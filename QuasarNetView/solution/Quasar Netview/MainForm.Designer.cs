/*
 * Criado por SharpDevelop.
 * Usuário: User
 * Data: 01/03/2021
 * Hora: 13:21
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace Quasar_Netview
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.TitleText = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ConnStress_Data = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.MinPing_Data = new System.Windows.Forms.Label();
			this.MaxPing_Data = new System.Windows.Forms.Label();
			this.MinPing_Text = new System.Windows.Forms.Label();
			this.MaxPing_Text = new System.Windows.Forms.Label();
			this.PublicIP_Data = new System.Windows.Forms.Label();
			this.PublicIP_Text = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.NetworkOptions = new System.Windows.Forms.Button();
			this.SaveLogButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.StressToleranceInfo = new System.Windows.Forms.Label();
			this.TracerouteInfo = new System.Windows.Forms.Label();
			this.JumpsBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.RequestsBox = new System.Windows.Forms.TextBox();
			this.StartTesting = new System.Windows.Forms.Button();
			this.AddressBox = new System.Windows.Forms.TextBox();
			this.LogDisplay = new System.Windows.Forms.RichTextBox();
			this.StressLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// TitleText
			// 
			this.TitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleText.Location = new System.Drawing.Point(13, 13);
			this.TitleText.Name = "TitleText";
			this.TitleText.Size = new System.Drawing.Size(638, 23);
			this.TitleText.TabIndex = 0;
			this.TitleText.Text = "QuasarNetMaster";
			this.TitleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.ConnStress_Data);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.MinPing_Data);
			this.groupBox1.Controls.Add(this.MaxPing_Data);
			this.groupBox1.Controls.Add(this.MinPing_Text);
			this.groupBox1.Controls.Add(this.MaxPing_Text);
			this.groupBox1.Controls.Add(this.PublicIP_Data);
			this.groupBox1.Controls.Add(this.PublicIP_Text);
			this.groupBox1.Location = new System.Drawing.Point(13, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(290, 116);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Connection Info";
			// 
			// ConnStress_Data
			// 
			this.ConnStress_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConnStress_Data.Location = new System.Drawing.Point(130, 89);
			this.ConnStress_Data.Name = "ConnStress_Data";
			this.ConnStress_Data.Size = new System.Drawing.Size(154, 23);
			this.ConnStress_Data.TabIndex = 7;
			this.ConnStress_Data.Text = "-";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(7, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Connection Stress:";
			// 
			// MinPing_Data
			// 
			this.MinPing_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinPing_Data.Location = new System.Drawing.Point(124, 66);
			this.MinPing_Data.Name = "MinPing_Data";
			this.MinPing_Data.Size = new System.Drawing.Size(160, 23);
			this.MinPing_Data.TabIndex = 5;
			this.MinPing_Data.Text = "-";
			// 
			// MaxPing_Data
			// 
			this.MaxPing_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaxPing_Data.Location = new System.Drawing.Point(124, 43);
			this.MaxPing_Data.Name = "MaxPing_Data";
			this.MaxPing_Data.Size = new System.Drawing.Size(160, 23);
			this.MaxPing_Data.TabIndex = 4;
			this.MaxPing_Data.Text = "-";
			// 
			// MinPing_Text
			// 
			this.MinPing_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MinPing_Text.Location = new System.Drawing.Point(7, 66);
			this.MinPing_Text.Name = "MinPing_Text";
			this.MinPing_Text.Size = new System.Drawing.Size(111, 23);
			this.MinPing_Text.TabIndex = 3;
			this.MinPing_Text.Text = "Minimum Latency:";
			// 
			// MaxPing_Text
			// 
			this.MaxPing_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaxPing_Text.Location = new System.Drawing.Point(7, 43);
			this.MaxPing_Text.Name = "MaxPing_Text";
			this.MaxPing_Text.Size = new System.Drawing.Size(111, 23);
			this.MaxPing_Text.TabIndex = 2;
			this.MaxPing_Text.Text = "Maximum Latency:";
			// 
			// PublicIP_Data
			// 
			this.PublicIP_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PublicIP_Data.Location = new System.Drawing.Point(124, 20);
			this.PublicIP_Data.Name = "PublicIP_Data";
			this.PublicIP_Data.Size = new System.Drawing.Size(160, 23);
			this.PublicIP_Data.TabIndex = 1;
			this.PublicIP_Data.Text = "-";
			// 
			// PublicIP_Text
			// 
			this.PublicIP_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PublicIP_Text.Location = new System.Drawing.Point(7, 20);
			this.PublicIP_Text.Name = "PublicIP_Text";
			this.PublicIP_Text.Size = new System.Drawing.Size(111, 23);
			this.PublicIP_Text.TabIndex = 0;
			this.PublicIP_Text.Text = "Public IP Address:";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.NetworkOptions);
			this.groupBox2.Controls.Add(this.SaveLogButton);
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.StressToleranceInfo);
			this.groupBox2.Controls.Add(this.TracerouteInfo);
			this.groupBox2.Controls.Add(this.JumpsBox);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.RequestsBox);
			this.groupBox2.Controls.Add(this.StartTesting);
			this.groupBox2.Controls.Add(this.AddressBox);
			this.groupBox2.Location = new System.Drawing.Point(309, 39);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(342, 139);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Connection Tests";
			// 
			// NetworkOptions
			// 
			this.NetworkOptions.Enabled = false;
			this.NetworkOptions.Location = new System.Drawing.Point(242, 68);
			this.NetworkOptions.Name = "NetworkOptions";
			this.NetworkOptions.Size = new System.Drawing.Size(94, 23);
			this.NetworkOptions.TabIndex = 15;
			this.NetworkOptions.Text = "NETWORK";
			this.NetworkOptions.UseVisualStyleBackColor = true;
			// 
			// SaveLogButton
			// 
			this.SaveLogButton.Enabled = false;
			this.SaveLogButton.Location = new System.Drawing.Point(242, 43);
			this.SaveLogButton.Name = "SaveLogButton";
			this.SaveLogButton.Size = new System.Drawing.Size(94, 23);
			this.SaveLogButton.TabIndex = 14;
			this.SaveLogButton.Text = "SAVE LOG";
			this.SaveLogButton.UseVisualStyleBackColor = true;
			this.SaveLogButton.Click += new System.EventHandler(this.SaveLogButtonClick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(162, 96);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(37, 20);
			this.textBox1.TabIndex = 13;
			this.textBox1.Text = "0";
			// 
			// StressToleranceInfo
			// 
			this.StressToleranceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StressToleranceInfo.Location = new System.Drawing.Point(7, 96);
			this.StressToleranceInfo.Name = "StressToleranceInfo";
			this.StressToleranceInfo.Size = new System.Drawing.Size(149, 20);
			this.StressToleranceInfo.TabIndex = 12;
			this.StressToleranceInfo.Text = "STRESS MAX TOLERANCE:";
			this.StressToleranceInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TracerouteInfo
			// 
			this.TracerouteInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TracerouteInfo.Location = new System.Drawing.Point(7, 70);
			this.TracerouteInfo.Name = "TracerouteInfo";
			this.TracerouteInfo.Size = new System.Drawing.Size(149, 20);
			this.TracerouteInfo.TabIndex = 11;
			this.TracerouteInfo.Text = "TRACEROUTE MAX LIMIT:";
			this.TracerouteInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// JumpsBox
			// 
			this.JumpsBox.Location = new System.Drawing.Point(162, 70);
			this.JumpsBox.Name = "JumpsBox";
			this.JumpsBox.Size = new System.Drawing.Size(37, 20);
			this.JumpsBox.TabIndex = 10;
			this.JumpsBox.Text = "5";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 20);
			this.label2.TabIndex = 8;
			this.label2.Text = "PACKET REQUESTS:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// RequestsBox
			// 
			this.RequestsBox.Location = new System.Drawing.Point(131, 47);
			this.RequestsBox.Name = "RequestsBox";
			this.RequestsBox.Size = new System.Drawing.Size(37, 20);
			this.RequestsBox.TabIndex = 2;
			this.RequestsBox.Text = "5";
			// 
			// StartTesting
			// 
			this.StartTesting.Location = new System.Drawing.Point(242, 19);
			this.StartTesting.Name = "StartTesting";
			this.StartTesting.Size = new System.Drawing.Size(94, 21);
			this.StartTesting.TabIndex = 1;
			this.StartTesting.Text = "START";
			this.StartTesting.UseVisualStyleBackColor = true;
			this.StartTesting.Click += new System.EventHandler(this.StartTestingClick);
			// 
			// AddressBox
			// 
			this.AddressBox.Location = new System.Drawing.Point(7, 20);
			this.AddressBox.Name = "AddressBox";
			this.AddressBox.Size = new System.Drawing.Size(229, 20);
			this.AddressBox.TabIndex = 0;
			this.AddressBox.Text = "localhost";
			// 
			// LogDisplay
			// 
			this.LogDisplay.Location = new System.Drawing.Point(13, 161);
			this.LogDisplay.Name = "LogDisplay";
			this.LogDisplay.ReadOnly = true;
			this.LogDisplay.Size = new System.Drawing.Size(290, 222);
			this.LogDisplay.TabIndex = 4;
			this.LogDisplay.Text = "";
			// 
			// StressLabel
			// 
			this.StressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StressLabel.Location = new System.Drawing.Point(315, 185);
			this.StressLabel.Name = "StressLabel";
			this.StressLabel.Size = new System.Drawing.Size(330, 23);
			this.StressLabel.TabIndex = 5;
			this.StressLabel.Text = "Connection Stress Values:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkGreen;
			this.label3.Location = new System.Drawing.Point(316, 208);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(336, 36);
			this.label3.TabIndex = 6;
			this.label3.Text = "  * 0 - 10 [GOOD CONNECTION, RARELY WILL NEED AN INTERVENTION]";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label4.Location = new System.Drawing.Point(316, 235);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(336, 36);
			this.label4.TabIndex = 7;
			this.label4.Text = " * 11 - 50 [ACCEPTABLE CONNECTION, OCCURS WHEN THE CONNECTION IS BEING USED NORMA" +
			"LLY]";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
			this.label5.Location = new System.Drawing.Point(316, 260);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(336, 36);
			this.label5.TabIndex = 8;
			this.label5.Text = " * 51 - 80 [UNSTABLE CONNECTION (1), OCCURS WHEN THE CONNECTION IS BEING USED WIT" +
			"H SOME WEIGHT (GAMES OR VIDEOS)]";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.OrangeRed;
			this.label6.Location = new System.Drawing.Point(316, 296);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(336, 36);
			this.label6.TabIndex = 9;
			this.label6.Text = " * 80 - 95 [UNSTABLE CONNECTION (2), <PROBLEM FLAG 1> OCCURS WHEN THE CONNECTION " +
			"IS BEING USED WITH SOME WEIGHT (GAMES, STREAMS OR VIDEOS)]";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.DarkRed;
			this.label7.Location = new System.Drawing.Point(316, 332);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(336, 36);
			this.label7.TabIndex = 10;
			this.label7.Text = " * 95 - 100 [UNACCEPTABLE CONNECTION, THE CONNECTION IS OUT OF AIR OR THERE IS SO" +
			"ME SERIOUS PROBLEM WITH IT]";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(663, 395);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.StressLabel);
			this.Controls.Add(this.LogDisplay);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.TitleText);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(679, 434);
			this.MinimumSize = new System.Drawing.Size(679, 434);
			this.Name = "MainForm";
			this.Text = "Quasar Netview";
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button NetworkOptions;
		private System.Windows.Forms.Button SaveLogButton;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label StressLabel;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label StressToleranceInfo;
		private System.Windows.Forms.RichTextBox LogDisplay;
		private System.Windows.Forms.TextBox JumpsBox;
		private System.Windows.Forms.Label TracerouteInfo;
		private System.Windows.Forms.Button StartTesting;
		private System.Windows.Forms.TextBox RequestsBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox AddressBox;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label ConnStress_Data;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label MaxPing_Data;
		private System.Windows.Forms.Label MinPing_Data;
		private System.Windows.Forms.Label MaxPing_Text;
		private System.Windows.Forms.Label MinPing_Text;
		private System.Windows.Forms.Label PublicIP_Data;
		private System.Windows.Forms.Label PublicIP_Text;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label TitleText;
	}
}
