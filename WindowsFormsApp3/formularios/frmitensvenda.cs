using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.classes;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp3.formularios
{
    public partial class frmitensvenda : Form
    {
        public frmitensvenda()
        {
            InitializeComponent();
        }

        private void Frmitensvenda_Load(object sender, EventArgs e)
        {

            //carregar combobox produto
            DataTable pt = new DataTable();
            classproduto prod = new classproduto();
            pt.Load(prod.ConsultarTodos());
            cmbproduto.DataSource = pt;
            cmbproduto.DisplayMember = "descricao";
            cmbproduto.ValueMember = "id";

            //carregar combobox venda

            DataTable vt = new DataTable();
            Classvenda vend = new Classvenda();
            vt.Load(vend.ConsultarTodos());
            cmbvenda.DataSource = vt;
            cmbvenda.DisplayMember = "id";
            cmbvenda.ValueMember = "id";

            //carregar combobox cliente

            DataTable dt = new DataTable();
            Classcliente p = new Classcliente();
            dt.Load(p.ConsultarTodos());
            cmbCliente.DataSource = dt;
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";

            //carregar combobox usuario

            DataTable usu = new DataTable();
            ClassUsuario u = new ClassUsuario();
            usu.Load(u.ConsultarTodos());
            cmbUsuario.DataSource = usu;
            cmbUsuario.DisplayMember = "nome";
            cmbUsuario.ValueMember = "id";

            //carregar combobox class venda convert

            DataTable rs = new DataTable();
            Classvenda vendp = new Classvenda();
            rs.Load(vendp.ConsultarTodos());
            cmbIdVendaP.DataSource = rs;
            cmbIdVendaP.DisplayMember = "id";
            cmbIdVendaP.ValueMember = "id";

            //carregar combobox itenscomanda convert

            DataTable ps = new DataTable();
            ClassComanda itencom = new ClassComanda();
            ps.Load(itencom.ConsultarTodos());
            cmbComandaP.DataSource = ps;
            cmbComandaP.DisplayMember = "id";
            cmbComandaP.ValueMember = "id";


        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            itens_venda c = new itens_venda();
            c.Venda.Id = Convert.ToInt32(cmbvenda.SelectedValue);
            c.Produto.Id = Convert.ToInt32(cmbproduto.SelectedValue);
            c.Quantidade = double.Parse(txtQuantidade.Text);
            c.Produto.Valor = double.Parse(txtvalorproduto.Text);
            c.Desconto = double.Parse(txtvalorproduto.Text);
            c.inserir();
            MessageBox.Show("comanda inserida com sucesso");
           
            txtQuantidade.Clear();
            txtvalorproduto.Clear();
            txtdesconto.Clear();
        }

        private void BtnLista_Click(object sender, EventArgs e)
        {
            itens_venda c = new itens_venda();
            DataTable dt = new DataTable();
            dt.Load(c.ConsultarTodos());
            dvglista.DataSource = dt;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {

            itenscomanda c = new itenscomanda();
            itens_venda v = new itens_venda();

            DataTable dt = new DataTable();
            c.Comanda.Id = int.Parse(cmbComandaP.Text);
            dt.Load(c.ConsultarTodosid());
            dvglista.DataSource = dt;
        }

        private void Btnalterar_Click(object sender, EventArgs e)
        {
            if (txtid2.Text != string.Empty && txtproduto2.Text != string.Empty && txtquantidade2.Text != string.Empty && txtvalorproduto2.Text != string.Empty && txtdesconto2.Text != string.Empty)
            {
                itens_venda c = new itens_venda();
                c.Venda.Id = int.Parse(txtid2.Text);
                c.Quantidade = double.Parse(txtquantidade2.Text);
                c.Produto.Valor = double.Parse(txtvalorproduto2.Text);
                c.Desconto = double.Parse(txtdesconto2.Text);


                if (c.alterar())
                {
                    MessageBox.Show("produto alterado com sucesso.");
                }
            }
        }

        private void Btnvendanova_Click(object sender, EventArgs e)
        {
            Classvenda c = new Classvenda();
            txtId.Text = c.Id.ToString();
            c.Id_cliente.Id = Convert.ToInt32(cmbCliente.SelectedValue);
            c.Desconto = Convert.ToDouble(txtdesconto3.Text);
            c.Id_usuario.Id = Convert.ToInt32(cmbUsuario.SelectedValue);
            c.Situacao = (txtSituacao.Text);
            c.inserir();
            MessageBox.Show("venda inserida com sucesso");
            txtId.Clear();
            txtdesconto3.Clear();
            txtSituacao.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            Classvenda c = new Classvenda();
            DataTable dt = new DataTable();
            dt.Load(c.ConsultarTodos());
            dvglista.DataSource = dt;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Classvenda c = new Classvenda();
            DataTable dt = new DataTable();
            c.ConsultarPorId(int.Parse(txtId.Text));
            txtdesconto3.Text = c.Desconto.ToString();
            txtData.Text = c.Data.ToString();
            txtSituacao.Text = c.Situacao.ToString();
            cmbCliente.Text = c.Id_cliente.Id.ToString();
            cmbUsuario.Text = c.Id_usuario.Id.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty && txtdesconto3.Text != string.Empty && txtSituacao.Text != string.Empty)
            {
                Classvenda c = new Classvenda();
                c.Id = int.Parse(txtId.Text);
                c.Desconto = Convert.ToDouble(txtdesconto3.Text);
                c.Situacao = txtSituacao.Text;


                if (c.alterar())
                {
                    MessageBox.Show("produto alterado com sucesso.");
                }
            }
        }

        private void BtnconsultaComanda_Click(object sender, EventArgs e)
        {
            itenscomanda c = new itenscomanda();
            itens_venda v = new itens_venda();

            DataTable dt = new DataTable();
            c.Comanda.Id = int.Parse(cmbComandaP.Text);
            dt.Load(c.ConsultarTodosid());
            dvglista.DataSource = dt;

            c.ConsultarPorId(int.Parse(cmbComandaP.Text));

            //foreach (MySqlDataReader item in c.ConsultarTodosid())
            //{
            //    v.Venda.Id = int.Parse(txtId.Text);
            //    v.Produto.Id = c.Produto.Id;
            //    v.Quantidade = c.Quantidade;
            //    v.Valor = c.Produto.Valor;
            //    v.Desconto = double.Parse(txtdesconto3.Text);


            //    v.inserir();                
            //}
            var dr = c.ConsultarTodosid();
            while (dr.Read())
            {
                v.Venda.Id = int.Parse(cmbIdVendaP.Text);
                v.Produto.Id = dr.GetInt32(1);
                v.Quantidade = dr.GetInt32(2);
                v.Valor = dr.GetDouble(3);
                v.Desconto = dr.GetDouble(4);
                v.inserir();
            }
                                                                                                     
        }

        private void Cmbproduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            classproduto prod = new classproduto();
            txtvalorproduto.Text = prod.Valor.ToString();

            
        }

        private void Cmbvenda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
