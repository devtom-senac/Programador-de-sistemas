namespace panorama
{
    partial class historico
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
            dataGridHistorico = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridHistorico).BeginInit();
            SuspendLayout();
            // 
            // dataGridHistorico
            // 
            dataGridHistorico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHistorico.Location = new Point(243, 105);
            dataGridHistorico.Name = "dataGridHistorico";
            dataGridHistorico.Size = new Size(348, 224);
            dataGridHistorico.TabIndex = 0;
            // 
            // historico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridHistorico);
            Name = "historico";
            Text = "historico";
            Load += historico_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridHistorico).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridHistorico;
    }
}