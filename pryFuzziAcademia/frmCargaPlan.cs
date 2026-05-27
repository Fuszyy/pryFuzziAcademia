using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFuzziAcademia
{
    public partial class frmCargaPlan : Form
    {
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
        }

        private void btnCancelPlan_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPlanList_Click(object sender, EventArgs e)
        {
            for (int count = 0; count < 5; count++)
            {
                if (ArrPlans[count] == null)
                {
                    ArrPlans[count] = "";
                    lstPlans.Items.Add(ArrPlans[count]);
                }
                else
                {
                    lstPlans.Items.Add(ArrPlans[count]);
                }
            }
        }
    }
}
