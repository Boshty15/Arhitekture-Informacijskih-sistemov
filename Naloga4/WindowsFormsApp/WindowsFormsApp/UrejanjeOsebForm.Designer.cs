namespace WindowsFormsApp
{
    partial class UrejanjeOsebForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBIme = new System.Windows.Forms.TextBox();
            this.txtBPriimek = new System.Windows.Forms.TextBox();
            this.txtBLeto = new System.Windows.Forms.TextBox();
            this.bttOk = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(412, 198);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Priimek:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Leto rojstva:";
            // 
            // txtBIme
            // 
            this.txtBIme.Location = new System.Drawing.Point(524, 32);
            this.txtBIme.Name = "txtBIme";
            this.txtBIme.Size = new System.Drawing.Size(129, 20);
            this.txtBIme.TabIndex = 4;
            // 
            // txtBPriimek
            // 
            this.txtBPriimek.Location = new System.Drawing.Point(524, 67);
            this.txtBPriimek.Name = "txtBPriimek";
            this.txtBPriimek.Size = new System.Drawing.Size(129, 20);
            this.txtBPriimek.TabIndex = 5;
            // 
            // txtBLeto
            // 
            this.txtBLeto.Location = new System.Drawing.Point(524, 107);
            this.txtBLeto.Name = "txtBLeto";
            this.txtBLeto.Size = new System.Drawing.Size(129, 20);
            this.txtBLeto.TabIndex = 6;
            // 
            // bttOk
            // 
            this.bttOk.Location = new System.Drawing.Point(458, 186);
            this.bttOk.Name = "bttOk";
            this.bttOk.Size = new System.Drawing.Size(75, 23);
            this.bttOk.TabIndex = 7;
            this.bttOk.Text = "Potrdi";
            this.bttOk.UseVisualStyleBackColor = true;
            this.bttOk.Click += new System.EventHandler(this.bttOk_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(578, 186);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(75, 23);
            this.bttCancel.TabIndex = 8;
            this.bttCancel.Text = "Prekliči";
            this.bttCancel.UseVisualStyleBackColor = true;
            // 
            // UrejanjeOsebForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 287);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttOk);
            this.Controls.Add(this.txtBLeto);
            this.Controls.Add(this.txtBPriimek);
            this.Controls.Add(this.txtBIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UrejanjeOsebForm";
            this.Text = "UrejanjeOsebForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBIme;
        private System.Windows.Forms.TextBox txtBPriimek;
        private System.Windows.Forms.TextBox txtBLeto;
        private System.Windows.Forms.Button bttOk;
        private System.Windows.Forms.Button bttCancel;
    }
}