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
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void sbtngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select *from tbl_giris where kuladi=@p1,sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtkuladi.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                Anasayfa frm = new Anasayfa();
                
                frm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre","",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }
            bgl.baglanti().Close();
                
        }

        private void frmgiris_Load(object sender, EventArgs e)
        {

        }
    }
}
