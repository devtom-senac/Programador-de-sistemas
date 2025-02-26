namespace login
{
    partial class FormLogin
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
            buttonEntrar = new Button();
            Usuario = new Label();
            label2 = new Label();
            textBoxUsuario = new TextBox();
            TextBoxSenha = new TextBox();
            LabelResultado = new Label();
            SuspendLayout();
            // 
            // buttonEntrar
            // 
            buttonEntrar.BackColor = SystemColors.Menu;
            buttonEntrar.Location = new Point(299, 300);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(111, 31);
            buttonEntrar.TabIndex = 2;
            buttonEntrar.Text = "Enviar";
            buttonEntrar.UseVisualStyleBackColor = false;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Location = new Point(228, 159);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(47, 15);
            Usuario.TabIndex = 3;
            Usuario.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 228);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(299, 156);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(100, 23);
            textBoxUsuario.TabIndex = 5;
            textBoxUsuario.Text = "Tom";
            // 
            // TextBoxSenha
            // 
            TextBoxSenha.Location = new Point(299, 228);
            TextBoxSenha.Name = "TextBoxSenha";
            TextBoxSenha.Size = new Size(100, 23);
            TextBoxSenha.TabIndex = 6;
            // 
            // LabelResultado
            // 
            LabelResultado.AutoSize = true;
            LabelResultado.Location = new Point(457, 156);
            LabelResultado.Name = "LabelResultado";
            LabelResultado.Size = new Size(0, 15);
            LabelResultado.TabIndex = 7;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InfoText;
            ClientSize = new Size(686, 504);
            Controls.Add(LabelResultado);
            Controls.Add(TextBoxSenha);
            Controls.Add(textBoxUsuario);
            Controls.Add(label2);
            Controls.Add(Usuario);
            Controls.Add(buttonEntrar);
            ForeColor = SystemColors.Highlight;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormLogin";
            Text = "Login";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonEntrar;
        private Label Usuario;
        private Label label2;
        private TextBox textBoxUsuario;
        private TextBox TextBoxSenha;
        private Label LabelResultado;
    }
}
