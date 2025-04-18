namespace ListaAtividades
{
    partial class CriarAtividade
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
            textBoxTitulo = new TextBox();
            buttonDescartar = new Button();
            buttonCriar = new Button();
            labelTitulo = new Label();
            labelErro = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(222, 172);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(100, 23);
            textBoxTitulo.TabIndex = 0;
            // 
            // buttonDescartar
            // 
            buttonDescartar.Location = new Point(193, 217);
            buttonDescartar.Name = "buttonDescartar";
            buttonDescartar.Size = new Size(75, 23);
            buttonDescartar.TabIndex = 4;
            buttonDescartar.Text = "Descartar";
            buttonDescartar.Click += buttonDescartar_Click;
            // 
            // buttonCriar
            // 
            buttonCriar.Location = new Point(285, 217);
            buttonCriar.Name = "buttonCriar";
            buttonCriar.Size = new Size(75, 23);
            buttonCriar.TabIndex = 2;
            buttonCriar.Text = "Criar";
            buttonCriar.UseVisualStyleBackColor = true;
            buttonCriar.Click += buttonCriar_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(253, 154);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(0, 15);
            labelTitulo.TabIndex = 3;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(6, 391);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(46, 15);
            labelErro.TabIndex = 4;
            labelErro.Text = "retorno";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonCriar);
            groupBox1.Controls.Add(labelTitulo);
            groupBox1.Controls.Add(buttonDescartar);
            groupBox1.Controls.Add(labelErro);
            groupBox1.Controls.Add(textBoxTitulo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(558, 426);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // CriarAtividade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 450);
            Controls.Add(groupBox1);
            Name = "CriarAtividade";
            Text = "CriarAtividade";
            Load += CriarAtividade_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxTitulo;
        private Button buttonDescartar;
        private Button buttonCriar;
        private Label labelTitulo;
        private Label labelErro;
        private GroupBox groupBox1;
    }
}