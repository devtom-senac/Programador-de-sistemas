namespace CadastroCliente
{
    public partial class CriarClientes : Form
    {
        private readonly List<Cliente> Clientes = [];
        private readonly BindingSource BindingSource = [];


        public CriarClientes()
        {
            InitializeComponent();

            comboBoxGenero.DataSource = Enum.GetValues(typeof(GeneroCliente));

            // Carrega os valores do Enum EtniaCliente no ComboBox
            comboBoxEtnia.DataSource = Enum.GetValues(typeof(EtniaCliente));

            // Carrega os valores do Enum TipoCliente no ComboBox
            comboBoxTipo.DataSource = Enum.GetValues(typeof(TipoCliente));


            // Exemplos de clientes pr�-cadastrados
            EnderecoCliente enderecoRafael = new EnderecoCliente()
            {
                Logradouro = "Rua do Rafael",
                Numero = "10",
                Bairro = "Jardim do Futebol",
                Complemento = "casa",
                CEP = "12345-300",
                Municipio = "S�o Paulo",
                Estado = "SP"
            };

            Cliente rafael = new Cliente()
            {
                Id = 1,
                Nome = "Rafael Silva",
                DataNascimento = "31/08/1991",
                Etnia = EtniaCliente.Branco,
                Tipo = TipoCliente.PF,
                Endereco = enderecoRafael,
                Email = "rafaeljr@gmail.com",
                Telefone = "11 91020-3040",
                Genero = GeneroCliente.Cisgenero,
                Estrangeiro = false
            };
            Clientes.Add(rafael);

            EnderecoCliente enderecoVanda = new EnderecoCliente()
            {
                Logradouro = "Endere�o dos pais do Rafael",
                Numero = "301",
                Bairro = "Jardim dos pais",
                Complemento = "casa",
                CEP = "17858-300",
                Municipio = "S�o Paulo",
                Estado = "SP"
            };

            Cliente vanda = new Cliente()
            {
                Id = 2,
                Nome = "Vanda Maria",
                DataNascimento = "08/03/1958",
                Etnia = EtniaCliente.Branco,
                Tipo = TipoCliente.PF,
                Endereco = enderecoVanda,
                Email = "vandajr@gmail.com",
                Telefone = "11 91020-3040",
                Genero = GeneroCliente.Cisgenero,
                Estrangeiro = false
            };
            Clientes.Add(vanda);

            EnderecoCliente enderecoJoao = new EnderecoCliente()
            {
                Logradouro = "Endere�o dos pais do Rafael",
                Numero = "301",
                Bairro = "Jardim dos pais",
                Complemento = "casa",
                CEP = "17858-300",
                Municipio = "S�o Paulo",
                Estado = "SP"
            };

            Cliente joao = new Cliente()
            {
                Id = 3,
                Nome = "Joao Sousa",
                DataNascimento = "14/07/1962",
                Etnia = EtniaCliente.Preto,
                Tipo = TipoCliente.PF,
                Endereco = enderecoJoao
            };
            Clientes.Add(joao);

            BindingSource.DataSource = Clientes;
            dataGridView1.DataSource = BindingSource;
        }

        // M�todo para validar se o campo est� vazio ou � nulo
        private bool ValidarCampo(string texto, string nomeCampo)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                labelRetorno.Text = "O campo " + nomeCampo + " n�o pode estar vazio ou conter apenas espa�os em branco.";
                return false; // Campo inv�lido
            }
            return true;
        }

        // M�todo para validar campos que n�o podem conter n�meros
        private bool ValidarSemNumeros(string texto, string nomeCampo)
        {
            if (texto.Any(char.IsDigit))
            {
                labelRetorno.Text = "O campo " + nomeCampo + " n�o pode conter n�meros.";
                return false;
            }
            return true;
        }

        // M�todo para validar o formato do e-mail
        private bool ValidarEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                labelRetorno.Text = "O e-mail deve estar em um formato v�lido (ex: usuario@gmail.com).";
                return false; // Campo inv�lido
            }
            return true;
        }

        // M�todo para validar a data de nascimento
        private bool ValidarNascimento(string data)
        {
            if (!DateTime.TryParse(data, out DateTime dataNascimento) || dataNascimento > DateTime.Now)
            {
                labelRetorno.Text = "Data inv�lida! Use o formato 00/00/0000 e verifique se n�o � futura.";
                return false; // Campo inv�lido
            }
            return true;
        }

        // M�todo para validar o CheckBox 
        private bool ValidarCheckBoxEstrangeiro(CheckBox checkBoxSim, CheckBox checkBoxNao)
        {

            if (checkBoxSim.Checked && checkBoxNao.Checked)
            {
                labelRetorno.Text = "Selecione apenas uma op��o para 'Estrangeiro'.";
                return false;
            }

            // Verifica se nenhuma est� marcada
            if (!checkBoxSim.Checked && !checkBoxNao.Checked)
            {
                labelRetorno.Text = "Selecione uma op��o para SIM ou N�O";
                return false;
            }

            return true;
        }

        // AREA DE M�TODOS PRINCIPAIS 

        private bool ValidarEmailUnico(string valor, string tipo, List<Cliente> clientes)
        {
            if (tipo == "Email" && clientes.Any(cliente => cliente.Email == valor))
            {
                labelRetorno.Text = "Erro: E-mail j� cadastrado.";
                return false;
            }

            return true;
        }
        //TELEFONE
        private bool ValidarNumeroUnico(string valor, string tipo, List<Cliente> clientes)
        {
            if (tipo == "Telefone" && clientes.Any(numero => numero.Telefone == valor))
            {
                labelRetorno.Text = "Erro: Telefone j� cadastrado.";
                return false;
            }

            return true;
        }

        //ID
        private int GerarNovoId(List<Cliente> clientes)
        {
            return clientes.Count == 0 ? 1 : clientes.Max(cliente => cliente.Id) + 1;
        }

        private void buttonCadastrar_Click_1(object sender, EventArgs e)
        {
            //AREA DE VALIDACOES BASICAS 

            // nome
            if (!ValidarCampo(textBoxNomeCliente.Text, "Nome do Cliente") || !ValidarSemNumeros(textBoxNomeCliente.Text, "Nome do Cliente"))
            {
                textBoxNomeCliente.Focus();
                return;
            }

            //  data de nascimento
            if (!ValidarCampo(maskedTextBoxData.Text, "Data de Nascimento") || !ValidarNascimento(maskedTextBoxData.Text))
            {
                maskedTextBoxData.Focus();
                return;
            }

            // Estrangeiro SIM / N�O
            if (!ValidarCheckBoxEstrangeiro(checkBoxSim, checkBoxNao))
            {
                return;
            }

            // Genero
            if (comboBoxGenero.SelectedItem == null)
            {
                labelRetorno.Text = "Erro: Selecione um g�nero v�lido.";
                comboBoxGenero.Focus();
                return;
            }

            // AREA DE VALIDA��ES PRINCIPAIS

            // Gera um novo ID �nico
            int novoId = GerarNovoId(Clientes);

            if (!ValidarCampo(textBoxEmail.Text, "E-mail") || !ValidarEmailUnico(textBoxEmail.Text, "Email", Clientes) || !ValidarNumeroUnico(textBoxEmail.Text, "Email", Clientes))
            {
                textBoxEmail.Focus();
                return;
            }

            // telefone
            if (!ValidarCampo(maskedTextBoxTelefone.Text, "Telefone") || !ValidarNumeroUnico(maskedTextBoxTelefone.Text, "Telefone", Clientes))
            {
                maskedTextBoxTelefone.Focus();
                return;
            }


            // AREA DE ADICIONAR O NOVO CLIENTE 


            // Cria o endere�o do cliente
            EnderecoCliente endereco = new EnderecoCliente
            {
                Logradouro = textBoxLogradouro.Text,
                Numero = textBoxNumero.Text,
                Bairro = textBoxBairro.Text,
                Complemento = textBoxComplemento.Text,
                CEP = maskedTextBoxCep.Text,
                Municipio = textBoxMunicipio.Text,
                Estado = textBoxEstado.Text // Supondo que o estado est� em um ComboBox
            };

            // Cria o novo cliente
            Cliente novoCliente = new Cliente
            {
                Id = novoId, // Usa o ID gerado
                Nome = textBoxNomeCliente.Text,
                Email = textBoxEmail.Text,
                Telefone = maskedTextBoxTelefone.Text,
                DataNascimento = maskedTextBoxData.Text,
                Genero = (GeneroCliente)comboBoxGenero.SelectedItem,
                Etnia = (EtniaCliente)comboBoxEtnia.SelectedItem,
                Tipo = (TipoCliente)comboBoxTipo.SelectedItem,
                Estrangeiro = checkBoxSim.Checked,
                Endereco = endereco
            };


            Clientes.Add(novoCliente);


            BindingSource.ResetBindings(false);


            labelRetorno.Text = "Cliente cadastrado com sucesso!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingSource.ResetBindings(false);
        }
    }
}