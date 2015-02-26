namespace SenDes0
{
    partial class ReportPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPage));
            this.HOMEPAGE = new System.Windows.Forms.Button();
            this.Start_Comp = new System.Windows.Forms.Button();
            this.Stop_Comp = new System.Windows.Forms.Button();
            this.Lable_Waming = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HOMEPAGE
            // 
            this.HOMEPAGE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HOMEPAGE.BackgroundImage")));
            this.HOMEPAGE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.HOMEPAGE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HOMEPAGE.Location = new System.Drawing.Point(16, 376);
            this.HOMEPAGE.Margin = new System.Windows.Forms.Padding(4);
            this.HOMEPAGE.Name = "HOMEPAGE";
            this.HOMEPAGE.Size = new System.Drawing.Size(295, 152);
            this.HOMEPAGE.TabIndex = 0;
            this.HOMEPAGE.UseVisualStyleBackColor = true;
            this.HOMEPAGE.Click += new System.EventHandler(this.HOMEPAGE_Click);
            // 
            // Start_Comp
            // 
            this.Start_Comp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Start_Comp.BackgroundImage")));
            this.Start_Comp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Start_Comp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Comp.Location = new System.Drawing.Point(16, 144);
            this.Start_Comp.Name = "Start_Comp";
            this.Start_Comp.Size = new System.Drawing.Size(136, 126);
            this.Start_Comp.TabIndex = 1;
            this.Start_Comp.UseVisualStyleBackColor = true;
            this.Start_Comp.Click += new System.EventHandler(this.Start_Comp_Click);
            // 
            // Stop_Comp
            // 
            this.Stop_Comp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Stop_Comp.BackgroundImage")));
            this.Stop_Comp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Stop_Comp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop_Comp.Location = new System.Drawing.Point(177, 144);
            this.Stop_Comp.Name = "Stop_Comp";
            this.Stop_Comp.Size = new System.Drawing.Size(134, 124);
            this.Stop_Comp.TabIndex = 2;
            this.Stop_Comp.UseVisualStyleBackColor = true;
            this.Stop_Comp.Visible = false;
            this.Stop_Comp.Click += new System.EventHandler(this.Stop_Comp_Click);
            // 
            // Lable_Waming
            // 
            this.Lable_Waming.Image = ((System.Drawing.Image)(resources.GetObject("Lable_Waming.Image")));
            this.Lable_Waming.Location = new System.Drawing.Point(12, 9);
            this.Lable_Waming.Name = "Lable_Waming";
            this.Lable_Waming.Size = new System.Drawing.Size(303, 194);
            this.Lable_Waming.TabIndex = 3;
            this.Lable_Waming.Text = "WARMING";
            this.Lable_Waming.Visible = false;
            this.Lable_Waming.Click += new System.EventHandler(this.Lable_Warming_Click);
            // 
            // ReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(327, 543);
            this.Controls.Add(this.Lable_Waming);
            this.Controls.Add(this.Stop_Comp);
            this.Controls.Add(this.Start_Comp);
            this.Controls.Add(this.HOMEPAGE);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportPage";
            this.Text = "ReportPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HOMEPAGE;
        private System.Windows.Forms.Button Start_Comp;
        private System.Windows.Forms.Button Stop_Comp;
        private System.Windows.Forms.Label Lable_Waming;
    }
}