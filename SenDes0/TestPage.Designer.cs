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
            this.REST = new System.Windows.Forms.Button();
            this.RUN = new System.Windows.Forms.Button();
            this.WALK = new System.Windows.Forms.Button();
            this.DRIVE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HOMEPAGE
            // 
            this.HOMEPAGE.Location = new System.Drawing.Point(16, 474);
            this.HOMEPAGE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HOMEPAGE.Name = "HOMEPAGE";
            this.HOMEPAGE.Size = new System.Drawing.Size(343, 62);
            this.HOMEPAGE.TabIndex = 0;
            this.HOMEPAGE.Text = "HOME";
            this.HOMEPAGE.UseVisualStyleBackColor = true;
            this.HOMEPAGE.Click += new System.EventHandler(this.HOMEPAGE_Click);
            // 
            // RLS
            // 
            this.RLS.Location = new System.Drawing.Point(16, 15);
            this.RLS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RLS.Name = "RLS";
            this.RLS.Size = new System.Drawing.Size(343, 50);
            this.RLS.TabIndex = 1;
            this.RLS.Text = "RLS";
            this.RLS.UseVisualStyleBackColor = true;
            this.RLS.Click += new System.EventHandler(this.RLS_Click);
            // 
            // REST
            // 
            this.REST.Location = new System.Drawing.Point(16, 73);
            this.REST.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.REST.Name = "REST";
            this.REST.Size = new System.Drawing.Size(343, 54);
            this.REST.TabIndex = 2;
            this.REST.Text = "REST";
            this.REST.UseVisualStyleBackColor = true;
            this.REST.Click += new System.EventHandler(this.REST_Click);
            // 
            // RUN
            // 
            this.RUN.Location = new System.Drawing.Point(16, 134);
            this.RUN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RUN.Name = "RUN";
            this.RUN.Size = new System.Drawing.Size(343, 54);
            this.RUN.TabIndex = 3;
            this.RUN.Text = "RUN";
            this.RUN.UseVisualStyleBackColor = true;
            this.RUN.Click += new System.EventHandler(this.RUN_Click);
            // 
            // WALK
            // 
            this.WALK.Location = new System.Drawing.Point(16, 196);
            this.WALK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.WALK.Name = "WALK";
            this.WALK.Size = new System.Drawing.Size(343, 58);
            this.WALK.TabIndex = 4;
            this.WALK.Text = "WALK";
            this.WALK.UseVisualStyleBackColor = true;
            this.WALK.Click += new System.EventHandler(this.WALK_Click);
            // 
            // DRIVE
            // 
            this.DRIVE.Location = new System.Drawing.Point(16, 261);
            this.DRIVE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DRIVE.Name = "DRIVE";
            this.DRIVE.Size = new System.Drawing.Size(343, 57);
            this.DRIVE.TabIndex = 5;
            this.DRIVE.Text = "DRIVE";
            this.DRIVE.UseVisualStyleBackColor = true;
            this.DRIVE.Click += new System.EventHandler(this.DRIVE_Click);
            // 
            // TestPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 550);
            this.Controls.Add(this.DRIVE);
            this.Controls.Add(this.WALK);
            this.Controls.Add(this.RUN);
            this.Controls.Add(this.REST);
            this.Controls.Add(this.RLS);
            this.Controls.Add(this.HOMEPAGE);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TestPage";
            this.Text = "TestPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HOMEPAGE;
        private System.Windows.Forms.Button RLS;
        private System.Windows.Forms.Button REST;
        private System.Windows.Forms.Button RUN;
        private System.Windows.Forms.Button WALK;
        private System.Windows.Forms.Button DRIVE;
    }
}