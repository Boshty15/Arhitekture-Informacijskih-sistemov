namespace WindowsFormsApp
{
    partial class DodajOseboForm
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
            this.txtBPriimek = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bttOK = new System.Windows.Forms.Button();
            this.bttBCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime Osebe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Priimek Osebe:";
            // 
            // txtBIme
            // 
            this.txtBIme.Location = new System.Drawing.Point(146, 57);
            this.txtBIme.Name = "txtBIme";
            this.txtBIme.Size = new System.Drawing.Size(136, 20);
            this.txtBIme.TabIndex = 2;
            // 
            // txtBPriimek
            // 
            this.txtBPriimek.Location = new System.Drawing.Point(146, 112);
            this.txtBPriimek.Name = "txtBPriimek";
            this.txtBPriimek.Size = new System.Drawing.Size(136, 20);
            this.txtBPriimek.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Leto rojstva:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // bttOK
            // 
            this.bttOK.Location = new System.Drawing.Point(57, 225);
            this.bttOK.Name = "bttOK";
            this.bttOK.Size = new System.Drawing.Size(75, 23);
            this.bttOK.TabIndex = 6;
            this.bttOK.Text = "Potrdi";
            this.bttOK.UseVisualStyleBackColor = true;
            this.bttOK.Click += new System.EventHandler(this.bttOK_Click);
            // 
            // bttBCancel
            // 
            this.bttBCancel.Location = new System.Drawing.Point(207, 225);
            this.bttBCancel.Name = "bttBCancel";
            this.bttBCancel.Size = new System.Drawing.Size(75, 23);
            this.bttBCancel.TabIndex = 7;
            this.bttBCancel.Text = "Prekliči";
            this.bttBCancel.UseVisualStyleBackColor = true;
            // 
            // DodajOseboForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 309);
            this.Controls.Add(this.bttBCancel);
            this.Controls.Add(this.bttOK);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBPriimek);
            this.Controls.Add(this.txtBIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajOseboForm";
            this.Text = "DodajOseboForm";
            this.Load += new System.EventHandler(this.DodajOseboForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBIme;
        private System.Windows.Forms.TextBox txtBPriimek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bttOK;
        private System.Windows.Forms.Button bttBCancel;
    }
}