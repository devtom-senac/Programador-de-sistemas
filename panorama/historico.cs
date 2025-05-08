using panorama.repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using panorama;
using panorama.dominio;

namespace panorama
{
    public partial class historico : Form
    {
        public historico()
        {
            InitializeComponent();
        }

        private void CarregarHistorico()
        {
            PedidoRepositorio repositorio = new PedidoRepositorio();
            List<Pedido> pedidosFinalizados = repositorio.ListarPedidosFinalizados();


            dataGridHistorico.DataSource = null; // limpa antes
            dataGridHistorico.DataSource = pedidosFinalizados;

            // Opcional: ajustar nomes das colunas
            dataGridHistorico.Columns["Id"].HeaderText = "Código";
            dataGridHistorico.Columns["NomeCliente"].HeaderText = "Cliente";
            dataGridHistorico.Columns["Telefone"].HeaderText = "Telefone";
            dataGridHistorico.Columns["Preco"].HeaderText = "Preço";
            dataGridHistorico.Columns["Pagamento"].HeaderText = "Pagamento";
            dataGridHistorico.Columns["DataEntrega"].HeaderText = "Entrega";
            dataGridHistorico.Columns["Situacao"].HeaderText = "Status";
        }

        private void historico_Load(object sender, EventArgs e)
        {
            CarregarHistorico();
        }
    }
}
