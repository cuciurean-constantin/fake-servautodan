﻿
namespace InputsOutputs
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblTitle = new System.Windows.Forms.Label();
            this.tblPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.grdAll = new System.Windows.Forms.DataGridView();
            this.tblFooter = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalPriceRonCash = new System.Windows.Forms.Label();
            this.lblTotalPriceRonCashRegister = new System.Windows.Forms.Label();
            this.lblTotalPriceEuro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFiltersInfo = new System.Windows.Forms.Label();
            this.btnExportToPdf = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnAddReturn = new System.Windows.Forms.Button();
            this.btnAddCost = new System.Windows.Forms.Button();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.tblPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAll)).BeginInit();
            this.tblFooter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(101, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(171, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "V / C / R";
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPrincipal.ColumnCount = 1;
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPrincipal.Controls.Add(this.btnDeleteAll, 0, 3);
            this.tblPrincipal.Controls.Add(this.grdAll, 0, 2);
            this.tblPrincipal.Controls.Add(this.tblFooter, 0, 4);
            this.tblPrincipal.Controls.Add(this.lblFiltersInfo, 0, 0);
            this.tblPrincipal.Location = new System.Drawing.Point(13, 157);
            this.tblPrincipal.Name = "tblPrincipal";
            this.tblPrincipal.RowCount = 5;
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tblPrincipal.Size = new System.Drawing.Size(1191, 480);
            this.tblPrincipal.TabIndex = 2;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAll.Image = global::InputsOutputs.Properties.Resources.delete;
            this.btnDeleteAll.Location = new System.Drawing.Point(1147, 350);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(41, 35);
            this.btnDeleteAll.TabIndex = 8;
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // grdAll
            // 
            this.grdAll.AllowUserToAddRows = false;
            this.grdAll.AllowUserToDeleteRows = false;
            this.grdAll.AllowUserToResizeColumns = false;
            this.grdAll.AllowUserToResizeRows = false;
            this.grdAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAll.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdAll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdAll.ColumnHeadersHeight = 55;
            this.grdAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAll.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdAll.Location = new System.Drawing.Point(3, 43);
            this.grdAll.MultiSelect = false;
            this.grdAll.Name = "grdAll";
            this.grdAll.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAll.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.grdAll.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grdAll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAll.Size = new System.Drawing.Size(1185, 301);
            this.grdAll.TabIndex = 0;
            this.grdAll.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdAll_CellFormatting);
            // 
            // tblFooter
            // 
            this.tblFooter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblFooter.ColumnCount = 2;
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tblFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tblFooter.Controls.Add(this.lblTotalInfo, 0, 0);
            this.tblFooter.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tblFooter.Location = new System.Drawing.Point(3, 391);
            this.tblFooter.Name = "tblFooter";
            this.tblFooter.RowCount = 1;
            this.tblFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFooter.Size = new System.Drawing.Size(1185, 86);
            this.tblFooter.TabIndex = 1;
            // 
            // lblTotalInfo
            // 
            this.lblTotalInfo.AutoSize = true;
            this.lblTotalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotalInfo.Location = new System.Drawing.Point(3, 0);
            this.lblTotalInfo.Name = "lblTotalInfo";
            this.lblTotalInfo.Size = new System.Drawing.Size(669, 86);
            this.lblTotalInfo.TabIndex = 1;
            this.lblTotalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lblTotalPriceRonCash, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalPriceRonCashRegister, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalPriceEuro, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(678, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 80);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTotalPriceRonCash
            // 
            this.lblTotalPriceRonCash.AutoSize = true;
            this.lblTotalPriceRonCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPriceRonCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPriceRonCash.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotalPriceRonCash.Location = new System.Drawing.Point(3, 34);
            this.lblTotalPriceRonCash.Name = "lblTotalPriceRonCash";
            this.lblTotalPriceRonCash.Size = new System.Drawing.Size(162, 46);
            this.lblTotalPriceRonCash.TabIndex = 17;
            this.lblTotalPriceRonCash.Text = "T R";
            this.lblTotalPriceRonCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPriceRonCashRegister
            // 
            this.lblTotalPriceRonCashRegister.AutoSize = true;
            this.lblTotalPriceRonCashRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPriceRonCashRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPriceRonCashRegister.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotalPriceRonCashRegister.Location = new System.Drawing.Point(171, 34);
            this.lblTotalPriceRonCashRegister.Name = "lblTotalPriceRonCashRegister";
            this.lblTotalPriceRonCashRegister.Size = new System.Drawing.Size(162, 46);
            this.lblTotalPriceRonCashRegister.TabIndex = 16;
            this.lblTotalPriceRonCashRegister.Text = "T R (C.M.)";
            this.lblTotalPriceRonCashRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPriceEuro
            // 
            this.lblTotalPriceEuro.AutoSize = true;
            this.lblTotalPriceEuro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPriceEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPriceEuro.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotalPriceEuro.Location = new System.Drawing.Point(339, 34);
            this.lblTotalPriceEuro.Name = "lblTotalPriceEuro";
            this.lblTotalPriceEuro.Size = new System.Drawing.Size(162, 46);
            this.lblTotalPriceEuro.TabIndex = 14;
            this.lblTotalPriceEuro.Text = "T €";
            this.lblTotalPriceEuro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(339, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "V - (Ch + R)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(171, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "V - (Ch + R)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(339, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "€";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(171, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "R (C.M.)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "V - (Ch + R)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "R";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFiltersInfo
            // 
            this.lblFiltersInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltersInfo.AutoSize = true;
            this.lblFiltersInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltersInfo.Location = new System.Drawing.Point(1133, 0);
            this.lblFiltersInfo.Name = "lblFiltersInfo";
            this.lblFiltersInfo.Size = new System.Drawing.Size(55, 15);
            this.lblFiltersInfo.TabIndex = 2;
            this.lblFiltersInfo.Text = "label10";
            this.lblFiltersInfo.Visible = false;
            // 
            // btnExportToPdf
            // 
            this.btnExportToPdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToPdf.Image = global::InputsOutputs.Properties.Resources.files;
            this.btnExportToPdf.Location = new System.Drawing.Point(1154, 101);
            this.btnExportToPdf.Name = "btnExportToPdf";
            this.btnExportToPdf.Size = new System.Drawing.Size(41, 39);
            this.btnExportToPdf.TabIndex = 7;
            this.btnExportToPdf.UseVisualStyleBackColor = true;
            this.btnExportToPdf.Click += new System.EventHandler(this.btnExportToPdf_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Image = global::InputsOutputs.Properties.Resources.filter;
            this.btnFilter.Location = new System.Drawing.Point(1107, 101);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(41, 39);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnAddReturn
            // 
            this.btnAddReturn.BackColor = System.Drawing.Color.Khaki;
            this.btnAddReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReturn.Image = global::InputsOutputs.Properties.Resources.exchange;
            this.btnAddReturn.Location = new System.Drawing.Point(457, 100);
            this.btnAddReturn.Name = "btnAddReturn";
            this.btnAddReturn.Size = new System.Drawing.Size(216, 39);
            this.btnAddReturn.TabIndex = 5;
            this.btnAddReturn.Text = "+ R";
            this.btnAddReturn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddReturn.UseVisualStyleBackColor = false;
            this.btnAddReturn.Click += new System.EventHandler(this.btnAddReturn_Click);
            // 
            // btnAddCost
            // 
            this.btnAddCost.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddCost.Image = global::InputsOutputs.Properties.Resources.get_money;
            this.btnAddCost.Location = new System.Drawing.Point(235, 100);
            this.btnAddCost.Name = "btnAddCost";
            this.btnAddCost.Size = new System.Drawing.Size(216, 39);
            this.btnAddCost.TabIndex = 4;
            this.btnAddCost.Text = "+ C";
            this.btnAddCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCost.UseVisualStyleBackColor = false;
            this.btnAddCost.Click += new System.EventHandler(this.btnAddCost_Click);
            // 
            // btnAddSale
            // 
            this.btnAddSale.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSale.Image = global::InputsOutputs.Properties.Resources.profits;
            this.btnAddSale.Location = new System.Drawing.Point(13, 100);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(216, 39);
            this.btnAddSale.TabIndex = 3;
            this.btnAddSale.Text = "+ V";
            this.btnAddSale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddSale.UseVisualStyleBackColor = false;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::InputsOutputs.Properties.Resources.logo;
            this.imgLogo.Location = new System.Drawing.Point(13, 13);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(83, 46);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 649);
            this.Controls.Add(this.btnExportToPdf);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnAddReturn);
            this.Controls.Add(this.btnAddCost);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.tblPrincipal);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.imgLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "V / C / R";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.tblPrincipal.ResumeLayout(false);
            this.tblPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAll)).EndInit();
            this.tblFooter.ResumeLayout(false);
            this.tblFooter.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tblPrincipal;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.Button btnAddCost;
        private System.Windows.Forms.Button btnAddReturn;
        private System.Windows.Forms.DataGridView grdAll;
        private System.Windows.Forms.TableLayoutPanel tblFooter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotalInfo;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblFiltersInfo;
        private System.Windows.Forms.Label lblTotalPriceRonCash;
        private System.Windows.Forms.Label lblTotalPriceRonCashRegister;
        private System.Windows.Forms.Label lblTotalPriceEuro;
        private System.Windows.Forms.Button btnExportToPdf;
        private System.Windows.Forms.Button btnDeleteAll;
    }
}

