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
    /// Interaction logic for UrejanjeOseb.xaml
    /// </summary>
    public partial class UrejanjeOseb : Window
    {
        localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
        int index, letoDo;
        string ime, priimek, newIme, newwPriimek;
        public UrejanjeOseb()
        {
            InitializeComponent();
            localhost.Oseba[] oseba = services.getOsebeAll();

            dataGridView1.ItemsSource = oseba;
        }

        private void bttPotrdi_Click(object sender, RoutedEventArgs e)
        {
            localhost.Oseba p = (localhost.Oseba)dataGridView1.SelectedItem;
            index = p.OsebaId;

            newIme = txtBime.Text;
            newwPriimek = txtBPriimek.Text;
            letoDo = Convert.ToInt32(txtBDatum.Text);

            this.DialogResult = true;
            this.Close();
        }
        public string getNewIme()
        {
            return newIme;
        }
        public string getNewPriimek()
        {
            return newwPriimek;
        }

        private void dataGridView1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            localhost.Oseba p = (localhost.Oseba)dataGridView1.SelectedItem;
            index = p.OsebaId;
            ime = p.ime;
            priimek = p.priimek;
            letoDo = p.letoRojstva;

            txtBime.Text = ime;
            txtBPriimek.Text = priimek;
            txtBDatum.Text = letoDo.ToString();
        }

        public string getIme()
        {
            return ime;
        }
        public string getPriimek()
        {
            return priimek;
        }
        public int getLetoDo()
        {
            return letoDo;
        }
        private void bttPreklici_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
