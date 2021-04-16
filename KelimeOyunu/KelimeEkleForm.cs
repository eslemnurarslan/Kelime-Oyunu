using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOyunu
{
    public partial class KelimeEkleForm : Form
    {
        public KelimeEkleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cevap = tbCevap.Text.Trim();
            string soru = tbSoru.Text.Trim();
            if (cevap.Contains(" "))
            {
                MessageBox.Show("Cevap, bitişik kelimelerden oluşmalıdır.");
            }
            else if (cevap.Length < 4 || cevap.Length > 10)
            {
                MessageBox.Show("Cevap en fazla 10, en az 4 harfli olmalıdır.");
            }
            else if (cevap==""||soru=="")
            {
                MessageBox.Show("Soru veya cevap boş olamaz!");
            }
            else
            {
                Soru soruNesne = new Soru(0,soru, cevap);
                soruNesne.vtKaydet(SoruDb.con);
                MessageBox.Show("Sorunuz kaydedildi.");
            }
            SorulariGoster();
        }
        private void SorulariGoster()
        {
            List<Soru> tumSorular = SoruDb.TumSorular();
            listBox1.Items.Clear();
            foreach (Soru soru in tumSorular)
            {
                listBox1.Items.Add(soru.id.ToString()+"| "+soru.soru + " : " + soru.cevap);
            }
        }
        private void KelimeEkleForm_Load(object sender, EventArgs e)
        {
            SorulariGoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex>=0)
            {
                string id = listBox1.SelectedItem.ToString().Split('|')[0];
                SoruDb.soruSil(int.Parse(id));
                MessageBox.Show("Soru silindi.");
                SorulariGoster();
            }
        }
    }
}
