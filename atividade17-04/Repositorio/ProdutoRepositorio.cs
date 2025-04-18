using atividade17_04.Banco_de_dados;
using atividade17_04.Dominio;
using MySql.Data.MySqlClient;

namespace atividade17_04.Repositorio
{
    internal class ProdutoRepositorio
    {
        public void CriarProduto(string nome)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO produto (nome) VALUES (@nome);";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public List<Produto> ExibirProdutos()
        {
            List<Produto> produtos = new();

            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM produto;";

                using (var cmd = new MySqlCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Produto produto = new Produto
                        {
                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Data = DateOnly.FromDateTime(reader.GetDateTime("data_produto"))
                        };

                        produtos.Add(produto);
                    }
                }
            }

            return produtos;
        }

        public void Remover(int id)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "DELETE FROM produto WHERE id = @id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
