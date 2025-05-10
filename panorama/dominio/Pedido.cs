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
            // Verifica se está vazio ou só com espaços
            if (string.IsNullOrWhiteSpace(NomeCliente))
            {
                return "O nome não pode ser vazio.";
            }

            // Remove espaços do começo e do fim
            string nomeLimpo = NomeCliente.Trim();

            // Conta quantas palavras tem (nome + sobrenome)
            int espacos = 0;
            for (int i = 0; i < nomeLimpo.Length; i++)
            {
                if (nomeLimpo[i] == ' ')
                {
                    espacos++;
                }
            }

            // Se não tiver pelo menos um espaço no meio, não tem sobrenome
            if (espacos < 1)
            {
                return "O nome deve ter pelo menos um sobrenome.";
            }

            // Verifica se tem número
            foreach (char c in nomeLimpo)
            {
                if (char.IsDigit(c))
                {
                    return "O nome não pode ter números.";
                }
            }

            // Verifica se tem símbolo ou caractere especial
            foreach (char c in nomeLimpo)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return "O nome não pode ter caracteres especiais.";
                }
            }

            // Se passou por tudo, está válido
            return "";
        }

        public string ValidarTelefone()
        {
            if (string.IsNullOrEmpty(Telefone))
            {
                return string.Empty;
            }

            if (!Telefone.All(char.IsNumber))
            {
                return "O telefone só deve ter numeros.";
            }

            if (Telefone.Length != 11)
            {
                return "O telefone deve ter 11 digitos.";
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

        public string ValidarPreco()
        {
            if (Preco < 0)
            {
                return "O valor deve ser maior ou igual a R$ 0,00.";
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

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}
