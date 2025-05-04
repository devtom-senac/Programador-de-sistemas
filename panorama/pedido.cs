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
using panorama.repositorio;


namespace costura
{
    public partial class pedido : Form
    {
        public pedido()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrar cadastrar = new cadastrar();
            cadastrar.Show();

            this.Hide();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            pedido pedido = new pedido();
            pedido.Show();

            this.Hide();
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();

            this.Hide();
        }

        private void pedido_Load(object sender, EventArgs e)
        {
            CarregarPedidos(); // Chama o método assim que a tela é aberta
        }

        private void CarregarPedidos()
        {
            // Cria o repositório que acessa o banco
            PedidoRepositorio repositorio = new PedidoRepositorio();

            // Pega todos os pedidos cadastrados no banco
            List<Pedido> listaPedidos = repositorio.Listar();

            // Limpa o painel onde os cards vão ser exibidos
            flow_pedidos.Controls.Clear();

            // Para cada pedido da lista, cria e exibe um card
            foreach (var pedido in listaPedidos)
            {
                // Cria um novo card visual
                var card = new PedidoCard();

                // Preenche os dados do card com as informações do pedido
                card.NomeCliente = pedido.NomeCliente;
                card.Telefone = pedido.Telefone;
                card.Preco = pedido.Preco;
                card.Pagamento = pedido.Pagamento;
                card.DataEntrega = pedido.DataEntrega;
                card.Situacao = pedido.Situacao;

                // Adiciona o card no painel de pedidos
                flow_pedidos.Controls.Add(card);
            }
        }
    }
}
