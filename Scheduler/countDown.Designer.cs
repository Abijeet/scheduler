namespace Scheduler
{
    partial class countDown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(countDown));
            this.lblActionDes = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.cbDelay = new System.Windows.Forms.ComboBox();
            this.btnDelay = new System.Windows.Forms.Button();
            this.btnShutNow = new System.Windows.Forms.Button();
            this.timerCoolDown = new System.Windows.Forms.Timer(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblActionDes
            // 
            this.lblActionDes.AutoSize = true;
            this.lblActionDes.Location = new System.Drawing.Point(12, 9);
            this.lblActionDes.Name = "lblActionDes";
            this.lblActionDes.Size = new System.Drawing.Size(49, 14);
            this.lblActionDes.TabIndex = 0;
            this.lblActionDes.Text = "Action";
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(266, 9);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(42, 14);
            this.lblCounter.TabIndex = 1;
            this.lblCounter.Text = "Timer";
            // 
            // cbDelay
            // 
            this.cbDelay.FormattingEnabled = true;
            this.cbDelay.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "30",
            "45",
            "60"});
            this.cbDelay.Location = new System.Drawing.Point(12, 47);
            this.cbDelay.MaxLength = 2;
            this.cbDelay.Name = "cbDelay";
            this.cbDelay.Size = new System.Drawing.Size(49, 22);
            this.cbDelay.TabIndex = 0;
            this.cbDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbDelay_KeyPress);
            // 
            // btnDelay
            // 
            this.btnDelay.Location = new System.Drawing.Point(67, 43);
            this.btnDelay.Name = "btnDelay";
            this.btnDelay.Size = new System.Drawing.Size(77, 25);
            this.btnDelay.TabIndex = 1;
            this.btnDelay.Text = "Delay";
            this.btnDelay.UseVisualStyleBackColor = true;
            this.btnDelay.Click += new System.EventHandler(this.btnDelay_Click);
            // 
            // btnShutNow
            // 
            this.btnShutNow.Location = new System.Drawing.Point(150, 42);
            this.btnShutNow.Name = "btnShutNow";
            this.btnShutNow.Size = new System.Drawing.Size(79, 26);
            this.btnShutNow.TabIndex = 2;
            this.btnShutNow.Text = "Shutdown";
            this.btnShutNow.UseVisualStyleBackColor = true;
            this.btnShutNow.Click += new System.EventHandler(this.btnShutNow_Click);
            // 
            // timerCoolDown
            // 
            this.timerCoolDown.Interval = 1000;
            this.timerCoolDown.Tick += new System.EventHandler(this.timerCoolDown_Tick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(235, 42);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // countDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 80);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnShutNow);
            this.Controls.Add(this.btnDelay);
            this.Controls.Add(this.cbDelay);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lblActionDes);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "countDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Count";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.countDown_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActionDes;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.ComboBox cbDelay;
        private System.Windows.Forms.Button btnDelay;
        private System.Windows.Forms.Button btnShutNow;
        private System.Windows.Forms.Timer timerCoolDown;
        private System.Windows.Forms.Button btnCancel;
    }
}