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
    public partial class frmbankalar : Form
    {
        public frmbankalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(" Execute BankaBilgileri", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void firmalistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,AD from tbl_firmalar", bgl.baglanti());
            da.Fill(dt);
            lookfirma.Properties.NullText = "Lütfen Bir Ad Seçiniz";
            lookfirma.Properties.ValueMember = "ID";
            lookfirma.Properties.DisplayMember = "AD";
            lookfirma.Properties.DataSource = dt;

        }
        private void frmbankalar_Load(object sender, EventArgs e)
        {
            listele();
            sehirlistesi();
            firmalistesi();
            temizle();
        }
        void sehirlistesi()
        {
            SqlCommand komut = new SqlCommand("select SEHIR from tbl_iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbil.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();

        }

        private void sbtnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_banka (BANKAADI,IL,ILCE,SUBE,IBAN,HESAPNO,YETKILI,TELEFON,TARIH,HESAPTURU,FIRMAID)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtbankaadi.Text);
            komut.Parameters.AddWithValue("@p2",cmbil.Text);
            komut.Parameters.AddWithValue("@p3", cmbilce.Text);
            komut.Parameters.AddWithValue("@p4", txtsube.Text);
            komut.Parameters.AddWithValue("@p5", txtiban.Text);
            komut.Parameters.AddWithValue("@p6", txthesapno.Text);
            komut.Parameters.AddWithValue("@p7", txtyetkili.Text);
            komut.Parameters.AddWithValue("@p8", maskedtelefon.Text);
            komut.Parameters.AddWithValue("@p9", maskedtarih.Text);
            komut.Parameters.AddWithValue("@p10", txthesapturu.Text);
            komut.Parameters.AddWithValue("@p11", lookfirma.EditValue);
            komut.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgisi Sisteme Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("Select ILCE from tbl_ilceler where SEHIR=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbil.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbilce.Properties.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr !=null)
            {
                txtid.Text = dr["ID"].ToString();
                txtbankaadi.Text = dr["BANKAADI"].ToString();
                cmbil.Text = dr["IL"].ToString();
                cmbilce.Text = dr["ILCE"].ToString();
                txtsube.Text = dr["SUBE"].ToString();
                txtiban.Text = dr["IBAN"].ToString();
                txthesapno.Text = dr["HESAPNO"].ToString();
                txtyetkili.Text = dr["YETKILI"].ToString();
                maskedtelefon.Text = dr["TELEFON"].ToString();
                maskedtarih.Text = dr["TARIH"].ToString();
                txthesapturu.Text = dr["HESAPTURU"].ToString();
                lookfirma.Text = dr["AD"].ToString();
                
            }

        }
        void temizle()
        {
            txtbankaadi.Text = "";
            txthesapno.Text = "";
            txthesapturu.Text = "";
            txtiban.Text = "";
            txtid.Text = "";
            txtsube.Text = "";
            txtyetkili.Text = "";
            maskedtarih.Text = "";
            maskedtelefon.Text = "";
            lookfirma.Text = "";
        }

       

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_banka where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            temizle();
            MessageBox.Show("Banka Bilgisi Sistemden Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            listele();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update  tbl_banka set BANKAADI=@p1,IL=@p2,ILCE=@p3,SUBE=@p4,IBAN=@p5,HESAPNO=@p6,YETKILI=@p7,TELEFON=@p8,TARIH=@p9,HESAPTURU=@p10,FIRMAID=@p11 WHERE ID=@p12", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtbankaadi.Text);
            komut.Parameters.AddWithValue("@p2", cmbil.Text);
            komut.Parameters.AddWithValue("@p3", cmbilce.Text);
            komut.Parameters.AddWithValue("@p4", txtsube.Text);
            komut.Parameters.AddWithValue("@p5", txtiban.Text);
            komut.Parameters.AddWithValue("@p6", txthesapno.Text);
            komut.Parameters.AddWithValue("@p7", txtyetkili.Text);
            komut.Parameters.AddWithValue("@p8", maskedtelefon.Text);
            komut.Parameters.AddWithValue("@p9", maskedtarih.Text);
            komut.Parameters.AddWithValue("@p10", txthesapturu.Text);
            komut.Parameters.AddWithValue("@p11", lookfirma.EditValue);
            komut.Parameters.AddWithValue("@p12", txtid.Text);
            komut.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Bilgisi Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
