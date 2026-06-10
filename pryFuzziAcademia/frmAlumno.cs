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
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        public string[,] arrAlumnos = new string[5, 8];

        public string[] arrPlanes = new string[5];
        public string[,] arrMaterias = new string[5, 4];

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (txtDNI.MaskCompleted && txtName.Text != null && txtLastName.Text != null && txtAddress.Text != null && txtContact.MaskCompleted)
            {

                MessageBox.Show("Alumno registrado con éxito.", "Registrar Alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDNI.Text = string.Empty;
                txtName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtAddress.Text = string.Empty;
                txtContact.Text = string.Empty;

                for (int i = 0; i < arrAlumnos.GetLength(0); i++)
                {
                    arrAlumnos[i, 0] = txtDNI.Text;
                    arrAlumnos[i, 1] = txtName.Text;
                    arrAlumnos[i, 2] = txtLastName.Text;
                    arrAlumnos[i, 3] = txtAddress.Text;
                    arrAlumnos[i, 4] = txtContact.Text;
                    arrAlumnos[i, 5] = dtpBirthDate.Text;

                }
                txtName.Enabled = false;
                txtLastName.Enabled = false;
                txtAddress.Enabled = false;
                txtContact.Enabled = false;
                dtpBirthDate.Enabled = false;


            }
            else
            {
                MessageBox.Show("Completar los datos.", "Registrar Alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtLastName.Enabled = true;
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            txtName.Enabled = true;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            txtAddress.Enabled = true;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            txtContact.Enabled = true;
        }

        private void txtContact_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            dtpBirthDate.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal ventana = new frmPrincipal();
            ventana.ShowDialog();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal ventana = new frmPrincipal();
            ventana.arrMaterias = arrMaterias;
            ventana.arrPlanes = arrPlanes;
            ventana.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
