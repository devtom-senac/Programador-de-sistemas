namespace Treino
{
    partial class Form1
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
            comboBox = new ComboBox();
            textBoxValor1 = new TextBox();
            textBoxValor2 = new TextBox();
            textBoxResultado = new TextBox();
            labelIgual = new Label();
            labelOperacao = new Label();
            buttonCalcular = new Button();
            SuspendLayout();
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(316, 152);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(115, 23);
            comboBox.TabIndex = 0;
            // 
            // textBoxValor1
            // 
            textBoxValor1.Location = new Point(272, 90);
            textBoxValor1.Name = "textBoxValor1";
            textBoxValor1.Size = new Size(51, 23);
            textBoxValor1.TabIndex = 1;
            // 
            // textBoxValor2
            // 
            textBoxValor2.Location = new Point(359, 90);
            textBoxValor2.Name = "textBoxValor2";
            textBoxValor2.Size = new Size(51, 23);
            textBoxValor2.TabIndex = 2;
            // 
            // textBoxResultado
            // 
            textBoxResultado.Enabled = false;
            textBoxResultado.Location = new Point(437, 90);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(243, 23);
            textBoxResultado.TabIndex = 3;
            // 
            // labelIgual
            // 
            labelIgual.AutoSize = true;
            labelIgual.Location = new Point(416, 93);
            labelIgual.Name = "labelIgual";
            labelIgual.Size = new Size(15, 15);
            labelIgual.TabIndex = 4;
            labelIgual.Text = "=";
            // 
            // labelOperacao
            // 
            labelOperacao.AutoSize = true;
            labelOperacao.Font = new Font("Segoe UI", 12F);
            labelOperacao.Location = new Point(341, 93);
            labelOperacao.Name = "labelOperacao";
            labelOperacao.Size = new Size(0, 21);
            labelOperacao.TabIndex = 5;
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(341, 49);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(76, 23);
            buttonCalcular.TabIndex = 6;
            buttonCalcular.Text = "Calcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += buttonCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCalcular);
            Controls.Add(labelOperacao);
            Controls.Add(labelIgual);
            Controls.Add(textBoxResultado);
            Controls.Add(textBoxValor2);
            Controls.Add(textBoxValor1);
            Controls.Add(comboBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBoxValor1;
        private TextBox textBoxValor2;
        private TextBox textBoxResultado;
        private Label labelIgual;
        private Label labelOperacao;
        private Button buttonCalcular;
        private ComboBox comboBox;
    }
}
