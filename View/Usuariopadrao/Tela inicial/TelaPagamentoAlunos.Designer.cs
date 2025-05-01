namespace ProjetoIntegrador.View.Usuariopadrao.Tela_inicial
{
    partial class TelaPagamentoAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPagamentoAlunos));
            this.dataGridViewpagamento = new System.Windows.Forms.DataGridView();
            this.buttonPagamentoRealizado = new System.Windows.Forms.Button();
            this.buttonPendentePagamento = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpagamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewpagamento
            // 
            this.dataGridViewpagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpagamento.Location = new System.Drawing.Point(209, 104);
            this.dataGridViewpagamento.Name = "dataGridViewpagamento";
            this.dataGridViewpagamento.Size = new System.Drawing.Size(448, 413);
            this.dataGridViewpagamento.TabIndex = 22;
            this.dataGridViewpagamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewpagamento_CellContentClick);
            // 
            // buttonPagamentoRealizado
            // 
            this.buttonPagamentoRealizado.BackColor = System.Drawing.Color.Transparent;
            this.buttonPagamentoRealizado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPagamentoRealizado.BackgroundImage")));
            this.buttonPagamentoRealizado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPagamentoRealizado.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonPagamentoRealizado.FlatAppearance.BorderSize = 0;
            this.buttonPagamentoRealizado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPagamentoRealizado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPagamentoRealizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPagamentoRealizado.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPagamentoRealizado.Location = new System.Drawing.Point(677, 161);
            this.buttonPagamentoRealizado.Name = "buttonPagamentoRealizado";
            this.buttonPagamentoRealizado.Size = new System.Drawing.Size(132, 46);
            this.buttonPagamentoRealizado.TabIndex = 24;
            this.buttonPagamentoRealizado.UseVisualStyleBackColor = false;
            this.buttonPagamentoRealizado.Click += new System.EventHandler(this.buttonPagamentoRealizado_Click);
            // 
            // buttonPendentePagamento
            // 
            this.buttonPendentePagamento.BackColor = System.Drawing.Color.Transparent;
            this.buttonPendentePagamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPendentePagamento.BackgroundImage")));
            this.buttonPendentePagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPendentePagamento.FlatAppearance.BorderSize = 0;
            this.buttonPendentePagamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPendentePagamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPendentePagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPendentePagamento.ForeColor = System.Drawing.Color.Transparent;
            this.buttonPendentePagamento.Location = new System.Drawing.Point(677, 314);
            this.buttonPendentePagamento.Name = "buttonPendentePagamento";
            this.buttonPendentePagamento.Size = new System.Drawing.Size(132, 51);
            this.buttonPendentePagamento.TabIndex = 23;
            this.buttonPendentePagamento.UseVisualStyleBackColor = false;
            this.buttonPendentePagamento.Click += new System.EventHandler(this.buttonPendentePagamento_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(194, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 500);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // TelaPagamentoAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 554);
            this.Controls.Add(this.buttonPagamentoRealizado);
            this.Controls.Add(this.buttonPendentePagamento);
            this.Controls.Add(this.dataGridViewpagamento);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(238, 118);
            this.Name = "TelaPagamentoAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.TelaPagamentoAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpagamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewpagamento;
        private System.Windows.Forms.Button buttonPagamentoRealizado;
        private System.Windows.Forms.Button buttonPendentePagamento;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}