using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticariotomasyon
{
    public partial class frmraporlar : Form
    {
        public frmraporlar()
        {
            InitializeComponent();
        }

        private void frmraporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ticariotomasyonDataSet3.tbl_giderler' table. You can move, or remove it, as needed.
            this.tbl_giderlerTableAdapter.Fill(this.ticariotomasyonDataSet3.tbl_giderler);
            // TODO: This line of code loads data into the 'ticariotomasyonDataSet2.tbl_personel' table. You can move, or remove it, as needed.
            this.tbl_personelTableAdapter.Fill(this.ticariotomasyonDataSet2.tbl_personel);
            // TODO: This line of code loads data into the 'ticariotomasyonDataSet1.tbl_musteriler' table. You can move, or remove it, as needed.
            this.tbl_musterilerTableAdapter.Fill(this.ticariotomasyonDataSet1.tbl_musteriler);
            // TODO: This line of code loads data into the 'ticariotomasyonDataSet.tbl_firmalar' table. You can move, or remove it, as needed.
            this.tbl_firmalarTableAdapter.Fill(this.ticariotomasyonDataSet.tbl_firmalar);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
        }
    }
}
