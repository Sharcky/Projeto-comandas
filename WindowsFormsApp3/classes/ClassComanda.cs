using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3.classes
{
    public class ClassComanda
    {
        private int id;
        private string numero;
        private string situacao;

       
        // propriedades
        public int Id { get => id; set => id = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Situacao { get => situacao; set => situacao = value; }

        // metodos construtores

        public ClassComanda()
        {
            
        }


        public ClassComanda(int id, string numero, string situacao)
        {
            this.id = id;
            this.numero = numero;
            this.situacao = situacao;
        }

        public ClassComanda(int id)
        {
            this.id = id;
          
        }


        // metodos construtor inserir 

        public void inserir()
        {
            var comm = Banco.Abrir();
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.CommandText = "sp_insert_comanda";
            comm.Parameters.Add("spid_comanda", MySqlDbType.VarChar).Value = id;
            comm.Parameters.Add("spnumero", MySqlDbType.VarChar).Value = numero;
            comm.Parameters.Add("spsituacao", MySqlDbType.VarChar).Value = situacao;
            id = Convert.ToInt32(comm.ExecuteScalar());
            comm.Connection.Close();

        }

        // metodo consultar por id

        public void ConsultarPorId(int id)
        {
            var comm = Banco.Abrir();

            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.CommandText = "sp_select_comanda";
            comm.Parameters.Add("spid_comanda", MySqlDbType.VarChar).Value = id;
            var dr = comm.ExecuteReader();
            while (dr.Read())
            {
                this.id = dr.GetInt32(0);
                this.numero = dr.GetString(1);
                this.situacao = dr.GetString(2);

            }
            comm.Connection.Close();
        }

        // metodo consultar todos 

        public MySqlDataReader ConsultarTodos()
        {
            var comm = Banco.Abrir();
            comm.CommandText = "select * from comandas";
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
                comm.CommandText = "sp_update_comanda";

                comm.Parameters.Add("spid_comanda", MySqlDbType.VarChar).Value = Id;
                comm.Parameters.Add("spnumero", MySqlDbType.VarChar).Value = numero;
                comm.Parameters.Add("spsituacao", MySqlDbType.VarChar).Value = situacao;
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
