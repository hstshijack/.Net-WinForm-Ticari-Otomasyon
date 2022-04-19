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
    public partial class frmurungrup : Form
    {
        public frmurungrup()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void urungrupdoldur()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from tbl_urungrup", bgl.baglanti());
            da.Fill(dt);
            listBoxControl1.DisplayMember = "urungrupadi";
            listBoxControl1.ValueMember = "id";
            listBoxControl1.DataSource = dt;
        }
        private void frmurungrup_Load(object sender, EventArgs e)
        {
            urungrupdoldur();
           
        }
       
        private void sbtnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_urungrup (urungrupadi) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txturungrup.Text);
           
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Grubu Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            urungrupdoldur();
            txturungrup.Text = "";
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tbl_urungrup where urungrupadi=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblindex.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Grubu Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            urungrupdoldur();
           
        }

       
    }
}
