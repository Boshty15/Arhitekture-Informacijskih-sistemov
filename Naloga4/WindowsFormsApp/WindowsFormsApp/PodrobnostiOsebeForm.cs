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
    public partial class PodrobnostiOsebeForm : Form
    {
        localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
        public PodrobnostiOsebeForm()
        {
            InitializeComponent();
            

        }

        private void PodrobnostiOsebeForm_Load(object sender, EventArgs e)
        {
            

        }

        private void bttPrikazi_Click(object sender, EventArgs e)
        {
            localhost.Oseba o2 = services.getOsebaIme(txtBImeOsebe.Text);

            label2.Text = o2.ime + " " + o2.priimek + " " + o2.letoRojstva;
        }
    }
}
