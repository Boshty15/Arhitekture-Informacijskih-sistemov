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
    public partial class UrejanjeOsebForm : Form
    {
        localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
        int index, letoDo;
        string ime, priimek, newIme,newwPriimek;
        public UrejanjeOsebForm()
        {
            InitializeComponent();
            bttOk.DialogResult = DialogResult.OK;
            bttCancel.DialogResult = DialogResult.Cancel;

            localhost.Oseba[] oseba = services.getOsebeAll();
            dataGridView1.DataSource = oseba;
        }

        private void bttOk_Click(object sender, EventArgs e)
        {
            newIme = txtBIme.Text;
            newwPriimek = txtBPriimek.Text;
            letoDo = Convert.ToInt32(txtBLeto.Text);

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                index = Convert.ToInt32(selectedRow.Cells[0].Value);
                ime = Convert.ToString(selectedRow.Cells[1].Value);
                priimek = Convert.ToString(selectedRow.Cells[2].Value);
                letoDo = Convert.ToInt32(selectedRow.Cells[3].Value);
                // MessageBox.Show(indexOdstraniOsebo.ToString());
                txtBIme.Text = ime;
                txtBPriimek.Text = priimek;
                txtBLeto.Text = letoDo.ToString();


            }
        }
        public string getNewIme()
        {
            return newIme;
        }
        public string getNewPriimek()
        {
            return newwPriimek;
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
    }
}
