/*
QUASAR NETMASTER [1.0]
>>> Application developed by Kayky Vitor Cruz and licensed under GNU General Public License, version 3(GPLv3):

>> The source code must be public whenever a distribution of the software is made.That is, if you launch a product
>> that is a modification of a project of this type, you need to make your code public as well. Modifications to 
>> the software must be released under the same license. Changes made to the source code must be documented.
>> If patented material is used in creating the software, it grants users the right to use it.
>> If the user sues anyone using the patented material, they will lose the right to use the software.
 */
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace Quasar_Netview
{
	public partial class MainForm : Form
	{
		//APPLICATION INFORMATION VARIABLES
		public string productBuild = "Build Mar2021";
		public string productClassification = "Beta Release";
		public string productVersion = "1.0.0";
		public int mainProgressBarPoint = 0;
		//API ACESSING VARIABLES
		public string ipObtainableUrl = "https://api.ipify.org/";
		//IMPORTANT OUTPUT VARIABLES
		public List <string> traceRouteLog = new List<string>();
		public List <string> finalLog = new List<string>();
		//WEB SERVICES VARIABLES
		public string userPublicIp;
        public string serverToTest;
        public string dnsAdress_1;
        public string dnsAdress_2;
		//DATA ANALYSIS VARIABLES
		public float dnsLatency_1;
		public float dnsLatency_2;
		public float maxLastOperationLatency;
		public float minLastOperationLatency;
		public float lastOperationPacketLoss;
		public float lastOperationTimeToLive;
		public int lastOperationStressLevel = -1;
		
		public MainForm()
		{
			InitializeComponent();
           
			//CORE AREA
			mainInitializationMethods();
			//DATA ALLOCATION AREA
			getCurrentPublicInternetProtocol();
			getLatency(userPublicIp, 5);
			determineBasicInformation();
			//developerTestFunctions(1);
		}
		
		public void mainInitializationMethods() {
		     //CHECK IF IMPORTANT FOLDERS AND/OR FILES EXIST AND CREATE/DELETE IF NECESSARY
		     if (!Directory.Exists("./scripts/")) { Directory.CreateDirectory("./scripts/"); }
		     if (File.Exists("./scripts/TraceRoute_Default.cmd")) { File.Delete("./scripts/TraceRoute_Default.cmd"); }
		     if (File.Exists("./scripts/TraceRoute_Default.tmp")) { File.Delete("./scripts/TraceRoute_Default.tmp"); }
		}
		
		public void determineBasicInformation() {
			//UPDATE USER INTERFACE INFORMATIONS
			PublicIP_Data.Text = userPublicIp;
			TitleText.Text = "Quasar Netview " + productVersion + " " + productClassification + " " + productBuild;
			MinPing_Data.Text = minLastOperationLatency.ToString() + "ms";
			MaxPing_Data.Text = maxLastOperationLatency.ToString() + "ms";
			ConnStress_Data.Text = lastOperationStressLevel.ToString();
			if (lastOperationStressLevel == -1) { ConnStress_Data.Text = "Undefined"; }
		}
		
		public void logGenerate() {
			LogDisplay.Text = "";
			LogDisplay.Text = "# QuasarNetView " + productVersion + " " + productBuild;
			LogDisplay.Text = LogDisplay.Text + Environment.NewLine + "#";
			LogDisplay.Text = LogDisplay.Text + Environment.NewLine + "# Log generated in " + DateTime.Now;
			LogDisplay.Text = LogDisplay.Text + Environment.NewLine + "#";
			LogDisplay.Text = LogDisplay.Text + Environment.NewLine + string.Join("", finalLog);
			LogDisplay.Text = LogDisplay.Text + Environment.NewLine + "# Traceroute Log:";
			
			foreach(string line in traceRouteLog) {
				LogDisplay.Text = LogDisplay.Text + Environment.NewLine + line;
			}
		}
		
		public void developerTestFunctions(int functionToTest) {
			/*-- DEVELOPER FUNCTION TO TEST ANOTHER FUNCTIONS
			 * >> [1] Log
			 * 
			 */
			
			if (functionToTest == 1) { MessageBox.Show(string.Join("", finalLog)); }
			
		}
		
		public void networkStressCalculator() {
			 /* CALCULATE THE NETWORK STRESS VALUE BASED ON CONNECTION VALUES
			  * 0 - 10 [GOOD CONNECTION, RARELY WILL NEED AN INTERVENTION]
			  * 11 - 50 [ACCEPTABLE CONNECTION, OCCURS WHEN THE CONNECTION IS BEING USED NORMALLY]
			  * 51 - 80 [UNSTABLE CONNECTION (1), OCCURS WHEN THE CONNECTION IS BEING USED WITH SOME WEIGHT (GAMES OR VIDEOS)]
			  * 80 - 95 [UNSTABLE CONNECTION (2), <PROBLEM FLAG 1> OCCURS WHEN THE CONNECTION IS BEING USED WITH SOME WEIGHT (GAMES, STREAMS OR VIDEOS)]
			  * 95 - 100 [UNACCEPTABLE CONNECTION, THE CONNECTION IS OUT OF AIR OR THERE IS SOME SERIOUS PROBLEM WITH IT]
			  * 
			    */
			   
			  /* STRESS TEMP VALUE */ float _ntwrkS = 0;
			  float mediumLatency = (minLastOperationLatency + maxLastOperationLatency) / 2;
			  float _latencyToStress = mediumLatency / 10;
			  
			  // -- SUPERFICIAL TEXT-BASED ANALYSIS NETWORK TESTS -- [TRACEROUTE]
			  
			  float _traceRouteToStress = 0;
			  
			  foreach (string fail_route in traceRouteLog) {
		  	   if (fail_route.Contains("*")) { _traceRouteToStress++; }
			  }
			  
			  
			  
			  
			  // -- DNS LATENCY TO STRESS --
			  
			  float _dnsLatencyToStress = (dnsLatency_1 + dnsLatency_2) / 2;
			 
			  // FINAL
			  _ntwrkS = _latencyToStress + _dnsLatencyToStress;
			  lastOperationStressLevel = (int)_ntwrkS;
		}

		public void startNetworkAnalysisOperation(int analysisType) {
			/*--START THE MAIN FUNCTION OF THE APPLICATION - AN CONNECTION FULL ANALYSIS WITH RESOLUTION STEPS
			 * analysis types:
			 * 1 - Ping Based Simple Process: Return [Latency], [Innacurate Stress Level], [Resolution Steps]
			 * 2 - Trace Route Based Process: Return [Latency], [Accurate Stress Level], [Resolution Steps]
			 * 3 - Full Process: Return [Latency], [Accurate Stress Level], [Resolution Steps], [Connection Debug Process Mistakes]
			 * 
			*/
			finalLog = new List<string>();
			if(analysisType == 3) {
				getLatency(AddressBox.Text, int.Parse(RequestsBox.Text));
				getTraceRouteFromExternalScripts(AddressBox.Text, int.Parse(JumpsBox.Text));
				networkStressCalculator();
			    DNSUtil();
			    getDNSLatency();
			    determineBasicInformation();
			}
		}
		
		public void getTraceRouteFromExternalScripts(string webServer, int requestLength) {
			try {
			File.WriteAllText("./scripts/TraceRoute_Default.cmd", "tracert -h " + requestLength + " " + webServer + " >> ./scripts/TraceRoute_Default.tmp");
			
			Process proc = new Process();
			proc.StartInfo.UseShellExecute = false;
			proc.StartInfo.CreateNoWindow = true;
			proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			proc.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "/scripts/TraceRoute_Default.cmd";
			proc.StartInfo.RedirectStandardError = false;
			proc.StartInfo.RedirectStandardOutput = false;
			proc.StartInfo.UseShellExecute = false;
			proc.StartInfo.CreateNoWindow = true;
			proc.Start();
			proc.WaitForExit();
			
			//---TRACE ROUTE LOG REGISTER [getTraceRouteFromExternalScripts.Success]
			traceRouteLog = File.ReadAllLines("./scripts/TraceRoute_Default.tmp").ToList();
			}
			catch {
			//---TRACE ROUTE LOG REGISTER [getTraceRouteFromExternalScripts.Fail]
			traceRouteLog = null;
			}
			finally {
				
			}
			
		}
		
		public void getLatency(string webServer, int requestLength) {
			/* START PROCESS OF GETTING THE LATENCY USING [webServer] TO GET THE ADDRESS OBJECTIVE
			 * AND [requestLength] TO GET HOW MUCH REQUESTS THE APPLICATION WILL MAKE.
			 */

			  
			try {
			List <long> requestResults = new List<long>();
			if (requestLength != 0) {
			
			for(int maxRequests = requestLength; maxRequests > 0; maxRequests -= 1) {
                Ping pingSender = new Ping();
                PingReply reply = pingSender.Send(webServer);
                requestResults.Add(reply.RoundtripTime);
                //---LOG REGISTER [getLatency.PartialSuccess]
			    finalLog.Add("#getLatencyRoundTripTime = " + reply.RoundtripTime);
			}
				maxLastOperationLatency = requestResults.Max();
				minLastOperationLatency = requestResults.Min();
			//---LOG REGISTER [getLatency.Success]
			finalLog.Add("#getLatencyRoundTripTime_MaxValue = " + maxLastOperationLatency);
			finalLog.Add("#getLatencyRoundTripTime_MinValue = " + minLastOperationLatency);
			}
			}
			catch {
			//---LOG REGISTER [getLatency.Error]
			maxLastOperationLatency = 0;
			minLastOperationLatency = 0;
			finalLog.Add(Environment.NewLine + "#getLatencyRoundTripTime = [Error] An error was detected while trying to get Internet Latency.");
			    
			}
			finally {
				
			}
		}
		
		public void getCurrentPublicInternetProtocol() {
			 //--GET THE PUBLIC USER INTERNET PROTOCOL USING A WEB CLIENT TO READ IPFY.ORG PLAIN TEXT API
			  try {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead(ipObtainableUrl);
                StreamReader reader = new StreamReader(stream);
                String content = reader.ReadToEnd();
                userPublicIp = content;
                //---LOG REGISTER [getCurrentInternetProtocol.Success]
                finalLog.Add("#getCurrentPublicInternetProtocol = " + content);
                
              } 
			 catch {
			 	userPublicIp = "[Error]";
			 	//---LOG REGISTER [getCurrentInternetProtocol.Error]
			 	finalLog.Add(Environment.NewLine + "#getCurrentInternetProtocol = [Error] An error was detected while trying to access the IPFY.ORG API.");
			    
			 }
			 finally {
			 	/*---DEVELOPMENT INFORMATION TESTS
			 	MessageBox.Show(string.Join("", finalLog));
			    */
			 }
		}
		public void getDNSLatency() {
			//--GET THE DNS LATENCY OF DNSUtil FUNCTION
			try {
			if(dnsAdress_1 != "" && dnsAdress_2 != "") {
				
				Ping pingSender_toDNS1 = new Ping();
                PingReply reply_toDNS1 = pingSender_toDNS1.Send(dnsAdress_1);
                dnsLatency_1 = reply_toDNS1.RoundtripTime;
                
                Ping pingSender_toDNS2 = new Ping();
                PingReply reply_toDNS2 = pingSender_toDNS2.Send(dnsAdress_2);
                dnsLatency_2 = reply_toDNS2.RoundtripTime;
				
			}
			//---LOG REGISTER [getDNSLatency.Success]
			finalLog.Add(Environment.NewLine + "#DNSUTIL>>GetLatency, = DNS Server Addresses Latency obtained from the system.");
			
			}
			catch {
			//---LOG REGISTER [DNSUtil.Fail]
			finalLog.Add(Environment.NewLine + "#DNSUTIL>>GetLatency, = [Error] DNS Server Addresses Latency can't be obtained from the system.");		
				
			}
			finally {
				
			}
		}
		public void DNSUtil() {
			//--GET THE DNS ADDRESSES CONFIGURED IN THE MACHINE
			try { 
			dnsAdress_1 = "";
			dnsAdress_2 = "";
			NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface networkInterface in networkInterfaces)
            {
                if (networkInterface.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties ipProperties = networkInterface.GetIPProperties();
                    IPAddressCollection dnsAddresses = ipProperties.DnsAddresses;

                    foreach (IPAddress dnsAdress in dnsAddresses)
                    {
                    	if(dnsAdress_1 == "") {
                    		dnsAdress_1 = dnsAdress.ToString();
                    	}
                    	if(dnsAdress_2 == "") {
                    		dnsAdress_2 = dnsAdress.ToString();
                    	}
                    }
                }
            }
            //---LOG REGISTER [DNSUtil.Success]
			finalLog.Add(Environment.NewLine + "#DNSUTIL, = DNS Server Addresses obtained from the system.");
			}
			catch {
			//---LOG REGISTER [DNSUtil.Fail]
			finalLog.Add(Environment.NewLine + "#DNSUTIL, = [Error] DNS Server Addresses can't be obtained from the system.");		
			}
			finally {
				
			}
		}
		
		void StartTestingClick(object sender, EventArgs e)
		{
			mainInitializationMethods();
			startNetworkAnalysisOperation(3);
			logGenerate();
			SaveLogButton.Enabled = true;
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void SaveLogButtonClick(object sender, EventArgs e)
		{
    SaveFileDialog saveFileDialog1 = new SaveFileDialog();      
    saveFileDialog1.InitialDirectory = @"./logs/";      
    saveFileDialog1.Title = "QUASARNETVIEW - SAVELOG";      
    saveFileDialog1.CheckPathExists = true;      
    saveFileDialog1.DefaultExt = "log";      
    saveFileDialog1.Filter = "Log files (*.log)|*.txt|All files (*.*)|*.*";      
    saveFileDialog1.FilterIndex = 2;      
    saveFileDialog1.RestoreDirectory = true;      
    if (saveFileDialog1.ShowDialog() == DialogResult.OK) {      
    	File.WriteAllText(saveFileDialog1.FileName, LogDisplay.Text);
    }      			
		}
		}
		
		}

