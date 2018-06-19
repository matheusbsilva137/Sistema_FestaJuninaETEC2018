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
    public partial class frmVenda : Form
    {
        String id_prod, login_atend, username;
        int qtd_vend;
        public int pag = 1;
        int registro, linha = 0;
        int fim = 1;

        public frmVenda(String usuario, String login)
        {
            username = usuario;
            login_atend = login;
            InitializeComponent();
        }

        //consegue a conexao
        OleDbConnection conn = Conexao.obterConn();
        String _query;
        OleDbDataReader dr;

        public void obterProdutos()
        {
            _query = "Select id_prod , nome from Produto ORDER BY nome ASC";

                DataTable dtTabelas = new DataTable();

                //adaptador do banco
                OleDbDataAdapter da = new OleDbDataAdapter(_query, conn);

                //preenche o DataTable para o mesmo conseguir jogar as informações no cmb
                da.Fill(dtTabelas);

                //carrega as informacoes no combo
                cmb_Produtos.DataSource = dtTabelas;
                cmb_Produtos.DisplayMember = "nome";
                cmb_Produtos.ValueMember = "nome";
        }

        public void preco()
        {
            if (txb_qtd.Text != "")
            {
              //query com o comando sql puxando o preco do produto
                _query = "Select id_prod,qtd_vend,preco from Produto where nome like '" + Convert.ToString(cmb_Produtos.SelectedValue) + "'";

                //O dataCommand é criado e o dataReader recebe o resultado dele, além de começar a leitura
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                dr = _dataCommand.ExecuteReader();
                dr.Read();
               
                //pega o preco que o dataReader conseguiu, multiplica pela quantidade e depois joga na label
                double preco = Convert.ToDouble(dr["preco"]) * Convert.ToDouble(txb_qtd.Text);
                lbl_bd_preco.Text = "R$ " + String.Format("{0:n}", preco);
                
                //consegue o id do produto para uso na inserção
                id_prod = Convert.ToString(dr["id_prod"]);
                qtd_vend = Convert.ToInt16(dr["qtd_vend"]);

                dr.Close();
            }
            //Caso a txb ainda não tenha recebido algum valor
            else
            {
                lbl_bd_preco.Text = "R$ 0,00";
            }
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            obterProdutos();
            preco();
            txb_qtd.Text = "1";
        }

        private void txb_qtd_TextChanged(object sender, EventArgs e)
        {
            preco();
        }

        private void txb_qtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void cmb_Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            preco();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (txb_qtd.Text != "" && txb_qtd.Text != "0")
            {
                int qtd_atual = qtd_vend + Convert.ToInt16(txb_qtd.Text);

                _query = "INSERT INTO Venda(id_prod,login_atendente,qtd,horario) VALUES ('" + id_prod + "','" + login_atend + "','" + txb_qtd.Text + "','" + DateTime.Now.ToString("HH:mm:ss") + "')";
                String _query2 = "UPDATE Produto SET qtd_vend = '" + qtd_atual + "' where id_prod = " + id_prod;

                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    OleDbCommand _dataCommand2 = new OleDbCommand(_query2, conn);
                    _dataCommand2.ExecuteNonQuery();
                    MessageBox.Show("Venda Efetuada!", "Venda realizada!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    printDialog1.ShowDialog();
                    printDocument1.Print();   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(_query+ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                preco();
            }
            else
            {
                MessageBox.Show("Insira uma quantidade válida", "Quantidade inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_diminuir_Click(object sender, EventArgs e)
        {
            if (txb_qtd.Text != "0" && txb_qtd.Text != "1" && txb_qtd.Text != "")
            {
                int novo = Convert.ToInt16(txb_qtd.Text) - 1;
                txb_qtd.Text = Convert.ToString(novo);
            }
        }

        private void txb_qtd_Leave(object sender, EventArgs e)
        {
            if (txb_qtd.Text == "0" || txb_qtd.Text == "")
            {
                txb_qtd.Text = "1";
            }
        }

        private void btn_aumentar_Click(object sender, EventArgs e)
        {
            if (txb_qtd.Text == "")
            {
                txb_qtd.Text = "1";
            }
            else
            {
                int novo = Convert.ToInt16(txb_qtd.Text) + 1;
                txb_qtd.Text = Convert.ToString(novo);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            /*e.Graphics.DrawImage(Image.FromFile("logo_ete.JPG"), 50, 25);
            // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
            e.Graphics.DrawString("RELATÓRIO GERAL DE DISCIPLINAS", new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 300, 50);
            //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)
            */

            linha = 100;

            // cabeçalho de colunas
            e.Graphics.DrawString("Produto  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, linha);
            e.Graphics.DrawString("Quantidade   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 150, linha);
            e.Graphics.DrawString("Preço ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 250, linha);
            e.Graphics.DrawString("Atendente ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 350, linha);

            linha = 130;

            //while ((linha < 1075) & (registro != fim))
            //{
                // código
            e.Graphics.DrawString(Convert.ToString(cmb_Produtos.SelectedValue), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 50, linha);
                // descrição
                e.Graphics.DrawString(txb_qtd.Text, new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 150, linha);
                // sigla
                e.Graphics.DrawString(lbl_bd_preco.Text, new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 250, linha);
                e.Graphics.DrawString(username, new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 350, linha);

                //registro += 1;   // incrementando a variável contadora de registros

                //linha += 20; // incrementando a variável para pular linha
            //}

            //***************************** 
            //imprime o rodapé do relatório 
            //***************************** 
            /*
            e.Graphics.DrawString("Total de Registros: " + registro.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 550, 1100);
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 1), 50, 1115, 800, 1115);
            e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 50, 1120);
            e.Graphics.DrawString("Pág: " + pag.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 550, 1120);
            
            pag += 1;  // reajustando contadores de pag

            // trocando de página
            if ((pag > 1) & (registro < fim))
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            */
        }
    }
}
