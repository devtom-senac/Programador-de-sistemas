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
        public ListaDeAtividades()
        {
            InitializeComponent();
        }

        private void ListaDeAtividades_Load(object sender, EventArgs e)
        {
            Atividade atividade = new ();

            var atividadeEmAndamento = atividade.BuscarAtividadesEmAndamento();
            if (atividadeEmAndamento.Id > 0)
            {
                textBoxAtividadeEmAndamento.Text = $"{atividadeEmAndamento.Id} - {atividadeEmAndamento.Titulo}";
            }

            var atividadesPendentes = atividade.ListarAtividadesPendentes();
            dataGridViewAtividades.DataSource = atividadesPendentes;
        }
    }
}
