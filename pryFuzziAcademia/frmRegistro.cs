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
        string[,] arrMaterias = new string[5, 4];
        int varRowCount = 0;

        public string[] arrPlanes = new string[5];
        

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
            for (int count = 0; count < arrPlanes.Length; count++)
            {
                if (arrPlanes[count] != null)
                {
                    cbxPlan.Items.Add(arrPlanes[count]);
                }
            }
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

            ventanaListado.arrMateriasListado = arrMaterias;            
            
            ventanaListado.ShowDialog();

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtCode.Text != "" && txtCode.MaskCompleted && txtName.Text != "" && cbxPlan.SelectedItem != null)
            {
                arrMaterias[varRowCount, 0] = txtCode.Text;
                arrMaterias[varRowCount, 1] = txtName.Text;
                arrMaterias[varRowCount, 2] = cbxPlan.Text;
                if (chkActive.Checked) { arrMaterias[varRowCount, 3] = "Activo"; }
                else { arrMaterias[varRowCount, 3] = "Inactivo"; }
                varRowCount++;

                MessageBox.Show("Registro exitoso.", "Registro Materia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCode.Text = string.Empty;
                txtName.Text = string.Empty;
                cbxPlan.SelectedItem = null;
                txtName.Enabled = false;
                cbxPlan.Enabled = false;
                chkActive.Checked = false;

                if (varRowCount >= arrMaterias.GetLength(0))
                {
                    MessageBox.Show("Límite de cantidad de Materias alcanzado.", "Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAccept.Enabled = false;
                }
                
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
            chkActive.Checked = false; 
        }

        private void btnPlanLoad_Click(object sender, EventArgs e)
        {
            frmCargaPlan ventanaCargaPlan = new frmCargaPlan();
            ventanaCargaPlan.ArrPlans = arrPlanes;
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
