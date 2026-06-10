using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFuzziAcademia
{
    public partial class frmListado : Form
    {
        public string[,] arrMateriasListado = new string[4, 5];
        public string[] arrPlanes = new string[5];
        int searchCount = 0;
        public frmListado()
        {
            InitializeComponent();
        }

        private void gbxSearch_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvGrilla.Rows.Clear();
            searchCount = 0;
            for (int row = 0; row < arrMateriasListado.GetLength(0); row++)
            {    
                if (arrMateriasListado[row, 0] != null)
                {
                    if (rbtAllSearch.Checked)
                    {
                        dgvGrilla.Rows.Add(arrMateriasListado[row, 0], arrMateriasListado[row, 1], arrMateriasListado[row, 2], arrMateriasListado[row, 3]);
                    }
                    if (rbtCodeSearch.Checked && arrMateriasListado[row, 0] == txtCodeSearch.Text)
                    {
                        dgvGrilla.Rows.Add(arrMateriasListado[row, 0], arrMateriasListado[row, 1], arrMateriasListado[row, 2], arrMateriasListado[row, 3]);
                        searchCount++;
                    }
                    if (rbtNameSearch.Checked && arrMateriasListado[row, 1] == txtNameSearch.Text)
                    {
                        dgvGrilla.Rows.Add(arrMateriasListado[row, 0], arrMateriasListado[row, 1], arrMateriasListado[row, 2], arrMateriasListado[row, 3]);
                        searchCount++;
                    }
                }
            }
            if (rbtAllSearch.Checked == false && searchCount == 0)
            {
                DialogResult result = MessageBox.Show("Materia no encontrada.", "Búsqueda de materias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmListado_Load(object sender, EventArgs e)
        {

        }

        private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal ventana = new frmPrincipal();
            ventana.arrMaterias = arrMateriasListado;
            ventana.arrPlanes = arrPlanes;
            ventana.ShowDialog();
        }

        private void rbtCodeSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCodeSearch.Checked)
            {
                txtCodeSearch.Enabled = true;
            }
            else
            {
                txtCodeSearch.Enabled = false;
            }
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtNameSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNameSearch.Checked)
            {
                txtNameSearch.Enabled = true;
            }
            else
            {
                txtNameSearch.Enabled = false;
            }
        }

        private void rbtPlanSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtPlanSearch.Checked)
            {
                cbxPlanSearch.Enabled = true;
                for (int count = 0; count < arrPlanes.Length; count++)
                {
                    if (arrPlanes[count] != null)
                    {
                        cbxPlanSearch.Items.Add(arrPlanes[count]);
                    }
                }
            }
            else
            {
                cbxPlanSearch.Enabled = false;
            }
        }

        private void cbxPlanSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodeSearch_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
