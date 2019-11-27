using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3.classes
{
    public class itenscomanda
    {
        private ClassComanda comanda;
        private classproduto produto;
        private double quantidade;
        private double desconto;

        




        //propriedades

        public ClassComanda Comanda { get => comanda; set => comanda = value; }
        public classproduto Produto { get => produto; set => produto = value; }
        public double Quantidade { get => quantidade; set => quantidade = value; }
       
        public double Desconto { get => desconto; set => desconto = value; }


        //metodo construtor

        public itenscomanda()
        {
             comanda = new ClassComanda();
             produto = new classproduto();
        }



        public itenscomanda(ClassComanda comanda, classproduto produto, double quantidade, double desconto)
        {
            this.comanda = comanda;
            this.produto = produto;
            this.quantidade = quantidade;
           
            this.desconto = desconto;
        }

        public itenscomanda(ClassComanda comanda)
        {
            this.comanda = comanda;

        }




        //metodo inserir

        public void inserir()
        {
            var comm = Banco.Abrir();
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.CommandText = "sp_insert_itenscomanda";
            comm.Parameters.Add("spid_comanda", MySqlDbType.Int32).Value = Comanda.Id;
            comm.Parameters.Add("spid_produto", MySqlDbType.Int32).Value = Produto.Id;
            comm.Parameters.Add("spquantidade", MySqlDbType.Decimal).Value = Quantidade;
            comm.Parameters.Add("spvalorproduto", MySqlDbType.Decimal).Value = produto.Valor;
            comm.Parameters.Add("spdesconto", MySqlDbType.Decimal).Value = Desconto;
            Comanda.Id = Convert.ToInt32(comm.ExecuteScalar());
            comm.Connection.Close();

        }

        // metodo consultar por id 

        public void ConsultarPorId(int _id)
        {
            var comm = Banco.Abrir();

            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.CommandText = "sp_select_itenscomanda";
            comm.Parameters.Add("spid_comada", MySqlDbType.Int32).Value = _id;
            var dr = comm.ExecuteReader();
            while (dr.Read())
            {
                this.comanda.Id = dr.GetInt32(0);
                this.produto.Id = dr.GetInt32(1);
                this.Quantidade = dr.GetDouble(2);
                this.produto.Valor = dr.GetDouble(3);
                this.Desconto = dr.GetDouble(4);
            }
            comm.Connection.Close();

        }


        // consultar todos 

        public MySqlDataReader ConsultarTodos()
        {
            var comm = Banco.Abrir();
            comm.CommandText = "select * from itens_comada";
            var dr = comm.ExecuteReader();
            return dr;
        }

        public MySqlDataReader ConsultarTodosid()
        {
            var comm = Banco.Abrir();
            comm.CommandText = "select * from itens_comada where id_comanda = " + this.Comanda.Id;
            var dr = comm.ExecuteReader();
            return dr;
        }


        // metodo alterar

        public bool alterar()
        {
            bool alterado = false;
            try
            {
            
                var comm = Banco.Abrir();
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.CommandText = "sp_update_itenscomanda";
                comm.Parameters.Add("spid_comanda", MySqlDbType.Int32).Value = comanda.Id;
                comm.Parameters.Add("spquantidade", MySqlDbType.VarChar).Value = Quantidade;
                comm.Parameters.Add("spvalorproduto", MySqlDbType.VarChar).Value = produto.Valor;
                comm.Parameters.Add("spdesconto", MySqlDbType.VarChar).Value = Desconto;
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
