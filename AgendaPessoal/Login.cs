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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            cls_login cls = new cls_login();
            if (cls.Autenticar(textBox1.Text, textBox2.Text) == true)
            {
                Tela_Principal _telaPrincipal = new Tela_Principal();
                _telaPrincipal.Show();
                this.Hide();
            }
            
            else
            {
               
            }

        }
    }
}
