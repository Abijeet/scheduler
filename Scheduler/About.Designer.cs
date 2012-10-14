namespace Scheduler
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.btnOkayClose = new System.Windows.Forms.Button();
            this.wbAbout = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnOkayClose
            // 
            this.btnOkayClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOkayClose.Location = new System.Drawing.Point(265, 243);
            this.btnOkayClose.Name = "btnOkayClose";
            this.btnOkayClose.Size = new System.Drawing.Size(87, 25);
            this.btnOkayClose.TabIndex = 0;
            this.btnOkayClose.Text = "OK";
            this.btnOkayClose.UseVisualStyleBackColor = true;
            this.btnOkayClose.Click += new System.EventHandler(this.btnOkayClose_Click);
            // 
            // wbAbout
            // 
            this.wbAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wbAbout.Location = new System.Drawing.Point(12, 12);
            this.wbAbout.MinimumSize = new System.Drawing.Size(23, 22);
            this.wbAbout.Name = "wbAbout";
            this.wbAbout.ScrollBarsEnabled = false;
            this.wbAbout.Size = new System.Drawing.Size(340, 208);
            this.wbAbout.TabIndex = 2;
            this.wbAbout.TabStop = false;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 280);
            this.Controls.Add(this.wbAbout);
            this.Controls.Add(this.btnOkayClose);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "About";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOkayClose;
        private System.Windows.Forms.WebBrowser wbAbout;
    }
}