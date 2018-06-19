using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace FestaJunina2018
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        OleDbConnection conn = Conexao.obterConn();
        OleDbDataReader dr_atend, dr_log, dr_useratend;
        BindingSource bs_atend = new BindingSource();
        String _query, senha, senhaCrip, _queryUsu;

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
        private void carregar_senha()
        {
            _queryUsu = "Select login_atendente from Atendente where login_atendente like '" + txtUsuario.Text + "'";
            _query = "Select senha from Atendente where login_atendente like '" + txtUsuario.Text + "'";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            OleDbCommand _dataCommandUsu = new OleDbCommand(_queryUsu, conn);
            dr_atend = _dataCommand.ExecuteReader();
            dr_log = _dataCommandUsu.ExecuteReader();
            dr_log.Read();
            dr_atend.Read();
            if (dr_log.HasRows == true)
            {
                senhaCrip = Convert.ToString(dr_atend["senha"]);
            }
            else
                MessageBox.Show("Login inválido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txtUsuario.Focus();
        }
        public bool valida()
        {
            bool erro = true;
            carregar_senha();
            senha = GerarMD5(txtSenha.Text);

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Usuário inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Focus();
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Senha inválida. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSenha.Focus();
            }
            if (senha != senhaCrip)
            {
                MessageBox.Show("Senhas inválidas. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSenha.Focus();
            }
            else
            {
                erro = false;
            }
            return erro;
        }
        private void btnValida_Click(object sender, EventArgs e)
        {
            bool teste;
            teste = valida();
            if (teste == false)
            {
                _query = "Select nome from Atendente where login_atendente like '" + txtUsuario.Text + "';";
                OleDbCommand _dataCommandAt = new OleDbCommand(_query, conn);
                dr_useratend = _dataCommandAt.ExecuteReader();
                dr_useratend.Read();
                String username = Convert.ToString(dr_useratend["nome"]);
                this.Hide();
                frmMenu mn = new frmMenu(username, txtUsuario.Text);
                mn.Show();
            }
        }
    }
}
