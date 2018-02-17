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
    /// Interaction logic for DodajOseboForm.xaml
    /// </summary>
    public partial class DodajOseboForm : Window
    {
        bool isOk = false;
        localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
        public DodajOseboForm()
        {
            
            InitializeComponent();
            int leto = DateTime.Now.Year;
            for (int i = 0; i < 100; i++)
            {
                comboBox.Items.Add(leto);
                leto--;
            }
        }

        private void bttPotrdi_Click(object sender, RoutedEventArgs e)
        {
            if (services.InsertNewOseba(txtBIme.Text, txtBPriimek.Text, int.Parse(comboBox.Text)) == 1)
            {
                MessageBox.Show("Uspešno dodana oseba");
            }

            this.DialogResult = true;
            this.Close();
          
        }

        private void bttPreklici_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
        public bool getIsOK()
        {
            return isOk;
        }
    }
}
