using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Scheduler
{
    public partial class frmSchedule : Form
    {
        DateTime dtActionTime;
        string strMessage = string.Empty;
        double remindTimer;
        double currentRemindTimer;
        string strFilePath = string.Empty;
        string strFileName = string.Empty;
        bool blDisplayedTip = false;    // 
        bool blClose = false;   // Handles exit the app or move it to notification area.                

        #region Constructor
        public frmSchedule()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Load Event
        private void frmSchedule_Load(object sender, EventArgs e)
        {
            cbAction.SelectedIndex = 0;
            btnStop.Enabled = false;
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            timerCurrentTime.Enabled = true;
            if (Properties.Settings.Default.FirstRun)
            {
                Properties.Settings.Default.FirstRun = false;                
            }
            notifyIcon.Text = lblTicker.Text;
        }
        #endregion

        #region After event has occured/been stopped restore defaults.
        void stopUpdate()
        {
            timer.Enabled = false;
            lblTicker.Text = "No event running.";
            lblTicker.ForeColor = Color.Black;
            notifyIcon.Text = "No event running.";
            btnStop.Enabled = false;
            btnOkay.Enabled = true;
            dtPicker.Enabled = true;
            lblDelayTimer.Visible = false;
            cbAction.Enabled = true;
            cbActionUpdate();       // Update the combobox again.          
            remindTimer = 0;
            cancelRunningEventToolStripMenuItem.Enabled = false;
        }
        #endregion

        #region Update combobox on change/on stop.
        void cbActionUpdate()
        {
            if (cbAction.SelectedIndex == 4)
            {
                rtbMessage.Enabled = true;
                btnBrowse.Enabled = false;
                rtbMessage.Text = "Enter your message here";
                btnOkay.Enabled = true;
            }
            else if (cbAction.SelectedIndex == 3)
            {
                rtbMessage.Enabled = false;
                btnBrowse.Enabled = true;
                rtbMessage.Text = "Please click on the browse button and select the file you want to open...";
                btnOkay.Enabled = false;
            }
            else
            {
                btnBrowse.Enabled = false;
                rtbMessage.Enabled = false;
                rtbMessage.Text = string.Empty;
                btnOkay.Enabled = true;
            }
        }
        #endregion

        #region Stop  Button Clicked
        private void btnStop_Click(object sender, EventArgs e)
        {
            stopUpdate();
            cbActionUpdate();
        }
        #endregion

        #region Combo Box Index Change Event
        private void cbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbActionUpdate();
        }
        #endregion

        #region Timer 1 second - Main Timer.
        private void timer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.ToString() == dtActionTime.ToString())
            {
                timer.Enabled = false;
                int intIndex = cbAction.SelectedIndex;
                strMessage = rtbMessage.Text;
                DoAction(intIndex);

            }
        }
        #endregion

        #region Okay Button Click Event
        private void btnOkay_Click(object sender, EventArgs e)
        {
            dtActionTime = dtPicker.Value;         
            lblTicker.Text = "Event running...";
            lblTicker.ForeColor = Color.Red;
            notifyIcon.Text = lblTicker.Text;
            timer.Enabled = true;
            btnOkay.Enabled = false;
            btnStop.Enabled = true;
            dtPicker.Enabled = false;
            btnBrowse.Enabled = false;
            cbAction.Enabled = false;
            cancelRunningEventToolStripMenuItem.Enabled = true;
        }
        #endregion

        #region Code for various actions here.
        void DoAction(int intIndex)
        {
            #region Shutdown.
            if (intIndex == 0)
            {
                performActions("Shutdown", "Shutting down in...","Shutdown",intIndex);
            }
            #endregion

            #region Restart.
            else if (intIndex == 1)
            {
                performActions("Restart", "Restarting in...", "Restart",intIndex);
            }
            #endregion

            #region Log Off
            else if (intIndex == 2)
            {
                performActions("Log Off", "Logging off in...","Log Off", intIndex);
            }
            #endregion

            #region Start Application
            else if (intIndex == 3)
            {
                performActions("Application Start", "Starting " + strFileName + " in...","Start later in :",true, intIndex);
            }
            #endregion

            #region Display Message
            else if (intIndex == 4)
            {
                performActions("Message", strMessage, "Display again after :", false, 5);
            }
            #endregion

            // If there is no delay time...then no event running or if delay time is -1 means that the event was cancelled.
            if (currentRemindTimer == 0 || currentRemindTimer == -1)
            {
                stopUpdate();
            }
            // else increment delay timer.
            else
            {
                remindTimer += currentRemindTimer;
                lblDelayTimer.Text = "Delay: +" + remindTimer.ToString() + " mins";
                lblDelayTimer.Visible = true;
                dtActionTime = dtActionTime.AddMinutes(remindTimer);
                timer.Enabled = true;
            }
        }
        #endregion

        #region Shutdown, Restart, Hibernate, LogOff Action
        void performActions(string strTitle,string strAction,string strButtonName, int intType)
        {
            countDown objCD = new countDown(strTitle, strAction, strButtonName);
            objCD.ShowDialog(this);
            currentRemindTimer = objCD.doubleDelayer;            
            if (currentRemindTimer == 0)
            {
                // Shutdown
                if (intType == 0)
                {
                    Process.Start("shutdown", "/s /t 60 /c \"Shutdown by Scheduler.\"");
                }
                // Restart
                else if (intType == 1)
                {
                    Process.Start("shutdown", "/r /t 60 /c \"Restart by Scheduler.\"");
                }
                // Log Off
                else if (intType == 2)
                {
                    Process.Start("shutdown", "/l");
                }
            }
        }
        #endregion

        #region Start an Application, and display a message box actions.
        void performActions(string strTitle,string strMessage, string strDelayDisplay, bool blVisibility, int intType)
        {
            Message msgBox = new Message(strTitle,strMessage,strDelayDisplay,blVisibility);
            msgBox.ShowDialog();
            currentRemindTimer = msgBox.doubleRemindAfter;
            // Start an application.
            if (currentRemindTimer == 0 && intType == 3)
            {
                Process.Start(strFilePath);
            }
        }
        #endregion

        #region On Browse Button Click
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult drResult = ofdSelectFile.ShowDialog();
            if (drResult == DialogResult.OK)
            {
                strFilePath = ofdSelectFile.FileName;                                
                strFileName = Path.GetFileName(strFilePath);
                rtbMessage.Text = "Open File: " + strFileName;
                rtbMessage.ForeColor = Color.Black;
                btnOkay.Enabled = true;
            }
        }
        #endregion

        #region Current Time Updater
        private void timerCurrentTime_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        #endregion

        #region Instead of closing form, makes it invisible *IF* close button is pressed...
        private void frmSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!blClose)
            {
                e.Cancel = true;
                this.Visible = false;
                if (!blDisplayedTip)
                {
                    notifyIcon.ShowBalloonTip(3, "Still running...", "Scheduler is still running in the notification area.", ToolTipIcon.Info);
                    blDisplayedTip = true;
                }
            }            
        }
        #endregion

        #region Double Clicking on the notification icon.
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.Focus();
        }
        #endregion

        #region Notification menu Exit Item click.
        private void notifyIconMenuItem1_Click(object sender, EventArgs e)
        {
            blClose = true;
            Application.Exit();
        }
        #endregion

        #region About Tool Item Click
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About objAbout = new About();
            objAbout.Show();
        }
        #endregion

        #region Exit button on menu clicked.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitApp(true);
        }
        #endregion

        #region handles the exit feature, if the user clicks exit from the file menu or notify menu this directly quits.
        void exitApp(bool blOrigin=false)
        {
            if (this.Visible == false || blOrigin)
            {
                timer.Enabled = false;
                blClose = true;
                Application.Exit();
            }
        }
        #endregion

        #region Notification menu Display Main Window clicked
        private void showMainWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.Focus();
        }
        #endregion

        #region Notification menu Cancel Current event click.
        private void cancelRunningEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopUpdate();        
        }
        #endregion
    }
}
