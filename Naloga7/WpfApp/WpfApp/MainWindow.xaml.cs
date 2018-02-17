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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        bool isAdmin = false;
        localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
        bool izpisOseb = false;
        bool odstraniOsebo = false, odstraniPodjetje = false;
        int indexOdstraniOsebo;
        int indexOdstraniPodjetje;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bttPrijava_Click(object sender, RoutedEventArgs e)
        {
            LoginForm frm2 = new LoginForm();
            if ((bool)frm2.ShowDialog())
            {
                isAdmin = frm2.getIsAdmin();
                frm2.Close();
                //adminToolStripMenuItem.Enabled = isAdmin;
                bttAdminPogled.IsEnabled = true;
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            //Izpis vseh podjetij
            localhost.Podjetje[] podjetje = services.getPodjetjeAll();
            dataGridView1.ItemsSource = podjetje;

        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            //dodaj osebo
            DodajOseboForm dodajOseboForm = new DodajOseboForm();
            bool isOk = false;
            if ((bool)dodajOseboForm.ShowDialog())
            {
                isOk = dodajOseboForm.getIsOK();
                dodajOseboForm.Close();

                localhost.Oseba[] oseba = services.getOsebeAll();
                dataGridView1.ItemsSource = oseba;
            }

        
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            //Dodaj podjetje
            DodajPodjetje dodajPodjetje = new DodajPodjetje();
            bool isOk = false;
            if ((bool)dodajPodjetje.ShowDialog())
            {
                isOk = dodajPodjetje.getIsOK();
                dodajPodjetje.Close();

                localhost.Podjetje[] podjetje = services.getPodjetjeAll();
                dataGridView1.ItemsSource = podjetje;
            }

        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            //dodaj osebo v podjetje
            int letoDo, indexO, indexP;
            string delovnoM, naziv;
            DodajOseboVPodjetje dodajOseboVPodjetje = new DodajOseboVPodjetje();
            if ((bool)dodajOseboVPodjetje.ShowDialog())
            {
                dodajOseboVPodjetje.Close();
                letoDo = dodajOseboVPodjetje.getLetoDo();
                indexO = dodajOseboVPodjetje.getIndexOseba();
                indexP = dodajOseboVPodjetje.getIndexPodjetje();
                delovnoM = dodajOseboVPodjetje.getDelovnoMesto();
                naziv = dodajOseboVPodjetje.getNaziv();

                if (services.AddOsebaVPodjetjeByIndex(indexO, indexP, delovnoM, letoDo) == 1)
                {
                    MessageBox.Show("Oseba dodana v podjetje.");
                }
                localhost.Oseba[] osebaVPod = services.listaOseb(naziv);
                dataGridView1.ItemsSource = osebaVPod;
            }

        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            //odstrani osebo
            bttOdstrani.IsEnabled = true;
            localhost.Oseba[] oseba = services.getOsebeAll();
            dataGridView1.ItemsSource = oseba;

            MessageBox.Show("Izberi osebo, ki jo želiš ostraniti.");
            odstraniOsebo = true;

            oseba = services.getOsebeAll();
            dataGridView1.ItemsSource = oseba;

        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            //odstrani podjetje
            bttOdstrani.IsEnabled = true;
            localhost.Podjetje[] podjetje = services.getPodjetjeAll();
            dataGridView1.ItemsSource = podjetje;
            bttOdstrani.Content = "Odstrani Podjetje";

            MessageBox.Show("Izberi podjetje, ki jo želiš odstraniti.");

            odstraniPodjetje = true;

            podjetje = services.getPodjetjeAll();
            dataGridView1.ItemsSource = podjetje;
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            //odstrani osebo iz podjetja
            OdstraniOseboIzPodjejta odstraniOseboIzPodjejta = new OdstraniOseboIzPodjejta();
            if ((bool)odstraniOseboIzPodjejta.ShowDialog())
            {
                odstraniOseboIzPodjejta.Close();
                string i = odstraniOseboIzPodjejta.getPodatki();

                localhost.Oseba[] osebaVPod = services.listaOseb(i);
                dataGridView1.ItemsSource = osebaVPod;
            }

        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            //urejanje oseb
            string ime, priimek, newIme, newPriimek;
            int letoDo;

            UrejanjeOseb urejanjeOseb = new UrejanjeOseb();
            if ((bool)urejanjeOseb.ShowDialog())
            {
                urejanjeOseb.Close();
                ime = urejanjeOseb.getIme();
                priimek = urejanjeOseb.getPriimek();
                letoDo = urejanjeOseb.getLetoDo();
                newIme = urejanjeOseb.getNewIme();
                newPriimek = urejanjeOseb.getNewPriimek();

                if (services.UpdateOsebe(ime, priimek, newIme, newPriimek, letoDo) == 1)
                    MessageBox.Show("Uspešno urejanje Osebe");

                localhost.Oseba[] oseba = services.getOsebeAll();

                dataGridView1.ItemsSource = oseba;
            }

        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            //urejanje podjetij
        }

        private void bttOdstrani_Click(object sender, RoutedEventArgs e)
        {
            //odstrani btt
            if (odstraniOsebo)
            {
                localhost.Oseba o = (localhost.Oseba)dataGridView1.SelectedItem;
                //MessageBox.Show(o.OsebaId.ToString());
                indexOdstraniOsebo = o.OsebaId;

                services.OdstraniOsebo(indexOdstraniOsebo);

                odstraniOsebo = false;

                localhost.Oseba[] oseba = services.getOsebeAll();
                dataGridView1.ItemsSource = oseba;
            }
            if (odstraniPodjetje)
            {
                localhost.Podjetje p = (localhost.Podjetje)dataGridView1.SelectedItem;
                indexOdstraniPodjetje = p.PodjetjeId;
                services.OdstraniPodjetje(indexOdstraniPodjetje);

                odstraniPodjetje = false;

                localhost.Podjetje[] podjetje = services.getPodjetjeAll();
                dataGridView1.ItemsSource = podjetje;
            }

        }

        private void MenuItem_Click_10(object sender, RoutedEventArgs e)
        {
            //Izpis vseh oseb v podjetjau
            string pod = null;
            IzberiPodjetje izberiPodjetje = new IzberiPodjetje();
            if ((bool)izberiPodjetje.ShowDialog())
            {
               
                pod = izberiPodjetje.getImePodjetja();
                izberiPodjetje.Close();

                localhost.Oseba[] osebaVPod = services.listaOseb(pod);
                dataGridView1.ItemsSource = osebaVPod;
            }


        }

        private void MenuItem_Click_11(object sender, RoutedEventArgs e)
        {
            //izpis vsa podjetja osebe
            string ime = null;
            IzberiOsebo izberiOsebo = new IzberiOsebo();
            if ((bool)izberiOsebo.ShowDialog())
            {
                ime = izberiOsebo.getImeOsebea();
                izberiOsebo.Close();

                localhost.Podjetje[] osebaVPod2 = services.listaPodjetja(ime);
                dataGridView1.ItemsSource = osebaVPod2;
            }

        }

        private void MenuItem_Click_12(object sender, RoutedEventArgs e)
        {
            //izpis podrobnosti
            PodrobnostiOsebe podrobnostiOsebe = new PodrobnostiOsebe();
            podrobnostiOsebe.Show();

        }

        private void MenuItem_Click_13(object sender, RoutedEventArgs e)
        {
            //izpis najmlajpe osebe
            localhost.Oseba o = services.minOseba();
            MessageBox.Show(o.ime + " " + o.priimek + " " + o.letoRojstva);
        }

        private void MenuItem_Click_14(object sender, RoutedEventArgs e)
        {
            //izpis povprečne ustaonvitve podjetja
            MessageBox.Show(services.povprecna());
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //Izpis vseh oseb
            localhost.Oseba[] oseba = services.getOsebeAll();
            dataGridView1.ItemsSource = oseba;
            izpisOseb = true;
        }
    }
}
