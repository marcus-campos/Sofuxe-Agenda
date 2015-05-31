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
    public partial class Adc_Compromisso : Form
    {
        public Adc_Compromisso()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Adc_Compromisso_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rtb_compromisso.Text == "")
            {
                MessageBox.Show("O campo 'Descrição' não foi preenchido corretamente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Focus();
            }
            DateTimePicker dt = new DateTimePicker();
            String DataFormatada = dt.Value.ToString("yyyyMMdd");
            string SQL = "Insert Into tbl_compromissos Values (''," + cls_login._id + ",'" + DataFormatada + "','" + maskedTextBox1.Text + "','" + rtb_compromisso.Text + "','" + tb_evento.Text + "');";
            cls_dados Inserir = new cls_dados();
            Inserir.ExecutarSQL(SQL);
            MessageBox.Show("Compromisso cadastrado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (MessageBox.Show("Deseja adicionar um novo compromisso?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimparCampos();
            }
            else
            {
                this.Close();
            }
        }

        private void LimparCampos()
        {
            tb_evento.Clear();
            rtb_compromisso.Clear();
            maskedTextBox1.Clear();
            
        }

        private void Adc_Compromisso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tela_Principal tl_pri = new Tela_Principal();
            tl_pri.CarregarCompromissos();
        }
    }
}
