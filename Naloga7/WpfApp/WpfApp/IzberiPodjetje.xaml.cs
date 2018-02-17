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
    /// Interaction logic for IzberiPodjetje.xaml
    /// </summary>
    public partial class IzberiPodjetje : Window
    {
        string ime = null;
        public IzberiPodjetje()
        {
            InitializeComponent();
            localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
            localhost.Podjetje[] pod = services.getPodjetjeAll();

            dataGridView1.ItemsSource = pod;
        }

        private void bttPotrdi_Click(object sender, RoutedEventArgs e)
        {
            localhost.Podjetje p = (localhost.Podjetje)dataGridView1.SelectedItem;
            ime = p.naziv;

            this.DialogResult = true;
            this.Close();
        }
        public string getImePodjetja()
        {

            return ime;
        }


        private void bttPreklici_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
