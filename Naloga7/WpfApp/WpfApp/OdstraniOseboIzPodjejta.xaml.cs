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
    /// Interaction logic for OdstraniOseboIzPodjejta.xaml
    /// </summary>
    public partial class OdstraniOseboIzPodjejta : Window
    {
        localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
        string naziv;
        public OdstraniOseboIzPodjejta()
        {
            InitializeComponent();
            localhost.Oseba[] oseba = services.getOsebeAll();
            dataGridViewOseba.ItemsSource = oseba;
            localhost.Podjetje[] podjetje = services.getPodjetjeAll();
            dataGridViewPod.ItemsSource = podjetje;
        }

        private void bttPotrdi_Click(object sender, RoutedEventArgs e)
        {
            localhost.Oseba o = (localhost.Oseba)dataGridViewOseba.SelectedItem;
            //MessageBox.Show(o.OsebaId.ToString());
            int indexOseba = o.OsebaId;

            localhost.Podjetje p = (localhost.Podjetje)dataGridViewPod.SelectedItem;
            int indexPodjetje = p.PodjetjeId;
            naziv = p.naziv;

            if (services.OdstraniOseboIzPodjetjaByIndex(indexOseba, indexPodjetje) == 1)
            {
                MessageBox.Show("Usprešno odstranjena oseba iz podjetja.");
            }

            this.DialogResult = true;
            this.Close();
        }
        public string getPodatki()
        {
            return naziv;
        }
        private void bttPreklici_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
