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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            buttonEntrar = new Button();
            Usuario = new Label();
            label2 = new Label();
            textBoxUsuario = new TextBox();
            TextBoxSenha = new TextBox();
            LabelResultado = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonEntrar
            // 
            buttonEntrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonEntrar.BackColor = SystemColors.ControlText;
            buttonEntrar.FlatAppearance.BorderSize = 3;
            buttonEntrar.Location = new Point(259, 293);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(151, 35);
            buttonEntrar.TabIndex = 2;
            buttonEntrar.Text = "Enviar";
            buttonEntrar.UseVisualStyleBackColor = false;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Location = new Point(220, 164);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(47, 15);
            Usuario.TabIndex = 3;
            Usuario.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 228);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(288, 164);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(100, 23);
            textBoxUsuario.TabIndex = 5;
            // 
            // TextBoxSenha
            // 
            TextBoxSenha.Location = new Point(288, 228);
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
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(-75, -28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(817, 549);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
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
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.Highlight;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormLogin";
            Text = "Login";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}
