namespace DoAn_CSharp.Forms
{
    partial class FormQuanLyHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.dateTimePickerDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvChiTietHD = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXuatHoaDon = new FontAwesome.Sharp.IconButton();
            this.reportViewerHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MaCTHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHD)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvDanhSachHoaDon);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.dateTimePickerDenNgay);
            this.groupBox1.Controls.Add(this.dateTimePickerTuNgay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbTimKiem);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(688, 427);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hóa Đơn";
            // 
            // dtgvDanhSachHoaDon
            // 
            this.dtgvDanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.MaNV,
            this.NgayLapHD,
            this.TrangThaiHD});
            this.dtgvDanhSachHoaDon.Location = new System.Drawing.Point(8, 172);
            this.dtgvDanhSachHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDanhSachHoaDon.Name = "dtgvDanhSachHoaDon";
            this.dtgvDanhSachHoaDon.RowHeadersWidth = 51;
            this.dtgvDanhSachHoaDon.Size = new System.Drawing.Size(672, 247);
            this.dtgvDanhSachHoaDon.TabIndex = 60;
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoa.IconColor = System.Drawing.Color.Black;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.Location = new System.Drawing.Point(580, 98);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDenNgay
            // 
            this.dateTimePickerDenNgay.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDenNgay.Location = new System.Drawing.Point(351, 127);
            this.dateTimePickerDenNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDenNgay.Name = "dateTimePickerDenNgay";
            this.dateTimePickerDenNgay.Size = new System.Drawing.Size(161, 23);
            this.dateTimePickerDenNgay.TabIndex = 58;
            // 
            // dateTimePickerTuNgay
            // 
            this.dateTimePickerTuNgay.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTuNgay.Location = new System.Drawing.Point(139, 127);
            this.dateTimePickerTuNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerTuNgay.Name = "dateTimePickerTuNgay";
            this.dateTimePickerTuNgay.Size = new System.Drawing.Size(161, 23);
            this.dateTimePickerTuNgay.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 56;
            this.label3.Text = "Đến Ngày :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 55;
            this.label2.Text = "Từ Ngày :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "Lọc :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 52;
            this.label7.Text = "Tìm Kiếm :";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Location = new System.Drawing.Point(444, 50);
            this.cbTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(152, 25);
            this.cbTimKiem.TabIndex = 51;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(139, 50);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(265, 23);
            this.txtTimKiem.TabIndex = 50;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvChiTietHD);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 437);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(688, 287);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Hóa Đơn";
            // 
            // dtgvChiTietHD
            // 
            this.dtgvChiTietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCTHD,
            this.Column2,
            this.MaSP,
            this.DonGia,
            this.SizeSP,
            this.SoLuongSP,
            this.ThanhTien});
            this.dtgvChiTietHD.Location = new System.Drawing.Point(8, 30);
            this.dtgvChiTietHD.Name = "dtgvChiTietHD";
            this.dtgvChiTietHD.RowHeadersWidth = 51;
            this.dtgvChiTietHD.RowTemplate.Height = 24;
            this.dtgvChiTietHD.Size = new System.Drawing.Size(673, 243);
            this.dtgvChiTietHD.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXuatHoaDon);
            this.panel1.Location = new System.Drawing.Point(699, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 63);
            this.panel1.TabIndex = 4;
            // 
            // btnXuatHoaDon
            // 
            this.btnXuatHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatHoaDon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHoaDon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXuatHoaDon.IconColor = System.Drawing.Color.Black;
            this.btnXuatHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXuatHoaDon.Location = new System.Drawing.Point(233, 16);
            this.btnXuatHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuatHoaDon.Name = "btnXuatHoaDon";
            this.btnXuatHoaDon.Size = new System.Drawing.Size(165, 28);
            this.btnXuatHoaDon.TabIndex = 61;
            this.btnXuatHoaDon.Text = "Xuất Hóa Đơn";
            this.btnXuatHoaDon.UseVisualStyleBackColor = true;
            // 
            // reportViewerHoaDon
            // 
            this.reportViewerHoaDon.Location = new System.Drawing.Point(699, 85);
            this.reportViewerHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewerHoaDon.Name = "reportViewerHoaDon";
            this.reportViewerHoaDon.ServerReport.BearerToken = null;
            this.reportViewerHoaDon.Size = new System.Drawing.Size(613, 625);
            this.reportViewerHoaDon.TabIndex = 5;
            // 
            // MaCTHD
            // 
            this.MaCTHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaCTHD.HeaderText = "MaCTHD";
            this.MaCTHD.MinimumWidth = 3;
            this.MaCTHD.Name = "MaCTHD";
            this.MaCTHD.Width = 122;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.HeaderText = "MaHD";
            this.Column2.MinimumWidth = 3;
            this.Column2.Name = "Column2";
            this.Column2.Width = 97;
            // 
            // MaSP
            // 
            this.MaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaSP.HeaderText = "MaSP ";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 94;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DonGia.HeaderText = "DonGia";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 104;
            // 
            // SizeSP
            // 
            this.SizeSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SizeSP.HeaderText = "SizeSP";
            this.SizeSP.MinimumWidth = 6;
            this.SizeSP.Name = "SizeSP";
            this.SizeSP.Width = 96;
            // 
            // SoLuongSP
            // 
            this.SoLuongSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SoLuongSP.HeaderText = "SoLuongSP";
            this.SoLuongSP.MinimumWidth = 6;
            this.SoLuongSP.Name = "SoLuongSP";
            this.SoLuongSP.Width = 137;
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ThanhTien.HeaderText = "ThanhTien";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Width = 131;
            // 
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaHD.HeaderText = "MaHD";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 97;
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaKH.HeaderText = "MaKH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 96;
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaNV.HeaderText = "MaNV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 94;
            // 
            // NgayLapHD
            // 
            this.NgayLapHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NgayLapHD.HeaderText = "NgayLapHD";
            this.NgayLapHD.MinimumWidth = 6;
            this.NgayLapHD.Name = "NgayLapHD";
            this.NgayLapHD.Width = 143;
            // 
            // TrangThaiHD
            // 
            this.TrangThaiHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TrangThaiHD.HeaderText = "TrangThaiHD";
            this.TrangThaiHD.MinimumWidth = 6;
            this.TrangThaiHD.Name = "TrangThaiHD";
            this.TrangThaiHD.Width = 158;
            // 
            // FormQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 725);
            this.Controls.Add(this.reportViewerHoaDon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQuanLyHoaDon";
            this.Text = "QUẢN LÝ HÓA ĐƠN ";
            this.Load += new System.EventHandler(this.FormQuanLyHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachHoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DateTimePicker dateTimePickerTuNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDenNgay;
        private FontAwesome.Sharp.IconButton btnXoa;
        private System.Windows.Forms.DataGridView dtgvDanhSachHoaDon;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerHoaDon;
        private FontAwesome.Sharp.IconButton btnXuatHoaDon;
        private System.Windows.Forms.DataGridView dtgvChiTietHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}