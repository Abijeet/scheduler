using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class Message : Form
    {
        public double doubleRemindAfter = 0;
        bool blDisplayTimer = false;
        int intCounter = 20;
        string strApplicationMessage;

        #region Constructor
        /// <summary>
        /// Constructor. You can call a constructor from another constructor...
        /// http://stackoverflow.com/questions/4009013/call-one-constructor-from-another
        /// </summary>
        /// <param name="strTitle">Title of the Window.</param>
        /// <param name="strMessage">Message inside the rich text box.</param>
        /// <param name="strDelayDisplay">Text for label.</param>
        /// <param name="blVisibility">For button Visibility.</param>
        public Message(string strTitle = "Message", string strMessage = "Enter your message here", string strDelayDisplay="Display after :", bool blVisibility = false)
        {
            InitializeComponent();
            this.Text = strTitle;
            rtbDisplay.Text = strMessage;
            lblDelayDisplay.Text = strDelayDisplay;
            blDisplayTimer = blVisibility;
            if (blVisibility == true)
            {
                strApplicationMessage = strMessage;
                timerCoolDown.Enabled = true;
                btnCancel.Visible = true;
            }
        }
        #endregion

        #region Okay Button Clicked
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cbReminder.Text.Length != 0)
            {
                doubleRemindAfter = Convert.ToDouble(cbReminder.Text);
            }
            this.Close();
        }
        #endregion

        #region Checking to ensure that data entered into cb box is numbers only.
        private void cbReminder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Start now button clicked...
        private void btnStartNow_Click(object sender, EventArgs e)
        {
            this.Close();            
            doubleRemindAfter = 0;
        }        
        #endregion

        #region Ticker for message box on application open.
        private void timerCoolDown_Tick(object sender, EventArgs e)
        {
            --intCounter;
            rtbDisplay.Text = strApplicationMessage + intCounter.ToString();
            if(intCounter == 0)
            {
                timerCoolDown.Enabled = false;
                this.Close();
            }
        }
#endregion

        #region Cancel Button Clicked
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // -1 to cancel an event from occuring.
            doubleRemindAfter = -1;
            this.Close();
        }
        #endregion
    }
}
