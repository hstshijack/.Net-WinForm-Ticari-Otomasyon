
namespace ticariotomasyon
{
    partial class frmayarlar
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sbtnurungrupekle = new DevExpress.XtraEditors.SimpleButton();
            this.lblid = new DevExpress.XtraEditors.LabelControl();
            this.sbtnguncelle = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnsil = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtsifre = new DevExpress.XtraEditors.TextEdit();
            this.txtkuladi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkuladi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gridControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.sbtnurungrupekle);
            this.splitContainer1.Panel2.Controls.Add(this.lblid);
            this.splitContainer1.Panel2.Controls.Add(this.sbtnguncelle);
            this.splitContainer1.Panel2.Controls.Add(this.sbtnsil);
            this.splitContainer1.Panel2.Controls.Add(this.sbtnkaydet);
            this.splitContainer1.Panel2.Controls.Add(this.txtsifre);
            this.splitContainer1.Panel2.Controls.Add(this.txtkuladi);
            this.splitContainer1.Panel2.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel2.Controls.Add(this.labelControl1);
            this.splitContainer1.Size = new System.Drawing.Size(753, 479);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(753, 181);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // sbtnurungrupekle
            // 
            this.sbtnurungrupekle.Location = new System.Drawing.Point(544, 140);
            this.sbtnurungrupekle.Name = "sbtnurungrupekle";
            this.sbtnurungrupekle.Size = new System.Drawing.Size(132, 35);
            this.sbtnurungrupekle.TabIndex = 13;
            this.sbtnurungrupekle.Text = "Ürün Grubu Ekle";
            this.sbtnurungrupekle.Click += new System.EventHandler(this.sbtnurungrupekle_Click);
            // 
            // lblid
            // 
            this.lblid.Location = new System.Drawing.Point(544, 55);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(75, 16);
            this.lblid.TabIndex = 12;
            this.lblid.Text = "labelControl3";
            this.lblid.Visible = false;
            // 
            // sbtnguncelle
            // 
            this.sbtnguncelle.Location = new System.Drawing.Point(127, 234);
            this.sbtnguncelle.Name = "sbtnguncelle";
            this.sbtnguncelle.Size = new System.Drawing.Size(170, 29);
            this.sbtnguncelle.TabIndex = 11;
            this.sbtnguncelle.Text = "Güncelle";
            this.sbtnguncelle.Click += new System.EventHandler(this.sbtnguncelle_Click);
            // 
            // sbtnsil
            // 
            this.sbtnsil.Location = new System.Drawing.Point(127, 188);
            this.sbtnsil.Name = "sbtnsil";
            this.sbtnsil.Size = new System.Drawing.Size(170, 29);
            this.sbtnsil.TabIndex = 10;
            this.sbtnsil.Text = "Sil";
            // 
            // sbtnkaydet
            // 
            this.sbtnkaydet.Location = new System.Drawing.Point(127, 143);
            this.sbtnkaydet.Name = "sbtnkaydet";
            this.sbtnkaydet.Size = new System.Drawing.Size(170, 29);
            this.sbtnkaydet.TabIndex = 9;
            this.sbtnkaydet.Text = "Kaydet";
            this.sbtnkaydet.Click += new System.EventHandler(this.sbtnkaydet_Click);
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(127, 98);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(170, 22);
            this.txtsifre.TabIndex = 8;
            // 
            // txtkuladi
            // 
            this.txtkuladi.Location = new System.Drawing.Point(127, 49);
            this.txtkuladi.Name = "txtkuladi";
            this.txtkuladi.Size = new System.Drawing.Size(170, 22);
            this.txtkuladi.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(85, 101);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Şifre :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(44, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 16);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Kullanıcı Adı :";
            // 
            // frmayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(753, 479);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmayarlar";
            this.Load += new System.EventHandler(this.frmayarlar_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkuladi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton sbtnkaydet;
        private DevExpress.XtraEditors.TextEdit txtsifre;
        private DevExpress.XtraEditors.TextEdit txtkuladi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbtnguncelle;
        private DevExpress.XtraEditors.SimpleButton sbtnsil;
        private DevExpress.XtraEditors.LabelControl lblid;
        private DevExpress.XtraEditors.SimpleButton sbtnurungrupekle;
    }
}