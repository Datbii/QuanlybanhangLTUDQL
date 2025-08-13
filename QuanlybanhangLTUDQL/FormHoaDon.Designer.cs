namespace QuanlybanhangLTUDQL
{
    partial class FormHoaDon
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cc = new System.Windows.Forms.GroupBox();
            this.cbdssanpham = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbloaisanpham = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDVT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSL = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtdongia = new Guna.UI2.WinForms.Guna2TextBox();
            this.butsua = new System.Windows.Forms.Button();
            this.butxoa = new System.Windows.Forms.Button();
            this.butthem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvhoadon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpNgayHD = new System.Windows.Forms.DateTimePicker();
            this.cbdanhsachKH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbdanhsachnv = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMaHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvcthd = new System.Windows.Forms.DataGridView();
            this.butinhoadon = new Guna.UI2.WinForms.Guna2Button();
            this.butxoahd = new Guna.UI2.WinForms.Guna2Button();
            this.butsuahd = new Guna.UI2.WinForms.Guna2Button();
            this.butluu = new Guna.UI2.WinForms.Guna2Button();
            this.buttaomoihd = new Guna.UI2.WinForms.Guna2Button();
            this.cc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvhoadon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvcthd)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Loại sản phẩm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Đơn vị tính ";
            // 
            // cc
            // 
            this.cc.Controls.Add(this.cbdssanpham);
            this.cc.Controls.Add(this.cbloaisanpham);
            this.cc.Controls.Add(this.txtDVT);
            this.cc.Controls.Add(this.txtSL);
            this.cc.Controls.Add(this.txtdongia);
            this.cc.Controls.Add(this.label9);
            this.cc.Controls.Add(this.label8);
            this.cc.Controls.Add(this.butsua);
            this.cc.Controls.Add(this.butxoa);
            this.cc.Controls.Add(this.butthem);
            this.cc.Controls.Add(this.label7);
            this.cc.Controls.Add(this.label6);
            this.cc.Controls.Add(this.label5);
            this.cc.Location = new System.Drawing.Point(526, 4);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(491, 140);
            this.cc.TabIndex = 38;
            this.cc.TabStop = false;
            this.cc.Text = "Chi tiết hóa đơn";
            // 
            // cbdssanpham
            // 
            this.cbdssanpham.BackColor = System.Drawing.Color.Transparent;
            this.cbdssanpham.BorderColor = System.Drawing.Color.Gray;
            this.cbdssanpham.BorderRadius = 5;
            this.cbdssanpham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbdssanpham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdssanpham.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbdssanpham.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbdssanpham.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdssanpham.ForeColor = System.Drawing.Color.Black;
            this.cbdssanpham.ItemHeight = 30;
            this.cbdssanpham.Items.AddRange(new object[] {
            "Cái",
            "Hộp",
            "Gói",
            "Chai",
            "Lít",
            "Kg",
            "Gram",
            "Bao",
            "Thùng",
            "Tấm",
            "Cuộn",
            "Hũ",
            "Túi",
            "Bộ",
            "Viên",
            "Đôi",
            "Thùng",
            "Lọ",
            "Can",
            "Mẫu",
            "Set",
            "Miếng",
            "Quả",
            "Cặp",
            "Tập",
            "Kẹp",
            "Sợi",
            "Chục",
            "Lạng",
            "Bịch"});
            this.cbdssanpham.Location = new System.Drawing.Point(15, 95);
            this.cbdssanpham.Name = "cbdssanpham";
            this.cbdssanpham.Size = new System.Drawing.Size(273, 36);
            this.cbdssanpham.TabIndex = 54;
            this.cbdssanpham.SelectedIndexChanged += new System.EventHandler(this.cbdssanpham_SelectedIndexChanged);
            // 
            // cbloaisanpham
            // 
            this.cbloaisanpham.BackColor = System.Drawing.Color.Transparent;
            this.cbloaisanpham.BorderColor = System.Drawing.Color.Gray;
            this.cbloaisanpham.BorderRadius = 5;
            this.cbloaisanpham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbloaisanpham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbloaisanpham.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbloaisanpham.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbloaisanpham.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbloaisanpham.ForeColor = System.Drawing.Color.Black;
            this.cbloaisanpham.ItemHeight = 30;
            this.cbloaisanpham.Location = new System.Drawing.Point(15, 30);
            this.cbloaisanpham.Name = "cbloaisanpham";
            this.cbloaisanpham.Size = new System.Drawing.Size(129, 36);
            this.cbloaisanpham.TabIndex = 54;
            this.cbloaisanpham.SelectedIndexChanged += new System.EventHandler(this.cbloaisanpham_SelectedIndexChanged);
            // 
            // txtDVT
            // 
            this.txtDVT.BorderColor = System.Drawing.Color.Gray;
            this.txtDVT.BorderRadius = 5;
            this.txtDVT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDVT.DefaultText = "";
            this.txtDVT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDVT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDVT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDVT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDVT.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtDVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDVT.ForeColor = System.Drawing.Color.Black;
            this.txtDVT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDVT.Location = new System.Drawing.Point(402, 30);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.PasswordChar = '\0';
            this.txtDVT.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtDVT.PlaceholderText = "DVT";
            this.txtDVT.ReadOnly = true;
            this.txtDVT.SelectedText = "";
            this.txtDVT.Size = new System.Drawing.Size(58, 34);
            this.txtDVT.TabIndex = 56;
            // 
            // txtSL
            // 
            this.txtSL.BorderColor = System.Drawing.Color.Gray;
            this.txtSL.BorderRadius = 5;
            this.txtSL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSL.DefaultText = "";
            this.txtSL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSL.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSL.ForeColor = System.Drawing.Color.Black;
            this.txtSL.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSL.Location = new System.Drawing.Point(331, 30);
            this.txtSL.Name = "txtSL";
            this.txtSL.PasswordChar = '\0';
            this.txtSL.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSL.PlaceholderText = "SL";
            this.txtSL.SelectedText = "";
            this.txtSL.Size = new System.Drawing.Size(58, 34);
            this.txtSL.TabIndex = 55;
            // 
            // txtdongia
            // 
            this.txtdongia.BorderColor = System.Drawing.Color.Gray;
            this.txtdongia.BorderRadius = 5;
            this.txtdongia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdongia.DefaultText = "";
            this.txtdongia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdongia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdongia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdongia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdongia.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtdongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtdongia.ForeColor = System.Drawing.Color.Black;
            this.txtdongia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdongia.Location = new System.Drawing.Point(172, 32);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.PasswordChar = '\0';
            this.txtdongia.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtdongia.PlaceholderText = "Đơn Giá";
            this.txtdongia.ReadOnly = true;
            this.txtdongia.SelectedText = "";
            this.txtdongia.Size = new System.Drawing.Size(116, 32);
            this.txtdongia.TabIndex = 54;
            // 
            // butsua
            // 
            this.butsua.BackColor = System.Drawing.Color.LightBlue;
            this.butsua.Location = new System.Drawing.Point(304, 111);
            this.butsua.Name = "butsua";
            this.butsua.Size = new System.Drawing.Size(75, 23);
            this.butsua.TabIndex = 11;
            this.butsua.Text = "Sửa";
            this.butsua.UseVisualStyleBackColor = false;
            this.butsua.Click += new System.EventHandler(this.butsua_Click);
            // 
            // butxoa
            // 
            this.butxoa.BackColor = System.Drawing.Color.LightBlue;
            this.butxoa.Location = new System.Drawing.Point(385, 111);
            this.butxoa.Name = "butxoa";
            this.butxoa.Size = new System.Drawing.Size(75, 23);
            this.butxoa.TabIndex = 12;
            this.butxoa.Text = "Xóa";
            this.butxoa.UseVisualStyleBackColor = false;
            this.butxoa.Click += new System.EventHandler(this.butxoa_Click);
            // 
            // butthem
            // 
            this.butthem.BackColor = System.Drawing.Color.LightBlue;
            this.butthem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butthem.Location = new System.Drawing.Point(385, 85);
            this.butthem.Name = "butthem";
            this.butthem.Size = new System.Drawing.Size(75, 23);
            this.butthem.TabIndex = 10;
            this.butthem.Text = "Thêm";
            this.butthem.UseVisualStyleBackColor = false;
            this.butthem.Click += new System.EventHandler(this.butthem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên sản phẩm";
            // 
            // dtgvhoadon
            // 
            this.dtgvhoadon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvhoadon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvhoadon.Location = new System.Drawing.Point(2, 150);
            this.dtgvhoadon.Name = "dtgvhoadon";
            this.dtgvhoadon.Size = new System.Drawing.Size(504, 244);
            this.dtgvhoadon.TabIndex = 35;
            this.dtgvhoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvhoadon_CellContentClick);
            this.dtgvhoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvhoadon_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpNgayHD);
            this.groupBox1.Controls.Add(this.cbdanhsachKH);
            this.groupBox1.Controls.Add(this.cbdanhsachnv);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 140);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // dtpNgayHD
            // 
            this.dtpNgayHD.Location = new System.Drawing.Point(22, 95);
            this.dtpNgayHD.Name = "dtpNgayHD";
            this.dtpNgayHD.Size = new System.Drawing.Size(220, 20);
            this.dtpNgayHD.TabIndex = 58;
            // 
            // cbdanhsachKH
            // 
            this.cbdanhsachKH.BackColor = System.Drawing.Color.Transparent;
            this.cbdanhsachKH.BorderColor = System.Drawing.Color.Gray;
            this.cbdanhsachKH.BorderRadius = 5;
            this.cbdanhsachKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbdanhsachKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdanhsachKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbdanhsachKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbdanhsachKH.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdanhsachKH.ForeColor = System.Drawing.Color.Black;
            this.cbdanhsachKH.ItemHeight = 30;
            this.cbdanhsachKH.Items.AddRange(new object[] {
            "Cái",
            "Hộp",
            "Gói",
            "Chai",
            "Lít",
            "Kg",
            "Gram",
            "Bao",
            "Thùng",
            "Tấm",
            "Cuộn",
            "Hũ",
            "Túi",
            "Bộ",
            "Viên",
            "Đôi",
            "Thùng",
            "Lọ",
            "Can",
            "Mẫu",
            "Set",
            "Miếng",
            "Quả",
            "Cặp",
            "Tập",
            "Kẹp",
            "Sợi",
            "Chục",
            "Lạng",
            "Bịch"});
            this.cbdanhsachKH.Location = new System.Drawing.Point(278, 88);
            this.cbdanhsachKH.Name = "cbdanhsachKH";
            this.cbdanhsachKH.Size = new System.Drawing.Size(220, 36);
            this.cbdanhsachKH.TabIndex = 53;
            // 
            // cbdanhsachnv
            // 
            this.cbdanhsachnv.BackColor = System.Drawing.Color.Transparent;
            this.cbdanhsachnv.BorderColor = System.Drawing.Color.Gray;
            this.cbdanhsachnv.BorderRadius = 5;
            this.cbdanhsachnv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbdanhsachnv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdanhsachnv.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbdanhsachnv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbdanhsachnv.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdanhsachnv.ForeColor = System.Drawing.Color.Black;
            this.cbdanhsachnv.ItemHeight = 30;
            this.cbdanhsachnv.Items.AddRange(new object[] {
            "Cái",
            "Hộp",
            "Gói",
            "Chai",
            "Lít",
            "Kg",
            "Gram",
            "Bao",
            "Thùng",
            "Tấm",
            "Cuộn",
            "Hũ",
            "Túi",
            "Bộ",
            "Viên",
            "Đôi",
            "Thùng",
            "Lọ",
            "Can",
            "Mẫu",
            "Set",
            "Miếng",
            "Quả",
            "Cặp",
            "Tập",
            "Kẹp",
            "Sợi",
            "Chục",
            "Lạng",
            "Bịch"});
            this.cbdanhsachnv.Location = new System.Drawing.Point(278, 32);
            this.cbdanhsachnv.Name = "cbdanhsachnv";
            this.cbdanhsachnv.Size = new System.Drawing.Size(220, 36);
            this.cbdanhsachnv.TabIndex = 52;
            // 
            // txtMaHD
            // 
            this.txtMaHD.BorderColor = System.Drawing.Color.Gray;
            this.txtMaHD.BorderRadius = 5;
            this.txtMaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHD.DefaultText = "";
            this.txtMaHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHD.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtMaHD.ForeColor = System.Drawing.Color.Black;
            this.txtMaHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.Location = new System.Drawing.Point(22, 32);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.PasswordChar = '\0';
            this.txtMaHD.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMaHD.PlaceholderText = "Mã hóa đơn";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.SelectedText = "";
            this.txtMaHD.Size = new System.Drawing.Size(220, 37);
            this.txtMaHD.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ngày hóa đơn \r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên khách hàng";
            // 
            // dtgvcthd
            // 
            this.dtgvcthd.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvcthd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvcthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvcthd.Location = new System.Drawing.Point(526, 150);
            this.dtgvcthd.Name = "dtgvcthd";
            this.dtgvcthd.Size = new System.Drawing.Size(491, 244);
            this.dtgvcthd.TabIndex = 37;
            this.dtgvcthd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvcthd_CellClick);
            this.dtgvcthd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvcthd_CellContentClick);
            // 
            // butinhoadon
            // 
            this.butinhoadon.BorderRadius = 5;
            this.butinhoadon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butinhoadon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butinhoadon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butinhoadon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butinhoadon.FillColor = System.Drawing.Color.RoyalBlue;
            this.butinhoadon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butinhoadon.ForeColor = System.Drawing.Color.White;
            this.butinhoadon.Location = new System.Drawing.Point(526, 400);
            this.butinhoadon.Name = "butinhoadon";
            this.butinhoadon.Size = new System.Drawing.Size(107, 45);
            this.butinhoadon.TabIndex = 53;
            this.butinhoadon.Text = "In";
            this.butinhoadon.Click += new System.EventHandler(this.butinhoadon_Click_1);
            // 
            // butxoahd
            // 
            this.butxoahd.BorderRadius = 5;
            this.butxoahd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butxoahd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butxoahd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butxoahd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butxoahd.FillColor = System.Drawing.Color.RoyalBlue;
            this.butxoahd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butxoahd.ForeColor = System.Drawing.Color.White;
            this.butxoahd.Location = new System.Drawing.Point(399, 400);
            this.butxoahd.Name = "butxoahd";
            this.butxoahd.Size = new System.Drawing.Size(107, 45);
            this.butxoahd.TabIndex = 54;
            this.butxoahd.Text = "Xóa";
            this.butxoahd.Click += new System.EventHandler(this.butxoahd_Click);
            // 
            // butsuahd
            // 
            this.butsuahd.BorderRadius = 5;
            this.butsuahd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butsuahd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butsuahd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butsuahd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butsuahd.FillColor = System.Drawing.Color.RoyalBlue;
            this.butsuahd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsuahd.ForeColor = System.Drawing.Color.White;
            this.butsuahd.Location = new System.Drawing.Point(263, 400);
            this.butsuahd.Name = "butsuahd";
            this.butsuahd.Size = new System.Drawing.Size(107, 45);
            this.butsuahd.TabIndex = 55;
            this.butsuahd.Text = "Sửa";
            this.butsuahd.Click += new System.EventHandler(this.butsuahd_Click);
            // 
            // butluu
            // 
            this.butluu.BorderRadius = 5;
            this.butluu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butluu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butluu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butluu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butluu.FillColor = System.Drawing.Color.RoyalBlue;
            this.butluu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butluu.ForeColor = System.Drawing.Color.White;
            this.butluu.Location = new System.Drawing.Point(127, 400);
            this.butluu.Name = "butluu";
            this.butluu.Size = new System.Drawing.Size(107, 45);
            this.butluu.TabIndex = 56;
            this.butluu.Text = "Lưu";
            this.butluu.Click += new System.EventHandler(this.butluu_Click);
            // 
            // buttaomoihd
            // 
            this.buttaomoihd.BorderRadius = 5;
            this.buttaomoihd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttaomoihd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttaomoihd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttaomoihd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttaomoihd.FillColor = System.Drawing.Color.RoyalBlue;
            this.buttaomoihd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttaomoihd.ForeColor = System.Drawing.Color.White;
            this.buttaomoihd.Location = new System.Drawing.Point(2, 400);
            this.buttaomoihd.Name = "buttaomoihd";
            this.buttaomoihd.Size = new System.Drawing.Size(107, 45);
            this.buttaomoihd.TabIndex = 57;
            this.buttaomoihd.Text = "Tạo mới";
            this.buttaomoihd.Click += new System.EventHandler(this.buttaomoihd_Click);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1031, 454);
            this.Controls.Add(this.buttaomoihd);
            this.Controls.Add(this.butluu);
            this.Controls.Add(this.butsuahd);
            this.Controls.Add(this.butxoahd);
            this.Controls.Add(this.butinhoadon);
            this.Controls.Add(this.cc);
            this.Controls.Add(this.dtgvhoadon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvcthd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHoaDon";
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.cc.ResumeLayout(false);
            this.cc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvhoadon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvcthd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox cc;
        private System.Windows.Forms.Button butsua;
        private System.Windows.Forms.Button butxoa;
        private System.Windows.Forms.Button butthem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvhoadon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvcthd;
        private Guna.UI2.WinForms.Guna2TextBox txtMaHD;
        private Guna.UI2.WinForms.Guna2TextBox txtdongia;
        private Guna.UI2.WinForms.Guna2ComboBox cbdanhsachKH;
        private Guna.UI2.WinForms.Guna2ComboBox cbdanhsachnv;
        private Guna.UI2.WinForms.Guna2ComboBox cbdssanpham;
        private Guna.UI2.WinForms.Guna2ComboBox cbloaisanpham;
        private Guna.UI2.WinForms.Guna2TextBox txtDVT;
        private Guna.UI2.WinForms.Guna2TextBox txtSL;
        private Guna.UI2.WinForms.Guna2Button butinhoadon;
        private Guna.UI2.WinForms.Guna2Button butxoahd;
        private Guna.UI2.WinForms.Guna2Button butsuahd;
        private Guna.UI2.WinForms.Guna2Button butluu;
        private Guna.UI2.WinForms.Guna2Button buttaomoihd;
        private System.Windows.Forms.DateTimePicker dtpNgayHD;
    }
}