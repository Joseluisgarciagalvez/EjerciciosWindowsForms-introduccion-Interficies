using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej4_a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxOperador1.Text = "";
            textBoxOperador2.Text =  "";
            textBoxResultado.Text = "";
            textBoxTipoOperacion.Text = "";
        }

        private void buttonSumar_Click(object sender, EventArgs e)
        {
            textBoxTipoOperacion.Text = "+";
        }

        private void buttonRestar_Click(object sender, EventArgs e)
        {
            textBoxTipoOperacion.Text = "-";
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double numero1 =0, numero2, resultado;
            if (textBoxTipoOperacion.Text == "+")
            {
                numero1 = double.Parse(textBoxOperador1.Text);
                numero2 = double.Parse(textBoxOperador2.Text);
                resultado = numero1 + numero2;
                textBoxResultado.Text = resultado.ToString();
            }

            if (textBoxTipoOperacion.Text == "-")
            {
                numero1 = double.Parse(textBoxOperador1.Text);
                numero2 = double.Parse(textBoxOperador2.Text);
                resultado = numero1 - numero2;
                textBoxResultado.Text = resultado.ToString();
            }
        }

        private void textBoxTipoOperacion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
