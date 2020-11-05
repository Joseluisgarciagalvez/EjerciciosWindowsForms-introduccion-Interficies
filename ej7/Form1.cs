using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxColores.SelectedIndex;

            textBoxResultado.Text = "The choosen colour is "+ comboBoxColores.Items[index].ToString();
        }
    }
}
