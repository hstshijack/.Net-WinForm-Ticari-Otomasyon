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
    public partial class frmhareketler : Form
    {
        public frmhareketler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void firmahareket()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Exec Hareketler", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
        }
        void musterihareket()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Exec musterihareketleri", bgl.baglanti());
            da1.Fill(dt1);
            gridControl1.DataSource = dt1;
        }
        private void frmhareketler_Load(object sender, EventArgs e)
        {
            firmahareket();
            musterihareket();
        }
    }
}
