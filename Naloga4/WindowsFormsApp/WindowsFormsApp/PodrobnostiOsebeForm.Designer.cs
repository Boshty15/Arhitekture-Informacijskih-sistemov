﻿namespace WindowsFormsApp
{
    partial class PodrobnostiOsebeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBImeOsebe = new System.Windows.Forms.TextBox();
            this.bttPrikazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime Osebe:";
            // 
            // txtBImeOsebe
            // 
            this.txtBImeOsebe.Location = new System.Drawing.Point(66, 69);
            this.txtBImeOsebe.Name = "txtBImeOsebe";
            this.txtBImeOsebe.Size = new System.Drawing.Size(142, 20);
            this.txtBImeOsebe.TabIndex = 1;
            // 
            // bttPrikazi
            // 
            this.bttPrikazi.Location = new System.Drawing.Point(91, 108);
            this.bttPrikazi.Name = "bttPrikazi";
            this.bttPrikazi.Size = new System.Drawing.Size(75, 23);
            this.bttPrikazi.TabIndex = 2;
            this.bttPrikazi.Text = "Prikaži";
            this.bttPrikazi.UseVisualStyleBackColor = true;
            this.bttPrikazi.Click += new System.EventHandler(this.bttPrikazi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // PodrobnostiOsebeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttPrikazi);
            this.Controls.Add(this.txtBImeOsebe);
            this.Controls.Add(this.label1);
            this.Name = "PodrobnostiOsebeForm";
            this.Text = "PodrobnostiOsebeForm";
            this.Load += new System.EventHandler(this.PodrobnostiOsebeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBImeOsebe;
        private System.Windows.Forms.Button bttPrikazi;
        private System.Windows.Forms.Label label2;
    }
}