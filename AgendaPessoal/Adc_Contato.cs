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
    public partial class Adc_Contato : Form
    {
        public Adc_Contato()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adc_Contato2 _adcContato2 = new Adc_Contato2();
            _adcContato2.ShowDialog();
            _adcContato2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adc_Contato3 _adcContato3 = new Adc_Contato3();
            _adcContato3.ShowDialog();
            _adcContato3.Focus();
        }
    }
}
