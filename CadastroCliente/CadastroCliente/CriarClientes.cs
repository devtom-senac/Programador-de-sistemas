namespace CadastroCliente
{
    public partial class CriarClientes : Form
    {
        private readonly List<Cliente> Clientes = [];

        private bool validarCampoVazioOuNulo(string texto)
        {
            return string.IsNullOrEmpty(texto);
            labelRetorno.Text = "erro";
        }

        public CriarClientes()
        {
            InitializeComponent();

            EnderecoCliente enderecoRafael = new EnderecoCliente() { Logradouro = "Endereço do Rafael", Numero = "10",  };
            Cliente rafael = new Cliente() { Id = 1, Nome = "Rafael Silva", DataNascimento = "31/08/1991", Etnia = EtniaCliente.Branco, Tipo = TipoCliente.PF, Endereco = enderecoRafael };
            Clientes.Add(rafael);

            EnderecoCliente enderecoVanda = new EnderecoCliente() { Logradouro = "Endereço dos pais do Rafael", Numero = "301" };
            Cliente vanda = new Cliente() { Id = 2, Nome = "Vanda Maria", DataNascimento = "08/03/1958", Etnia = EtniaCliente.Branco, Tipo = TipoCliente.PF, Endereco = enderecoVanda };
            Clientes.Add(vanda);

            Cliente joao = new Cliente() { Id = 3, Nome = "Joao Sousa", DataNascimento = "14/07/1962", Etnia = EtniaCliente.Preto, Tipo = TipoCliente.PF, Endereco = enderecoVanda };
            Clientes.Add(joao);

            //EnderecoCliente enderecoHeverton = new EnderecoCliente() { Logradouro = "Orcar Freire", Numero = "1012" };
            //Cliente heverton = new Cliente() { Id = 3, Nome = "Heverton Nascimento", DataNascimento = "10/12/2005", Etnia = EtniaCliente.Preto, Tipo = TipoCliente.PF, Endereco = enderecoHeverton };
            //Clientes.Add(heverton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //metodo para validar o email vendo se não existe um 
            //para o id, criar um metodo que busque o numero do maior id,e o novo sera a soma dele mais 1
            if (validarCampoVazioOuNulo(textBoxNomeCliente.Text) || textBoxNomeCliente.Text.Any(char.IsNumber))
            {
              
              return;
            }

           


            if (string.IsNullOrWhiteSpace(textBoxEmail.Text) || !textBoxEmail.Text.Contains("@"))
            {
                labelRetorno.Text = "Digite um email válido ex: usuario@gmail.com";
                textBoxEmail.Focus();
                return;
            } 

            if (string.IsNullOrEmpty(textBoxLagradouro.Text))
            {

            }



            EnderecoCliente novoEndereco = new()
            {
               
            };

            Cliente novoCliente = new()
            {

            };
        }
    }

}




