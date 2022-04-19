
namespace ticariotomasyon
{
    partial class frmgiris
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtkuladi = new DevExpress.XtraEditors.TextEdit();
            this.txtsifre = new DevExpress.XtraEditors.TextEdit();
            this.sbtngiris = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtkuladi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(108, 137);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kullanıcı Adı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(149, 186);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Şifre :";
            // 
            // txtkuladi
            // 
            this.txtkuladi.Location = new System.Drawing.Point(191, 134);
            this.txtkuladi.Name = "txtkuladi";
            this.txtkuladi.Size = new System.Drawing.Size(170, 22);
            this.txtkuladi.TabIndex = 2;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(191, 183);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(170, 22);
            this.txtsifre.TabIndex = 3;
            // 
            // sbtngiris
            // 
            this.sbtngiris.Location = new System.Drawing.Point(191, 228);
            this.sbtngiris.Name = "sbtngiris";
            this.sbtngiris.Size = new System.Drawing.Size(170, 29);
            this.sbtngiris.TabIndex = 4;
            this.sbtngiris.Text = "Giriş";
            this.sbtngiris.Click += new System.EventHandler(this.sbtngiris_Click);
            // 
            // frmgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 310);
            this.Controls.Add(this.sbtngiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkuladi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmgiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmgiris";
            this.Load += new System.EventHandler(this.frmgiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtkuladi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtkuladi;
        private DevExpress.XtraEditors.TextEdit txtsifre;
        private DevExpress.XtraEditors.SimpleButton sbtngiris;
    }
}