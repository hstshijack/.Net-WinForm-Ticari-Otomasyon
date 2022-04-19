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
    public partial class frmkasa : Form
    {
        public frmkasa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string ad;
        void firmahareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec Hareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void musterihareket()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Exec musterihareketleri", bgl.baglanti());
            da1.Fill(dt1);
            gridControl2.DataSource = dt1;
        }
        void toplamtutar()
        {
            SqlCommand komut1 = new SqlCommand("select sum(tutar) from tbl_fatura_detay", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read()) 
            {
                lbltoplamtutar.Text = dr1[0].ToString() + "TL";
            }
            bgl.baglanti().Close();

        }
        void odemeler()
        {
            //Son Ayın faturaları
            SqlCommand komut2 = new SqlCommand("select (ELEKTRIK+SU+DOGALGAZ)from tbl_giderler order by ID asc", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                lblodemeler.Text = dr2[0].ToString()+"TL";
            }
            bgl.baglanti().Close();
        }
        void maas()
        {
            //son ayın personel maaşları

            SqlCommand komut3 = new SqlCommand("select maaslar from tbl_giderler order by ID asc", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblpersonelmaas.Text = dr3[0].ToString()+"TL";
            }
            bgl.baglanti().Close();
        }

        void chartsondortay ()
        {
            //Son 4 ayın elektrik faturası
            groupControl4.Text = "ELEKTRİK";
            SqlCommand komut4 = new SqlCommand("select top 4 Ay,Elektrık from tbl_giderler order by ID desc", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while(dr4.Read())
            {
                chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr4[0],dr4[1]));

            }
            bgl.baglanti().Close();

            //Son 4 ayın su faturası
            groupControl5.Text = "SU";
            SqlCommand komut5 = new SqlCommand("select top 4 Ay,su from tbl_giderler order by ID Desc", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while(dr5.Read())
              {
                chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr5[0], dr5[1]));

              }

            bgl.baglanti().Close();

        }
        private void frmkasa_Load(object sender, EventArgs e)
        {
            lblaktifkullanici.Text = ad;
            musterihareket();
            firmahareket();
            toplamtutar();
            odemeler();
            maas();
            chartsondortay();
            
        }
       

        
    }
}
