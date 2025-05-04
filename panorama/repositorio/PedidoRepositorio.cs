using MySql.Data.MySqlClient;
using panorama.bancoDeDados;
using panorama.dominio;
using System;
using System.Collections.Generic;
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

                // Enquanto houver linhas para ler no resultado da consulta...
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
    }
}
