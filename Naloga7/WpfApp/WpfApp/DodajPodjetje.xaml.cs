using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for DodajPodjetje.xaml
    /// </summary>
    public partial class DodajPodjetje : Window
    {
        bool isOk = false;
        localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
        public DodajPodjetje()
        {
            InitializeComponent();
        }

        private void bttPotrdi_Click(object sender, RoutedEventArgs e)
        {
            if (services.InsertNewPodjetje(txtBIme.Text, txtBPanoga.Text, DateTime.Now.Year) == 1)
            {
                MessageBox.Show("Uspešno dodano podjetje");
            }

            this.DialogResult = true;
            this.Close();
        }
        public bool getIsOK()
        {
            return isOk;
        }
        private void bttPreklici_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
