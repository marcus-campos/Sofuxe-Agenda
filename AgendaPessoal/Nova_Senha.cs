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
    public partial class Nova_Senha : Form
    {
        public Nova_Senha()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Nova_Senha_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_senha_antiga.Text == "")
            {
                MessageBox.Show("O campo 'Senha Antiga' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_senha_antiga.Focus();
            }
            else
                if(tb_senha_nova.Text.Length != 5)
            {
                MessageBox.Show("O campo 'Nova Senha' não foi preenchido corretamente, Deve conter no minimo 5 caracteres!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_senha_nova.Focus();
            }
            else
                    if (tb_senha_nova_confirma.Text != tb_senha_nova.Text)
                    {
                        MessageBox.Show("As senhas nao coincidem!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Cadastrado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
                    }
        }

        private void tb_senha_nova_confirma_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
