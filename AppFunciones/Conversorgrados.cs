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
    public partial class Conversorgrados : Form
    {
        public Conversorgrados()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtC.Text = "";
            this.txtF.Text = "";
            this.txtC.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float cent = float.Parse(this.txtC.Text);
            float fahr = (cent * 9 / 5) + 32;
            this.txtF.Text = fahr.ToString();
        }
    }
}
