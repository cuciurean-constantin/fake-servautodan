﻿
namespace InputsOutputs
{
    partial class AddSale
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtPriceEuro = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPriceRonCashRegister = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPriceRonCash = new System.Windows.Forms.TextBox();
            this.lnkCancel = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtSellerName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTime);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 57);
            this.groupBox1.TabIndex = 1;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(12, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 59);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Denumire";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 23);
            this.txtName.MaxLength = 1024;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(387, 23);
            this.txtName.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 92);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Valoare";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtPriceEuro);
            this.groupBox6.Location = new System.Drawing.Point(272, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(127, 60);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "€";
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
            this.groupBox5.Text = "R (C.M.)";
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
            this.groupBox4.Text = "R";
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
            // lnkCancel
            // 
            this.lnkCancel.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnkCancel.DisabledLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnkCancel.Image = global::InputsOutputs.Properties.Resources.error;
            this.lnkCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkCancel.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnkCancel.Location = new System.Drawing.Point(88, 337);
            this.lnkCancel.Name = "lnkCancel";
            this.lnkCancel.Size = new System.Drawing.Size(100, 17);
            this.lnkCancel.TabIndex = 8;
            this.lnkCancel.TabStop = true;
            this.lnkCancel.Text = "Renunta";
            this.lnkCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkCancel.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lnkCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCancel_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::InputsOutputs.Properties.Resources.profits;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(194, 327);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(162, 37);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Salveaza";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtSellerName);
            this.groupBox8.Location = new System.Drawing.Point(12, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(420, 59);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Nume";
            // 
            // txtSellerName
            // 
            this.txtSellerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSellerName.Location = new System.Drawing.Point(12, 23);
            this.txtSellerName.MaxLength = 128;
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.Size = new System.Drawing.Size(387, 23);
            this.txtSellerName.TabIndex = 0;
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 389);
            this.Controls.Add(this.groupBox8);
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
            this.Name = "AddSale";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "V ...";
            this.Load += new System.EventHandler(this.AddSale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtPriceEuro;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtPriceRonCashRegister;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPriceRonCash;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel lnkCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtSellerName;
    }
}