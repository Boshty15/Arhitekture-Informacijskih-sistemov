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
    public partial class OdstraniOseboIZzPodjetjaForm : Form
    {
        localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
        string ime, priimek, naziv;
        int indexOseba, indexPodjetje;
        public OdstraniOseboIZzPodjetjaForm()
        {
            InitializeComponent();
            bttOk.DialogResult = DialogResult.OK;
            bttCancel.DialogResult = DialogResult.Cancel;

            localhost.Oseba[] oseba = services.getOsebeAll();
            dataGridViewOseba.DataSource = oseba;
            localhost.Podjetje[] podjetje = services.getPodjetjeAll();
            dataGridViewPodjetje.DataSource = podjetje;

        }

        private void dataGridViewOseba_SelectionChanged(object sender, EventArgs e)
        {
            //oseba
            if (dataGridViewOseba.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewOseba.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewOseba.Rows[selectedrowindex];

                indexOseba = Convert.ToInt32(selectedRow.Cells[0].Value);
                ime = Convert.ToString(selectedRow.Cells[1].Value);
                // MessageBox.Show(indexOdstraniOsebo.ToString());

                localhost.Podjetje[] osebaVPod2 = services.listaPodjetja(ime);
                dataGridViewPodjetje.DataSource = osebaVPod2;

            }

        }

        private void bttOk_Click(object sender, EventArgs e)
        {
            if (services.OdstraniOseboIzPodjetjaByIndex(indexOseba, indexPodjetje) == 1)
            {
                MessageBox.Show("Usprešno odstranjena oseba iz podjetja.");
            }
        }

        private void dataGridViewPodjetje_SelectionChanged(object sender, EventArgs e)
        {
            //podjetje
            if (dataGridViewPodjetje.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewPodjetje.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewPodjetje.Rows[selectedrowindex];

                indexPodjetje = Convert.ToInt32(selectedRow.Cells[0].Value);
                // MessageBox.Show(indexOdstraniOsebo.ToString());

            }

        }

        public string getPodatki()
        {
            return naziv;
        }
        private void OdstraniOseboIZzPodjetjaForm_Load(object sender, EventArgs e)
        {
            


        }
    }
}
