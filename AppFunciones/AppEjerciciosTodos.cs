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
    public partial class AppEjerciciosTodos : Form
    {
        public AppEjerciciosTodos()
        {
            InitializeComponent();
        }

        private void AppEjerciciosTodos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0, result;

            if (this.textBox1.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar el valor de A");
                this.textBox1.Focus();
                return;
            }

            if (this.textBox2.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar el valor de B");
                this.textBox2.Focus();
                return;
            }
            if (this.textBox3.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar el valor de C");
                this.textBox3.Focus();
                return;
            }

            if (Double.TryParse(this.textBox1.Text, out result))
                a = result;
            else
            {
                MessageBox.Show("Debe ingresar valores numéricos");
                this.textBox1.Focus();
                return;
            }
            if (Double.TryParse(this.textBox2.Text, out result))
                b = result;
            else
            {
                MessageBox.Show("Debe ingresar valores numéricos");
                this.textBox2.Focus();
                return;
            }
            if (Double.TryParse(this.textBox3.Text, out result))
                c = result;
            else
            {
                MessageBox.Show("Debe ingresar valores numéricos");
                this.textBox3.Focus();
                return;
            }
            double ar = AreaTriangulo(a, b, c);
            this.textBox4.Text = ar.ToString();


        }
        private double AreaTriangulo(double a, double b, double c)
        {
            double area, sp;
            sp = (a + b + c) / 2;

            area = Math.Sqrt(sp * (sp - a) * (sp - a) * (sp - c));
            return area;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
