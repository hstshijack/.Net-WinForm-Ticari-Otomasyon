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
    public partial class frmanasayfa : Form
    {
        public frmanasayfa()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        //void azalanstok()
        //{
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter("select URUNAD,sum(adet) as 'Adet' from tbl_urunler group by URUNAD having sum(adet)<=20 order by sum(adet)", bgl.baglanti());
        //    da.Fill(dt);
        //    gridControl3.DataSource = dt;
        //}
        //void ajanda()
        //{
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter("Select top 8 tarıh,saat,baslık  from tbl_notlar order by ID desc", bgl.baglanti());
        //    da.Fill(dt);
        //    gridControl4.DataSource = dt;
        //}
        //void firmahareket()
        //{
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter da = new SqlDataAdapter("Exec firmahareket2", bgl.baglanti());
        //    da.Fill(dt);
        //    gridControl1.DataSource = dt;
        //}
        private void frmanasayfa_Load(object sender, EventArgs e)
        {
            //azalanstok();
            //ajanda();
            //firmahareket();
        }
    }
}
