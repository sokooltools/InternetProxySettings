namespace InternetProxySettings
{
	partial class ProxySettingsDialog
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtHttp = new System.Windows.Forms.TextBox();
			this.lblExc1 = new System.Windows.Forms.Label();
			this.txtHttpPort = new System.Windows.Forms.TextBox();
			this.grpServers = new System.Windows.Forms.GroupBox();
			this.chkSameProxyForAll = new System.Windows.Forms.CheckBox();
			this.txtSocksPort = new System.Windows.Forms.TextBox();
			this.lblSocks = new System.Windows.Forms.Label();
			this.txtFtpPort = new System.Windows.Forms.TextBox();
			this.lblFtp = new System.Windows.Forms.Label();
			this.txtSecurePort = new System.Windows.Forms.TextBox();
			this.txtSocks = new System.Windows.Forms.TextBox();
			this.lblSecure = new System.Windows.Forms.Label();
			this.txtFtp = new System.Windows.Forms.TextBox();
			this.lblExc4 = new System.Windows.Forms.Label();
			this.txtSecure = new System.Windows.Forms.TextBox();
			this.lblExc3 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblHttp = new System.Windows.Forms.Label();
			this.lblExc2 = new System.Windows.Forms.Label();
			this.grpExceptions = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtProxyOverride = new System.Windows.Forms.TextBox();
			this.grpServers.SuspendLayout();
			this.grpExceptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(314, 352);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(233, 352);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(55, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Type";
			// 
			// txtHttp
			// 
			this.txtHttp.Location = new System.Drawing.Point(100, 51);
			this.txtHttp.Name = "txtHttp";
			this.txtHttp.Size = new System.Drawing.Size(197, 20);
			this.txtHttp.TabIndex = 5;
			// 
			// lblExc1
			// 
			this.lblExc1.AutoSize = true;
			this.lblExc1.Location = new System.Drawing.Point(300, 54);
			this.lblExc1.Name = "lblExc1";
			this.lblExc1.Size = new System.Drawing.Size(10, 13);
			this.lblExc1.TabIndex = 4;
			this.lblExc1.Text = ":";
			// 
			// txtHttpPort
			// 
			this.txtHttpPort.Location = new System.Drawing.Point(316, 51);
			this.txtHttpPort.Name = "txtHttpPort";
			this.txtHttpPort.Size = new System.Drawing.Size(43, 20);
			this.txtHttpPort.TabIndex = 5;
			// 
			// grpServers
			// 
			this.grpServers.Controls.Add(this.chkSameProxyForAll);
			this.grpServers.Controls.Add(this.txtSocksPort);
			this.grpServers.Controls.Add(this.lblSocks);
			this.grpServers.Controls.Add(this.txtFtpPort);
			this.grpServers.Controls.Add(this.lblFtp);
			this.grpServers.Controls.Add(this.txtSecurePort);
			this.grpServers.Controls.Add(this.txtSocks);
			this.grpServers.Controls.Add(this.lblSecure);
			this.grpServers.Controls.Add(this.txtFtp);
			this.grpServers.Controls.Add(this.txtHttpPort);
			this.grpServers.Controls.Add(this.lblExc4);
			this.grpServers.Controls.Add(this.txtSecure);
			this.grpServers.Controls.Add(this.lblExc3);
			this.grpServers.Controls.Add(this.label3);
			this.grpServers.Controls.Add(this.label2);
			this.grpServers.Controls.Add(this.lblHttp);
			this.grpServers.Controls.Add(this.label1);
			this.grpServers.Controls.Add(this.lblExc2);
			this.grpServers.Controls.Add(this.txtHttp);
			this.grpServers.Controls.Add(this.lblExc1);
			this.grpServers.Location = new System.Drawing.Point(12, 12);
			this.grpServers.Name = "grpServers";
			this.grpServers.Size = new System.Drawing.Size(376, 202);
			this.grpServers.TabIndex = 6;
			this.grpServers.TabStop = false;
			this.grpServers.Text = "Servers";
			// 
			// chkSameProxyForAll
			// 
			this.chkSameProxyForAll.AutoSize = true;
			this.chkSameProxyForAll.Enabled = false;
			this.chkSameProxyForAll.Location = new System.Drawing.Point(57, 163);
			this.chkSameProxyForAll.Name = "chkSameProxyForAll";
			this.chkSameProxyForAll.Size = new System.Drawing.Size(225, 17);
			this.chkSameProxyForAll.TabIndex = 6;
			this.chkSameProxyForAll.Text = "Use the same proxy server for all protocols";
			this.chkSameProxyForAll.UseVisualStyleBackColor = true;
			this.chkSameProxyForAll.CheckedChanged += new System.EventHandler(this.chkSameProxyForAll_CheckedChanged);
			// 
			// txtSocksPort
			// 
			this.txtSocksPort.Location = new System.Drawing.Point(316, 129);
			this.txtSocksPort.Name = "txtSocksPort";
			this.txtSocksPort.Size = new System.Drawing.Size(43, 20);
			this.txtSocksPort.TabIndex = 5;
			// 
			// lblSocks
			// 
			this.lblSocks.AutoSize = true;
			this.lblSocks.Location = new System.Drawing.Point(54, 132);
			this.lblSocks.Name = "lblSocks";
			this.lblSocks.Size = new System.Drawing.Size(40, 13);
			this.lblSocks.TabIndex = 4;
			this.lblSocks.Text = "Socks:";
			// 
			// txtFtpPort
			// 
			this.txtFtpPort.Location = new System.Drawing.Point(316, 103);
			this.txtFtpPort.Name = "txtFtpPort";
			this.txtFtpPort.Size = new System.Drawing.Size(43, 20);
			this.txtFtpPort.TabIndex = 5;
			// 
			// lblFtp
			// 
			this.lblFtp.AutoSize = true;
			this.lblFtp.Location = new System.Drawing.Point(54, 106);
			this.lblFtp.Name = "lblFtp";
			this.lblFtp.Size = new System.Drawing.Size(30, 13);
			this.lblFtp.TabIndex = 4;
			this.lblFtp.Text = "FTP:";
			// 
			// txtSecurePort
			// 
			this.txtSecurePort.Location = new System.Drawing.Point(316, 77);
			this.txtSecurePort.Name = "txtSecurePort";
			this.txtSecurePort.Size = new System.Drawing.Size(43, 20);
			this.txtSecurePort.TabIndex = 5;
			// 
			// txtSocks
			// 
			this.txtSocks.Location = new System.Drawing.Point(100, 129);
			this.txtSocks.Name = "txtSocks";
			this.txtSocks.Size = new System.Drawing.Size(197, 20);
			this.txtSocks.TabIndex = 5;
			// 
			// lblSecure
			// 
			this.lblSecure.AutoSize = true;
			this.lblSecure.Location = new System.Drawing.Point(54, 80);
			this.lblSecure.Name = "lblSecure";
			this.lblSecure.Size = new System.Drawing.Size(44, 13);
			this.lblSecure.TabIndex = 4;
			this.lblSecure.Text = "Secure:";
			// 
			// txtFtp
			// 
			this.txtFtp.Location = new System.Drawing.Point(100, 103);
			this.txtFtp.Name = "txtFtp";
			this.txtFtp.Size = new System.Drawing.Size(197, 20);
			this.txtFtp.TabIndex = 5;
			// 
			// lblExc4
			// 
			this.lblExc4.AutoSize = true;
			this.lblExc4.Location = new System.Drawing.Point(300, 132);
			this.lblExc4.Name = "lblExc4";
			this.lblExc4.Size = new System.Drawing.Size(10, 13);
			this.lblExc4.TabIndex = 4;
			this.lblExc4.Text = ":";
			// 
			// txtSecure
			// 
			this.txtSecure.Location = new System.Drawing.Point(100, 77);
			this.txtSecure.Name = "txtSecure";
			this.txtSecure.Size = new System.Drawing.Size(197, 20);
			this.txtSecure.TabIndex = 5;
			// 
			// lblExc3
			// 
			this.lblExc3.AutoSize = true;
			this.lblExc3.Location = new System.Drawing.Point(300, 106);
			this.lblExc3.Name = "lblExc3";
			this.lblExc3.Size = new System.Drawing.Size(10, 13);
			this.lblExc3.TabIndex = 4;
			this.lblExc3.Text = ":";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(313, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Port";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(97, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Proxy address to use";
			// 
			// lblHttp
			// 
			this.lblHttp.AutoSize = true;
			this.lblHttp.Location = new System.Drawing.Point(55, 54);
			this.lblHttp.Name = "lblHttp";
			this.lblHttp.Size = new System.Drawing.Size(39, 13);
			this.lblHttp.TabIndex = 4;
			this.lblHttp.Text = "HTTP:";
			// 
			// lblExc2
			// 
			this.lblExc2.AutoSize = true;
			this.lblExc2.Location = new System.Drawing.Point(300, 80);
			this.lblExc2.Name = "lblExc2";
			this.lblExc2.Size = new System.Drawing.Size(10, 13);
			this.lblExc2.TabIndex = 4;
			this.lblExc2.Text = ":";
			// 
			// grpExceptions
			// 
			this.grpExceptions.Controls.Add(this.label5);
			this.grpExceptions.Controls.Add(this.label4);
			this.grpExceptions.Controls.Add(this.txtProxyOverride);
			this.grpExceptions.Location = new System.Drawing.Point(13, 221);
			this.grpExceptions.Name = "grpExceptions";
			this.grpExceptions.Size = new System.Drawing.Size(375, 121);
			this.grpExceptions.TabIndex = 7;
			this.grpExceptions.TabStop = false;
			this.grpExceptions.Text = "Exceptions";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(54, 92);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(189, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Use semicolons ( ; ) to separate entries";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(54, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(259, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Do not use proxy server for addresses beginning with:";
			// 
			// txtProxyOverride
			// 
			this.txtProxyOverride.Location = new System.Drawing.Point(57, 45);
			this.txtProxyOverride.Multiline = true;
			this.txtProxyOverride.Name = "txtProxyOverride";
			this.txtProxyOverride.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtProxyOverride.Size = new System.Drawing.Size(301, 40);
			this.txtProxyOverride.TabIndex = 5;
			// 
			// ProxySettingsDialog
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(401, 383);
			this.Controls.Add(this.grpExceptions);
			this.Controls.Add(this.grpServers);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ProxySettingsDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Proxy Settings";
			this.TopMost = true;
			this.grpServers.ResumeLayout(false);
			this.grpServers.PerformLayout();
			this.grpExceptions.ResumeLayout(false);
			this.grpExceptions.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		internal System.Windows.Forms.CheckBox chkSameProxyForAll;
		private System.Windows.Forms.GroupBox grpExceptions;
		private System.Windows.Forms.GroupBox grpServers;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblExc1;
		private System.Windows.Forms.Label lblExc2;
		private System.Windows.Forms.Label lblExc3;
		private System.Windows.Forms.Label lblExc4;
		private System.Windows.Forms.Label lblFtp;
		private System.Windows.Forms.Label lblHttp;
		private System.Windows.Forms.Label lblSecure;
		private System.Windows.Forms.Label lblSocks;
		internal System.Windows.Forms.TextBox txtProxyOverride;
		internal System.Windows.Forms.TextBox txtFtp;
		internal System.Windows.Forms.TextBox txtFtpPort;
		internal System.Windows.Forms.TextBox txtHttp;
		internal System.Windows.Forms.TextBox txtHttpPort;
		internal System.Windows.Forms.TextBox txtSecure;
		internal System.Windows.Forms.TextBox txtSecurePort;
		internal System.Windows.Forms.TextBox txtSocks;
		internal System.Windows.Forms.TextBox txtSocksPort;
	}
}