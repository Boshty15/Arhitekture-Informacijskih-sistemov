namespace WindowsFormsApp
{
    partial class DodajOseboVPodjetjeForm
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
            this.dataGridViewPod = new System.Windows.Forms.DataGridView();
            this.bttOk = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBDelovnoMesto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBLetoDo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOseba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPod)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOseba
            // 
            this.dataGridViewOseba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOseba.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOseba.Name = "dataGridViewOseba";
            this.dataGridViewOseba.Size = new System.Drawing.Size(341, 221);
            this.dataGridViewOseba.TabIndex = 0;
            this.dataGridViewOseba.SelectionChanged += new System.EventHandler(this.dataGridViewOseba_SelectionChanged);
            // 
            // dataGridViewPod
            // 
            this.dataGridViewPod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPod.Location = new System.Drawing.Point(385, 12);
            this.dataGridViewPod.Name = "dataGridViewPod";
            this.dataGridViewPod.Size = new System.Drawing.Size(341, 221);
            this.dataGridViewPod.TabIndex = 1;
            this.dataGridViewPod.SelectionChanged += new System.EventHandler(this.dataGridViewPod_SelectionChanged);
            // 
            // bttOk
            // 
            this.bttOk.Location = new System.Drawing.Point(278, 315);
            this.bttOk.Name = "bttOk";
            this.bttOk.Size = new System.Drawing.Size(75, 23);
            this.bttOk.TabIndex = 2;
            this.bttOk.Text = "Potrdi";
            this.bttOk.UseVisualStyleBackColor = true;
            this.bttOk.Click += new System.EventHandler(this.bttOk_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(385, 315);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(75, 23);
            this.bttCancel.TabIndex = 3;
            this.bttCancel.Text = "Prekliči";
            this.bttCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vnesi delovno mest:";
            // 
            // txtBDelovnoMesto
            // 
            this.txtBDelovnoMesto.Location = new System.Drawing.Point(122, 264);
            this.txtBDelovnoMesto.Name = "txtBDelovnoMesto";
            this.txtBDelovnoMesto.Size = new System.Drawing.Size(231, 20);
            this.txtBDelovnoMesto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vnesi leto do: ";
            // 
            // txtBLetoDo
            // 
            this.txtBLetoDo.Location = new System.Drawing.Point(465, 267);
            this.txtBLetoDo.Name = "txtBLetoDo";
            this.txtBLetoDo.Size = new System.Drawing.Size(261, 20);
            this.txtBLetoDo.TabIndex = 7;
            // 
            // DodajOseboVPodjetjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 379);
            this.Controls.Add(this.txtBLetoDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBDelovnoMesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttOk);
            this.Controls.Add(this.dataGridViewPod);
            this.Controls.Add(this.dataGridViewOseba);
            this.Name = "DodajOseboVPodjetjeForm";
            this.Text = "DodajOseboVPodjetjeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOseba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOseba;
        private System.Windows.Forms.DataGridView dataGridViewPod;
        private System.Windows.Forms.Button bttOk;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBDelovnoMesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBLetoDo;
    }
}