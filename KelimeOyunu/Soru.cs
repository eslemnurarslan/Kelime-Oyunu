using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace KelimeOyunu
{
    class Soru
    {
        public string soru;
        public string cevap;
        public int id;
        private bool[] alinanHarfler;
        public Soru(int id, string soru, string cevap)
        {
            this.id = id;
            this.soru = soru;
            this.cevap = cevap;
            alinanHarfler = new bool[cevap.Length];
        }
        public string cevapGetir()
        {
            string str = "";
            for (int i = 0; i < cevap.Length; i++)
            {
                if (alinanHarfler[i]==false)
                {
                    str += "-";
                }
                else
                {
                    str += cevap[i];
                }
            }
            return str;
        }
        public bool TumHarflerAlindiMi()
        {
           return alinanHarfler.Where(x => x == true).ToList().Count == alinanHarfler.Length;
        }
        public int acilmayanHarfSayisi()
        {
            return alinanHarfler.Where(x => x == false).ToList().Count;
        }
        public void rastgeleHarfAc()
        {
            int index;
            Random rastgele = new Random();
            do
            {
                index = rastgele.Next(0,cevap.Length);
            } while (alinanHarfler[index]==true);
            alinanHarfler[index] = true;
        }
        public void vtKaydet(MySqlConnection con)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Sorular(soru,cevap) VALUES('" + soru.Replace('\'','\0') + "','" + cevap + "')");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
