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
            this.HOMEPAGE = new System.Windows.Forms.Button();
            this.RLS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HOMEPAGE
            // 
            this.HOMEPAGE.Location = new System.Drawing.Point(16, 474);
            this.HOMEPAGE.Margin = new System.Windows.Forms.Padding(4);
            this.HOMEPAGE.Name = "HOMEPAGE";
            this.HOMEPAGE.Size = new System.Drawing.Size(343, 62);
            this.HOMEPAGE.TabIndex = 0;
            this.HOMEPAGE.Text = "HOME";
            this.HOMEPAGE.UseVisualStyleBackColor = true;
            this.HOMEPAGE.Click += new System.EventHandler(this.HOMEPAGE_Click);
            // 
            // RLS
            // 
            this.RLS.Location = new System.Drawing.Point(13, 180);
            this.RLS.Margin = new System.Windows.Forms.Padding(4);
            this.RLS.Name = "RLS";
            this.RLS.Size = new System.Drawing.Size(343, 50);
            this.RLS.TabIndex = 1;
            this.RLS.Text = "RLS SAMPLING";
            this.RLS.UseVisualStyleBackColor = true;
            this.RLS.Click += new System.EventHandler(this.RLS_Click);
            // 
            // TestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 550);
            this.Controls.Add(this.RLS);
            this.Controls.Add(this.HOMEPAGE);
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