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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            Classcliente c = new Classcliente();
            c.Nome = txtNome.Text;
            c.inserir();
            txtId.Text = c.Id.ToString();
            MessageBox.Show("cliente inserido com sucesso");
            txtId.Clear();
            txtNome.Clear();    

           

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            Classcliente c = new Classcliente();
            c.ConsultarPorId(int.Parse(txtId.Text));
            txtNome2.Text = c.Nome;
        }

        private void BtnAltera_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty && txtNome2.Text != string.Empty)
            {
                Classcliente c = new Classcliente();
                c.Id = int.Parse(txtId.Text);
                c.Nome = txtNome2.Text;
                if (c.alterar())
                {
                    MessageBox.Show("usuario alterado com sucesso.");
                }

            }
        }

        private void BtnLista_Click(object sender, EventArgs e)
        {
            Classcliente c = new Classcliente();
            DataTable dt = new DataTable();
            dt.Load(c.ConsultarTodos());
            dvgLista.DataSource = dt;
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
