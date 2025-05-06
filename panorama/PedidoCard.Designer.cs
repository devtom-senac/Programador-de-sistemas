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
            lbl_nome.Location = new Point(130, 25);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(42, 15);
            lbl_nome.TabIndex = 0;
            lbl_nome.Text = "NOME";
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Location = new Point(37, 70);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(61, 15);
            lbl_telefone.TabIndex = 1;
            lbl_telefone.Text = "TELEFONE";
            // 
            // lbl_preco
            // 
            lbl_preco.AutoSize = true;
            lbl_preco.Location = new Point(222, 70);
            lbl_preco.Name = "lbl_preco";
            lbl_preco.Size = new Size(44, 15);
            lbl_preco.TabIndex = 2;
            lbl_preco.Text = "PRECO";
            // 
            // lbl_entrega
            // 
            lbl_entrega.AutoSize = true;
            lbl_entrega.Location = new Point(37, 137);
            lbl_entrega.Name = "lbl_entrega";
            lbl_entrega.Size = new Size(57, 15);
            lbl_entrega.TabIndex = 3;
            lbl_entrega.Text = "ENTREGA";
            // 
            // lbl_pagamento
            // 
            lbl_pagamento.AutoSize = true;
            lbl_pagamento.Location = new Point(204, 137);
            lbl_pagamento.Name = "lbl_pagamento";
            lbl_pagamento.Size = new Size(77, 15);
            lbl_pagamento.TabIndex = 4;
            lbl_pagamento.Text = "PAGAMENTO";
            // 
            // lbl_situacao
            // 
            lbl_situacao.AutoSize = true;
            lbl_situacao.Location = new Point(109, 216);
            lbl_situacao.Name = "lbl_situacao";
            lbl_situacao.Size = new Size(63, 15);
            lbl_situacao.TabIndex = 5;
            lbl_situacao.Text = "SITUAÇÃO";
            // 
            // PedidoCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_situacao);
            Controls.Add(lbl_pagamento);
            Controls.Add(lbl_entrega);
            Controls.Add(lbl_preco);
            Controls.Add(lbl_telefone);
            Controls.Add(lbl_nome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PedidoCard";
            Size = new Size(319, 272);
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
