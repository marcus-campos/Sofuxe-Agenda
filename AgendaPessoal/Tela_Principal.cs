using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;


namespace AgendaPessoal
{
    public partial class Tela_Principal : Form
    {
        public Tela_Principal()
        {
            InitializeComponent();
        }
        private StringReader leitor;

        MySqlConnection Conexao = new MySqlConnection(Properties.Settings.Default.ConectionString);

        private void Tela_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fazer o logoff?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                Application.Restart();
            }

            

        }

        private void novoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoUsuario _novoUsuario = new NovoUsuario();
            _novoUsuario.ShowDialog();
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nova_Senha _novaSenha = new Nova_Senha();
            _novaSenha.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adc_Contato _adcContato = new Adc_Contato();
            _adcContato.ShowDialog();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Restaurar_Contato _restaurarContato = new Restaurar_Contato();
            _restaurarContato.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tb_apelido.ReadOnly = true;
            tb_bairro.ReadOnly = true;
            tb_cargo.ReadOnly = true;
            tb_casa.ReadOnly = true;
            tb_celular.ReadOnly = true;
            tb_CEP.ReadOnly = true;
            tb_cidade.ReadOnly = true;
            tb_cnpj.ReadOnly = true;
            tb_complemento.ReadOnly = true;
            tb_email.ReadOnly = true;
            tb_estado.ReadOnly = true;
            tb_fax.ReadOnly = true;
            tb_logradouro.ReadOnly = true;
            tb_nome.ReadOnly = true;
            tb_nome_empresa.ReadOnly = true;
            tb_nome_fantasia.ReadOnly = true;
            tb_numero.ReadOnly = true;
            tb_responsavel.ReadOnly = true;
            tb_telefone.ReadOnly = true;
            msk_data.ReadOnly = true;
            msk_data_nascimento.ReadOnly = true;
            
            

            button4.Enabled = true;
            button8.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tb_apelido.ReadOnly = false;
            tb_bairro.ReadOnly = false;
            tb_cargo.ReadOnly = false;
            tb_casa.ReadOnly = false;
            tb_celular.ReadOnly = false;
            tb_CEP.ReadOnly = false;
            tb_cidade.ReadOnly = false;
            tb_cnpj.ReadOnly = false;
            tb_complemento.ReadOnly = false;
            tb_email.ReadOnly = false;
            tb_estado.ReadOnly = false;
            tb_fax.ReadOnly = false;
            tb_logradouro.ReadOnly = false;
            tb_nome.ReadOnly = false;
            tb_nome_empresa.ReadOnly = false;
            tb_nome_fantasia.ReadOnly = false;
            tb_numero.ReadOnly = false;
            tb_responsavel.ReadOnly = false;
            tb_telefone.ReadOnly = false;
            msk_data.ReadOnly = false;
            msk_data_nascimento.ReadOnly = false;
            
            button8.Visible = true;
            button4.Enabled = false;
            button8.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deletar_Contato _deletarContato = new Deletar_Contato();
            _deletarContato.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Adc_Compromisso _adcCompromisso = new Adc_Compromisso();
            _adcCompromisso.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            msk_data.ReadOnly = false;
            rtb_Infos.ReadOnly = false;
            button10.Visible = true;
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            msk_data.ReadOnly = true;
            rtb_Infos.ReadOnly = true;
            button9.Enabled = true;
            button10.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Deletar_Compromisso _deletarCompromisso = new Deletar_Compromisso();
            _deletarCompromisso.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Restaurar_Compromisso _restaurarCompromisso = new Restaurar_Compromisso();
            _restaurarCompromisso.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Sobre _sobre = new Sobre();
            _sobre.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void compromissosDeHojeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Tela_Principal_Load(object sender, EventArgs e)
        {
            CarregarDadosUsuario();
            CarregarCompromissos();
           
        }

        private void CarregarDadosUsuario()
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
                string SQL = "select nome, foto from tbl_usuario where codigo = " + cls_login._id + ";";

                MySqlDataAdapter Adapter = new MySqlDataAdapter(SQL, Conexao);

                DataSet Dados = new DataSet();

                Adapter.Fill(Dados, "dados");

                if (Dados.Tables[0].Rows.Count > 0)
                {
                    this.Text = "Sofuxe - Agenda  | " + Dados.Tables[0].Rows[0]["nome"].ToString();
                    picFoto1.ImageLocation = Dados.Tables[0].Rows[0]["foto"].ToString();
                    
                }
            }
        }

        public void CarregarCompromissos()
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
                string SQL = "select * from tbl_compromissos where tbl_usuario_codigo = " + cls_login._id + ";";

                MySqlDataAdapter Adapter = new MySqlDataAdapter(SQL, Conexao);

                DataSet Dados = new DataSet();

                Adapter.Fill(Dados, "compromissos");

                if (Dados.Tables[0].Rows.Count > 0)
                {
                    for (int x = 0; Dados.Tables[0].Rows.Count >= x; x++)
                    {
                        if (DateTime.Parse(Dados.Tables[0].Rows[x]["data_compromisso"].ToString()).Date < DateTime.Now.Date || DateTime.Parse(Dados.Tables[0].Rows[x]["data_compromisso"].ToString()).Date > DateTime.Now.AddDays(7))
                        {

                        }
                        else
                        {
                            lst_compromissos.Items.Add(Dados.Tables[0].Rows[x]["evento"].ToString());
                        }
                    }
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Compromissos_Enter(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           
            float linhasPorPagina = 0;
            float yPosicao = 0;
            int contador = 0;
            float margemEsquerda = e.MarginBounds.Left;
            float margemSuperior = e.MarginBounds.Top;
            string linha = null;
            Font fonteImpressao = this.rtb_Infos.Font;
            SolidBrush mCaneta = new SolidBrush(Color.Black);

            
            linhasPorPagina = e.MarginBounds.Height / fonteImpressao.GetHeight(e.Graphics);

           
            while (contador < linhasPorPagina && ((linha = leitor.ReadLine()) != null))
            {
                yPosicao = margemSuperior + (contador * fonteImpressao.GetHeight(e.Graphics));
                e.Graphics.DrawString(linha, fonteImpressao, mCaneta, margemEsquerda, yPosicao, new StringFormat());
                contador++;
            }

            if (linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }

            		
            mCaneta.Dispose();
        }

        private void verImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                string texto = "Compromisso"
                               +"\n\n\nData do compromisso: " + this.msk_data.Text 
                               +"\n----------------------------------------------------------------------------"
                               +"\n\n" + this.rtb_Infos.Text;
                leitor = new StringReader(texto);
                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                printPreviewDialog1.Document = this.printDocument1;
                printPreviewDialog1.FormBorderStyle = FormBorderStyle.Fixed3D;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception exp)
            {
                MessageBox.Show(" Erro : " + exp.Message.ToString());
            }

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            string texto = "Data do compromisso: "+this.msk_data.Text + "\n\n\n" + this.rtb_Infos.Text;
            leitor = new StringReader(texto);

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }
    }
}
