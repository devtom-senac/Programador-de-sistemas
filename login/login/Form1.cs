namespace login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void entrar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;

            string senha = TextBoxSenha.Text;

            if (string.IsNullOrWhiteSpace(usuario))
            {
                LabelResultado.Text = "Usuario é obrigatorio !!!";
                LabelResultado.ForeColor = Color.Red;
                return;
            }

            if (senha == null || senha == "")
            {
                LabelResultado.Text = "Senha é obrigatoria !!!";
                LabelResultado.ForeColor = Color.Green;  
                return;
            }

            if (usuario == "Rafael.sousa" && senha == "12345")
            {
                LabelResultado.Text = "Autenticado com sucesso";
            }
            else
            {
                LabelResultado.Text = "Usuario ou Senha incorretos...";
            }

        }

    }
}

