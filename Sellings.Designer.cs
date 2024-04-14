namespace Pharmacy_Management_System
{
    partial class Sellings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sellings));
            this.btnManufacturar = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DGVBill = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textMedicine = new System.Windows.Forms.TextBox();
            this.DGVMedicineLists = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoLogout = new System.Windows.Forms.PictureBox();
            this.GoSellers = new System.Windows.Forms.PictureBox();
            this.GoSeller = new System.Windows.Forms.PictureBox();
            this.GoCustomers = new System.Windows.Forms.PictureBox();
            this.GoMedicines = new System.Windows.Forms.PictureBox();
            this.GoManufacturar = new System.Windows.Forms.PictureBox();
            this.GoDashboard = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSelling = new System.Windows.Forms.Button();
            this.btnSellers = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnMedicines = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblSellerName = new System.Windows.Forms.Label();
            this.PrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedicineLists)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSellers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSeller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoMedicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoManufacturar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManufacturar
            // 
            this.btnManufacturar.BackColor = System.Drawing.Color.White;
            this.btnManufacturar.FlatAppearance.BorderSize = 0;
            this.btnManufacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManufacturar.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnManufacturar.Location = new System.Drawing.Point(64, 221);
            this.btnManufacturar.Name = "btnManufacturar";
            this.btnManufacturar.Size = new System.Drawing.Size(195, 40);
            this.btnManufacturar.TabIndex = 14;
            this.btnManufacturar.Text = "Manufacturar";
            this.btnManufacturar.UseVisualStyleBackColor = false;
            this.btnManufacturar.Click += new System.EventHandler(this.btnManufacturar_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnDashboard.Location = new System.Drawing.Point(64, 150);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(195, 40);
            this.btnDashboard.TabIndex = 14;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(260, 152);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(207, 37);
            this.txtPrice.TabIndex = 21;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(2, 2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(100, 100);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 12;
            this.PictureBox1.TabStop = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(259, 73);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(207, 37);
            this.txtQuantity.TabIndex = 16;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Location = new System.Drawing.Point(13, 152);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(225, 37);
            this.txtCustomerName.TabIndex = 16;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtSellerName_TextChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(701, 557);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(136, 48);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(192, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 40);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Add to Bill";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.LimeGreen;
            this.label8.Location = new System.Drawing.Point(263, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 28);
            this.label8.TabIndex = 14;
            this.label8.Text = "Quantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.LimeGreen;
            this.label12.Location = new System.Drawing.Point(265, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 28);
            this.label12.TabIndex = 14;
            this.label12.Text = "Price";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.LimeGreen;
            this.label10.Location = new System.Drawing.Point(13, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 28);
            this.label10.TabIndex = 14;
            this.label10.Text = "Customer Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LimeGreen;
            this.label6.Location = new System.Drawing.Point(12, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Customer Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LimeGreen;
            this.label5.Location = new System.Drawing.Point(2, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 28);
            this.label5.TabIndex = 14;
            this.label5.Text = "Billing Module";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(108, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "Health Care";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(276, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 28);
            this.label3.TabIndex = 45;
            this.label3.Text = "Selling";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.DGVBill);
            this.panel2.Controls.Add(this.LblTotal);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textMedicine);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.DGVMedicineLists);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtCustomerId);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.txtCustomerName);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(280, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 630);
            this.panel2.TabIndex = 41;
            // 
            // DGVBill
            // 
            this.DGVBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVBill.BackgroundColor = System.Drawing.Color.White;
            this.DGVBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.meds,
            this.qty,
            this.price,
            this.total});
            this.DGVBill.GridColor = System.Drawing.Color.Black;
            this.DGVBill.Location = new System.Drawing.Point(14, 376);
            this.DGVBill.Name = "DGVBill";
            this.DGVBill.RowHeadersWidth = 62;
            this.DGVBill.RowTemplate.Height = 28;
            this.DGVBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVBill.Size = new System.Drawing.Size(547, 223);
            this.DGVBill.TabIndex = 25;
            this.DGVBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVBill_CellContentClick_1);
            // 
            // id
            // 
            this.id.HeaderText = "Bill_Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 115;
            // 
            // meds
            // 
            this.meds.HeaderText = "Medicine_Name";
            this.meds.MinimumWidth = 6;
            this.meds.Name = "meds";
            this.meds.Width = 241;
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            this.qty.Width = 146;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 105;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.Width = 102;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.ForeColor = System.Drawing.Color.LimeGreen;
            this.LblTotal.Location = new System.Drawing.Point(697, 393);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(148, 28);
            this.LblTotal.TabIndex = 24;
            this.LblTotal.Text = "Total in BDT ";
            this.LblTotal.Click += new System.EventHandler(this.LblTotal_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.LimeGreen;
            this.label9.Location = new System.Drawing.Point(247, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 28);
            this.label9.TabIndex = 22;
            this.label9.Text = "Bill";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textMedicine
            // 
            this.textMedicine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMedicine.Location = new System.Drawing.Point(139, 225);
            this.textMedicine.Name = "textMedicine";
            this.textMedicine.Size = new System.Drawing.Size(237, 37);
            this.textMedicine.TabIndex = 21;
            this.textMedicine.TextChanged += new System.EventHandler(this.textMedicine_TextChanged);
            // 
            // DGVMedicineLists
            // 
            this.DGVMedicineLists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DGVMedicineLists.BackgroundColor = System.Drawing.Color.White;
            this.DGVMedicineLists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMedicineLists.GridColor = System.Drawing.Color.Black;
            this.DGVMedicineLists.Location = new System.Drawing.Point(472, 44);
            this.DGVMedicineLists.Name = "DGVMedicineLists";
            this.DGVMedicineLists.RowHeadersWidth = 62;
            this.DGVMedicineLists.RowTemplate.Height = 28;
            this.DGVMedicineLists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMedicineLists.Size = new System.Drawing.Size(509, 244);
            this.DGVMedicineLists.TabIndex = 20;
            this.DGVMedicineLists.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMedicineList_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.LimeGreen;
            this.label11.Location = new System.Drawing.Point(626, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 28);
            this.label11.TabIndex = 19;
            this.label11.Text = "Medicine List";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.FormattingEnabled = true;
            this.txtCustomerId.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.txtCustomerId.Location = new System.Drawing.Point(13, 72);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(225, 36);
            this.txtCustomerId.TabIndex = 18;
            this.txtCustomerId.SelectedIndexChanged += new System.EventHandler(this.txtGender_SelectedIndexChanged);
            this.txtCustomerId.SelectionChangeCommitted += new System.EventHandler(this.txtCustomerId_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LimeGreen;
            this.label7.Location = new System.Drawing.Point(201, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Medicine";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.GoLogout);
            this.panel1.Controls.Add(this.GoSellers);
            this.panel1.Controls.Add(this.GoSeller);
            this.panel1.Controls.Add(this.GoCustomers);
            this.panel1.Controls.Add(this.GoMedicines);
            this.panel1.Controls.Add(this.GoManufacturar);
            this.panel1.Controls.Add(this.GoDashboard);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnSelling);
            this.panel1.Controls.Add(this.btnSellers);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnMedicines);
            this.panel1.Controls.Add(this.btnManufacturar);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 768);
            this.panel1.TabIndex = 40;
            // 
            // GoLogout
            // 
            this.GoLogout.Image = ((System.Drawing.Image)(resources.GetObject("GoLogout.Image")));
            this.GoLogout.Location = new System.Drawing.Point(5, 673);
            this.GoLogout.Name = "GoLogout";
            this.GoLogout.Size = new System.Drawing.Size(50, 50);
            this.GoLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoLogout.TabIndex = 15;
            this.GoLogout.TabStop = false;
            this.GoLogout.Click += new System.EventHandler(this.GoLogout_Click);
            // 
            // GoSellers
            // 
            this.GoSellers.Image = ((System.Drawing.Image)(resources.GetObject("GoSellers.Image")));
            this.GoSellers.Location = new System.Drawing.Point(5, 496);
            this.GoSellers.Name = "GoSellers";
            this.GoSellers.Size = new System.Drawing.Size(50, 50);
            this.GoSellers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoSellers.TabIndex = 15;
            this.GoSellers.TabStop = false;
            // 
            // GoSeller
            // 
            this.GoSeller.Image = ((System.Drawing.Image)(resources.GetObject("GoSeller.Image")));
            this.GoSeller.Location = new System.Drawing.Point(5, 430);
            this.GoSeller.Name = "GoSeller";
            this.GoSeller.Size = new System.Drawing.Size(50, 50);
            this.GoSeller.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoSeller.TabIndex = 15;
            this.GoSeller.TabStop = false;
            this.GoSeller.Click += new System.EventHandler(this.GoSeller_Click);
            // 
            // GoCustomers
            // 
            this.GoCustomers.Image = ((System.Drawing.Image)(resources.GetObject("GoCustomers.Image")));
            this.GoCustomers.Location = new System.Drawing.Point(5, 360);
            this.GoCustomers.Name = "GoCustomers";
            this.GoCustomers.Size = new System.Drawing.Size(50, 50);
            this.GoCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoCustomers.TabIndex = 15;
            this.GoCustomers.TabStop = false;
            this.GoCustomers.Click += new System.EventHandler(this.GoCustomers_Click);
            // 
            // GoMedicines
            // 
            this.GoMedicines.Image = ((System.Drawing.Image)(resources.GetObject("GoMedicines.Image")));
            this.GoMedicines.Location = new System.Drawing.Point(5, 288);
            this.GoMedicines.Name = "GoMedicines";
            this.GoMedicines.Size = new System.Drawing.Size(50, 50);
            this.GoMedicines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoMedicines.TabIndex = 15;
            this.GoMedicines.TabStop = false;
            this.GoMedicines.Click += new System.EventHandler(this.GoMedicines_Click);
            // 
            // GoManufacturar
            // 
            this.GoManufacturar.Image = ((System.Drawing.Image)(resources.GetObject("GoManufacturar.Image")));
            this.GoManufacturar.Location = new System.Drawing.Point(5, 216);
            this.GoManufacturar.Name = "GoManufacturar";
            this.GoManufacturar.Size = new System.Drawing.Size(50, 50);
            this.GoManufacturar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoManufacturar.TabIndex = 15;
            this.GoManufacturar.TabStop = false;
            this.GoManufacturar.Click += new System.EventHandler(this.GoManufacturar_Click);
            // 
            // GoDashboard
            // 
            this.GoDashboard.Image = ((System.Drawing.Image)(resources.GetObject("GoDashboard.Image")));
            this.GoDashboard.Location = new System.Drawing.Point(5, 145);
            this.GoDashboard.Name = "GoDashboard";
            this.GoDashboard.Size = new System.Drawing.Size(50, 50);
            this.GoDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoDashboard.TabIndex = 15;
            this.GoDashboard.TabStop = false;
            this.GoDashboard.Click += new System.EventHandler(this.GoDashboard_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnLogout.Location = new System.Drawing.Point(63, 679);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(195, 40);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSelling
            // 
            this.btnSelling.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSelling.FlatAppearance.BorderSize = 0;
            this.btnSelling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelling.ForeColor = System.Drawing.Color.White;
            this.btnSelling.Location = new System.Drawing.Point(64, 501);
            this.btnSelling.Name = "btnSelling";
            this.btnSelling.Size = new System.Drawing.Size(195, 40);
            this.btnSelling.TabIndex = 14;
            this.btnSelling.Text = "Selling";
            this.btnSelling.UseVisualStyleBackColor = false;
            this.btnSelling.Click += new System.EventHandler(this.btnSelling_Click);
            // 
            // btnSellers
            // 
            this.btnSellers.BackColor = System.Drawing.Color.White;
            this.btnSellers.FlatAppearance.BorderSize = 0;
            this.btnSellers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellers.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnSellers.Location = new System.Drawing.Point(64, 435);
            this.btnSellers.Name = "btnSellers";
            this.btnSellers.Size = new System.Drawing.Size(195, 40);
            this.btnSellers.TabIndex = 14;
            this.btnSellers.Text = "Sellers";
            this.btnSellers.UseVisualStyleBackColor = false;
            this.btnSellers.Click += new System.EventHandler(this.btnSellers_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.White;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnCustomers.Location = new System.Drawing.Point(66, 365);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(195, 40);
            this.btnCustomers.TabIndex = 14;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnMedicines
            // 
            this.btnMedicines.BackColor = System.Drawing.Color.White;
            this.btnMedicines.FlatAppearance.BorderSize = 0;
            this.btnMedicines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicines.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnMedicines.Location = new System.Drawing.Point(64, 293);
            this.btnMedicines.Name = "btnMedicines";
            this.btnMedicines.Size = new System.Drawing.Size(195, 40);
            this.btnMedicines.TabIndex = 14;
            this.btnMedicines.Text = "Medicines";
            this.btnMedicines.UseVisualStyleBackColor = false;
            this.btnMedicines.Click += new System.EventHandler(this.btnMedicines_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1244, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 32);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 44;
            this.btnClose.TabStop = false;
            this.btnClose.UseWaitCursor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(584, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 28);
            this.label1.TabIndex = 42;
            this.label1.Text = "Pharmacy Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(703, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 43;
            this.label2.Text = "Version 1.0";
            // 
            // LblSellerName
            // 
            this.LblSellerName.AutoSize = true;
            this.LblSellerName.ForeColor = System.Drawing.Color.White;
            this.LblSellerName.Location = new System.Drawing.Point(1075, 9);
            this.LblSellerName.Name = "LblSellerName";
            this.LblSellerName.Size = new System.Drawing.Size(153, 28);
            this.LblSellerName.TabIndex = 45;
            this.LblSellerName.Text = "Seller Name";
            this.LblSellerName.Click += new System.EventHandler(this.label15_Click);
            // 
            // PrintPreviewDialog
            // 
            this.PrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialog.Document = this.PrintDocument;
            this.PrintPreviewDialog.Enabled = true;
            this.PrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialog.Icon")));
            this.PrintPreviewDialog.Name = "PrintPreviewDialog";
            this.PrintPreviewDialog.Visible = false;
            this.PrintPreviewDialog.Load += new System.EventHandler(this.PrintPreviewDialog_Load);
            // 
            // PrintDocument
            // 
            this.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // Sellings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.LblSellerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Sellings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sellings";
            this.Load += new System.EventHandler(this.Sellings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedicineLists)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSellers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoSeller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoMedicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoManufacturar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManufacturar;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DGVMedicineLists;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtCustomerId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox GoLogout;
        private System.Windows.Forms.PictureBox GoSellers;
        private System.Windows.Forms.PictureBox GoSeller;
        private System.Windows.Forms.PictureBox GoCustomers;
        private System.Windows.Forms.PictureBox GoMedicines;
        private System.Windows.Forms.PictureBox GoManufacturar;
        private System.Windows.Forms.PictureBox GoDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSelling;
        private System.Windows.Forms.Button btnSellers;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnMedicines;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textMedicine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblSellerName;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private System.Windows.Forms.DataGridView DGVBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn meds;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}