namespace SenDes0
{
    partial class TestPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestPage));
            this.HOMEPAGE = new System.Windows.Forms.Button();
            this.RLS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HOMEPAGE
            // 
            this.HOMEPAGE.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.HOMEPAGE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HOMEPAGE.BackgroundImage")));
            this.HOMEPAGE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HOMEPAGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HOMEPAGE.Location = new System.Drawing.Point(16, 397);
            this.HOMEPAGE.Margin = new System.Windows.Forms.Padding(4);
            this.HOMEPAGE.Name = "HOMEPAGE";
            this.HOMEPAGE.Size = new System.Drawing.Size(343, 139);
            this.HOMEPAGE.TabIndex = 0;
            this.HOMEPAGE.UseVisualStyleBackColor = false;
            this.HOMEPAGE.Click += new System.EventHandler(this.HOMEPAGE_Click);
            // 
            // RLS
            // 
            this.RLS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RLS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RLS.BackgroundImage")));
            this.RLS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RLS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RLS.Location = new System.Drawing.Point(55, 90);
            this.RLS.Margin = new System.Windows.Forms.Padding(4);
            this.RLS.Name = "RLS";
            this.RLS.Size = new System.Drawing.Size(317, 190);
            this.RLS.TabIndex = 1;
            this.RLS.UseVisualStyleBackColor = false;
            this.RLS.Click += new System.EventHandler(this.RLS_Click);
            // 
            // TestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(375, 550);
            this.Controls.Add(this.RLS);
            this.Controls.Add(this.HOMEPAGE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TestPage";
            this.Text = "TestPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HOMEPAGE;
        private System.Windows.Forms.Button RLS;
    }
}