namespace Treino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox.Items.Add("Somar");
            comboBox.Items.Add("Subtrair");
            comboBox.Items.Add("Multiplicar");
            comboBox.Items.Add("Dividir");

            comboBox.SelectedItem = "Somar";

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string valor1 = textBoxValor1.Text;
            string valor2 = textBoxValor2.Text;

            if (!double.TryParse(valor1, out double doubleValor1) || !double.TryParse(valor2, out double doubleValor2))
            {
                textBoxResultado.Text = "Os valores digitados devem ser n�meros v�lidos.";
                return;
            }

            double resultado = 0;  
           
            switch (comboBox.SelectedItem.ToString())  // Realiza a opera��o selecionada no ComboBox
            {
                case "Somar":
                    labelOperacao.Text = "+";
                    resultado = doubleValor1 + doubleValor2;
                    break;

                case "Subtrair":
                    labelOperacao.Text = "-";
                    resultado = doubleValor1 - doubleValor2;
                    break;

                case "Multiplicar":
                    labelOperacao.Text = "*";
                    resultado = doubleValor1 * doubleValor2;
                    break;

                case "Dividir":
                    labelOperacao.Text = "/";

                    if (doubleValor2 == 0) // Verifica se o divisor � zero para evitar erro de divis�o por zero
                    {
                        textBoxResultado.Text = "N�o � poss�vel dividir por zero.";
                        return;
                    }
                    resultado = doubleValor1 / doubleValor2;
                    break;

                default:
                    labelOperacao.Text = "";
                    textBoxResultado.Text = "Selecione uma opera��o v�lida.";
                    return;
            }

            // Exibe o resultado no textBoxResultado
            textBoxResultado.Text = resultado.ToString();


        }
    }
}
