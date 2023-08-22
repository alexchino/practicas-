using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void validar_Click(object sender, EventArgs e)
        {
            string numero = numero1.Text;
            string letra = letra2.Text;
            if (string.IsNullOrEmpty(letra) ||
                string.IsNullOrWhiteSpace(letra))
            {
                MessageBox.Show("ingrese un numero");
            }
            if (int.TryParse(numero, out int n))
            {
                MessageBox.Show("es un numero");
            }
            else
            {
                MessageBox.Show("no es un numero");
            }
        }
    }
}
