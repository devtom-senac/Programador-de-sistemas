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
    public partial class tarefas : Form
    {
        public tarefas()
        {
            InitializeComponent();
        }

        List<string> listaTarefas = new List<string>();
        List<string> listaNiveis = new List<string>();

        private void adicionarTarefa()
        {
            //Recebendo o nome da tarefa e o nivel em variaveis.
            string nomeTarefa = textBoxTarefa.Text;
            string nivel = comboBoxNivel.SelectedItem?.ToString();

            //Colocando nas listas através das variaveis usando .Add
            listaTarefas.Add(nomeTarefa);
            listaNiveis.Add(nivel);

            // Agora exibe a tarefa na list box para vermos quais tarefas já adicionamos e o nivel.
            listBoxTarefas.Items.Add($"{nomeTarefa} - {nivel}");

            // Aqui limpamos o texBox e o comboBox para receberem nova tarefa e nivel.
            textBoxTarefa.Clear();
            comboBoxNivel.SelectedIndex = -1;
        }

        private void buttonAdicionarTarefa_Click(object sender, EventArgs e)
        {
            // aqui chamamos o método de adicionar tarefa que criamos antes.
            adicionarTarefa();
        }
            
        private void DividirTempo()
        {
            // Verifica se o tempo total é válido
            int tempoTotal = ConverterTempo(textBoxTempo.Text);
            if (tempoTotal <= 0)
            {
                labelRetorno.Text = "Insira um tempo válido no formato (XhYm ou Xm). Ex: 1h30 ou 90min.";
                return; // Sai do método para evitar erros
            }

            // Aqui contamos quantas tarefas tem em cada nível
            int nivelFacil = listaNiveis.Count(n => n == "Facil");
            int nivelMedio = listaNiveis.Count(n => n == "Medio");
            int nivelDificil = listaNiveis.Count(n => n == "Dificil");

            // Agora divide o tempo de acordo com o nível de dificuldade
            double tempoFacil = tempoTotal * 0.2; // 20% do tempo total para tarefas fáceis
            double tempoMedio = tempoTotal * 0.3; // 30% do tempo total para tarefas médias
            double tempoDificil = tempoTotal * 0.5; // 50% do tempo total para tarefas difíceis

            // E agora dividimos o tempo entre as tarefas de cada nível
            double tempoPorFacil = (nivelFacil > 0) ? tempoFacil / nivelFacil : 0;
            double tempoPorMedio = (nivelMedio > 0) ? tempoMedio / nivelMedio : 0;
            double tempoPorDificil = (nivelDificil > 0) ? tempoDificil / nivelDificil : 0;

            // Limpamos a lista para evitar adicionar valores duplicados
            listBoxTarefas.Items.Clear();

            // Agora exibimos as tarefas com o tempo calculado
            for (int i = 0; i < listaTarefas.Count; i++)
            {
                string nome = listaTarefas[i]; // Pegamos o nome da tarefa
                string nivel = listaNiveis[i]; // Pegamos o nível de dificuldade

                // Definimos o tempo correspondente ao nível da tarefa
                double tempoTarefa = (nivel == "Facil") ? tempoPorFacil :
                                     (nivel == "Medio") ? tempoPorMedio :
                                     tempoPorDificil;

                // Exibimos a tarefa na listBox com seu respectivo tempo formatado
                listBoxTarefas.Items.Add($"{nome} - {nivel} - {ConverterParaHorasMinutos(tempoTarefa)}");
            }
        }

        private int ConverterTempo(string entradaTempo)
        {
            int totalMinutos = 0;

            // Verifica se a entrada contém "h" (horas)
            if (entradaTempo.Contains("h"))
            {
                string[] partes = entradaTempo.Split('h');
                if (int.TryParse(partes[0], out int horas))
                {
                    totalMinutos += horas * 60; // Converte horas para minutos
                }

                if (partes.Length > 1 && int.TryParse(partes[1].Replace("min", ""), out int minutos))
                {
                    totalMinutos += minutos; // Adiciona os minutos
                }
            }
            else if (entradaTempo.Contains("min")) // Se for só minutos
            {
                if (int.TryParse(entradaTempo.Replace("min", ""), out int minutos))
                {
                    totalMinutos += minutos;
                }
            }
            else // Caso o usuário digite apenas um número (assumimos que são minutos)
            {
                if (int.TryParse(entradaTempo, out int minutos))
                {
                    totalMinutos = minutos;
                }
            }

            return totalMinutos;
        }

        private string ConverterParaHorasMinutos(double tempoEmMinutos)
        {
            int horas = (int)(tempoEmMinutos / 60);
            int minutos = (int)(tempoEmMinutos % 60);
            return $"{horas}h{minutos}min";
        }

        private void buttonDistribuirTempo_Click(object sender, EventArgs e)
        {
            DividirTempo(); // Chama o método para dividir o tempo quando o botão for clicado.
        }






    }
}
