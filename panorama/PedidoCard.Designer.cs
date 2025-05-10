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
            txb_preco = new TextBox();
            txb_entrega = new TextBox();
            label15 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_status = new Label();
            label4 = new Label();
            txb_pagamento = new TextBox();
            txb_situacao = new TextBox();
            txb_nome = new TextBox();
            txb_telefone = new TextBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(64, 64, 64);
            groupBox2.BackgroundImageLayout = ImageLayout.None;
            groupBox2.Controls.Add(txb_preco);
            groupBox2.Controls.Add(txb_entrega);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(lbl_status);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txb_pagamento);
            groupBox2.Controls.Add(txb_situacao);
            groupBox2.Controls.Add(txb_nome);
            groupBox2.Controls.Add(txb_telefone);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(284, 226);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txb_preco
            // 
            txb_preco.Enabled = false;
            txb_preco.Location = new Point(150, 86);
            txb_preco.Name = "txb_preco";
            txb_preco.Size = new Size(112, 23);
            txb_preco.TabIndex = 3;
            // 
            // txb_entrega
            // 
            txb_entrega.Enabled = false;
            txb_entrega.Location = new Point(17, 139);
            txb_entrega.Name = "txb_entrega";
            txb_entrega.Size = new Size(112, 23);
            txb_entrega.TabIndex = 4;
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
            // txb_pagamento
            // 
            txb_pagamento.BackColor = SystemColors.HighlightText;
            txb_pagamento.Enabled = false;
            txb_pagamento.Location = new Point(150, 139);
            txb_pagamento.Name = "txb_pagamento";
            txb_pagamento.Size = new Size(112, 23);
            txb_pagamento.TabIndex = 5;
            // 
            // txb_situacao
            // 
            txb_situacao.BackColor = SystemColors.ButtonHighlight;
            txb_situacao.Enabled = false;
            txb_situacao.Location = new Point(17, 195);
            txb_situacao.Name = "txb_situacao";
            txb_situacao.Size = new Size(246, 23);
            txb_situacao.TabIndex = 6;
            // 
            // txb_nome
            // 
            txb_nome.Enabled = false;
            txb_nome.Location = new Point(18, 38);
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(246, 23);
            txb_nome.TabIndex = 1;
            // 
            // txb_telefone
            // 
            txb_telefone.Enabled = false;
            txb_telefone.Location = new Point(18, 85);
            txb_telefone.Margin = new Padding(3, 2, 3, 2);
            txb_telefone.Name = "txb_telefone";
            txb_telefone.Size = new Size(110, 23);
            txb_telefone.TabIndex = 2;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(99, 15);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(68, 20);
            label1.TabIndex = 16;
            label1.Text = "CLIENTE";
            label1.UseMnemonic = false;
            // 
            // PedidoCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PedidoCard";
            Size = new Size(287, 228);
            Load += PedidoCard_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private TextBox txb_telefone;
        private TextBox txb_nome;
        private TextBox txb_preco;
        private TextBox txb_entrega;
        private Label label15;
        private Label label2;
        private Label label3;
        private Label lbl_status;
        private Label label4;
        private TextBox txb_pagamento;
        private TextBox txb_situacao;
        private Label label1;
    }
}
