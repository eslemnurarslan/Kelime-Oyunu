using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace KelimeOyunu
{
    class SoruDb
    {
        public static MySqlConnection con = new MySqlConnection("Server=localhost;Database=KelimeOyunu;user=root;Pwd=eslem123.;SslMode=none");
        public static List<Soru> TumSorular()
        {
            con.Open();
            List<Soru> sorular = new List<Soru>();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Sorular", con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sorular.Add(new Soru(int.Parse(dr[0].ToString()),dr[1].ToString(), dr[2].ToString()));
            }
            con.Close();
            return sorular;
        }
        private static Soru rastgeleSoru(List<Soru> sorular,int harfSayisi)
        {
            List<Soru> harfLimitli = sorular.Where(s => s.cevap.Length == harfSayisi).ToList();
            Random rastgele = new Random();
            return harfLimitli[rastgele.Next(0, harfLimitli.Count)];
        }
        public static List<Soru> OyunGetir()
        {
            List<Soru> sorular = new List<Soru>();
            List<Soru> tumSorular = TumSorular();
            Soru soru;
            for (int i = 4; i <= 10; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    do
                    {
                        soru = rastgeleSoru(tumSorular, i);
                    } while (sorular.Contains(soru));
                    sorular.Add(soru);
                }
            }
            return sorular;
        }
        public static void soruSil(int id)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM Sorular WHERE id=" + id,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
