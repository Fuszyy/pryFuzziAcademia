using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace pryFuzziAcademia
{
    public partial class frmCargaPlan : Form
    {
        public string[,] arrMaterias = new string[5, 4];
        public string[] ArrPlans = new string[5];
        int varCounter = 0;
        public frmCargaPlan()
        {
            InitializeComponent();
        }

        private void btnLoadPlan_Click(object sender, EventArgs e)
        {
            if (txtPlanName.Text != "")
            {
                ArrPlans[varCounter] = txtPlanName.Text;
                varCounter++;
                txtPlanName.Text = string.Empty;
                MessageBox.Show("Plan de estudio añadido con éxito.", "Planes de estudio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (varCounter == 5)
                {
                    MessageBox.Show("Límite de cantidad de planes alcanzado.", "Planes de estudio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPlanName.Enabled = false;
                    btnLoadPlan.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Completar los datos.", "Carga de Plan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelPlan_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPlanList_Click(object sender, EventArgs e)
        {
            if (ArrPlans[0] != null)
            {
                lstPlans.Items.Clear();
                for (int count = 0; count < ArrPlans.Length; count++)
                {
                    if (ArrPlans[count] != null)
                    {
                        lstPlans.Items.Add(ArrPlans[count]);
                    }
                }

                MessageBox.Show("Planes de estudio cargados.", "Carga de Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cargue por lo menos 1 plan de estudio.", "Carga de Plan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal ventana = new frmPrincipal();
            ventana.arrPlanes = ArrPlans;
            ventana.arrMaterias = arrMaterias;
            ventana.ShowDialog();
        }

        private void frmCargaPlan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            for (int count = 0; count < ArrPlans.Length; count++)
            {
                if (ArrPlans[count] != null)
                {
                    ArrPlans[count] = null;
                }
            }
            lstPlans.Items.Clear();

            DialogResult result = MessageBox.Show("¿Eliminar planes de estudio?", "Plan de Estudio", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                for (int count = 0; count < ArrPlans.Length; count++)
                {
                    if (ArrPlans[count] != null)
                    {
                        ArrPlans[count] = null;
                    }
                }
                lstPlans.Items.Clear();

                MessageBox.Show("Planes de estudio eliminados", "Plan de Estudio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
