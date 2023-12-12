namespace DoAn_CSharp.Report
{
    partial class fDanhSachNhanVien
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSQuanLyBanGiayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSQuanLyBanGiay = new DoAn_CSharp.Databsase.DSQuanLyBanGiay();
            this.nhanvienTableAdapter = new DoAn_CSharp.Databsase.DSQuanLyBanGiayTableAdapters.nhanvienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSQuanLyBanGiayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSQuanLyBanGiay)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nhanvienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAn_CSharp.Report.rQuanLyNhanVien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(696, 633);
            this.reportViewer1.TabIndex = 0;
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataMember = "nhanvien";
            this.nhanvienBindingSource.DataSource = this.dSQuanLyBanGiayBindingSource;
            // 
            // dSQuanLyBanGiayBindingSource
            // 
            this.dSQuanLyBanGiayBindingSource.DataSource = this.dSQuanLyBanGiay;
            this.dSQuanLyBanGiayBindingSource.Position = 0;
            // 
            // dSQuanLyBanGiay
            // 
            this.dSQuanLyBanGiay.DataSetName = "DSQuanLyBanGiay";
            this.dSQuanLyBanGiay.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanvienTableAdapter
            // 
            this.nhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // fDanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 633);
            this.Controls.Add(this.reportViewer1);
            this.IsMdiContainer = true;
            this.Name = "fDanhSachNhanVien";
            this.Text = "fDanhSachNhanVien";
            this.Load += new System.EventHandler(this.fDanhSachNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSQuanLyBanGiayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSQuanLyBanGiay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Databsase.DSQuanLyBanGiay dSQuanLyBanGiay;
        private System.Windows.Forms.BindingSource dSQuanLyBanGiayBindingSource;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private Databsase.DSQuanLyBanGiayTableAdapters.nhanvienTableAdapter nhanvienTableAdapter;
    }
}