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
    public partial class frmfaturalar : Form
    {
        public frmfaturalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select *from tbl_fatura_bilgi", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txtalici.Text = "";
            txtid.Text = "";
            txtseri.Text = "";
            txtsirano.Text = "";
            txtteslimalan.Text = "";
            txtteslimeden.Text = "";
            txtvergidaire.Text = "";
            maskedsaat.Text = "";
            maskedtarih.Text = "";
        }

        private void frmfaturalar_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }

        private void sbtnkaydet_Click(object sender, EventArgs e)
        {
            if(txtfaturaid.Text=="")
            {
                SqlCommand komut = new SqlCommand("insert into tbl_fatura_bilgi (SERI,SIRANO,TARIH,SAAT,VERGIDAIRESI,ALICI,TESLIMEDEN,TESLIMALAN)VALUES(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)", bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", txtseri.Text);
                komut.Parameters.AddWithValue("@P2", txtsirano.Text);
                komut.Parameters.AddWithValue("@P3", maskedtarih.Text);
                komut.Parameters.AddWithValue("@P4", maskedsaat.Text);
                komut.Parameters.AddWithValue("@P5", txtvergidaire.Text);
                komut.Parameters.AddWithValue("@P6", txtalici.Text);
                komut.Parameters.AddWithValue("@P7", txtteslimeden.Text);
                komut.Parameters.AddWithValue("@P8", txtteslimalan.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Fatura Bilgisi Sisteme Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                listele();
            }
            if(txtfaturaid.Text !="")
            {
                double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(txtfiyat.Text);
                miktar = Convert.ToDouble(txtmiktar.Text);
                tutar = Convert.ToDouble(txttutar.Text);
                tutar = miktar * fiyat;
                txttutar.Text = tutar.ToString();

                SqlCommand komut2 = new SqlCommand("insert into tbl_fatura_detay (URUNAD,MIKTAR,FIYAT,TUTAR,FATURAID)values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txturunadi.Text);
                komut2.Parameters.AddWithValue("@p2", txtmiktar.Text);
                komut2.Parameters.AddWithValue("@p3", txtfiyat.Text);
                komut2.Parameters.AddWithValue("@p4", txttutar.Text);
                komut2.Parameters.AddWithValue("@p5", txtfaturaid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Faturaya Ait Ürün Kaydedildi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                listele();

            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr !=null)
            {
                txtid.Text = dr["ID"].ToString();
                txtsirano.Text = dr["SIRANO"].ToString();
                txtseri.Text = dr["SERI"].ToString();
                maskedtarih.Text = dr["TARIH"].ToString();
                maskedsaat.Text = dr["SAAT"].ToString();
                txtalici.Text = dr["ALICI"].ToString();
                txtteslimeden.Text = dr["TESLIMEDEN"].ToString();
                txtteslimalan.Text = dr["TESLIMALAN"].ToString();
                txtvergidaire.Text = dr["VERGIDAIRESI"].ToString();
               

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsil2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tbl_fatura_bilgi where ID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            listele();
        }

        private void btnguncelle2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_fatura_bilgi set SERI=@P1,SIRANO=@P2,TARIH=@P3,SAAT=@P4,VERGIDAIRESI=@P5,ALICI=@P6,TESLIMEDEN=@P7,TESLIMALAN=@P8 WHERE ID=@P9", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtseri.Text);
            komut.Parameters.AddWithValue("@P2", txtsirano.Text);
            komut.Parameters.AddWithValue("@P3", maskedtarih.Text);
            komut.Parameters.AddWithValue("@P4", maskedsaat.Text);
            komut.Parameters.AddWithValue("@P5", txtvergidaire.Text);
            komut.Parameters.AddWithValue("@P6", txtalici.Text);
            komut.Parameters.AddWithValue("@P7", txtteslimeden.Text);
            komut.Parameters.AddWithValue("@P8", txtteslimalan.Text);
            komut.Parameters.AddWithValue("@P9", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura Bilgisi  Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmfaturadetay fr = new frmfaturadetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if(dr !=null)
            {
                fr.id = dr["ID"].ToString();

            }
            fr.Show();
        }
    }
}
