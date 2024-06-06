namespace DAV_Suit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxSerialCom = new System.Windows.Forms.GroupBox();
            this.btnCheckCom = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.boxBaudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.receivedData = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sendData = new System.Windows.Forms.Label();
            this.barStatus = new System.Windows.Forms.StatusStrip();
            this.boxTermtool = new System.Windows.Forms.GroupBox();
            this.sendByte = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.textCMD = new System.Windows.Forms.TextBox();
            this.textTerminal = new System.Windows.Forms.RichTextBox();
            this.termSetting = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.boxSerialCom.SuspendLayout();
            this.boxTermtool.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // boxSerialCom
            // 
            this.boxSerialCom.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.boxSerialCom.Controls.Add(this.btnCheckCom);
            this.boxSerialCom.Controls.Add(this.btnRefresh);
            this.boxSerialCom.Controls.Add(this.btnConnect);
            this.boxSerialCom.Controls.Add(this.boxBaudrate);
            this.boxSerialCom.Controls.Add(this.label2);
            this.boxSerialCom.Controls.Add(this.boxComPort);
            this.boxSerialCom.Controls.Add(this.label1);
            this.boxSerialCom.Location = new System.Drawing.Point(12, 27);
            this.boxSerialCom.Name = "boxSerialCom";
            this.boxSerialCom.Size = new System.Drawing.Size(760, 50);
            this.boxSerialCom.TabIndex = 2;
            this.boxSerialCom.TabStop = false;
            this.boxSerialCom.Text = "Serial Communication";
            // 
            // btnCheckCom
            // 
            this.btnCheckCom.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckCom.Location = new System.Drawing.Point(623, 16);
            this.btnCheckCom.Name = "btnCheckCom";
            this.btnCheckCom.Size = new System.Drawing.Size(131, 21);
            this.btnCheckCom.TabIndex = 6;
            this.btnCheckCom.Text = "CHECK COMMUNICATION";
            this.btnCheckCom.UseVisualStyleBackColor = true;
            this.btnCheckCom.Click += new System.EventHandler(this.btnCheckCom_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(532, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.IndianRed;
            this.btnConnect.Location = new System.Drawing.Point(402, 11);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(124, 29);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // boxBaudrate
            // 
            this.boxBaudrate.FormattingEnabled = true;
            this.boxBaudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "115200"});
            this.boxBaudrate.Location = new System.Drawing.Point(294, 16);
            this.boxBaudrate.Name = "boxBaudrate";
            this.boxBaudrate.Size = new System.Drawing.Size(102, 21);
            this.boxBaudrate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "BAUD RATE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // boxComPort
            // 
            this.boxComPort.FormattingEnabled = true;
            this.boxComPort.Location = new System.Drawing.Point(76, 18);
            this.boxComPort.Name = "boxComPort";
            this.boxComPort.Size = new System.Drawing.Size(137, 21);
            this.boxComPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM PORT";
            // 
            // receivedData
            // 
            this.receivedData.AutoSize = true;
            this.receivedData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedData.ForeColor = System.Drawing.Color.Green;
            this.receivedData.Location = new System.Drawing.Point(342, 641);
            this.receivedData.Name = "receivedData";
            this.receivedData.Size = new System.Drawing.Size(42, 15);
            this.receivedData.TabIndex = 7;
            this.receivedData.Text = "- - - - - ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 643);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "|  Received: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 643);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "|  Send: ";
            // 
            // sendData
            // 
            this.sendData.AutoSize = true;
            this.sendData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendData.ForeColor = System.Drawing.Color.Blue;
            this.sendData.Location = new System.Drawing.Point(61, 641);
            this.sendData.Name = "sendData";
            this.sendData.Size = new System.Drawing.Size(42, 15);
            this.sendData.TabIndex = 10;
            this.sendData.Text = "- - - - - ";
            // 
            // barStatus
            // 
            this.barStatus.Location = new System.Drawing.Point(0, 639);
            this.barStatus.Name = "barStatus";
            this.barStatus.Size = new System.Drawing.Size(784, 22);
            this.barStatus.TabIndex = 1;
            this.barStatus.Text = "statusStrip1";
            // 
            // boxTermtool
            // 
            this.boxTermtool.Controls.Add(this.sendByte);
            this.boxTermtool.Location = new System.Drawing.Point(624, 182);
            this.boxTermtool.Name = "boxTermtool";
            this.boxTermtool.Size = new System.Drawing.Size(148, 357);
            this.boxTermtool.TabIndex = 15;
            this.boxTermtool.TabStop = false;
            this.boxTermtool.Text = "Terminal Tools";
            // 
            // sendByte
            // 
            this.sendByte.AutoSize = true;
            this.sendByte.Location = new System.Drawing.Point(25, 33);
            this.sendByte.Name = "sendByte";
            this.sendByte.Size = new System.Drawing.Size(94, 17);
            this.sendByte.TabIndex = 0;
            this.sendByte.Text = "send as BYTE";
            this.sendByte.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(624, 545);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 30);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "CLEAR ALL";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(624, 581);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(148, 52);
            this.btnEnter.TabIndex = 13;
            this.btnEnter.Text = "ENTER";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // textCMD
            // 
            this.textCMD.AcceptsReturn = true;
            this.textCMD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCMD.Location = new System.Drawing.Point(12, 611);
            this.textCMD.Name = "textCMD";
            this.textCMD.Size = new System.Drawing.Size(600, 22);
            this.textCMD.TabIndex = 12;
            // 
            // textTerminal
            // 
            this.textTerminal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textTerminal.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTerminal.Location = new System.Drawing.Point(12, 182);
            this.textTerminal.Name = "textTerminal";
            this.textTerminal.ReadOnly = true;
            this.textTerminal.Size = new System.Drawing.Size(600, 423);
            this.textTerminal.TabIndex = 11;
            this.textTerminal.Text = "";
            // 
            // termSetting
            // 
            this.termSetting.Location = new System.Drawing.Point(12, 83);
            this.termSetting.Name = "termSetting";
            this.termSetting.Size = new System.Drawing.Size(760, 93);
            this.termSetting.TabIndex = 16;
            this.termSetting.TabStop = false;
            this.termSetting.Text = "Terminal Setting";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.termSetting);
            this.Controls.Add(this.boxTermtool);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.textCMD);
            this.Controls.Add(this.textTerminal);
            this.Controls.Add(this.sendData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.receivedData);
            this.Controls.Add(this.boxSerialCom);
            this.Controls.Add(this.barStatus);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Terminal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.boxSerialCom.ResumeLayout(false);
            this.boxSerialCom.PerformLayout();
            this.boxTermtool.ResumeLayout(false);
            this.boxTermtool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox boxSerialCom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckCom;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox boxBaudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxComPort;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private  System.Windows.Forms.Label receivedData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label sendData;
        private System.Windows.Forms.StatusStrip barStatus;
        private System.Windows.Forms.GroupBox boxTermtool;
        private System.Windows.Forms.CheckBox sendByte;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox textCMD;
        private System.Windows.Forms.RichTextBox textTerminal;
        private System.Windows.Forms.GroupBox termSetting;
    }
}

