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
    public partial class Adc_Contato3 : Form
    {
        public Adc_Contato3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Nome fantasia da empresa não e necessário caso a empresa ainda não tenha um
            if (tb_nomeEmpresa.Text == "")
            {
                MessageBox.Show("O campo 'Nome Empresa' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_nomeEmpresa.Focus();
            }
            else
                if (msk_CNPJ.Text.Length != 18)
                {
                    MessageBox.Show("O campo 'CNPJ' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    msk_CNPJ.Focus();
                }
                else
                    if(tb_responsavel.Text == "")
                {
                    MessageBox.Show("O campo 'Responsavel' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_responsavel.Focus();
                }
            else
                        if (msk_telefone.Text.Length != 14)
                        {
                            MessageBox.Show("O campo 'Telefone' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            msk_telefone.Focus();
                        }
            else
                            if (msk_fax.Text.Length != 14)
                            {
                                MessageBox.Show("O campo 'Fax' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                msk_fax.Focus();
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
                                            if (tb_cidade.Text == "")
                                            {
                                                MessageBox.Show("O campo 'Cidade' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                tb_cidade.Focus();
                                            }
            else
                                                if (tb_bairro.Text == "")
                                                {
                                                    MessageBox.Show("O campo 'Bairro' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    tb_bairro.Focus();
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
                                                            if (msk_CEP.Text.Length != 10)
                                                            {
                                                                MessageBox.Show("O campo 'CEP' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                msk_CEP.Focus();
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Cadastrado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
                                                            }
                
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Adc_Contato3_Load(object sender, EventArgs e)
        {

        }
    }
}

