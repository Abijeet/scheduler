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
    public partial class countDown : Form
    {
        // Set Timer here.
        int intCounter=20;
        public double doubleDelayer = 0;

        #region Constructor
        public countDown(string strTitle="Counter",string strAction="Action:",string strButtonName = "Do Now!")
        {
            InitializeComponent();
            lblActionDes.Text = strAction;
            this.Text = strTitle;
            btnShutNow.Text = strButtonName;
            lblCounter.Text = intCounter.ToString();
        }
        #endregion

        #region Timer tick.
        private void timerCoolDown_Tick(object sender, EventArgs e)
        {
            --intCounter;
            lblCounter.Text = intCounter.ToString();
            if (intCounter == 0)
            {
                timerCoolDown.Enabled = false;
                this.Close();
            }
        }
        #endregion

        #region Shut down button click.
        private void btnShutNow_Click(object sender, EventArgs e)
        {
            timerCoolDown.Enabled = false;
            doubleDelayer = 0;
            this.Close();
        }
        #endregion

        #region Delay button clicked
        private void btnDelay_Click(object sender, EventArgs e)
        {
            if (cbDelay.Text.Length != 0)
            {
                doubleDelayer = Convert.ToDouble(cbDelay.Text);
            }
            this.Close();
        }
        #endregion

        #region Check to make sure user can enter only numbers.
        private void cbDelay_KeyPress(object sender, KeyPressEventArgs e)
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

        #region OnLoad Event
        private void countDown_Load(object sender, EventArgs e)
        {
            timerCoolDown.Enabled = true;
        }
        #endregion 

        private void btnCancel_Click(object sender, EventArgs e)
        {
            doubleDelayer = -1;
            this.Close();
        }
    }
}
