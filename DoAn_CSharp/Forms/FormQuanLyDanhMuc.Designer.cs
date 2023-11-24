namespace DoAn_CSharp.Forms
{
    partial class FormQuanLyDanhMuc
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
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.txtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDanhSachDanhMuc = new System.Windows.Forms.DataGridView();
            this.MaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvSanPhamTrongDanhMuc = new System.Windows.Forms.DataGridView();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnCapNhat = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnXuatExcel = new FontAwesome.Sharp.IconButton();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MieuTaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnhSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachDanhMuc)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPhamTrongDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Location = new System.Drawing.Point(496, 78);
            this.txtTenDanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(424, 22);
            this.txtTenDanhMuc.TabIndex = 24;
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.Location = new System.Drawing.Point(496, 26);
            this.txtMaDanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.Size = new System.Drawing.Size(424, 22);
            this.txtMaDanhMuc.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tên Danh Mục :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã Danh Mục :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(177, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 49;
            this.label7.Text = "Tìm Kiếm :";
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Mã Danh Mục",
            "Tên Danh Mục"});
            this.cbTimKiem.Location = new System.Drawing.Point(772, 206);
            this.cbTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(199, 24);
            this.cbTimKiem.TabIndex = 47;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(337, 206);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(403, 22);
            this.txtTimKiem.TabIndex = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvDanhSachDanhMuc);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 251);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1309, 229);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Danh Mục :";
            // 
            // dtgvDanhSachDanhMuc
            // 
            this.dtgvDanhSachDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDanhMuc,
            this.TenDM,
            this.TrangThaiDM});
            this.dtgvDanhSachDanhMuc.Location = new System.Drawing.Point(7, 26);
            this.dtgvDanhSachDanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvDanhSachDanhMuc.Name = "dtgvDanhSachDanhMuc";
            this.dtgvDanhSachDanhMuc.RowHeadersWidth = 51;
            this.dtgvDanhSachDanhMuc.Size = new System.Drawing.Size(1288, 196);
            this.dtgvDanhSachDanhMuc.TabIndex = 43;
            this.dtgvDanhSachDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachDanhMuc_CellClick);
            // 
            // MaDanhMuc
            // 
            this.MaDanhMuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaDanhMuc.HeaderText = "MaDanhMuc";
            this.MaDanhMuc.MinimumWidth = 6;
            this.MaDanhMuc.Name = "MaDanhMuc";
            // 
            // TenDM
            // 
            this.TenDM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDM.HeaderText = "TenDM";
            this.TenDM.MinimumWidth = 6;
            this.TenDM.Name = "TenDM";
            // 
            // TrangThaiDM
            // 
            this.TrangThaiDM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrangThaiDM.HeaderText = "TrangThaiDM";
            this.TrangThaiDM.MinimumWidth = 6;
            this.TrangThaiDM.Name = "TrangThaiDM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvSanPhamTrongDanhMuc);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1, 501);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1309, 222);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản Phẩm Trong Danh Mục :";
            // 
            // dtgvSanPhamTrongDanhMuc
            // 
            this.dtgvSanPhamTrongDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanPhamTrongDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.MaNCC,
            this.MaDM,
            this.TenSP,
            this.SizeSP,
            this.SoLuongSP,
            this.MieuTaSP,
            this.DonGia,
            this.TrangThaiSP,
            this.AnhSP});
            this.dtgvSanPhamTrongDanhMuc.Location = new System.Drawing.Point(8, 26);
            this.dtgvSanPhamTrongDanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvSanPhamTrongDanhMuc.Name = "dtgvSanPhamTrongDanhMuc";
            this.dtgvSanPhamTrongDanhMuc.RowHeadersWidth = 51;
            this.dtgvSanPhamTrongDanhMuc.Size = new System.Drawing.Size(1288, 188);
            this.dtgvSanPhamTrongDanhMuc.TabIndex = 44;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClear.IconColor = System.Drawing.Color.Black;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.Location = new System.Drawing.Point(893, 138);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoa.IconColor = System.Drawing.Color.Black;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.Location = new System.Drawing.Point(739, 138);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCapNhat.IconColor = System.Drawing.Color.Black;
            this.btnCapNhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCapNhat.Location = new System.Drawing.Point(607, 138);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 28);
            this.btnCapNhat.TabIndex = 51;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThem.IconColor = System.Drawing.Color.Black;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.Location = new System.Drawing.Point(476, 138);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXuatExcel.IconColor = System.Drawing.Color.Black;
            this.btnXuatExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXuatExcel.Location = new System.Drawing.Point(1125, 208);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(117, 28);
            this.btnXuatExcel.TabIndex = 54;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // MaSP
            // 
            this.MaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSP.HeaderText = "MaSP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            // 
            // MaNCC
            // 
            this.MaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNCC.HeaderText = "MaNCC";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MaDM
            // 
            this.MaDM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaDM.HeaderText = "MaDM";
            this.MaDM.MinimumWidth = 6;
            this.MaDM.Name = "MaDM";
            // 
            // TenSP
            // 
            this.TenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TenSP.HeaderText = "TenSP";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 92;
            // 
            // SizeSP
            // 
            this.SizeSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SizeSP.HeaderText = "SizeSP";
            this.SizeSP.MinimumWidth = 6;
            this.SizeSP.Name = "SizeSP";
            // 
            // SoLuongSP
            // 
            this.SoLuongSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuongSP.HeaderText = "SoLuongSP";
            this.SoLuongSP.MinimumWidth = 6;
            this.SoLuongSP.Name = "SoLuongSP";
            // 
            // MieuTaSP
            // 
            this.MieuTaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MieuTaSP.HeaderText = "MieuTaSP";
            this.MieuTaSP.MinimumWidth = 6;
            this.MieuTaSP.Name = "MieuTaSP";
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.HeaderText = "DonGia";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // TrangThaiSP
            // 
            this.TrangThaiSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrangThaiSP.HeaderText = "TrangThaiSP";
            this.TrangThaiSP.MinimumWidth = 6;
            this.TrangThaiSP.Name = "TrangThaiSP";
            // 
            // AnhSP
            // 
            this.AnhSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AnhSP.HeaderText = "AnhSP";
            this.AnhSP.MinimumWidth = 6;
            this.AnhSP.Name = "AnhSP";
            // 
            // FormQuanLyDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 725);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtTenDanhMuc);
            this.Controls.Add(this.txtMaDanhMuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormQuanLyDanhMuc";
            this.Text = "QUẢN LÝ DANH MỤC ";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachDanhMuc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPhamTrongDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.TextBox txtMaDanhMuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvDanhSachDanhMuc;
        private System.Windows.Forms.DataGridView dtgvSanPhamTrongDanhMuc;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnCapNhat;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnXuatExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MieuTaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnhSP;
    }
}