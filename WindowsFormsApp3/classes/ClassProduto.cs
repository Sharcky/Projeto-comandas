using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3.classes
{
    public class classproduto
    {
        private int id;
        private string descricao;
        private double valor;
        private string cod_bar;
        private double quantidade;

       



        // proprioedades

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Cod_bar { get => cod_bar; set => cod_bar = value; }
        public double Quantidade { get => quantidade; set => quantidade = value; }

        //metodos construtores


        public classproduto()
        {
          
        }




        public classproduto(int id, string descricao, double valor, string cod_bar, double quantidade)
        {
            this.id = id;
            this.descricao = descricao;
            this.valor = valor;
            this.cod_bar = cod_bar;
            this.quantidade = quantidade;
        }


        public classproduto(int id)
        {
            this.id = id;
           
        }



        // metodo inserir

        public void inserir()
        {
            var comm = Banco.Abrir();
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.CommandText = "sp_insert_produto";
            comm.Parameters.Add("spid_produto", MySqlDbType.VarChar).Value = Id;
            comm.Parameters.Add("spdescricao", MySqlDbType.VarChar).Value = Descricao;
            comm.Parameters.Add("spvalor", MySqlDbType.Decimal).Value = Valor;
            comm.Parameters.Add("spcod_bar", MySqlDbType.VarChar).Value = Cod_bar;
            comm.Parameters.Add("spquantidade", MySqlDbType.Decimal).Value = Quantidade;
            id = Convert.ToInt32(comm.ExecuteScalar());
            comm.Connection.Close();

        }


        // metodo consultar por id

        public void ConsultarPorId(int id)
        {
            var comm = Banco.Abrir();

            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.CommandText = "sp_select_produto";
            comm.Parameters.Add("spid_produto", MySqlDbType.VarChar).Value = id;
            var dr = comm.ExecuteReader();
            while (dr.Read())
            {
                this.id = dr.GetInt32(0);
                this.descricao = dr.GetString(1);
                this.valor = dr.GetDouble(2);
                this.cod_bar = dr.GetString(3);
                this.quantidade = dr.GetDouble(4);
            }
            comm.Connection.Close();
        }

        // metodo consultar todos

        public MySqlDataReader ConsultarTodos()
        {
            var comm = Banco.Abrir();
            comm.CommandText = "select * from produtos";
            var dr = comm.ExecuteReader();
            return dr;
        }



     





        //metodo construtor alterar produto

        public bool Alterar()
        {
            bool Alterado = false;
            try
            {
                var comm = Banco.Abrir();
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_update_produto";

                comm.Parameters.Add("spdescricao", MySqlDbType.VarChar).Value = descricao;
                comm.Parameters.Add("spid_produto", MySqlDbType.VarChar).Value = id;
                comm.Parameters.Add("spvalor", MySqlDbType.Decimal).Value = valor;
                comm.Parameters.Add("spcod_bar", MySqlDbType.VarChar).Value = cod_bar;
                comm.Parameters.Add("spquantidade", MySqlDbType.Decimal).Value = quantidade;
                comm.ExecuteNonQuery();
                comm.Connection.Close();

                Alterado = true;


            }
            catch (Exception)
            {

                throw;
            }

            return Alterado;



        }

        
    }
}
