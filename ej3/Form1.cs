using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSumar_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;
            numero1 = double.Parse(textBoxOperador1.Text);
            numero2 = double.Parse(textBoxOperador2.Text);
            resultado = numero1 + numero2;
            textBoxResultado.Text = resultado.ToString();

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxOperador1.Text = "";
            textBoxOperador2.Text = "";
            textBoxResultado.Text = "";
        }
    }
}
