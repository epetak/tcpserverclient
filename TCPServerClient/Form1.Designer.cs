namespace TCPServerClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBoxMessages = new System.Windows.Forms.TextBox();
            this.groupBoxServer = new System.Windows.Forms.GroupBox();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.txtBoxPortClient = new System.Windows.Forms.TextBox();
            this.txtBoxIpAddressClient = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.btnChangePresets = new System.Windows.Forms.Button();
            this.userIpAddress = new System.Windows.Forms.Label();
            this.userPort = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.lblIpAddressUser = new System.Windows.Forms.Label();
            this.lblPortUser = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxUserMessage = new System.Windows.Forms.TextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.groupBoxServer.SuspendLayout();
            this.groupBoxClient.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxMessages
            // 
            this.txtBoxMessages.Location = new System.Drawing.Point(12, 12);
            this.txtBoxMessages.Multiline = true;
            this.txtBoxMessages.Name = "txtBoxMessages";
            this.txtBoxMessages.ReadOnly = true;
            this.txtBoxMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxMessages.Size = new System.Drawing.Size(274, 362);
            this.txtBoxMessages.TabIndex = 0;
            this.txtBoxMessages.TabStop = false;
            // 
            // groupBoxServer
            // 
            this.groupBoxServer.Controls.Add(this.btnStopServer);
            this.groupBoxServer.Controls.Add(this.btnStartServer);
            this.groupBoxServer.Location = new System.Drawing.Point(292, 12);
            this.groupBoxServer.Name = "groupBoxServer";
            this.groupBoxServer.Size = new System.Drawing.Size(207, 71);
            this.groupBoxServer.TabIndex = 1;
            this.groupBoxServer.TabStop = false;
            this.groupBoxServer.Text = "Server";
            // 
            // btnStopServer
            // 
            this.btnStopServer.Enabled = false;
            this.btnStopServer.Location = new System.Drawing.Point(116, 22);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(85, 34);
            this.btnStopServer.TabIndex = 1;
            this.btnStopServer.Text = "Stop server";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(6, 22);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(85, 34);
            this.btnStartServer.TabIndex = 0;
            this.btnStartServer.Text = "Start server";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.txtBoxPortClient);
            this.groupBoxClient.Controls.Add(this.txtBoxIpAddressClient);
            this.groupBoxClient.Controls.Add(this.lblPort);
            this.groupBoxClient.Controls.Add(this.lblIpAddress);
            this.groupBoxClient.Controls.Add(this.btnDisconnect);
            this.groupBoxClient.Controls.Add(this.btnConnect);
            this.groupBoxClient.Location = new System.Drawing.Point(292, 99);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Size = new System.Drawing.Size(207, 146);
            this.groupBoxClient.TabIndex = 2;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Client";
            // 
            // txtBoxPortClient
            // 
            this.txtBoxPortClient.Location = new System.Drawing.Point(77, 106);
            this.txtBoxPortClient.Name = "txtBoxPortClient";
            this.txtBoxPortClient.Size = new System.Drawing.Size(124, 23);
            this.txtBoxPortClient.TabIndex = 7;
            this.txtBoxPortClient.Text = "4949";
            // 
            // txtBoxIpAddressClient
            // 
            this.txtBoxIpAddressClient.Location = new System.Drawing.Point(77, 72);
            this.txtBoxIpAddressClient.Name = "txtBoxIpAddressClient";
            this.txtBoxIpAddressClient.Size = new System.Drawing.Size(124, 23);
            this.txtBoxIpAddressClient.TabIndex = 6;
            this.txtBoxIpAddressClient.Text = "127.0.0.1";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(39, 109);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(32, 15);
            this.lblPort.TabIndex = 5;
            this.lblPort.Text = "Port:";
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Location = new System.Drawing.Point(6, 75);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(65, 15);
            this.lblIpAddress.TabIndex = 4;
            this.lblIpAddress.Text = "IP Address:";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(116, 22);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(85, 34);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 22);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(85, 34);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.btnChangePresets);
            this.groupBoxUser.Controls.Add(this.userIpAddress);
            this.groupBoxUser.Controls.Add(this.userPort);
            this.groupBoxUser.Controls.Add(this.userName);
            this.groupBoxUser.Controls.Add(this.lblIpAddressUser);
            this.groupBoxUser.Controls.Add(this.lblPortUser);
            this.groupBoxUser.Controls.Add(this.lblName);
            this.groupBoxUser.Location = new System.Drawing.Point(528, 12);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(200, 177);
            this.groupBoxUser.TabIndex = 3;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "User";
            // 
            // btnChangePresets
            // 
            this.btnChangePresets.Location = new System.Drawing.Point(44, 137);
            this.btnChangePresets.Name = "btnChangePresets";
            this.btnChangePresets.Size = new System.Drawing.Size(97, 34);
            this.btnChangePresets.TabIndex = 8;
            this.btnChangePresets.Text = "Change presets";
            this.btnChangePresets.UseVisualStyleBackColor = true;
            this.btnChangePresets.Click += new System.EventHandler(this.btnChangePresets_Click);
            // 
            // userIpAddress
            // 
            this.userIpAddress.AutoSize = true;
            this.userIpAddress.Location = new System.Drawing.Point(77, 97);
            this.userIpAddress.Name = "userIpAddress";
            this.userIpAddress.Size = new System.Drawing.Size(34, 15);
            this.userIpAddress.TabIndex = 5;
            this.userIpAddress.Text = "none";
            // 
            // userPort
            // 
            this.userPort.AutoSize = true;
            this.userPort.Location = new System.Drawing.Point(44, 65);
            this.userPort.Name = "userPort";
            this.userPort.Size = new System.Drawing.Size(34, 15);
            this.userPort.TabIndex = 4;
            this.userPort.Text = "none";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(54, 32);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(34, 15);
            this.userName.TabIndex = 3;
            this.userName.Text = "none";
            // 
            // lblIpAddressUser
            // 
            this.lblIpAddressUser.AutoSize = true;
            this.lblIpAddressUser.Location = new System.Drawing.Point(6, 97);
            this.lblIpAddressUser.Name = "lblIpAddressUser";
            this.lblIpAddressUser.Size = new System.Drawing.Size(65, 15);
            this.lblIpAddressUser.TabIndex = 2;
            this.lblIpAddressUser.Text = "IP Address:";
            // 
            // lblPortUser
            // 
            this.lblPortUser.AutoSize = true;
            this.lblPortUser.Location = new System.Drawing.Point(6, 65);
            this.lblPortUser.Name = "lblPortUser";
            this.lblPortUser.Size = new System.Drawing.Size(32, 15);
            this.lblPortUser.TabIndex = 1;
            this.lblPortUser.Text = "Port:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtBoxUserMessage
            // 
            this.txtBoxUserMessage.Location = new System.Drawing.Point(12, 380);
            this.txtBoxUserMessage.Multiline = true;
            this.txtBoxUserMessage.Name = "txtBoxUserMessage";
            this.txtBoxUserMessage.Size = new System.Drawing.Size(274, 58);
            this.txtBoxUserMessage.TabIndex = 4;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(292, 380);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(85, 34);
            this.btnSendMessage.TabIndex = 8;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtBoxUserMessage);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.groupBoxClient);
            this.Controls.Add(this.groupBoxServer);
            this.Controls.Add(this.txtBoxMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCPServerClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxServer.ResumeLayout(false);
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxMessages;
        private GroupBox groupBoxServer;
        private Button btnStopServer;
        private Button btnStartServer;
        private GroupBox groupBoxClient;
        private Button btnDisconnect;
        private Button btnConnect;
        private TextBox txtBoxPortClient;
        private TextBox txtBoxIpAddressClient;
        private Label lblPort;
        private Label lblIpAddress;
        private GroupBox groupBoxUser;
        private Label userIpAddress;
        private Label userPort;
        private Label userName;
        private Label lblIpAddressUser;
        private Label lblPortUser;
        private Label lblName;
        private Button btnChangePresets;
        private TextBox txtBoxUserMessage;
        private Button btnSendMessage;
    }
}