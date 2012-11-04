namespace Scheduler
{
    partial class frmSchedule
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchedule));
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnOkay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.lblText = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTicker = new System.Windows.Forms.Label();
            this.lblDelayTimer = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.ofdSelectFile = new System.Windows.Forms.OpenFileDialog();
            this.timerCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showMainWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelRunningEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nmExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msTopMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyMenu.SuspendLayout();
            this.msTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbAction
            // 
            this.cbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Items.AddRange(new object[] {
            "Shutdown",
            "Restart",
            "Log Off",
            "Open File/Application",
            "Display Message"});
            this.cbAction.Location = new System.Drawing.Point(15, 69);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(213, 22);
            this.cbAction.TabIndex = 0;
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.cbAction_SelectedIndexChanged);
            // 
            // rtbMessage
            // 
            this.rtbMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbMessage.Enabled = false;
            this.rtbMessage.Location = new System.Drawing.Point(13, 106);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(356, 79);
            this.rtbMessage.TabIndex = 1;
            this.rtbMessage.Text = "";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 37);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(140, 14);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "Select your action,";
            // 
            // btnOkay
            // 
            this.btnOkay.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkay.Location = new System.Drawing.Point(223, 209);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(70, 27);
            this.btnOkay.TabIndex = 3;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(299, 209);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(70, 27);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // dtPicker
            // 
            this.dtPicker.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtPicker.Location = new System.Drawing.Point(260, 69);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.ShowUpDown = true;
            this.dtPicker.Size = new System.Drawing.Size(109, 22);
            this.dtPicker.TabIndex = 1;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(233, 74);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(21, 14);
            this.lblText.TabIndex = 9;
            this.lblText.Text = "at";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblTicker
            // 
            this.lblTicker.AutoSize = true;
            this.lblTicker.Location = new System.Drawing.Point(10, 215);
            this.lblTicker.Name = "lblTicker";
            this.lblTicker.Size = new System.Drawing.Size(126, 14);
            this.lblTicker.TabIndex = 10;
            this.lblTicker.Text = "No event running.";
            // 
            // lblDelayTimer
            // 
            this.lblDelayTimer.AutoSize = true;
            this.lblDelayTimer.Location = new System.Drawing.Point(257, 37);
            this.lblDelayTimer.Name = "lblDelayTimer";
            this.lblDelayTimer.Size = new System.Drawing.Size(56, 14);
            this.lblDelayTimer.TabIndex = 11;
            this.lblDelayTimer.Text = "Delay :";
            this.lblDelayTimer.Visible = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(144, 209);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(73, 27);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse..";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ofdSelectFile
            // 
            this.ofdSelectFile.FileName = "openFileDialog";
            // 
            // timerCurrentTime
            // 
            this.timerCurrentTime.Interval = 1000;
            this.timerCurrentTime.Tick += new System.EventHandler(this.timerCurrentTime_Tick);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCurrentTime.Location = new System.Drawing.Point(278, 6);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(91, 14);
            this.lblCurrentTime.TabIndex = 14;
            this.lblCurrentTime.Text = "Current Time";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "\r\nScheduler will always be accessible through the notification area.\r\n\r\nTo close " +
    "Scheduler exit it from the notification area.";
            this.notifyIcon.BalloonTipTitle = "Tip";
            this.notifyIcon.ContextMenuStrip = this.notifyMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // notifyMenu
            // 
            this.notifyMenu.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMainWindowToolStripMenuItem,
            this.cancelRunningEventToolStripMenuItem,
            this.toolStripSeparator1,
            this.nmExitItem});
            this.notifyMenu.Name = "notifyMenu";
            this.notifyMenu.Size = new System.Drawing.Size(215, 98);
            // 
            // showMainWindowToolStripMenuItem
            // 
            this.showMainWindowToolStripMenuItem.Name = "showMainWindowToolStripMenuItem";
            this.showMainWindowToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.showMainWindowToolStripMenuItem.Text = "Display Window";
            this.showMainWindowToolStripMenuItem.Click += new System.EventHandler(this.showMainWindowToolStripMenuItem_Click);
            // 
            // cancelRunningEventToolStripMenuItem
            // 
            this.cancelRunningEventToolStripMenuItem.Enabled = false;
            this.cancelRunningEventToolStripMenuItem.Name = "cancelRunningEventToolStripMenuItem";
            this.cancelRunningEventToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.cancelRunningEventToolStripMenuItem.Text = "Cancel running event";
            this.cancelRunningEventToolStripMenuItem.Click += new System.EventHandler(this.cancelRunningEventToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // nmExitItem
            // 
            this.nmExitItem.Name = "nmExitItem";
            this.nmExitItem.Size = new System.Drawing.Size(214, 22);
            this.nmExitItem.Text = "E&xit";
            this.nmExitItem.Click += new System.EventHandler(this.notifyIconMenuItem1_Click);
            // 
            // msTopMenu
            // 
            this.msTopMenu.BackColor = System.Drawing.SystemColors.Menu;
            this.msTopMenu.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msTopMenu.Location = new System.Drawing.Point(0, 0);
            this.msTopMenu.Name = "msTopMenu";
            this.msTopMenu.Size = new System.Drawing.Size(382, 24);
            this.msTopMenu.TabIndex = 15;
            this.msTopMenu.Text = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(106, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 247);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblDelayTimer);
            this.Controls.Add(this.lblTicker);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.cbAction);
            this.Controls.Add(this.msTopMenu);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msTopMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSchedule";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Scheduler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSchedule_FormClosing);
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            this.notifyMenu.ResumeLayout(false);
            this.msTopMenu.ResumeLayout(false);
            this.msTopMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTicker;
        private System.Windows.Forms.Label lblDelayTimer;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog ofdSelectFile;
        private System.Windows.Forms.Timer timerCurrentTime;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyMenu;
        private System.Windows.Forms.ToolStripMenuItem nmExitItem;
        private System.Windows.Forms.MenuStrip msTopMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMainWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelRunningEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

