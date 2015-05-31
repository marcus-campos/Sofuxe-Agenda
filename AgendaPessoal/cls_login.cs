using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace AgendaPessoal
{
    class cls_login
    {
        public static int _id = 0;
        MySqlConnection objconexao = new MySqlConnection(Properties.Settings.Default.ConectionString);

        public bool Autenticar(string Login, string Senha)
        {
            bool retn = false;                                

            try
            {
                objconexao.Open();
            }
            catch
            {
                MessageBox.Show("Não foi possível conectar-se ao banco de dados. Favor conferir se o banco de dados está corretamente configurado, e online.", "Erro!");
                retn = false;
            }

            if (objconexao.State == System.Data.ConnectionState.Open)
            {


                string SQL = "SELECT * FROM tbl_usuario WHERE LOGIN = '" + Login + "'AND SENHA = '" + Senha + "';";
                MySqlDataAdapter objadapter = new MySqlDataAdapter(SQL, objconexao);
                DataSet objdataset = new DataSet();
                objadapter.Fill(objdataset, "usuarios");



                if (objdataset.Tables[0].Rows.Count > 0)
                {
                    _id = int.Parse(objdataset.Tables[0].Rows[0]["codigo"].ToString());
                    retn = true;
                }
                else
                {
                    MessageBox.Show("Senha ou usuario incorretos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    retn = false;

                }

                objconexao.Close();

            }

            return retn;


        }
    }
}
