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
    public partial class frmConsVendas : Form
    {
        OleDbConnection conn = Conexao.obterConn();
        OleDbDataReader dr_vend, dr_produtos;
        BindingSource bs_vend = new BindingSource();
        String _query, _queryProd;
        double preco, qtd;
        double total = 0;

        public frmConsVendas()
        {
            InitializeComponent();
        }

        public void carregar_grid()
        {
            total = 0;
            _query = "Select * from Venda";
            _queryProd = "Select qtd_vend, preco from Produto";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_vend = _dataCommand.ExecuteReader();

            OleDbCommand _dataCommandProd = new OleDbCommand(_queryProd, conn);

            if (dr_vend.HasRows == true)
            {
                bs_vend.DataSource = dr_vend;
                dgvVendas.DataSource = bs_vend;
                igualar_text();
                
            }
            else
            {
                MessageBox.Show("Não há vendas cadastradas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            dr_vend.Close();

            OleDbCommand _dataCommandProduto = new OleDbCommand(_queryProd, conn);
            dr_produtos = _dataCommandProduto.ExecuteReader();

            while (dr_produtos.Read())
            {
                qtd = Convert.ToDouble(dr_produtos["qtd_vend"]);
                preco = Convert.ToDouble(dr_produtos["preco"]);
                total += qtd * preco;
            }
            lblNumArrecad.Text = String.Format("{0:C2}", Convert.ToDouble(total));
            lblNumArrecadAPM.Text = String.Format("{0:C2}", Convert.ToDouble(total*0.3)); ;
        }

        private void igualar_text()
        {
            lblNumCod.DataBindings.Add("Text", bs_vend, "id_venda");
            lblNumCod.DataBindings.Clear();
            txbHorario.DataBindings.Add("Text", bs_vend, "horario");
            txbHorario.DataBindings.Clear();
            txbQuant.DataBindings.Add("Text", bs_vend, "qtd");
            txbQuant.DataBindings.Clear();
            txbIdProd.DataBindings.Add("Text", bs_vend, "id_prod");
            txbIdProd.DataBindings.Clear();
            txbLogin.DataBindings.Add("Text", bs_vend, "login_atendente");
            txbLogin.DataBindings.Clear();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void btnExc_Click(object sender, EventArgs e)
        {
            
            _query = "delete from Venda where id_venda like '" + lblNumCod.Text + "'";
            _queryProd = "update Produto set qtd_vend = qtd_vend - " + txbQuant.Text + " where id_prod like '" + txbIdProd.Text + "'";
            
            try
            {
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                _dataCommand.ExecuteNonQuery();

                OleDbCommand _dataCommandProd = new OleDbCommand(_queryProd, conn);
                _dataCommandProd.ExecuteReader();

                carregar_grid();
                MessageBox.Show("Excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com a Exclusão!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void frmConsVendas_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void dgvVendas_Click(object sender, EventArgs e)
        {
            igualar_text();
        }

        private void dgvVendas_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void btnUlt_Click(object sender, EventArgs e)
        {
            bs_vend.MoveLast();
            igualar_text();
        }

        private void btnPrim_Click(object sender, EventArgs e)
        {
            bs_vend.MoveFirst();
            igualar_text();
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            if (bs_vend.Count == bs_vend.Position + 1)
            {
                MessageBox.Show("Fim de arquivo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bs_vend.MoveNext();
                igualar_text();
            }
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            if (bs_vend.Position == 0)
            {
                MessageBox.Show("Início de arquivo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bs_vend.MovePrevious();
                igualar_text();
            }
        }
    }
}