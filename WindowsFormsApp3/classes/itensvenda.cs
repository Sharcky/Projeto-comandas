using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3.classes
{
    class itens_venda
    {
        private Classvenda venda;
        private classproduto produto;
        private double quantidade;
        private double valor;
        private double desconto;
       



        //propriedades

        public Classvenda Venda { get => venda; set => venda = value; }
        public classproduto Produto { get => produto; set => produto = value; }
        public double Quantidade { get => quantidade; set => quantidade = value; }
        public double Valor { get => valor; set => valor = value; }
        public double Desconto { get => desconto; set => desconto = value; }
       





        //metodos construtores

        public itens_venda()
        {
            Produto = new classproduto();
            Venda = new Classvenda();
           
        }

       
        public itens_venda(Classvenda venda)
        {
            this.Venda = venda;

        }

        public itens_venda(Classvenda venda, classproduto produto, double quantidade, double valor, double desconto)
        {
            this.venda = venda;
            this.produto = produto;
            this.quantidade = quantidade;
            this.valor = valor;
            this.desconto = desconto;
            
        }




        // metodo inserir

        public void inserir()
        {
            var comm = Banco.Abrir();
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.CommandText = "sp_insert_itensvenda";
            comm.Parameters.Add("spid_venda", MySqlDbType.Int32).Value = Venda.Id;
            comm.Parameters.Add("spid_produto", MySqlDbType.Int32).Value = Produto.Id;
            comm.Parameters.Add("spquantidade", MySqlDbType.Decimal).Value = Quantidade;
            comm.Parameters.Add("spvalorproduto", MySqlDbType.Decimal).Value = Valor;
            comm.Parameters.Add("spdesconto", MySqlDbType.Decimal).Value = Desconto;
            Venda.Id = Convert.ToInt32(comm.ExecuteScalar());
            comm.Parameters.Clear();
            comm.Connection.Close();
        }

        // metodo consultar por id 
        public void ConsultarPorId(int _id)
        {
            var comm = Banco.Abrir();

            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.CommandText = "sp_select_itensvenda";
            comm.Parameters.Add("spid_venda", MySqlDbType.Int32).Value = _id;
            var dr = comm.ExecuteReader();
            while (dr.Read())
            {
                this.Venda.Id = dr.GetInt32(0);
                this.Produto.Id = dr.GetInt32(1);
                this.Quantidade = dr.GetDouble(2);
                this.Produto.Valor = dr.GetDouble(3);
                this.Desconto = dr.GetDouble(4);
            }
            comm.Connection.Close();

        }

        public MySqlDataReader ConsultarTodosid()
        {
            var comm = Banco.Abrir();
            comm.CommandText = "select * from itens_venda where id_comanda = " + this.produto.Id;
            var dr = comm.ExecuteReader();
            return dr;
        }

        // metodo consultar todos

        public MySqlDataReader ConsultarTodos()
        {
            var comm = Banco.Abrir();
            comm.CommandText = "select * from itens_venda";
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
                comm.CommandText = "sp_update_itensvenda";
                comm.Parameters.Add("spid_venda", MySqlDbType.Int32).Value = Venda.Id;
                comm.Parameters.Add("spquantidade", MySqlDbType.VarChar).Value = Quantidade;
                comm.Parameters.Add("spvalorproduto", MySqlDbType.VarChar).Value = Produto.Valor;
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
