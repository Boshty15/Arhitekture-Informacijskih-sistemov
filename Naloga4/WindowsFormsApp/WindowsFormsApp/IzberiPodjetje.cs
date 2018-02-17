using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class IzberiPodjetje : Form
    {
        string imePodjetja;
        localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
        public IzberiPodjetje()
        {
            InitializeComponent();
            bttCancel.DialogResult = DialogResult.Cancel;
            bttOK.DialogResult = DialogResult.OK;
        
            localhost.Podjetje[] podjetje = services.getPodjetjeAll();
            foreach (localhost.Podjetje p in podjetje)
            {
                //Console.WriteLine(o.ime + " " + o.priimek + " " + o.letoRojstva);
                listBox.Items.Add(p.PodjetjeId + " " + p.naziv + " " + p.panoga + " " + p.letoUstanovitve);
            }
        }

        private void bttOK_Click(object sender, EventArgs e)
        {
            //imeOsebe = textBox1.Text;
            this.Close();
        }
        public string getImePodjetja()
        {
            return imePodjetja;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ImeOsebe_Load(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox.FindString("1 FERI Šola 2000");
            string text = listBox.GetItemText(listBox.SelectedItem);
            text = text.Substring(2);
            int tmpIndex = text.IndexOf(' ');
            text = text.Substring(0, tmpIndex);
            imePodjetja = text;

            //imePodjetja = text.Substring(1, text.IndexOf(" ") + 1);
            //MessageBox.Show(text);

        }
    }
}
