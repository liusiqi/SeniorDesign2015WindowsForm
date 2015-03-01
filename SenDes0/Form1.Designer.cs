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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.TEST_BUTTON = new System.Windows.Forms.Button();
            this.REPORTS_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TEST_BUTTON
            // 
            this.TEST_BUTTON.BackColor = System.Drawing.Color.Black;
            this.TEST_BUTTON.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TEST_BUTTON.BackgroundImage")));
            this.TEST_BUTTON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.TEST_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TEST_BUTTON.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.TEST_BUTTON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.TEST_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TEST_BUTTON.Location = new System.Drawing.Point(12, 454);
            this.TEST_BUTTON.Name = "TEST_BUTTON";
            this.TEST_BUTTON.Size = new System.Drawing.Size(140, 55);
            this.TEST_BUTTON.TabIndex = 0;
            this.TEST_BUTTON.UseVisualStyleBackColor = false;
            this.TEST_BUTTON.Click += new System.EventHandler(this.TEST_BUTTON_Click);
            // 
            // REPORTS_BUTTON
            // 
            this.REPORTS_BUTTON.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("REPORTS_BUTTON.BackgroundImage")));
            this.REPORTS_BUTTON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.REPORTS_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.REPORTS_BUTTON.Location = new System.Drawing.Point(158, 454);
            this.REPORTS_BUTTON.Name = "REPORTS_BUTTON";
            this.REPORTS_BUTTON.Size = new System.Drawing.Size(125, 80);
            this.REPORTS_BUTTON.TabIndex = 1;
            this.REPORTS_BUTTON.UseVisualStyleBackColor = true;
            this.REPORTS_BUTTON.Click += new System.EventHandler(this.REPORTS_BUTTON_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(295, 521);
            this.Controls.Add(this.REPORTS_BUTTON);
            this.Controls.Add(this.TEST_BUTTON);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TEST_BUTTON;
        private System.Windows.Forms.Button REPORTS_BUTTON;
    }
}

