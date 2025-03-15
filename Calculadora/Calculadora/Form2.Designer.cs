namespace Calculadora
{
    partial class Form2
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
            groupBoxQuadrado = new GroupBox();
            textBoxResultado = new TextBox();
            radioButtonVolume = new RadioButton();
            radioButtonPerimetro = new RadioButton();
            radioButtonArea = new RadioButton();
            labelAltura = new Label();
            labelLargura = new Label();
            labelComprimento = new Label();
            textBoxAltura = new TextBox();
            textBoxComprimento = new TextBox();
            textBoxLargura = new TextBox();
            buttonCalcular = new Button();
            comboBoxForma = new ComboBox();
            groupBoxRetangulo = new GroupBox();
            labelErro = new Label();
            groupBoxQuadrado.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxQuadrado
            // 
            groupBoxQuadrado.Controls.Add(textBoxResultado);
            groupBoxQuadrado.Controls.Add(radioButtonVolume);
            groupBoxQuadrado.Controls.Add(radioButtonPerimetro);
            groupBoxQuadrado.Controls.Add(radioButtonArea);
            groupBoxQuadrado.Controls.Add(labelAltura);
            groupBoxQuadrado.Controls.Add(labelLargura);
            groupBoxQuadrado.Controls.Add(labelComprimento);
            groupBoxQuadrado.Controls.Add(textBoxAltura);
            groupBoxQuadrado.Controls.Add(textBoxComprimento);
            groupBoxQuadrado.Controls.Add(textBoxLargura);
            groupBoxQuadrado.Controls.Add(buttonCalcular);
            groupBoxQuadrado.Location = new Point(20, 32);
            groupBoxQuadrado.Name = "groupBoxQuadrado";
            groupBoxQuadrado.Size = new Size(386, 178);
            groupBoxQuadrado.TabIndex = 6;
            groupBoxQuadrado.TabStop = false;
            groupBoxQuadrado.Text = "groupBoxQuadrado";
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(86, 134);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(74, 23);
            textBoxResultado.TabIndex = 10;
            // 
            // radioButtonVolume
            // 
            radioButtonVolume.AutoSize = true;
            radioButtonVolume.Location = new Point(226, 75);
            radioButtonVolume.Name = "radioButtonVolume";
            radioButtonVolume.Size = new Size(65, 19);
            radioButtonVolume.TabIndex = 9;
            radioButtonVolume.TabStop = true;
            radioButtonVolume.Text = "Volume";
            radioButtonVolume.UseVisualStyleBackColor = true;
            radioButtonVolume.CheckedChanged += radioButtonVolume_CheckedChanged;
            // 
            // radioButtonPerimetro
            // 
            radioButtonPerimetro.AutoSize = true;
            radioButtonPerimetro.Location = new Point(226, 50);
            radioButtonPerimetro.Name = "radioButtonPerimetro";
            radioButtonPerimetro.Size = new Size(77, 19);
            radioButtonPerimetro.TabIndex = 8;
            radioButtonPerimetro.TabStop = true;
            radioButtonPerimetro.Text = "Perimetro";
            radioButtonPerimetro.UseVisualStyleBackColor = true;
            radioButtonPerimetro.CheckedChanged += radioButtonPerimetro_CheckedChanged;
            // 
            // radioButtonArea
            // 
            radioButtonArea.AutoSize = true;
            radioButtonArea.Location = new Point(226, 26);
            radioButtonArea.Name = "radioButtonArea";
            radioButtonArea.Size = new Size(49, 19);
            radioButtonArea.TabIndex = 7;
            radioButtonArea.TabStop = true;
            radioButtonArea.Text = "Area";
            radioButtonArea.UseVisualStyleBackColor = true;
            radioButtonArea.CheckedChanged += radioButtonArea_CheckedChanged;
            // 
            // labelAltura
            // 
            labelAltura.AutoSize = true;
            labelAltura.Location = new Point(13, 79);
            labelAltura.Name = "labelAltura";
            labelAltura.Size = new Size(39, 15);
            labelAltura.TabIndex = 6;
            labelAltura.Text = "Altura";
            // 
            // labelLargura
            // 
            labelLargura.AutoSize = true;
            labelLargura.Location = new Point(13, 50);
            labelLargura.Name = "labelLargura";
            labelLargura.Size = new Size(44, 15);
            labelLargura.TabIndex = 5;
            labelLargura.Text = "largura";
            // 
            // labelComprimento
            // 
            labelComprimento.AutoSize = true;
            labelComprimento.Location = new Point(13, 108);
            labelComprimento.Name = "labelComprimento";
            labelComprimento.Size = new Size(82, 15);
            labelComprimento.TabIndex = 4;
            labelComprimento.Text = "Comprimento";
            // 
            // textBoxAltura
            // 
            textBoxAltura.Location = new Point(101, 76);
            textBoxAltura.Name = "textBoxAltura";
            textBoxAltura.Size = new Size(59, 23);
            textBoxAltura.TabIndex = 3;
            // 
            // textBoxComprimento
            // 
            textBoxComprimento.Location = new Point(101, 105);
            textBoxComprimento.Name = "textBoxComprimento";
            textBoxComprimento.Size = new Size(59, 23);
            textBoxComprimento.TabIndex = 2;
            // 
            // textBoxLargura
            // 
            textBoxLargura.Location = new Point(101, 46);
            textBoxLargura.Name = "textBoxLargura";
            textBoxLargura.Size = new Size(59, 23);
            textBoxLargura.TabIndex = 1;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(226, 124);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(74, 24);
            buttonCalcular.TabIndex = 0;
            buttonCalcular.Text = "calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // comboBoxForma
            // 
            comboBoxForma.FormattingEnabled = true;
            comboBoxForma.Items.AddRange(new object[] { "Quadrado", "Retangulo" });
            comboBoxForma.Location = new Point(20, 216);
            comboBoxForma.Name = "comboBoxForma";
            comboBoxForma.Size = new Size(116, 23);
            comboBoxForma.TabIndex = 7;
            comboBoxForma.SelectedIndexChanged += comboBoxForma_SelectedIndexChanged;
            // 
            // groupBoxRetangulo
            // 
            groupBoxRetangulo.Location = new Point(412, 32);
            groupBoxRetangulo.Name = "groupBoxRetangulo";
            groupBoxRetangulo.Size = new Size(356, 178);
            groupBoxRetangulo.TabIndex = 8;
            groupBoxRetangulo.TabStop = false;
            groupBoxRetangulo.Text = "groupBoxRetangulo";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(20, 260);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(46, 15);
            labelErro.TabIndex = 9;
            labelErro.Text = "retorno";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(998, 450);
            Controls.Add(labelErro);
            Controls.Add(groupBoxRetangulo);
            Controls.Add(comboBoxForma);
            Controls.Add(groupBoxQuadrado);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "Form2";
            Text = "Form2";
            groupBoxQuadrado.ResumeLayout(false);
            groupBoxQuadrado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxForma;
        private TextBox textBoxLargura;
        private GroupBox groupBoxQuadrado;
        private Button buttonCalcular;
        private TextBox textBoxAltura;
        private TextBox textBoxComprimento;
        private GroupBox groupBoxRetangulo;
        private Label labelAltura;
        private Label labelLargura;
        private Label labelComprimento;
        private Label labelErro;
        private RadioButton radioButtonVolume;
        private RadioButton radioButtonPerimetro;
        private RadioButton radioButtonArea;
        private TextBox textBoxResultado;
    }
}