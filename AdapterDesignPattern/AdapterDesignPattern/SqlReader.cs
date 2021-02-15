using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class SqlReader
    {
        public string connectionsource { get; set; }
        public void SendMessage()
        {
            Console.WriteLine("Sirket3 verilerine ulaşıldı");

        }
        public List<Calısanlar>GetAll()
        {  
         List<Calısanlar> sqllist = new List<Calısanlar>();
            SqlConnection connection = new SqlConnection(connectionsource);
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from Calisanlar", connection);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Calısanlar calısanlar = new Calısanlar();
                calısanlar.ID = Convert.ToInt32(dr[0]);
                calısanlar.Ad = dr[1].ToString();
                calısanlar.Soyad = dr[2].ToString();
                calısanlar.Departman = dr[3].ToString();
                calısanlar.Eposta = dr[4].ToString();
                sqllist.Add(calısanlar);
            }
            connection.Close();
            return sqllist;
        }
    }
}
