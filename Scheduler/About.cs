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
    public partial class About : Form
    {
        #region Constructor
        public About()
        {
            InitializeComponent();
        }
        #endregion

        #region Binds the url of the html file to the webBrowser Control.
        private void About_Load(object sender, EventArgs e)
        {
            wbAbout.DocumentText = Properties.Resources.about;
        }
        #endregion

        #region Closes the about box.
        private void btnOkayClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }
    }
}
