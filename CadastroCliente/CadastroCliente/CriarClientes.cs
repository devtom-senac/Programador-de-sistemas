namespace CadastroCliente
{
    public partial class CriarClientes : Form
    {
        private readonly List<Cliente> Clientes = [];
        
        //Metodo para validar se o campo digitos vazios ou � nulo
        private bool ValidarCampo(string texto, string nomeCampo)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                labelRetorno.Text = "O campo n�o pode estar vazio ou conter apenas espa�os em branco.";
                return false; // Campo inv�lido
            }
            return true; // Campo v�lido
        }

        //Metodo para campos que n�o podem ter numeros
        private bool ValidarSemNumeros(string texto, string nomeCampo)
        {
            if (texto.Any(char.IsDigit))
            {
                labelRetorno.Text = "O campo " + nomeCampo + " n�o pode conter n�meros.";
                return false; // Campo inv�lido
            }
            return true; // Campo v�lido
        }

        //Metodo para campos que s� podem ter numeros
        private bool ValidarApenasNumeros(string texto, string nomeCampo)
        {
            if (!texto.All(char.IsDigit))
            {
                labelRetorno.Text = "O campo " + nomeCampo + " deve conter apenas n�meros.";
                return false; // Campo inv�lido
            }
            return true; // Campo v�lido
        }

        //Metodo para validar o email 
        private bool ValidarEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                labelRetorno.Text = "O email deve estar em um formato v�lido (ex: usuario@gmail.com).";
                return false; // Campo inv�lido
            }
            return true; // Campo v�lido
        }

        private bool ValidarNumeroUnico(string numero)
        {
            // Verifica se j� existe um cliente com o mesmo n�mero
            bool numeroExistente = Cliente.Any(cliente => cliente.Endereco.Numero == numero);
            if (numeroExistente)
            {
                labelRetorno.Text = "O n�mero informado j� est� cadastrado.";
                return false;
            }
            return true;
        }

        public CriarClientes()
        {
            InitializeComponent();

            EnderecoCliente enderecoRafael = new EnderecoCliente() { Logradouro = "Rua do Rafael", Numero = "10", Bairro = "Jardim do Futebol", Complemento = "casa", CEP = "12345-300", Municipio = "S�o Paulo", Estado = "SP"};

            Cliente rafael = new Cliente() { Id = 1, Nome = "Rafael Silva", DataNascimento = "31/08/1991", Etnia = EtniaCliente.Branco, Tipo = TipoCliente.PF, Endereco = enderecoRafael, Email = "rafaeljr@gmail.com", Telefone = "11 91020-3040", Genero = GeneroCliente.Cisgenero, Estrangeiro = false };
            Clientes.Add(rafael);

            EnderecoCliente enderecoVanda = new EnderecoCliente() { Logradouro = "Endere�o dos pais do Rafael", Numero = "301" };
            Cliente vanda = new Cliente() { Id = 2, Nome = "Vanda Maria", DataNascimento = "08/03/1958", Etnia = EtniaCliente.Branco, Tipo = TipoCliente.PF, Endereco = enderecoVanda, Email = "vandajr@gmail.com", Telefone = "11 91020-3040", Genero = GeneroCliente.Cisgenero, Estrangeiro = false };
            Clientes.Add(vanda);

            Cliente joao = new Cliente() { Id = 3, Nome = "Joao Sousa", DataNascimento = "14/07/1962", Etnia = EtniaCliente.Preto, Tipo = TipoCliente.PF, Endereco = enderecoVanda };
            Clientes.Add(joao);

            //EnderecoCliente enderecoHeverton = new EnderecoCliente() { Logradouro = "Orcar Freire", Numero = "1012" };
            //Cliente heverton = new Cliente() { Id = 3, Nome = "Heverton Nascimento", DataNascimento = "10/12/2005", Etnia = EtniaCliente.Preto, Tipo = TipoCliente.PF, Endereco = enderecoHeverton };
            //Clientes.Add(heverton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarCampo(textBoxNomeCliente.Text, "Nome do Cliente") || !ValidarSemNumeros(textBoxNomeCliente.Text, "Nome do cliente"))
            {
                textBoxNomeCliente.Focus();
                return;
            }

            // Valida��o para endere�o
            if (!ValidarCampo(textBoxLagradouro.Text, "Logradouro"))
            {
                textBoxLagradouro.Focus();
                return;
            }

            if (!ValidarCampo(textBoxBairro.Text, "Bairro"))
            {
                textBoxBairro.Focus();
                return;
            }

            if (!ValidarCampo(textBoxMunicipio.Text, "Munic�pio") || !ValidarCampo(textBoxMunicipio.Text, "Munic�pio"))
            {
                textBoxMunicipio.Focus();
                return;
            }

            if (!ValidarCampo(textBoxNumero.Text,"Campo do N�mero"))
            {
                textBoxNumero.Focus();
                return;
            }

            if (!ValidarCampo(textBoxEstado.Text, "Estado"))
            {
                textBoxEstado.Focus();
                return;
            }

            if (!ValidarApenasNumeros(maskedTextBoxCep.Text, "o campo CEP"))
            {
                maskedTextBoxCep.Focus();
                return;
            }

            if (!ValidarCampo(textBoxEmail.Text, "Email") || !ValidarEmail(textBoxEmail.Text))
            {
                textBoxEmail.Focus();
                return;
            }

            if (!ValidarApenasNumeros(maskedTextBoxTelefone.Text, "Telefone"))
            {
                maskedTextBoxTelefone.Focus();
                return;
            }

            

        }
    }

}




