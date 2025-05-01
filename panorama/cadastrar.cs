﻿using panorama.dominio;
using panorama.repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace costura
{
    public partial class cadastrar : Form
    {
        public cadastrar()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadastrar cadastrar = new cadastrar();
            cadastrar.Show();

            this.Hide();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            pedido pedido = new pedido();
            pedido.Show();

            this.Hide();
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();

            this.Hide();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            decimal preco; 
            if (decimal.TryParse(txt_preco.Text, out preco))
            {
                // Convertemos o texto do txt_preco em decimal para pegarmos valor dele
                Pedido pedido = new Pedido
                {
                    NomeCliente = txt_nome.Text,
                    Telefone = txt_telefone.Text,
                    Preco = preco, // agora é decimal
                    DataEntrega = DateTime.TryParse(txt_entrega.Text, out DateTime dataEntrega) ? dataEntrega : DateTime.MinValue, // aqui esta sendo usado ternario ? para realizar ou um metodo ou outro metodo
                    Situacao = txt_situacao.Text,
                    Pagamento = txt_pagamento.Text
                };

                string erroNome = pedido.ValidarNomeCliente();
                if (!string.IsNullOrEmpty(erroNome))
                {
                    MessageBox.Show(erroNome, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Interrompe o fluxo caso haja erro no nome
                }


                pedido.Criar();

                // Exibe uma mensagem de sucesso
                MessageBox.Show("Pedido cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void LimparCampos()
        {
            txt_nome.Text = "";
            txt_telefone.Text = "";
            txt_preco.Text = "";
            txt_entrega.Text = "";
            txt_pagamento.Text = "";
            txt_situacao.Text = "";
        }
    }
}