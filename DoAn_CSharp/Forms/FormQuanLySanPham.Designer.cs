namespace DoAn_CSharp.Forms
{
    partial class FormQuanLySanPham
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
            this.sp_ncc = new System.Windows.Forms.ComboBox();
            this.sp_price = new System.Windows.Forms.TextBox();
            this.sp_description = new System.Windows.Forms.TextBox();
            this.sp_size = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sp_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sp_dm = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listSP = new System.Windows.Forms.DataGridView();
            this.btnXuatExcel = new FontAwesome.Sharp.IconButton();
            this.btnClear = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.browseButton = new FontAwesome.Sharp.IconButton();
            this.sp_quantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sp_status = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.delete = new FontAwesome.Sharp.IconButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnThemNhaCungCapNhanh = new FontAwesome.Sharp.IconButton();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.detail_image = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.detail_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.detail_status = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.detail_quantity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label18 = new System.Windows.Forms.Label();
            this.detail_size = new System.Windows.Forms.TextBox();
            this.detail_description = new System.Windows.Forms.TextBox();
            this.detail_price = new System.Windows.Forms.TextBox();
            this.detail_ncc = new System.Windows.Forms.ComboBox();
            this.detail_dm = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listSP)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detail_image)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_ncc
            // 
            this.sp_ncc.FormattingEnabled = true;
            this.sp_ncc.Location = new System.Drawing.Point(184, 110);
            this.sp_ncc.Name = "sp_ncc";
            this.sp_ncc.Size = new System.Drawing.Size(315, 21);
            this.sp_ncc.TabIndex = 37;
            this.sp_ncc.SelectedIndexChanged += new System.EventHandler(this.cbMaChucVu_SelectedIndexChanged);
            // 
            // sp_price
            // 
            this.sp_price.Location = new System.Drawing.Point(184, 290);
            this.sp_price.Name = "sp_price";
            this.sp_price.Size = new System.Drawing.Size(315, 20);
            this.sp_price.TabIndex = 35;
            this.sp_price.TextChanged += new System.EventHandler(this.sp_price_TextChanged);
            // 
            // sp_description
            // 
            this.sp_description.Location = new System.Drawing.Point(184, 217);
            this.sp_description.Multiline = true;
            this.sp_description.Name = "sp_description";
            this.sp_description.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sp_description.Size = new System.Drawing.Size(315, 55);
            this.sp_description.TabIndex = 34;
            this.sp_description.TextChanged += new System.EventHandler(this.sp_description_TextChanged);
            // 
            // sp_size
            // 
            this.sp_size.Location = new System.Drawing.Point(184, 179);
            this.sp_size.Name = "sp_size";
            this.sp_size.Size = new System.Drawing.Size(315, 20);
            this.sp_size.TabIndex = 33;
            this.sp_size.TextChanged += new System.EventHandler(this.sp_size_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Đơn Giá :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Miêu Tả Sản Phẩm :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tên Sản Phẩm :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Size Sản Phẩm :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Danh Mục :";
            // 
            // sp_name
            // 
            this.sp_name.Location = new System.Drawing.Point(184, 78);
            this.sp_name.Name = "sp_name";
            this.sp_name.Size = new System.Drawing.Size(315, 20);
            this.sp_name.TabIndex = 24;
            this.sp_name.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nhà Cung Cấp :";
            // 
            // sp_dm
            // 
            this.sp_dm.FormattingEnabled = true;
            this.sp_dm.Location = new System.Drawing.Point(184, 142);
            this.sp_dm.Name = "sp_dm";
            this.sp_dm.Size = new System.Drawing.Size(315, 21);
            this.sp_dm.TabIndex = 39;
            this.sp_dm.SelectedIndexChanged += new System.EventHandler(this.sp_dm_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listSP);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(641, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 621);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Sản Phẩm :";
            // 
            // listSP
            // 
            this.listSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listSP.Location = new System.Drawing.Point(27, 38);
            this.listSP.Name = "listSP";
            this.listSP.Size = new System.Drawing.Size(433, 575);
            this.listSP.TabIndex = 58;
            this.listSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvQuanLyNhanVien_CellContentClick);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExcel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnXuatExcel.IconColor = System.Drawing.Color.Black;
            this.btnXuatExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXuatExcel.Location = new System.Drawing.Point(240, 520);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(259, 23);
            this.btnXuatExcel.TabIndex = 63;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnClear.IconColor = System.Drawing.Color.Black;
            this.btnClear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClear.Location = new System.Drawing.Point(3, 520);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(209, 23);
            this.btnClear.TabIndex = 62;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DarkCyan;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThem.IconColor = System.Drawing.Color.Black;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.Location = new System.Drawing.Point(70, 549);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(324, 32);
            this.btnThem.TabIndex = 59;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // browseButton
            // 
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.browseButton.IconColor = System.Drawing.Color.Black;
            this.browseButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.browseButton.Location = new System.Drawing.Point(56, 432);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 64;
            this.browseButton.Text = "Chọn Ảnh ";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // sp_quantity
            // 
            this.sp_quantity.Location = new System.Drawing.Point(184, 331);
            this.sp_quantity.Name = "sp_quantity";
            this.sp_quantity.Size = new System.Drawing.Size(315, 20);
            this.sp_quantity.TabIndex = 66;
            this.sp_quantity.TextChanged += new System.EventHandler(this.sp_quantity_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "Số lượng :";
            // 
            // sp_status
            // 
            this.sp_status.AutoSize = true;
            this.sp_status.Location = new System.Drawing.Point(184, 369);
            this.sp_status.Margin = new System.Windows.Forms.Padding(2);
            this.sp_status.Name = "sp_status";
            this.sp_status.Size = new System.Drawing.Size(41, 17);
            this.sp_status.TabIndex = 69;
            this.sp_status.Text = "Mở";
            this.sp_status.UseVisualStyleBackColor = true;
            this.sp_status.CheckedChanged += new System.EventHandler(this.sp_status_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 70;
            this.label8.Text = "Trạng thái:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(179, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(178, 29);
            this.label17.TabIndex = 88;
            this.label17.Text = "Tạo sản phẩm";
            // 
            // delete
            // 
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.Brown;
            this.delete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.delete.IconColor = System.Drawing.Color.Black;
            this.delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.delete.Location = new System.Drawing.Point(57, 522);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(146, 35);
            this.delete.TabIndex = 89;
            this.delete.Text = "Xóa";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(42, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(593, 621);
            this.tabControl1.TabIndex = 91;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.iconButton3);
            this.tabPage1.Controls.Add(this.btnThemNhaCungCapNhanh);
            this.tabPage1.Controls.Add(this.imagePictureBox);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.sp_name);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.sp_status);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.sp_quantity);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.browseButton);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnXuatExcel);
            this.tabPage1.Controls.Add(this.sp_size);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.sp_description);
            this.tabPage1.Controls.Add(this.btnThem);
            this.tabPage1.Controls.Add(this.sp_price);
            this.tabPage1.Controls.Add(this.sp_ncc);
            this.tabPage1.Controls.Add(this.sp_dm);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(585, 595);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tạo mới";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(505, 140);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(80, 23);
            this.iconButton3.TabIndex = 91;
            this.iconButton3.Text = "Thêm DM";
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnThemNhaCungCapNhanh
            // 
            this.btnThemNhaCungCapNhanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNhaCungCapNhanh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhaCungCapNhanh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThemNhaCungCapNhanh.IconColor = System.Drawing.Color.Black;
            this.btnThemNhaCungCapNhanh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemNhaCungCapNhanh.Location = new System.Drawing.Point(501, 108);
            this.btnThemNhaCungCapNhanh.Name = "btnThemNhaCungCapNhanh";
            this.btnThemNhaCungCapNhanh.Size = new System.Drawing.Size(84, 23);
            this.btnThemNhaCungCapNhanh.TabIndex = 90;
            this.btnThemNhaCungCapNhanh.Text = "Thêm NCC";
            this.btnThemNhaCungCapNhanh.UseVisualStyleBackColor = true;
            this.btnThemNhaCungCapNhanh.Click += new System.EventHandler(this.btnThemNhaCungCapNhanh_Click);
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Location = new System.Drawing.Point(184, 403);
            this.imagePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(314, 86);
            this.imagePictureBox.TabIndex = 89;
            this.imagePictureBox.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.detail_image);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.delete);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.detail_name);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.detail_status);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.detail_quantity);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.iconButton2);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.detail_size);
            this.tabPage2.Controls.Add(this.detail_description);
            this.tabPage2.Controls.Add(this.detail_price);
            this.tabPage2.Controls.Add(this.detail_ncc);
            this.tabPage2.Controls.Add(this.detail_dm);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(585, 595);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chỉnh sửa sản phẩm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // detail_image
            // 
            this.detail_image.Location = new System.Drawing.Point(215, 411);
            this.detail_image.Margin = new System.Windows.Forms.Padding(2);
            this.detail_image.Name = "detail_image";
            this.detail_image.Size = new System.Drawing.Size(314, 93);
            this.detail_image.TabIndex = 108;
            this.detail_image.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 521);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 36);
            this.button1.TabIndex = 107;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(136, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 29);
            this.label9.TabIndex = 106;
            this.label9.Text = "Chỉnh sửa sản phẩm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 89;
            this.label10.Text = "Nhà Cung Cấp :";
            // 
            // detail_name
            // 
            this.detail_name.Location = new System.Drawing.Point(215, 72);
            this.detail_name.Name = "detail_name";
            this.detail_name.Size = new System.Drawing.Size(315, 20);
            this.detail_name.TabIndex = 90;
            this.detail_name.TextChanged += new System.EventHandler(this.detail_name_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 363);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 17);
            this.label11.TabIndex = 105;
            this.label11.Text = "Trạng thái:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(54, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 17);
            this.label12.TabIndex = 91;
            this.label12.Text = "Danh Mục :";
            // 
            // detail_status
            // 
            this.detail_status.AutoSize = true;
            this.detail_status.Location = new System.Drawing.Point(215, 363);
            this.detail_status.Margin = new System.Windows.Forms.Padding(2);
            this.detail_status.Name = "detail_status";
            this.detail_status.Size = new System.Drawing.Size(41, 17);
            this.detail_status.TabIndex = 104;
            this.detail_status.Text = "Mở";
            this.detail_status.UseVisualStyleBackColor = true;
            this.detail_status.CheckedChanged += new System.EventHandler(this.detail_status_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(54, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 17);
            this.label13.TabIndex = 92;
            this.label13.Text = "Size Sản Phẩm :";
            // 
            // detail_quantity
            // 
            this.detail_quantity.Location = new System.Drawing.Point(215, 325);
            this.detail_quantity.Name = "detail_quantity";
            this.detail_quantity.Size = new System.Drawing.Size(315, 20);
            this.detail_quantity.TabIndex = 103;
            this.detail_quantity.TextChanged += new System.EventHandler(this.detail_quantity_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(52, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 17);
            this.label14.TabIndex = 93;
            this.label14.Text = "Tên Sản Phẩm :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(54, 325);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 17);
            this.label15.TabIndex = 102;
            this.label15.Text = "Số lượng :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(54, 213);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 17);
            this.label16.TabIndex = 94;
            this.label16.Text = "Miêu Tả Sản Phẩm :";
            // 
            // iconButton2
            // 
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(53, 411);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(75, 23);
            this.iconButton2.TabIndex = 101;
            this.iconButton2.Text = "Chọn Ảnh ";
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(54, 284);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 17);
            this.label18.TabIndex = 95;
            this.label18.Text = "Đơn Giá :";
            // 
            // detail_size
            // 
            this.detail_size.Location = new System.Drawing.Point(215, 173);
            this.detail_size.Name = "detail_size";
            this.detail_size.Size = new System.Drawing.Size(315, 20);
            this.detail_size.TabIndex = 96;
            this.detail_size.TextChanged += new System.EventHandler(this.detail_size_TextChanged);
            // 
            // detail_description
            // 
            this.detail_description.Location = new System.Drawing.Point(215, 211);
            this.detail_description.Multiline = true;
            this.detail_description.Name = "detail_description";
            this.detail_description.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.detail_description.Size = new System.Drawing.Size(315, 55);
            this.detail_description.TabIndex = 97;
            this.detail_description.TextChanged += new System.EventHandler(this.detail_description_TextChanged);
            // 
            // detail_price
            // 
            this.detail_price.Location = new System.Drawing.Point(215, 284);
            this.detail_price.Name = "detail_price";
            this.detail_price.Size = new System.Drawing.Size(315, 20);
            this.detail_price.TabIndex = 98;
            this.detail_price.TextChanged += new System.EventHandler(this.detail_price_TextChanged);
            // 
            // detail_ncc
            // 
            this.detail_ncc.FormattingEnabled = true;
            this.detail_ncc.Location = new System.Drawing.Point(215, 104);
            this.detail_ncc.Name = "detail_ncc";
            this.detail_ncc.Size = new System.Drawing.Size(315, 21);
            this.detail_ncc.TabIndex = 99;
            this.detail_ncc.SelectedIndexChanged += new System.EventHandler(this.detail_ncc_SelectedIndexChanged);
            // 
            // detail_dm
            // 
            this.detail_dm.FormattingEnabled = true;
            this.detail_dm.Location = new System.Drawing.Point(215, 136);
            this.detail_dm.Name = "detail_dm";
            this.detail_dm.Size = new System.Drawing.Size(315, 21);
            this.detail_dm.TabIndex = 100;
            this.detail_dm.SelectedIndexChanged += new System.EventHandler(this.detail_dm_SelectedIndexChanged);
            // 
            // FormQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 643);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQuanLySanPham";
            this.Text = "QUẢN LÝ SẢN PHẨM ";
            this.Load += new System.EventHandler(this.FormQuanLySanPham_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listSP)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detail_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox sp_ncc;
        private System.Windows.Forms.TextBox sp_price;
        private System.Windows.Forms.TextBox sp_description;
        private System.Windows.Forms.TextBox sp_size;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sp_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sp_dm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listSP;
        private FontAwesome.Sharp.IconButton btnXuatExcel;
        private FontAwesome.Sharp.IconButton btnClear;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton browseButton;
        private System.Windows.Forms.TextBox sp_quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox sp_status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label17;
        private FontAwesome.Sharp.IconButton delete;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox detail_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox detail_status;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox detail_quantity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox detail_size;
        private System.Windows.Forms.TextBox detail_description;
        private System.Windows.Forms.TextBox detail_price;
        private System.Windows.Forms.ComboBox detail_ncc;
        private System.Windows.Forms.ComboBox detail_dm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.PictureBox detail_image;
        private FontAwesome.Sharp.IconButton btnThemNhaCungCapNhanh;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}