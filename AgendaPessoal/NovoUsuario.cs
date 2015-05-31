using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AgendaPessoal
{
    public partial class NovoUsuario : Form
    {
        public NovoUsuario()
        {
            InitializeComponent();
        }

        MySqlConnection Conexao = new MySqlConnection(Properties.Settings.Default.ConectionString);
        public static int _cadastroLiberado = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_nome_usuario.Text == "")
            {
                MessageBox.Show("O campo 'Nome' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_nome_usuario.Focus();
            }
            else
                if (tb_usuario.Text == "")
                {
                    MessageBox.Show("O campo 'Usuario' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_usuario.Focus();
                }
            else
                    if (tb_senha_usuario.Text.Length < 5)
                    {
                        MessageBox.Show("O campo 'Senha' não foi preenchido corretamente, Deve conter no minimo 5 caracteres!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tb_senha_usuario.Focus();
                    }
            else
                        if (tb_confirmar_senha.Text != tb_senha_usuario.Text)
                        {
                            MessageBox.Show("As senhas não coincidem!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tb_confirmar_senha.Focus();
                        }

            if (_cadastroLiberado == 1)
            {
                string SQL = "Insert Into tbl_usuario Values ('','" + tb_nome_usuario.Text + "','" + tb_usuario.Text + "','" + tb_senha_usuario.Text + "','" + this.picFoto.ImageLocation + "');";
                cls_dados Inserir = new cls_dados();
                Inserir.ExecutarSQL(SQL);
                MessageBox.Show("Usuário cadastrado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _cadastroLiberado = 0;
            }
            else
            {
                MessageBox.Show("Já existe um usuario com esta indentificação!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_usuario.Focus();
            }

        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg)|*.jpg|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.picFoto.Visible = true;
                this.picFoto.ImageLocation = openFileDialog.FileName;
           
            }
        }

        private void tb_usuario_Leave(object sender, EventArgs e)
        {
            try
            {
                Conexao.Open();
            }
            catch
            {
            }

            if (Conexao.State == ConnectionState.Open)
            {
                cls_login cls_login = new cls_login();
                string SQL = "select * from tbl_usuario where login = '" + tb_usuario.Text + "';";

                MySqlDataAdapter Adapter = new MySqlDataAdapter(SQL, Conexao);

                DataSet Dados = new DataSet();

                Adapter.Fill(Dados, "Liberar_Cadastro");

                if (Dados.Tables[0].Rows.Count > 0)
                {
                    _cadastroLiberado = 0;
                }
                else
                {
                    _cadastroLiberado = 1;
                }
            }
        }


    }
}
