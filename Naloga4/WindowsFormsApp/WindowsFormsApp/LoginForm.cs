using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Resources;
using System.Reflection;

namespace WindowsFormsApp
{
    public partial class LoginForm : Form
    {
        bool isAdmin = false;
        localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
        MainForm mainForm = new MainForm();
        public LoginForm()
        {
            InitializeComponent();
            bttlogin.DialogResult = DialogResult.OK;

            string s = mainForm.getLanguage();
            ChangeLanguage(s);
        }
        public void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                 ComponentResourceManager resources = new ComponentResourceManager(typeof(LoginForm));
                 resources.ApplyResources(c, c.Name, new CultureInfo(lang));
                
                ComponentResourceManager resourcesss = new ComponentResourceManager(typeof(LoginForm));
                CultureInfo cult = new CultureInfo(lang);

                //foreach (ToolStripItem m in menuStrip1.Items) //menu.Items)
                //{
                //    string text = resourcesss.GetString(m.Name + ".Text", cult);
                //    if (text != null)
                //    {
                //        m.Text = text;
                //    }
                //}

                //for (int j = 0; j < 4; j++)
                //{
                //    var i = (menuStrip1.Items[j] as ToolStripMenuItem).DropDownItems;
                //    foreach (ToolStripItem m in i) //menu.Items)
                //    {

                //        string text = resourcesss.GetString(m.Name + ".Text", cult);
                //        if (text != null)
                //        {
                //            m.Text = text;
                //        }
                //    }
                //}
            }
        }
            private void bttlogin_Click(object sender, EventArgs e)
        {
            if (services.isAdministrator(txtBLoginName.Text, txtBPass.Text))
            {
                MessageBox.Show("Successful login for Admin");
                isAdmin = true;
            }
            this.Close();
        }
        public bool getIsAdmin()
        {
            return isAdmin;
        }
    }
}
