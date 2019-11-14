namespace InternetProxySettings
{
	partial class MainForm
	{
		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Required designer variable.
		/// </summary>
		//------------------------------------------------------------------------------------------------------------------------
		private System.ComponentModel.IContainer components = null;

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		//------------------------------------------------------------------------------------------------------------------------
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		//.................................................................................................................................

		#region Windows Form Designer generated code

		//------------------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		//------------------------------------------------------------------------------------------------------------------------
		private void InitializeComponent()
		{
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.grpProxyServer = new System.Windows.Forms.GroupBox();
			this.chkIsLocalBypassed = new System.Windows.Forms.CheckBox();
			this.txtProxyPort = new System.Windows.Forms.TextBox();
			this.btnAdvanced = new System.Windows.Forms.Button();
			this.lblProxyPort = new System.Windows.Forms.Label();
			this.txtProxyHost = new System.Windows.Forms.TextBox();
			this.lblProxyHost = new System.Windows.Forms.Label();
			this.chkIsEnabled = new System.Windows.Forms.CheckBox();
			this.grpProxyServer.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(217, 168);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(298, 168);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// grpProxyServer
			// 
			this.grpProxyServer.Controls.Add(this.chkIsLocalBypassed);
			this.grpProxyServer.Controls.Add(this.txtProxyPort);
			this.grpProxyServer.Controls.Add(this.btnAdvanced);
			this.grpProxyServer.Controls.Add(this.lblProxyPort);
			this.grpProxyServer.Controls.Add(this.txtProxyHost);
			this.grpProxyServer.Controls.Add(this.lblProxyHost);
			this.grpProxyServer.Controls.Add(this.chkIsEnabled);
			this.grpProxyServer.Location = new System.Drawing.Point(12, 13);
			this.grpProxyServer.Name = "grpProxyServer";
			this.grpProxyServer.Size = new System.Drawing.Size(362, 141);
			this.grpProxyServer.TabIndex = 2;
			this.grpProxyServer.TabStop = false;
			this.grpProxyServer.Text = "Proxy Server";
			// 
			// chkIsLocalBypassed
			// 
			this.chkIsLocalBypassed.AutoSize = true;
			this.chkIsLocalBypassed.Location = new System.Drawing.Point(20, 108);
			this.chkIsLocalBypassed.Name = "chkIsLocalBypassed";
			this.chkIsLocalBypassed.Size = new System.Drawing.Size(211, 17);
			this.chkIsLocalBypassed.TabIndex = 6;
			this.chkIsLocalBypassed.Text = "Bypass proxy server for local addresses";
			this.chkIsLocalBypassed.UseVisualStyleBackColor = true;
			// 
			// txtProxyPort
			// 
			this.txtProxyPort.Location = new System.Drawing.Point(202, 73);
			this.txtProxyPort.Name = "txtProxyPort";
			this.txtProxyPort.Size = new System.Drawing.Size(68, 20);
			this.txtProxyPort.TabIndex = 4;
			// 
			// btnAdvanced
			// 
			this.btnAdvanced.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnAdvanced.Location = new System.Drawing.Point(276, 71);
			this.btnAdvanced.Name = "btnAdvanced";
			this.btnAdvanced.Size = new System.Drawing.Size(75, 23);
			this.btnAdvanced.TabIndex = 5;
			this.btnAdvanced.Text = "Advanced";
			this.btnAdvanced.UseVisualStyleBackColor = true;
			this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
			// 
			// lblProxyPort
			// 
			this.lblProxyPort.AutoSize = true;
			this.lblProxyPort.Location = new System.Drawing.Point(167, 76);
			this.lblProxyPort.Name = "lblProxyPort";
			this.lblProxyPort.Size = new System.Drawing.Size(29, 13);
			this.lblProxyPort.TabIndex = 3;
			this.lblProxyPort.Text = "Port:";
			// 
			// txtProxyHost
			// 
			this.txtProxyHost.Location = new System.Drawing.Point(73, 73);
			this.txtProxyHost.Name = "txtProxyHost";
			this.txtProxyHost.Size = new System.Drawing.Size(86, 20);
			this.txtProxyHost.TabIndex = 2;
			// 
			// lblProxyHost
			// 
			this.lblProxyHost.AutoSize = true;
			this.lblProxyHost.Location = new System.Drawing.Point(21, 76);
			this.lblProxyHost.Name = "lblProxyHost";
			this.lblProxyHost.Size = new System.Drawing.Size(48, 13);
			this.lblProxyHost.TabIndex = 1;
			this.lblProxyHost.Text = "Address:";
			// 
			// chkIsEnabled
			// 
			this.chkIsEnabled.Checked = true;
			this.chkIsEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkIsEnabled.Location = new System.Drawing.Point(7, 30);
			this.chkIsEnabled.Name = "chkIsEnabled";
			this.chkIsEnabled.Size = new System.Drawing.Size(330, 34);
			this.chkIsEnabled.TabIndex = 0;
			this.chkIsEnabled.Text = "Use a proxy server for your LAN (These settings will not apply to dial-up or VPN " +
    "connections).";
			this.chkIsEnabled.UseVisualStyleBackColor = true;
			this.chkIsEnabled.CheckStateChanged += new System.EventHandler(this.chkIsEnabled_CheckStateChanged);
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(386, 203);
			this.Controls.Add(this.grpProxyServer);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Local Area Network (LAN) Settings";
			this.TopMost = true;
			this.grpProxyServer.ResumeLayout(false);
			this.grpProxyServer.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.GroupBox grpProxyServer;
		private System.Windows.Forms.CheckBox chkIsLocalBypassed;
		private System.Windows.Forms.TextBox txtProxyPort;
		private System.Windows.Forms.Button btnAdvanced;
		private System.Windows.Forms.Label lblProxyPort;
		private System.Windows.Forms.TextBox txtProxyHost;
		private System.Windows.Forms.Label lblProxyHost;
		private System.Windows.Forms.CheckBox chkIsEnabled;
	}
}

