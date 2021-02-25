
namespace InputsOutputs
{
    partial class AddCost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lnkCancel = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtPricePounds = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtPriceEuro = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPriceRonCashRegister = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPriceRonCash = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkCancel
            // 
            this.lnkCancel.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnkCancel.DisabledLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnkCancel.Image = global::InputsOutputs.Properties.Resources.error;
            this.lnkCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkCancel.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnkCancel.Location = new System.Drawing.Point(178, 271);
            this.lnkCancel.Name = "lnkCancel";
            this.lnkCancel.Size = new System.Drawing.Size(100, 17);
            this.lnkCancel.TabIndex = 13;
            this.lnkCancel.TabStop = true;
            this.lnkCancel.Text = "Renunta";
            this.lnkCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkCancel.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnkCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCancel_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::InputsOutputs.Properties.Resources.get_money;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(284, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 37);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Salveaza";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(543, 92);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pret";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtPricePounds);
            this.groupBox7.Location = new System.Drawing.Point(405, 22);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(127, 60);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "LIRE";
            // 
            // txtPricePounds
            // 
            this.txtPricePounds.Location = new System.Drawing.Point(6, 22);
            this.txtPricePounds.Name = "txtPricePounds";
            this.txtPricePounds.Size = new System.Drawing.Size(103, 23);
            this.txtPricePounds.TabIndex = 6;
            this.txtPricePounds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPricePounds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtPriceEuro);
            this.groupBox6.Location = new System.Drawing.Point(272, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(127, 60);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "EURO";
            // 
            // txtPriceEuro
            // 
            this.txtPriceEuro.Location = new System.Drawing.Point(6, 22);
            this.txtPriceEuro.Name = "txtPriceEuro";
            this.txtPriceEuro.Size = new System.Drawing.Size(103, 23);
            this.txtPriceEuro.TabIndex = 5;
            this.txtPriceEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPriceEuro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPriceRonCashRegister);
            this.groupBox5.Location = new System.Drawing.Point(139, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(127, 60);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "RON (C.M.)";
            // 
            // txtPriceRonCashRegister
            // 
            this.txtPriceRonCashRegister.Location = new System.Drawing.Point(6, 22);
            this.txtPriceRonCashRegister.Name = "txtPriceRonCashRegister";
            this.txtPriceRonCashRegister.Size = new System.Drawing.Size(103, 23);
            this.txtPriceRonCashRegister.TabIndex = 4;
            this.txtPriceRonCashRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPriceRonCashRegister.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPriceRonCash);
            this.groupBox4.Location = new System.Drawing.Point(6, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(127, 60);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RON (Cash)";
            // 
            // txtPriceRonCash
            // 
            this.txtPriceRonCash.Location = new System.Drawing.Point(6, 22);
            this.txtPriceRonCash.Name = "txtPriceRonCash";
            this.txtPriceRonCash.Size = new System.Drawing.Size(103, 23);
            this.txtPriceRonCash.TabIndex = 3;
            this.txtPriceRonCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPriceRonCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 59);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Denumire";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 23);
            this.txtName.MaxLength = 1024;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(502, 23);
            this.txtName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTime);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 57);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(12, 22);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(103, 23);
            this.dateTime.TabIndex = 1;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // AddCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 323);
            this.Controls.Add(this.lnkCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCost";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cheltuiala noua ...";
            this.Load += new System.EventHandler(this.AddCost_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtPricePounds;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtPriceEuro;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtPriceRonCashRegister;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPriceRonCash;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}