using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for DodajOseboVPodjetje.xaml
    /// </summary>
    public partial class DodajOseboVPodjetje : Window
    {
        int indexOseba, indexPodjetje, letoDO;
        string delovnoMesto, naziv;
        localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
        public DodajOseboVPodjetje()
        {
            InitializeComponent();
            localhost.Oseba[] oseba = services.getOsebeAll();
            dataGridViewOseba.ItemsSource = oseba;
            localhost.Podjetje[] podjetje = services.getPodjetjeAll();
            dataGridViewPod.ItemsSource = podjetje;
        }

        private void bttPotrdi_Click(object sender, RoutedEventArgs e)
        {
            /*DataRowView CompRow;
            int SComp;
            long CompID;

            SComp = dataGridViewOseba.SelectedIndex;
            CompRow = dataGridViewOseba.Items.GetItemAt(SComp) as DataRowView;
            CompID = Convert.ToInt16(CompRow["OsebaId"]);
            MessageBox.Show(CompID.ToString());*/

            localhost.Oseba o = (localhost.Oseba)dataGridViewOseba.SelectedItem;
            //MessageBox.Show(o.OsebaId.ToString());
            indexOseba = o.OsebaId;

            localhost.Podjetje p = (localhost.Podjetje)dataGridViewPod.SelectedItem;
            indexPodjetje = p.PodjetjeId;
            naziv = p.naziv;

            letoDO = Convert.ToInt32(txtBLetoDo.Text);
            delovnoMesto = txtBDelovnoMesto.Text;

            this.DialogResult = true;
            this.Close();
        }

        private void bttPreklici_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
        public string getNaziv()
        {
            return naziv;
        }
        public int getIndexOseba()
        {
            return indexOseba;
        }
        public int getIndexPodjetje()
        {
            return indexPodjetje;
        }
        public int getLetoDo()
        {
            return letoDO;
        }
        public string getDelovnoMesto()
        {
            return delovnoMesto;
        }
    }
}
