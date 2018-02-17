namespace WindowsFormsApp
{
    partial class IzberiPodjetje
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
            this.bttOK = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bttOK
            // 
            this.bttOK.Location = new System.Drawing.Point(67, 185);
            this.bttOK.Name = "bttOK";
            this.bttOK.Size = new System.Drawing.Size(57, 23);
            this.bttOK.TabIndex = 2;
            this.bttOK.Text = "Potrdi";
            this.bttOK.UseVisualStyleBackColor = true;
            this.bttOK.Click += new System.EventHandler(this.bttOK_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(153, 185);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(57, 23);
            this.bttCancel.TabIndex = 3;
            this.bttCancel.Text = "Prekliči";
            this.bttCancel.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(55, 37);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(186, 121);
            this.listBox.TabIndex = 4;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // IzberiPodjetje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.bttCancel);
            this.Controls.Add(this.bttOK);
            this.Name = "IzberiPodjetje";
            this.Text = "Podjetje";
            this.Load += new System.EventHandler(this.ImeOsebe_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bttOK;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.ListBox listBox;
    }
}