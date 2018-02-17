namespace WindowsFormsApp
{
    partial class OdstraniOseboIZzPodjetjaForm
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
            this.dataGridViewOseba = new System.Windows.Forms.DataGridView();
            this.dataGridViewPodjetje = new System.Windows.Forms.DataGridView();
            this.bttOk = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOseba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPodjetje)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOseba
            // 
            this.dataGridViewOseba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOseba.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOseba.Name = "dataGridViewOseba";
            this.dataGridViewOseba.Size = new System.Drawing.Size(336, 236);
            this.dataGridViewOseba.TabIndex = 0;
            this.dataGridViewOseba.SelectionChanged += new System.EventHandler(this.dataGridViewOseba_SelectionChanged);
            // 
            // dataGridViewPodjetje
            // 
            this.dataGridViewPodjetje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPodjetje.Location = new System.Drawing.Point(381, 12);
            this.dataGridViewPodjetje.Name = "dataGridViewPodjetje";
            this.dataGridViewPodjetje.Size = new System.Drawing.Size(336, 236);
            this.dataGridViewPodjetje.TabIndex = 1;
            this.dataGridViewPodjetje.SelectionChanged += new System.EventHandler(this.dataGridViewPodjetje_SelectionChanged);
            // 
            // bttOk
            // 
            this.bttOk.Location = new System.Drawing.Point(273, 269);
            this.bttOk.Name = "bttOk";
            this.bttOk.Size = new System.Drawing.Size(75, 23);
            this.bttOk.TabIndex = 2;
            this.bttOk.Text = "Potrdi";
            this.bttOk.UseVisualStyleBackColor = true;
            this.bttOk.Click += new System.EventHandler(this.bttOk_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(381, 269);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(75, 23);
            this.bttCancel.TabIndex = 3;
            this.bttCancel.Text = "Prekliči";
            this.bttCancel.UseVisualStyleBackColor = true;
            // 
            // OdstraniOseboIZzPodjetjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 304);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttOk);
            this.Controls.Add(this.dataGridViewPodjetje);
            this.Controls.Add(this.dataGridViewOseba);
            this.Name = "OdstraniOseboIZzPodjetjaForm";
            this.Text = "OdstraniOseboIZzPodjetjaForm";
            this.Load += new System.EventHandler(this.OdstraniOseboIZzPodjetjaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOseba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPodjetje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOseba;
        private System.Windows.Forms.DataGridView dataGridViewPodjetje;
        private System.Windows.Forms.Button bttOk;
        private System.Windows.Forms.Button bttCancel;
    }
}