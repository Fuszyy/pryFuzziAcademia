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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (txtDNI.MaskCompleted && txtName.Text != null && txtLastName.Text != null && txtAddress.Text != null && txtContact.MaskCompleted && txtBirthDate.MaskCompleted)
            {

                MessageBox.Show("Alumno registrado con éxito.", "Registrar Alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Completar los datos.", "Registrar Alumno", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
