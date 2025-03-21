namespace CadastroCliente
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
            dataGridView1 = new DataGridView();
            labelRetorno = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(649, 491);
            buttonCadastrar.Margin = new Padding(3, 4, 3, 4);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(242, 67);
            buttonCadastrar.TabIndex = 0;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click_1;
            // 
            // textBoxNomeCliente
            // 
            textBoxNomeCliente.Location = new Point(67, 81);
            textBoxNomeCliente.Margin = new Padding(3, 4, 3, 4);
            textBoxNomeCliente.Name = "textBoxNomeCliente";
            textBoxNomeCliente.Size = new Size(283, 27);
            textBoxNomeCliente.TabIndex = 1;
            // 
            // textBoxNomeSocial
            // 
            textBoxNomeSocial.Location = new Point(67, 199);
            textBoxNomeSocial.Margin = new Padding(3, 4, 3, 4);
            textBoxNomeSocial.Name = "textBoxNomeSocial";
            textBoxNomeSocial.Size = new Size(283, 27);
            textBoxNomeSocial.TabIndex = 2;
            // 
            // maskedTextBoxData
            // 
            maskedTextBoxData.Location = new Point(385, 279);
            maskedTextBoxData.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxData.Mask = "00/00/0000";
            maskedTextBoxData.Name = "maskedTextBoxData";
            maskedTextBoxData.Size = new Size(130, 27);
            maskedTextBoxData.TabIndex = 3;
            maskedTextBoxData.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBoxTelefone
            // 
            maskedTextBoxTelefone.Location = new Point(530, 279);
            maskedTextBoxTelefone.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxTelefone.Mask = "(00) 00000-0000";
            maskedTextBoxTelefone.Name = "maskedTextBoxTelefone";
            maskedTextBoxTelefone.Size = new Size(114, 27);
            maskedTextBoxTelefone.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(67, 140);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(283, 27);
            textBoxEmail.TabIndex = 5;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Cisgenero", "Transgenero", "Nao Binario", "Agenero" });
            comboBoxGenero.Location = new Point(67, 263);
            comboBoxGenero.Margin = new Padding(3, 4, 3, 4);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(283, 28);
            comboBoxGenero.TabIndex = 6;
            // 
            // comboBoxEtnia
            // 
            comboBoxEtnia.FormattingEnabled = true;
            comboBoxEtnia.Items.AddRange(new object[] { "Branco", "Preto", "Pardo", "Indigena", "Amarelo", "        " });
            comboBoxEtnia.Location = new Point(67, 321);
            comboBoxEtnia.Margin = new Padding(3, 4, 3, 4);
            comboBoxEtnia.Name = "comboBoxEtnia";
            comboBoxEtnia.Size = new Size(283, 28);
            comboBoxEtnia.TabIndex = 7;
            // 
            // checkBoxSim
            // 
            checkBoxSim.AutoSize = true;
            checkBoxSim.Location = new Point(713, 279);
            checkBoxSim.Margin = new Padding(3, 4, 3, 4);
            checkBoxSim.Name = "checkBoxSim";
            checkBoxSim.Size = new Size(56, 24);
            checkBoxSim.TabIndex = 8;
            checkBoxSim.Text = "Sim";
            checkBoxSim.UseVisualStyleBackColor = true;
            // 
            // checkBoxNao
            // 
            checkBoxNao.AutoSize = true;
            checkBoxNao.Location = new Point(767, 279);
            checkBoxNao.Margin = new Padding(3, 4, 3, 4);
            checkBoxNao.Name = "checkBoxNao";
            checkBoxNao.Size = new Size(59, 24);
            checkBoxNao.TabIndex = 9;
            checkBoxNao.Text = "Não";
            checkBoxNao.UseVisualStyleBackColor = true;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.BackColor = SystemColors.AppWorkspace;
            labelNome.Location = new Point(67, 57);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(50, 20);
            labelNome.TabIndex = 10;
            labelNome.Text = "Nome";
            // 
            // labelNomeSocial
            // 
            labelNomeSocial.AutoSize = true;
            labelNomeSocial.Location = new Point(67, 175);
            labelNomeSocial.Name = "labelNomeSocial";
            labelNomeSocial.Size = new Size(92, 20);
            labelNomeSocial.TabIndex = 11;
            labelNomeSocial.Text = "Nome social";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = SystemColors.ActiveBorder;
            labelEmail.Location = new Point(67, 116);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 12;
            labelEmail.Text = "Email";
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(67, 239);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(57, 20);
            labelGenero.TabIndex = 13;
            labelGenero.Text = "Genero";
            // 
            // labelEtnia
            // 
            labelEtnia.AutoSize = true;
            labelEtnia.Location = new Point(67, 297);
            labelEtnia.Name = "labelEtnia";
            labelEtnia.Size = new Size(42, 20);
            labelEtnia.TabIndex = 14;
            labelEtnia.Text = "Etnia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(706, 259);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 15;
            label1.Text = "É estrangeiro";
            // 
            // labelDataNascimento
            // 
            labelDataNascimento.AutoSize = true;
            labelDataNascimento.Location = new Point(385, 255);
            labelDataNascimento.Name = "labelDataNascimento";
            labelDataNascimento.Size = new Size(145, 20);
            labelDataNascimento.TabIndex = 16;
            labelDataNascimento.Text = "Data de Nascimento";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(529, 255);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(66, 20);
            labelTelefone.TabIndex = 17;
            labelTelefone.Text = "Telefone";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(385, 39);
            textBoxLogradouro.Margin = new Padding(3, 4, 3, 4);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(308, 27);
            textBoxLogradouro.TabIndex = 18;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(707, 39);
            textBoxNumero.Margin = new Padding(3, 4, 3, 4);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(114, 27);
            textBoxNumero.TabIndex = 19;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(707, 97);
            textBoxComplemento.Margin = new Padding(3, 4, 3, 4);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(114, 27);
            textBoxComplemento.TabIndex = 20;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(385, 97);
            textBoxBairro.Margin = new Padding(3, 4, 3, 4);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(308, 27);
            textBoxBairro.TabIndex = 21;
            // 
            // textBoxMunicipio
            // 
            textBoxMunicipio.Location = new Point(385, 152);
            textBoxMunicipio.Margin = new Padding(3, 4, 3, 4);
            textBoxMunicipio.Name = "textBoxMunicipio";
            textBoxMunicipio.Size = new Size(308, 27);
            textBoxMunicipio.TabIndex = 22;
            // 
            // textBoxEstado
            // 
            textBoxEstado.Location = new Point(707, 152);
            textBoxEstado.Margin = new Padding(3, 4, 3, 4);
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.Size = new Size(114, 27);
            textBoxEstado.TabIndex = 23;
            // 
            // maskedTextBoxCep
            // 
            maskedTextBoxCep.Location = new Point(385, 217);
            maskedTextBoxCep.Margin = new Padding(3, 4, 3, 4);
            maskedTextBoxCep.Mask = "00000-000";
            maskedTextBoxCep.Name = "maskedTextBoxCep";
            maskedTextBoxCep.Size = new Size(69, 27);
            maskedTextBoxCep.TabIndex = 24;
            // 
            // labelLagradouro
            // 
            labelLagradouro.AutoSize = true;
            labelLagradouro.Location = new Point(385, 15);
            labelLagradouro.Name = "labelLagradouro";
            labelLagradouro.Size = new Size(86, 20);
            labelLagradouro.TabIndex = 25;
            labelLagradouro.Text = "Lagradouro";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(707, 73);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(104, 20);
            labelComplemento.TabIndex = 26;
            labelComplemento.Text = "Complemento";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(707, 15);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(63, 20);
            labelNumero.TabIndex = 27;
            labelNumero.Text = "Número";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(707, 132);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(54, 20);
            labelEstado.TabIndex = 28;
            labelEstado.Text = "Estado";
            // 
            // labelMunicipio
            // 
            labelMunicipio.AutoSize = true;
            labelMunicipio.Location = new Point(385, 132);
            labelMunicipio.Name = "labelMunicipio";
            labelMunicipio.Size = new Size(75, 20);
            labelMunicipio.TabIndex = 29;
            labelMunicipio.Text = "Municipio";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Location = new Point(385, 73);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(49, 20);
            labelBairro.TabIndex = 30;
            labelBairro.Text = "Bairro";
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Location = new Point(385, 196);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(34, 20);
            labelCep.TabIndex = 31;
            labelCep.Text = "CEP";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(labelTipo);
            groupBox1.Controls.Add(comboBoxTipo);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(labelRetorno);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(labelTelefone);
            groupBox1.Controls.Add(labelCep);
            groupBox1.Controls.Add(labelDataNascimento);
            groupBox1.Controls.Add(labelLagradouro);
            groupBox1.Controls.Add(checkBoxNao);
            groupBox1.Controls.Add(labelBairro);
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
            groupBox1.Location = new Point(53, 43);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1352, 416);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            // 
            // labelTipo
            // 
            labelTipo.AutoSize = true;
            labelTipo.Location = new Point(14, 310);
            labelTipo.Name = "labelTipo";
            labelTipo.Size = new Size(39, 20);
            labelTipo.TabIndex = 37;
            labelTipo.Text = "Tipo";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Branco", "Preto", "Pardo", "Indigena", "Amarelo", "        " });
            comboBoxTipo.Location = new Point(14, 334);
            comboBoxTipo.Margin = new Padding(3, 4, 3, 4);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(283, 28);
            comboBoxTipo.TabIndex = 36;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(882, 15);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(421, 356);
            dataGridView1.TabIndex = 34;
            // 
            // labelRetorno
            // 
            labelRetorno.AutoSize = true;
            labelRetorno.BackColor = SystemColors.ButtonHighlight;
            labelRetorno.Location = new Point(397, 351);
            labelRetorno.Name = "labelRetorno";
            labelRetorno.Size = new Size(0, 20);
            labelRetorno.TabIndex = 33;
            // 
            // button2
            // 
            button2.Location = new Point(1091, 491);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(154, 45);
            button2.TabIndex = 35;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // CriarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1519, 600);
            Controls.Add(button2);
            Controls.Add(labelEtnia);
            Controls.Add(labelGenero);
            Controls.Add(labelEmail);
            Controls.Add(labelNomeSocial);
            Controls.Add(labelNome);
            Controls.Add(comboBoxEtnia);
            Controls.Add(comboBoxGenero);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNomeSocial);
            Controls.Add(textBoxNomeCliente);
            Controls.Add(buttonCadastrar);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CriarClientes";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
