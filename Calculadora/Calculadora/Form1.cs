using System;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonSomar_Click(object sender, EventArgs e)
        {
            string valor1 = textBoxValor1.Text;
            string valor2 = textBoxValor2.Text;

            if (!valor1.All(char.IsNumber) && !valor2.All(char.IsNumber))
            {
                labelResultado.Text = "os valores digitados devem ser um números";
            }

            double doubleValor1 = Convert.ToDouble(valor1);
            double doubleValor2 = Convert.ToDouble(valor2);

            double resultado = doubleValor1 + doubleValor2;

            labelResultado.Text = resultado.ToString();
        }

        private void buttonSubtrair_Click(object sender, EventArgs e)
        {
            string valor1 = textBoxValor1.Text;
            string valor2 = textBoxValor2.Text;

            if (!valor1.All(char.IsNumber) && !valor2.All(char.IsNumber))
            {
                labelResultado.Text = "os valores digitados devem ser um números";
            }
            double doubleValor1 = Convert.ToDouble(valor1);
            double doubleValor2 = Convert.ToDouble(valor2);

            double resultado = doubleValor1 - doubleValor2;

            labelResultado.Text = resultado.ToString();
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            string valor1 = textBoxValor1.Text;
            string valor2 = textBoxValor2.Text;

            if (!valor1.All(char.IsNumber) && !valor2.All(char.IsNumber))
            {
                labelResultado.Text = "os valores digitados devem ser um números";
            }
            double doubleValor1 = Convert.ToDouble(valor1);
            double doubleValor2 = Convert.ToDouble(valor2);

            double resultado = doubleValor1 * doubleValor2;

            labelResultado.Text = resultado.ToString();
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            string valor1 = textBoxValor1.Text;
            string valor2 = textBoxValor2.Text;

            if (!valor1.All(char.IsNumber) && !valor2.All(char.IsNumber))
            {
                labelResultado.Text = "os valores digitados devem ser um números";
            }
            double doubleValor1 = Convert.ToDouble(valor1);
            double doubleValor2 = Convert.ToDouble(valor2);

            double resultado = doubleValor1 * doubleValor2;

            labelResultado.Text = resultado.ToString();
        }


        private void buttonMigrar_Click(object sender, EventArgs e)
        {
            Form2 trocarPagina = new Form2();

            trocarPagina.Show();

            this.Hide();
        }

        private void buttonTarefa_Click(object sender, EventArgs e)
        {
            tarefas trocarPagina = new tarefas();

            trocarPagina.Show();

            this.Hide();
        }
    }
}

