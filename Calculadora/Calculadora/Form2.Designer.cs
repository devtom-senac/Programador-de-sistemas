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
            radioButton1 = new RadioButton();
            textBox1 = new TextBox();
            radioButton2 = new RadioButton();
            textBox4 = new TextBox();
            radioButton3 = new RadioButton();
            button1 = new Button();
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            labelErro = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            rdbPerimetro = new RadioButton();
            rdbVolume = new RadioButton();
            rdbDiametro = new RadioButton();
            rdbArea = new RadioButton();
            buttonCalcularCirculo = new Button();
            labelArea = new Label();
            label5 = new Label();
            groupBoxQuadrado.SuspendLayout();
            groupBoxRetangulo.SuspendLayout();
            groupBox1.SuspendLayout();
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
            comboBoxForma.Location = new Point(20, 3);
            comboBoxForma.Name = "comboBoxForma";
            comboBoxForma.Size = new Size(116, 23);
            comboBoxForma.TabIndex = 7;
            comboBoxForma.SelectedIndexChanged += comboBoxForma_SelectedIndexChanged;
            // 
            // groupBoxRetangulo
            // 
            groupBoxRetangulo.Controls.Add(radioButton1);
            groupBoxRetangulo.Controls.Add(textBox1);
            groupBoxRetangulo.Controls.Add(radioButton2);
            groupBoxRetangulo.Controls.Add(textBox4);
            groupBoxRetangulo.Controls.Add(radioButton3);
            groupBoxRetangulo.Controls.Add(button1);
            groupBoxRetangulo.Controls.Add(label1);
            groupBoxRetangulo.Controls.Add(textBox3);
            groupBoxRetangulo.Controls.Add(label2);
            groupBoxRetangulo.Controls.Add(textBox2);
            groupBoxRetangulo.Controls.Add(label3);
            groupBoxRetangulo.Location = new Point(412, 32);
            groupBoxRetangulo.Name = "groupBoxRetangulo";
            groupBoxRetangulo.Size = new Size(356, 178);
            groupBoxRetangulo.TabIndex = 8;
            groupBoxRetangulo.TabStop = false;
            groupBoxRetangulo.Text = "groupBoxRetangulo";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(222, 71);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 19);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Volume";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(74, 23);
            textBox1.TabIndex = 17;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(222, 46);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 19);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Perimetro";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(109, 26);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(59, 23);
            textBox4.TabIndex = 11;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(222, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(49, 19);
            radioButton3.TabIndex = 12;
            radioButton3.TabStop = true;
            radioButton3.Text = "Area";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(222, 120);
            button1.Name = "button1";
            button1.Size = new Size(74, 24);
            button1.TabIndex = 11;
            button1.Text = "calcular";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 59);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 16;
            label1.Text = "Altura";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(109, 85);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(59, 23);
            textBox3.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 30);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 15;
            label2.Text = "largura";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(109, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(59, 23);
            textBox2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 88);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 14;
            label3.Text = "Comprimento";
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(161, 6);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(46, 15);
            labelErro.TabIndex = 9;
            labelErro.Text = "retorno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 315);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 10;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(labelArea);
            groupBox1.Controls.Add(buttonCalcularCirculo);
            groupBox1.Controls.Add(rdbArea);
            groupBox1.Controls.Add(rdbDiametro);
            groupBox1.Controls.Add(rdbVolume);
            groupBox1.Controls.Add(rdbPerimetro);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Location = new Point(20, 236);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 159);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(60, 51);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 0;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(60, 22);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 0;
            // 
            // rdbPerimetro
            // 
            rdbPerimetro.AutoSize = true;
            rdbPerimetro.Location = new Point(181, 52);
            rdbPerimetro.Name = "rdbPerimetro";
            rdbPerimetro.Size = new Size(77, 19);
            rdbPerimetro.TabIndex = 1;
            rdbPerimetro.TabStop = true;
            rdbPerimetro.Text = "perimetro";
            rdbPerimetro.UseVisualStyleBackColor = true;
            // 
            // rdbVolume
            // 
            rdbVolume.AutoSize = true;
            rdbVolume.Location = new Point(181, 100);
            rdbVolume.Name = "rdbVolume";
            rdbVolume.Size = new Size(65, 19);
            rdbVolume.TabIndex = 2;
            rdbVolume.TabStop = true;
            rdbVolume.Text = "volume";
            rdbVolume.UseVisualStyleBackColor = true;
            // 
            // rdbDiametro
            // 
            rdbDiametro.AutoSize = true;
            rdbDiametro.Location = new Point(181, 27);
            rdbDiametro.Name = "rdbDiametro";
            rdbDiametro.Size = new Size(73, 19);
            rdbDiametro.TabIndex = 2;
            rdbDiametro.TabStop = true;
            rdbDiametro.Text = "diametro";
            rdbDiametro.UseVisualStyleBackColor = true;
            // 
            // rdbArea
            // 
            rdbArea.AutoSize = true;
            rdbArea.Location = new Point(181, 75);
            rdbArea.Name = "rdbArea";
            rdbArea.Size = new Size(47, 19);
            rdbArea.TabIndex = 3;
            rdbArea.TabStop = true;
            rdbArea.Text = "area";
            rdbArea.UseVisualStyleBackColor = true;
            // 
            // buttonCalcularCirculo
            // 
            buttonCalcularCirculo.Location = new Point(309, 54);
            buttonCalcularCirculo.Name = "buttonCalcularCirculo";
            buttonCalcularCirculo.Size = new Size(77, 20);
            buttonCalcularCirculo.TabIndex = 4;
            buttonCalcularCirculo.Text = "Calcular";
            buttonCalcularCirculo.UseVisualStyleBackColor = true;
            buttonCalcularCirculo.Click += buttonCalcularCirculo_Click;
            // 
            // labelArea
            // 
            labelArea.AutoSize = true;
            labelArea.Location = new Point(13, 27);
            labelArea.Name = "labelArea";
            labelArea.Size = new Size(29, 15);
            labelArea.TabIndex = 12;
            labelArea.Text = "area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 57);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 13;
            label5.Text = "area";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(998, 450);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(labelErro);
            Controls.Add(groupBoxRetangulo);
            Controls.Add(comboBoxForma);
            Controls.Add(groupBoxQuadrado);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "Form2";
            Text = "Form2";
            groupBoxQuadrado.ResumeLayout(false);
            groupBoxQuadrado.PerformLayout();
            groupBoxRetangulo.ResumeLayout(false);
            groupBoxRetangulo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private TextBox textBox1;
        private TextBox textBox4;
        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button1;
        private Label label4;
        private GroupBox groupBox1;
        private Label label5;
        private Label labelArea;
        private Button buttonCalcularCirculo;
        private RadioButton rdbArea;
        private RadioButton rdbDiametro;
        private RadioButton rdbVolume;
        private RadioButton rdbPerimetro;
        private TextBox textBox6;
        private TextBox textBox5;
    }
}