using InputsOutputs.Models.Database;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
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
            grdAll.Rows[e.RowIndex].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

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
                e.CellStyle.ForeColor = Color.Black;
                e.CellStyle.SelectionBackColor = Color.PaleVioletRed;
                e.CellStyle.SelectionForeColor = Color.Black;
            }
            else if ((int)grdAll.Rows[e.RowIndex].Cells[8].Value == (int)DataType.Return)
            {
                e.CellStyle.BackColor = Color.Khaki;
                e.CellStyle.ForeColor = Color.Black;
                e.CellStyle.SelectionBackColor = Color.Khaki;
                e.CellStyle.SelectionForeColor = Color.Black;
            }
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            var addSaleForm = new AddSale();
            addSaleForm.NewDataDelegate += new AddSale.NewData(OnNewDataAdded);
            addSaleForm.ShowDialog();
        }

        private void btnAddCost_Click(object sender, EventArgs e)
        {
            var addCostForm = new AddCost();
            addCostForm.NewDataDelegate += new AddCost.NewData(OnNewDataAdded);
            addCostForm.ShowDialog();
        }

        private void btnAddReturn_Click(object sender, EventArgs e)
        {
            var addReturnForm = new AddReturn();
            addReturnForm.NewDataDelegate += new AddReturn.NewData(OnNewDataAdded);
            addReturnForm.ShowDialog();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var filterForm = new Filter();
            filterForm.FilterAppliedDelegate += new Filter.FilterApplied(OnFilterApplied);
            filterForm.ShowDialog();
        }

        private void btnExportToPdf_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = string.Format("InputOutputs_{0:dd_MM_yyyy_HH_mm_ss}.pdf", DateTime.UtcNow);

            var fileError = false;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        MessageBox.Show("Eroare: " + ex.Message, "Eroare");
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        var blankLine = new Paragraph(" ", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 15));

                        using (var stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            var pdfDoc = new Document(PageSize.A4.Rotate(), 20f, 20f, 20f, 20f);
                            var writer = PdfWriter.GetInstance(pdfDoc, stream);
                            var pageEventHelper = new PageEventHelper();
                            writer.PageEvent = pageEventHelper;
                            pdfDoc.Open();
                            var title = new Paragraph("VANZARI / CHELTUIELI / RETUR PIESE", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 18, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue)));
                            title.Alignment = Element.ALIGN_CENTER;
                            pdfDoc.Add(title);
                            pdfDoc.Add(new Paragraph(" ", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 5)));
                            if (!string.IsNullOrEmpty(partNameFilter))
                            {
                                var filter = new Paragraph($"Termen de cautare: [{partNameFilter}]", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 8));
                                filter.Alignment = Element.ALIGN_CENTER;
                                pdfDoc.Add(filter);
                            }
                            var dates = new Paragraph($"Perioada: [{dateFromFilter.ToShortDateString()} - {dateToFilter.ToShortDateString()}]", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 8));
                            if (dateFromFilter == dateToFilter)
                                dates = new Paragraph($"Data: [{dateFromFilter.ToShortDateString()}]", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 8));
                            dates.Alignment = Element.ALIGN_CENTER;
                            pdfDoc.Add(dates);
                            pdfDoc.Add(blankLine);
                            pdfDoc.Add(GetSalesTableToExport());
                            pdfDoc.Add(blankLine);
                            pdfDoc.Add(GetCostsTableToExport());
                            pdfDoc.Add(blankLine);
                            pdfDoc.Add(GetReturnsTableToExport());
                            pdfDoc.Add(blankLine);
                            pdfDoc.Add(GetTotalsTableToExport());
                            pdfDoc.Close();
                            stream.Close();
                        }

                        MessageBox.Show("Date exportate cu succes!", "Info");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Eroare: " + ex.Message, "Eroare");
                    }
                }
            }
        }

        private PdfPTable GetSalesTableToExport()
        {
            var salesTable = new PdfPTable(grdAll.Columns.Count - 2);

            salesTable.SetWidths(new float[] { 60f, 60f, 320f, 60f, 60f, 60f, 60f });
            salesTable.DefaultCell.Padding = 3;
            salesTable.WidthPercentage = 100;
            salesTable.HorizontalAlignment = Element.ALIGN_CENTER;

            var titleCell = new PdfPCell(new Phrase("VANZARI", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD)));
            titleCell.Colspan = 7;
            titleCell.BackgroundColor = new BaseColor(Color.LightGreen);
            titleCell.HorizontalAlignment = Element.ALIGN_CENTER;
            salesTable.AddCell(titleCell);

            foreach (DataGridViewColumn column in grdAll.Columns)
            {
                if (column.Index != 0 && column.Index != 8)
                {
                    var cell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_CENTER;
                    salesTable.AddCell(cell);
                }
            }
            foreach (DataGridViewRow row in grdAll.Rows)
            {
                if ((int)row.Cells[8].Value == (int)DataType.Sale)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex != 0 && cell.ColumnIndex != 8)
                        {
                            var cellValueToAdd = cell.ColumnIndex == 2 ? string.Format("{0:dd.MM.yyy}", cell.Value) : cell.Value.ToString();
                            var cellToAdd = new PdfPCell(new Phrase(cellValueToAdd, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10)));
                            cellToAdd.HorizontalAlignment = cell.ColumnIndex == 3 ? Element.ALIGN_LEFT : Element.ALIGN_CENTER;
                            salesTable.AddCell(cellToAdd);
                        }
                    }
                }
            }

            var totalCell = new PdfPCell(new Phrase("TOTAL VANZARI", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            totalCell.Colspan = 3;
            totalCell.BackgroundColor = new BaseColor(Color.LightGreen);
            totalCell.HorizontalAlignment = Element.ALIGN_CENTER;
            salesTable.AddCell(totalCell);

            var totalPriceRonCash = 0;
            var totalPriceRonCashRegister = 0;
            var totalPriceEuro = 0;
            var totalPricePounds = 0;
            for (var i = 0; i < grdAll.Rows.Count; i++)
            {
                if ((int)grdAll.Rows[i].Cells[8].Value == (int)DataType.Sale)
                {
                    totalPriceRonCash += grdAll.Rows[i].Cells[4].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[4].Value) : 0;
                    totalPriceRonCashRegister += grdAll.Rows[i].Cells[5].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[5].Value) : 0;
                    totalPriceEuro += grdAll.Rows[i].Cells[6].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[6].Value) : 0;
                    totalPricePounds += grdAll.Rows[i].Cells[7].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[7].Value) : 0;
                }
            }

            var totalCellRonCash = new PdfPCell(new Phrase(totalPriceRonCash > 0 ? totalPriceRonCash.ToString() : "-", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            totalCellRonCash.BackgroundColor = new BaseColor(Color.LightGreen);
            totalCellRonCash.HorizontalAlignment = Element.ALIGN_CENTER;
            salesTable.AddCell(totalCellRonCash);

            var totalCellRonCashRegister = new PdfPCell(new Phrase(totalPriceRonCashRegister > 0 ? totalPriceRonCashRegister.ToString() : "-", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            totalCellRonCashRegister.BackgroundColor = new BaseColor(Color.LightGreen);
            totalCellRonCashRegister.HorizontalAlignment = Element.ALIGN_CENTER;
            salesTable.AddCell(totalCellRonCashRegister);

            var totalCellEuro = new PdfPCell(new Phrase(totalPriceEuro > 0 ? totalPriceEuro.ToString() : "-", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            totalCellEuro.BackgroundColor = new BaseColor(Color.LightGreen);
            totalCellEuro.HorizontalAlignment = Element.ALIGN_CENTER;
            salesTable.AddCell(totalCellEuro);

            var totalCellPounds = new PdfPCell(new Phrase(totalPricePounds > 0 ? totalPricePounds.ToString() : "-", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            totalCellPounds.BackgroundColor = new BaseColor(Color.LightGreen);
            totalCellPounds.HorizontalAlignment = Element.ALIGN_CENTER;
            salesTable.AddCell(totalCellPounds);

            return salesTable;
        }

        private PdfPTable GetCostsTableToExport()
        {
            var costsTable = new PdfPTable(grdAll.Columns.Count - 3);

            costsTable.SetWidths(new float[] { 60f, 380f, 60f, 60f, 60f, 60f });
            costsTable.DefaultCell.Padding = 3;
            costsTable.WidthPercentage = 100;
            costsTable.HorizontalAlignment = Element.ALIGN_CENTER;

            var titleCell = new PdfPCell(new Phrase("CHELTUIELI", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD)));
            titleCell.Colspan = 6;
            titleCell.BackgroundColor = new BaseColor(Color.PaleVioletRed);
            titleCell.HorizontalAlignment = Element.ALIGN_CENTER;
            costsTable.AddCell(titleCell);

            foreach (DataGridViewColumn column in grdAll.Columns)
            {
                if (column.Index != 0 && column.Index != 1 && column.Index != 8)
                {
                    var cell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_CENTER;
                    costsTable.AddCell(cell);
                }
            }
            foreach (DataGridViewRow row in grdAll.Rows)
            {
                if ((int)row.Cells[8].Value == (int)DataType.Cost)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex != 0 && cell.ColumnIndex != 1 && cell.ColumnIndex != 8)
                        {
                            var cellValueToAdd = cell.ColumnIndex == 2 ? string.Format("{0:dd.MM.yyy}", cell.Value) : cell.Value.ToString();
                            var cellToAdd = new PdfPCell(new Phrase(cellValueToAdd, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10)));
                            cellToAdd.HorizontalAlignment = cell.ColumnIndex == 3 ? Element.ALIGN_LEFT : Element.ALIGN_CENTER;
                            costsTable.AddCell(cellToAdd);
                        }
                    }
                }
            }

            var totalCell = new PdfPCell(new Phrase("TOTAL CHELTUIELI", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            totalCell.Colspan = 2;
            totalCell.BackgroundColor = new BaseColor(Color.PaleVioletRed);
            totalCell.HorizontalAlignment = Element.ALIGN_CENTER;
            costsTable.AddCell(totalCell);

            var totalPriceRonCash = 0;
            var totalPriceRonCashRegister = 0;
            var totalPriceEuro = 0;
            var totalPricePounds = 0;
            for (var i = 0; i < grdAll.Rows.Count; i++)
            {
                if ((int)grdAll.Rows[i].Cells[8].Value == (int)DataType.Cost)
                {
                    totalPriceRonCash += grdAll.Rows[i].Cells[4].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[4].Value) : 0;
                    totalPriceRonCashRegister += grdAll.Rows[i].Cells[5].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[5].Value) : 0;
                    totalPriceEuro += grdAll.Rows[i].Cells[6].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[6].Value) : 0;
                    totalPricePounds += grdAll.Rows[i].Cells[7].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[7].Value) : 0;
                }
            }

            var totalCellRonCash = new PdfPCell(new Phrase(totalPriceRonCash > 0 ? totalPriceRonCash.ToString() : "-", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            totalCellRonCash.BackgroundColor = new BaseColor(Color.PaleVioletRed);
            totalCellRonCash.HorizontalAlignment = Element.ALIGN_CENTER;
            costsTable.AddCell(totalCellRonCash);

            var totalCellRonCashRegister = new PdfPCell(new Phrase(totalPriceRonCashRegister > 0 ? totalPriceRonCashRegister.ToString() : "-", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            totalCellRonCashRegister.BackgroundColor = new BaseColor(Color.PaleVioletRed);
            totalCellRonCashRegister.HorizontalAlignment = Element.ALIGN_CENTER;
            costsTable.AddCell(totalCellRonCashRegister);

            var totalCellEuro = new PdfPCell(new Phrase(totalPriceEuro > 0 ? totalPriceEuro.ToString() : "-", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            totalCellEuro.BackgroundColor = new BaseColor(Color.PaleVioletRed);
            totalCellEuro.HorizontalAlignment = Element.ALIGN_CENTER;
            costsTable.AddCell(totalCellEuro);

            var totalCellPounds = new PdfPCell(new Phrase(totalPricePounds > 0 ? totalPricePounds.ToString() : "-", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            totalCellPounds.BackgroundColor = new BaseColor(Color.PaleVioletRed);
            totalCellPounds.HorizontalAlignment = Element.ALIGN_CENTER;
            costsTable.AddCell(totalCellPounds);

            return costsTable;
        }

        private PdfPTable GetReturnsTableToExport()
        {
            var returnsTable = new PdfPTable(grdAll.Columns.Count - 3);

            returnsTable.SetWidths(new float[] { 60f, 380f, 60f, 60f, 60f, 60f });
            returnsTable.DefaultCell.Padding = 3;
            returnsTable.WidthPercentage = 100;
            returnsTable.HorizontalAlignment = Element.ALIGN_CENTER;

            var titleCell = new PdfPCell(new Phrase("RETUR PIESE", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD)));
            titleCell.Colspan = 6;
            titleCell.BackgroundColor = new BaseColor(Color.Khaki);
            titleCell.HorizontalAlignment = Element.ALIGN_CENTER;
            returnsTable.AddCell(titleCell);

            foreach (DataGridViewColumn column in grdAll.Columns)
            {
                if (column.Index != 0 && column.Index != 1 && column.Index != 8)
                {
                    var cell = new PdfPCell(new Phrase(column.HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10, iTextSharp.text.Font.BOLD)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_CENTER;
                    returnsTable.AddCell(cell);
                }
            }
            foreach (DataGridViewRow row in grdAll.Rows)
            {
                if ((int)row.Cells[8].Value == (int)DataType.Return)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex != 0 && cell.ColumnIndex != 1 && cell.ColumnIndex != 8)
                        {
                            var cellValueToAdd = cell.ColumnIndex == 2 ? string.Format("{0:dd.MM.yyy}", cell.Value) : cell.Value.ToString();
                            var cellToAdd = new PdfPCell(new Phrase(cellValueToAdd, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10)));
                            cellToAdd.HorizontalAlignment = cell.ColumnIndex == 3 ? Element.ALIGN_LEFT : Element.ALIGN_CENTER;
                            returnsTable.AddCell(cellToAdd);
                        }
                    }
                }
            }

            var totalCell = new PdfPCell(new Phrase("TOTAL RETUR PIESE", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            totalCell.Colspan = 2;
            totalCell.BackgroundColor = new BaseColor(Color.Khaki);
            totalCell.HorizontalAlignment = Element.ALIGN_CENTER;
            returnsTable.AddCell(totalCell);

            var totalPriceRonCash = 0;
            var totalPriceRonCashRegister = 0;
            var totalPriceEuro = 0;
            var totalPricePounds = 0;
            for (var i = 0; i < grdAll.Rows.Count; i++)
            {
                if ((int)grdAll.Rows[i].Cells[8].Value == (int)DataType.Return)
                {
                    totalPriceRonCash += grdAll.Rows[i].Cells[4].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[4].Value) : 0;
                    totalPriceRonCashRegister += grdAll.Rows[i].Cells[5].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[5].Value) : 0;
                    totalPriceEuro += grdAll.Rows[i].Cells[6].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[6].Value) : 0;
                    totalPricePounds += grdAll.Rows[i].Cells[7].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[7].Value) : 0;
                }
            }

            var totalCellRonCash = new PdfPCell(new Phrase(totalPriceRonCash > 0 ? totalPriceRonCash.ToString() : "-", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            totalCellRonCash.BackgroundColor = new BaseColor(Color.Khaki);
            totalCellRonCash.HorizontalAlignment = Element.ALIGN_CENTER;
            returnsTable.AddCell(totalCellRonCash);

            var totalCellRonCashRegister = new PdfPCell(new Phrase(totalPriceRonCashRegister > 0 ? totalPriceRonCashRegister.ToString() : "-", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            totalCellRonCashRegister.BackgroundColor = new BaseColor(Color.Khaki);
            totalCellRonCashRegister.HorizontalAlignment = Element.ALIGN_CENTER;
            returnsTable.AddCell(totalCellRonCashRegister);

            var totalCellEuro = new PdfPCell(new Phrase(totalPriceEuro > 0 ? totalPriceEuro.ToString() : "-", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            totalCellEuro.BackgroundColor = new BaseColor(Color.Khaki);
            totalCellEuro.HorizontalAlignment = Element.ALIGN_CENTER;
            returnsTable.AddCell(totalCellEuro);

            var totalCellPounds = new PdfPCell(new Phrase(totalPricePounds > 0 ? totalPricePounds.ToString() : "-", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            totalCellPounds.BackgroundColor = new BaseColor(Color.Khaki);
            totalCellPounds.HorizontalAlignment = Element.ALIGN_CENTER;
            returnsTable.AddCell(totalCellPounds);

            return returnsTable;
        }

        private PdfPTable GetTotalsTableToExport()
        {
            var totalsTable = new PdfPTable(4);

            totalsTable.DefaultCell.Padding = 3;
            totalsTable.WidthPercentage = 100;
            totalsTable.HorizontalAlignment = Element.ALIGN_CENTER;

            var titleCell = new PdfPCell(new Phrase("TOTAL FINAL", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            titleCell.Colspan = 4;
            titleCell.BackgroundColor = new BaseColor(Color.LightGray);
            titleCell.HorizontalAlignment = Element.ALIGN_CENTER;
            totalsTable.AddCell(titleCell);

            foreach (DataGridViewColumn column in grdAll.Columns)
            {
                if (column.Index > 3 && column.Index != 8)
                {
                    var cell = new PdfPCell(new Phrase(column.HeaderText.Replace("Pret ", string.Empty), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
                    cell.BackgroundColor = new BaseColor(Color.LightGray);
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    totalsTable.AddCell(cell);
                }
            }

            var totalPriceRonCash = 0;
            var totalPriceRonCashRegister = 0;
            var totalPriceEuro = 0;
            var totalPricePounds = 0;
            for (var i = 0; i < grdAll.Rows.Count; i++)
            {
                if ((int)grdAll.Rows[i].Cells[8].Value == (int)DataType.Sale)
                {
                    totalPriceRonCash += grdAll.Rows[i].Cells[4].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[4].Value) : 0;
                    totalPriceRonCashRegister += grdAll.Rows[i].Cells[5].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[5].Value) : 0;
                    totalPriceEuro += grdAll.Rows[i].Cells[6].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[6].Value) : 0;
                    totalPricePounds += grdAll.Rows[i].Cells[7].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[7].Value) : 0;
                }
                else
                {
                    totalPriceRonCash -= grdAll.Rows[i].Cells[4].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[4].Value) : 0;
                    totalPriceRonCashRegister -= grdAll.Rows[i].Cells[5].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[5].Value) : 0;
                    totalPriceEuro -= grdAll.Rows[i].Cells[6].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[6].Value) : 0;
                    totalPricePounds -= grdAll.Rows[i].Cells[7].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[7].Value) : 0;
                }
            }

            var totalCellRonCash = new PdfPCell(new Phrase(totalPriceRonCash != 0 ? totalPriceRonCash.ToString() : "-", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            totalCellRonCash.BackgroundColor = new BaseColor(Color.LightGray);
            totalCellRonCash.HorizontalAlignment = Element.ALIGN_CENTER;
            totalsTable.AddCell(totalCellRonCash);

            var totalCellRonCashRegister = new PdfPCell(new Phrase(totalPriceRonCashRegister != 0 ? totalPriceRonCashRegister.ToString() : "-", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            totalCellRonCashRegister.BackgroundColor = new BaseColor(Color.LightGray);
            totalCellRonCashRegister.HorizontalAlignment = Element.ALIGN_CENTER;
            totalsTable.AddCell(totalCellRonCashRegister);

            var totalCellEuro = new PdfPCell(new Phrase(totalPriceEuro != 0 ? totalPriceEuro.ToString() : "-", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            totalCellEuro.BackgroundColor = new BaseColor(Color.LightGray);
            totalCellEuro.HorizontalAlignment = Element.ALIGN_CENTER;
            totalsTable.AddCell(totalCellEuro);

            var totalCellPounds = new PdfPCell(new Phrase(totalPricePounds != 0 ? totalPricePounds.ToString() : "-", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD, new BaseColor(Color.Blue))));
            totalCellPounds.BackgroundColor = new BaseColor(Color.LightGray);
            totalCellPounds.HorizontalAlignment = Element.ALIGN_CENTER;
            totalsTable.AddCell(totalCellPounds);

            return totalsTable;
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
                if ((int)grdAll.Rows[i].Cells[8].Value == (int)DataType.Sale)
                {
                    totalPriceRonCash += grdAll.Rows[i].Cells[4].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[4].Value) : 0;
                    totalPriceRonCashRegister += grdAll.Rows[i].Cells[5].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[5].Value) : 0;
                    totalPriceEuro += grdAll.Rows[i].Cells[6].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[6].Value) : 0;
                    totalPricePounds += grdAll.Rows[i].Cells[7].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[7].Value) : 0;
                }
                else
                {
                    totalPriceRonCash -= grdAll.Rows[i].Cells[4].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[4].Value) : 0;
                    totalPriceRonCashRegister -= grdAll.Rows[i].Cells[5].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[5].Value) : 0;
                    totalPriceEuro -= grdAll.Rows[i].Cells[6].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[6].Value) : 0;
                    totalPricePounds -= grdAll.Rows[i].Cells[7].Value != DBNull.Value ? Convert.ToInt32(grdAll.Rows[i].Cells[7].Value) : 0;
                }
            }
            lblTotalPriceRonCash.Text = totalPriceRonCash != 0 ? totalPriceRonCash.ToString() : "-";
            lblTotalPriceRonCashRegister.Text = totalPriceRonCashRegister != 0 ? totalPriceRonCashRegister.ToString() : "-";
            lblTotalPriceEuro.Text = totalPriceEuro != 0 ? totalPriceEuro.ToString() : "-";
            lblTotalPricePounds.Text = totalPricePounds != 0 ? totalPricePounds.ToString() : "-";
        }

        private void FormatGridColums()
        {
            grdAll.Columns[0].Visible = false;
            grdAll.Columns[1].HeaderText = "Vanzator";
            grdAll.Columns[2].HeaderText = "Data";
            grdAll.Columns[3].HeaderText = "Denumire Piesa";
            grdAll.Columns[3].Width = 500;
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

        private string GetSearchTerm(string partNameSearchTerm)
        {
            partNameSearchTerm = partNameSearchTerm.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;");
            return string.Format(
                $"(CONTAINS (d.{nameof(DataModel.Name)}, ''{{0}}''))",
                string.Join(" AND ", partNameSearchTerm.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                                        .Select(x => x = string.Format("\"{0}*\"", x)))
            );
        }

        private void OnNewDataAdded(object sender, EventArgs e)
        {
            RefreshData();
        }
    }

    public class PageEventHelper : PdfPageEventHelper
    {
        PdfContentByte cb;
        PdfTemplate template;
        BaseFont baseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            cb = writer.DirectContent;
            template = cb.CreateTemplate(50, 50);
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);

            int pageN = writer.PageNumber;
            var text = pageN.ToString() + " / ";
            float len = baseFont.GetWidthPoint(text, 7);

            iTextSharp.text.Rectangle pageSize = document.PageSize;

            cb.SetRGBColorFill(100, 100, 100);

            cb.BeginText();
            cb.SetFontAndSize(baseFont, 7);
            cb.SetTextMatrix(document.LeftMargin, pageSize.GetBottom(document.BottomMargin) - 10f);
            cb.ShowText(text);

            cb.EndText();

            cb.AddTemplate(template, document.LeftMargin + len, pageSize.GetBottom(document.BottomMargin) - 10f);
        }

        public override void OnCloseDocument(PdfWriter writer, Document document)
        {
            base.OnCloseDocument(writer, document);

            template.BeginText();
            template.SetFontAndSize(baseFont, 7);
            template.SetTextMatrix(0, 0);
            template.ShowText("" + (writer.PageNumber));
            template.EndText();
        }
    }
}
