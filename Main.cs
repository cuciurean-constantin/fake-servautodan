using InputsOutputs.Models.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace InputsOutputs
{
    public partial class Main : Form
    {
        public static string partNameFilter = "";
        public static DateTime dateFromFilter = DateTime.Now.Date;
        public static DateTime dateToFilter = DateTime.Now.Date;

        private BindingSource bindingSource = new BindingSource();
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            grdAll.DataSource = bindingSource;
            RefreshData();

            lblFiltersInfo.Text = $"FILTROS APLICADOS -> Data: [{dateFromFilter.ToShortDateString()}]";
            lblFiltersInfo.Visible = true;
            lblTotalInfo.Text += $"TOTAL{Environment.NewLine}Data: [{dateFromFilter.ToShortDateString()}]";

            FormatGridColums();
        }

        private void grdAll_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((int)grdAll.Rows[e.RowIndex].Cells[8].Value == (int)DataType.Sale)
            {
                e.CellStyle.BackColor = Color.LightGreen;
                e.CellStyle.ForeColor = Color.Black;
                e.CellStyle.SelectionBackColor = Color.LightGreen;
                e.CellStyle.SelectionForeColor = Color.Black;
            }
            else if ((int)grdAll.Rows[e.RowIndex].Cells[8].Value == (int)DataType.Cost)
            {
                e.CellStyle.BackColor = Color.PaleVioletRed;
                e.CellStyle.ForeColor = Color.White;
                e.CellStyle.SelectionBackColor = Color.PaleVioletRed;
                e.CellStyle.SelectionForeColor = Color.White;
            }
            else if ((int)grdAll.Rows[e.RowIndex].Cells[8].Value == (int)DataType.Return)
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

        private void RefreshData()
        {
            dataAdapter = new SqlDataAdapter(
                $@"EXEC [dbo].[GetAll]
                    @searchTerm = {(!string.IsNullOrEmpty(partNameFilter) ? $"N'{GetSearchTerm(partNameFilter)}'" : "NULL")},
                    @from = N'{string.Format("{0:yyyy-MM-dd}", dateFromFilter)}',
                    @to = N'{string.Format("{0:yyyy-MM-dd}", dateToFilter)}'",
                Properties.Settings.Default.DefaultConnection);

            var table = new DataTable { Locale = CultureInfo.InvariantCulture };
            dataAdapter.Fill(table);
            bindingSource.DataSource = table;

            var totalPriceRonCash = 0;
            var totalPriceRonCashRegister = 0;
            var totalPriceEuro = 0;
            var totalPricePounds = 0;
            for (var i = 0; i < grdAll.Rows.Count; i++)
            {
                totalPriceRonCash += grdAll.Rows[i].Cells[4].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[4].Value) : 0;
                totalPriceRonCashRegister += grdAll.Rows[i].Cells[5].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[5].Value) : 0;
                totalPriceEuro += grdAll.Rows[i].Cells[6].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[6].Value) : 0;
                totalPricePounds += grdAll.Rows[i].Cells[7].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[7].Value) : 0;
            }
            lblTotalPriceRonCash.Text = totalPriceRonCash > 0 ? totalPriceRonCash.ToString(): "-";
            lblTotalPriceRonCashRegister.Text = totalPriceRonCashRegister > 0 ? totalPriceRonCashRegister.ToString() : "-";
            lblTotalPriceEuro.Text = totalPriceEuro > 0 ? totalPriceEuro.ToString() : "-";
            lblTotalPricePounds.Text = totalPricePounds > 0 ? totalPricePounds.ToString() : "-";
        }

        private void FormatGridColums()
        {
            grdAll.Columns[0].Visible = false;
            grdAll.Columns[1].HeaderText = "Vanzator";
            grdAll.Columns[2].HeaderText = "Data";
            grdAll.Columns[3].HeaderText = "Denumire Piesa";
            grdAll.Columns[4].HeaderText = "Pret RON (Cash)";
            grdAll.Columns[5].HeaderText = "Pret RON (C.M.)";
            grdAll.Columns[6].HeaderText = "Pret EURO";
            grdAll.Columns[7].HeaderText = "Pret LIRE";
            grdAll.Columns[8].Visible = false;
        }

        private void OnFilterApplied(object sender, EventArgs e)
        {
            lblFiltersInfo.Text = "FILTROS APLICADOS -> ";
            lblTotalInfo.Text = "TOTAL";

            if (!string.IsNullOrEmpty(partNameFilter))
            {
                lblFiltersInfo.Text += $"Denumire: [{partNameFilter}], ";
                lblTotalInfo.Text += $"{Environment.NewLine}Termen de cautare: [{partNameFilter}]";
            }
            if (dateFromFilter == dateToFilter)
            {
                lblFiltersInfo.Text += $"Data: [{dateFromFilter.ToShortDateString()}]";
                lblTotalInfo.Text += $"{Environment.NewLine}Data: [{dateFromFilter.ToShortDateString()}]";
            }
            else
            {
                lblFiltersInfo.Text += $"Perioada: [{dateFromFilter.ToShortDateString()} - {dateToFilter.ToShortDateString()}]";
                lblTotalInfo.Text += $"{Environment.NewLine}Perioada: [{dateFromFilter.ToShortDateString()} - {dateToFilter.ToShortDateString()}]";
            }

            RefreshData();
        }

        public string GetSearchTerm(string partNameSearchTerm)
        {
            partNameSearchTerm = partNameSearchTerm.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;");
            return string.Format(
                $"(CONTAINS (d.{nameof(DataModel.Name)}, ''{{0}}''))",
                string.Join(" AND ", partNameSearchTerm.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                                        .Select(x => x = string.Format("\"{0}*\"", x)))
            );
        }
    }
}
