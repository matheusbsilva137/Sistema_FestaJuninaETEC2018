using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FestaJunina2018
{
    public partial class frmCadastroProd : Form
    {
        OleDbConnection conn = Conexao.obterConn();
        OleDbDataReader dr_prod;
        BindingSource bs_prod = new BindingSource();
        String _query;

        public frmCadastroProd()
        {
            InitializeComponent();
        }

        public void carregar_grid(){
            _query = "Select * from Produto";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_prod = _dataCommand.ExecuteReader();
            if (dr_prod.HasRows == true)
            {
                bs_prod.DataSource = dr_prod;
                dgvProd.DataSource = bs_prod;
                igualar_text();
            }
            else
            {
                MessageBox.Show("Não há produtos cadastrados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void igualar_text()
        {
            lblNumCod.DataBindings.Add("Text", bs_prod, "id_prod");
            lblNumCod.DataBindings.Clear();
            txbNome.DataBindings.Add("Text", bs_prod, "nome");
            txbNome.DataBindings.Clear();
            txbPreco.DataBindings.Add("Text", bs_prod, "preco");
            txbPreco.DataBindings.Clear();
            txbQuant.DataBindings.Add("Text", bs_prod, "qtd_vend");
            txbQuant.DataBindings.Clear();
        }

        private void frmCadastroProd_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void dgvProd_Click(object sender, EventArgs e)
        {
            igualar_text();
        }

        private void dgvProd_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            _query = "Select * from Produto where nome like '" + txbPesquisa.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_prod = _dataCommand.ExecuteReader();

            if (dr_prod.HasRows == true)
            {
                bs_prod.DataSource = dr_prod;
            }
            else
            {
                MessageBox.Show("Não há produtos cadastrado com este nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPesquisa.Text = "";
            }

        }

        private void btnPrim_Click(object sender, EventArgs e)
        {
            bs_prod.MoveFirst();
            igualar_text();
        }

        private void btnUlt_Click(object sender, EventArgs e)
        {
            bs_prod.MoveLast();
            igualar_text();
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            if (bs_prod.Count == bs_prod.Position + 1)
            {
                MessageBox.Show("Fim de arquivo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bs_prod.MoveNext();
                igualar_text();
            }
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            if (bs_prod.Position == 0)
            {
                MessageBox.Show("Início de arquivo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bs_prod.MovePrevious();
                igualar_text();
            }
        }

        private void limpar()
        {
            lblNumCod.Text = "";
            txbNome.Clear();
            txbPreco.Clear();
            txbQuant.Clear();
        }

        private void btnLimparInf_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limpar();
            txbNome.Focus();
        }

        private void frmCadastroProd_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conexao.fecharConn();
        }

        private bool valida()
        {
            bool erro = true;
            if(txbNome.Text == ""){
                MessageBox.Show("Nome inválido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbNome.Focus();
            }
            else if (txbPreco.Text == "")
            {
                MessageBox.Show("Preço inválido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPreco.Focus();
            }
            else
            {
                erro = false;
            }

            if(txbQuant.Text == ""){
                txbQuant.Text = "0";
            }

            return erro;
        }
        private void btnExc_Click(object sender, EventArgs e)
        {
            _query = "delete from Produto where id_prod like '" + lblNumCod.Text + "'";
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

        private void btnInc_Click(object sender, EventArgs e)
        {
            bool teste = valida();
            if(teste == false){
                _query = "Insert into Produto (nome,preco,qtd_vend) Values ";
                _query += "('" + txbNome.Text + "','" + txbPreco.Text + "','" + txbQuant.Text + "')";
                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    carregar_grid();
                    MessageBox.Show("Produto registrado com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas com o registro!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            bool teste = valida();
            if (teste == false)
            {
                _query = "Update Produto set nome =  '" + txbNome.Text + "',";
                _query += "preco = '" + txbPreco.Text + "',"; ;
                _query += "qtd_vend = '"+txbQuant.Text+"' where id_prod like '"+lblNumCod.Text+"';";
                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    carregar_grid();
                    MessageBox.Show("Produto alterado com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problemas com a alteração!"+ex, "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            carregar_grid();
            igualar_text();
        }
    }
}
