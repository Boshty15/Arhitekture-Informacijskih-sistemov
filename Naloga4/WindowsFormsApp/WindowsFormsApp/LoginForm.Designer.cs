namespace WindowsFormsApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.bttlogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBLoginName = new System.Windows.Forms.TextBox();
            this.txtBPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttlogin
            // 
            resources.ApplyResources(this.bttlogin, "bttlogin");
            this.bttlogin.Name = "bttlogin";
            this.bttlogin.UseVisualStyleBackColor = true;
            this.bttlogin.Click += new System.EventHandler(this.bttlogin_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtBLoginName
            // 
            resources.ApplyResources(this.txtBLoginName, "txtBLoginName");
            this.txtBLoginName.Name = "txtBLoginName";
            // 
            // txtBPass
            // 
            resources.ApplyResources(this.txtBPass, "txtBPass");
            this.txtBPass.Name = "txtBPass";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBPass);
            this.Controls.Add(this.txtBLoginName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttlogin);
            this.Name = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttlogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBLoginName;
        private System.Windows.Forms.TextBox txtBPass;
    }
}