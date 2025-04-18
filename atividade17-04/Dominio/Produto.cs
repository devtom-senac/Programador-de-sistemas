using atividade17_04.Repositorio;

namespace atividade17_04.Dominio
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateOnly Data { get; set; }

        private readonly ProdutoRepositorio repositorio = new();

        public bool CriarProduto()
        {
            if (!ValidarNome())
                return false;

            repositorio.CriarProduto(Nome); // Chama repositório para inserir
            return true;
        }

        private bool ValidarNome()
        {
            return !string.IsNullOrWhiteSpace(Nome);
        }

        public List<Produto> ListarProdutos()
        {
            return repositorio.ExibirProdutos(); // Chama repositório para listar
        }

        public void RemoverProduto()
        {
            repositorio.Remover(Id);
        }

    }
}
