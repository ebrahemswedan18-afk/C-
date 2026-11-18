namespace AlNorWholesale
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBackHome = new System.Windows.Forms.Button();
            this.lblProductsTitle = new System.Windows.Forms.Label();
            this.pnlInputCard = new System.Windows.Forms.Panel();
            this.btnClearProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtCartonPrice = new System.Windows.Forms.TextBox();
            this.lblCartonPrice = new System.Windows.Forms.Label();
            this.txtProducName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblCardHeading = new System.Windows.Forms.Label();
            this.pnlTableCard = new System.Windows.Forms.Panel();
            this.lblTableTitle = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloCartonPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlInputCard.SuspendLayout();
            this.pnlTableCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.pnlHeader.Controls.Add(this.btnBackHome);
            this.pnlHeader.Controls.Add(this.lblProductsTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 85);
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
            this.btnBackHome.Location = new System.Drawing.Point(25, 20);
            this.btnBackHome.Name = "btnBackHome";
            this.btnBackHome.Size = new System.Drawing.Size(322, 46);
            this.btnBackHome.TabIndex = 0;
            this.btnBackHome.Text = "↩   الصفحة الرئيسية";
            this.btnBackHome.UseVisualStyleBackColor = false;
            this.btnBackHome.Click += new System.EventHandler(this.btnBackHome_Click);
            // 
            // lblProductsTitle
            // 
            this.lblProductsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProductsTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductsTitle.ForeColor = System.Drawing.Color.White;
            this.lblProductsTitle.Location = new System.Drawing.Point(424, 9);
            this.lblProductsTitle.Name = "lblProductsTitle";
            this.lblProductsTitle.Size = new System.Drawing.Size(720, 66);
            this.lblProductsTitle.TabIndex = 1;
            this.lblProductsTitle.Text = "إدارة المنتجات والمخزون - مؤسسة النور";
            this.lblProductsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlInputCard
            // 
            this.pnlInputCard.BackColor = System.Drawing.Color.White;
            this.pnlInputCard.Controls.Add(this.btnClearProduct);
            this.pnlInputCard.Controls.Add(this.btnDeleteProduct);
            this.pnlInputCard.Controls.Add(this.btnEditProduct);
            this.pnlInputCard.Controls.Add(this.btnAddProduct);
            this.pnlInputCard.Controls.Add(this.txtQuantity);
            this.pnlInputCard.Controls.Add(this.lblQuantity);
            this.pnlInputCard.Controls.Add(this.txtCartonPrice);
            this.pnlInputCard.Controls.Add(this.lblCartonPrice);
            this.pnlInputCard.Controls.Add(this.txtProducName);
            this.pnlInputCard.Controls.Add(this.lblProductName);
            this.pnlInputCard.Controls.Add(this.txtProductID);
            this.pnlInputCard.Controls.Add(this.lblProductID);
            this.pnlInputCard.Controls.Add(this.lblCardHeading);
            this.pnlInputCard.Location = new System.Drawing.Point(35, 99);
            this.pnlInputCard.Name = "pnlInputCard";
            this.pnlInputCard.Size = new System.Drawing.Size(1130, 216);
            this.pnlInputCard.TabIndex = 1;
            // 
            // btnClearProduct
            // 
            this.btnClearProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.btnClearProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearProduct.FlatAppearance.BorderSize = 0;
            this.btnClearProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearProduct.ForeColor = System.Drawing.Color.White;
            this.btnClearProduct.Location = new System.Drawing.Point(30, 140);
            this.btnClearProduct.Name = "btnClearProduct";
            this.btnClearProduct.Size = new System.Drawing.Size(130, 42);
            this.btnClearProduct.TabIndex = 12;
            this.btnClearProduct.Text = "تفريغ  🔄";
            this.btnClearProduct.UseVisualStyleBackColor = false;
            this.btnClearProduct.Click += new System.EventHandler(this.btnClearProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Location = new System.Drawing.Point(170, 140);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(135, 42);
            this.btnDeleteProduct.TabIndex = 11;
            this.btnDeleteProduct.Text = "حذف  🗑️";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(119)))), ((int)(((byte)(6)))));
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.Location = new System.Drawing.Point(315, 140);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(135, 42);
            this.btnEditProduct.TabIndex = 10;
            this.btnEditProduct.Text = "تعديل  ✏️";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(150)))), ((int)(((byte)(105)))));
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(460, 140);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(135, 42);
            this.btnAddProduct.TabIndex = 9;
            this.btnAddProduct.Text = "إضافة  +";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(870, 160);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(230, 37);
            this.txtQuantity.TabIndex = 6;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblQuantity.Location = new System.Drawing.Point(952, 127);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(147, 30);
            this.lblQuantity.TabIndex = 5;
            this.lblQuantity.Text = "الكمية بالكرتون:";
            // 
            // txtCartonPrice
            // 
            this.txtCartonPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartonPrice.Location = new System.Drawing.Point(620, 160);
            this.txtCartonPrice.Name = "txtCartonPrice";
            this.txtCartonPrice.Size = new System.Drawing.Size(225, 37);
            this.txtCartonPrice.TabIndex = 8;
            // 
            // lblCartonPrice
            // 
            this.lblCartonPrice.AutoSize = true;
            this.lblCartonPrice.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartonPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblCartonPrice.Location = new System.Drawing.Point(655, 127);
            this.lblCartonPrice.Name = "lblCartonPrice";
            this.lblCartonPrice.Size = new System.Drawing.Size(185, 30);
            this.lblCartonPrice.TabIndex = 7;
            this.lblCartonPrice.Text = "سعر الكرتون (ريال):";
            // 
            // txtProducName
            // 
            this.txtProducName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducName.Location = new System.Drawing.Point(30, 72);
            this.txtProducName.Name = "txtProducName";
            this.txtProducName.Size = new System.Drawing.Size(815, 37);
            this.txtProducName.TabIndex = 4;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblProductName.Location = new System.Drawing.Point(730, 39);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(110, 30);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "اسم المنتج:";
            // 
            // txtProductID
            // 
            this.txtProductID.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.Location = new System.Drawing.Point(870, 72);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(230, 37);
            this.txtProductID.TabIndex = 2;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblProductID.Location = new System.Drawing.Point(994, 39);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(105, 30);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "رقم المنتج:";
            // 
            // lblCardHeading
            // 
            this.lblCardHeading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblCardHeading.Location = new System.Drawing.Point(856, 5);
            this.lblCardHeading.Name = "lblCardHeading";
            this.lblCardHeading.Size = new System.Drawing.Size(280, 35);
            this.lblCardHeading.TabIndex = 0;
            this.lblCardHeading.Text = "📝  بيانات الصنف والمنتج";
            this.lblCardHeading.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlTableCard
            // 
            this.pnlTableCard.BackColor = System.Drawing.Color.White;
            this.pnlTableCard.Controls.Add(this.lblTableTitle);
            this.pnlTableCard.Controls.Add(this.dgvProducts);
            this.pnlTableCard.Location = new System.Drawing.Point(35, 331);
            this.pnlTableCard.Name = "pnlTableCard";
            this.pnlTableCard.Size = new System.Drawing.Size(1130, 385);
            this.pnlTableCard.TabIndex = 2;
            // 
            // lblTableTitle
            // 
            this.lblTableTitle.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblTableTitle.Location = new System.Drawing.Point(700, 12);
            this.lblTableTitle.Name = "lblTableTitle";
            this.lblTableTitle.Size = new System.Drawing.Size(400, 35);
            this.lblTableTitle.TabIndex = 1;
            this.lblTableTitle.Text = "📋  قائمة المنتجات المتوفرة في المخزن";
            this.lblTableTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProducts.ColumnHeadersHeight = 42;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductID,
            this.colProductName,
            this.cloCartonPrice,
            this.cloQuantity});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgvProducts.Location = new System.Drawing.Point(20, 50);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 36;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(1090, 315);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellClick);
            // 
            // colProductID
            // 
            this.colProductID.FillWeight = 70F;
            this.colProductID.HeaderText = "رقم المنتج";
            this.colProductID.MinimumWidth = 8;
            this.colProductID.Name = "colProductID";
            this.colProductID.ReadOnly = true;
            // 
            // colProductName
            // 
            this.colProductName.FillWeight = 210F;
            this.colProductName.HeaderText = "اسم المنتج";
            this.colProductName.MinimumWidth = 8;
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // cloCartonPrice
            // 
            this.cloCartonPrice.FillWeight = 85F;
            this.cloCartonPrice.HeaderText = "سعر الكرتون (ريال)";
            this.cloCartonPrice.MinimumWidth = 8;
            this.cloCartonPrice.Name = "cloCartonPrice";
            this.cloCartonPrice.ReadOnly = true;
            // 
            // cloQuantity
            // 
            this.cloQuantity.FillWeight = 85F;
            this.cloQuantity.HeaderText = "الكمية بالمخزن";
            this.cloQuantity.MinimumWidth = 8;
            this.cloQuantity.Name = "cloQuantity";
            this.cloQuantity.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1, 1);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 1);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.pnlTableCard);
            this.Controls.Add(this.pnlInputCard);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة المنتجات والمخزون - مؤسسة النور";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlInputCard.ResumeLayout(false);
            this.pnlInputCard.PerformLayout();
            this.pnlTableCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblProductsTitle;
        private System.Windows.Forms.Button btnBackHome;
        private System.Windows.Forms.Panel pnlInputCard;
        private System.Windows.Forms.Label lblCardHeading;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProducName;
        private System.Windows.Forms.Label lblCartonPrice;
        private System.Windows.Forms.TextBox txtCartonPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnClearProduct;
        private System.Windows.Forms.Panel pnlTableCard;
        private System.Windows.Forms.Label lblTableTitle;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloCartonPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloQuantity;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
