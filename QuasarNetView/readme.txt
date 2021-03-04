=================================
QUASAR NETMASTER [1.0]
>>> Application developed by Kayky Vitor Cruz and licensed under GNU General Public License, version 3(GPLv3):

>> The source code must be public whenever a distribution of the software is made.That is, if you launch a product
>> that is a modification of a project of this type, you need to make your code public as well. Modifications to 
>> the software must be released under the same license. Changes made to the source code must be documented.
>> If patented material is used in creating the software, it grants users the right to use it.
>> If the user sues anyone using the patented material, they will lose the right to use the software.

This application was created with the
intention of joining simple network analysis
tools and is currently under development.

=================================

>> FUNCTIONS OVERVIEW

>>> Latency-based Ping Process [Main]:

Performs latency test for the target server, 
obtaining the final operation time for each 
request in milliseconds.

<!> DevNote:

In Code function: public void getLatency(string webServer, int requestLength).

[webServer] The main target of an operation. ex: www.google.com;
wrong ex: http://www.google.com/404.

[requestLength] The number of requests to be made to the target 
server (will be exposed in the main log).

>>> Traceroute + Test connection/failure estimative

Traces the route of the connection to the target server and analyzes
the result from the failures to determine the state of the connection.

<!> DevNote: public void getTraceRouteFromExternalScripts(string webServer, int requestLength).

[webServer] The main target of an operation. ex: www.google.com;
wrong ex: http://www.google.com/404.

[requestLength] The max number of loops for the operation.

>>> DNS Find + DNS Test

Gets and tests DNS servers configured to be used on the system.

<!> DevNote: public void DNSUtil() -> Get the DNS Servers | getDNSLatency() -> Test the DNS Servers.

>>> NETWORK STRESS CALCULATOR

It uses the values obtained from the other functions of the program to 
calculate a value called "Connection Stress" that classifies your machine's 
connection to the target.

<!> DevNote: networkStressCalculator().

Data analysis variables:
		public float dnsLatency_1;
		public float dnsLatency_2;
		public float maxLastOperationLatency;
		public float minLastOperationLatency;
		public float lastOperationPacketLoss;
		public float lastOperationTimeToLive;
		public int lastOperationStressLevel = -1;

>>> SHOW THE MAIN LOG IN A MESSAGEBOX <DEV>

<!> DevNote: developerTestFunctions(int functionToTest).

[functionToTest] Select the function to test: 1- Log

>> LOG

Log output variables:
		public List <string> traceRouteLog = new List<string>();
		public List <string> finalLog = new List<string>();

>> API 

API Access variables:
		public string ipObtainableUrl = "https://api.ipify.org/"; *USING IPFY.ORG TO GET PUBLIC USER IP

>> CORE

Core variables:
		public string userPublicIp;
        	public string serverToTest; --> Target application address (Button START)
        	public string dnsAdress_1;
        	public string dnsAdress_2;
		

