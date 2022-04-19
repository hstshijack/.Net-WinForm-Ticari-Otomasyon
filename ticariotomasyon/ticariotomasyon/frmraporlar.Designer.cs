
namespace ticariotomasyon
{
    partial class frmraporlar
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ticariotomasyonDataSet = new ticariotomasyon.ticariotomasyonDataSet();
            this.tbl_firmalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_firmalarTableAdapter = new ticariotomasyon.ticariotomasyonDataSetTableAdapters.tbl_firmalarTableAdapter();
            this.ticariotomasyonDataSet1 = new ticariotomasyon.ticariotomasyonDataSet1();
            this.tbl_musterilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_musterilerTableAdapter = new ticariotomasyon.ticariotomasyonDataSet1TableAdapters.tbl_musterilerTableAdapter();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.reportViewer5 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ticariotomasyonDataSet2 = new ticariotomasyon.ticariotomasyonDataSet2();
            this.tbl_personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_personelTableAdapter = new ticariotomasyon.ticariotomasyonDataSet2TableAdapters.tbl_personelTableAdapter();
            this.ticariotomasyonDataSet3 = new ticariotomasyon.ticariotomasyonDataSet3();
            this.tbl_giderlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_giderlerTableAdapter = new ticariotomasyon.ticariotomasyonDataSet3TableAdapters.tbl_giderlerTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticariotomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_firmalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticariotomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_musterilerBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticariotomasyonDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticariotomasyonDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_giderlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1101, 1055);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1093, 1026);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteri Raporları";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_musterilerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ticariotomasyon.musteri.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1087, 1020);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1093, 1026);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Firma Raporları";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "dtfirmalar";
            reportDataSource2.Value = this.tbl_firmalarBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ticariotomasyon.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1087, 1020);
            this.reportViewer2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1093, 1026);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Kasa Raporları";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer3.Location = new System.Drawing.Point(3, 3);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1087, 1020);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.reportViewer4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1093, 1026);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Personel Raporları";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // reportViewer4
            // 
            this.reportViewer4.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.tbl_personelBindingSource;
            this.reportViewer4.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer4.LocalReport.ReportEmbeddedResource = "ticariotomasyon.personel.rdlc";
            this.reportViewer4.Location = new System.Drawing.Point(3, 3);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(1087, 1020);
            this.reportViewer4.TabIndex = 0;
            // 
            // ticariotomasyonDataSet
            // 
            this.ticariotomasyonDataSet.DataSetName = "ticariotomasyonDataSet";
            this.ticariotomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_firmalarBindingSource
            // 
            this.tbl_firmalarBindingSource.DataMember = "tbl_firmalar";
            this.tbl_firmalarBindingSource.DataSource = this.ticariotomasyonDataSet;
            // 
            // tbl_firmalarTableAdapter
            // 
            this.tbl_firmalarTableAdapter.ClearBeforeFill = true;
            // 
            // ticariotomasyonDataSet1
            // 
            this.ticariotomasyonDataSet1.DataSetName = "ticariotomasyonDataSet1";
            this.ticariotomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_musterilerBindingSource
            // 
            this.tbl_musterilerBindingSource.DataMember = "tbl_musteriler";
            this.tbl_musterilerBindingSource.DataSource = this.ticariotomasyonDataSet1;
            // 
            // tbl_musterilerTableAdapter
            // 
            this.tbl_musterilerTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.reportViewer5);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1093, 1026);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Gider Raporları";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // reportViewer5
            // 
            this.reportViewer5.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.tbl_giderlerBindingSource;
            this.reportViewer5.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer5.LocalReport.ReportEmbeddedResource = "ticariotomasyon.giderler.rdlc";
            this.reportViewer5.Location = new System.Drawing.Point(3, 3);
            this.reportViewer5.Name = "reportViewer5";
            this.reportViewer5.ServerReport.BearerToken = null;
            this.reportViewer5.Size = new System.Drawing.Size(1087, 1020);
            this.reportViewer5.TabIndex = 0;
            // 
            // ticariotomasyonDataSet2
            // 
            this.ticariotomasyonDataSet2.DataSetName = "ticariotomasyonDataSet2";
            this.ticariotomasyonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_personelBindingSource
            // 
            this.tbl_personelBindingSource.DataMember = "tbl_personel";
            this.tbl_personelBindingSource.DataSource = this.ticariotomasyonDataSet2;
            // 
            // tbl_personelTableAdapter
            // 
            this.tbl_personelTableAdapter.ClearBeforeFill = true;
            // 
            // ticariotomasyonDataSet3
            // 
            this.ticariotomasyonDataSet3.DataSetName = "ticariotomasyonDataSet3";
            this.ticariotomasyonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_giderlerBindingSource
            // 
            this.tbl_giderlerBindingSource.DataMember = "tbl_giderler";
            this.tbl_giderlerBindingSource.DataSource = this.ticariotomasyonDataSet3;
            // 
            // tbl_giderlerTableAdapter
            // 
            this.tbl_giderlerTableAdapter.ClearBeforeFill = true;
            // 
            // frmraporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 1055);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmraporlar";
            this.Text = "frmraporlar";
            this.Load += new System.EventHandler(this.frmraporlar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ticariotomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_firmalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticariotomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_musterilerBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ticariotomasyonDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticariotomasyonDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_giderlerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
        private System.Windows.Forms.BindingSource tbl_firmalarBindingSource;
        private ticariotomasyonDataSet ticariotomasyonDataSet;
        private ticariotomasyonDataSetTableAdapters.tbl_firmalarTableAdapter tbl_firmalarTableAdapter;
        private System.Windows.Forms.BindingSource tbl_musterilerBindingSource;
        private ticariotomasyonDataSet1 ticariotomasyonDataSet1;
        private ticariotomasyonDataSet1TableAdapters.tbl_musterilerTableAdapter tbl_musterilerTableAdapter;
        private System.Windows.Forms.TabPage tabPage5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer5;
        private System.Windows.Forms.BindingSource tbl_personelBindingSource;
        private ticariotomasyonDataSet2 ticariotomasyonDataSet2;
        private ticariotomasyonDataSet2TableAdapters.tbl_personelTableAdapter tbl_personelTableAdapter;
        private System.Windows.Forms.BindingSource tbl_giderlerBindingSource;
        private ticariotomasyonDataSet3 ticariotomasyonDataSet3;
        private ticariotomasyonDataSet3TableAdapters.tbl_giderlerTableAdapter tbl_giderlerTableAdapter;
    }
}