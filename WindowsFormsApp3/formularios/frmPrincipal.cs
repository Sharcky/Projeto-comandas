using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.formularios;

namespace WindowsFormsApp3
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();

        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProduto frmProduto = new frmProduto();
            frmProduto.MdiParent = this;
            frmProduto.Show();

        }

        private void InserirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ComandasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcomanda frmComanda = new frmcomanda();
            frmComanda.MdiParent = this;
            frmComanda.Show();

        }

        private void ItenscomandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmitenscomanda itenscomanda = new frmitenscomanda();
            itenscomanda.MdiParent = this;
            itenscomanda.Show();
        }

        private void ItensvendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmitensvenda itensvenda = new frmitensvenda();
            itensvenda.MdiParent = this;
            itensvenda.Show();
        }
    }
}
