using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ticariotomasyon
{
    public partial class frmgiderler : Form
    {
        public frmgiderler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        void giderlistesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from tbl_giderler order by ID asc", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        void temizle()
        {
            txtdogalgaz.Text = "";
            txtekstra.Text = "";
            txtelektrik.Text = "";
            txtid.Text = "";
            txtinternet.Text = "";
            txtmaaslar.Text = "";
            txtsu.Text = "";
            cmbay.Text = "";
            cmbyil.Text = "";
            richnotlar.Text = "";

        }
        private void frmgiderler_Load(object sender, EventArgs e)
        {
           
            giderlistesi();
            temizle();


        }

        private void sbtnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_giderler (AY,YIL,ELEKTRIK,SU,DOGALGAZ,INTERNET,MAASLAR,EKSTRA,NOTLAR)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbay.Text);
            komut.Parameters.AddWithValue("@p2", cmbyil.Text);
            komut.Parameters.AddWithValue("@p3",decimal.Parse(txtelektrik.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtsu.Text));
            komut.Parameters.AddWithValue("@p5", decimal.Parse(txtdogalgaz.Text));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtinternet.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtmaaslar.Text));
            komut.Parameters.AddWithValue("@p8", decimal.Parse(txtekstra.Text));
            komut.Parameters.AddWithValue("@p9", richnotlar.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider tabloya eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            giderlistesi();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr!=null)
            {
                txtid.Text = dr["ID"].ToString();
                cmbay.Text = dr["AY"].ToString();
                cmbyil.Text = dr["YIL"].ToString();
                txtelektrik.Text = dr["ELEKTRIK"].ToString();
                txtsu.Text = dr["SU"].ToString();
                txtdogalgaz.Text = dr["DOGALGAZ"].ToString();
                txtinternet.Text = dr["INTERNET"].ToString();
                txtmaaslar.Text = dr["MAASLAR"].ToString();
                txtekstra.Text = dr["EKSTRA"].ToString();
                richnotlar.Text = dr["NOTLAR"].ToString();

            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From tbl_giderler where ID=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            giderlistesi();
            MessageBox.Show("Gider listeden silindi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("update tbl_giderler set AY=@P1,YIL=@P2,ELEKTRIK=@P3,SU=@P4,DOGALGAZ=@P5,INTERNET=@P6,MAASLAR=@P7,EKSTRA=@P8,NOTLAR=@P9 where ID=@P10", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", cmbay.Text);
            komut.Parameters.AddWithValue("@P2", cmbyil.Text);
            komut.Parameters.AddWithValue("@P3", decimal.Parse(txtelektrik.Text));
            komut.Parameters.AddWithValue("@P4", decimal.Parse(txtsu.Text));
            komut.Parameters.AddWithValue("@P5", decimal.Parse(txtdogalgaz.Text));
            komut.Parameters.AddWithValue("@P6", decimal.Parse(txtinternet.Text));
            komut.Parameters.AddWithValue("@P7", decimal.Parse(txtmaaslar.Text));
            komut.Parameters.AddWithValue("@P8", decimal.Parse(txtekstra.Text));
            komut.Parameters.AddWithValue("@P9", richnotlar.Text);
            komut.Parameters.AddWithValue("@P10", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderlistesi();
            temizle();

        }
    }
}
