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


            // Exemplos de clientes pré-cadastrados
            EnderecoCliente enderecoRafael = new EnderecoCliente()
            {
                Logradouro = "Rua do Rafael",
                Numero = "10",
                Bairro = "Jardim do Futebol",
                Complemento = "casa",
                CEP = "12345-300",
                Municipio = "São Paulo",
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
                Logradouro = "Endereço dos pais do Rafael",
                Numero = "301",
                Bairro = "Jardim dos pais",
                Complemento = "casa",
                CEP = "17858-300",
                Municipio = "São Paulo",
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
                Logradouro = "Endereço dos pais do Rafael",
                Numero = "301",
                Bairro = "Jardim dos pais",
                Complemento = "casa",
                CEP = "17858-300",
                Municipio = "São Paulo",
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


        // Método para validar se o campo está vazio ou é nulo
        private bool ValidarCampo(string texto, string nomeCampo)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                labelRetorno.Text = "O campo " + nomeCampo + " não pode estar vazio ou conter apenas espaços em branco.";
                return false; // Campo inválido
            }
            return true; // Campo válido
        }

        // Método para validar campos que não podem conter números
        private bool ValidarSemNumeros(string texto, string nomeCampo)
        {
            if (texto.Any(char.IsDigit))
            {
                labelRetorno.Text = "O campo " + nomeCampo + " não pode conter números.";
                return false; // Campo inválido
            }
            return true; // Campo válido
        }

        // Método para validar campos que só podem conter números
        private bool ValidarApenasNumeros(string texto, string nomeCampo)
        {
            if (!texto.All(char.IsDigit))
            {
                labelRetorno.Text = "O campo " + nomeCampo + " deve conter apenas números.";
                return false; // Campo inválido
            }
            return true; // Campo válido
        }

        // Método para validar o formato do e-mail
        private bool ValidarEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                labelRetorno.Text = "O e-mail deve estar em um formato válido (ex: usuario@gmail.com).";
                return false; // Campo inválido
            }
            return true; // Campo válido
        }

        // Método para validar a data de nascimento
        private bool ValidarNascimento(string data)
        {
            if (!DateTime.TryParse(data, out DateTime dataNascimento) || dataNascimento > DateTime.Now)
            {
                labelRetorno.Text = "Data inválida! Use o formato 00/00/0000 e verifique se não é futura.";
                return false; // Campo inválido
            }
            return true; // Campo válido
        }

        // Método para validar se um valor (e-mail ou telefone) é único
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

        // Método para validar se uma das CheckBox foi selecionada
        // Método para validar se o ComboBox de Gênero tem um item selecionado
        private bool ValidarComboBoxGenero(ComboBox comboBoxGenero)
        {
            if (comboBoxGenero.SelectedItem == null || comboBoxGenero.SelectedIndex == -1)
            {
                labelRetorno.Text = "Erro: O campo Gênero deve ser selecionado.";
                comboBoxGenero.Focus(); // Define o foco no ComboBox de Gênero
                return false; // Campo inválido
            }
            return true; // Campo válido
        }

        // Método para validar o CheckBox 
        private bool ValidarCheckBoxEstrangeiro(CheckBox checkBoxSim, CheckBox checkBoxNao)
        {
            // Verifica se ambas estão marcadas
            if (checkBoxSim.Checked && checkBoxNao.Checked)
            {
                labelRetorno.Text = "Selecione apenas uma opção para 'Estrangeiro'.";
                return false; // Inválido
            }

            // Verifica se nenhuma está marcada
            if (!checkBoxSim.Checked && !checkBoxNao.Checked)
            {
                labelRetorno.Text = "Selecione uma opção para SIM ou NÃO";
                return false; // Inválido
            }

            return true; // Válido
        }

        // Método para gerar um novo ID único
        private int GerarNovoId(List<Cliente> clientes)
        {
            return clientes.Count == 0 ? 1 : clientes.Max(cliente => cliente.Id) + 1;
        }

        private bool EmailJaExiste(string email, List<Cliente> clientes)
        {
            return clientes.Any(cliente => cliente.Email == email);
        }

        // Verifica se o telefone já existe
        private bool TelefoneJaExiste(string telefone, List<Cliente> clientes)
        {
            return clientes.Any(cliente => cliente.Telefone == telefone);
        }


        private void buttonCadastrar_Click_1(object sender, EventArgs e)
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

            // Validação Estrangeiro
            if (!ValidarCheckBoxEstrangeiro(checkBoxSim, checkBoxNao))
            {
                return;
            }

            // Validação Genero
            if (comboBoxGenero.SelectedItem == null)
            {
                labelRetorno.Text = "Erro: Selecione um gênero válido.";
                comboBoxGenero.Focus();
                return;
            }

            // Gera um novo ID único
            int novoId = GerarNovoId(Clientes);

            if (EmailJaExiste(textBoxEmail.Text, Clientes))
            {
                labelRetorno.Text = "Erro: E-mail já cadastrado.";
                textBoxEmail.Focus();
                return;
            }

            if (!ValidarCampo(maskedTextBoxTelefone.Text, "Telefone") || !ValidarApenasNumeros(maskedTextBoxTelefone.Text, "Telefone"))
            {
                maskedTextBoxTelefone.Focus();
                return;
            }

            // Cria o endereço do cliente
            EnderecoCliente endereco = new EnderecoCliente
            {
                Logradouro = textBoxLogradouro.Text,
                Numero = textBoxNumero.Text,
                Bairro = textBoxBairro.Text,
                Complemento = textBoxComplemento.Text,
                CEP = maskedTextBoxCep.Text,
                Municipio = textBoxMunicipio.Text,
                Estado = textBoxEstado.Text // Supondo que o estado está em um ComboBox
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
                Estrangeiro = checkBoxSim.Checked, // Valor das CheckBox (true se "Sim", false se "Não")
                Endereco = endereco // Atribui o endereço ao cliente
            };

            // Adiciona o novo cliente à lista
            Clientes.Add(novoCliente);

            // Atualiza o BindingSource para refletir as mudanças no DataGridView
            BindingSource.ResetBindings(false);

            // Mensagem de sucesso
            labelRetorno.Text = "Cliente cadastrado com sucesso!";
        }
    }
}