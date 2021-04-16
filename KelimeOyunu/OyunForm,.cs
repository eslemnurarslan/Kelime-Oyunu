using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOyunu
{
    public partial class OyunForm_ : Form
    {
        int dakika = 3, saniye = 60, tahminSaniye = 20,index,skor=0;
        string oyuncuAdi;
        DateTime tarih;
        List<Soru> sorular;
        Soru aktifSoru;
        public OyunForm_(string oyuncuAdi)
        {
            this.oyuncuAdi = oyuncuAdi;
            sorular = SoruDb.OyunGetir();
            index = -1;
            tarih = DateTime.Now;
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            oyunSayac.Start();
            SonrakiSoru();
        }

        private void oyunSayac_Tick(object sender, EventArgs e)
        {
            saniye--;
            if (saniye==0&&dakika!=0)
            {
                saniye = 59;
                dakika--;
            }
            EkranGoster();
            OyunKontrol();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oyunSayac.Stop();
            cevapSayac.Start();
            tahminEt();
        }

        private void cevapSayac_Tick(object sender, EventArgs e)
        {
            tahminSaniye--;
            if (tahminSaniye==0)
            {
                skor -= aktifSoru.acilmayanHarfSayisi()*100;
                tahminSaniye = 20;
                oyunSayac.Start();
                SonrakiSoru();
                tahminBitis();
                cevapSayac.Stop();
                tbTahmin.Text = "";
                EkranGoster();
            }
        }
        public void SonrakiSoru()
        {
            index++;
            if (index == sorular.Count)
            {
                OyunuBitir();
            }
            else
            {
                aktifSoru = sorular[index];
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tbTahmin.Text.ToLower()==aktifSoru.cevap.ToLower())
            {
                skor += aktifSoru.acilmayanHarfSayisi() * 100;
                tahminSaniye = 3;
                cevapSayac.Stop();
                oyunSayac.Start();
                tahminBitis();
                SonrakiSoru();
                tbTahmin.Text = "";
                EkranGoster();
            }
        }
        private void tahminEt()
        {
            button5.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }
        private void tahminBitis()
        {
            button5.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;

        }

        private void OyunForm__Load(object sender, EventArgs e)
        {
            oyuncuLabel.Text = oyuncuAdi;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aktifSoru.rastgeleHarfAc();
            if (aktifSoru.TumHarflerAlindiMi())
            {
                skor -= aktifSoru.cevap.Length*100;
                SonrakiSoru();
            }
            EkranGoster();
        }

        private void OyunKontrol()
        {
            if (index==sorular.Count||(dakika == 0&&saniye==0))
            {
                OyunuBitir();
            }
        }
        private void EkranGoster()
        {
            soruLabel.Text = aktifSoru.soru;
            kelimeLabel.Text = aktifSoru.cevapGetir();
            sureLabel.Text = dakika.ToString() + " : " + saniye.ToString();
            if (dakika == 0)
                sureLabel.BackColor = Color.Red;
            tarihLabel.Text = tarih.ToShortDateString();
            skorLabel.Text = skor.ToString();
            soruSayiLbl.Text = "Soru: " + (index + 1).ToString();
        }
        private void OyunuBitir()
        {
            oyunSayac.Stop();
            MessageBox.Show("Oyun Bitti.");
            MessageBox.Show("Tebrikler "+oyuncuAdi+"! Puanınız: "+skor);
            MessageBox.Show("Kalan Süre: "+(dakika.ToString()+" : "+saniye.ToString())+" Oynama Tarihi: "+tarih.ToShortDateString());
            Application.Exit();
        }
    }
}
