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
            this.txbValor1 = new TextBox();
            txbValor2 = new TextBox();
            textBox3 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            SuspendLayout();
            // 
            // txbValor1
            // 
            this.txbValor1.Location = new Point(76, 144);
            this.txbValor1.Name = "txbValor1";
            this.txbValor1.Size = new Size(49, 23);
            this.txbValor1.TabIndex = 1;
            // 
            // txbValor2
            // 
            txbValor2.Location = new Point(146, 144);
            txbValor2.Name = "txbValor2";
            txbValor2.Size = new Size(49, 23);
            txbValor2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.HideSelection = false;
            textBox3.Location = new Point(217, 144);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(49, 23);
            textBox3.TabIndex = 3;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(48, 240);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(49, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Área";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = SystemColors.ButtonHighlight;
            radioButton2.Location = new Point(48, 265);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(77, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Perimetro";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(573, 450);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox3);
            Controls.Add(txbValor2);
            Controls.Add(this.txbValor1);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox txbValor2;
        private TextBox textBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
    }
}