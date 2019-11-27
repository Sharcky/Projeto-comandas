using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3.classes
{
    public class Classcliente
    {


        private int id;
        private string nome;

       //propriedades da classe

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }

        //metodos contrutores da classe


        public Classcliente()
        {
          
        }



        public Classcliente(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }


        public Classcliente(int id)
        {
            this.id = id;
        }

        //criar metodo inserir

        public void inserir()
        {
            var comm = Banco.Abrir();
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.CommandText = "sp_insert_cliente";
            comm.Parameters.Add("spnome", MySqlDbType.VarChar).Value = Nome;
            comm.Parameters.Add("spid_cliente", MySqlDbType.Int32).Value = id;
            id = Convert.ToInt32(comm.ExecuteScalar());
            comm.Connection.Close();

        }

        //criar metodo consultar por id

        public void ConsultarPorId(int id)
        {
            var comm = Banco.Abrir();

            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.CommandText = "sp_select_cliente";
            comm.Parameters.Add("spid_cliente", MySqlDbType.Int32).Value = id;
            var dr = comm.ExecuteReader();
            while (dr.Read())
            {
                this.id = dr.GetInt32(0);
                this.nome = dr.GetString(1);
            }
            comm.Connection.Close();
        }


        //criar metodo consultar todos

        public MySqlDataReader ConsultarTodos()
        {
            var comm = Banco.Abrir();
            comm.CommandText = "select * from clientes";
            var dr = comm.ExecuteReader();
            return dr;
        }
        // metodo construtor altera usuario
        public bool alterar()
        {
            bool alterado = false;
            try
            {
                var comm = Banco.Abrir();
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_update_cliente";

                comm.Parameters.Add("spnome", MySqlDbType.VarChar).Value = nome;
                comm.Parameters.Add("spid_cliente", MySqlDbType.Int32).Value = id;
                comm.ExecuteNonQuery();
                comm.Connection.Close();

                alterado = true;


            }
            catch (Exception)
            {

                throw;
            }

            return alterado;
            
    

        }






    }
}
