namespace atividade17_04
{
    partial class ListaProdutos
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
            dataGridViewProdutos = new DataGridView();
            textBoxNomeProduto = new TextBox();
            buttonCadastrar = new Button();
            labelErro = new Label();
            buttonRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Location = new Point(36, 188);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.Size = new Size(597, 150);
            dataGridViewProdutos.TabIndex = 0;
            // 
            // textBoxNomeProduto
            // 
            textBoxNomeProduto.Location = new Point(36, 129);
            textBoxNomeProduto.Name = "textBoxNomeProduto";
            textBoxNomeProduto.Size = new Size(597, 23);
            textBoxNomeProduto.TabIndex = 1;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(659, 128);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(75, 23);
            buttonCadastrar.TabIndex = 2;
            buttonCadastrar.Text = "Adicionar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // labelErro
            // 
            labelErro.AutoSize = true;
            labelErro.Location = new Point(39, 367);
            labelErro.Name = "labelErro";
            labelErro.Size = new Size(0, 15);
            labelErro.TabIndex = 3;
            // 
            // buttonRemover
            // 
            buttonRemover.Location = new Point(659, 188);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(75, 23);
            buttonRemover.TabIndex = 4;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // ListaProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRemover);
            Controls.Add(labelErro);
            Controls.Add(buttonCadastrar);
            Controls.Add(textBoxNomeProduto);
            Controls.Add(dataGridViewProdutos);
            Name = "ListaProdutos";
            Text = "ListaProdutos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProdutos;
        private TextBox textBoxNomeProduto;
        private Button buttonCadastrar;
        private Label labelErro;
        private Button buttonRemover;
    }
}