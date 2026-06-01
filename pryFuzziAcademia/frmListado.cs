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
            if (rbtAllSearch.Checked)
            {
                for (int row = 0;row < arrMateriasListado.GetLength(0); row++)
                {
                    if (arrMateriasListado[row, 0] != null)
                    {
                        dgvGrilla.Rows.Add(arrMateriasListado[row, 0], arrMateriasListado[row, 1], arrMateriasListado[row, 2], arrMateriasListado[row, 3]);
                    }                    
                }
            }
        }

        private void frmListado_Load(object sender, EventArgs e)
        {

        }

        private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
