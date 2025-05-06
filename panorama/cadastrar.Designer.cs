﻿namespace costura
{
    partial class cadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrar));
            pictureBox1 = new PictureBox();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            lbl_cadastrar = new Label();
            groupBox2 = new GroupBox();
            txt_telefone = new TextBox();
            txt_nome = new TextBox();
            txt_preco = new TextBox();
            txt_entrega = new TextBox();
            lbl_nome = new Label();
            label15 = new Label();
            lbl_entrega = new Label();
            lbl_pagamento = new Label();
            lbl_status = new Label();
            lbl_telefone = new Label();
            txt_pagamento = new TextBox();
            txt_situacao = new TextBox();
            btn_cadastrar = new Button();
            label_erro = new Label();
            btn_cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(808, 503);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.CadetBlue;
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem11 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 28);
            menuStrip2.TabIndex = 3;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem4 });
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(42, 24);
            toolStripMenuItem1.Text = " ";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Image = (Image)resources.GetObject("toolStripMenuItem3.Image");
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(111, 22);
            toolStripMenuItem3.Text = "home";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Image = (Image)resources.GetObject("toolStripMenuItem4.Image");
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(111, 22);
            toolStripMenuItem4.Text = "Pedido";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, cadastrarToolStripMenuItem1 });
            toolStripMenuItem11.Image = (Image)resources.GetObject("toolStripMenuItem11.Image");
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(42, 24);
            toolStripMenuItem11.Text = " ";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Image = (Image)resources.GetObject("loginToolStripMenuItem.Image");
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(124, 22);
            loginToolStripMenuItem.Text = "Login";
            // 
            // cadastrarToolStripMenuItem1
            // 
            cadastrarToolStripMenuItem1.Image = (Image)resources.GetObject("cadastrarToolStripMenuItem1.Image");
            cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            cadastrarToolStripMenuItem1.Size = new Size(124, 22);
            cadastrarToolStripMenuItem1.Text = "Cadastrar";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.CadetBlue;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(808, 46);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lbl_cadastrar
            // 
            lbl_cadastrar.AccessibleRole = AccessibleRole.None;
            lbl_cadastrar.AutoSize = true;
            lbl_cadastrar.BackColor = Color.CadetBlue;
            lbl_cadastrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_cadastrar.ForeColor = Color.White;
            lbl_cadastrar.Location = new Point(276, 14);
            lbl_cadastrar.Name = "lbl_cadastrar";
            lbl_cadastrar.RightToLeft = RightToLeft.No;
            lbl_cadastrar.Size = new Size(216, 25);
            lbl_cadastrar.TabIndex = 5;
            lbl_cadastrar.Text = "CADASTRO DE PEDIDO";
            lbl_cadastrar.UseMnemonic = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(64, 64, 64);
            groupBox2.BackgroundImageLayout = ImageLayout.None;
            groupBox2.Controls.Add(txt_telefone);
            groupBox2.Controls.Add(txt_nome);
            groupBox2.Controls.Add(txt_preco);
            groupBox2.Controls.Add(txt_entrega);
            groupBox2.Controls.Add(lbl_nome);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(lbl_entrega);
            groupBox2.Controls.Add(lbl_pagamento);
            groupBox2.Controls.Add(lbl_status);
            groupBox2.Controls.Add(lbl_telefone);
            groupBox2.Controls.Add(txt_pagamento);
            groupBox2.Controls.Add(txt_situacao);
            groupBox2.Location = new Point(239, 105);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(279, 226);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(18, 85);
            txt_telefone.Margin = new Padding(3, 2, 3, 2);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(110, 23);
            txt_telefone.TabIndex = 2;
            // 
            // txt_nome
            // 
            txt_nome.Location = new Point(18, 37);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(246, 23);
            txt_nome.TabIndex = 1;
            // 
            // txt_preco
            // 
            txt_preco.Location = new Point(150, 86);
            txt_preco.Name = "txt_preco";
            txt_preco.Size = new Size(112, 23);
            txt_preco.TabIndex = 3;
            // 
            // txt_entrega
            // 
            txt_entrega.Location = new Point(17, 139);
            txt_entrega.Name = "txt_entrega";
            txt_entrega.Size = new Size(112, 23);
            txt_entrega.TabIndex = 4;
            // 
            // lbl_nome
            // 
            lbl_nome.AccessibleRole = AccessibleRole.None;
            lbl_nome.AutoSize = true;
            lbl_nome.BackColor = Color.Transparent;
            lbl_nome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_nome.ForeColor = Color.White;
            lbl_nome.Location = new Point(106, 15);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.RightToLeft = RightToLeft.No;
            lbl_nome.Size = new Size(68, 20);
            lbl_nome.TabIndex = 16;
            lbl_nome.Text = "CLIENTE";
            lbl_nome.UseMnemonic = false;
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
            // lbl_entrega
            // 
            lbl_entrega.AccessibleRole = AccessibleRole.None;
            lbl_entrega.AutoSize = true;
            lbl_entrega.BackColor = Color.Transparent;
            lbl_entrega.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl_entrega.ForeColor = SystemColors.ControlLightLight;
            lbl_entrega.Location = new Point(28, 117);
            lbl_entrega.Name = "lbl_entrega";
            lbl_entrega.RightToLeft = RightToLeft.No;
            lbl_entrega.Size = new Size(78, 20);
            lbl_entrega.TabIndex = 17;
            lbl_entrega.Text = "ENTREGA";
            lbl_entrega.UseMnemonic = false;
            // 
            // lbl_pagamento
            // 
            lbl_pagamento.AccessibleRole = AccessibleRole.None;
            lbl_pagamento.AutoSize = true;
            lbl_pagamento.BackColor = Color.Transparent;
            lbl_pagamento.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl_pagamento.ForeColor = SystemColors.ControlLightLight;
            lbl_pagamento.Location = new Point(150, 117);
            lbl_pagamento.Name = "lbl_pagamento";
            lbl_pagamento.RightToLeft = RightToLeft.No;
            lbl_pagamento.Size = new Size(103, 20);
            lbl_pagamento.TabIndex = 10;
            lbl_pagamento.Text = "PAGAMENTO";
            lbl_pagamento.UseMnemonic = false;
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
            // lbl_telefone
            // 
            lbl_telefone.AccessibleRole = AccessibleRole.None;
            lbl_telefone.AutoSize = true;
            lbl_telefone.BackColor = Color.Transparent;
            lbl_telefone.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lbl_telefone.ForeColor = SystemColors.ControlLightLight;
            lbl_telefone.Location = new Point(28, 62);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.RightToLeft = RightToLeft.No;
            lbl_telefone.Size = new Size(85, 20);
            lbl_telefone.TabIndex = 8;
            lbl_telefone.Text = "TELEFONE ";
            lbl_telefone.UseMnemonic = false;
            // 
            // txt_pagamento
            // 
            txt_pagamento.BackColor = SystemColors.HighlightText;
            txt_pagamento.Location = new Point(150, 139);
            txt_pagamento.Name = "txt_pagamento";
            txt_pagamento.Size = new Size(112, 23);
            txt_pagamento.TabIndex = 5;
            // 
            // txt_situacao
            // 
            txt_situacao.BackColor = SystemColors.ButtonHighlight;
            txt_situacao.Location = new Point(17, 195);
            txt_situacao.Name = "txt_situacao";
            txt_situacao.Size = new Size(246, 23);
            txt_situacao.TabIndex = 6;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.FromArgb(64, 64, 64);
            btn_cadastrar.FlatStyle = FlatStyle.Flat;
            btn_cadastrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cadastrar.ForeColor = SystemColors.ButtonHighlight;
            btn_cadastrar.Location = new Point(239, 356);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(129, 32);
            btn_cadastrar.TabIndex = 8;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // label_erro
            // 
            label_erro.AutoSize = true;
            label_erro.BackColor = Color.FromArgb(64, 64, 64);
            label_erro.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_erro.ForeColor = Color.Red;
            label_erro.Location = new Point(239, 407);
            label_erro.Name = "label_erro";
            label_erro.Size = new Size(0, 17);
            label_erro.TabIndex = 22;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.FromArgb(64, 64, 64);
            btn_cancelar.FlatStyle = FlatStyle.Flat;
            btn_cancelar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cancelar.ForeColor = SystemColors.ButtonHighlight;
            btn_cancelar.Location = new Point(389, 356);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(129, 32);
            btn_cancelar.TabIndex = 7;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += button1_Click;
            // 
            // cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_cancelar);
            Controls.Add(label_erro);
            Controls.Add(btn_cadastrar);
            Controls.Add(groupBox2);
            Controls.Add(lbl_cadastrar);
            Controls.Add(menuStrip2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "cadastrar";
            Text = "cadastrar";
            Load += cadastrar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem1;
        private PictureBox pictureBox2;
        private Label lbl_cadastrar;
        private GroupBox groupBox2;
        private TextBox txt_pagamento;
        private TextBox txt_situacao;
        private Label lbl_pagamento;
        private Label lbl_status;
        private Label lbl_telefone;
        private TextBox txt_nome;
        private TextBox txt_preco;
        private TextBox txt_entrega;
        private Label lbl_entrega;
        private Label lbl_nome;
        private Label label15;
        private Button btn_cadastrar;
        private Label label_erro;
        private TextBox txt_telefone;
        private Button btn_cancelar;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
    }
}