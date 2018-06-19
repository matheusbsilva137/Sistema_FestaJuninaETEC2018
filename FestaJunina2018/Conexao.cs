using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace FestaJunina2018
{
    class Conexao
    {
        private static string connString = @"Provider=Microsoft.Ace.OLEDB.12.0;Data Source=bd_festajunina.accdb";
        private static OleDbConnection conn = null;

        public static OleDbConnection obterConn()
        {
            conn = new OleDbConnection(connString);

            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                conn = null;
                MessageBox.Show("Conexão não Show");
            }
            return conn;
        }

        public static void fecharConn()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

    }
}