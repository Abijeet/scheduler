namespace Scheduler
{
    partial class Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblDelayDisplay = new System.Windows.Forms.Label();
            this.cbReminder = new System.Windows.Forms.ComboBox();
            this.timerCoolDown = new System.Windows.Forms.Timer(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDisplay.Location = new System.Drawing.Point(12, 12);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(463, 140);
            this.rtbDisplay.TabIndex = 0;
            this.rtbDisplay.Text = "";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(329, 161);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(67, 29);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Okay";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblDelayDisplay
            // 
            this.lblDelayDisplay.AutoSize = true;
            this.lblDelayDisplay.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelayDisplay.Location = new System.Drawing.Point(12, 168);
            this.lblDelayDisplay.Name = "lblDelayDisplay";
            this.lblDelayDisplay.Size = new System.Drawing.Size(154, 14);
            this.lblDelayDisplay.TabIndex = 2;
            this.lblDelayDisplay.Text = "Display again after :";
            // 
            // cbReminder
            // 
            this.cbReminder.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReminder.FormattingEnabled = true;
            this.cbReminder.Items.AddRange(new object[] {
            "10",
            "15",
            "20",
            "30",
            "45",
            "60"});
            this.cbReminder.Location = new System.Drawing.Point(172, 165);
            this.cbReminder.MaxLength = 2;
            this.cbReminder.Name = "cbReminder";
            this.cbReminder.Size = new System.Drawing.Size(51, 22);
            this.cbReminder.TabIndex = 1;
            this.cbReminder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbReminder_KeyPress);
            // 
            // timerCoolDown
            // 
            this.timerCoolDown.Interval = 1000;
            this.timerCoolDown.Tick += new System.EventHandler(this.timerCoolDown_Tick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(402, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(73, 29);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 202);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbReminder);
            this.Controls.Add(this.lblDelayDisplay);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.rtbDisplay);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblDelayDisplay;
        private System.Windows.Forms.ComboBox cbReminder;
        private System.Windows.Forms.Timer timerCoolDown;
        private System.Windows.Forms.Button btnCancel;
    }
}