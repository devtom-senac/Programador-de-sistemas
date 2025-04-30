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

            //// Validações de campos obrigatórios
            //if (string.IsNullOrWhiteSpace(txt_nome.Text))
            //{
            //    MessageBox.Show("Por favor, preencha o nome.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //if (string.IsNullOrWhiteSpace(txt_telefone.Text))
            //{
            //    MessageBox.Show("Por favor, preencha o telefone.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //if (string.IsNullOrWhiteSpace(txt_preco.Text))
            //{
            //    MessageBox.Show("Por favor, preencha o preço.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //if (string.IsNullOrWhiteSpace(txt_entrega.Text))
            //{
            //    MessageBox.Show("Por favor, informe a data de entrega.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //if (string.IsNullOrWhiteSpace(txt_pagamento.Text))
            //{
            //    MessageBox.Show("Por favor, informe a forma de pagamento.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //if (string.IsNullOrWhiteSpace(txt_status.Text))
            //{
            //    MessageBox.Show("Por favor, informe o status do pedido.", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //// Aqui segue a lógica para cadastrar:
            //Cliente cliente = new Cliente
            //{
            //    Nome = txt_nome.Text,
            //    Telefone = txt_telefone.Text
            //};

            //string resultado = ClienteRepositorio.CadastrarCliente(cliente);

            //if (resultado == "")
            //{
            //    MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    LimparCampos();
            //}
            //else
            //{
            //    MessageBox.Show(resultado, "Erro ao cadastrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void LimparCampos()
        {
            txt_nome.Text = "";
            txt_telefone.Text = "";
            txt_preco.Text = "";
            txt_entrega.Text = "";
            txt_pagamento.Text = "";
            txt_status.Text = "";
        }
    }
}