using panorama.repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using panorama;
using panorama.dominio;
using MySql.Data.MySqlClient;
using panorama.bancoDeDados;
using costura;


namespace panorama
{
    public partial class historico : Form
    {
        public historico()
        {
            InitializeComponent();
        }



        private void historico_Load(object sender, EventArgs e)
        {
            CarregarHistorico();
        }

        private void CarregarHistorico()
        {
            string query = "SELECT * FROM pedido WHERE situacao = 'concluído' OR situacao = 'cancelado'";

            using (MySqlConnection conexao = DataBase.GetConnection())
            {
                conexao.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dataGridHistorico.DataSource = dt;
                }
            }
        }

        private void lbl_cadastrar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();

            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            pedido pedido = new pedido();
            pedido.Show();

            this.Hide();
        }
    }
}
