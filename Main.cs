using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputsOutputs
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.allTableAdapter.Fill(inputsOutputsDataSet.All);

        }

        private void grdAll_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (inputsOutputsDataSet.All[e.RowIndex].Type == "Sale")
            {
                e.CellStyle.BackColor = Color.LightGreen;
                e.CellStyle.ForeColor = Color.Black;
                e.CellStyle.SelectionBackColor = Color.LightGreen;
                e.CellStyle.SelectionForeColor = Color.Black;
            }
            else if (inputsOutputsDataSet.All[e.RowIndex].Type == "Cost")
            {
                e.CellStyle.BackColor = Color.PaleVioletRed;
                e.CellStyle.ForeColor = Color.White;
                e.CellStyle.SelectionBackColor = Color.PaleVioletRed;
                e.CellStyle.SelectionForeColor = Color.White;
            }
            else if (inputsOutputsDataSet.All[e.RowIndex].Type == "Return")
            {
                e.CellStyle.BackColor = Color.Khaki;
                e.CellStyle.ForeColor = Color.Black;
                e.CellStyle.SelectionBackColor = Color.Khaki;
                e.CellStyle.SelectionForeColor = Color.Black;
            }
        }
    }
}
