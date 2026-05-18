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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void lblPlan_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            frmListado ventanaListado = new frmListado();
            ventanaListado.ShowDialog();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(txtCode.Text != "" && txtCode.MaskCompleted && txtName.Text != "" && cbxPlan.SelectedItem != null)
            {
                MessageBox.Show("Registro exitoso.", "Registro Materia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Completar los datos.", "Registro Materia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
