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
            set { lbl_nome.Text =  value; }
        }

        public string Telefone
        {
            set { lbl_telefone.Text =  value; }
        }

        public decimal Preco
        {
            set { lbl_preco.Text = value.ToString("F2"); }
        }

        public string Pagamento
        {
            set { lbl_pagamento.Text = value; }
        }

        public DateTime DataEntrega
        {
            set { lbl_entrega.Text = value.ToShortDateString(); }
        }

        public string Situacao
        {
            set { lbl_situacao.Text = value; }
        }
    }
}
