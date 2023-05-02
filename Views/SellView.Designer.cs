namespace Supermarket_mvp.Views
{
    partial class SellView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSellList = new System.Windows.Forms.TabPage();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.DgSell = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tabPageSellDetail = new System.Windows.Forms.TabPage();
            this.BtnChooseAnotherPay = new System.Windows.Forms.Button();
            this.BtnChooseAnother = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.txtSellObservation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSellPayMode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSellTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSellCustomerId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSellId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DgSellPayMode = new System.Windows.Forms.DataGridView();
            this.DgSellProducts = new System.Windows.Forms.DataGridView();
            this.DgSellCustomers = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageSellList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgSell)).BeginInit();
            this.tabPageSellDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgSellPayMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgSellProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgSellCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 74);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Supermarket_mvp.Properties.Resources.sell;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(103, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELL";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageSellList);
            this.tabControl1.Controls.Add(this.tabPageSellDetail);
            this.tabControl1.Location = new System.Drawing.Point(7, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(981, 711);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageSellList
            // 
            this.tabPageSellList.Controls.Add(this.BtnClose);
            this.tabPageSellList.Controls.Add(this.BtnDelete);
            this.tabPageSellList.Controls.Add(this.BtnEdit);
            this.tabPageSellList.Controls.Add(this.BtnNew);
            this.tabPageSellList.Controls.Add(this.DgSell);
            this.tabPageSellList.Controls.Add(this.BtnSearch);
            this.tabPageSellList.Controls.Add(this.label11);
            this.tabPageSellList.Controls.Add(this.txtSearch);
            this.tabPageSellList.Location = new System.Drawing.Point(4, 24);
            this.tabPageSellList.Name = "tabPageSellList";
            this.tabPageSellList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSellList.Size = new System.Drawing.Size(973, 683);
            this.tabPageSellList.TabIndex = 0;
            this.tabPageSellList.Text = "Sell List";
            this.tabPageSellList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Image = global::Supermarket_mvp.Properties.Resources.cerrar;
            this.BtnClose.Location = new System.Drawing.Point(490, 263);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(180, 59);
            this.BtnClose.TabIndex = 19;
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Image = global::Supermarket_mvp.Properties.Resources.delete;
            this.BtnDelete.Location = new System.Drawing.Point(490, 199);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(180, 58);
            this.BtnDelete.TabIndex = 18;
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Image = global::Supermarket_mvp.Properties.Resources.edit;
            this.BtnEdit.Location = new System.Drawing.Point(490, 134);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(180, 59);
            this.BtnEdit.TabIndex = 17;
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Image = global::Supermarket_mvp.Properties.Resources._new;
            this.BtnNew.Location = new System.Drawing.Point(490, 69);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(180, 59);
            this.BtnNew.TabIndex = 16;
            this.BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgSell
            // 
            this.DgSell.AllowUserToAddRows = false;
            this.DgSell.AllowUserToDeleteRows = false;
            this.DgSell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgSell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgSell.Location = new System.Drawing.Point(13, 69);
            this.DgSell.Name = "DgSell";
            this.DgSell.ReadOnly = true;
            this.DgSell.RowTemplate.Height = 25;
            this.DgSell.Size = new System.Drawing.Size(471, 253);
            this.DgSell.TabIndex = 3;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.Image = global::Supermarket_mvp.Properties.Resources.search_small;
            this.BtnSearch.Location = new System.Drawing.Point(440, 23);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(44, 40);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Search Sell";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(13, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Data to search";
            this.txtSearch.Size = new System.Drawing.Size(421, 23);
            this.txtSearch.TabIndex = 0;
            // 
            // tabPageSellDetail
            // 
            this.tabPageSellDetail.Controls.Add(this.BtnChooseAnotherPay);
            this.tabPageSellDetail.Controls.Add(this.BtnChooseAnother);
            this.tabPageSellDetail.Controls.Add(this.button2);
            this.tabPageSellDetail.Controls.Add(this.label13);
            this.tabPageSellDetail.Controls.Add(this.txtSubtotal);
            this.tabPageSellDetail.Controls.Add(this.button1);
            this.tabPageSellDetail.Controls.Add(this.label12);
            this.tabPageSellDetail.Controls.Add(this.txtQuantity);
            this.tabPageSellDetail.Controls.Add(this.BtnCancel);
            this.tabPageSellDetail.Controls.Add(this.BtnSave);
            this.tabPageSellDetail.Controls.Add(this.txtSellObservation);
            this.tabPageSellDetail.Controls.Add(this.label10);
            this.tabPageSellDetail.Controls.Add(this.txtSellPayMode);
            this.tabPageSellDetail.Controls.Add(this.label9);
            this.tabPageSellDetail.Controls.Add(this.txtSellTotal);
            this.tabPageSellDetail.Controls.Add(this.label8);
            this.tabPageSellDetail.Controls.Add(this.txtSellCustomerId);
            this.tabPageSellDetail.Controls.Add(this.label7);
            this.tabPageSellDetail.Controls.Add(this.txtSellId);
            this.tabPageSellDetail.Controls.Add(this.label6);
            this.tabPageSellDetail.Controls.Add(this.DgSellPayMode);
            this.tabPageSellDetail.Controls.Add(this.DgSellProducts);
            this.tabPageSellDetail.Controls.Add(this.DgSellCustomers);
            this.tabPageSellDetail.Controls.Add(this.label4);
            this.tabPageSellDetail.Controls.Add(this.label5);
            this.tabPageSellDetail.Controls.Add(this.label3);
            this.tabPageSellDetail.Location = new System.Drawing.Point(4, 24);
            this.tabPageSellDetail.Name = "tabPageSellDetail";
            this.tabPageSellDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSellDetail.Size = new System.Drawing.Size(939, 683);
            this.tabPageSellDetail.TabIndex = 1;
            this.tabPageSellDetail.Text = "Sell Detail";
            this.tabPageSellDetail.UseVisualStyleBackColor = true;
            // 
            // BtnChooseAnotherPay
            // 
            this.BtnChooseAnotherPay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnChooseAnotherPay.Location = new System.Drawing.Point(322, 401);
            this.BtnChooseAnotherPay.Name = "BtnChooseAnotherPay";
            this.BtnChooseAnotherPay.Size = new System.Drawing.Size(137, 40);
            this.BtnChooseAnotherPay.TabIndex = 31;
            this.BtnChooseAnotherPay.Text = "<<Choose Another>>";
            this.BtnChooseAnotherPay.UseVisualStyleBackColor = true;
            this.BtnChooseAnotherPay.Click += new System.EventHandler(this.BtnChooseAnotherPay_Click);
            // 
            // BtnChooseAnother
            // 
            this.BtnChooseAnother.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnChooseAnother.Location = new System.Drawing.Point(319, 180);
            this.BtnChooseAnother.Name = "BtnChooseAnother";
            this.BtnChooseAnother.Size = new System.Drawing.Size(137, 40);
            this.BtnChooseAnother.TabIndex = 30;
            this.BtnChooseAnother.Text = "<<Choose Another>>";
            this.BtnChooseAnother.UseVisualStyleBackColor = true;
            this.BtnChooseAnother.Click += new System.EventHandler(this.BtnChooseAnother_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(465, 620);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 40);
            this.button2.TabIndex = 29;
            this.button2.Text = "<<Finish>>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(792, 617);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(792, 637);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(119, 23);
            this.txtSubtotal.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(322, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 40);
            this.button1.TabIndex = 26;
            this.button1.Text = "<<Enter Product>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(598, 617);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Product quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(650, 637);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(69, 23);
            this.txtQuantity.TabIndex = 24;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Image = global::Supermarket_mvp.Properties.Resources.cancel;
            this.BtnCancel.Location = new System.Drawing.Point(198, 442);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(103, 40);
            this.BtnCancel.TabIndex = 23;
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Image = global::Supermarket_mvp.Properties.Resources.save;
            this.BtnSave.Location = new System.Drawing.Point(18, 441);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(103, 40);
            this.BtnSave.TabIndex = 22;
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // txtSellObservation
            // 
            this.txtSellObservation.Location = new System.Drawing.Point(16, 339);
            this.txtSellObservation.Multiline = true;
            this.txtSellObservation.Name = "txtSellObservation";
            this.txtSellObservation.Size = new System.Drawing.Size(287, 74);
            this.txtSellObservation.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(15, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Observation";
            // 
            // txtSellPayMode
            // 
            this.txtSellPayMode.Location = new System.Drawing.Point(16, 210);
            this.txtSellPayMode.Name = "txtSellPayMode";
            this.txtSellPayMode.ReadOnly = true;
            this.txtSellPayMode.Size = new System.Drawing.Size(202, 23);
            this.txtSellPayMode.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(16, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Pay Mode";
            // 
            // txtSellTotal
            // 
            this.txtSellTotal.Location = new System.Drawing.Point(18, 270);
            this.txtSellTotal.Name = "txtSellTotal";
            this.txtSellTotal.ReadOnly = true;
            this.txtSellTotal.Size = new System.Drawing.Size(130, 23);
            this.txtSellTotal.TabIndex = 17;
            this.txtSellTotal.Text = "0";
            this.txtSellTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(15, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sell Total";
            // 
            // txtSellCustomerId
            // 
            this.txtSellCustomerId.Location = new System.Drawing.Point(16, 141);
            this.txtSellCustomerId.Name = "txtSellCustomerId";
            this.txtSellCustomerId.ReadOnly = true;
            this.txtSellCustomerId.Size = new System.Drawing.Size(130, 23);
            this.txtSellCustomerId.TabIndex = 15;
            this.txtSellCustomerId.Text = "0";
            this.txtSellCustomerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(14, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sell Customer Id";
            // 
            // txtSellId
            // 
            this.txtSellId.Location = new System.Drawing.Point(16, 88);
            this.txtSellId.Name = "txtSellId";
            this.txtSellId.ReadOnly = true;
            this.txtSellId.Size = new System.Drawing.Size(130, 23);
            this.txtSellId.TabIndex = 13;
            this.txtSellId.Text = "0";
            this.txtSellId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(15, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Sell Id";
            // 
            // DgSellPayMode
            // 
            this.DgSellPayMode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgSellPayMode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgSellPayMode.Location = new System.Drawing.Point(322, 247);
            this.DgSellPayMode.Name = "DgSellPayMode";
            this.DgSellPayMode.RowTemplate.Height = 25;
            this.DgSellPayMode.Size = new System.Drawing.Size(460, 150);
            this.DgSellPayMode.TabIndex = 11;
            this.DgSellPayMode.Click += new System.EventHandler(this.DgSellPayMode_Click);
            // 
            // DgSellProducts
            // 
            this.DgSellProducts.AllowUserToAddRows = false;
            this.DgSellProducts.AllowUserToDeleteRows = false;
            this.DgSellProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgSellProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgSellProducts.Location = new System.Drawing.Point(322, 465);
            this.DgSellProducts.Name = "DgSellProducts";
            this.DgSellProducts.ReadOnly = true;
            this.DgSellProducts.RowTemplate.Height = 25;
            this.DgSellProducts.Size = new System.Drawing.Size(589, 150);
            this.DgSellProducts.TabIndex = 10;
            this.DgSellProducts.Click += new System.EventHandler(this.DgSellProducts_Click);
            // 
            // DgSellCustomers
            // 
            this.DgSellCustomers.AllowUserToAddRows = false;
            this.DgSellCustomers.AllowUserToDeleteRows = false;
            this.DgSellCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgSellCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgSellCustomers.Location = new System.Drawing.Point(319, 25);
            this.DgSellCustomers.Name = "DgSellCustomers";
            this.DgSellCustomers.ReadOnly = true;
            this.DgSellCustomers.RowTemplate.Height = 25;
            this.DgSellCustomers.Size = new System.Drawing.Size(463, 150);
            this.DgSellCustomers.TabIndex = 9;
            this.DgSellCustomers.Click += new System.EventHandler(this.DgSellCustomers_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(318, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Choose Customers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(319, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Choose Pay Mode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(319, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose Products:";
            // 
            // SellView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 787);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "SellView";
            this.Text = "SellView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageSellList.ResumeLayout(false);
            this.tabPageSellList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgSell)).EndInit();
            this.tabPageSellDetail.ResumeLayout(false);
            this.tabPageSellDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgSellPayMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgSellProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgSellCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageSellList;
        private TabPage tabPageSellDetail;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSellId;
        private Label label6;
        private DataGridView DgSellPayMode;
        private DataGridView DgSellProducts;
        private DataGridView DgSellCustomers;
        private TextBox txtSellCustomerId;
        private Label label7;
        private TextBox txtSellTotal;
        private Label label8;
        private Label label10;
        private TextBox txtSellPayMode;
        private Label label9;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox txtSellObservation;
        private DataGridView DgSell;
        private Button BtnSearch;
        private Label label11;
        private TextBox txtSearch;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Label label12;
        private TextBox txtQuantity;
        private Button button1;
        private Label label13;
        private TextBox txtSubtotal;
        private Button button2;
        private Button BtnChooseAnother;
        private Button BtnChooseAnotherPay;
    }
}