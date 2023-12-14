namespace DoAn_CSharp.Forms
{
    partial class ThemNhaCungCap_Form
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.TT_NCC = new System.Windows.Forms.CheckBox();
            this.txtTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.txtSDTNhaCungCap = new System.Windows.Forms.TextBox();
            this.txtDiaChiNhaCungCap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(230, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(426, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(119, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 88;
            this.label10.Text = "Email :";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.White;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.title.Location = new System.Drawing.Point(272, 32);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(266, 26);
            this.title.TabIndex = 87;
            this.title.Text = "THÊM NHÀ CUNG CẤP";
            // 
            // TT_NCC
            // 
            this.TT_NCC.AutoSize = true;
            this.TT_NCC.Location = new System.Drawing.Point(229, 202);
            this.TT_NCC.Margin = new System.Windows.Forms.Padding(2);
            this.TT_NCC.Name = "TT_NCC";
            this.TT_NCC.Size = new System.Drawing.Size(74, 17);
            this.TT_NCC.TabIndex = 4;
            this.TT_NCC.Text = "Trạng thái";
            this.TT_NCC.UseVisualStyleBackColor = true;
            // 
            // txtTenNhaCungCap
            // 
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(229, 85);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(426, 20);
            this.txtTenNhaCungCap.TabIndex = 0;
            // 
            // txtSDTNhaCungCap
            // 
            this.txtSDTNhaCungCap.Location = new System.Drawing.Point(229, 146);
            this.txtSDTNhaCungCap.Name = "txtSDTNhaCungCap";
            this.txtSDTNhaCungCap.Size = new System.Drawing.Size(426, 20);
            this.txtSDTNhaCungCap.TabIndex = 2;
            // 
            // txtDiaChiNhaCungCap
            // 
            this.txtDiaChiNhaCungCap.Location = new System.Drawing.Point(229, 116);
            this.txtDiaChiNhaCungCap.Name = "txtDiaChiNhaCungCap";
            this.txtDiaChiNhaCungCap.Size = new System.Drawing.Size(426, 20);
            this.txtDiaChiNhaCungCap.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 82;
            this.label4.Text = "Số điện thoại :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 81;
            this.label3.Text = "Địa Chỉ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 80;
            this.label2.Text = "Tên:";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnThem.IconColor = System.Drawing.Color.Black;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.Location = new System.Drawing.Point(320, 228);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(183, 32);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // ThemNhaCungCap_Form
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 272);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.title);
            this.Controls.Add(this.TT_NCC);
            this.Controls.Add(this.txtTenNhaCungCap);
            this.Controls.Add(this.txtSDTNhaCungCap);
            this.Controls.Add(this.txtDiaChiNhaCungCap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ThemNhaCungCap_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemNhaCungCap_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.CheckBox TT_NCC;
        private System.Windows.Forms.TextBox txtTenNhaCungCap;
        private System.Windows.Forms.TextBox txtSDTNhaCungCap;
        private System.Windows.Forms.TextBox txtDiaChiNhaCungCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnThem;
    }
}