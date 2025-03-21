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
            return true; // Campo v�lido
        }

        // M�todo para validar campos que n�o podem conter n�meros
        private bool ValidarSemNumeros(string texto, string nomeCampo)
        {
            if (texto.Any(char.IsDigit))
            {
                labelRetorno.Text = "O campo " + nomeCampo + " n�o pode conter n�meros.";
                return false; // Campo inv�lido
            }
            return true; // Campo v�lido
        }

        // M�todo para validar campos que s� podem conter n�meros
        private bool ValidarApenasNumeros(string texto, string nomeCampo)
        {
            if (!texto.All(char.IsDigit))
            {
                labelRetorno.Text = "O campo " + nomeCampo + " deve conter apenas n�meros.";
                return false; // Campo inv�lido
            }
            return true; // Campo v�lido
        }

        // M�todo para validar o formato do e-mail
        private bool ValidarEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                labelRetorno.Text = "O e-mail deve estar em um formato v�lido (ex: usuario@gmail.com).";
                return false; // Campo inv�lido
            }
            return true; // Campo v�lido
        }

        // M�todo para validar a data de nascimento
        private bool ValidarNascimento(string data)
        {
            if (!DateTime.TryParse(data, out DateTime dataNascimento) || dataNascimento > DateTime.Now)
            {
                labelRetorno.Text = "Data inv�lida! Use o formato 00/00/0000 e verifique se n�o � futura.";
                return false; // Campo inv�lido
            }
            return true; // Campo v�lido
        }

        // M�todo para validar se um valor (e-mail ou telefone) � �nico
        private bool ValidarNumeroUnico(string valor, string tipo, List<Cliente> clientes)
        {
            if (tipo == "Email" && clientes.Any(cliente => cliente.Email == valor))
            {
                labelRetorno.Text = "Erro: E-mail j� cadastrado.";
                return false;
            }

            if (tipo == "Telefone" && clientes.Any(c => c.Telefone == valor))
            {
                labelRetorno.Text = "Erro: Telefone j� cadastrado.";
                return false;
            }

            return true;
        }

        // M�todo para validar se uma das CheckBox foi selecionada
        // M�todo para validar se o ComboBox de G�nero tem um item selecionado
        private bool ValidarComboBoxGenero(ComboBox comboBoxGenero)
        {
            if (comboBoxGenero.SelectedItem == null || comboBoxGenero.SelectedIndex == -1)
            {
                labelRetorno.Text = "Erro: O campo G�nero deve ser selecionado.";
                comboBoxGenero.Focus(); // Define o foco no ComboBox de G�nero
                return false; // Campo inv�lido
            }
            return true; // Campo v�lido
        }

        // M�todo para validar o CheckBox 
        private bool ValidarCheckBoxEstrangeiro(CheckBox checkBoxSim, CheckBox checkBoxNao)
        {
            // Verifica se ambas est�o marcadas
            if (checkBoxSim.Checked && checkBoxNao.Checked)
            {
                labelRetorno.Text = "Selecione apenas uma op��o para 'Estrangeiro'.";
                return false; // Inv�lido
            }

            // Verifica se nenhuma est� marcada
            if (!checkBoxSim.Checked && !checkBoxNao.Checked)
            {
                labelRetorno.Text = "Selecione uma op��o para SIM ou N�O";
                return false; // Inv�lido
            }

            return true; // V�lido
        }

        // M�todo para gerar um novo ID �nico
        private int GerarNovoId(List<Cliente> clientes)
        {
            return clientes.Count == 0 ? 1 : clientes.Max(cliente => cliente.Id) + 1;
        }

        private bool EmailJaExiste(string email, List<Cliente> clientes)
        {
            return clientes.Any(cliente => cliente.Email == email);
        }

        // Verifica se o telefone j� existe
        private bool TelefoneJaExiste(string telefone, List<Cliente> clientes)
        {
            return clientes.Any(cliente => cliente.Telefone == telefone);
        }


        private void buttonCadastrar_Click_1(object sender, EventArgs e)
        {
            // Valida��o do nome
            if (!ValidarCampo(textBoxNomeCliente.Text, "Nome do Cliente") || !ValidarSemNumeros(textBoxNomeCliente.Text, "Nome do Cliente"))
            {
                textBoxNomeCliente.Focus();
                return;
            }

            // Valida��o do e-mail
            if (!ValidarCampo(textBoxEmail.Text, "E-mail") || !ValidarEmail(textBoxEmail.Text) || !ValidarNumeroUnico(textBoxEmail.Text, "Email", Clientes))
            {
                textBoxEmail.Focus();
                return;
            }

            // Valida��o do telefone
            if (!ValidarCampo(maskedTextBoxTelefone.Text, "Telefone") || !ValidarApenasNumeros(maskedTextBoxTelefone.Text, "Telefone") || !ValidarNumeroUnico(maskedTextBoxTelefone.Text, "Telefone", Clientes))
            {
                maskedTextBoxTelefone.Focus();
                return;
            }

            // Valida��o da data de nascimento
            if (!ValidarCampo(maskedTextBoxData.Text, "Data de Nascimento") || !ValidarNascimento(maskedTextBoxData.Text))
            {
                maskedTextBoxData.Focus();
                return;
            }

            // Valida��o Estrangeiro
            if (!ValidarCheckBoxEstrangeiro(checkBoxSim, checkBoxNao))
            {
                return;
            }

            // Valida��o Genero
            if (comboBoxGenero.SelectedItem == null)
            {
                labelRetorno.Text = "Erro: Selecione um g�nero v�lido.";
                comboBoxGenero.Focus();
                return;
            }

            // Gera um novo ID �nico
            int novoId = GerarNovoId(Clientes);

            if (EmailJaExiste(textBoxEmail.Text, Clientes))
            {
                labelRetorno.Text = "Erro: E-mail j� cadastrado.";
                textBoxEmail.Focus();
                return;
            }

            if (!ValidarCampo(maskedTextBoxTelefone.Text, "Telefone") || !ValidarApenasNumeros(maskedTextBoxTelefone.Text, "Telefone"))
            {
                maskedTextBoxTelefone.Focus();
                return;
            }

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
                Genero = (GeneroCliente)comboBoxGenero.SelectedItem, // Converte para o Enum GeneroCliente
                Etnia = (EtniaCliente)comboBoxEtnia.SelectedItem,    // Converte para o Enum EtniaCliente
                Tipo = (TipoCliente)comboBoxTipo.SelectedItem,       // Converte para o Enum TipoCliente
                Estrangeiro = checkBoxSim.Checked, // Valor das CheckBox (true se "Sim", false se "N�o")
                Endereco = endereco // Atribui o endere�o ao cliente
            };

            // Adiciona o novo cliente � lista
            Clientes.Add(novoCliente);

            // Atualiza o BindingSource para refletir as mudan�as no DataGridView
            BindingSource.ResetBindings(false);

            // Mensagem de sucesso
            labelRetorno.Text = "Cliente cadastrado com sucesso!";
        }
    }
}