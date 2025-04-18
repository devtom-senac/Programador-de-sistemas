using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade17_04.Dominio
{
    internal class Estoque
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public DateOnly Data { get; set; }

        private bool ValidarQuantidade()
        {
            if (Quantidade <= 0)
            {
                return true;
            }
            return false;
        }

        public bool CriarEstoque()
        {
            if (!ValidarQuantidade())
            {
                return false;
            }

            return true;
        }
    }
}
