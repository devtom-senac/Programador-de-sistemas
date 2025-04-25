namespace costura
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            {
                pedido pedido = new pedido();
                pedido.Show();

                this.Hide();
            }
        }

        private void btn_pedido_Click(object sender, EventArgs e)
        {
            cadastrar cadastrar = new cadastrar();
            cadastrar.Show();

            this.Hide();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pedido pedido = new pedido();
            pedido.Show();

            this.Hide();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            pedido pedido = new pedido();
            pedido.Show();

            this.Hide();
        }
    }
}
