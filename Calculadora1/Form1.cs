using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            texto.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            texto.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            texto.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            texto.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            texto.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            texto.Text += "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            texto.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            texto.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            texto.Text += "9";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            texto.Text += "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            texto.Text += ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(texto.Text, CultureInfo.InvariantCulture);

            if (operacao == "SOMA")
            {
                texto.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                texto.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                texto.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIV")
            {
                texto.Text = Convert.ToString(valor1 / valor2);
            }
        }

    

        private void button14_Click(object sender, EventArgs e)
        {
            if (texto.Text != "")
            {
                valor1 = decimal.Parse(texto.Text, CultureInfo.InvariantCulture);
                texto.Text = "";
                operacao = "SUB";
                lblOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Tem de colocar um valor para poder efetuar a conta");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (texto.Text != "")
            {
                valor1 = decimal.Parse(texto.Text, CultureInfo.InvariantCulture);
                texto.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "*";
            }
            else
            {
                MessageBox.Show("Tem de colocar um valor para poder efetuar a conta");
            }
        }


        private void button17_Click(object sender, EventArgs e)
        {
            if (texto.Text != "")
            {
                valor1 = decimal.Parse(texto.Text, CultureInfo.InvariantCulture);
                texto.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Tem de colocar um valor para poder efetuar a conta");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            texto.Text = "";
            lblOperacao.Text = ""; 
        }

        private void button15_Click(object sender, EventArgs e)
        {
            texto.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (texto.Text != "")
            {
                valor1 = decimal.Parse(texto.Text, CultureInfo.InvariantCulture);
                texto.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Tem de colocar um valor para poder efetuar a conta");
            }
        }
    }
}
