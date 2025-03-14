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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // Evento que dispara quando a seleção no ComboBox muda
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxForma.SelectedItem == null)
            {
                labelErro.Text = "Selecione um opção";
                return;
            }

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
            textBoxComprimento.Enabled = false;
        }

        private void radioButtonPerimetro_CheckedChanged(object sender, EventArgs e)
        {
            textBoxComprimento.Enabled = false;
        }

        private void radioButtonVolume_CheckedChanged(object sender, EventArgs e)
        {
            textBoxComprimento.Enabled = false;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            labelErro.Text = "";

            if (radioButtonArea.Checked)
            {
                string largura = textBoxLargura.Text;
                string altura = textBoxAltura.Text;

                if (string.IsNullOrWhiteSpace(largura) || !largura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma largura válida.";
                    return;
                }

                if (string.IsNullOrWhiteSpace(altura) || !altura.All(char.IsNumber))
                {
                    labelErro.Text = "Insira uma altura válida.";
                    return;
                }

                double resultado = Convert.ToDouble(altura) * Convert.ToDouble(largura);

                textBoxResultado.Text = resultado.ToString();
            }
        }
    }
}
