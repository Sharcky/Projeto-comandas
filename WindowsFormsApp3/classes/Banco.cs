using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql;


namespace WindowsFormsApp3.classes
{
    public static class Banco
    {
        public static MySqlCommand Abrir()
        {
            string strconn = @"server=127.0.0.1;user id=root;database=comandadb; SslMode = 0" ;
            MySqlConnection cn = new MySqlConnection(strconn);
            cn.Open();
            MySqlCommand comm = new MySqlCommand();
            comm.Connection = cn;
            return comm;

        }
       
        


    }
}
