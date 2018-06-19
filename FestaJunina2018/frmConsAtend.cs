using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FestaJunina2018
{
    public partial class frmConsAtend : Form
    {
        OleDbConnection conn = Conexao.obterConn();
        OleDbDataReader dr_atend;
        BindingSource bs_atend = new BindingSource();
        String _query;

        public frmConsAtend()
        {
            InitializeComponent();
        }

        public void carregar_grid()
        {
            _query = "Select * from Atendente";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_atend = _dataCommand.ExecuteReader();
            if (dr_atend.HasRows == true)
            {
                bs_atend.DataSource = dr_atend;
                dgvAtend.DataSource = bs_atend;
                igualar_text();
            }
            else
            {
                MessageBox.Show("Não há atendentes cadastrados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void igualar_text()
        {
            txbNome.DataBindings.Add("Text", bs_atend, "nome");
            txbNome.DataBindings.Clear();
            txbLogin.DataBindings.Add("Text", bs_atend, "login_atendente");
            txbLogin.DataBindings.Clear();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void frmConsAtend_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void dgvAtend_Click(object sender, EventArgs e)
        {
            igualar_text();
        }

        private void dgvAtend_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void btnUlt_Click(object sender, EventArgs e)
        {
            bs_atend.MoveLast();
            igualar_text();
        }

        private void btnPrim_Click(object sender, EventArgs e)
        {
            bs_atend.MoveFirst();
            igualar_text();
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            if (bs_atend.Position == 0)
            {
                MessageBox.Show("Início de arquivo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bs_atend.MovePrevious();
                igualar_text();
            }
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            if (bs_atend.Count == bs_atend.Position + 1)
            {
                MessageBox.Show("Fim de arquivo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bs_atend.MoveNext();
                igualar_text();
            }
        }

        private void btnExc_Click(object sender, EventArgs e)
        {
            _query = "delete from Atendente where login_atendente like '" + txbLogin.Text + "'";
            try
            {
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                _dataCommand.ExecuteNonQuery();
                carregar_grid();
                MessageBox.Show("Excluido com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com a Exclusão!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            _query = "Select * from Atendente where nome like '" + txbNome.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_atend = _dataCommand.ExecuteReader();

            if (dr_atend.HasRows == true)
            {
                bs_atend.DataSource = bs_atend;
            }
            else
            {
                MessageBox.Show("Não há produtos cadastrado com este nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPesquisa.Text = "";
            }
        }
    }
}
