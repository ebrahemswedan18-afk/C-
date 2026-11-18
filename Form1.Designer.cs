namespace AlNorWholesale
{
    partial class Form1
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
            this.btnCheckConnection = new System.Windows.Forms.Button();
            this.lblTitel = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblSidebarBrand = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.lblDbInfo = new System.Windows.Forms.Label();
            this.pnlCard1 = new System.Windows.Forms.Panel();
            this.lblCard1Sub = new System.Windows.Forms.Label();
            this.lblCard1Title = new System.Windows.Forms.Label();
            this.pnlCard2 = new System.Windows.Forms.Panel();
            this.lblCard2Sub = new System.Windows.Forms.Label();
            this.lblCard2Title = new System.Windows.Forms.Label();
            this.pnlCard3 = new System.Windows.Forms.Panel();
            this.lblCard3Sub = new System.Windows.Forms.Label();
            this.lblCard3Title = new System.Windows.Forms.Label();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.dgvRecentInvoices = new System.Windows.Forms.DataGridView();
            this.colRecentInvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecentCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecentTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlCard1.SuspendLayout();
            this.pnlCard2.SuspendLayout();
            this.pnlCard3.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlHeader.Controls.Add(this.btnCheckConnection);
            this.pnlHeader.Controls.Add(this.lblTitel);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 99);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnCheckConnection
            // 
            this.btnCheckConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(148)))), ((int)(((byte)(136)))));
            this.btnCheckConnection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckConnection.FlatAppearance.BorderSize = 0;
            this.btnCheckConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckConnection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckConnection.ForeColor = System.Drawing.Color.White;
            this.btnCheckConnection.Location = new System.Drawing.Point(25, 20);
            this.btnCheckConnection.Name = "btnCheckConnection";
            this.btnCheckConnection.Size = new System.Drawing.Size(280, 46);
            this.btnCheckConnection.TabIndex = 0;
            this.btnCheckConnection.Text = "⚡ فحص اتصال Oracle";
            this.btnCheckConnection.UseVisualStyleBackColor = false;
            this.btnCheckConnection.Click += new System.EventHandler(this.btnCheckConnection_Click);
            // 
            // lblTitel
            // 
            this.lblTitel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.White;
            this.lblTitel.Location = new System.Drawing.Point(378, 20);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(720, 62);
            this.lblTitel.TabIndex = 1;
            this.lblTitel.Text = "مؤسسة النور لإدارة مبيعات الجملة";
            this.lblTitel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnlSidebar.Controls.Add(this.lblSidebarBrand);
            this.pnlSidebar.Controls.Add(this.btnHome);
            this.pnlSidebar.Controls.Add(this.btnProducts);
            this.pnlSidebar.Controls.Add(this.btnCustomers);
            this.pnlSidebar.Controls.Add(this.btnSales);
            this.pnlSidebar.Controls.Add(this.lblDbInfo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSidebar.Location = new System.Drawing.Point(960, 99);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(240, 541);
            this.pnlSidebar.TabIndex = 1;
            // 
            // lblSidebarBrand
            // 
            this.lblSidebarBrand.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSidebarBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblSidebarBrand.Location = new System.Drawing.Point(15, 15);
            this.lblSidebarBrand.Name = "lblSidebarBrand";
            this.lblSidebarBrand.Size = new System.Drawing.Size(210, 30);
            this.lblSidebarBrand.TabIndex = 5;
            this.lblSidebarBrand.Text = "القائمة الرئيسية";
            this.lblSidebarBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(15, 60);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnHome.Size = new System.Drawing.Size(253, 52);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "🏠   الصفحة الرئيسية";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnProducts.Location = new System.Drawing.Point(15, 125);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnProducts.Size = new System.Drawing.Size(253, 52);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "📦   إدارة المنتجات";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnCustomers.Location = new System.Drawing.Point(15, 190);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnCustomers.Size = new System.Drawing.Size(253, 52);
            this.btnCustomers.TabIndex = 2;
            this.btnCustomers.Text = "👥   إدارة العملاء";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.btnSales.Location = new System.Drawing.Point(15, 255);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnSales.Size = new System.Drawing.Size(253, 52);
            this.btnSales.TabIndex = 3;
            this.btnSales.Text = "🧾   المبيعات والفواتير";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // lblDbInfo
            // 
            this.lblDbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDbInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDbInfo.Location = new System.Drawing.Point(15, 319);
            this.lblDbInfo.Name = "lblDbInfo";
            this.lblDbInfo.Size = new System.Drawing.Size(210, 222);
            this.lblDbInfo.TabIndex = 4;
            this.lblDbInfo.Text = "قاعدة البيانات: Oracle Database\r\n\r\nتطوير الطلاب :\r\nابراهيم سويدان \r\nأمجد الصاعي \r" +
    "\nمحمد باعديل \r\n\r\n";
            this.lblDbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCard1
            // 
            this.pnlCard1.BackColor = System.Drawing.Color.White;
            this.pnlCard1.Controls.Add(this.lblCard1Sub);
            this.pnlCard1.Controls.Add(this.lblCard1Title);
            this.pnlCard1.Location = new System.Drawing.Point(639, 105);
            this.pnlCard1.Name = "pnlCard1";
            this.pnlCard1.Size = new System.Drawing.Size(291, 95);
            this.pnlCard1.TabIndex = 2;
            // 
            // lblCard1Sub
            // 
            this.lblCard1Sub.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard1Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCard1Sub.Location = new System.Drawing.Point(10, 59);
            this.lblCard1Sub.Name = "lblCard1Sub";
            this.lblCard1Sub.Size = new System.Drawing.Size(260, 26);
            this.lblCard1Sub.TabIndex = 1;
            this.lblCard1Sub.Text = "متابعة أرصدة وأسعار الكراتين";
            this.lblCard1Sub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCard1Title
            // 
            this.lblCard1Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblCard1Title.Location = new System.Drawing.Point(16, 9);
            this.lblCard1Title.Name = "lblCard1Title";
            this.lblCard1Title.Size = new System.Drawing.Size(272, 47);
            this.lblCard1Title.TabIndex = 0;
            this.lblCard1Title.Text = "📦 المنتجات في المخزن";
            this.lblCard1Title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlCard2
            // 
            this.pnlCard2.BackColor = System.Drawing.Color.White;
            this.pnlCard2.Controls.Add(this.lblCard2Sub);
            this.pnlCard2.Controls.Add(this.lblCard2Title);
            this.pnlCard2.Location = new System.Drawing.Point(335, 105);
            this.pnlCard2.Name = "pnlCard2";
            this.pnlCard2.Size = new System.Drawing.Size(280, 95);
            this.pnlCard2.TabIndex = 3;
            // 
            // lblCard2Sub
            // 
            this.lblCard2Sub.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard2Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCard2Sub.Location = new System.Drawing.Point(10, 58);
            this.lblCard2Sub.Name = "lblCard2Sub";
            this.lblCard2Sub.Size = new System.Drawing.Size(260, 26);
            this.lblCard2Sub.TabIndex = 1;
            this.lblCard2Sub.Text = "بيانات التواصل وعناوين التوزيع";
            this.lblCard2Sub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCard2Title
            // 
            this.lblCard2Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lblCard2Title.Location = new System.Drawing.Point(92, 12);
            this.lblCard2Title.Name = "lblCard2Title";
            this.lblCard2Title.Size = new System.Drawing.Size(185, 47);
            this.lblCard2Title.TabIndex = 0;
            this.lblCard2Title.Text = "👥 دليل العملاء";
            this.lblCard2Title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlCard3
            // 
            this.pnlCard3.BackColor = System.Drawing.Color.White;
            this.pnlCard3.Controls.Add(this.lblCard3Sub);
            this.pnlCard3.Controls.Add(this.lblCard3Title);
            this.pnlCard3.Location = new System.Drawing.Point(15, 105);
            this.pnlCard3.Name = "pnlCard3";
            this.pnlCard3.Size = new System.Drawing.Size(280, 95);
            this.pnlCard3.TabIndex = 4;
            // 
            // lblCard3Sub
            // 
            this.lblCard3Sub.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard3Sub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblCard3Sub.Location = new System.Drawing.Point(10, 59);
            this.lblCard3Sub.Name = "lblCard3Sub";
            this.lblCard3Sub.Size = new System.Drawing.Size(260, 26);
            this.lblCard3Sub.TabIndex = 1;
            this.lblCard3Sub.Text = "إصدار فواتير الجملة وترحيلها";
            this.lblCard3Sub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCard3Title
            // 
            this.lblCard3Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCard3Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.lblCard3Title.Location = new System.Drawing.Point(56, 9);
            this.lblCard3Title.Name = "lblCard3Title";
            this.lblCard3Title.Size = new System.Drawing.Size(204, 47);
            this.lblCard3Title.TabIndex = 0;
            this.lblCard3Title.Text = "🧾 حركة المبيعات";
            this.lblCard3Title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlGridCard
            // 
            this.pnlGridCard.BackColor = System.Drawing.Color.White;
            this.pnlGridCard.Controls.Add(this.lblGridTitle);
            this.pnlGridCard.Controls.Add(this.dgvRecentInvoices);
            this.pnlGridCard.Location = new System.Drawing.Point(12, 216);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Size = new System.Drawing.Size(918, 408);
            this.pnlGridCard.TabIndex = 5;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblGridTitle.Location = new System.Drawing.Point(376, 8);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(480, 45);
            this.lblGridTitle.TabIndex = 1;
            this.lblGridTitle.Text = "📋 أحدث الفواتير المسجلة في النظام";
            this.lblGridTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvRecentInvoices
            // 
            this.dgvRecentInvoices.AllowUserToAddRows = false;
            this.dgvRecentInvoices.AllowUserToDeleteRows = false;
            this.dgvRecentInvoices.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvRecentInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRecentInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentInvoices.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentInvoices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentInvoices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecentInvoices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecentInvoices.ColumnHeadersHeight = 42;
            this.dgvRecentInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecentInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRecentInvoiceID,
            this.colRecentCustomer,
            this.colRecentDate,
            this.colRecentTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecentInvoices.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecentInvoices.EnableHeadersVisualStyles = false;
            this.dgvRecentInvoices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvRecentInvoices.Location = new System.Drawing.Point(13, 56);
            this.dgvRecentInvoices.MultiSelect = false;
            this.dgvRecentInvoices.Name = "dgvRecentInvoices";
            this.dgvRecentInvoices.ReadOnly = true;
            this.dgvRecentInvoices.RowHeadersVisible = false;
            this.dgvRecentInvoices.RowHeadersWidth = 62;
            this.dgvRecentInvoices.RowTemplate.Height = 36;
            this.dgvRecentInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentInvoices.Size = new System.Drawing.Size(850, 339);
            this.dgvRecentInvoices.TabIndex = 0;
            // 
            // colRecentInvoiceID
            // 
            this.colRecentInvoiceID.FillWeight = 80F;
            this.colRecentInvoiceID.HeaderText = "رقم الفاتورة";
            this.colRecentInvoiceID.MinimumWidth = 8;
            this.colRecentInvoiceID.Name = "colRecentInvoiceID";
            this.colRecentInvoiceID.ReadOnly = true;
            // 
            // colRecentCustomer
            // 
            this.colRecentCustomer.FillWeight = 160F;
            this.colRecentCustomer.HeaderText = "اسم العميل";
            this.colRecentCustomer.MinimumWidth = 8;
            this.colRecentCustomer.Name = "colRecentCustomer";
            this.colRecentCustomer.ReadOnly = true;
            // 
            // colRecentDate
            // 
            this.colRecentDate.FillWeight = 110F;
            this.colRecentDate.HeaderText = "تاريخ الفاتورة";
            this.colRecentDate.MinimumWidth = 8;
            this.colRecentDate.Name = "colRecentDate";
            this.colRecentDate.ReadOnly = true;
            // 
            // colRecentTotal
            // 
            this.colRecentTotal.FillWeight = 110F;
            this.colRecentTotal.HeaderText = "إجمالي المبلغ (ريال)";
            this.colRecentTotal.MinimumWidth = 8;
            this.colRecentTotal.Name = "colRecentTotal";
            this.colRecentTotal.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 1);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 1);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1, 1);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1, 1);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1, 1);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(0, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1, 1);
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1200, 640);
            this.Controls.Add(this.pnlGridCard);
            this.Controls.Add(this.pnlCard3);
            this.Controls.Add(this.pnlCard2);
            this.Controls.Add(this.pnlCard1);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام إدارة مبيعات الجملة - مؤسسة النور";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlCard1.ResumeLayout(false);
            this.pnlCard2.ResumeLayout(false);
            this.pnlCard3.ResumeLayout(false);
            this.pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Button btnCheckConnection;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblSidebarBrand;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Label lblDbInfo;
        private System.Windows.Forms.Panel pnlCard1;
        private System.Windows.Forms.Label lblCard1Title;
        private System.Windows.Forms.Label lblCard1Sub;
        private System.Windows.Forms.Panel pnlCard2;
        private System.Windows.Forms.Label lblCard2Title;
        private System.Windows.Forms.Label lblCard2Sub;
        private System.Windows.Forms.Panel pnlCard3;
        private System.Windows.Forms.Label lblCard3Title;
        private System.Windows.Forms.Label lblCard3Sub;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.DataGridView dgvRecentInvoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecentInvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecentCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecentTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}
