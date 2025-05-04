namespace costura
{
    partial class pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pedido));
            menuStrip2 = new MenuStrip();
            toolStripMenuItem7 = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            historicoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem10 = new ToolStripMenuItem();
            toolStripMenuItem11 = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox2 = new PictureBox();
            btn_cadastrar = new Button();
            lbl_pedido = new Label();
            pictureBox1 = new PictureBox();
            flow_pedidos = new FlowLayoutPanel();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.BackColor = Color.FromArgb(128, 64, 0);
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem7, toolStripMenuItem11 });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(808, 28);
            menuStrip2.TabIndex = 23;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.DropDownItems.AddRange(new ToolStripItem[] { cadastrarToolStripMenuItem, historicoToolStripMenuItem, toolStripMenuItem10 });
            toolStripMenuItem7.Image = (Image)resources.GetObject("toolStripMenuItem7.Image");
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(47, 24);
            toolStripMenuItem7.Text = " ";
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Image = (Image)resources.GetObject("cadastrarToolStripMenuItem.Image");
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(155, 26);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // historicoToolStripMenuItem
            // 
            historicoToolStripMenuItem.Image = (Image)resources.GetObject("historicoToolStripMenuItem.Image");
            historicoToolStripMenuItem.Name = "historicoToolStripMenuItem";
            historicoToolStripMenuItem.Size = new Size(155, 26);
            historicoToolStripMenuItem.Text = "home";
            historicoToolStripMenuItem.Click += historicoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem10
            // 
            toolStripMenuItem10.Image = (Image)resources.GetObject("toolStripMenuItem10.Image");
            toolStripMenuItem10.Name = "toolStripMenuItem10";
            toolStripMenuItem10.Size = new Size(155, 26);
            toolStripMenuItem10.Text = "Pedido";
            toolStripMenuItem10.Click += toolStripMenuItem10_Click;
            // 
            // toolStripMenuItem11
            // 
            toolStripMenuItem11.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, cadastrarToolStripMenuItem1 });
            toolStripMenuItem11.Image = (Image)resources.GetObject("toolStripMenuItem11.Image");
            toolStripMenuItem11.Name = "toolStripMenuItem11";
            toolStripMenuItem11.Size = new Size(47, 24);
            toolStripMenuItem11.Text = " ";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Image = (Image)resources.GetObject("loginToolStripMenuItem.Image");
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(155, 26);
            loginToolStripMenuItem.Text = "Login";
            // 
            // cadastrarToolStripMenuItem1
            // 
            cadastrarToolStripMenuItem1.Image = (Image)resources.GetObject("cadastrarToolStripMenuItem1.Image");
            cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            cadastrarToolStripMenuItem1.Size = new Size(155, 26);
            cadastrarToolStripMenuItem1.Text = "Cadastrar";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(798, 459);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackColor = Color.Transparent;
            btn_cadastrar.BackgroundImage = (Image)resources.GetObject("btn_cadastrar.BackgroundImage");
            btn_cadastrar.FlatStyle = FlatStyle.Flat;
            btn_cadastrar.Location = new Point(345, 405);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(75, 23);
            btn_cadastrar.TabIndex = 25;
            btn_cadastrar.Text = "cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = false;
            // 
            // lbl_pedido
            // 
            lbl_pedido.AccessibleRole = AccessibleRole.None;
            lbl_pedido.AutoSize = true;
            lbl_pedido.BackColor = Color.FromArgb(128, 64, 0);
            lbl_pedido.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_pedido.ForeColor = Color.White;
            lbl_pedido.Location = new Point(329, 12);
            lbl_pedido.Name = "lbl_pedido";
            lbl_pedido.RightToLeft = RightToLeft.No;
            lbl_pedido.Size = new Size(111, 31);
            lbl_pedido.TabIndex = 28;
            lbl_pedido.Text = "PEDIDOS";
            lbl_pedido.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(128, 64, 0);
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(808, 52);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // flow_pedidos
            // 
            flow_pedidos.AutoScroll = true;
            flow_pedidos.BackColor = Color.FromArgb(128, 64, 0);
            flow_pedidos.Location = new Point(89, 79);
            flow_pedidos.Name = "flow_pedidos";
            flow_pedidos.Size = new Size(587, 320);
            flow_pedidos.TabIndex = 29;
            // 
            // pedido
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleMode = AutoScaleMode.None;
            AutoScroll = true;
            CausesValidation = false;
            ClientSize = new Size(800, 450);
            Controls.Add(flow_pedidos);
            Controls.Add(lbl_pedido);
            Controls.Add(menuStrip2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(btn_cadastrar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "pedido";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "pedido";
            Load += pedido_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem historicoToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem10;
        private ToolStripMenuItem toolStripMenuItem11;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem1;
        private PictureBox pictureBox2;
        private Button btn_cadastrar;
        private Label lbl_pedido;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flow_pedidos;
    }
}