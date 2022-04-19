
namespace ticariotomasyon
{
    partial class frmmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmail));
            this.label1 = new System.Windows.Forms.Label();
            this.txtmail = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkonu = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmesaj = new System.Windows.Forms.RichTextBox();
            this.sbtngonder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkonu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresi :";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(179, 85);
            this.txtmail.Name = "txtmail";
            this.txtmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmail.Properties.Appearance.Options.UseFont = true;
            this.txtmail.Size = new System.Drawing.Size(256, 28);
            this.txtmail.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Konu :";
            // 
            // txtkonu
            // 
            this.txtkonu.Location = new System.Drawing.Point(179, 148);
            this.txtkonu.Name = "txtkonu";
            this.txtkonu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkonu.Properties.Appearance.Options.UseFont = true;
            this.txtkonu.Size = new System.Drawing.Size(256, 28);
            this.txtkonu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mesaj :";
            // 
            // txtmesaj
            // 
            this.txtmesaj.Location = new System.Drawing.Point(179, 204);
            this.txtmesaj.Name = "txtmesaj";
            this.txtmesaj.Size = new System.Drawing.Size(256, 96);
            this.txtmesaj.TabIndex = 5;
            this.txtmesaj.Text = "";
            // 
            // sbtngonder
            // 
            this.sbtngonder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtngonder.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sbtngonder.Appearance.Options.UseFont = true;
            this.sbtngonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbtnkaydet.ImageOptions.Image")));
            this.sbtngonder.Location = new System.Drawing.Point(280, 330);
            this.sbtngonder.Name = "sbtngonder";
            this.sbtngonder.Size = new System.Drawing.Size(155, 40);
            this.sbtngonder.TabIndex = 95;
            this.sbtngonder.Text = "Gönder";
            this.sbtngonder.Click += new System.EventHandler(this.sbtngonder_Click);
            // 
            // frmmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 460);
            this.Controls.Add(this.sbtngonder);
            this.Controls.Add(this.txtmesaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtkonu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmmail";
            this.Load += new System.EventHandler(this.frmmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkonu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtmail;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtkonu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtmesaj;
        private DevExpress.XtraEditors.SimpleButton sbtngonder;
    }
}