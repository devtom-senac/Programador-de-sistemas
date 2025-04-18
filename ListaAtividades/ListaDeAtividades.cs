using ListaAtividades.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaAtividades
{
    public partial class ListaDeAtividades : Form
    {
        private Atividade? atividadeEmAndamento;

        public ListaDeAtividades()
        {
            InitializeComponent();
        }

        private void ListaDeAtividades_Load(object sender, EventArgs e)
        {
            labelErro.Text = string.Empty;

            CarregarAtividadesEmAndamento();
            CarregarListaDeAtividades();
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            if (atividadeEmAndamento == null || atividadeEmAndamento.Id <= 0)
            {
                labelErro.Text = "Não há atividade em andamento";
                return;
            }

            if (atividadeEmAndamento.AtualizarSituacao())
            {
                labelErro.Text = "Não foi possível finalizar a atividade";
                return;
            }

            labelErro.Text = string.Empty;
            CarregarAtividadesEmAndamento();
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAtividades.SelectedRows.Count <= 0)
            {
                labelErro.Text = "Selecione uma atividade.";
            }

            var linhaSelecionada = dataGridViewAtividades.SelectedRows[0];

            Atividade atividade = new()
            {
                Id = (int)linhaSelecionada.Cells[0].Value,
                Titulo = (string)linhaSelecionada.Cells[1].Value,
                Situacao = (Situacao)linhaSelecionada.Cells[2].Value,
            };

            if (!atividade.AtualizarSituacao())
            {
                labelErro.Text = "Não foi possivel atualizar a atividade.";
                return;
            }

            labelErro.Text = string.Empty;
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            var resultado = new CriarAtividade().ShowDialog();

            if (resultado != DialogResult.OK)
            {
                labelErro.Text = "Atividade criada com sucesso";
                return;
            }

            labelErro.Text = "Atividade criada com sucesso.";
            CarregarListaDeAtividades();
        }

        private void CarregarListaDeAtividades()
        {
            Atividade atividade = new();

            var atividadesPendentes = atividade.ListarAtividadesPendentes();
            dataGridViewAtividades.DataSource = atividadesPendentes;
        }

        private void CarregarAtividadesEmAndamento()
        {
            Atividade atividade = new Atividade();

            atividadeEmAndamento = atividade.BuscarAtividadesEmAndamento();
            string textoAtividade = $"{atividadeEmAndamento.Id} - {atividadeEmAndamento.Titulo}";
            textBoxAtividadeEmAndamento.Text = atividadeEmAndamento.Id > 0 ? textoAtividade : string.Empty;
        }
    }
}
