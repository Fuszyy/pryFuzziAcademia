using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace pryFuzziAcademia
{
    public partial class frmRegistro : Form
    {

        public DateTime varLoginDate;
        string[,] arrMaterias = new string[3, 5];
        int varRowCount = 0;

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
            cbxPlan.Enabled = true;
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
            if (txtCode.Text != "" && txtCode.MaskCompleted && txtName.Text != "" && cbxPlan.SelectedItem != null)
            {
                arrMaterias[0, varRowCount] = txtCode.Text;
                arrMaterias[1, varRowCount] = txtName.Text;
                if (chkActive.Checked) { arrMaterias[2, varRowCount] = "Activo"; }
                else { arrMaterias[2, varRowCount] = "Inactivo"; }
                varRowCount++;
                if(varRowCount >= arrMaterias.Length)
                {
                    MessageBox.Show("Límite de cantidad de Materias alcanzado.", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAccept.Enabled = false;
                }
                MessageBox.Show("Registro exitoso.", "Registro Materia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCode.Text = string.Empty;
                txtName.Text = string.Empty;
                cbxPlan.SelectedItem = null;
                txtName.Enabled = false;
                cbxPlan.Enabled = false;
            }
            else
            {
                MessageBox.Show("Completar los datos.", "Registro Materia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            lblLoginDateShow.Text = varLoginDate.ToString();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            cbxPlan.SelectedItem = null;
            txtName.Enabled = false;
            cbxPlan.Enabled = false;
        }

        private void btnPlanLoad_Click(object sender, EventArgs e)
        {
            frmCargaPlan ventanaCargaPlan = new frmCargaPlan();
            ventanaCargaPlan.ShowDialog();
            txtCode.Text = string.Empty;
            txtName.Text = string.Empty;
            cbxPlan.SelectedItem = null;
            txtName.Enabled = false;
            cbxPlan.Enabled = false;
        }

        private void txtCode_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            txtName.Enabled = true;
        }
    }
}
