namespace DoAn_CSharp.Forms
{
    partial class SanPhamsSize_Form
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
            this.btnOK = new System.Windows.Forms.Button();
            this.numericUpDownSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbSizes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TenSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(82, 73);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(69, 22);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // numericUpDownSoLuong
            // 
            this.numericUpDownSoLuong.Location = new System.Drawing.Point(9, 32);
            this.numericUpDownSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownSoLuong.Name = "numericUpDownSoLuong";
            this.numericUpDownSoLuong.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownSoLuong.TabIndex = 1;
            // 
            // cbSizes
            // 
            this.cbSizes.FormattingEnabled = true;
            this.cbSizes.Location = new System.Drawing.Point(170, 31);
            this.cbSizes.Margin = new System.Windows.Forms.Padding(2);
            this.cbSizes.Name = "cbSizes";
            this.cbSizes.Size = new System.Drawing.Size(92, 21);
            this.cbSizes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số Lượng";
            // 
            // TenSize
            // 
            this.TenSize.AutoSize = true;
            this.TenSize.Location = new System.Drawing.Point(175, 13);
            this.TenSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TenSize.Name = "TenSize";
            this.TenSize.Size = new System.Drawing.Size(49, 13);
            this.TenSize.TabIndex = 4;
            this.TenSize.Text = "Tên Size";
            // 
            // SanPhamsSize_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 105);
            this.Controls.Add(this.TenSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSizes);
            this.Controls.Add(this.numericUpDownSoLuong);
            this.Controls.Add(this.btnOK);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SanPhamsSize_Form";
            this.Text = "SanPhamsSize_Form";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown numericUpDownSoLuong;
        private System.Windows.Forms.ComboBox cbSizes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TenSize;
    }
}