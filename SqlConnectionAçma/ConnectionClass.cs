using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlConnectionAçma
{
    class ConnectionClass
    {
        public string server = @"MUSTAFA1\SQLEXPRESS";
        public string user = "admin";
        public string sifre = "admin";
        public string database = "Ak_Win";
        public SqlConnection BaglantiAcma()
        {
            SqlConnection baglanti = new SqlConnection();

            baglanti.ConnectionString = @"server=" + server + "; user=" + user + "; pwd=" + sifre + "; database=" + database + "";

            baglanti.Open();

            return baglanti;




        }
    }
}
