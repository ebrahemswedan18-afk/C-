namespace AlNorWholesale
{
    partial class Form4
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBackHome = new System.Windows.Forms.Button();
            this.lblSalesTitle = new System.Windows.Forms.Label();
            this.pnlInvoiceHeader = new System.Windows.Forms.Panel();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblInvoiceDate = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.ttxtInvoiceIDextBox2 = new System.Windows.Forms.TextBox();
            this.lblInvoiceID = new System.Windows.Forms.Label();
            this.lblInvoiceHeaderTitle = new System.Windows.Forms.Label();
            this.pnlAddItem = new System.Windows.Forms.Panel();
            this.btnNewInvoice = new System.Windows.Forms.Button();
            this.btnSaveInvoice = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddToInvoice = new System.Windows.Forms.Button();
            this.txtSaleQuantity = new System.Windows.Forms.TextBox();
            this.lblSaleQuantity = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblAddItemTitle = new System.Windows.Forms.Label();
            this.pnlTableCard = new System.Windows.Forms.Panel();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.dgvInvoiceItems = new System.Windows.Forms.DataGridView();
            this.colInvoiceProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlInvoiceHeader.SuspendLayout();
            this.pnlAddItem.SuspendLayout();
            this.pnlTableCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlHeader.Controls.Add(this.btnBackHome);
            this.pnlHeader.Controls.Add(this.lblSalesTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 89);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnBackHome
            // 
            this.btnBackHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.btnBackHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackHome.FlatAppearance.BorderSize = 0;
            this.btnBackHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackHome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackHome.ForeColor = System.Drawing.Color.White;
            this.btnBackHome.Location = new System.Drawing.Point(35, 20);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(270, 46);
            this.btnBackHome.TabIndex = 0;
            this.btnBackHome.Text = "↩   الصفحة الرئيسية";
            this.btnBackHome.UseVisualStyleBackColor = false;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // lblSalesTitle
            // 
            this.lblSalesTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSalesTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesTitle.ForeColor = System.Drawing.Color.White;
            this.lblSalesTitle.Location = new System.Drawing.Point(352, 20);
            this.lblSalesTitle.Name = "lblSalesTitle";
            this.lblSalesTitle.Size = new System.Drawing.Size(818, 58);
            this.lblSalesTitle.TabIndex = 1;
            this.lblSalesTitle.Text = "إدارة المبيعات وفواتير الجملة - مؤسسة النور";
            this.lblSalesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlInvoiceHeader
            // 
            this.pnlInvoiceHeader.BackColor = System.Drawing.Color.White;
            this.pnlInvoiceHeader.Controls.Add(this.dtpInvoiceDate);
            this.pnlInvoiceHeader.Controls.Add(this.lblInvoiceDate);
            this.pnlInvoiceHeader.Controls.Add(this.cmbCustomers);
            this.pnlInvoiceHeader.Controls.Add(this.lblCustomer);
            this.pnlInvoiceHeader.Controls.Add(this.ttxtInvoiceIDextBox2);
            this.pnlInvoiceHeader.Controls.Add(this.lblInvoiceID);
            this.pnlInvoiceHeader.Controls.Add(this.lblInvoiceHeaderTitle);
            this.pnlInvoiceHeader.Location = new System.Drawing.Point(12, 95);
            this.pnlInvoiceHeader.Name = "pnlInvoiceHeader";
            this.pnlInvoiceHeader.Size = new System.Drawing.Size(1176, 95);
            this.pnlInvoiceHeader.TabIndex = 1;
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(30, 54);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(280, 37);
            this.dtpInvoiceDate.TabIndex = 6;
            // 
            // lblInvoiceDate
            // 
            this.lblInvoiceDate.AutoSize = true;
            this.lblInvoiceDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblInvoiceDate.Location = new System.Drawing.Point(191, 23);
            this.lblInvoiceDate.Name = "lblInvoiceDate";
            this.lblInvoiceDate.Size = new System.Drawing.Size(124, 28);
            this.lblInvoiceDate.TabIndex = 5;
            this.lblInvoiceDate.Text = "تاريخ الفاتورة:";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(340, 54);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(575, 38);
            this.cmbCustomers.TabIndex = 4;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblCustomer.Location = new System.Drawing.Point(680, 23);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(212, 28);
            this.lblCustomer.TabIndex = 3;
            this.lblCustomer.Text = "اسم العميل / المؤسسة:";
            // 
            // ttxtInvoiceIDextBox2
            // 
            this.ttxtInvoiceIDextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.ttxtInvoiceIDextBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttxtInvoiceIDextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.ttxtInvoiceIDextBox2.Location = new System.Drawing.Point(950, 54);
            this.ttxtInvoiceIDextBox2.Name = "ttxtInvoiceIDextBox2";
            this.ttxtInvoiceIDextBox2.ReadOnly = true;
            this.ttxtInvoiceIDextBox2.Size = new System.Drawing.Size(150, 37);
            this.ttxtInvoiceIDextBox2.TabIndex = 2;
            this.ttxtInvoiceIDextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInvoiceID
            // 
            this.lblInvoiceID.AutoSize = true;
            this.lblInvoiceID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblInvoiceID.Location = new System.Drawing.Point(1005, 23);
            this.lblInvoiceID.Name = "lblInvoiceID";
            this.lblInvoiceID.Size = new System.Drawing.Size(111, 28);
            this.lblInvoiceID.TabIndex = 1;
            this.lblInvoiceID.Text = "رقم الفاتورة:";
            // 
            // lblInvoiceHeaderTitle
            // 
            this.lblInvoiceHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblInvoiceHeaderTitle.Location = new System.Drawing.Point(475, 0);
            this.lblInvoiceHeaderTitle.Name = "lblInvoiceHeaderTitle";
            this.lblInvoiceHeaderTitle.Size = new System.Drawing.Size(220, 32);
            this.lblInvoiceHeaderTitle.TabIndex = 0;
            this.lblInvoiceHeaderTitle.Text = "📋  بيانات الفاتورة العامة";
            this.lblInvoiceHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlAddItem
            // 
            this.pnlAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlAddItem.Controls.Add(this.btnNewInvoice);
            this.pnlAddItem.Controls.Add(this.btnSaveInvoice);
            this.pnlAddItem.Controls.Add(this.btnRemoveItem);
            this.pnlAddItem.Controls.Add(this.btnAddToInvoice);
            this.pnlAddItem.Controls.Add(this.txtSaleQuantity);
            this.pnlAddItem.Controls.Add(this.lblSaleQuantity);
            this.pnlAddItem.Controls.Add(this.txtSalePrice);
            this.pnlAddItem.Controls.Add(this.lblSalePrice);
            this.pnlAddItem.Controls.Add(this.cmbProducts);
            this.pnlAddItem.Controls.Add(this.lblProduct);
            this.pnlAddItem.Controls.Add(this.lblAddItemTitle);
            this.pnlAddItem.Location = new System.Drawing.Point(811, 204);
            this.pnlAddItem.Name = "pnlAddItem";
            this.pnlAddItem.Size = new System.Drawing.Size(377, 499);
            this.pnlAddItem.TabIndex = 2;
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.btnNewInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewInvoice.FlatAppearance.BorderSize = 0;
            this.btnNewInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewInvoice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewInvoice.ForeColor = System.Drawing.Color.White;
            this.btnNewInvoice.Location = new System.Drawing.Point(141, 407);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(224, 47);
            this.btnNewInvoice.TabIndex = 3;
            this.btnNewInvoice.Text = "📄   فاتورة جديدة";
            this.btnNewInvoice.UseVisualStyleBackColor = false;
            this.btnNewInvoice.Click += new System.EventHandler(this.btnNewInvoice_Click);
            // 
            // btnSaveInvoice
            // 
            this.btnSaveInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSaveInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveInvoice.FlatAppearance.BorderSize = 0;
            this.btnSaveInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveInvoice.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveInvoice.ForeColor = System.Drawing.Color.White;
            this.btnSaveInvoice.Location = new System.Drawing.Point(145, 336);
            this.btnSaveInvoice.Name = "btnSaveInvoice";
            this.btnSaveInvoice.Size = new System.Drawing.Size(220, 47);
            this.btnSaveInvoice.TabIndex = 2;
            this.btnSaveInvoice.Text = "💾   حفظ وترحيل الفاتورة";
            this.btnSaveInvoice.UseVisualStyleBackColor = false;
            this.btnSaveInvoice.Click += new System.EventHandler(this.btnSaveInvoice_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(28, 261);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(135, 40);
            this.btnRemoveItem.TabIndex = 8;
            this.btnRemoveItem.Text = "حذف صنف  🗑️";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddToInvoice
            // 
            this.btnAddToInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnAddToInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToInvoice.FlatAppearance.BorderSize = 0;
            this.btnAddToInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToInvoice.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToInvoice.ForeColor = System.Drawing.Color.White;
            this.btnAddToInvoice.Location = new System.Drawing.Point(212, 261);
            this.btnAddToInvoice.Name = "btnAddToInvoice";
            this.btnAddToInvoice.Size = new System.Drawing.Size(145, 40);
            this.btnAddToInvoice.TabIndex = 7;
            this.btnAddToInvoice.Text = "إضافة للصنف  +";
            this.btnAddToInvoice.UseVisualStyleBackColor = false;
            this.btnAddToInvoice.Click += new System.EventHandler(this.btnAddToInvoice_Click);
            // 
            // txtSaleQuantity
            // 
            this.txtSaleQuantity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleQuantity.Location = new System.Drawing.Point(23, 187);
            this.txtSaleQuantity.Name = "txtSaleQuantity";
            this.txtSaleQuantity.Size = new System.Drawing.Size(150, 37);
            this.txtSaleQuantity.TabIndex = 6;
            this.txtSaleQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSaleQuantity
            // 
            this.lblSaleQuantity.AutoSize = true;
            this.lblSaleQuantity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleQuantity.ForeColor = System.Drawing.Color.White;
            this.lblSaleQuantity.Location = new System.Drawing.Point(19, 141);
            this.lblSaleQuantity.Name = "lblSaleQuantity";
            this.lblSaleQuantity.Size = new System.Drawing.Size(166, 28);
            this.lblSaleQuantity.TabIndex = 5;
            this.lblSaleQuantity.Text = "كمية البيع (كرتون):";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.txtSalePrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.txtSalePrice.Location = new System.Drawing.Point(208, 187);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.ReadOnly = true;
            this.txtSalePrice.Size = new System.Drawing.Size(150, 37);
            this.txtSalePrice.TabIndex = 4;
            this.txtSalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalePrice.ForeColor = System.Drawing.Color.White;
            this.lblSalePrice.Location = new System.Drawing.Point(200, 141);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(173, 28);
            this.lblSalePrice.TabIndex = 3;
            this.lblSalePrice.Text = "سعر الكرتون (ريال):";
            // 
            // cmbProducts
            // 
            this.cmbProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(18, 83);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(351, 38);
            this.cmbProducts.TabIndex = 2;
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.cmbProducts_SelectedIndexChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(256, 53);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(114, 28);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "اختر الصنف:";
            // 
            // lblAddItemTitle
            // 
            this.lblAddItemTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddItemTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblAddItemTitle.Location = new System.Drawing.Point(154, 16);
            this.lblAddItemTitle.Name = "lblAddItemTitle";
            this.lblAddItemTitle.Size = new System.Drawing.Size(220, 26);
            this.lblAddItemTitle.TabIndex = 0;
            this.lblAddItemTitle.Text = "📦  إضافة صنف للفاتورة";
            this.lblAddItemTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlTableCard
            // 
            this.pnlTableCard.BackColor = System.Drawing.Color.White;
            this.pnlTableCard.Controls.Add(this.lblTotalTitle);
            this.pnlTableCard.Controls.Add(this.lblTableTitle);
            this.pnlTableCard.Controls.Add(this.lblGrandTotal);
            this.pnlTableCard.Controls.Add(this.dgvInvoiceItems);
            this.pnlTableCard.Location = new System.Drawing.Point(12, 209);
            this.pnlTableCard.Name = "pnlTableCard";
            this.pnlTableCard.Size = new System.Drawing.Size(793, 499);
            this.pnlTableCard.TabIndex = 3;
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.AutoSize = true;
            this.lblTotalTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTitle.ForeColor = System.Drawing.Color.White;
            this.lblTotalTitle.Location = new System.Drawing.Point(406, 448);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(306, 41);
            this.lblTotalTitle.TabIndex = 0;
            this.lblTotalTitle.Text = "إجمالي الفاتورة النهائي:";
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTableTitle.Location = new System.Drawing.Point(195, 7);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new System.Drawing.Size(400, 44);
            this.lblTableTitle.TabIndex = 1;
            this.lblTableTitle.Text = "📑  أصناف وبنود الفاتورة الحالية";
            this.lblTableTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.lblGrandTotal.Location = new System.Drawing.Point(30, 423);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(167, 66);
            this.lblGrandTotal.TabIndex = 1;
            this.lblGrandTotal.Text = "0.00";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvInvoiceItems
            // 
            this.dgvInvoiceItems.AllowUserToAddRows = false;
            this.dgvInvoiceItems.AllowUserToDeleteRows = false;
            this.dgvInvoiceItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvInvoiceItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoiceItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoiceItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoiceItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoiceItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInvoiceItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoiceItems.ColumnHeadersHeight = 42;
            this.dgvInvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInvoiceItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInvoiceProduct,
            this.colInvoiceQuantity,
            this.colInvoicePrice,
            this.colInvoiceTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoiceItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInvoiceItems.EnableHeadersVisualStyles = false;
            this.dgvInvoiceItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvInvoiceItems.Location = new System.Drawing.Point(-32, 54);
            this.dgvInvoiceItems.MultiSelect = false;
            this.dgvInvoiceItems.Name = "dgvInvoiceItems";
            this.dgvInvoiceItems.ReadOnly = true;
            this.dgvInvoiceItems.RowHeadersVisible = false;
            this.dgvInvoiceItems.RowHeadersWidth = 62;
            this.dgvInvoiceItems.RowTemplate.Height = 36;
            this.dgvInvoiceItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceItems.Size = new System.Drawing.Size(822, 345);
            this.dgvInvoiceItems.TabIndex = 0;
            // 
            // colInvoiceProduct
            // 
            this.colInvoiceProduct.FillWeight = 180F;
            this.colInvoiceProduct.HeaderText = "اسم المنتج";
            this.colInvoiceProduct.MinimumWidth = 8;
            this.colInvoiceProduct.Name = "colInvoiceProduct";
            this.colInvoiceProduct.ReadOnly = true;
            // 
            // colInvoiceQuantity
            // 
            this.colInvoiceQuantity.FillWeight = 85F;
            this.colInvoiceQuantity.HeaderText = "الكمية بالكرتون";
            this.colInvoiceQuantity.MinimumWidth = 8;
            this.colInvoiceQuantity.Name = "colInvoiceQuantity";
            this.colInvoiceQuantity.ReadOnly = true;
            // 
            // colInvoicePrice
            // 
            this.colInvoicePrice.FillWeight = 90F;
            this.colInvoicePrice.HeaderText = "سعر الكرتون (ريال)";
            this.colInvoicePrice.MinimumWidth = 8;
            this.colInvoicePrice.Name = "colInvoicePrice";
            this.colInvoicePrice.ReadOnly = true;
            // 
            // colInvoiceTotal
            // 
            this.colInvoiceTotal.FillWeight = 150F;
            this.colInvoiceTotal.HeaderText = "إجمالي الصنف (ريال)";
            this.colInvoiceTotal.MinimumWidth = 8;
            this.colInvoiceTotal.Name = "colInvoiceTotal";
            this.colInvoiceTotal.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 1);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1, 1);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.pnlTableCard);
            this.Controls.Add(this.pnlAddItem);
            this.Controls.Add(this.pnlInvoiceHeader);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form4";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة المبيعات وفواتير الجملة - مؤسسة النور";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlInvoiceHeader.ResumeLayout(false);
            this.pnlInvoiceHeader.PerformLayout();
            this.pnlAddItem.ResumeLayout(false);
            this.pnlAddItem.PerformLayout();
            this.pnlTableCard.ResumeLayout(false);
            this.pnlTableCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSalesTitle;
        private System.Windows.Forms.Button btnBackHome;
        private System.Windows.Forms.Panel pnlInvoiceHeader;
        private System.Windows.Forms.Label lblInvoiceHeaderTitle;
        private System.Windows.Forms.Label lblInvoiceID;
        private System.Windows.Forms.TextBox ttxtInvoiceIDextBox2;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.Panel pnlAddItem;
        private System.Windows.Forms.Label lblAddItemTitle;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label lblSaleQuantity;
        private System.Windows.Forms.TextBox txtSaleQuantity;
        private System.Windows.Forms.Button btnAddToInvoice;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Panel pnlTableCard;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.DataGridView dgvInvoiceItems;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Button btnSaveInvoice;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoicePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceTotal;
    }
}
