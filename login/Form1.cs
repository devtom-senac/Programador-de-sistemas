namespace Login
{
    public partial class FormLogin : Form
    {

        List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo.vitar", "sukuna.silva" };
        List<string> listaSenhas = new List<string>() { "bruna", "12345", "777" };

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuarioBuscado = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                labelResultado.Text = "Usuario eh obrigatorio!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            if (senha == null || senha == "")
            {
                labelResultado.Text = "Senha eh obrigatoria!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

            int posicaoUsuarioEncontrado = -1;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (usuarioBuscado == listaUsuarios[i])
                {
                    posicaoUsuarioEncontrado = i;
                }
            }

            if (posicaoUsuarioEncontrado > -1 && senha == listaSenhas[posicaoUsuarioEncontrado])
            {
                labelResultado.Text = "Autenticado com sucesso!";
                labelResultado.ForeColor = Color.Green;
            }
            else
            {
                labelResultado.Text = "Usuario ou Senha incorretos...";
                labelResultado.ForeColor = Color.Red;
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string novoUsuario = textBoxUsuario.Text;
            string NovaSenha = textBoxSenha.Text;

            bool usuarioEncontrado = false;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (novoUsuario == listaUsuarios[i])
                {
                    usuarioEncontrado = true;
                }
            }

            if (!usuarioEncontrado)
            {
                listaUsuarios.Add(novoUsuario);
                listaSenhas.Add(novoUsuario);
                labelNovoUsuario.Text = "Usuário cadastrado com sucesso";
            }
            else
            {
                labelNovoUsuario.Text = "já existe";
            }

        }
    }
}