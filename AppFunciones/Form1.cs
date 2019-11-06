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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cierra el formulario
            this.Close();
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(this.txtNum1.Text.ToString());
            int num2 = Int32.Parse(this.txtnum2.Text.ToString());
            int suma = fnsuma(num1, num2);

            //asigno  el resultado al cuadro de texto
            this.txtresultado.Text = suma.ToString();
        }

        int fnsuma(int a, int b)
        {
            return (a + b);
        }

    }
}
