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
    public partial class Restaurar_Contato : Form
    {
        public Restaurar_Contato()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Restaurado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }
    }
}
