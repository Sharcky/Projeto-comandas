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


namespace WindowsFormsApp3.formularios
{
    public partial class frmitenscomanda : Form
    {
        public frmitenscomanda()
        {
            InitializeComponent();
        }

        
        
        private void Frmitenscomanda_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ClassComanda p = new ClassComanda();
            dt.Load(p.ConsultarTodos());
            cmbcomanda.DataSource = dt;
            cmbcomanda.DisplayMember = "numero";
            cmbcomanda.ValueMember = "id";


            DataTable pt = new DataTable();
            classproduto prod = new classproduto();
            pt.Load(prod.ConsultarTodos());
            cmbproduto.DataSource = pt;
            cmbproduto.DisplayMember = "descricao";
            cmbproduto.ValueMember = "id";

            
            cmbproduto.Text = "";
            
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            itenscomanda c = new itenscomanda();
            c.Comanda.Id = Convert.ToInt32(cmbcomanda.SelectedValue);
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
            itenscomanda c = new itenscomanda();
            DataTable dt = new DataTable();
            dt.Load(c.ConsultarTodos());
            dvglista.DataSource = dt;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            itenscomanda c = new itenscomanda();
            c.ConsultarPorId(int.Parse(txtcomanda2.Text));
            txtproduto2.Text = c.Produto.Id.ToString();
            txtquantidade2.Text = c.Quantidade.ToString();
            txtvalorproduto2.Text = c.Produto.Valor.ToString();
            txtdesconto2.Text = c.Desconto.ToString();

            DataTable dt = new DataTable();
            c.Comanda.Id = int.Parse(txtcomanda2.Text);
            dt.Load(c.ConsultarTodosid());
            dvglista.DataSource = dt;

            c.ConsultarPorId(int.Parse(txtcomanda2.Text));
        }

        private void Btnalterar_Click(object sender, EventArgs e)
        {
            if (txtcomanda2.Text != string.Empty && txtproduto2.Text != string.Empty && txtquantidade2.Text != string.Empty && txtvalorproduto2.Text != string.Empty && txtdesconto2.Text != string.Empty)
            {
                itenscomanda c = new itenscomanda();
                c.Comanda.Id = int.Parse(txtcomanda2.Text);
                c.Quantidade = double.Parse(txtquantidade2.Text);
                c.Produto.Valor = double.Parse(txtvalorproduto2.Text);
                c.Desconto = double.Parse(txtdesconto2.Text);


                if (c.alterar())
                {
                    MessageBox.Show("produto alterado com sucesso.");
                }
            }
        }

        private void Cmbproduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            frmitensvenda frmVenda = new frmitensvenda();
            frmVenda.Show();

            this.Close();
        }

        private void Cmbcomanda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txtcomanda2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
