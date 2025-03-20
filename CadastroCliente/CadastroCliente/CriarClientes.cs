namespace CadastroCliente
{
    public partial class CriarClientes : Form
    {
        private readonly List<Cliente> Clientes = [];
        
        //Metodo para validar se o campo digitos vazios ou é nulo
        private bool ValidarCampo(string texto, string nomeCampo)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                labelRetorno.Text = "O campo" + nomeCampo + "não pode estar vazio ou conter apenas espaços em branco.";
                return false; // Campo inválido
            }
            return true; // Campo válido
        }

        //Metodo para campos que não podem ter numeros
        private bool ValidarSemNumeros(string texto, string nomeCampo)
        {
            if (texto.Any(char.IsDigit))
            {
                labelRetorno.Text = "O campo " + nomeCampo + " não pode conter números.";
                return false; // Campo inválido
            }
            return true; // Campo válido
        }

        //Metodo para campos que só podem ter numeros
        private bool ValidarApenasNumeros(string texto, string nomeCampo)
        {
            if (!texto.All(char.IsDigit))
            {
                labelRetorno.Text = "O campo " + nomeCampo + " deve conter apenas números.";
                return false; // Campo inválido
            }
            return true; // Campo válido
        }

        //Metodo para validar o email 
        private bool ValidarEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                labelRetorno.Text = "O email deve estar em um formato válido (ex: usuario@gmail.com).";
                return false; // Campo inválido
            }
            return true; // Campo válido
        }

        //private bool ValidarNumeroUnico(string numero)

        private bool ValidarNascimento(string data)
        {
            if (DateTime.TryParse(data, out DateTime dataNascimento) && dataNascimento <= DateTime.Now)
            {
                labelRetorno.Text = "Data inválida! Use o formato 00/00/0000 e verifique se não é futura.";
                return true;
            }
            return false;
        }
        public CriarClientes()
        {
            InitializeComponent();

            EnderecoCliente enderecoRafael = new EnderecoCliente() { Logradouro = "Rua do Rafael", Numero = "10", Bairro = "Jardim do Futebol", Complemento = "casa", CEP = "12345-300", Municipio = "São Paulo", Estado = "SP" };

            Cliente rafael = new Cliente() { Id = 1, Nome = "Rafael Silva", DataNascimento = "31/08/1991", Etnia = EtniaCliente.Branco, Tipo = TipoCliente.PF, Endereco = enderecoRafael, Email = "rafaeljr@gmail.com", Telefone = "11 91020-3040", Genero = GeneroCliente.Cisgenero, Estrangeiro = false };
            Clientes.Add(rafael);

            EnderecoCliente enderecoVanda = new EnderecoCliente() { Logradouro = "Endereço dos pais do Rafael", Numero = "301", Bairro = "Jardim dos pais", Complemento = "casa", CEP = "17858-300", Municipio = "São Paulo", Estado = "SP" };

            Cliente vanda = new Cliente() { Id = 2, Nome = "Vanda Maria", DataNascimento = "08/03/1958", Etnia = EtniaCliente.Branco, Tipo = TipoCliente.PF, Endereco = enderecoVanda, Email = "vandajr@gmail.com", Telefone = "11 91020-3040", Genero = GeneroCliente.Cisgenero, Estrangeiro = false };
            Clientes.Add(vanda);

            EnderecoCliente enderecoJoao = new EnderecoCliente() { Logradouro = "Endereço dos pais do Rafael", Numero = "301", Bairro = "Jardim dos pais", Complemento = "casa", CEP = "17858-300", Municipio = "São Paulo", Estado = "SP" };

            Cliente joao = new Cliente() { Id = 3, Nome = "Joao Sousa", DataNascimento = "14/07/1962", Etnia = EtniaCliente.Preto, Tipo = TipoCliente.PF, Endereco = enderecoJoao };
            Clientes.Add(joao);

            //EnderecoCliente enderecoHeverton = new EnderecoCliente() { Logradouro = "Orcar Freire", Numero = "1012" };
            //Cliente heverton = new Cliente() { Id = 3, Nome = "Heverton Nascimento", DataNascimento = "10/12/2005", Etnia = EtniaCliente.Preto, Tipo = TipoCliente.PF, Endereco = enderecoHeverton };
            //Clientes.Add(heverton);
        }

        private bool ValidarNumeroUnico(string valor, string tipo, List<Cliente> clientes)
        {
            if (tipo == "Email" && clientes.Any(cliente => cliente.Email == valor))
            {
                labelRetorno.Text = "Erro: E-mail já cadastrado.";
                return false; 
            }

            if (tipo == "Telefone" && clientes.Any(c => c.Telefone == valor))
            {
                labelRetorno.Text = "Erro: Telefone já cadastrado.";
                return false; 
            }

            return true; 
        }

        private int GerarNovoId(List<Cliente> clientes)
        {
            if (clientes.Count == 0)
            {
                return 1; 
            }
            return clientes.Max(cliente => cliente.Id) + 1; 
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Validação do nome
            if (!ValidarCampo(textBoxNomeCliente.Text, "Nome do Cliente") || !ValidarSemNumeros(textBoxNomeCliente.Text, "Nome do Cliente"))
            {
                textBoxNomeCliente.Focus();
                return;
            }

            // Validação do e-mail
            if (!ValidarCampo(textBoxEmail.Text, "E-mail") || !ValidarEmail(textBoxEmail.Text) || !ValidarNumeroUnico(textBoxEmail.Text, "Email", Clientes))
            {
                textBoxEmail.Focus();
                return;
            }

            // Validação do telefone
            if (!ValidarCampo(maskedTextBoxTelefone.Text, "Telefone") || !ValidarApenasNumeros(maskedTextBoxTelefone.Text, "Telefone") || !ValidarNumeroUnico(maskedTextBoxTelefone.Text, "Telefone", Clientes))
            {
                maskedTextBoxTelefone.Focus();
                return;
            }

            // Validação da data de nascimento
            if (!ValidarCampo(maskedTextBoxData.Text, "Data de Nascimento") || !ValidarNascimento(maskedTextBoxData.Text))
            {
                maskedTextBoxData.Focus();
                return;
            }

            // Gera um novo ID único
            int novoId = GerarNovoId(Clientes);

            // Cria o novo cliente
            Cliente novoCliente = new Cliente
            {
                Id = novoId, // Usa o ID gerado
                Nome = textBoxNomeCliente.Text,
                Email = textBoxEmail.Text,
                Telefone = maskedTextBoxTelefone.Text,
                DataNascimento = maskedTextBoxData.Text
                // Adicione os outros campos aqui
            };

            // Adiciona o novo cliente à lista
            Clientes.Add(novoCliente);

            // Mensagem de sucesso
            labelRetorno.Text = "Cliente cadastrado com sucesso!";
        }
    }

}




