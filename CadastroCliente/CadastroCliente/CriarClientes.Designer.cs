﻿namespace CadastroCliente
{
    partial class CriarClientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCadastrar = new Button();
            textBoxNomeCliente = new TextBox();
            textBoxNomeSocial = new TextBox();
            maskedTextBoxData = new MaskedTextBox();
            maskedTextBoxTelefone = new MaskedTextBox();
            textBoxEmail = new TextBox();
            comboBoxGenero = new ComboBox();
            comboBoxEtnia = new ComboBox();
            checkBoxSim = new CheckBox();
            checkBoxNao = new CheckBox();
            labelNome = new Label();
            labelNomeSocial = new Label();
            labelEmail = new Label();
            labelGenero = new Label();
            labelEtnia = new Label();
            label1 = new Label();
            labelDataNascimento = new Label();
            labelTelefone = new Label();
            textBoxLogradouro = new TextBox();
            textBoxNumero = new TextBox();
            textBoxComplemento = new TextBox();
            textBoxBairro = new TextBox();
            textBoxMunicipio = new TextBox();
            textBoxEstado = new TextBox();
            maskedTextBoxCep = new MaskedTextBox();
            labelLagradouro = new Label();
            labelComplemento = new Label();
            labelNumero = new Label();
            labelEstado = new Label();
            labelMunicipio = new Label();
            labelBairro = new Label();
            labelCep = new Label();
            groupBox1 = new GroupBox();
            labelTipo = new Label();
            comboBoxTipo = new ComboBox();
            labelRetorno = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.BackColor = Color.MidnightBlue;
            buttonCadastrar.ForeColor = SystemColors.ControlLight;
            buttonCadastrar.Location = new Point(464, 263);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(159, 43);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "CADASTRAR";
            buttonCadastrar.UseVisualStyleBackColor = false;
            buttonCadastrar.Click += buttonCadastrar_Click_1;
            // 
            // textBoxNomeCliente
            // 
            textBoxNomeCliente.Location = new Point(12, 29);
            textBoxNomeCliente.Name = "textBoxNomeCliente";
            textBoxNomeCliente.Size = new Size(248, 23);
            textBoxNomeCliente.TabIndex = 1;
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Location = new Point(12, 117);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(248, 23);
            textBoxNomeSocial.TabIndex = 2;
            // 
            // maskedTextBoxData
            // 
            maskedTextBoxData.Location = new Point(337, 209);
            maskedTextBoxData.Mask = "00/00/0000";
            maskedTextBoxData.Name = "maskedTextBoxData";
            maskedTextBoxData.Size = new Size(114, 23);
            maskedTextBoxData.TabIndex = 3;
            maskedTextBoxData.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(464, 209);
            maskedTextBoxTelefone.Mask = "00000000000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(100, 23);
            maskedTextBoxTelefone.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 73);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(248, 23);
            textBoxEmail.TabIndex = 5;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Cisgenero", "Transgenero", "Nao Binario", "Agenero" });
            comboBoxGenero.Location = new Point(12, 165);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(248, 23);
            comboBoxGenero.TabIndex = 6;
            // 
            // comboBoxEtnia
            // 
            comboBoxEtnia.FormattingEnabled = true;
            comboBoxEtnia.Items.AddRange(new object[] { "Branco", "Preto", "Pardo", "Indigena", "Amarelo", "        " });
            comboBoxEtnia.Location = new Point(12, 209);
            comboBoxEtnia.Name = "comboBoxEtnia";
            comboBoxEtnia.Size = new Size(248, 23);
            comboBoxEtnia.TabIndex = 7;
            // 
            // checkBoxSim
            // 
            checkBoxSim.AutoSize = true;
            checkBoxSim.Location = new Point(624, 209);
            checkBoxSim.Name = "checkBoxSim";
            checkBoxSim.Size = new Size(46, 19);
            checkBoxSim.TabIndex = 8;
            checkBoxSim.Text = "Sim";
            checkBoxSim.UseVisualStyleBackColor = true;
            // 
            // checkBoxNao
            // 
            checkBoxNao.AutoSize = true;
            checkBoxNao.Location = new Point(671, 209);
            checkBoxNao.Name = "checkBoxNao";
            checkBoxNao.Size = new Size(48, 19);
            checkBoxNao.TabIndex = 9;
            checkBoxNao.Text = "Não";
            checkBoxNao.UseVisualStyleBackColor = true;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = Color.DarkGray;
            labelNome.Location = new Point(12, 11);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 10;
            labelNome.Text = "Nome";
            // 
            // labelNomeSocial
            // 
            labelNomeSocial.AutoSize = true;
            labelNomeSocial.BackColor = SystemColors.AppWorkspace;
            labelNomeSocial.Location = new Point(12, 99);
            labelNomeSocial.Name = "labelNomeSocial";
            labelNomeSocial.Size = new Size(73, 15);
            labelNomeSocial.TabIndex = 11;
            labelNomeSocial.Text = "Nome social";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = SystemColors.AppWorkspace;
            labelEmail.Location = new Point(12, 55);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 12;
            labelEmail.Text = "Email";
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.BackColor = SystemColors.AppWorkspace;
            labelGenero.Location = new Point(12, 147);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(45, 15);
            labelGenero.TabIndex = 13;
            labelGenero.Text = "Genero";
            // 
            // labelEtnia
            // 
            labelEtnia.AutoSize = true;
            labelEtnia.BackColor = SystemColors.AppWorkspace;
            labelEtnia.Location = new Point(12, 191);
            labelEtnia.Name = "labelEtnia";
            labelEtnia.Size = new Size(33, 15);
            labelEtnia.TabIndex = 14;
            labelEtnia.Text = "Etnia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(618, 194);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 15;
            label1.Text = "É estrangeiro";
            // 
            // labelDataNascimento
            // 
            labelDataNascimento.AutoSize = true;
            labelDataNascimento.Location = new Point(337, 191);
            labelDataNascimento.Name = "labelDataNascimento";
            labelDataNascimento.Size = new Size(114, 15);
            labelDataNascimento.TabIndex = 16;
            labelDataNascimento.Text = "Data de Nascimento";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(463, 191);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(51, 15);
            labelTelefone.TabIndex = 17;
            labelTelefone.Text = "Telefone";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(337, 29);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(270, 23);
            textBoxLogradouro.TabIndex = 18;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(619, 29);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(100, 23);
            textBoxNumero.TabIndex = 19;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(619, 73);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(100, 23);
            textBoxComplemento.TabIndex = 20;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(337, 73);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(270, 23);
            textBoxBairro.TabIndex = 21;
            // 
            // textBoxMunicipio
            // 
            textBoxMunicipio.Location = new Point(337, 114);
            textBoxMunicipio.Name = "textBoxMunicipio";
            textBoxMunicipio.Size = new Size(270, 23);
            textBoxMunicipio.TabIndex = 22;
            // 
            // textBoxEstado
            // 
            textBoxEstado.Location = new Point(619, 114);
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.Size = new Size(100, 23);
            textBoxEstado.TabIndex = 23;
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(337, 163);
            maskedTextBoxCep.Mask = "00000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(61, 23);
            maskedTextBoxCep.TabIndex = 24;
            // 
            // labelLagradouro
            // 
            labelLagradouro.AutoSize = true;
            labelLagradouro.Location = new Point(337, 11);
            labelLagradouro.Name = "labelLagradouro";
            labelLagradouro.Size = new Size(68, 15);
            labelLagradouro.TabIndex = 25;
            labelLagradouro.Text = "Lagradouro";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(619, 55);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(84, 15);
            labelComplemento.TabIndex = 26;
            labelComplemento.Text = "Complemento";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(619, 11);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(51, 15);
            labelNumero.TabIndex = 27;
            labelNumero.Text = "Número";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(619, 99);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(42, 15);
            labelEstado.TabIndex = 28;
            labelEstado.Text = "Estado";
            // 
            // labelMunicipio
            // 
            labelMunicipio.AutoSize = true;
            labelMunicipio.Location = new Point(337, 99);
            labelMunicipio.Name = "labelMunicipio";
            labelMunicipio.Size = new Size(61, 15);
            labelMunicipio.TabIndex = 29;
            labelMunicipio.Text = "Municipio";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(337, 55);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(38, 15);
            labelBairro.TabIndex = 30;
            labelBairro.Text = "Bairro";
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Location = new Point(337, 147);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(28, 15);
            labelCep.TabIndex = 31;
            labelCep.Text = "CEP";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(labelTipo);
            groupBox1.Controls.Add(labelEtnia);
            groupBox1.Controls.Add(comboBoxTipo);
            groupBox1.Controls.Add(labelRetorno);
            groupBox1.Controls.Add(labelGenero);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(labelTelefone);
            groupBox1.Controls.Add(labelNomeSocial);
            groupBox1.Controls.Add(labelCep);
            groupBox1.Controls.Add(labelNome);
            groupBox1.Controls.Add(comboBoxEtnia);
            groupBox1.Controls.Add(labelDataNascimento);
            groupBox1.Controls.Add(comboBoxGenero);
            groupBox1.Controls.Add(labelLagradouro);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(checkBoxNao);
            groupBox1.Controls.Add(textBoxNomeSocial);
            groupBox1.Controls.Add(labelBairro);
            groupBox1.Controls.Add(textBoxNomeCliente);
            groupBox1.Controls.Add(buttonCadastrar);
            groupBox1.Controls.Add(checkBoxSim);
            groupBox1.Controls.Add(textBoxLogradouro);
            groupBox1.Controls.Add(textBoxNumero);
            groupBox1.Controls.Add(labelMunicipio);
            groupBox1.Controls.Add(textBoxComplemento);
            groupBox1.Controls.Add(textBoxBairro);
            groupBox1.Controls.Add(labelEstado);
            groupBox1.Controls.Add(maskedTextBoxTelefone);
            groupBox1.Controls.Add(textBoxMunicipio);
            groupBox1.Controls.Add(textBoxEstado);
            groupBox1.Controls.Add(labelNumero);
            groupBox1.Controls.Add(maskedTextBoxCep);
            groupBox1.Controls.Add(labelComplemento);
            groupBox1.Controls.Add(maskedTextBoxData);
            groupBox1.Location = new Point(250, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(747, 312);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(12, 232);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(30, 15);
            labelTipo.TabIndex = 37;
            labelTipo.Text = "Tipo";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Branco", "Preto", "Pardo", "Indigena", "Amarelo", "        " });
            comboBoxTipo.Location = new Point(12, 250);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(248, 23);
            comboBoxTipo.TabIndex = 36;
            // 
            // labelRetorno
            // 
            labelRetorno.AutoSize = true;
            labelRetorno.BackColor = SystemColors.ButtonHighlight;
            labelRetorno.Location = new Point(347, 263);
            labelRetorno.Name = "labelRetorno";
            labelRetorno.Size = new Size(0, 15);
            labelRetorno.TabIndex = 33;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 368);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1183, 267);
            dataGridView1.TabIndex = 34;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.ForeColor = Color.Cornsilk;
            button2.Location = new Point(510, 654);
            button2.Name = "button2";
            button2.Size = new Size(159, 44);
            button2.TabIndex = 35;
            button2.Text = "EXIBIR CLIENTES";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // CriarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 773);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "CriarClientes";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCadastrar;
        private TextBox textBoxNomeCliente;
        private TextBox textBoxNomeSocial;
        private MaskedTextBox maskedTextBoxData;
        private MaskedTextBox maskedTextBoxTelefone;
        private TextBox textBoxEmail;
        private ComboBox comboBoxGenero;
        private ComboBox comboBoxEtnia;
        private CheckBox checkBoxSim;
        private CheckBox checkBoxNao;
        private Label labelNome;
        private Label labelNomeSocial;
        private Label labelEmail;
        private Label labelGenero;
        private Label labelEtnia;
        private Label label1;
        private Label labelDataNascimento;
        private Label labelTelefone;
        private TextBox textBoxLogradouro;
        private TextBox textBoxNumero;
        private TextBox textBoxComplemento;
        private TextBox textBoxBairro;
        private TextBox textBoxMunicipio;
        private TextBox textBoxEstado;
        private MaskedTextBox maskedTextBoxCep;
        private Label labelLagradouro;
        private Label labelComplemento;
        private Label labelNumero;
        private Label labelEstado;
        private Label labelMunicipio;
        private Label labelBairro;
        private Label labelCep;
        private GroupBox groupBox1;
        private Label labelRetorno;
        private DataGridView dataGridView1;
        private Button button2;
        private Label labelTipo;
        private ComboBox comboBoxTipo;
    }
}
