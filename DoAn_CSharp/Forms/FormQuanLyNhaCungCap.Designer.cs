﻿namespace DoAn_CSharp.Forms
{
    partial class FormQuanLyNhaCungCap
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
            this.txtTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.txtSDTNhaCungCap = new System.Windows.Forms.TextBox();
            this.txtDiaChiNhaCungCap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listNCC = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvSanPhamCuaNhaCungCap = new System.Windows.Forms.DataGridView();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnCapNhat = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnXuatExcel = new FontAwesome.Sharp.IconButton();
            this.TT_NCC = new System.Windows.Forms.CheckBox();
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.detail_name = new System.Windows.Forms.TextBox();
            this.detail_email = new System.Windows.Forms.TextBox();
            this.detail_address = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.detail_phone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.detail_status = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.listNCC)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPhamCuaNhaCungCap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenNhaCungCap
            // 
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(191, 74);
            this.txtTenNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(567, 22);
            this.txtTenNhaCungCap.TabIndex = 51;
            this.txtTenNhaCungCap.TextChanged += new System.EventHandler(this.txtTenNhaCungCap_TextChanged);
            // 
            // txtSDTNhaCungCap
            // 
            this.txtSDTNhaCungCap.Location = new System.Drawing.Point(191, 149);
            this.txtSDTNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSDTNhaCungCap.Name = "txtSDTNhaCungCap";
            this.txtSDTNhaCungCap.Size = new System.Drawing.Size(567, 22);
            this.txtSDTNhaCungCap.TabIndex = 50;
            this.txtSDTNhaCungCap.TextChanged += new System.EventHandler(this.txtSDTNhaCungCap_TextChanged);
            // 
            // txtDiaChiNhaCungCap
            // 
            this.txtDiaChiNhaCungCap.Location = new System.Drawing.Point(191, 112);
            this.txtDiaChiNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiaChiNhaCungCap.Name = "txtDiaChiNhaCungCap";
            this.txtDiaChiNhaCungCap.Size = new System.Drawing.Size(567, 22);
            this.txtDiaChiNhaCungCap.TabIndex = 49;
            this.txtDiaChiNhaCungCap.TextChanged += new System.EventHandler(this.txtDiaChiNhaCungCap_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Số điện thoại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Địa Chỉ :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tên:";
            // 
            // listNCC
            // 
            this.listNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listNCC.Location = new System.Drawing.Point(40, 279);
            this.listNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listNCC.Name = "listNCC";
            this.listNCC.Size = new System.Drawing.Size(717, 294);
            this.listNCC.TabIndex = 60;
            this.listNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvQuanLyNhaCungCap_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvSanPhamCuaNhaCungCap);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 636);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1288, 210);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản Phẩm Của Nhà Cung Cấp :";
            // 
            // dtgvSanPhamCuaNhaCungCap
            // 
            this.dtgvSanPhamCuaNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSanPhamCuaNhaCungCap.Location = new System.Drawing.Point(8, 31);
            this.dtgvSanPhamCuaNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgvSanPhamCuaNhaCungCap.Name = "dtgvSanPhamCuaNhaCungCap";
            this.dtgvSanPhamCuaNhaCungCap.Size = new System.Drawing.Size(997, 172);
            this.dtgvSanPhamCuaNhaCungCap.TabIndex = 62;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClear.IconColor = System.Drawing.Color.Black;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.Location = new System.Drawing.Point(158, 230);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 66;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightCoral;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXoa.IconColor = System.Drawing.Color.Black;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.Location = new System.Drawing.Point(28, 479);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 42);
            this.btnXoa.TabIndex = 65;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCapNhat.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCapNhat.IconColor = System.Drawing.Color.Black;
            this.btnCapNhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCapNhat.Location = new System.Drawing.Point(202, 479);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(232, 42);
            this.btnCapNhat.TabIndex = 64;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThem.IconColor = System.Drawing.Color.Black;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.Location = new System.Drawing.Point(40, 230);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 63;
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
            this.btnXuatExcel.Location = new System.Drawing.Point(280, 230);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(117, 28);
            this.btnXuatExcel.TabIndex = 67;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // TT_NCC
            // 
            this.TT_NCC.AutoSize = true;
            this.TT_NCC.Location = new System.Drawing.Point(191, 187);
            this.TT_NCC.Name = "TT_NCC";
            this.TT_NCC.Size = new System.Drawing.Size(86, 20);
            this.TT_NCC.TabIndex = 68;
            this.TT_NCC.Text = "Trạng thái";
            this.TT_NCC.UseVisualStyleBackColor = true;
            this.TT_NCC.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.title.Location = new System.Drawing.Point(41, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(266, 26);
            this.title.TabIndex = 69;
            this.title.Text = "THÊM NHÀ CUNG CẤP";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 26);
            this.label1.TabIndex = 70;
            this.label1.Text = "THÔNG TIN CHI TIẾT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // detail_name
            // 
            this.detail_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detail_name.Location = new System.Drawing.Point(29, 87);
            this.detail_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detail_name.Multiline = true;
            this.detail_name.Name = "detail_name";
            this.detail_name.Size = new System.Drawing.Size(401, 40);
            this.detail_name.TabIndex = 76;
            this.detail_name.TextChanged += new System.EventHandler(this.detail_name_TextChanged);
            // 
            // detail_email
            // 
            this.detail_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detail_email.Location = new System.Drawing.Point(29, 243);
            this.detail_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detail_email.Multiline = true;
            this.detail_email.Name = "detail_email";
            this.detail_email.Size = new System.Drawing.Size(401, 40);
            this.detail_email.TabIndex = 75;
            this.detail_email.TextChanged += new System.EventHandler(this.detail_email_TextChanged);
            // 
            // detail_address
            // 
            this.detail_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detail_address.Location = new System.Drawing.Point(28, 165);
            this.detail_address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detail_address.Multiline = true;
            this.detail_address.Name = "detail_address";
            this.detail_address.Size = new System.Drawing.Size(401, 40);
            this.detail_address.TabIndex = 74;
            this.detail_address.TextChanged += new System.EventHandler(this.detail_address_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 72;
            this.label6.Text = "Địa Chỉ :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 71;
            this.label7.Text = "Tên:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.detail_status);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.detail_phone);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.detail_name);
            this.panel1.Controls.Add(this.detail_email);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.detail_address);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Location = new System.Drawing.Point(784, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 552);
            this.panel1.TabIndex = 77;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // detail_phone
            // 
            this.detail_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detail_phone.Location = new System.Drawing.Point(29, 324);
            this.detail_phone.Margin = new System.Windows.Forms.Padding(4);
            this.detail_phone.Multiline = true;
            this.detail_phone.Name = "detail_phone";
            this.detail_phone.Size = new System.Drawing.Size(401, 40);
            this.detail_phone.TabIndex = 78;
            this.detail_phone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 299);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 77;
            this.label8.Text = "Số điện thoại :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 380);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 79;
            this.label9.Text = "Trạng thái";
            // 
            // detail_status
            // 
            this.detail_status.AutoSize = true;
            this.detail_status.Location = new System.Drawing.Point(121, 380);
            this.detail_status.Name = "detail_status";
            this.detail_status.Size = new System.Drawing.Size(45, 20);
            this.detail_status.TabIndex = 80;
            this.detail_status.Text = "Mở";
            this.detail_status.UseVisualStyleBackColor = true;
            this.detail_status.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // FormQuanLyNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 732);
            this.Controls.Add(this.title);
            this.Controls.Add(this.TT_NCC);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listNCC);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenNhaCungCap);
            this.Controls.Add(this.txtSDTNhaCungCap);
            this.Controls.Add(this.txtDiaChiNhaCungCap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormQuanLyNhaCungCap";
            this.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            this.Load += new System.EventHandler(this.FormQuanLyNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listNCC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSanPhamCuaNhaCungCap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenNhaCungCap;
        private System.Windows.Forms.TextBox txtSDTNhaCungCap;
        private System.Windows.Forms.TextBox txtDiaChiNhaCungCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView listNCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvSanPhamCuaNhaCungCap;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnCapNhat;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnXuatExcel;
        private System.Windows.Forms.CheckBox TT_NCC;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox detail_name;
        private System.Windows.Forms.TextBox detail_email;
        private System.Windows.Forms.TextBox detail_address;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox detail_phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox detail_status;
        private System.Windows.Forms.Label label9;
    }
}