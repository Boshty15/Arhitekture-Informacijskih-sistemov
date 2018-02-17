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
    public partial class DodajOseboVPodjetjeForm : Form
    {
        int indexOseba, indexPodjetje, letoDO;
        string delovnoMesto, naziv;
        localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
        public DodajOseboVPodjetjeForm()
        {
            InitializeComponent();
            bttOk.DialogResult = DialogResult.OK;
            bttCancel.DialogResult = DialogResult.Cancel;

            localhost.Oseba[] oseba = services.getOsebeAll();
            dataGridViewOseba.DataSource = oseba;
            localhost.Podjetje[] podjetje = services.getPodjetjeAll();
            dataGridViewPod.DataSource = podjetje;


        }

        private void bttOk_Click(object sender, EventArgs e)
        {
            letoDO = Convert.ToInt32(txtBLetoDo.Text);
            delovnoMesto = txtBDelovnoMesto.Text;
        }

        private void dataGridViewOseba_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOseba.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewOseba.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewOseba.Rows[selectedrowindex];

                indexOseba = Convert.ToInt32(selectedRow.Cells[0].Value);
                // MessageBox.Show(indexOdstraniOsebo.ToString());

            }
        }

        private void dataGridViewPod_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPod.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridViewPod.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridViewPod.Rows[selectedrowindex];

                indexPodjetje = Convert.ToInt32(selectedRow.Cells[0].Value);
                naziv = Convert.ToString(selectedRow.Cells[1].Value);
                // MessageBox.Show(indexOdstraniOsebo.ToString());

            }
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
