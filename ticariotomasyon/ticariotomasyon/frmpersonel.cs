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
    public partial class frmpersonel : Form
    {
        public frmpersonel()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void personelliste()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,AD AS 'ADI',SOYAD AS 'SOYADI',TELEFON,TC,MAIL AS 'MAİL',IL AS 'İL',ILCE AS 'İLÇE',ADRES,GOREV AS 'GÖREV'  from tbl_personel", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("select SEHIR from tbl_iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboil.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();

        }
        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtgorev.Text = "";
            txtsoyad.Text = "";
            txtmail.Text = "";
            maskedtc.Text = "";
            maskedtel1.Text = "";
            comboil.Text = "";
            comboilce.Text = "";
            richadres.Text ="";
        }
        private void frmpersonel_Load(object sender, EventArgs e)
        {
            personelliste();
            sehirlistesi();
            temizle();
        }


        private void sbtnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_personel(AD,SOYAD,TELEFON,TC,MAIL,IL,ILCE,ADRES,GOREV) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedtel1.Text);
            komut.Parameters.AddWithValue("@p4", maskedtc.Text);
            komut.Parameters.AddWithValue("@p5", txtmail.Text);
            komut.Parameters.AddWithValue("@p6", comboil.Text);
            komut.Parameters.AddWithValue("@p7", comboilce.Text);
            komut.Parameters.AddWithValue("@p8", richadres.Text);
            komut.Parameters.AddWithValue("@p9", txtgorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            personelliste();
            temizle();
        }

        private void comboil_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboilce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE from tbl_ilceler where SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboilce.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr !=null)
            {
                txtid.Text = dr["ID"].ToString();
                txtad.Text = dr["ADI"].ToString();
                txtsoyad.Text = dr["SOYADI"].ToString();
                maskedtel1.Text = dr["TELEFON"].ToString();
                maskedtc.Text = dr["TC"].ToString();
                txtmail.Text = dr["MAİL"].ToString();
                comboil.Text = dr["İL"].ToString();
                comboilce.Text = dr["İLÇE"].ToString();
                richadres.Text = dr["ADRES"].ToString();
                txtgorev.Text = dr["GÖREV"].ToString();
                
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from tbl_personel where ID=@p1",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Listeden Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.None);
            personelliste();
            temizle();

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_personel set AD=@P1,SOYAD=@P2,TELEFON=@P3,TC=@P4,MAIL=@P5,IL=@P6,ILCE=@P7,ADRES=@P8,GOREV=@P9 WHERE ID=@P10", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedtel1.Text);
            komut.Parameters.AddWithValue("@p4", maskedtc.Text);
            komut.Parameters.AddWithValue("@p5", txtmail.Text);
            komut.Parameters.AddWithValue("@p6", comboil.Text);
            komut.Parameters.AddWithValue("@p7", comboilce.Text);
            komut.Parameters.AddWithValue("@p8", richadres.Text);
            komut.Parameters.AddWithValue("@p9", txtgorev.Text);
            komut.Parameters.AddWithValue("@p10", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            personelliste();
            temizle();
        }
    }
}
