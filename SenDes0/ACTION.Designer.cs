namespace SenDes0
{
    partial class ACTION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACTION));
            this.GO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GO
            // 
            this.GO.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GO.Image = ((System.Drawing.Image)(resources.GetObject("GO.Image")));
            this.GO.Location = new System.Drawing.Point(22, 9);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(250, 61);
            this.GO.TabIndex = 0;
            // 
            // ACTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 451);
            this.Controls.Add(this.GO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ACTION";
            this.Text = "ACTION";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label GO;
    }
}