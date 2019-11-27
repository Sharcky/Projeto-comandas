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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }
        //botao inserir usuario
        private void BtnInserir_Click(object sender, EventArgs e)
        {
            ClassUsuario c = new ClassUsuario();
            c.Nome = txtNome.Text;
            c.inserir();
            txtId.Text = c.Id.ToString();
            MessageBox.Show("usario inserido com sucesso");
            txtId.Clear();
            txtNome.Clear();
        }
        // botao alterar usuario
        private void BtnAltera_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty && txtNome2.Text != string.Empty)
            {
                ClassUsuario c = new ClassUsuario();
                c.Id = int.Parse(txtId.Text);
                c.Nome = txtNome2.Text;
                if (c.alterar())
                {
                    MessageBox.Show("usuario alterado com sucesso.");
                }

            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ClassUsuario c = new ClassUsuario();
            c.ConsultarPorId(int.Parse(txtId.Text));
            txtNome2.Text = c.Nome;
        }

        private void BtnLista_Click(object sender, EventArgs e)
        {
            ClassUsuario c = new ClassUsuario();
            DataTable dt = new DataTable();
            dt.Load(c.ConsultarTodos());
            dvgLista.DataSource = dt;
        }
    }    
}
