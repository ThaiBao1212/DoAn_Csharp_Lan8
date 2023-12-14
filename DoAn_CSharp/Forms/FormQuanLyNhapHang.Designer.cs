namespace DoAn_CSharp.Forms
{
    partial class FormQuanLyNhapHang
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
            this.tbQuanLyNhapHang = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachPhieuNhap = new System.Windows.Forms.DataGridView();
            this.btnXoaQLPN = new FontAwesome.Sharp.IconButton();
            this.dateTimePickerDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTimKiemQLPN = new System.Windows.Forms.ComboBox();
            this.txtTimKiemQLPN = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnChuyenQua = new FontAwesome.Sharp.IconButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnNhapHang = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongSoLuongNhap = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnXoaALLTPN = new FontAwesome.Sharp.IconButton();
            this.btnXoaTPN = new FontAwesome.Sharp.IconButton();
            this.dtgvChiTietNhapHang = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.cbTimKiemTPN = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTimKiemTPN = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayLapPhieuTPN = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbQuanLyNhapHang.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPhieuNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhieuNhap)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietNhapHang)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSanPham)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbQuanLyNhapHang
            // 
            this.tbQuanLyNhapHang.Controls.Add(this.tabPage1);
            this.tbQuanLyNhapHang.Controls.Add(this.tabPage2);
            this.tbQuanLyNhapHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQuanLyNhapHang.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuanLyNhapHang.Location = new System.Drawing.Point(0, 0);
            this.tbQuanLyNhapHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbQuanLyNhapHang.Name = "tbQuanLyNhapHang";
            this.tbQuanLyNhapHang.SelectedIndex = 0;
            this.tbQuanLyNhapHang.Size = new System.Drawing.Size(1312, 725);
            this.tbQuanLyNhapHang.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1304, 692);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản Lý Phiếu Nhập";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvChiTietPhieuNhap);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(247, 399);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(807, 283);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Phiếu Nhập";
            // 
            // dtgvChiTietPhieuNhap
            // 
            this.dtgvChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietPhieuNhap.Location = new System.Drawing.Point(8, 23);
            this.dtgvChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvChiTietPhieuNhap.Name = "dtgvChiTietPhieuNhap";
            this.dtgvChiTietPhieuNhap.RowHeadersWidth = 51;
            this.dtgvChiTietPhieuNhap.Size = new System.Drawing.Size(791, 252);
            this.dtgvChiTietPhieuNhap.TabIndex = 70;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvDanhSachPhieuNhap);
            this.groupBox1.Controls.Add(this.btnXoaQLPN);
            this.groupBox1.Controls.Add(this.dateTimePickerDenNgay);
            this.groupBox1.Controls.Add(this.dateTimePickerTuNgay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbTimKiemQLPN);
            this.groupBox1.Controls.Add(this.txtTimKiemQLPN);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1283, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phiếu Nhập";
            // 
            // dtgvDanhSachPhieuNhap
            // 
            this.dtgvDanhSachPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachPhieuNhap.Location = new System.Drawing.Point(8, 124);
            this.dtgvDanhSachPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvDanhSachPhieuNhap.Name = "dtgvDanhSachPhieuNhap";
            this.dtgvDanhSachPhieuNhap.RowHeadersWidth = 51;
            this.dtgvDanhSachPhieuNhap.Size = new System.Drawing.Size(1267, 235);
            this.dtgvDanhSachPhieuNhap.TabIndex = 69;
            // 
            // btnXoaQLPN
            // 
            this.btnXoaQLPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaQLPN.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaQLPN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaQLPN.IconColor = System.Drawing.Color.Black;
            this.btnXoaQLPN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaQLPN.Location = new System.Drawing.Point(988, 64);
            this.btnXoaQLPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaQLPN.Name = "btnXoaQLPN";
            this.btnXoaQLPN.Size = new System.Drawing.Size(100, 28);
            this.btnXoaQLPN.TabIndex = 68;
            this.btnXoaQLPN.Text = "Xóa";
            this.btnXoaQLPN.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDenNgay
            // 
            this.dateTimePickerDenNgay.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDenNgay.Location = new System.Drawing.Point(644, 81);
            this.dateTimePickerDenNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerDenNgay.Name = "dateTimePickerDenNgay";
            this.dateTimePickerDenNgay.Size = new System.Drawing.Size(161, 23);
            this.dateTimePickerDenNgay.TabIndex = 67;
            // 
            // dateTimePickerTuNgay
            // 
            this.dateTimePickerTuNgay.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTuNgay.Location = new System.Drawing.Point(432, 81);
            this.dateTimePickerTuNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerTuNgay.Name = "dateTimePickerTuNgay";
            this.dateTimePickerTuNgay.Size = new System.Drawing.Size(161, 23);
            this.dateTimePickerTuNgay.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(640, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 65;
            this.label3.Text = "Đến Ngày :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 64;
            this.label2.Text = "Từ Ngày :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 63;
            this.label1.Text = "Lọc :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(301, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 62;
            this.label7.Text = "Tìm Kiếm :";
            // 
            // cbTimKiemQLPN
            // 
            this.cbTimKiemQLPN.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiemQLPN.FormattingEnabled = true;
            this.cbTimKiemQLPN.Location = new System.Drawing.Point(737, 16);
            this.cbTimKiemQLPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTimKiemQLPN.Name = "cbTimKiemQLPN";
            this.cbTimKiemQLPN.Size = new System.Drawing.Size(152, 25);
            this.cbTimKiemQLPN.TabIndex = 61;
            // 
            // txtTimKiemQLPN
            // 
            this.txtTimKiemQLPN.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemQLPN.Location = new System.Drawing.Point(432, 16);
            this.txtTimKiemQLPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiemQLPN.Name = "txtTimKiemQLPN";
            this.txtTimKiemQLPN.Size = new System.Drawing.Size(265, 23);
            this.txtTimKiemQLPN.TabIndex = 60;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnChuyenQua);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1304, 692);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thêm Phiếu Nhập";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnChuyenQua
            // 
            this.btnChuyenQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyenQua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenQua.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChuyenQua.IconColor = System.Drawing.Color.Black;
            this.btnChuyenQua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChuyenQua.Location = new System.Drawing.Point(631, 266);
            this.btnChuyenQua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChuyenQua.Name = "btnChuyenQua";
            this.btnChuyenQua.Size = new System.Drawing.Size(51, 28);
            this.btnChuyenQua.TabIndex = 66;
            this.btnChuyenQua.Text = ">";
            this.btnChuyenQua.UseVisualStyleBackColor = true;
            this.btnChuyenQua.Click += new System.EventHandler(this.btnChuyenQua_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnNhapHang);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txtTongSoLuongNhap);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(703, 423);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(587, 256);
            this.groupBox6.TabIndex = 58;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nhập Hàng";
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnNhapHang.IconColor = System.Drawing.Color.Black;
            this.btnNhapHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhapHang.Location = new System.Drawing.Point(203, 174);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(197, 34);
            this.btnNhapHang.TabIndex = 66;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 19);
            this.label9.TabIndex = 60;
            this.label9.Text = "Tổng Số Lượng Nhập :";
            // 
            // txtTongSoLuongNhap
            // 
            this.txtTongSoLuongNhap.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongSoLuongNhap.Location = new System.Drawing.Point(240, 74);
            this.txtTongSoLuongNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongSoLuongNhap.Name = "txtTongSoLuongNhap";
            this.txtTongSoLuongNhap.Size = new System.Drawing.Size(300, 23);
            this.txtTongSoLuongNhap.TabIndex = 59;
            this.txtTongSoLuongNhap.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(11, 423);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(620, 256);
            this.groupBox5.TabIndex = 57;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hình Ảnh Sản Phẩm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnXoaALLTPN);
            this.groupBox4.Controls.Add(this.btnXoaTPN);
            this.groupBox4.Controls.Add(this.dtgvChiTietNhapHang);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(681, 95);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(609, 321);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi Tiết Nhập Hàng";
            // 
            // btnXoaALLTPN
            // 
            this.btnXoaALLTPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaALLTPN.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaALLTPN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaALLTPN.IconColor = System.Drawing.Color.Black;
            this.btnXoaALLTPN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaALLTPN.Location = new System.Drawing.Point(372, 39);
            this.btnXoaALLTPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaALLTPN.Name = "btnXoaALLTPN";
            this.btnXoaALLTPN.Size = new System.Drawing.Size(100, 28);
            this.btnXoaALLTPN.TabIndex = 65;
            this.btnXoaALLTPN.Text = "Xóa ALL ";
            this.btnXoaALLTPN.UseVisualStyleBackColor = true;
            // 
            // btnXoaTPN
            // 
            this.btnXoaTPN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTPN.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTPN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoaTPN.IconColor = System.Drawing.Color.Black;
            this.btnXoaTPN.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaTPN.Location = new System.Drawing.Point(501, 39);
            this.btnXoaTPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaTPN.Name = "btnXoaTPN";
            this.btnXoaTPN.Size = new System.Drawing.Size(100, 28);
            this.btnXoaTPN.TabIndex = 64;
            this.btnXoaTPN.Text = "Xóa";
            this.btnXoaTPN.UseVisualStyleBackColor = true;
            // 
            // dtgvChiTietNhapHang
            // 
            this.dtgvChiTietNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietNhapHang.Location = new System.Drawing.Point(8, 87);
            this.dtgvChiTietNhapHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvChiTietNhapHang.Name = "dtgvChiTietNhapHang";
            this.dtgvChiTietNhapHang.RowHeadersWidth = 51;
            this.dtgvChiTietNhapHang.Size = new System.Drawing.Size(608, 226);
            this.dtgvChiTietNhapHang.TabIndex = 63;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgvDanhSachSanPham);
            this.groupBox3.Controls.Add(this.cbTimKiemTPN);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtTimKiemTPN);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 95);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(620, 321);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Sản Phẩm ";
            // 
            // dtgvDanhSachSanPham
            // 
            this.dtgvDanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dtgvDanhSachSanPham.Location = new System.Drawing.Point(8, 87);
            this.dtgvDanhSachSanPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvDanhSachSanPham.Name = "dtgvDanhSachSanPham";
            this.dtgvDanhSachSanPham.RowHeadersWidth = 51;
            this.dtgvDanhSachSanPham.Size = new System.Drawing.Size(604, 226);
            this.dtgvDanhSachSanPham.TabIndex = 62;
            // 
            // cbTimKiemTPN
            // 
            this.cbTimKiemTPN.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiemTPN.FormattingEnabled = true;
            this.cbTimKiemTPN.Location = new System.Drawing.Point(399, 44);
            this.cbTimKiemTPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTimKiemTPN.Name = "cbTimKiemTPN";
            this.cbTimKiemTPN.Size = new System.Drawing.Size(187, 24);
            this.cbTimKiemTPN.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 19);
            this.label8.TabIndex = 60;
            this.label8.Text = "Tìm Kiếm :";
            // 
            // txtTimKiemTPN
            // 
            this.txtTimKiemTPN.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemTPN.Location = new System.Drawing.Point(136, 44);
            this.txtTimKiemTPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiemTPN.Name = "txtTimKiemTPN";
            this.txtTimKiemTPN.Size = new System.Drawing.Size(219, 23);
            this.txtTimKiemTPN.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMaNhanVien);
            this.panel1.Controls.Add(this.dateTimePickerNgayLapPhieuTPN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMaPhieuNhap);
            this.panel1.Location = new System.Drawing.Point(11, 7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 80);
            this.panel1.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(857, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 57;
            this.label6.Text = "Nhân Viên :";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(985, 26);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(265, 23);
            this.txtMaNhanVien.TabIndex = 56;
            // 
            // dateTimePickerNgayLapPhieuTPN
            // 
            this.dateTimePickerNgayLapPhieuTPN.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgayLapPhieuTPN.Location = new System.Drawing.Point(545, 23);
            this.dateTimePickerNgayLapPhieuTPN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerNgayLapPhieuTPN.Name = "dateTimePickerNgayLapPhieuTPN";
            this.dateTimePickerNgayLapPhieuTPN.Size = new System.Drawing.Size(265, 23);
            this.dateTimePickerNgayLapPhieuTPN.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 57;
            this.label5.Text = "Ngày Lập Phiếu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 19);
            this.label4.TabIndex = 54;
            this.label4.Text = "Mã Phiếu Nhập :";
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(184, 23);
            this.txtMaPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(152, 23);
            this.txtMaPhieuNhap.TabIndex = 53;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // FormQuanLyNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 725);
            this.Controls.Add(this.tbQuanLyNhapHang);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormQuanLyNhapHang";
            this.Text = "QUẢN LÝ NHẬP HÀNG";
            this.tbQuanLyNhapHang.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietPhieuNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhieuNhap)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietNhapHang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachSanPham)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbQuanLyNhapHang;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDanhSachPhieuNhap;
        private FontAwesome.Sharp.IconButton btnXoaQLPN;
        private System.Windows.Forms.DateTimePicker dateTimePickerDenNgay;
        private System.Windows.Forms.DateTimePicker dateTimePickerTuNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTimKiemQLPN;
        private System.Windows.Forms.TextBox txtTimKiemQLPN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvChiTietPhieuNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayLapPhieuTPN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbTimKiemTPN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTimKiemTPN;
        private System.Windows.Forms.DataGridView dtgvDanhSachSanPham;
        private System.Windows.Forms.DataGridView dtgvChiTietNhapHang;
        private FontAwesome.Sharp.IconButton btnNhapHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTongSoLuongNhap;
        private FontAwesome.Sharp.IconButton btnXoaALLTPN;
        private FontAwesome.Sharp.IconButton btnXoaTPN;
        private FontAwesome.Sharp.IconButton btnChuyenQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}