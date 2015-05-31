using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgendaPessoal
{
    public partial class Adc_Contato2 : Form
    {
        public Adc_Contato2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_nome.Text == "")
            {
                MessageBox.Show("O campo 'Nome' não foi preenchido corretamente!","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                tb_nome.Focus();
            }
            else
                if ((!tb_email.Text.Contains("@") || !tb_email.Text.Contains(".")) || tb_email.Text.Length == 0)
                {
                    MessageBox.Show("O campo 'Email' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_email.Focus();
                }
                else
                            if (tb_logradouro.Text == "")
                            {
                                MessageBox.Show("O campo 'Logradouro' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                tb_logradouro.Focus();
                            }
                                else
                                if (cb_estado.Text.Length != 2)
                                {
                                    MessageBox.Show("O campo 'Estado' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    cb_estado.Focus();
                                }
                                else
                                    if (tb_bairro.Text == "")
                                    {
                                        MessageBox.Show("O campo 'Bairro' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        tb_bairro.Focus();
                                    }
                                    else
                                        if (tb_cidade.Text == "")
                                        {
                                            MessageBox.Show("O campo 'Cidade' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            tb_cidade.Focus();
                                        }
                                        else
                                            if (tb_numero.Text == "")
                                            {
                                                MessageBox.Show("O campo 'Numero' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                tb_numero.Focus();
                                            }
                                            else
                                                if (tb_complemento.Text == "")
                                                {
                                                    MessageBox.Show("O campo 'Complemento' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    tb_complemento.Focus();
                                                }
                                                else
                                                    if (msk_celular.Text.Length != 14)
                                                    {
                                                        MessageBox.Show("O campo 'Celular' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    }
                                                    else
                                                        if (msk_telefone.Text.Length != 14)
                                                        {
                                                            MessageBox.Show("O campo 'Telefone' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        }
                                                            else
                                                                if (msk_dataNascimento.Text.Length != 10)                                              {
                                                                    MessageBox.Show("O campo 'Data de nascimento' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                }
                                                                else
                                                                    if (msk_cep.Text.Length != 10)
                                                                    {
                                                                        MessageBox.Show("O campo 'CEP' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("Cadastrado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
                                                                    }
        }
    }
}
