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
    public partial class DodajPodjetje : Form
    {
        bool isOk = false;
        localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
        public DodajPodjetje()
        {
            InitializeComponent();
            bttOK.DialogResult = DialogResult.OK;
            bttCancel.DialogResult = DialogResult.Cancel;
            
        }
        public bool getIsOK()
        {
            return isOk;
        }
        private void bttOK_Click(object sender, EventArgs e)
        {
            if (services.InsertNewPodjetje(txtBIme.Text, txtBPanoga.Text, DateTime.Now.Year) == 1)
            {
                MessageBox.Show("Uspešno dodano podjetje");
            }
        }
    }
}
