using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace AgendaPessoal
{
    class cls_dados
    {
        public void ExecutarSQL(string _comandoSQL)
        {

            MySqlConnection Conexao = new MySqlConnection(Properties.Settings.Default.ConectionString);

            try
            {
                Conexao.Open();
            }
            catch
            {
                
            }

            if (Conexao.State == ConnectionState.Open)
            {
                MySqlDataAdapter Adapter = new MySqlDataAdapter(_comandoSQL, Conexao);
                Adapter.SelectCommand.ExecuteNonQuery();
            }
        }
    }
}
