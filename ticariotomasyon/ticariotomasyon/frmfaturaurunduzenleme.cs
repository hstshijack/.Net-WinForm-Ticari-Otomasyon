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
    public partial class frmfaturaurunduzenleme : Form
    {
        public frmfaturaurunduzenleme()
        {
            InitializeComponent();
        }
        public string urunid;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmfaturaurunduzenleme_Load(object sender, EventArgs e)
        {
            txturunid.Text = urunid;

            SqlCommand komut = new SqlCommand("Select *From tbl_fatura_detay where FATURAURUNID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", urunid);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txtfiyat.Text = dr[3].ToString();
                txtmiktar.Text = dr[2].ToString();
                txttutar.Text = dr[4].ToString();
                txturunadi.Text = dr[1].ToString();
                bgl.baglanti().Close();
                    
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_fatura_detay set URUNAD=@p1,MIKTAR=@p2,FIYAT=@p3,TUTAR=@p4 WHERE FATURAURUNID=@P5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txturunadi.Text);
            komut.Parameters.AddWithValue("@p2", txtmiktar.Text);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtfiyat.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txttutar.Text));
            komut.Parameters.AddWithValue("@p5", txturunid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Değişiklikler Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From tbl_fatura_detay where FATURAURUNID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txturunid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Question);

        }
    }
}
