namespace SenDes0
{
    partial class Timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this.READY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // READY
            // 
            this.READY.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.READY.ForeColor = System.Drawing.Color.Black;
            this.READY.Image = ((System.Drawing.Image)(resources.GetObject("READY.Image")));
            this.READY.Location = new System.Drawing.Point(1, -1);
            this.READY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.READY.Name = "READY";
            this.READY.Size = new System.Drawing.Size(391, 174);
            this.READY.TabIndex = 0;
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(392, 546);
            this.Controls.Add(this.READY);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Timer";
            this.Text = "Timer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label READY;

    }
}