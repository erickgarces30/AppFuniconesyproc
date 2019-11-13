using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFunciones
{
    public partial class FactorialNumero : Form
    {
        public FactorialNumero()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private long facnum(int num = 0)
        {
            int cont=1;
            for (int i = 1; i <= num; i++)
            {
               cont = cont * i;
            }
            return cont;

        }
        private void FactorialNumero_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num =0;
            if(this.textBox1.Text.Length==0)
            {
                MessageBox.Show("Ingrse algún valor");
                this.textBox1.Focus();
                return;
            }
            num = int.Parse(this.textBox1.Text);
            long fact = facnum(num);
            this.textBox2.Text = fact.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox1.Focus();
        }
    }
}
