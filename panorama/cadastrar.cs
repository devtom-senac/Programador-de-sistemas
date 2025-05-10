using panorama;
using panorama.dominio;
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

        private void cadastrar_Load(object sender, EventArgs e)
        {
            txt_nome.Focus();

            // Deixa todos os campos em maiúsculo
            txt_nome.CharacterCasing = CharacterCasing.Upper;
            txt_telefone.CharacterCasing = CharacterCasing.Upper;
            txt_pagamento.CharacterCasing = CharacterCasing.Upper;
            txt_situacao.CharacterCasing = CharacterCasing.Upper;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido
            {
                NomeCliente = txt_nome.Text,
                Telefone = txt_telefone.Text,
                Pagamento = txt_pagamento.Text,
                Situacao = txt_situacao.Text
            };

            string erro;

            // Validação Nome
            erro = pedido.ValidarNomeCliente();
            if (!string.IsNullOrWhiteSpace(erro))
            {
                label_erro.Text = erro;
                txt_nome.Focus();
                return;
            }

            // Validação Telefone
            erro = pedido.ValidarTelefone();
            if (!string.IsNullOrEmpty(erro))
            {
                label_erro.Text = erro;
                txt_telefone.Focus();
                return;
            }

            // Preço - só tenta converter aqui
            if (decimal.TryParse(txt_preco.Text, out decimal preco))
            {
                pedido.Preco = preco;
                erro = pedido.ValidarPreco();
                if (!string.IsNullOrEmpty(erro))
                {
                    label_erro.Text = erro;
                    txt_preco.Focus();
                    return;
                }
            }
            else
            {
                label_erro.Text = "Preço inválido.";
                txt_preco.Focus();
                return;
            }

            // DataEntrega - só tenta converter aqui
            if (DateTime.TryParse(txt_entrega.Text, out DateTime data))
            {
                pedido.DataEntrega = data;
                erro = pedido.ValidarDataEntrega();
                if (!string.IsNullOrEmpty(erro))
                {
                    label_erro.Text = erro;
                    txt_entrega.Focus();
                    return;
                }
            }
            else
            {
                label_erro.Text = "Data de entrega inválida.";
                txt_entrega.Focus();
                return;
            }

            // Validação Pagamento
            erro = pedido.ValidarPagamento();
            if (!string.IsNullOrEmpty(erro))
            {
                label_erro.Text = erro;
                txt_pagamento.Focus();
                return;
            }

            // Validação Situação
            erro = pedido.ValidarSituacao();
            if (!string.IsNullOrEmpty(erro))
            {
                label_erro.Text = erro;
                txt_situacao.Focus();
                return;
            }

            // Tudo certo
            label_erro.Text = "";
            pedido.Criar();
            MessageBox.Show("Pedido cadastrado com sucesso!");
            LimparCampos();

            AbrirPedidos();
        }

        private void AbrirPedidos()
        {
            pedido pedido = new pedido();
            pedido.Show();

            this.Hide();
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();

            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            pedido pedido = new pedido();
            pedido.Show();

            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cadastrar_Click(object sender, EventArgs e)
        {

        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historico Historico = new historico();
            Historico.Show();

            this.Hide();
        }
    }
}