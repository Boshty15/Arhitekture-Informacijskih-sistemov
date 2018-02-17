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
    public partial class UrejanjePodjetjaForm : Form
    {
        int index, newLeto;
        string naziv, newNaziv, newPanoga;
        localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
        public UrejanjePodjetjaForm()
        {
            InitializeComponent();
            bttOk.DialogResult = DialogResult.OK;
            bttCancel.DialogResult = DialogResult.Cancel;

            localhost.Podjetje[] podjetje = services.getPodjetjeAll();
            dataGridView1.DataSource = podjetje;


        }

        private void bttOk_Click(object sender, EventArgs e)
        {
            newNaziv = txtBNaziv.Text;
            newLeto = Convert.ToInt32(txtBLetoDo.Text);
            newPanoga = txtBPanoga.Text;

        }
        public string getNewNaziv()
        {
            return newNaziv;
        }
        public string getNaziv()
        {
            return naziv;
        }
        public string getPanoga()
        {
            return newPanoga;
        }
        public int getLetoDo()
        {
            return newLeto;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                index = Convert.ToInt32(selectedRow.Cells[0].Value);
                naziv = Convert.ToString(selectedRow.Cells[1].Value);
                newPanoga = Convert.ToString(selectedRow.Cells[3].Value);
                newLeto = Convert.ToInt32(selectedRow.Cells[3].Value);
                txtBNaziv.Text = naziv;
                txtBPanoga.Text = newPanoga;
                txtBLetoDo.Text = newLeto.ToString();

            }
        }
    }
}
