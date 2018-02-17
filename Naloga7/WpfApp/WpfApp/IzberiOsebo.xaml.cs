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
    /// Interaction logic for IzberiOsebo.xaml
    /// </summary>
    public partial class IzberiOsebo : Window
    {
        string imeOsebe = null;
        public IzberiOsebo()
        {
            InitializeComponent();
            localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
            localhost.Oseba[] oseba = services.getOsebeAll();

            dataGridView1.ItemsSource = oseba;
        }

        private void bttPotrdi_Click(object sender, RoutedEventArgs e)
        {
            localhost.Oseba p = (localhost.Oseba)dataGridView1.SelectedItem;
            imeOsebe = p.ime;

            this.DialogResult = true;
            this.Close();
        }
        public string getImeOsebea()
        {

            return imeOsebe;
        }

        private void bttPreklici_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
