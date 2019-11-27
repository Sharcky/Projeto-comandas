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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            
            classproduto c = new classproduto();
            txtId.Text = c.Id.ToString();

            c.Quantidade = double.Parse(txtQuantidade.Text);
            c.Cod_bar = txtcodbar.Text;
            c.Valor = double.Parse(txtvalor.Text);
            c.Descricao = txtdescricao.Text;
            c.inserir();
            MessageBox.Show("produto inserido com sucesso");
            txtId.Clear();
            txtQuantidade.Clear();
            txtcodbar.Clear();
            txtvalor.Clear();
            txtdescricao.Clear();
        }

        private void BtnLista_Click(object sender, EventArgs e)
        {
            classproduto c = new classproduto();
            DataTable dt = new DataTable();
            dt.Load(c.ConsultarTodos());
            dvgLista.DataSource = dt;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            classproduto c = new classproduto();
            c.ConsultarPorId(int.Parse(txtId2.Text));
            txtQuantidade2.Text = c.Quantidade.ToString();
            txtcodbar2.Text = c.Cod_bar;
            txtvalor2.Text = c.Valor.ToString();
            txtdescricao2.Text = c.Descricao;
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnAlterar_Click_1(object sender, EventArgs e)
        {
            if (txtId2.Text != string.Empty && txtQuantidade2.Text  != string.Empty && txtcodbar2.Text != string.Empty && txtvalor2.Text != string.Empty && txtdescricao2.Text != string.Empty)
            {
                classproduto c = new classproduto();
                c.Id = int.Parse(txtId2.Text);
                c.Quantidade = double.Parse(txtQuantidade2.Text);
                c.Cod_bar = txtcodbar2.Text;
                c.Valor = double.Parse(txtvalor2.Text);
                c.Descricao = txtdescricao2.Text;
                if (c.Alterar())
                {
                    MessageBox.Show("usuario alterado com sucesso.");
                }

            }

        }
    }
}
