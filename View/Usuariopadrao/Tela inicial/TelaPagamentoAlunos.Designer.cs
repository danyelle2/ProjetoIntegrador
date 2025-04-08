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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridViewpagamento = new System.Windows.Forms.DataGridView();
            this.buttonPagamentoRealizado = new System.Windows.Forms.Button();
            this.buttonPendentePagamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpagamento)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(40, 52);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(119, 107);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridViewpagamento
            // 
            this.dataGridViewpagamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpagamento.Location = new System.Drawing.Point(210, 33);
            this.dataGridViewpagamento.Name = "dataGridViewpagamento";
            this.dataGridViewpagamento.Size = new System.Drawing.Size(428, 327);
            this.dataGridViewpagamento.TabIndex = 22;
            this.dataGridViewpagamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewpagamento_CellContentClick);
            // 
            // buttonPagamentoRealizado
            // 
            this.buttonPagamentoRealizado.Location = new System.Drawing.Point(678, 202);
            this.buttonPagamentoRealizado.Name = "buttonPagamentoRealizado";
            this.buttonPagamentoRealizado.Size = new System.Drawing.Size(75, 23);
            this.buttonPagamentoRealizado.TabIndex = 24;
            this.buttonPagamentoRealizado.Text = "Realizado";
            this.buttonPagamentoRealizado.UseVisualStyleBackColor = true;
            this.buttonPagamentoRealizado.Click += new System.EventHandler(this.buttonPagamentoRealizado_Click);
            // 
            // buttonPendentePagamento
            // 
            this.buttonPendentePagamento.Location = new System.Drawing.Point(678, 152);
            this.buttonPendentePagamento.Name = "buttonPendentePagamento";
            this.buttonPendentePagamento.Size = new System.Drawing.Size(75, 23);
            this.buttonPendentePagamento.TabIndex = 23;
            this.buttonPendentePagamento.Text = "Pendente";
            this.buttonPendentePagamento.UseVisualStyleBackColor = true;
            this.buttonPendentePagamento.Click += new System.EventHandler(this.buttonPendentePagamento_Click);
            // 
            // TelaPagamentoAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPagamentoRealizado);
            this.Controls.Add(this.buttonPendentePagamento);
            this.Controls.Add(this.dataGridViewpagamento);
            this.Controls.Add(this.pictureBox3);
            this.Name = "TelaPagamentoAlunos";
            this.Text = "TelaPagamentoAlunos";
            this.Load += new System.EventHandler(this.TelaPagamentoAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpagamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridViewpagamento;
        private System.Windows.Forms.Button buttonPagamentoRealizado;
        private System.Windows.Forms.Button buttonPendentePagamento;
    }
}