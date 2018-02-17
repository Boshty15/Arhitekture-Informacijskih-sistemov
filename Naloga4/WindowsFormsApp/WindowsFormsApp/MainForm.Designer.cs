namespace WindowsFormsApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sloveniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izpisVsehOsebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izpisVsehPodjetijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajOseboToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPodjetjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajOseboVPodjetjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odstraniOseboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odstraniPodjetjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odstraniOseboIzPodjetjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urejanjeOsebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urejanjePodjetijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izpisVsehOsebVPodjetjuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izpisVsehToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izpisPodrobnostiOsebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izpisNajmlajšeOsebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izpisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttOdstrani = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.viewToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sloveniaToolStripMenuItem,
            this.englishToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            resources.ApplyResources(this.filesToolStripMenuItem, "filesToolStripMenuItem");
            // 
            // sloveniaToolStripMenuItem
            // 
            this.sloveniaToolStripMenuItem.Name = "sloveniaToolStripMenuItem";
            resources.ApplyResources(this.sloveniaToolStripMenuItem, "sloveniaToolStripMenuItem");
            this.sloveniaToolStripMenuItem.Click += new System.EventHandler(this.sloveniaToolStripMenuItem_Click);
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            resources.ApplyResources(this.loginToolStripMenuItem, "loginToolStripMenuItem");
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izpisVsehOsebToolStripMenuItem,
            this.izpisVsehPodjetijToolStripMenuItem,
            this.dodajOseboToolStripMenuItem1,
            this.dodajPodjetjeToolStripMenuItem,
            this.dodajOseboVPodjetjeToolStripMenuItem,
            this.odstraniOseboToolStripMenuItem,
            this.odstraniPodjetjeToolStripMenuItem,
            this.odstraniOseboIzPodjetjaToolStripMenuItem,
            this.urejanjeOsebToolStripMenuItem,
            this.urejanjePodjetijToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            resources.ApplyResources(this.adminToolStripMenuItem, "adminToolStripMenuItem");
            // 
            // izpisVsehOsebToolStripMenuItem
            // 
            this.izpisVsehOsebToolStripMenuItem.Name = "izpisVsehOsebToolStripMenuItem";
            resources.ApplyResources(this.izpisVsehOsebToolStripMenuItem, "izpisVsehOsebToolStripMenuItem");
            this.izpisVsehOsebToolStripMenuItem.Click += new System.EventHandler(this.izpisVsehOsebToolStripMenuItem_Click);
            // 
            // izpisVsehPodjetijToolStripMenuItem
            // 
            this.izpisVsehPodjetijToolStripMenuItem.Name = "izpisVsehPodjetijToolStripMenuItem";
            resources.ApplyResources(this.izpisVsehPodjetijToolStripMenuItem, "izpisVsehPodjetijToolStripMenuItem");
            this.izpisVsehPodjetijToolStripMenuItem.Click += new System.EventHandler(this.izpisVsehPodjetijToolStripMenuItem_Click);
            // 
            // dodajOseboToolStripMenuItem1
            // 
            this.dodajOseboToolStripMenuItem1.Name = "dodajOseboToolStripMenuItem1";
            resources.ApplyResources(this.dodajOseboToolStripMenuItem1, "dodajOseboToolStripMenuItem1");
            this.dodajOseboToolStripMenuItem1.Click += new System.EventHandler(this.dodajOseboToolStripMenuItem1_Click);
            // 
            // dodajPodjetjeToolStripMenuItem
            // 
            this.dodajPodjetjeToolStripMenuItem.Name = "dodajPodjetjeToolStripMenuItem";
            resources.ApplyResources(this.dodajPodjetjeToolStripMenuItem, "dodajPodjetjeToolStripMenuItem");
            this.dodajPodjetjeToolStripMenuItem.Click += new System.EventHandler(this.dodajPodjetjeToolStripMenuItem_Click);
            // 
            // dodajOseboVPodjetjeToolStripMenuItem
            // 
            this.dodajOseboVPodjetjeToolStripMenuItem.Name = "dodajOseboVPodjetjeToolStripMenuItem";
            resources.ApplyResources(this.dodajOseboVPodjetjeToolStripMenuItem, "dodajOseboVPodjetjeToolStripMenuItem");
            this.dodajOseboVPodjetjeToolStripMenuItem.Click += new System.EventHandler(this.dodajOseboVPodjetjeToolStripMenuItem_Click);
            // 
            // odstraniOseboToolStripMenuItem
            // 
            this.odstraniOseboToolStripMenuItem.Name = "odstraniOseboToolStripMenuItem";
            resources.ApplyResources(this.odstraniOseboToolStripMenuItem, "odstraniOseboToolStripMenuItem");
            this.odstraniOseboToolStripMenuItem.Click += new System.EventHandler(this.odstraniOseboToolStripMenuItem_Click);
            // 
            // odstraniPodjetjeToolStripMenuItem
            // 
            this.odstraniPodjetjeToolStripMenuItem.Name = "odstraniPodjetjeToolStripMenuItem";
            resources.ApplyResources(this.odstraniPodjetjeToolStripMenuItem, "odstraniPodjetjeToolStripMenuItem");
            this.odstraniPodjetjeToolStripMenuItem.Click += new System.EventHandler(this.odstraniPodjetjeToolStripMenuItem_Click);
            // 
            // odstraniOseboIzPodjetjaToolStripMenuItem
            // 
            this.odstraniOseboIzPodjetjaToolStripMenuItem.Name = "odstraniOseboIzPodjetjaToolStripMenuItem";
            resources.ApplyResources(this.odstraniOseboIzPodjetjaToolStripMenuItem, "odstraniOseboIzPodjetjaToolStripMenuItem");
            this.odstraniOseboIzPodjetjaToolStripMenuItem.Click += new System.EventHandler(this.odstraniOseboIzPodjetjaToolStripMenuItem_Click);
            // 
            // urejanjeOsebToolStripMenuItem
            // 
            this.urejanjeOsebToolStripMenuItem.Name = "urejanjeOsebToolStripMenuItem";
            resources.ApplyResources(this.urejanjeOsebToolStripMenuItem, "urejanjeOsebToolStripMenuItem");
            this.urejanjeOsebToolStripMenuItem.Click += new System.EventHandler(this.urejanjeOsebToolStripMenuItem_Click);
            // 
            // urejanjePodjetijToolStripMenuItem
            // 
            this.urejanjePodjetijToolStripMenuItem.Name = "urejanjePodjetijToolStripMenuItem";
            resources.ApplyResources(this.urejanjePodjetijToolStripMenuItem, "urejanjePodjetijToolStripMenuItem");
            this.urejanjePodjetijToolStripMenuItem.Click += new System.EventHandler(this.urejanjePodjetijToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izpisVsehOsebVPodjetjuToolStripMenuItem,
            this.izpisVsehToolStripMenuItem,
            this.izpisPodrobnostiOsebeToolStripMenuItem,
            this.izpisNajmlajšeOsebeToolStripMenuItem,
            this.izpisToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // izpisVsehOsebVPodjetjuToolStripMenuItem
            // 
            this.izpisVsehOsebVPodjetjuToolStripMenuItem.Name = "izpisVsehOsebVPodjetjuToolStripMenuItem";
            resources.ApplyResources(this.izpisVsehOsebVPodjetjuToolStripMenuItem, "izpisVsehOsebVPodjetjuToolStripMenuItem");
            this.izpisVsehOsebVPodjetjuToolStripMenuItem.Click += new System.EventHandler(this.izpisVsehOsebVPodjetjuToolStripMenuItem_Click);
            // 
            // izpisVsehToolStripMenuItem
            // 
            this.izpisVsehToolStripMenuItem.Name = "izpisVsehToolStripMenuItem";
            resources.ApplyResources(this.izpisVsehToolStripMenuItem, "izpisVsehToolStripMenuItem");
            this.izpisVsehToolStripMenuItem.Click += new System.EventHandler(this.izpisVsehToolStripMenuItem_Click);
            // 
            // izpisPodrobnostiOsebeToolStripMenuItem
            // 
            this.izpisPodrobnostiOsebeToolStripMenuItem.Name = "izpisPodrobnostiOsebeToolStripMenuItem";
            resources.ApplyResources(this.izpisPodrobnostiOsebeToolStripMenuItem, "izpisPodrobnostiOsebeToolStripMenuItem");
            this.izpisPodrobnostiOsebeToolStripMenuItem.Click += new System.EventHandler(this.izpisPodrobnostiOsebeToolStripMenuItem_Click);
            // 
            // izpisNajmlajšeOsebeToolStripMenuItem
            // 
            this.izpisNajmlajšeOsebeToolStripMenuItem.Name = "izpisNajmlajšeOsebeToolStripMenuItem";
            resources.ApplyResources(this.izpisNajmlajšeOsebeToolStripMenuItem, "izpisNajmlajšeOsebeToolStripMenuItem");
            this.izpisNajmlajšeOsebeToolStripMenuItem.Click += new System.EventHandler(this.izpisNajmlajšeOsebeToolStripMenuItem_Click);
            // 
            // izpisToolStripMenuItem
            // 
            this.izpisToolStripMenuItem.Name = "izpisToolStripMenuItem";
            resources.ApplyResources(this.izpisToolStripMenuItem, "izpisToolStripMenuItem");
            this.izpisToolStripMenuItem.Click += new System.EventHandler(this.izpisToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // bttOdstrani
            // 
            resources.ApplyResources(this.bttOdstrani, "bttOdstrani");
            this.bttOdstrani.Name = "bttOdstrani";
            this.bttOdstrani.UseVisualStyleBackColor = true;
            this.bttOdstrani.Click += new System.EventHandler(this.bttOdstrani_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttOdstrani);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izpisVsehOsebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izpisVsehPodjetijToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izpisVsehOsebVPodjetjuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izpisVsehToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem izpisPodrobnostiOsebeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izpisNajmlajšeOsebeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izpisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajOseboToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodajPodjetjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odstraniOseboToolStripMenuItem;
        private System.Windows.Forms.Button bttOdstrani;
        private System.Windows.Forms.ToolStripMenuItem odstraniPodjetjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odstraniOseboIzPodjetjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajOseboVPodjetjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urejanjeOsebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urejanjePodjetijToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem sloveniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

