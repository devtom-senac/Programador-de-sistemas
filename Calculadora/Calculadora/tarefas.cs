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
        private void buttonDistribuirTempo_Click(object sender, EventArgs e)
        {
            DividirTempo(); // Chama o método para dividir o tempo quando o botão for clicado.
        }

        

        private void DividirTempo()
        {
            // Verifica se o tempo total é válido
            if (!int.TryParse(textBoxTempo.Text, out int tempoTotal) || tempoTotal <= 0)
            {
                labelRetorno.Text = "Insira o tempo disponível!";
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

                // Exibimos a tarefa na listBox com seu respectivo tempo
                listBoxTarefas.Items.Add($"{nome} - {nivel} - {tempoTarefa:F1} min");
            }
        }



    }
}
