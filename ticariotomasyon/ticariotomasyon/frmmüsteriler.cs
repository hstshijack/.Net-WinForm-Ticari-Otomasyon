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
    public partial class frmmüsteriler : Form
    {
        public frmmüsteriler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from tbl_musteriler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void  sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("select SEHIR from tbl_iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                comboil.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
            
        }
        private void frmmüsteriler_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();
            temizle();
        }

        private void comboil_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboilce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE from tbl_ilceler where SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboil.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                comboilce.Properties.Items.Add(dr[0]); 

            }
            bgl.baglanti().Close();
        }

        private void sbtnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_musteriler (AD,SOYAD,TELEFON,TELEFON2,TC,MAIL,IL,ILCE,VERGIDAIRESI,ADRES) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedtel1.Text);
            komut.Parameters.AddWithValue("@p4", maskedtel2.Text);
            komut.Parameters.AddWithValue("@p5", maskedtc.Text);
            komut.Parameters.AddWithValue("@p6", txtmail.Text);
            komut.Parameters.AddWithValue("@p7", comboil.Text);
            komut.Parameters.AddWithValue("@p8", comboilce.Text);
            komut.Parameters.AddWithValue("@p9", txtvergiid.Text);
            komut.Parameters.AddWithValue("@p10", richadres.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Sisteme Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            temizle();
        }
        void temizle()
        {
            txtad.Text = "";
            txtid.Text = "";
            txtmail.Text = "";
            txtsoyad.Text = "";
            txtvergiid.Text = "";
            maskedtc.Text = "";
            maskedtel1.Text = "";
            maskedtel2.Text = "";
            comboil.Text = "";
            comboilce.Text = "";
            richadres.Text = "";
            
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!=null)
            {
                txtid.Text = dr["ID"].ToString();
                txtad.Text= dr["AD"].ToString();
                txtsoyad.Text= dr["SOYAD"].ToString();
                maskedtel1.Text= dr["TELEFON"].ToString();
                maskedtel2.Text= dr["TELEFON2"].ToString();
                maskedtc.Text= dr["TC"].ToString();
                txtmail.Text= dr["MAIL"].ToString();
                comboil.Text= dr["IL"].ToString();
                comboilce.Text= dr["ILCE"].ToString();
                txtvergiid.Text= dr["VERGIDAIRESI"].ToString();
                richadres.Text= dr["ADRES"].ToString();
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tbl_musteriler where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Silimdi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            listele();
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_musteriler set AD=@p1,SOYAD=@p2,TELEFON=@p3,TELEFON2=@p4,TC=@p5,MAIL=@p6,IL=@p7,ILCE=@p8,VERGIDAIRESI=@p9,ADRES=@p10 where ID=@p11", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedtel1.Text);
            komut.Parameters.AddWithValue("@p4", maskedtel2.Text);
            komut.Parameters.AddWithValue("@p5", maskedtc.Text);
            komut.Parameters.AddWithValue("@p6", txtmail.Text);
            komut.Parameters.AddWithValue("@p7", comboil.Text);
            komut.Parameters.AddWithValue("@p8", comboilce.Text);
            komut.Parameters.AddWithValue("@p9", txtvergiid.Text);
            komut.Parameters.AddWithValue("@p10", richadres.Text);
            komut.Parameters.AddWithValue("@p11", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Müşteri Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
