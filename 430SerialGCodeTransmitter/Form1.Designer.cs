namespace _430SerialGCodeTransmitter
{
    partial class Form1
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
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.fdSourceFile = new System.Windows.Forms.OpenFileDialog();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboBaudRate = new System.Windows.Forms.ComboBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRefreshPorts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.chkAutoSend = new System.Windows.Forms.CheckBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.chkSendAll = new System.Windows.Forms.CheckBox();
            this.chkRound = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(375, 12);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // fdSourceFile
            // 
            this.fdSourceFile.FileOk += new System.ComponentModel.CancelEventHandler(this.fdSourceFile_FileOk);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(12, 12);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(357, 20);
            this.txtFile.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 38);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(357, 332);
            this.txtOutput.TabIndex = 2;
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(67, 19);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(171, 21);
            this.cbPorts.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboBaudRate);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.btnRefreshPorts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbPorts);
            this.groupBox1.Location = new System.Drawing.Point(475, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 358);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transmit";
            // 
            // cboBaudRate
            // 
            this.cboBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBaudRate.FormattingEnabled = true;
            this.cboBaudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cboBaudRate.Location = new System.Drawing.Point(67, 48);
            this.cboBaudRate.Name = "cboBaudRate";
            this.cboBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cboBaudRate.TabIndex = 8;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(305, 46);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 7;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(224, 46);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnRefreshPorts
            // 
            this.btnRefreshPorts.Location = new System.Drawing.Point(244, 17);
            this.btnRefreshPorts.Name = "btnRefreshPorts";
            this.btnRefreshPorts.Size = new System.Drawing.Size(136, 23);
            this.btnRefreshPorts.TabIndex = 5;
            this.btnRefreshPorts.Text = "Refresh List";
            this.btnRefreshPorts.UseVisualStyleBackColor = true;
            this.btnRefreshPorts.Click += new System.EventHandler(this.btnRefreshPorts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Serial Port";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(375, 42);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(75, 23);
            this.btnLoadFile.TabIndex = 5;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(376, 81);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(75, 23);
            this.btnSendFile.TabIndex = 6;
            this.btnSendFile.Text = "Send";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // chkAutoSend
            // 
            this.chkAutoSend.AutoSize = true;
            this.chkAutoSend.Location = new System.Drawing.Point(376, 122);
            this.chkAutoSend.Name = "chkAutoSend";
            this.chkAutoSend.Size = new System.Drawing.Size(76, 17);
            this.chkAutoSend.TabIndex = 7;
            this.chkAutoSend.Text = "Auto Send";
            this.chkAutoSend.UseVisualStyleBackColor = true;
            this.chkAutoSend.CheckedChanged += new System.EventHandler(this.chkAutoSend_CheckedChanged);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(375, 213);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(75, 23);
            this.btnAnalyze.TabIndex = 8;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // chkSendAll
            // 
            this.chkSendAll.AutoSize = true;
            this.chkSendAll.Location = new System.Drawing.Point(375, 146);
            this.chkSendAll.Name = "chkSendAll";
            this.chkSendAll.Size = new System.Drawing.Size(65, 17);
            this.chkSendAll.TabIndex = 9;
            this.chkSendAll.Text = "Send All";
            this.chkSendAll.UseVisualStyleBackColor = true;
            this.chkSendAll.CheckedChanged += new System.EventHandler(this.chkSendAll_CheckedChanged);
            // 
            // chkRound
            // 
            this.chkRound.AutoSize = true;
            this.chkRound.Location = new System.Drawing.Point(376, 170);
            this.chkRound.Name = "chkRound";
            this.chkRound.Size = new System.Drawing.Size(93, 17);
            this.chkRound.TabIndex = 10;
            this.chkRound.Text = "Round Values";
            this.chkRound.UseVisualStyleBackColor = true;
            this.chkRound.CheckedChanged += new System.EventHandler(this.chkRound_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Baud Rate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 382);
            this.Controls.Add(this.chkRound);
            this.Controls.Add(this.chkSendAll);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.chkAutoSend);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.OpenFileDialog fdSourceFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefreshPorts;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnSendFile;
        private System.Windows.Forms.CheckBox chkAutoSend;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.CheckBox chkSendAll;
        private System.Windows.Forms.ComboBox cboBaudRate;
        private System.Windows.Forms.CheckBox chkRound;
        private System.Windows.Forms.Label label2;
    }
}

