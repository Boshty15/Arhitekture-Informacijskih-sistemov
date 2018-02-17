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
    public partial class DodajOseboForm : Form
    {
        bool isOk = false;
        localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
        public DodajOseboForm()
        {
            
            InitializeComponent();
            bttOK.DialogResult = DialogResult.OK;
            bttBCancel.DialogResult = DialogResult.Cancel;

        }

        private void DodajOseboForm_Load(object sender, EventArgs e)
        {
            int leto = DateTime.Now.Year;
            for(int i = 0; i < 100; i++)
            {
                comboBox1.Items.Add(leto);
                leto--;
            }

        }
        public bool getIsOK()
        {
            return isOk;
        }
        private void bttOK_Click(object sender, EventArgs e)
        {
            //isOk = true;
           // MessageBox.Show(comboBox1.Text);
            //services.InsertNewOseba(txtBIme.Text, txtBPriimek.Text, int.Parse(comboBox1.Text));

            if (services.InsertNewOseba(txtBIme.Text, txtBPriimek.Text, int.Parse(comboBox1.Text)) == 1)
            {
                MessageBox.Show("Uspešno dodana oseba");
            }

            this.Close();
        }
    }
}
