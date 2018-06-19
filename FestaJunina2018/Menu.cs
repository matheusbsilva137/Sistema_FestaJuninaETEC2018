using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FestaJunina2018
{
    public partial class frmMenu : Form
    {
        String username, login_atend;

        public frmMenu(String usuario, String login)
        {
            username = usuario;
            login_atend = login;
            InitializeComponent();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProd cProd = new frmCadastroProd();
            cProd.MdiParent = this;
            cProd.Show();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void consultaDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsVendas fcv = new frmConsVendas();
            fcv.MdiParent = this;
            fcv.Show();
        }

        private void cadastroDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenda fv = new frmVenda(username, login_atend);
            fv.MdiParent = this;
            fv.Show();
        }

        private void cadastroDeAtendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroAtendente cAtend = new frmCadastroAtendente();
            cAtend.MdiParent = this;
            cAtend.Show();
        }

        private void consultaDeAtendentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsAtend consAtend = new frmConsAtend();
            consAtend.MdiParent = this;
            consAtend.Show();
        }
    }
}
