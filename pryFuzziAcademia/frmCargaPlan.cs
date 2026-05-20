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
    public partial class frmCargaPlan : Form
    {
        string[] ArrPlans = new string[5];
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
                if (varCounter == 5)
                {
                    MessageBox.Show("Cantidad de planes ")
                }
            }
        }
    }
}
