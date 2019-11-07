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
    public partial class frminicio : Form
    {
        public frminicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //llamada a la función calcularX1
            double a, b, c;
            //validar si el usuario a ingresado valores
            if (this.txtA.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingresa el valor de A...");
                this.txtA.Focus();//ubica el cursor en el cuadro
                return; //abandonar
            }

            a = Double.Parse(this.txtA.Text);
            b = Double.Parse(this.txtB.Text);
            c = Double.Parse(this.txtC.Text);

            double x1 = calcularX1(a, b, c);
            double x2 = calcularX2(a, b, c);

            //asigno el resultado de X1 en el textbox txtX1
            txtX1.Text = x1.ToString();
            txtX2.Text = x2.ToString();
        }

        private void txtX2_TextChanged(object sender, EventArgs e)
        {

        }

        private void frminicio_Load(object sender, EventArgs e)
        {
            //este evento
            //se ejecuta  cada vez que se abre el formulario

            //establecer ell control txtX2 de solo
            //lectura
            this.txtX2.ReadOnly = true;
        }
        //Crear un método o procedimiento
        private double calcularX1(double a, double b, double c)
        {
            //declarar variables
            double x1 = 0, d = 0;

            //calcular discriminante
            d = (b * b) - (4 * a * c);

            //verificar si a  es distinto de cero
            if(a==0)
            {
                MessageBox.Show("Error al dividir para cero...");
                return 0; //abandonar

            }

            //verificar raices negativas
            if (d < 0)
                {
                MessageBox.Show("Error, la ecuación tiene soluciones imaginarias...");
                return 0;
            }
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            return x1;
        }
        //Crear un método o procedimiento
        private double calcularX2(double a, double b, double c)
        {
            //declarar variables
            double x2 = 0, d = 0;

            //calcular discriminante
            d = (b * b) - (4 * a * c);

            //verificar si a  es distinto de cero
            if (a == 0)
            {
                MessageBox.Show("Error al dividir para cero...");
                return 0; //abandonar

            }

            //verificar raices negativas
            if (d < 0)
            {
                MessageBox.Show("Error, la ecuación tiene soluciones imaginarias...");
                return 0;
            }
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return x2;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Encerar cuadros de texto
            this.txtA.Text = "";
            this.txtB.Text = "";
            this.txtC.Text = "";
            this.txtX1.Text = "";
            this.txtX2.Text = "";
            this.txtA.Focus();
        }
    }
}
