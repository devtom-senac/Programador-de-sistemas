using panorama.repositorio;

namespace panorama.dominio
{
    internal class Pedido
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; }
        public string Telefone { get; set; }
        public decimal Preco { get; set; }
        public string Pagamento { get; set; }
        public DateTime DataEntrega { get; set; }
        public string Situacao { get; set; }

        public string ValidarNomeCliente()
        {
            if (string.IsNullOrWhiteSpace(NomeCliente))
            {
                return "O nome não pode ser vazio.";
            }

            if (!NomeCliente.Contains(' '))
            {
                return "O nome deve ter pelo menos um sobrenome.";
            }

            if (NomeCliente.Any(char.IsNumber))
            {
                return "O nome não pode ter números.";
            }

            if (NomeCliente.Any(char.IsSymbol))
            {
                return "O nome não pode ter caracteres especiais.";
            }

            return string.Empty;
        }

        public string ValidarTelefone()
        {
            if (string.IsNullOrEmpty(Telefone))
            {
                return string.Empty;
            }

            if (Telefone.Length != 11)
            {
                return "O telefone deve ter 11 digitos.";
            }

            if (!Telefone.All(char.IsNumber))
            {
                return "O telefone só deve ter numeros.";
            }

            return string.Empty;
        }

        public string ValidarPreco()
        {
            if (Preco < 0)
            {
                return "O valor deve ser maior ou igual a R$ 0,00.";
            }
            return string.Empty;
        }

        public string ValidarPagamento()
        {
            if (string.IsNullOrWhiteSpace(Pagamento))
            {
                return "O pagamento não pode ser vazio.";
            }
            return string.Empty;
        }

        public string ValidarDataEntrega()
        {
            if (DataEntrega < DateTime.Now)
            {
                return "A data deve ser uma data futura.";
            }


            return string.Empty;
        }

        public string ValidarSituacao()
        {
            if (string.IsNullOrWhiteSpace(Situacao))
            {
                return "A situação não pode ser vazia.";
            }

            return string.Empty;
        }



        public void Criar()
        {
            //PedidoRepositorio pedidoRepositorio = new PedidoRepositorio();

            //var pedidoRepositorio = new PedidoRepositorio();

            PedidoRepositorio pedidoRepositorio = new ();

            pedidoRepositorio.Criar(this);
        }
    }
}
