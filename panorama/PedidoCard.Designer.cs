namespace panorama
{
    partial class PedidoCard
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_nome = new Label();
            lbl_telefone = new Label();
            lbl_preco = new Label();
            lbl_entrega = new Label();
            lbl_pagamento = new Label();
            lbl_situacao = new Label();
            SuspendLayout();
            // 
            // lbl_nome
            // 
            lbl_nome.AutoSize = true;
            lbl_nome.Location = new Point(149, 20);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(52, 20);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "NOME";
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Location = new Point(42, 94);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(77, 20);
            lbl_telefone.TabIndex = 1;
            lbl_telefone.Text = "TELEFONE";
            // 
            // lbl_preco
            // 
            lbl_preco.AutoSize = true;
            lbl_preco.Location = new Point(254, 94);
            lbl_preco.Name = "lbl_preco";
            lbl_preco.Size = new Size(54, 20);
            lbl_preco.TabIndex = 2;
            lbl_preco.Text = "PRECO";
            // 
            // lbl_entrega
            // 
            lbl_entrega.AutoSize = true;
            lbl_entrega.Location = new Point(42, 183);
            lbl_entrega.Name = "lbl_entrega";
            lbl_entrega.Size = new Size(73, 20);
            lbl_entrega.TabIndex = 3;
            lbl_entrega.Text = "ENTREGA";
            // 
            // lbl_pagamento
            // 
            lbl_pagamento.AutoSize = true;
            lbl_pagamento.Location = new Point(233, 183);
            lbl_pagamento.Name = "lbl_pagamento";
            lbl_pagamento.Size = new Size(96, 20);
            lbl_pagamento.TabIndex = 4;
            lbl_pagamento.Text = "PAGAMENTO";
            // 
            // lbl_situacao
            // 
            lbl_situacao.AutoSize = true;
            lbl_situacao.Location = new Point(122, 286);
            lbl_situacao.Name = "lbl_situacao";
            lbl_situacao.Size = new Size(79, 20);
            lbl_situacao.TabIndex = 5;
            lbl_situacao.Text = "SITUAÇÃO";
            // 
            // PedidoCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_situacao);
            Controls.Add(lbl_pagamento);
            Controls.Add(lbl_entrega);
            Controls.Add(lbl_preco);
            Controls.Add(lbl_telefone);
            Controls.Add(lbl_nome);
            Name = "PedidoCard";
            Size = new Size(365, 363);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nome;
        private Label lbl_telefone;
        private Label lbl_preco;
        private Label lbl_entrega;
        private Label lbl_pagamento;
        private Label lbl_situacao;
    }
}
