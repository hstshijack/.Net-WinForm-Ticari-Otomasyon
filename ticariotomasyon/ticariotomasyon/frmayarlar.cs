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
    public partial class frmayarlar : Form
    {
        public frmayarlar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from tbl_giris", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void frmayarlar_Load(object sender, EventArgs e)
        {
            listele();
            txtkuladi.Text = "";
            txtsifre.Text = "";

        }

        private void sbtnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_giris  values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtkuladi.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Admin Sisteme Kaydedildi","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(dr !=null)
            {
                txtkuladi.Text = dr["kuladi"].ToString();
                txtsifre.Text = dr["sifre"].ToString();
                lblid.Text = dr["id"].ToString();
            }
        }

        private void sbtnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("update tbl_giris set  sifre=@p2 ,kuladi=@p1 where id=@p3", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", txtkuladi.Text);
            komut1.Parameters.AddWithValue("@p2", txtsifre.Text);
            komut1.Parameters.AddWithValue("@p3", lblid.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            listele();
        }

        private void sbtnurungrupekle_Click(object sender, EventArgs e)
        {
            frmurungrup frm = new frmurungrup();
            frm.ShowDialog();
        }
    }
}
