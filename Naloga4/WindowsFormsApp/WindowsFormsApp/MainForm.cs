using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;
using System.Threading;
using System.Resources;
using System.Reflection;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
        bool isAdmin = false;
        bool izpisOseb = false;
        bool odstraniOsebo = false, odstraniPodjetje = false;
        int indexOdstraniOsebo;
        int indexOdstraniPodjetje;
        static string language;
        public MainForm()
        {
            InitializeComponent();
            adminToolStripMenuItem.Enabled = isAdmin;
            bttOdstrani.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm frm2 = new LoginForm();
            DialogResult dr = frm2.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                frm2.Close();
            }
            else if (dr == DialogResult.OK)
            {
                isAdmin = frm2.getIsAdmin();
                frm2.Close();
                adminToolStripMenuItem.Enabled = isAdmin;
            }
        }

        private void izpisVsehOsebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            localhost.Oseba[] oseba = services.getOsebeAll();
            bindingSource1.DataSource = oseba;

            dataGridView1.DataSource = bindingSource1;
            izpisOseb = true;
            //dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }

        private void izpisVsehPodjetijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            localhost.Podjetje[] podjetje = services.getPodjetjeAll();
            dataGridView1.DataSource = podjetje;
            //dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }

        private void izpisVsehOsebVPodjetjuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pod = null;
            IzberiPodjetje imeOsebe = new IzberiPodjetje();
            DialogResult dr = imeOsebe.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                imeOsebe.Close();
            }
            else if (dr == DialogResult.OK)
            {
                pod = imeOsebe.getImePodjetja();
                imeOsebe.Close();
            }

            localhost.Oseba[] osebaVPod = services.listaOseb(pod);
            dataGridView1.DataSource = osebaVPod;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataTable table = dataGridView1.DataSource as DataTable;

            if (dataGridView1.SortOrder.ToString() == "Descending") // Check if sorting is Descending
            {
                table.DefaultView.Sort = dataGridView1.SortedColumn.Name + " DESC"; // Get Sorted Column name and sort it in Descending order
            }
            else
            {
                table.DefaultView.Sort = dataGridView1.SortedColumn.Name + " ASC";  // Otherwise sort it in Ascending order
            }
            table = table.DefaultView.ToTable();

        }
        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //sort column 1 descending on a 'D' press
            if (e.KeyCode == Keys.D)
                dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);

            //sort column 1 Ascending on a 'U' press
            if (e.KeyCode == Keys.U)
            {
                //dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
                List<localhost.Oseba> list = services.getOsebeAll().ToList();
                //bindingSource1.DataSource = list.OrderBy("Ime ASCC").ToList();
            }
                
        }

        private void izpisVsehToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ime= null;
            IzberiOsebo izberiOsebo = new IzberiOsebo();
            DialogResult dr = izberiOsebo.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                izberiOsebo.Close();
            }
            else if (dr == DialogResult.OK)
            {
                ime= izberiOsebo.getImeOsebea();
                izberiOsebo.Close();
            }

            localhost.Podjetje[] osebaVPod2 = services.listaPodjetja(ime);
            dataGridView1.DataSource = osebaVPod2;

        }

        private void izpisPodrobnostiOsebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PodrobnostiOsebeForm podrobnostiOsebeForm = new PodrobnostiOsebeForm();
            podrobnostiOsebeForm.Show();
            

        }

        private void izpisNajmlajšeOsebeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            localhost.Oseba o = services.minOseba();
            MessageBox.Show(o.ime + " " + o.priimek + " " + o.letoRojstva);
        }

        private void izpisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(services.povprecna());
        }
        

        private void dodajOseboToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DodajOseboForm dodajOseboForm = new DodajOseboForm();
            bool isOk = false;
            DialogResult dr = dodajOseboForm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                dodajOseboForm.Close();
            }
            else if (dr == DialogResult.OK)
            {
                isOk = dodajOseboForm.getIsOK();
                dodajOseboForm.Close();

                localhost.Oseba[] oseba = services.getOsebeAll();
                dataGridView1.DataSource = oseba;
            }
               

        }

        private void dodajPodjetjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajPodjetje dodajPodjetje = new DodajPodjetje();
            bool isOk = false;
            DialogResult dr = dodajPodjetje.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                dodajPodjetje.Close();
            }
            else if (dr == DialogResult.OK)
            {
                isOk = dodajPodjetje.getIsOK();
                dodajPodjetje.Close();

                localhost.Podjetje[] podjetje = services.getPodjetjeAll();
                dataGridView1.DataSource = podjetje;
            }
        }

        private void odstraniOseboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bttOdstrani.Enabled = true;
            localhost.Oseba[] oseba = services.getOsebeAll();
            dataGridView1.DataSource = oseba;

            MessageBox.Show("Izberi osebo, ki jo želiš ostraniti.");
            odstraniOsebo = true;

            oseba = services.getOsebeAll();
            dataGridView1.DataSource = oseba;


        }
        private void odstraniPodjetjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bttOdstrani.Enabled = true;
            localhost.Podjetje[] podjetje = services.getPodjetjeAll();
            dataGridView1.DataSource = podjetje;
            bttOdstrani.Text = "Odstrani Podjetje";

            MessageBox.Show("Izberi podjetje, ki jo želiš odstraniti.");

            odstraniPodjetje = true;

            podjetje = services.getPodjetjeAll();
            dataGridView1.DataSource = podjetje;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (odstraniOsebo)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                    indexOdstraniOsebo = Convert.ToInt32(selectedRow.Cells[0].Value);
                   // MessageBox.Show(indexOdstraniOsebo.ToString());

                }
            }
            if (odstraniPodjetje)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                    indexOdstraniPodjetje = Convert.ToInt32(selectedRow.Cells[0].Value);
                     MessageBox.Show(indexOdstraniPodjetje.ToString());

                }
            }
            
        }

        private void odstraniOseboIzPodjetjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdstraniOseboIZzPodjetjaForm odstraniOseboIZzPodjetjaForm = new OdstraniOseboIZzPodjetjaForm();
            DialogResult dr = odstraniOseboIZzPodjetjaForm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                odstraniOseboIZzPodjetjaForm.Close();
            }
            else if (dr == DialogResult.OK)
            {
                //isOk = dodajPodjetje.getIsOK();
                odstraniOseboIZzPodjetjaForm.Close();
                string i = odstraniOseboIZzPodjetjaForm.getPodatki();

                localhost.Oseba[] osebaVPod = services.listaOseb(i);
                dataGridView1.DataSource = osebaVPod;

            }


        }

        private void dodajOseboVPodjetjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int letoDo, indexO, indexP;
            string delovnoM, naziv;

            DodajOseboVPodjetjeForm dodajOseboVPodjetjeForm = new DodajOseboVPodjetjeForm();
            DialogResult dr = dodajOseboVPodjetjeForm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                dodajOseboVPodjetjeForm.Close();
            }
            else if (dr == DialogResult.OK)
            {
                //isOk = dodajPodjetje.getIsOK();
                dodajOseboVPodjetjeForm.Close();
                letoDo = dodajOseboVPodjetjeForm.getLetoDo();
                indexO = dodajOseboVPodjetjeForm.getIndexOseba();
                indexP = dodajOseboVPodjetjeForm.getIndexPodjetje();
                delovnoM = dodajOseboVPodjetjeForm.getDelovnoMesto();
                naziv = dodajOseboVPodjetjeForm.getNaziv();

                if (services.AddOsebaVPodjetjeByIndex(indexO, indexP, delovnoM, letoDo) == 1)
                {
                    MessageBox.Show("Oseba dodana v podjetje.");
                }
                localhost.Oseba[] osebaVPod = services.listaOseb(naziv);
                dataGridView1.DataSource = osebaVPod;

            }

        }

        private void urejanjeOsebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ime, priimek, newIme, newPriimek;
            int letoDo;
            UrejanjeOsebForm urejanjeOsebForm = new UrejanjeOsebForm();
            DialogResult dr = urejanjeOsebForm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                urejanjeOsebForm.Close();
            }
            else if (dr == DialogResult.OK)
            {
                //isOk = dodajPodjetje.getIsOK();
                urejanjeOsebForm.Close();
                ime = urejanjeOsebForm.getIme();
                priimek = urejanjeOsebForm.getPriimek();
                letoDo = urejanjeOsebForm.getLetoDo();
                newIme = urejanjeOsebForm.getNewIme();
                newPriimek = urejanjeOsebForm.getNewPriimek();

                if (services.UpdateOsebe(ime, priimek, newIme, newPriimek,letoDo) == 1)
                    MessageBox.Show("Uspešno urejanje Osebe");

                localhost.Oseba[] oseba = services.getOsebeAll();

                dataGridView1.DataSource = oseba;
            }
        }

        private void urejanjePodjetijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string naziv, newNaziv, newPanoga;
            int leto;
            UrejanjePodjetjaForm urejanjePodjetjaForm = new UrejanjePodjetjaForm();
            DialogResult dr = urejanjePodjetjaForm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                urejanjePodjetjaForm.Close();
            }
            else if (dr == DialogResult.OK)
            {
                //isOk = dodajPodjetje.getIsOK();
                urejanjePodjetjaForm.Close();
                naziv = urejanjePodjetjaForm.getNaziv();
                newNaziv = urejanjePodjetjaForm.getNewNaziv();
                newPanoga = urejanjePodjetjaForm.getPanoga();
                leto = urejanjePodjetjaForm.getLetoDo();

                if (services.UpdatePodjetje(naziv,newNaziv,newPanoga,leto) == 1)
                    MessageBox.Show("Uspešno urejanje Podjetja");

                localhost.Podjetje[] podjetje = services.getPodjetjeAll();

                dataGridView1.DataSource = podjetje;
            }


        }
        public string getLanguage()
        {
            return language;
        }
        public  void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                // ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
                // resources.ApplyResources(c, c.Name, new CultureInfo(lang));

                language = lang;
                ComponentResourceManager resourcesss = new ComponentResourceManager(typeof(MainForm));
                CultureInfo cult = new CultureInfo(lang);

                foreach (ToolStripItem m in menuStrip1.Items) //menu.Items)
                {
                    string text = resourcesss.GetString(m.Name + ".Text", cult);
                    if (text != null)
                    {
                        m.Text = text;
                    }
                }

                for (int j = 0; j < 4; j++)
                {
                    var i = (menuStrip1.Items[j] as ToolStripMenuItem).DropDownItems;
                    foreach (ToolStripItem m in i) //menu.Items)
                    {

                        string text = resourcesss.GetString(m.Name + ".Text", cult);
                        if (text != null)
                        {
                            m.Text = text;
                        }
                    }
                }
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //System.Threading.Thread.CurrentThread.CurrentCulture =
            //   System.Globalization.CultureInfo.GetCultureInfo("en");

            ChangeLanguage("en");
            language = "en";
            //Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en");

            

            //foreach (ToolStripItem m in menuStrip1.Items) //menu.Items)
            //{
            //    string text = resourcesss.GetString(m.Name + ".Text", cult);
            //    if (text != null)
            //    {
            //        m.Text = text;
            //    }
            //}

            //for(int j = 0; j < 4; j++)
            //{
            //    var i = (menuStrip1.Items[j] as ToolStripMenuItem).DropDownItems;
            //    foreach (ToolStripItem m in i) //menu.Items)
            //    {

            //        string text = resourcesss.GetString(m.Name + ".Text", cult);
            //        if (text != null)
            //        {
            //            m.Text = text;
            //        }
            //    }
            //}
            
        }

        private void sloveniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // System.Threading.Thread.CurrentThread.CurrentCulture =
            //    System.Globalization.CultureInfo.GetCultureInfo("sl");
            ChangeLanguage("sl-SL");
            language = "sl-Sl";
            //Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("sl-SL")


            //viewToolStripMenuItem.Text = "Pogledi";
            ComponentResourceManager resourcesss = new ComponentResourceManager(typeof(MainForm));
            CultureInfo cult = new CultureInfo("sl-Sl");

            //foreach (ToolStripItem m in menuStrip1.Items) //menu.Items)
            //{
            //    string text = resourcesss.GetString(m.Name + ".Text", cult);
            //    if (text != null)
            //    {
            //        m.Text = text;
            //    }
            //}
            //for (int j = 0; j < 4; j++)
            //{
            //    var i = (menuStrip1.Items[j] as ToolStripMenuItem).DropDownItems;
            //    foreach (ToolStripItem m in i) //menu.Items)
            //    {

            //        string text = resourcesss.GetString(m.Name + ".Text", cult);
            //        if (text != null)
            //        {
            //            m.Text = text;
            //        }
            //    }
            //}
            //foreach (ToolStripItem co in contextMenuStrip1.Items) //menu.Items)
            //{
            //    string text = resourcesss.GetString(co.Name + ".Text", cult);
            //    if (text != null)
            //    {
            //        co.Text = text;
            //    }
            //}


        }

        private void bttOdstrani_Click(object sender, EventArgs e)
        {

            if (odstraniOsebo)
            {
                services.OdstraniOsebo(indexOdstraniOsebo);

                odstraniOsebo = false;

                localhost.Oseba[] oseba = services.getOsebeAll();
                dataGridView1.DataSource = oseba;
            }
            if (odstraniPodjetje)
            {
                services.OdstraniPodjetje(indexOdstraniPodjetje);

                odstraniPodjetje = false;

                localhost.Podjetje[] podjetje = services.getPodjetjeAll();
                dataGridView1.DataSource = podjetje;
            }

            
        }

        
    }
}

