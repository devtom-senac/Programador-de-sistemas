namespace Calculadora
{
    partial class tarefas
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
            labelTempo = new Label();
            labelTerefa = new Label();
            comboBoxNivel = new ComboBox();
            buttonDistribuirTempo = new Button();
            buttonAdicionarTarefa = new Button();
            buttonLimpar = new Button();
            textBoxTempo = new TextBox();
            textBoxTarefa = new TextBox();
            listBoxTarefas = new ListBox();
            labelRetorno = new Label();
            SuspendLayout();
            // 
            // labelTempo
            // 
            labelTempo.AutoSize = true;
            labelTempo.Location = new Point(140, 139);
            labelTempo.Name = "labelTempo";
            labelTempo.Size = new Size(55, 20);
            labelTempo.TabIndex = 0;
            labelTempo.Text = "Tempo";
            // 
            // labelTerefa
            // 
            labelTerefa.AutoSize = true;
            labelTerefa.Location = new Point(140, 173);
            labelTerefa.Name = "labelTerefa";
            labelTerefa.Size = new Size(49, 20);
            labelTerefa.TabIndex = 1;
            labelTerefa.Text = "Tarefa";
            // 
            // comboBoxNivel
            // 
            comboBoxNivel.FormattingEnabled = true;
            comboBoxNivel.Items.AddRange(new object[] { "Facil", "Medio ", "Dificil" });
            comboBoxNivel.Location = new Point(140, 243);
            comboBoxNivel.Name = "comboBoxNivel";
            comboBoxNivel.Size = new Size(127, 28);
            comboBoxNivel.TabIndex = 2;
            // 
            // buttonDistribuirTempo
            // 
            buttonDistribuirTempo.Location = new Point(212, 54);
            buttonDistribuirTempo.Name = "buttonDistribuirTempo";
            buttonDistribuirTempo.Size = new Size(155, 44);
            buttonDistribuirTempo.TabIndex = 3;
            buttonDistribuirTempo.Text = "Distribuir Tempo";
            buttonDistribuirTempo.UseVisualStyleBackColor = true;
            buttonDistribuirTempo.Click += buttonDistribuirTempo_Click;
            // 
            // buttonAdicionarTarefa
            // 
            buttonAdicionarTarefa.Location = new Point(51, 54);
            buttonAdicionarTarefa.Name = "buttonAdicionarTarefa";
            buttonAdicionarTarefa.Size = new Size(155, 44);
            buttonAdicionarTarefa.TabIndex = 4;
            buttonAdicionarTarefa.Text = "Adicionar";
            buttonAdicionarTarefa.UseVisualStyleBackColor = true;
            buttonAdicionarTarefa.Click += buttonAdicionarTarefa_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.Location = new Point(393, 54);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(155, 44);
            buttonLimpar.TabIndex = 5;
            buttonLimpar.Text = "Limpar";
            buttonLimpar.UseVisualStyleBackColor = true;
            // 
            // textBoxTempo
            // 
            textBoxTempo.Location = new Point(198, 140);
            textBoxTempo.Name = "textBoxTempo";
            textBoxTempo.Size = new Size(125, 27);
            textBoxTempo.TabIndex = 6;
            // 
            // textBoxTarefa
            // 
            textBoxTarefa.Location = new Point(198, 173);
            textBoxTarefa.Name = "textBoxTarefa";
            textBoxTarefa.Size = new Size(125, 27);
            textBoxTarefa.TabIndex = 7;
            // 
            // listBoxTarefas
            // 
            listBoxTarefas.FormattingEnabled = true;
            listBoxTarefas.Location = new Point(380, 114);
            listBoxTarefas.Name = "listBoxTarefas";
            listBoxTarefas.Size = new Size(346, 324);
            listBoxTarefas.TabIndex = 8;
            // 
            // labelRetorno
            // 
            labelRetorno.AutoSize = true;
            labelRetorno.Location = new Point(62, 348);
            labelRetorno.Name = "labelRetorno";
            labelRetorno.Size = new Size(58, 20);
            labelRetorno.TabIndex = 9;
            labelRetorno.Text = "retorno";
            // 
            // tarefas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelRetorno);
            Controls.Add(listBoxTarefas);
            Controls.Add(textBoxTarefa);
            Controls.Add(textBoxTempo);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonAdicionarTarefa);
            Controls.Add(buttonDistribuirTempo);
            Controls.Add(comboBoxNivel);
            Controls.Add(labelTerefa);
            Controls.Add(labelTempo);
            Name = "tarefas";
            Text = "tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTempo;
        private Label labelTerefa;
        private ComboBox comboBoxNivel;
        private Button buttonDistribuirTempo;
        private Button buttonAdicionarTarefa;
        private Button buttonLimpar;
        private TextBox textBoxTempo;
        private TextBox textBoxTarefa;
        private ListBox listBoxTarefas;
        private Label labelRetorno;
    }
}