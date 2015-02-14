namespace SenDes0
{
    partial class HomePage
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
            this.TEST_BUTTON = new System.Windows.Forms.Button();
            this.REPORTS_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TEST_BUTTON
            // 
            this.TEST_BUTTON.Location = new System.Drawing.Point(12, 382);
            this.TEST_BUTTON.Name = "TEST_BUTTON";
            this.TEST_BUTTON.Size = new System.Drawing.Size(140, 55);
            this.TEST_BUTTON.TabIndex = 0;
            this.TEST_BUTTON.Text = "TEST";
            this.TEST_BUTTON.UseVisualStyleBackColor = true;
            this.TEST_BUTTON.Click += new System.EventHandler(this.TEST_BUTTON_Click);
            // 
            // REPORTS_BUTTON
            // 
            this.REPORTS_BUTTON.Location = new System.Drawing.Point(158, 382);
            this.REPORTS_BUTTON.Name = "REPORTS_BUTTON";
            this.REPORTS_BUTTON.Size = new System.Drawing.Size(125, 55);
            this.REPORTS_BUTTON.TabIndex = 1;
            this.REPORTS_BUTTON.Text = "REPORTS";
            this.REPORTS_BUTTON.UseVisualStyleBackColor = true;
            this.REPORTS_BUTTON.Click += new System.EventHandler(this.REPORTS_BUTTON_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 449);
            this.Controls.Add(this.REPORTS_BUTTON);
            this.Controls.Add(this.TEST_BUTTON);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TEST_BUTTON;
        private System.Windows.Forms.Button REPORTS_BUTTON;
    }
}

