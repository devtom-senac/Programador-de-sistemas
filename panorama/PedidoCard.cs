using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace panorama
{
    public partial class PedidoCard : UserControl
    {
        public PedidoCard()
        {
            InitializeComponent();
        }

        public string NomeCliente
        {
            set { lbl_nome.Text = "Cliente: " + value; }
        }

        public string Telefone
        {
            set { lbl_telefone.Text = "Telefone: " + value; }
        }

        public decimal Preco
        {
            set { lbl_preco.Text = "Preço: R$ " + value.ToString("F2"); }
        }

        public string Pagamento
        {
            set { lbl_pagamento.Text = "Pagamento: " + value; }
        }

        public DateTime DataEntrega
        {
            set { lbl_entrega.Text = "Entrega: " + value.ToShortDateString(); }
        }

        public string Situacao
        {
            set { lbl_situacao.Text = "Situação: " + value; }
        }
    }
}
