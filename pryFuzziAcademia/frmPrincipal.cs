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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        
        

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblDateNow.Text = DateTime.Now.ToString();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListado ventana = new frmListado();
            ventana.ShowDialog();
        }

        private void stsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAlumno ventana = new frmAlumno();
            ventana.ShowDialog();
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistro ventana = new frmRegistro();
            ventana.varLoginDate = DateTime.Now;
            ventana.ShowDialog();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCargaPlan ventana = new frmCargaPlan();
            ventana.ShowDialog();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

        }

        private void mstMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
