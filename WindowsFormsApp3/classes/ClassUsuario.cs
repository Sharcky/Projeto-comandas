using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3.classes
{
    public class ClassUsuario
    {

        private int id;
        private string nome;

        // propriedades
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }


        // metodos construtores 
        public ClassUsuario()
        {

        }



        public ClassUsuario(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }


        public ClassUsuario(int id)
        {
            this.id = id;

        }


        // metodo construtor inserir
        public void inserir()
        {
            var comm = Banco.Abrir();
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.CommandText = "sp_insert_usuario";
            comm.Parameters.Add("spnome", MySqlDbType.VarChar).Value = Nome;
            comm.Parameters.Add("spid_usuario", MySqlDbType.Int32).Value = id;
            id = Convert.ToInt32(comm.ExecuteScalar());
            comm.Connection.Close();

        }

        // metodo construtor consultar por id
        public void ConsultarPorId(int id)
        {
            var comm = Banco.Abrir();

            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.CommandText = "sp_select_usuario";
            comm.Parameters.Add("spid_usuario", MySqlDbType.Int32).Value = id;
            var dr = comm.ExecuteReader();
            while (dr.Read())
            {
                this.id = dr.GetInt32(0);
                this.nome = dr.GetString(1);
            }
            comm.Connection.Close();
        }

        // metodo construtor consultar todos

        public MySqlDataReader ConsultarTodos()
        {
            var comm = Banco.Abrir();
            comm.CommandText = "select * from usuarios";
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
                comm.CommandText = "sp_update_usuario";

                comm.Parameters.Add("spnome", MySqlDbType.VarChar).Value = nome;
                comm.Parameters.Add("spid_usuario", MySqlDbType.Int32).Value = id;
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
