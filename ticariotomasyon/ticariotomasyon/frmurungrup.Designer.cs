
namespace ticariotomasyon
{
    partial class frmurungrup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmurungrup));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txturungrup = new DevExpress.XtraEditors.TextEdit();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.btnsil = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.lblindex = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txturungrup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(30, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(115, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ürün Grup Adı :";
            // 
            // txturungrup
            // 
            this.txturungrup.Location = new System.Drawing.Point(161, 55);
            this.txturungrup.Name = "txturungrup";
            this.txturungrup.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturungrup.Properties.Appearance.Options.UseFont = true;
            this.txturungrup.Size = new System.Drawing.Size(290, 28);
            this.txturungrup.TabIndex = 1;
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(161, 113);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(290, 149);
            this.listBoxControl1.TabIndex = 2;
           
            // 
            // btnsil
            // 
            this.btnsil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsil.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Appearance.Options.UseFont = true;
            this.btnsil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsil.ImageOptions.Image")));
            this.btnsil.Location = new System.Drawing.Point(161, 278);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(118, 40);
            this.btnsil.TabIndex = 14;
            this.btnsil.Text = "Sil";
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // sbtnkaydet
            // 
            this.sbtnkaydet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtnkaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtnkaydet.Appearance.Options.UseFont = true;
            this.sbtnkaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnkaydet.ImageOptions.Image")));
            this.sbtnkaydet.Location = new System.Drawing.Point(336, 278);
            this.sbtnkaydet.Name = "sbtnkaydet";
            this.sbtnkaydet.Size = new System.Drawing.Size(115, 40);
            this.sbtnkaydet.TabIndex = 13;
            this.sbtnkaydet.Text = "Kaydet";
            this.sbtnkaydet.Click += new System.EventHandler(this.sbtnkaydet_Click);
            // 
            // lblindex
            // 
            this.lblindex.Location = new System.Drawing.Point(525, 58);
            this.lblindex.Name = "lblindex";
            this.lblindex.Size = new System.Drawing.Size(44, 16);
            this.lblindex.TabIndex = 15;
            this.lblindex.Text = "lblindex";
            // 
            // frmurungrup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(635, 387);
            this.Controls.Add(this.lblindex);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.sbtnkaydet);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.txturungrup);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmurungrup";
            this.Text = "frmurungrup";
            this.Load += new System.EventHandler(this.frmurungrup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txturungrup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txturungrup;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.SimpleButton btnsil;
        private DevExpress.XtraEditors.SimpleButton sbtnkaydet;
        private DevExpress.XtraEditors.LabelControl lblindex;
    }
}