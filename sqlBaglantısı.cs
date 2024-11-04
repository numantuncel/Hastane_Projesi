using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Hastane_Projesi
{
    internal class sqlBaglantısı
    {
        public string adres = System.IO.File.ReadAllText(@"C:\Test.txt");
        public SqlConnection baglanti()
        {
            
            SqlConnection bağlan = new SqlConnection("Data Source=NUMANTUNCEL\\MSSQLSERVER01;Initial Catalog=HastaneProje;Integrated Security=True;");
            bağlan.Open();
            return bağlan;
        }
        public SqlCommand sorguOlustur(string sorgu)
        {
            SqlCommand komut = new SqlCommand(sorgu,baglanti());
            return komut;
        }
    }
}
