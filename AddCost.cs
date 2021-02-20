using InputsOutputs.Models.Database;
using System;
using System.Windows.Forms;

namespace InputsOutputs
{
    public partial class AddCost : Form
    {
        public delegate void NewData(object sender, EventArgs e);
        public NewData NewDataDelegate { get; set; }

        private ApplicationDbContext db = new ApplicationDbContext();

        public AddCost()
        {
            InitializeComponent();
        }

        private void AddCost_Load(object sender, EventArgs e)
        {
            dateTime.Value = DateTime.Now.Date;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void lnkCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (dateTime.Value > DateTime.Now)
            {
                errorProvider.SetError(dateTime, "Data incorecta! Nu poate fi mai mare decat data de azi!");
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                errorProvider.SetError(txtName, "Trebuie sa introduci denumirea piesei!");
                return;
            }
            if (string.IsNullOrEmpty(txtPriceRonCash.Text.Trim()) && string.IsNullOrEmpty(txtPriceRonCashRegister.Text.Trim()) &&
                string.IsNullOrEmpty(txtPriceEuro.Text.Trim()) && string.IsNullOrEmpty(txtPricePounds.Text.Trim()))
            {
                errorProvider.SetError(txtPriceRonCash, "Trebuie sa introduci macar un pret!");
                errorProvider.SetError(txtPriceRonCashRegister, "Trebuie sa introduci macar un pret!");
                errorProvider.SetError(txtPriceEuro, "Trebuie sa introduci macar un pret!");
                errorProvider.SetError(txtPricePounds, "Trebuie sa introduci macar un pret!");
                return;
            }

            db.AllData.Add(new DataModel
            {
                Date = dateTime.Value.Date,
                Name = txtName.Text.Trim(),
                PriceRonCash = !string.IsNullOrEmpty(txtPriceRonCash.Text.Trim()) ? Convert.ToInt32(txtPriceRonCash.Text.Trim()) : (int?)null,
                PriceRonCashRegister = !string.IsNullOrEmpty(txtPriceRonCashRegister.Text.Trim()) ? Convert.ToInt32(txtPriceRonCashRegister.Text.Trim()) : (int?)null,
                PriceEuro = !string.IsNullOrEmpty(txtPriceEuro.Text.Trim()) ? Convert.ToInt32(txtPriceEuro.Text.Trim()) : (int?)null,
                PricePounds = !string.IsNullOrEmpty(txtPricePounds.Text.Trim()) ? Convert.ToInt32(txtPricePounds.Text.Trim()) : (int?)null,
                Type = DataType.Cost
            });
            db.SaveChanges();

            NewDataDelegate.Invoke(null, null);
            Close();
        }
    }
}
