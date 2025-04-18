using atividade17_04.Banco_de_dados;
using atividade17_04.Dominio;
using MySql.Data.MySqlClient;

namespace atividade17_04
{
    public partial class ListaProdutos : Form
    {
        public ListaProdutos()
        {
            InitializeComponent();
        }

        private void ListaProdutos_Load(object sender, EventArgs e)
        {
            labelErro.Text = string.Empty;
            CarregarProdutos(); // Carrega ao iniciar
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Produto produto = new()
            {
                Nome = textBoxNomeProduto.Text.Trim()
            };

            if (!produto.CriarProduto())
            {
                labelErro.Text = "Não foi possível criar o produto.";
                return;
            }

            labelErro.Text = "Produto criado com sucesso!";
            CarregarProdutos(); // Atualiza lista após cadastro
        }

        private void CarregarProdutos()
        {
            Produto produto = new();
            List<Produto> lista = produto.ListarProdutos();

            dataGridViewProdutos.DataSource = lista;

            // Formatar coluna de data (opcional)
            if (dataGridViewProdutos.Columns["Data"] != null)
            {
                dataGridViewProdutos.Columns["Data"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            var linha = dataGridViewProdutos.SelectedRows[0];

            Produto produto = new Produto()
            {
                Id = (int)linha.Cells["Id"].Value
            };

            produto.RemoverProduto();

            CarregarProdutos(); 
            labelErro.Text = "Produto removido";
        }


    }
}
