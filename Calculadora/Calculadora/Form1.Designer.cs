namespace Calculadora
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
            buttonSomar = new Button();
            textBoxValor1 = new TextBox();
            textBoxValor2 = new TextBox();
            labelResultado = new Label();
            buttonSubtrair = new Button();
            buttonMultiplicar = new Button();
            buttonDividir = new Button();
            buttonMigrar = new Button();
            SuspendLayout();
            // 
            // buttonSomar
            // 
            buttonSomar.Location = new Point(107, 188);
            buttonSomar.Name = "buttonSomar";
            buttonSomar.Size = new Size(126, 31);
            buttonSomar.TabIndex = 0;
            buttonSomar.Text = "SOMAR ";
            buttonSomar.UseVisualStyleBackColor = true;
            buttonSomar.Click += buttonSomar_Click;
            // 
            // textBoxValor1
            // 
            textBoxValor1.Location = new Point(174, 114);
            textBoxValor1.Name = "textBoxValor1";
            textBoxValor1.Size = new Size(158, 23);
            textBoxValor1.TabIndex = 1;
            // 
            // textBoxValor2
            // 
            textBoxValor2.Location = new Point(174, 143);
            textBoxValor2.Name = "textBoxValor2";
            textBoxValor2.Size = new Size(158, 23);
            textBoxValor2.TabIndex = 2;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(207, 277);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(72, 15);
            labelResultado.TabIndex = 3;
            labelResultado.Text = "RESULTADO:";
            // 
            // buttonSubtrair
            // 
            buttonSubtrair.Location = new Point(256, 188);
            buttonSubtrair.Name = "buttonSubtrair";
            buttonSubtrair.Size = new Size(126, 30);
            buttonSubtrair.TabIndex = 4;
            buttonSubtrair.Text = "SUBTRAIR";
            buttonSubtrair.UseVisualStyleBackColor = true;
            buttonSubtrair.Click += buttonSubtrair_Click;
            // 
            // buttonMultiplicar
            // 
            buttonMultiplicar.Location = new Point(107, 225);
            buttonMultiplicar.Name = "buttonMultiplicar";
            buttonMultiplicar.Size = new Size(126, 30);
            buttonMultiplicar.TabIndex = 5;
            buttonMultiplicar.Text = "MULTIPLICAR";
            buttonMultiplicar.UseVisualStyleBackColor = true;
            buttonMultiplicar.Click += buttonMultiplicar_Click;
            // 
            // buttonDividir
            // 
            buttonDividir.Location = new Point(256, 225);
            buttonDividir.Name = "buttonDividir";
            buttonDividir.Size = new Size(126, 31);
            buttonDividir.TabIndex = 6;
            buttonDividir.Text = "DIVIDIR";
            buttonDividir.UseVisualStyleBackColor = true;
            buttonDividir.Click += buttonDividir_Click;
            // 
            // buttonMigrar
            // 
            buttonMigrar.Location = new Point(459, 294);
            buttonMigrar.Name = "buttonMigrar";
            buttonMigrar.Size = new Size(116, 62);
            buttonMigrar.TabIndex = 7;
            buttonMigrar.Text = "MIGRAR";
            buttonMigrar.UseVisualStyleBackColor = true;
            buttonMigrar.Click += buttonMigrar_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(688, 387);
            Controls.Add(buttonMigrar);
            Controls.Add(buttonDividir);
            Controls.Add(buttonMultiplicar);
            Controls.Add(buttonSubtrair);
            Controls.Add(labelResultado);
            Controls.Add(textBoxValor2);
            Controls.Add(textBoxValor1);
            Controls.Add(buttonSomar);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button buttonSomar;
        private TextBox textBoxValor1;
        private TextBox textBoxValor2;
        private Label labelResultado;
        private Button buttonSubtrair;
        private Button buttonMultiplicar;
        private Button buttonDividir;
        private Button buttonMigrar;
    }
}
