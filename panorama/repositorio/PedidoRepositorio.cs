using MySql.Data.MySqlClient;
using panorama.bancoDeDados;
using panorama.dominio;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panorama.repositorio
{
    internal class PedidoRepositorio
    {
        public void Criar(Pedido novoPedido)
        {
            try
            {
                // Cria a conexão com o banco de dados usando a classe DataBase
                using var conexao = DataBase.GetConnection();
                conexao.Open(); // Abre a conexão com o banco

                // Comando SQL para inserir os dados do pedido
                var query = @"INSERT INTO pedido 
                              (nome_cliente, telefone, data_entrega, preco, pagamento, situacao) 
                              VALUES (@nome, @telefone, @dataEntrega, @preco, @pagamento, @situacao)";

                // Cria o comando MySQL e vincula à conexão aberta
                using var comando = new MySqlCommand(query, conexao);

                // Define os valores que serão inseridos na query com base no objeto novoPedido
                comando.Parameters.AddWithValue("@nome", novoPedido.NomeCliente);
                comando.Parameters.AddWithValue("@telefone", novoPedido.Telefone);
                comando.Parameters.AddWithValue("@dataEntrega", novoPedido.DataEntrega);
                comando.Parameters.AddWithValue("@preco", novoPedido.Preco);
                comando.Parameters.AddWithValue("@pagamento", novoPedido.Pagamento);
                comando.Parameters.AddWithValue("@situacao", novoPedido.Situacao);

                // Executa o comando de inserção no banco de dados
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                // Caso ocorra algum erro na conexão ou na execução da query, mostra uma mensagem para o usuário
                System.Windows.Forms.MessageBox.Show("Erro ao inserir no banco: " + ex.Message);
            }
        }

        public List<Pedido> Listar()
        {
            // Cria uma lista vazia que será preenchida com os pedidos do banco
            List<Pedido> pedidos = new List<Pedido>();

            try
            {
                // Usa a classe de conexão centralizada para abrir conexão com o MySQL
                using var conexao = DataBase.GetConnection();
                conexao.Open(); // Abre a conexão com o banco de dados

                // Comando SQL para buscar todos os campos da tabela 'pedido'
                string query = @"SELECT id, nome_cliente, telefone, data_entrega, preco, pagamento, situacao FROM pedido";

                // Cria o comando SQL, associado à conexão aberta
                using var comando = new MySqlCommand(query, conexao);

                // Executa o comando e obtém um leitor de dados (MySqlDataReader)
                using var reader = comando.ExecuteReader();

                // Enquanto houver linhas para ler no resultado da consulta
                while (reader.Read())
                {
                    // Cria um novo objeto Pedido e preenche com os dados da linha atual
                    Pedido p = new Pedido
                    {
                        Id = Convert.ToInt32(reader["id"]),
                        NomeCliente = reader["nome_cliente"].ToString(),
                        Telefone = reader["telefone"].ToString(),
                        DataEntrega = Convert.ToDateTime(reader["data_entrega"]),
                        Preco = Convert.ToDecimal(reader["preco"]),
                        Pagamento = reader["pagamento"].ToString(),
                        Situacao = reader["situacao"].ToString()
                    };

                    // Adiciona o pedido à lista
                    pedidos.Add(p);
                }
            }
            catch (MySqlException ex)
            {
                // Caso ocorra algum erro de conexão ou execução, mostra mensagem na tela
                System.Windows.Forms.MessageBox.Show("Erro ao buscar pedidos: " + ex.Message);
            }

            // Retorna a lista completa com os pedidos encontrados
            return pedidos;
        }

        // Metodo que atualiza o pedido quando clicar no botão atualizar 
        public void Atualizar(Pedido pedido)
        {
            try
            {
                using var con = DataBase.GetConnection();
                con.Open();

                string sql = @"UPDATE pedido 
                       SET nome_cliente = @nome, 
                           telefone = @telefone, 
                           preco = @preco, 
                           pagamento = @pagamento, 
                           data_entrega = @entrega, 
                           situacao = @situacao 
                       WHERE id = @id";

                using var cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", pedido.NomeCliente);
                cmd.Parameters.AddWithValue("@telefone", pedido.Telefone);
                cmd.Parameters.AddWithValue("@preco", pedido.Preco);
                cmd.Parameters.AddWithValue("@pagamento", pedido.Pagamento);
                cmd.Parameters.AddWithValue("@entrega", pedido.DataEntrega.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@situacao", pedido.Situacao);
                cmd.Parameters.AddWithValue("@id", pedido.Id);

                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("Erro ao atualizar pedido: " + ex.Message);
            }
        }

        public List<Pedido> BuscarHistorico()
        {
            var lista = new List<Pedido>();

            string query = "SELECT * FROM pedido WHERE situacao = 'Concluído' OR situacao = 'Cancelado'";

            using var conexao = DataBase.GetConnection();
            conexao.Open();
            using var comando = new MySqlCommand(query, conexao);
            using var reader = comando.ExecuteReader();

            while (reader.Read())
            {
                var p = new Pedido
                {
                    Id = Convert.ToInt32(reader["id"]),
                    NomeCliente = reader["nome_cliente"].ToString(),
                    Telefone = reader["telefone"].ToString(),
                    DataEntrega = Convert.ToDateTime(reader["data_entrega"]),
                    Preco = Convert.ToDecimal(reader["preco"]),
                    Pagamento = reader["pagamento"].ToString(),
                    Situacao = reader["situacao"].ToString()
                };
                lista.Add(p);
            }

            return lista;
        }

        public List<Pedido> ListarPedidosAtivos()
        {
            var lista = new List<Pedido>();

            string query = "SELECT * FROM pedido WHERE situacao != 'Cancelado' AND situacao != 'Concluído'";

            using var conexao = DataBase.GetConnection();
            conexao.Open();
            using var comando = new MySqlCommand(query, conexao);
            using var reader = comando.ExecuteReader();

            while (reader.Read())
            {
                var p = new Pedido
                {
                    Id = Convert.ToInt32(reader["id"]),
                    NomeCliente = reader["nome_cliente"].ToString(),
                    Telefone = reader["telefone"].ToString(),
                    DataEntrega = Convert.ToDateTime(reader["data_entrega"]),
                    Preco = Convert.ToDecimal(reader["preco"]),
                    Pagamento = reader["pagamento"].ToString(),
                    Situacao = reader["situacao"].ToString()
                };
                lista.Add(p);
            }

            return lista;
        }

        public List<Pedido> ListarPedidosFinalizados()
        {
            List<Pedido> pedidos = new List<Pedido>();

            string query = "SELECT * FROM pedidos WHERE LOWER(situacao) IN ('concluído', 'cancelado')";

            using var conexao = DataBase.GetConnection();
            conexao.Open();
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand(query, conexao);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Pedido p = new Pedido
                        {
                            Id = reader.GetInt32("id"),
                            NomeCliente = reader.GetString("nome_cliente"),
                            Telefone = reader.GetString("telefone"),
                            Preco = reader.GetDecimal("preco"),
                            Pagamento = reader.GetString("pagamento"),
                            DataEntrega = reader.GetDateTime("data_entrega"),
                            Situacao = reader.GetString("situacao")
                        };
                        pedidos.Add(p);
                    }
                }
            }

            return pedidos;
        }
    }
}
