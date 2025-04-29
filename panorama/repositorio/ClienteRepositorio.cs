using panorama.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panorama.repositorio
{
    public class ClienteRepositorio
    {
        public static string CadastrarCliente(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nome) || string.IsNullOrWhiteSpace(cliente.Telefone))
            {
                return "Nome e telefone são obrigatórios.";
            }

            // Simulando sucesso
            return "";
        }
    }
}
