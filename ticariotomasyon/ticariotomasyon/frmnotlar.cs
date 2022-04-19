using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ticariotomasyon
{
    public partial class frmnotlar : Form
    {
        public frmnotlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *from tbl_notlar", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txtbaslik.Text = "";
            txthitap.Text = "";
            txtid.Text = "";
            txtolusturan.Text = "";
            richdetay.Text = "";
            maskedsaat.Text = "";
            maskestarih.Text = "";
        }
        private void frmnotlar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void sbtnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_notlar (TARIH,SAAT,BASLIK,DETAY,OLUSTURAN,HITAP)values(@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskestarih.Text);
            komut.Parameters.AddWithValue("@p2", maskedsaat.Text);
            komut.Parameters.AddWithValue("@p3", txtbaslik.Text);
            komut.Parameters.AddWithValue("@p4", richdetay.Text);
            komut.Parameters.AddWithValue("@p5", txtolusturan.Text);
            komut.Parameters.AddWithValue("@p6", txthitap.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Not Bilgisi Sisteme Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr !=null)
            {
                txtid.Text = dr["ID"].ToString();
                txtbaslik.Text = dr["BASLIK"].ToString();
                richdetay.Text = dr["DETAY"].ToString();
                txtolusturan.Text = dr["OLUSTURAN"].ToString();
                txthitap.Text = dr["HITAP"].ToString();
                maskestarih.Text = dr["TARIH"].ToString();
                maskedsaat.Text = dr["SAAT"].ToString();

            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete *from tbl_notkar where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not Sistemden Silindi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_notlar set TARIH=@P1,SAAT=@P2,BASLIK=@P3,DETAY=@P4,OLUSTURAN=@P5,HITAP=@P6 where ID=@p7", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", maskestarih.Text);
            komut.Parameters.AddWithValue("@p2", maskedsaat.Text);
            komut.Parameters.AddWithValue("@p3", txtbaslik.Text);
            komut.Parameters.AddWithValue("@p4", richdetay.Text);
            komut.Parameters.AddWithValue("@p5", txtolusturan.Text);
            komut.Parameters.AddWithValue("@p6", txthitap.Text);
            komut.Parameters.AddWithValue("@p7", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            listele();
            MessageBox.Show("Not Bilgisi Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);

        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmnotdetay frm = new frmnotdetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(dr !=null)
            {
                frm.metin = dr["DETAY"].ToString();
            }
            frm.Show();
        }
    }
}
