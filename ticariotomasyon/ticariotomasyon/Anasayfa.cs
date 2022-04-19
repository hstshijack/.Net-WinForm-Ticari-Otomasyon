using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticariotomasyon
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }
        frmurunler urunler;
        frmmüsteriler musteriler;
        frmfirmalar firmalar;
        frmpersonel personel;
        frmrehber rehber;
        frmgiderler giderler;
        frmbankalar bankalar;
        frmfaturalar faturalar;
        frmnotlar notlar;
        frmhareketler hareketler;
        frmraporlar raporlar;
        frmstok stok;
        frmkasa kasa;
        frmanasayfa anasayfa;
       

        

        

        private void sbtnurunler_Click_2(object sender, EventArgs e)
        {
            if(urunler ==null || urunler.IsDisposed )
            {
                if(musteriler !=null)
                {
                    musteriler.Close();
                }
                if (firmalar != null)
                {
                    firmalar.Close();
                }
                if (personel != null)
                {
                    personel.Close();
                }
                if (rehber != null)
                {
                    rehber.Close();
                }
                if (giderler != null)
                {
                    giderler.Close();
                }
                if (bankalar != null)
                {
                    bankalar.Close();
                }
                if (faturalar != null)
                {
                    faturalar.Close();
                }
                if (notlar != null)
                {
                    notlar.Close();
                }
                if (hareketler != null)
                {
                    hareketler.Close();
                }
                if (raporlar != null)
                {
                    raporlar.Close();
                }
                if (stok != null)
                {
                    stok.Close();
                }
                if (kasa != null)
                {
                    kasa.Close();
                }
                if (anasayfa != null)
                {
                    anasayfa.Close();
                }

                urunler = new frmurunler();

                urunler.MdiParent = this;
                urunler.Show();
                splitContainer1.Panel2.Controls.Add(urunler);
                urunler.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
           
        }

        private void sbtnmüsteriler_Click(object sender, EventArgs e)
        {
            if (musteriler == null || musteriler.IsDisposed)
            {
                if(urunler !=null)
                {
                    urunler.Close();
                }
                if (firmalar != null)
                {
                    firmalar.Close();
                }
                if (personel != null)
                {
                    personel.Close();
                }
                if (rehber != null)
                {
                    rehber.Close();
                }
                if (giderler != null)
                {
                    giderler.Close();
                }
                if (bankalar != null)
                {
                    bankalar.Close();
                }
                if (faturalar != null)
                {
                    faturalar.Close();
                }
                if (notlar != null)
                {
                    notlar.Close();
                }
                if (hareketler != null)
                {
                    hareketler.Close();
                }
                if (raporlar != null)
                {
                    raporlar.Close();
                }
                if (stok != null)
                {
                    stok.Close();
                }
                if (kasa != null)
                {
                    kasa.Close();
                }
                if (anasayfa != null)
                {
                    anasayfa.Close();
                }
                musteriler = new frmmüsteriler();

                musteriler.MdiParent = this;
                musteriler.Show();
                splitContainer1.Panel2.Controls.Add(musteriler);
                musteriler.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
        }

        private void sbtnfirmalar_Click(object sender, EventArgs e)
        {
            if (firmalar == null || firmalar.IsDisposed)
            {
                if (urunler != null)
                {
                    urunler.Close();
                }
                if (musteriler != null)
                {
                    musteriler.Close();
                }
                if (personel != null)
                {
                    personel.Close();
                }
                if (rehber != null)
                {
                    rehber.Close();
                }
                if (giderler != null)
                {
                    giderler.Close();
                }
                if (bankalar != null)
                {
                    bankalar.Close();
                }
                if (faturalar != null)
                {
                    faturalar.Close();
                }
                if (notlar != null)
                {
                    notlar.Close();
                }
                if (hareketler != null)
                {
                    hareketler.Close();
                }
                if (raporlar != null)
                {
                    raporlar.Close();
                }
                if (stok != null)
                {
                    stok.Close();
                }
                if (kasa != null)
                {
                    kasa.Close();
                }
                if (anasayfa != null)
                {
                    anasayfa.Close();
                }
                firmalar = new frmfirmalar();

                firmalar.MdiParent = this;
                firmalar.Show();
                splitContainer1.Panel2.Controls.Add(firmalar);
                firmalar.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
        }

        private void sbtnpersoneller_Click(object sender, EventArgs e)
        {
            if (personel == null || personel.IsDisposed)
            {
                if (musteriler != null)
                {
                    musteriler.Close();
                }
                if (firmalar != null)
                {
                    firmalar.Close();
                }
                if (urunler != null)
                {
                    urunler.Close();
                }
                if (rehber != null)
                {
                    rehber.Close();
                }
                if (giderler != null)
                {
                    giderler.Close();
                }
                if (bankalar != null)
                {
                    bankalar.Close();
                }
                if (faturalar != null)
                {
                    faturalar.Close();
                }
                if (notlar != null)
                {
                    notlar.Close();
                }
                if (hareketler != null)
                {
                    hareketler.Close();
                }
                if (raporlar != null)
                {
                    raporlar.Close();
                }
                if (stok != null)
                {
                    stok.Close();
                }
                if (kasa != null)
                {
                    kasa.Close();
                }
                if (anasayfa != null)
                {
                    anasayfa.Close();
                }
                personel = new frmpersonel();

                personel.MdiParent = this;
                personel.Show();
                splitContainer1.Panel2.Controls.Add(personel);
                personel.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
        }

        private void sbtnrehber_Click(object sender, EventArgs e)
        {
            if (rehber == null || rehber.IsDisposed)
            {
                if (urunler != null)
                {
                    urunler.Close();
                }
                if (firmalar != null)
                {
                    firmalar.Close();
                }
                if (personel != null)
                {
                    personel.Close();
                }
                if (musteriler != null)
                {
                    musteriler.Close();
                }
                if (giderler != null)
                {
                    giderler.Close();
                }
                if (bankalar != null)
                {
                    bankalar.Close();
                }
                if (faturalar != null)
                {
                    faturalar.Close();
                }
                if (notlar != null)
                {
                    notlar.Close();
                }
                if(hareketler !=null)
                {
                    hareketler.Close();
                }
                if (raporlar != null)
                {
                    raporlar.Close();
                }
                if (stok != null)
                {
                    stok.Close();
                }
                if (kasa != null)
                {
                    kasa.Close();
                }
                if (anasayfa != null)
                {
                    anasayfa.Close();
                }
                rehber = new frmrehber();

                rehber.MdiParent = this;
                rehber.Show();
                splitContainer1.Panel2.Controls.Add(rehber);
                rehber.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
        }

        private void sbtngiderler_Click(object sender, EventArgs e)
        {
            if (giderler == null || giderler.IsDisposed)
            {
                if (musteriler != null)
                {
                    musteriler.Close();
                }
                if (firmalar != null)
                {
                    firmalar.Close();
                }
                if (personel != null)
                {
                    personel.Close();
                }
                if (rehber != null)
                {
                    rehber.Close();
                }
                if (urunler != null)
                {
                    urunler.Close();
                }
                if (bankalar != null)
                {
                    bankalar.Close();
                }
                if (faturalar != null)
                {
                    faturalar.Close();
                }
                if (notlar != null)
                {
                    notlar.Close();
                }
                if (hareketler != null)
                {
                    hareketler.Close();
                }
                if (raporlar != null)
                {
                    raporlar.Close();
                }
                if (stok != null)
                {
                    stok.Close();
                }
                if (kasa != null)
                {
                    kasa.Close();
                }
                if (anasayfa != null)
                {
                    anasayfa.Close();
                }
                giderler = new frmgiderler();

                giderler.MdiParent = this;
                giderler.Show();
                splitContainer1.Panel2.Controls.Add(giderler);
                giderler.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
        }

        private void sbtnbankalar_Click(object sender, EventArgs e)
        {
            if (bankalar == null || bankalar.IsDisposed)
            {
                if (musteriler != null)
                {
                    musteriler.Close();
                }
                if (firmalar != null)
                {
                    firmalar.Close();
                }
                if (personel != null)
                {
                    personel.Close();
                }
                if (rehber != null)
                {
                    rehber.Close();
                }
                if (urunler != null)
                {
                    urunler.Close();
                }
                if (giderler != null)
                {
                    giderler.Close();
                }
                if(faturalar !=null)
                {
                    faturalar.Close();
                }
                if (notlar != null)
                {
                    notlar.Close();
                }
                if (hareketler != null)
                {
                    hareketler.Close();
                }
                if (raporlar != null)
                {
                    raporlar.Close();
                }
                if (stok != null)
                {
                    stok.Close();
                }
                if (kasa != null)
                {
                    kasa.Close();
                }
                if (anasayfa != null)
                {
                    anasayfa.Close();
                }
                bankalar = new frmbankalar();

                bankalar.MdiParent = this;
                bankalar.Show();
                splitContainer1.Panel2.Controls.Add(bankalar);
                bankalar.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
        }

        private void sbtnfaturalar_Click(object sender, EventArgs e)
        {
            if (faturalar == null || faturalar.IsDisposed)
            {
                if (musteriler != null)
                {
                    musteriler.Close();
                }
                if (firmalar != null)
                {
                    firmalar.Close();
                }
                if (personel != null)
                {
                    personel.Close();
                }
                if (rehber != null)
                {
                    rehber.Close();
                }
                if (urunler != null)
                {
                    urunler.Close();
                }
                if (giderler != null)
                {
                    giderler.Close();
                }
                if (bankalar != null)
                {
                    bankalar.Close();
                }
                if(notlar !=null)
                {
                    notlar.Close();
                }
                if (hareketler != null)
                {
                    hareketler.Close();
                }
                if (raporlar != null)
                {
                    raporlar.Close();
                }
                if (stok != null)
                {
                    stok.Close();
                }
                if (kasa != null)
                {
                    kasa.Close();
                }
                if (anasayfa != null)
                {
                    anasayfa.Close();
                }
                faturalar = new frmfaturalar();
                faturalar.MdiParent = this;
                faturalar.Show();
                splitContainer1.Panel2.Controls.Add(faturalar);
                faturalar.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
        }

        private void sbtnnotlar_Click(object sender, EventArgs e)
        {
            if (notlar == null || notlar.IsDisposed)
            {
                if (musteriler != null)
                {
                    musteriler.Close();
                }
                if (firmalar != null)
                {
                    firmalar.Close();
                }
                if (personel != null)
                {
                    personel.Close();
                }
                if (rehber != null)
                {
                    rehber.Close();
                }
                if (urunler != null)
                {
                    urunler.Close();
                }
                if (giderler != null)
                {
                    giderler.Close();
                }
                if (bankalar != null)
                {
                    bankalar.Close();
                }
                if (faturalar != null)
                {
                    faturalar.Close();
                }
                if(hareketler !=null)
                {
                    hareketler.Close();
                }
                if (raporlar != null)
                {
                    raporlar.Close();
                }
                if (stok != null)
                {
                    stok.Close();
                }
                if (kasa != null)
                {
                    kasa.Close();
                }
                if (anasayfa != null)
                {
                    anasayfa.Close();
                }
                notlar = new frmnotlar();
                notlar.MdiParent = this;
                notlar.Show();
                splitContainer1.Panel2.Controls.Add(notlar);
                notlar.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
        }

        private void sbtnhareketler_Click(object sender, EventArgs e)
        {
            if (hareketler == null || hareketler.IsDisposed)
            {
                if (musteriler != null)
                {
                    musteriler.Close();
                }
                if (firmalar != null)
                {
                    firmalar.Close();
                }
                if (personel != null)
                {
                    personel.Close();
                }
                if (rehber != null)
                {
                    rehber.Close();
                }
                if (urunler != null)
                {
                    urunler.Close();
                }
                if (giderler != null)
                {
                    giderler.Close();
                }
                if (bankalar != null)
                {
                    bankalar.Close();
                }
                if (faturalar != null)
                {
                    faturalar.Close();
                }
                if (hareketler != null)
                {
                    hareketler.Close();
                }
                if(raporlar !=null)
                {
                    raporlar.Close();
                }
                if (stok != null)
                {
                    stok.Close();
                }
                if (kasa != null)
                {
                    kasa.Close();
                }
                if (anasayfa != null)
                {
                    anasayfa.Close();
                }


                hareketler = new frmhareketler();
                hareketler.MdiParent = this;
                hareketler.Show();
                splitContainer1.Panel2.Controls.Add(hareketler);
                hareketler.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
        }

        private void sbtnraporlar_Click(object sender, EventArgs e)
        {
            if (raporlar == null || raporlar.IsDisposed)
            {
                if (musteriler != null)
                {
                    musteriler.Close();
                }
                if (firmalar != null)
                {
                    firmalar.Close();
                }
                if (personel != null)
                {
                    personel.Close();
                }
                if (rehber != null)
                {
                    rehber.Close();
                }
                if (urunler != null)
                {
                    urunler.Close();
                }
                if (giderler != null)
                {
                    giderler.Close();
                }
                if (bankalar != null)
                {
                    bankalar.Close();
                }
                if (faturalar != null)
                {
                    faturalar.Close();
                }
                if (notlar != null)
                {
                    notlar.Close();
                }
                if (hareketler != null)
                {
                    hareketler.Close();
                }
                if (stok != null)
                {
                    stok.Close();
                }


                raporlar = new frmraporlar();
                raporlar.MdiParent = this;
                raporlar.Show();
                splitContainer1.Panel2.Controls.Add(raporlar);
                raporlar.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
        }

        private void sbtnstoklar_Click(object sender, EventArgs e)
        {
            if (stok == null || stok.IsDisposed)
            {
                if (musteriler != null)
                {
                    musteriler.Close();
                }
                if (firmalar != null)
                {
                    firmalar.Close();
                }
                if (personel != null)
                {
                    personel.Close();
                }
                if (rehber != null)
                {
                    rehber.Close();
                }
                if (urunler != null)
                {
                    urunler.Close();
                }
                if (giderler != null)
                {
                    giderler.Close();
                }
                if (bankalar != null)
                {
                    bankalar.Close();
                }
                if (faturalar != null)
                {
                    faturalar.Close();
                }
                if (notlar != null)
                {
                    notlar.Close();
                }
                if (hareketler != null)
                {
                    hareketler.Close();
                }
                if (raporlar != null)
                {
                    raporlar.Close();
                }
                if (kasa != null)
                {
                    kasa.Close();
                }


                stok = new frmstok();
                stok.MdiParent = this;
                stok.Show();
                splitContainer1.Panel2.Controls.Add(stok);
                stok.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
        }

        private void sbtnayarlar_Click(object sender, EventArgs e)
        {
            frmayarlar frm = new frmayarlar();
            frm.ShowDialog();
        }

        private void sbtnkasa_Click(object sender, EventArgs e)
        {
            if (kasa == null || kasa.IsDisposed)
            {
                if (musteriler != null)
                {
                    musteriler.Close();
                }
                if (firmalar != null)
                {
                    firmalar.Close();
                }
                if (personel != null)
                {
                    personel.Close();
                }
                if (rehber != null)
                {
                    rehber.Close();
                }
                if (urunler != null)
                {
                    urunler.Close();
                }
                if (giderler != null)
                {
                    giderler.Close();
                }
                if (bankalar != null)
                {
                    bankalar.Close();
                }
                if (faturalar != null)
                {
                    faturalar.Close();
                }
                if (notlar != null)
                {
                    notlar.Close();
                }
                if (hareketler != null)
                {
                    hareketler.Close();
                }
                if (raporlar != null)
                {
                    raporlar.Close();
                }
                if (stok != null)
                {
                    stok.Close();
                }
                if (anasayfa != null)
                {
                    anasayfa.Close();
                }

                kasa = new frmkasa();
                kasa.MdiParent = this;
                kasa.Show();
                splitContainer1.Panel2.Controls.Add(kasa);
                kasa.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
        }

        private void sbtnanasayfa_Click(object sender, EventArgs e)
        {
            if (anasayfa == null || anasayfa.IsDisposed)
            {
                if (musteriler != null)
                {
                    musteriler.Close();
                }
                if (firmalar != null)
                {
                    firmalar.Close();
                }
                if (personel != null)
                {
                    personel.Close();
                }
                if (rehber != null)
                {
                    rehber.Close();
                }
                if (urunler != null)
                {
                    urunler.Close();
                }
                if (giderler != null)
                {
                    giderler.Close();
                }
                if (bankalar != null)
                {
                    bankalar.Close();
                }
                if (faturalar != null)
                {
                    faturalar.Close();
                }
                if (notlar != null)
                {
                    notlar.Close();
                }
                if (hareketler != null)
                {
                    hareketler.Close();
                }
                if (raporlar != null)
                {
                    raporlar.Close();
                }
                if (stok != null)
                {
                    stok.Close();
                }
                if (kasa != null)
                {
                    kasa.Close();
                }

                anasayfa = new frmanasayfa();
                anasayfa.MdiParent = this;
                anasayfa.Show();
                splitContainer1.Panel2.Controls.Add(anasayfa);
                anasayfa.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            }
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            anasayfa = new frmanasayfa();
            anasayfa.MdiParent = this;
            anasayfa.Show();
            splitContainer1.Panel2.Controls.Add(anasayfa);
            anasayfa.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
    }
}
