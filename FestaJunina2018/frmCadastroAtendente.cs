using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Security.Cryptography;

namespace FestaJunina2018
{
    public partial class frmCadastroAtendente : Form
    {
        public frmCadastroAtendente()
        {
            InitializeComponent();
        }
            OleDbConnection conn = Conexao.obterConn();
            String _query;

            public static string GerarMD5(string senha)
            {
                MD5 hash = MD5.Create();

                //converte a string da senha para um array de bytes, que é o como md5 trabalha
                byte[] data = hash.ComputeHash(Encoding.UTF8.GetBytes(senha));

                //recompor a String
                StringBuilder sBuilder = new StringBuilder();

                //byte -> String em hex
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                return sBuilder.ToString();
            }
            String senha, confSenha;
            public bool valida()
            {
                bool erro = true;

                senha = GerarMD5(txbSenha.Text);
                confSenha = GerarMD5(txbConfSenha.Text);

                if (txtNome.Text == "")
                {
                    MessageBox.Show("Nome inválido. Redigite!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome.Focus();
                }else if (txtUsu.Text == "")
                {
                    MessageBox.Show("Usuário inválido. Redigite!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsu.Focus();
                }else if (txbSenha.Text == "" || txbConfSenha.Text == "")
                {
                    MessageBox.Show("Senha inválida. Redigite!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txbSenha.Focus();
                }else if (senha != confSenha)
                {
                    MessageBox.Show("Senhas inválida. Redigite!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txbSenha.Focus();
                }
                else
                {
                    erro = false;
                }
                return erro;
            }
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            bool teste;
            teste = valida();
            if (teste == false)
            {
                _query = "Insert into Atendente (login_atendente, nome, senha) Values ";
                _query += "('" + txtUsu.Text + "','" + txtNome.Text + "','" + senha + "')";
                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    MessageBox.Show("Cadastrado com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas com o cadastro!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
