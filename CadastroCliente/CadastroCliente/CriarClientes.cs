namespace CadastroCliente
{
    public partial class CriarClientes : Form
    {
        List<Cliente> clientes = new List<Cliente>();

        public CriarClientes()
        {
            InitializeComponent();

            EnderecoCliente EnderecoNeymar = new EnderecoCliente() 
            {
                Bairro = "Grajau"
            };

            Cliente NomeNeymar = new Cliente()
            {
                Nome = "Neymar Junior",
                NomeSocial = "Menino Ney",
            };

            clientes.Add(new Cliente
            {
                Nome = NomeNeymar,
                Email = "neymar.jr@email.com",
                Endereco = EnderecoNeymar,

            });

            clientes.Add(new Cliente { Nome = "Cristiano Ronaldo", Email = "cristiano.ronaldo@email.com" });
            clientes.Add(new Cliente { Nome = "Lionel Messi", Email = "lionel.messi@email.com"});
        }

        
    }

}




