﻿namespace SenDes0
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
            this.READY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // READY
            // 
            this.READY.AutoSize = true;
            this.READY.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.READY.Location = new System.Drawing.Point(91, 36);
            this.READY.Name = "READY";
            this.READY.Size = new System.Drawing.Size(111, 31);
            this.READY.TabIndex = 0;
            this.READY.Text = "READY";
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 267);
            this.Controls.Add(this.READY);
            this.Name = "Timer";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label READY;

    }
}