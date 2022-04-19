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
    public partial class frmfirmalar : Form
    {
        public frmfirmalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void firmalistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from tbl_firmalar", bgl.baglanti());
            DataTable dt = new DataTable();
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
            txtad.Text = "";
            txtid.Text = "";
            txtmail.Text = "";
            txtsektor.Text = "";
            txtvergiid.Text = "";
            txtyetkili.Text = "";
            txtygorev.Text = "";
            maskedfax.Text = "";
            maskedtel1.Text = " ";
            maskedtel2.Text = "";
            maskedtel3.Text = "";
            richadres.Text = "";
            comboil.Text = "";
            comboilce.Text = "";
            maskedtc.Text = "";
            txtad.Focus();
        }
        
        private void frmfirmalar_Load(object sender, EventArgs e)
        {
            firmalistesi();
            sehirlistesi();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr !=null)
            {
                txtid.Text = dr["ID"].ToString();
                txtad.Text= dr["AD"].ToString();
                txtyetkili.Text= dr["YETKILISTATU"].ToString();
                txtygorev.Text= dr["YETKILIADSOYAD"].ToString();
                maskedtc.Text= dr["YETKILITC"].ToString();
                txtsektor.Text= dr["SEKTOR"].ToString();
                maskedtel1.Text= dr["TELEFON1"].ToString();
                maskedtel2.Text= dr["TELEFON2"].ToString();
                maskedtel3.Text= dr["TELEFON3"].ToString();
                txtmail.Text= dr["MAIL"].ToString();
                maskedfax.Text= dr["FAX"].ToString();
                comboil.Text= dr["IL"].ToString();
                comboilce.Text= dr["ILCE"].ToString();
                txtvergiid.Text= dr["VERGIDAIRESI"].ToString();
                richadres.Text= dr["ADRES"].ToString();
                

            }
        }

        private void sbtnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_firmalar (AD,YETKILISTATU,YETKILIADSOYAD,YETKILITC,SEKTOR,TELEFON1,TELEFON2,TELEFON3,MAIL,FAX,IL,ILCE,VERGIDAIRESI,ADRES) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtygorev.Text);
            komut.Parameters.AddWithValue("@p3", txtyetkili.Text);
            komut.Parameters.AddWithValue("@p4", maskedtc.Text);
            komut.Parameters.AddWithValue("@p5", txtsektor.Text);
            komut.Parameters.AddWithValue("@p6", maskedtel1.Text);
            komut.Parameters.AddWithValue("@p7", maskedtel2.Text);
            komut.Parameters.AddWithValue("@p8", maskedtel3.Text);
            komut.Parameters.AddWithValue("@p9", txtmail.Text);
            komut.Parameters.AddWithValue("@p10", maskedfax.Text);
            komut.Parameters.AddWithValue("@p11", comboil.Text);
            komut.Parameters.AddWithValue("@p12", comboilce.Text);
            komut.Parameters.AddWithValue("@p13", txtvergiid.Text);
            komut.Parameters.AddWithValue("@p14", richadres.Text);
           
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Sisteme Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            firmalistesi();
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

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From tbl_firmalar where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            firmalistesi();
            MessageBox.Show("Firma Listeden silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_firmalar set AD=@p1,YETKILISTATU=@p2,YETKILIADSOYAD=@p3,YETKILITC=@p4,SEKTOR=@p5,TELEFON1=@p6,TELEFON2=@p7,TELEFON3=@p8,MAIL=@p9,FAX=@p12,IL=@p10,ILCE=@p11,VERGIDAIRESI=@p13,ADRES=@p14 WHERE ID=@p18", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtygorev.Text);
            komut.Parameters.AddWithValue("@p3", txtyetkili.Text);
            komut.Parameters.AddWithValue("@p4", maskedtc.Text);
            komut.Parameters.AddWithValue("@p5", txtsektor.Text);
            komut.Parameters.AddWithValue("@p6", maskedtel1.Text);
            komut.Parameters.AddWithValue("@p7", maskedtel2.Text);
            komut.Parameters.AddWithValue("@p8", maskedtel3.Text);
            komut.Parameters.AddWithValue("@p9", txtmail.Text);
            komut.Parameters.AddWithValue("@p12", maskedfax.Text);
            komut.Parameters.AddWithValue("@p10", comboil.Text);
            komut.Parameters.AddWithValue("@p11", comboilce.Text);
            komut.Parameters.AddWithValue("@p13", txtvergiid.Text);
            komut.Parameters.AddWithValue("@p14", richadres.Text);
            komut.Parameters.AddWithValue("@p18", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            firmalistesi();
            temizle();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
