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
    public partial class frmcomanda : Form
    {
        public frmcomanda()
        {
            InitializeComponent();
        }

        private void Frmcomanda_Load(object sender, EventArgs e)
        {

        }

        private void TxtNome2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            ClassComanda c = new ClassComanda();
            txtId.Text = c.Id.ToString();
            c.Numero = txtComanda.Text;
            c.Situacao = txtsituacao.Text;
            c.inserir();
            MessageBox.Show("comanda inserida com sucesso");
            txtId.Clear();
            txtComanda.Clear();
            txtsituacao.Clear();
        }

        private void BtnLista_Click(object sender, EventArgs e)
        {
            ClassComanda c = new ClassComanda();
            DataTable dt = new DataTable();
            dt.Load(c.ConsultarTodos());
            dvgLista.DataSource = dt;
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ClassComanda c = new ClassComanda();
            c.ConsultarPorId(int.Parse(txtId.Text));
            txtcomanda2.Text = c.Numero;
            txtsituacao2.Text = c.Situacao;
            
        }

        private void BtnAltera_Click(object sender, EventArgs e)
        {

            if (txtId.Text != string.Empty && txtcomanda2.Text != string.Empty && txtsituacao2.Text != String.Empty)
            {
                ClassComanda c = new ClassComanda();
                c.Id = int.Parse(txtId.Text);
                c.Numero = txtcomanda2.Text;
                c.Situacao = txtsituacao2.Text;
                if (c.alterar())
                {
                    MessageBox.Show("usuario alterado com sucesso.");
                }
            }
        }
    }
}
