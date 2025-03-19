using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    internal class EnderecoCliente
    {
        public string Logradouro {  get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

    }
}
