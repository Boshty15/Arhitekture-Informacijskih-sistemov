namespace WindowsFormsApp
{
    partial class UrejanjePodjetjaForm
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
            this.txtBNaziv = new System.Windows.Forms.TextBox();
            this.txtBPanoga = new System.Windows.Forms.TextBox();
            this.txtBLetoDo = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Size = new System.Drawing.Size(407, 238);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Panoga:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Leto:";
            // 
            // txtBNaziv
            // 
            this.txtBNaziv.Location = new System.Drawing.Point(515, 55);
            this.txtBNaziv.Name = "txtBNaziv";
            this.txtBNaziv.Size = new System.Drawing.Size(141, 20);
            this.txtBNaziv.TabIndex = 4;
            // 
            // txtBPanoga
            // 
            this.txtBPanoga.Location = new System.Drawing.Point(515, 101);
            this.txtBPanoga.Name = "txtBPanoga";
            this.txtBPanoga.Size = new System.Drawing.Size(141, 20);
            this.txtBPanoga.TabIndex = 5;
            // 
            // txtBLetoDo
            // 
            this.txtBLetoDo.Location = new System.Drawing.Point(515, 155);
            this.txtBLetoDo.Name = "txtBLetoDo";
            this.txtBLetoDo.Size = new System.Drawing.Size(141, 20);
            this.txtBLetoDo.TabIndex = 6;
            // 
            // bttOk
            // 
            this.bttOk.Location = new System.Drawing.Point(463, 226);
            this.bttOk.Name = "bttOk";
            this.bttOk.Size = new System.Drawing.Size(75, 23);
            this.bttOk.TabIndex = 7;
            this.bttOk.Text = "Potrdi";
            this.bttOk.UseVisualStyleBackColor = true;
            this.bttOk.Click += new System.EventHandler(this.bttOk_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(581, 226);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(75, 23);
            this.bttCancel.TabIndex = 8;
            this.bttCancel.Text = "Prekliči";
            this.bttCancel.UseVisualStyleBackColor = true;
            // 
            // UrejanjePodjetjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 344);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttOk);
            this.Controls.Add(this.txtBLetoDo);
            this.Controls.Add(this.txtBPanoga);
            this.Controls.Add(this.txtBNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UrejanjePodjetjaForm";
            this.Text = "UrejanjePodjetjaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBNaziv;
        private System.Windows.Forms.TextBox txtBPanoga;
        private System.Windows.Forms.TextBox txtBLetoDo;
        private System.Windows.Forms.Button bttOk;
        private System.Windows.Forms.Button bttCancel;
    }
}