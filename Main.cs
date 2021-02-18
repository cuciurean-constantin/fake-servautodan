using InputsOutputs.Models.Database;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace InputsOutputs
{
    public partial class Main : Form
    {
        public static string partNameFilter = "";
        public static DateTime dateFromFilter = DateTime.Now.Date;
        public static DateTime dateToFilter = DateTime.Now.Date;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inputsOutputsDataSet.Data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.inputsOutputsDataSet.Data);
            // TODO: This line of code loads data into the 'inputsOutputsDataSet2.Data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.inputsOutputsDataSet.Data);
            dataBindingSource.Filter = string.Format("Date >= '{0:yyyy-MM-dd}' AND Date <= '{0:yyyy-MM-dd}'", dateFromFilter);
            dataTableAdapter.Fill(inputsOutputsDataSet.Data);
            lblFiltersInfo.Text = $"FILTROS APLICADOS -> Data: [{dateFromFilter.ToShortDateString()}]";
            lblFiltersInfo.Visible = true;
        }

        private void grdAll_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (inputsOutputsDataSet.Data[e.RowIndex].Type == (int)DataType.Sale)
            {
                e.CellStyle.BackColor = Color.LightGreen;
                e.CellStyle.ForeColor = Color.Black;
                e.CellStyle.SelectionBackColor = Color.LightGreen;
                e.CellStyle.SelectionForeColor = Color.Black;
            }
            else if (inputsOutputsDataSet.Data[e.RowIndex].Type == (int)DataType.Cost)
            {
                e.CellStyle.BackColor = Color.PaleVioletRed;
                e.CellStyle.ForeColor = Color.White;
                e.CellStyle.SelectionBackColor = Color.PaleVioletRed;
                e.CellStyle.SelectionForeColor = Color.White;
            }
            else if (inputsOutputsDataSet.Data[e.RowIndex].Type == (int)DataType.Return)
            {
                e.CellStyle.BackColor = Color.Khaki;
                e.CellStyle.ForeColor = Color.Black;
                e.CellStyle.SelectionBackColor = Color.Khaki;
                e.CellStyle.SelectionForeColor = Color.Black;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var filterForm = new Filter();
            filterForm.FilterAppliedDelegate += new Filter.FilterApplied(OnFilterApplied);
            filterForm.ShowDialog();
        }

        private void OnFilterApplied(object sender, EventArgs e)
        {
            lblFiltersInfo.Text = $"FILTROS APLICADOS -> ";
            if (!string.IsNullOrEmpty(partNameFilter))
                lblFiltersInfo.Text += $"Denumire: [{partNameFilter}], ";
            if (dateFromFilter == dateToFilter)
                lblFiltersInfo.Text += $"Data: [{dateFromFilter.ToShortDateString()}]";
            else
                lblFiltersInfo.Text += $"Perioada: [{dateFromFilter.ToShortDateString()} - {dateToFilter.ToShortDateString()}]";

            dataBindingSource.Filter = string.Format("Date >= '{0:yyyy-MM-dd}' AND Date <= '{1:yyyy-MM-dd}'", dateFromFilter, dateToFilter);
        }
    }
}
