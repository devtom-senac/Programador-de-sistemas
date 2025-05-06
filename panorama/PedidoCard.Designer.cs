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
            groupBox2 = new GroupBox();
            lbl_preco = new TextBox();
            lbl_entrega = new TextBox();
            label1 = new Label();
            label15 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_status = new Label();
            label4 = new Label();
            lbl_pagamento = new TextBox();
            lbl_situacao = new TextBox();
            lbl_nome = new TextBox();
            lbl_telefone = new TextBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(64, 64, 64);
            groupBox2.BackgroundImageLayout = ImageLayout.None;
            groupBox2.Controls.Add(lbl_preco);
            groupBox2.Controls.Add(lbl_entrega);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(lbl_status);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lbl_pagamento);
            groupBox2.Controls.Add(lbl_situacao);
            groupBox2.Controls.Add(lbl_nome);
            groupBox2.Controls.Add(lbl_telefone);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(284, 226);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // lbl_preco
            // 
            lbl_preco.Location = new Point(150, 86);
            lbl_preco.Name = "lbl_preco";
            lbl_preco.Size = new Size(112, 23);
            lbl_preco.TabIndex = 3;
            // 
            // lbl_entrega
            // 
            lbl_entrega.Location = new Point(17, 139);
            lbl_entrega.Name = "lbl_entrega";
            lbl_entrega.Size = new Size(112, 23);
            lbl_entrega.TabIndex = 4;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(106, 15);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(68, 20);
            label1.TabIndex = 16;
            label1.Text = "CLIENTE";
            label1.UseMnemonic = false;
            // 
            // label15
            // 
            label15.AccessibleRole = AccessibleRole.None;
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label15.ForeColor = SystemColors.ControlLightLight;
            label15.Location = new Point(175, 64);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.No;
            label15.Size = new Size(58, 20);
            label15.TabIndex = 15;
            label15.Text = "VALOR";
            label15.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(28, 117);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(78, 20);
            label2.TabIndex = 17;
            label2.Text = "ENTREGA";
            label2.UseMnemonic = false;
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(150, 117);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(103, 20);
            label3.TabIndex = 10;
            label3.Text = "PAGAMENTO";
            label3.UseMnemonic = false;
            // 
            // lbl_status
            // 
            lbl_status.AccessibleRole = AccessibleRole.None;
            lbl_status.AutoSize = true;
            lbl_status.BackColor = Color.Transparent;
            lbl_status.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_status.ForeColor = SystemColors.ControlLightLight;
            lbl_status.Location = new Point(99, 173);
            lbl_status.Name = "lbl_status";
            lbl_status.RightToLeft = RightToLeft.No;
            lbl_status.Size = new Size(84, 20);
            lbl_status.TabIndex = 9;
            lbl_status.Text = "SITUAÇÃO";
            lbl_status.UseMnemonic = false;
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.None;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(28, 62);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(85, 20);
            label4.TabIndex = 8;
            label4.Text = "TELEFONE ";
            label4.UseMnemonic = false;
            // 
            // lbl_pagamento
            // 
            lbl_pagamento.BackColor = SystemColors.HighlightText;
            lbl_pagamento.Location = new Point(150, 139);
            lbl_pagamento.Name = "lbl_pagamento";
            lbl_pagamento.Size = new Size(112, 23);
            lbl_pagamento.TabIndex = 5;
            // 
            // lbl_situacao
            // 
            lbl_situacao.BackColor = SystemColors.ButtonHighlight;
            lbl_situacao.Location = new Point(17, 195);
            lbl_situacao.Name = "lbl_situacao";
            lbl_situacao.Size = new Size(246, 23);
            lbl_situacao.TabIndex = 6;
            // 
            // lbl_nome
            // 
            lbl_nome.Location = new Point(18, 38);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(246, 23);
            lbl_nome.TabIndex = 1;
            // 
            // lbl_telefone
            // 
            lbl_telefone.Location = new Point(18, 85);
            lbl_telefone.Margin = new Padding(3, 2, 3, 2);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(110, 23);
            lbl_telefone.TabIndex = 2;
            // 
            // PedidoCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PedidoCard";
            Size = new Size(287, 228);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private TextBox lbl_telefone;
        private TextBox lbl_nome;
        private TextBox lbl_preco;
        private TextBox lbl_entrega;
        private Label label1;
        private Label label15;
        private Label label2;
        private Label label3;
        private Label lbl_status;
        private Label label4;
        private TextBox lbl_pagamento;
        private TextBox lbl_situacao;
    }
}
