namespace WindowsFormsApp
{
    partial class DodajPodjetje
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBIme = new System.Windows.Forms.TextBox();
            this.txtBPanoga = new System.Windows.Forms.TextBox();
            this.bttOK = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Panoga:";
            // 
            // txtBIme
            // 
            this.txtBIme.Location = new System.Drawing.Point(108, 56);
            this.txtBIme.Name = "txtBIme";
            this.txtBIme.Size = new System.Drawing.Size(100, 20);
            this.txtBIme.TabIndex = 2;
            // 
            // txtBPanoga
            // 
            this.txtBPanoga.Location = new System.Drawing.Point(108, 103);
            this.txtBPanoga.Name = "txtBPanoga";
            this.txtBPanoga.Size = new System.Drawing.Size(100, 20);
            this.txtBPanoga.TabIndex = 3;
            // 
            // bttOK
            // 
            this.bttOK.Location = new System.Drawing.Point(49, 173);
            this.bttOK.Name = "bttOK";
            this.bttOK.Size = new System.Drawing.Size(75, 23);
            this.bttOK.TabIndex = 4;
            this.bttOK.Text = "Potrdi";
            this.bttOK.UseVisualStyleBackColor = true;
            this.bttOK.Click += new System.EventHandler(this.bttOK_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(133, 173);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(75, 23);
            this.bttCancel.TabIndex = 5;
            this.bttCancel.Text = "Prekliči";
            this.bttCancel.UseVisualStyleBackColor = true;
            // 
            // DodajPodjetje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttOK);
            this.Controls.Add(this.txtBPanoga);
            this.Controls.Add(this.txtBIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajPodjetje";
            this.Text = "DodajPodjetje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBIme;
        private System.Windows.Forms.TextBox txtBPanoga;
        private System.Windows.Forms.Button bttOK;
        private System.Windows.Forms.Button bttCancel;
    }
}