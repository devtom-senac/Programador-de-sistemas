namespace Calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBoxForma_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBoxForma.SelectedItem.ToString() == "Quadrado")
            {
                groupBoxQuadrado.Visible = true;
                groupBoxRetangulo.Visible = false;
                groupBoxQuadrado.BringToFront();
                groupBoxRetangulo.SendToBack();
                return;
            }

            if (comboBoxForma.SelectedItem.ToString() == "Retangulo")
            {
                groupBoxQuadrado.Visible = false;
                groupBoxRetangulo.Visible = true;
                groupBoxQuadrado.SendToBack();
                groupBoxRetangulo.BringToFront();
                return;
            }
        }

        private void radioButtonArea_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAltura.Enabled = false;
            textBoxComprimento.Enabled = false;
        }

        private void radioButtonPerimetro_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAltura.Enabled = false;
            textBoxComprimento.Enabled = false;
        }

        private void radioButtonVolume_CheckedChanged(object sender, EventArgs e)
        {
            textBoxComprimento.Enabled = false;
            textBoxAltura.Enabled = false;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (comboBoxForma.SelectedItem == null)
            {
                labelErro.Text = "Selecione um opção";
                return;
            }

            labelErro.Text = "";

            textBoxAltura.Enabled = false;

            if (radioButtonArea.Checked)
            {
                string largura = textBoxLargura.Text;
                string altura = textBoxAltura.Text;

                if (string.IsNullOrWhiteSpace(largura) || !largura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma largura válida.";
                    return;
                }

                double areaValor = Convert.ToDouble(largura);

                double resultado = Math.Pow(areaValor, 2);

                textBoxResultado.Text = resultado.ToString();

                textBoxResultado.Text = resultado.ToString();
            }

            if (radioButtonPerimetro.Checked)
            {

                string largura = textBoxLargura.Text;

                if (string.IsNullOrWhiteSpace(largura) || !largura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma largura válida.";
                    return;
                }

                double resultado = Convert.ToDouble(largura) * 4;

                textBoxResultado.Text = resultado.ToString();

            }

            if (radioButtonVolume.Checked)
            {

                string largura = textBoxLargura.Text;

                if (string.IsNullOrWhiteSpace(largura) || !largura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma largura válida.";
                    return;
                }

                double larguraValor = Convert.ToDouble(largura);

                double resultado = Math.Pow(larguraValor, 3);

                textBoxResultado.Text = resultado.ToString();

            }

        }

        private void buttonCalcularCirculo_Click(object sender, EventArgs e)
        {
            labelErro.Text = "";

            if (rdbDiametro.Checked)
            {

            }
        }
    }
}
