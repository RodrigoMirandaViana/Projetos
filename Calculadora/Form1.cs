using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double valor1;
        double valor2;
        double resultado;
        string operacao;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "8";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "0";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "";
        }

        private void adicao_Click(object sender, EventArgs e)
        {
            operacao = "+";
            valor1 = int.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void igual_Click(object sender, EventArgs e)
        {
            valor2 = int.Parse(txtdisplay.Text);

            switch (operacao){
                case "+":
                    resultado = valor1 + valor2;
                    txtdisplay.Text = resultado.ToString();
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    txtdisplay.Text = resultado.ToString();
                    break;
                case "x":
                    resultado = valor1 * valor2;
                    txtdisplay.Text = resultado.ToString();
                    break;
                case "/":
                    resultado = valor1 / valor2;
                    txtdisplay.Text = resultado.ToString();
                    break;
                case "x²":
                    resultado = Math.Pow(valor1,valor2);
                    txtdisplay.Text = resultado.ToString();
                    break;
            }
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            operacao = "-";
            valor1 = int.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            operacao = "x";
            valor1 = int.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            operacao = "/";
            valor1 = int.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            operacao = "x²";
            valor1 = int.Parse(txtdisplay.Text);
            txtdisplay.Clear();
        }

        private void raiz_Click(object sender, EventArgs e)
        {
            operacao = "√";
            valor1 = int.Parse(txtdisplay.Text);
            resultado = valor1;
            txtdisplay.Text = Math.Sqrt(valor1).ToString();
        }
    }
}
