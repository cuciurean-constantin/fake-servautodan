using System;
using System.Windows.Forms;

namespace InputsOutputs
{
    public partial class Filter : Form
    {
        public delegate void FilterApplied(object sender, EventArgs e);
        public FilterApplied FilterAppliedDelegate { get; set; }

        public Filter()
        {
            InitializeComponent();
        }

        private void Filter_Load(object sender, EventArgs e)
        {
            txtName.Text = Main.partNameFilter;
            dateFrom.Value = Main.dateFromFilter;
            dateTo.Value = Main.dateToFilter;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            errDates.Clear();

            if (dateFrom.Value > dateTo.Value)
            {
                errDates.SetError(dateFrom, "Data incorecta! Nu poate fi mai mare decat data 'pana la'!");
                errDates.SetError(dateTo, "Data incorecta! Nu poate fi mai mica decat data 'de la'!");
                return;
            }

            if ((dateTo.Value - dateFrom.Value).TotalDays > 31)
            {
                errDates.SetError(dateTo, "Data incorecta! Nu poti filtra datete pentru un interval mai mare de 31 de zile!");
                return;
            }

            Main.partNameFilter = txtName.Text.Trim();
            Main.dateFromFilter = dateFrom.Value.Date;
            Main.dateToFilter = dateTo.Value.Date;

            FilterAppliedDelegate.Invoke(null, null);

            Close();
        }
    }
}
