namespace WindowsFormsApp
{
    partial class IzberiOsebo
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
            this.bttOk = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttOk
            // 
            this.bttOk.Location = new System.Drawing.Point(124, 209);
            this.bttOk.Name = "bttOk";
            this.bttOk.Size = new System.Drawing.Size(75, 23);
            this.bttOk.TabIndex = 1;
            this.bttOk.Text = "Potrdi";
            this.bttOk.UseVisualStyleBackColor = true;
            this.bttOk.Click += new System.EventHandler(this.bttOk_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(239, 209);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(75, 23);
            this.bttCancel.TabIndex = 2;
            this.bttCancel.Text = "Prekliči";
            this.bttCancel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(367, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // IzberiOsebo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttOk);
            this.Name = "IzberiOsebo";
            this.Text = "IzberiOsebo";
            this.Load += new System.EventHandler(this.IzberiOsebo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bttOk;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}