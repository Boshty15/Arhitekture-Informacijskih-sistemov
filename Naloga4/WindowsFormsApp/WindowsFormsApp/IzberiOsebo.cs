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
    public partial class IzberiOsebo : Form
    {
        string imeOsebe = null;
        public IzberiOsebo()
        {
            InitializeComponent();
            bttOk.DialogResult = DialogResult.OK;
            bttCancel.DialogResult = DialogResult.Cancel;

            localhost.StoritveIzpiti services = new localhost.StoritveIzpiti();
            localhost.Oseba[] oseba = services.getOsebeAll();

            dataGridView1.DataSource = oseba;
        }

        private void IzberiOsebo_Load(object sender, EventArgs e)
        {

        }
        public string getImeOsebea()
        {

            return imeOsebe;
        }

        private void bttOk_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("test");
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                imeOsebe = Convert.ToString(selectedRow.Cells["Ime"].Value);
                //MessageBox.Show(imeOsebe);

            }
        }
    }
}
