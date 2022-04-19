using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticariotomasyon
{
    public partial class frmurunler : Form
    {
        public frmurunler()
        {
            InitializeComponent();
        }
        sqlbaglantisi baglanti = new sqlbaglantisi();
        void listele()
        {
           


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ID, URUNAD as 'ÜRÜN ADI',MARKA,MODEL,URUNGRUP as 'ÜRÜN GRUBU',YIL,ADET,ALISFIYATI AS 'ALIŞ FİYATI',SATISFIYATI AS 'SATIŞ FİYATI',DETAY from tbl_urunler", baglanti.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        

        private void frmurunler_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
            urungrupdoldur();
        }
        void urungrupdoldur()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from tbl_urungrup", baglanti.baglanti());
            da1.Fill(dt1);
            cmburungrup.DisplayMember = "urungrupadi";
            cmburungrup.ValueMember = "id";
            cmburungrup.DataSource = dt1;
           
        }

        private void sbtnkaydet_Click(object sender, EventArgs e)
        {
            //Veri Kaydetme

            SqlCommand komut = new SqlCommand("insert into tbl_urunler(URUNAD,MARKA,MODEL,URUNGRUP,YIL,ADET,ALISFIYATI,SATISFIYATI,DETAY) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtmarka.Text);
            komut.Parameters.AddWithValue("@p3", txtmodel.Text);
            komut.Parameters.AddWithValue("@p9", cmburungrup.Text);
            komut.Parameters.AddWithValue("@p4", maskedyil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((numericadet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtalisfiyati.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtsatisfiyati.Text));
            komut.Parameters.AddWithValue("@p8", richdetay.Text);
        
            komut.ExecuteNonQuery();
            baglanti.baglanti().Close();
            MessageBox.Show("Ürün sisteme eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from tbl_urunler where ID=@p1", baglanti.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.baglanti().Close();
            MessageBox.Show("Ürün silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
            temizle();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtid.Text = dr["ID"].ToString();
            txtad.Text = dr["ÜRÜN ADI"].ToString();
            txtmarka.Text = dr["MARKA"].ToString();
            txtmodel.Text = dr["MODEL"].ToString();
            maskedyil.Text = dr["YIL"].ToString();
            numericadet.Value = decimal.Parse(dr["ADET"].ToString());
            txtalisfiyati.Text = dr["ALIŞ FİYATI"].ToString();
            txtsatisfiyati.Text = dr["SATIŞ FİYATI"].ToString();
            richdetay.Text = dr["DETAY"].ToString();

        }
       
        void temizle()
        {
            txtad.Text = "";
            txtalisfiyati.Text = "";
            txtid.Text = "";
            txtmarka.Text = "";
            txtmodel.Text = "";
            txtsatisfiyati.Text = "";
            maskedyil.Text = "";
            numericadet.Value = 0;
            richdetay.Text = "";

            
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_urunler set URUNAD=@p1,MARKA=@p2,MODEL=@p3,URUNGRUP=@p10,YIL=@p4,ADET=@p5,ALISFIYATI=@p6,SATISFIYATI=@p7,DETAY=@p8 where ID=@p9", baglanti.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtmarka.Text);
            komut.Parameters.AddWithValue("@p3", txtmodel.Text);
            komut.Parameters.AddWithValue("@p10", cmburungrup.Text);
            komut.Parameters.AddWithValue("@p4", maskedyil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((numericadet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtalisfiyati.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtsatisfiyati.Text));
            komut.Parameters.AddWithValue("@p8", richdetay.Text);
            komut.Parameters.AddWithValue("@p9", txtid.Text);
            komut.ExecuteNonQuery();
            baglanti.baglanti().Close();
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            temizle();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
