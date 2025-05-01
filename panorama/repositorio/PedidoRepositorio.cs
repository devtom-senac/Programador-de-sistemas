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
            using var conexao = DataBase.GetConnection();
            conexao.Open();

            var query = "INSERT INTO pedido (nome_cliente, telefone, data_entrega, preco, pagamento, situacao) VALUES (@nome, @telefone, @dataEntrega, @preco, @pagamento, @situacao)";

            using var comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@nome", novoPedido.NomeCliente);
            comando.Parameters.AddWithValue("@telefone", novoPedido.Telefone);
            comando.Parameters.AddWithValue("@dataEntrega", novoPedido.DataEntrega);
            comando.Parameters.AddWithValue("@preco", novoPedido.Preco);
            comando.Parameters.AddWithValue("@pagamento", novoPedido.Pagamento);
            comando.Parameters.AddWithValue("@situacao", novoPedido.Situacao);

            comando.ExecuteNonQuery();
        }
    }
}
