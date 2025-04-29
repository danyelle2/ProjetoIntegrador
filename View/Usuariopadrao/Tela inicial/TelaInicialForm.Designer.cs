namespace ProjetoIntegrador.View
{
    partial class TelaInicialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicialForm));
            this.MsgExplicacaoGrafico = new System.Windows.Forms.Label();
            this.MsgExplicacaoAlterarDados = new System.Windows.Forms.Label();
            this.MsgExplicacaoCadastro = new System.Windows.Forms.Label();
            this.pictureBoxCadastroAlunos = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlterar = new System.Windows.Forms.PictureBox();
            this.pictureBox2Graficos = new System.Windows.Forms.PictureBox();
            this.dataGridViewListaGeralAlunos = new System.Windows.Forms.DataGridView();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.textBoxPesquisa = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.MsgTemporariaPagamento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxVoltar = new System.Windows.Forms.PictureBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadastroAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Graficos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaGeralAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // MsgExplicacaoGrafico
            // 
            this.MsgExplicacaoGrafico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MsgExplicacaoGrafico.AutoSize = true;
            this.MsgExplicacaoGrafico.Location = new System.Drawing.Point(86, 713);
            this.MsgExplicacaoGrafico.Name = "MsgExplicacaoGrafico";
            this.MsgExplicacaoGrafico.Size = new System.Drawing.Size(16, 13);
            this.MsgExplicacaoGrafico.TabIndex = 14;
            this.MsgExplicacaoGrafico.Text = "...";
            // 
            // MsgExplicacaoAlterarDados
            // 
            this.MsgExplicacaoAlterarDados.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MsgExplicacaoAlterarDados.AutoSize = true;
            this.MsgExplicacaoAlterarDados.Location = new System.Drawing.Point(86, 487);
            this.MsgExplicacaoAlterarDados.Name = "MsgExplicacaoAlterarDados";
            this.MsgExplicacaoAlterarDados.Size = new System.Drawing.Size(16, 13);
            this.MsgExplicacaoAlterarDados.TabIndex = 13;
            this.MsgExplicacaoAlterarDados.Text = "...";
            // 
            // MsgExplicacaoCadastro
            // 
            this.MsgExplicacaoCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MsgExplicacaoCadastro.AutoSize = true;
            this.MsgExplicacaoCadastro.Location = new System.Drawing.Point(86, 245);
            this.MsgExplicacaoCadastro.Name = "MsgExplicacaoCadastro";
            this.MsgExplicacaoCadastro.Size = new System.Drawing.Size(16, 13);
            this.MsgExplicacaoCadastro.TabIndex = 12;
            this.MsgExplicacaoCadastro.Text = "...";
            // 
            // pictureBoxCadastroAlunos
            // 
            this.pictureBoxCadastroAlunos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxCadastroAlunos.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCadastroAlunos.ErrorImage = null;
            this.pictureBoxCadastroAlunos.Location = new System.Drawing.Point(-166, 32);
            this.pictureBoxCadastroAlunos.Name = "pictureBoxCadastroAlunos";
            this.pictureBoxCadastroAlunos.Size = new System.Drawing.Size(246, 226);
            this.pictureBoxCadastroAlunos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCadastroAlunos.TabIndex = 15;
            this.pictureBoxCadastroAlunos.TabStop = false;
            this.pictureBoxCadastroAlunos.Click += new System.EventHandler(this.pictureBoxCadastroAlunos_Click);
            this.pictureBoxCadastroAlunos.MouseLeave += new System.EventHandler(this.pictureBoxCadastroAlunosDesaparece);
            this.pictureBoxCadastroAlunos.MouseHover += new System.EventHandler(this.pictureBoxCadastroAlunosAparecer);
            // 
            // pictureBoxAlterar
            // 
            this.pictureBoxAlterar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxAlterar.BackColor = System.Drawing.Color.Black;
            this.pictureBoxAlterar.ErrorImage = null;
            this.pictureBoxAlterar.Location = new System.Drawing.Point(108, 349);
            this.pictureBoxAlterar.Name = "pictureBoxAlterar";
            this.pictureBoxAlterar.Size = new System.Drawing.Size(222, 163);
            this.pictureBoxAlterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAlterar.TabIndex = 16;
            this.pictureBoxAlterar.TabStop = false;
            this.pictureBoxAlterar.Click += new System.EventHandler(this.pictureBoxAlterar_Click);
            this.pictureBoxAlterar.MouseLeave += new System.EventHandler(this.pictureBoxAlterarDadosDesaparece);
            this.pictureBoxAlterar.MouseHover += new System.EventHandler(this.pictureBoxAlterarDadosAparece);
            // 
            // pictureBox2Graficos
            // 
            this.pictureBox2Graficos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2Graficos.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2Graficos.ErrorImage = null;
            this.pictureBox2Graficos.Location = new System.Drawing.Point(89, 503);
            this.pictureBox2Graficos.Name = "pictureBox2Graficos";
            this.pictureBox2Graficos.Size = new System.Drawing.Size(246, 220);
            this.pictureBox2Graficos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2Graficos.TabIndex = 17;
            this.pictureBox2Graficos.TabStop = false;
            this.pictureBox2Graficos.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2Graficos.MouseLeave += new System.EventHandler(this.pictureBoxGráficoDesaparece);
            this.pictureBox2Graficos.MouseHover += new System.EventHandler(this.pictureBoxGráficoAparece);
            // 
            // dataGridViewListaGeralAlunos
            // 
            this.dataGridViewListaGeralAlunos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewListaGeralAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaGeralAlunos.Location = new System.Drawing.Point(875, 215);
            this.dataGridViewListaGeralAlunos.Name = "dataGridViewListaGeralAlunos";
            this.dataGridViewListaGeralAlunos.Size = new System.Drawing.Size(985, 882);
            this.dataGridViewListaGeralAlunos.TabIndex = 18;
            this.dataGridViewListaGeralAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // textBoxPesquisa
            // 
            this.textBoxPesquisa.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxPesquisa.Location = new System.Drawing.Point(1016, 242);
            this.textBoxPesquisa.Multiline = true;
            this.textBoxPesquisa.Name = "textBoxPesquisa";
            this.textBoxPesquisa.Size = new System.Drawing.Size(699, 53);
            this.textBoxPesquisa.TabIndex = 19;
            this.textBoxPesquisa.TextChanged += new System.EventHandler(this.textBoxPesquisa_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(-166, 732);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(246, 232);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // MsgTemporariaPagamento
            // 
            this.MsgTemporariaPagamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MsgTemporariaPagamento.AutoSize = true;
            this.MsgTemporariaPagamento.Location = new System.Drawing.Point(86, 951);
            this.MsgTemporariaPagamento.Name = "MsgTemporariaPagamento";
            this.MsgTemporariaPagamento.Size = new System.Drawing.Size(16, 13);
            this.MsgTemporariaPagamento.TabIndex = 21;
            this.MsgTemporariaPagamento.Text = "...";
            this.MsgTemporariaPagamento.MouseLeave += new System.EventHandler(this.MsgTemporariaPagamento_Desaparece);
            this.MsgTemporariaPagamento.MouseHover += new System.EventHandler(this.MsgTemporariaPagamento_Aparece);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxVoltar);
            this.panel1.Location = new System.Drawing.Point(551, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 22;
            // 
            // pictureBoxVoltar
            // 
            this.pictureBoxVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVoltar.Image")));
            this.pictureBoxVoltar.Location = new System.Drawing.Point(33, 21);
            this.pictureBoxVoltar.Name = "pictureBoxVoltar";
            this.pictureBoxVoltar.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVoltar.TabIndex = 27;
            this.pictureBoxVoltar.TabStop = false;
            this.pictureBoxVoltar.Click += new System.EventHandler(this.pictureBoxVoltar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(120, 32);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(278, 24);
            this.labelTitulo.TabIndex = 23;
            this.labelTitulo.Text = "TEXTO TITULO DA PAGINA";
            // 
            // TelaInicialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MsgTemporariaPagamento);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBoxPesquisa);
            this.Controls.Add(this.dataGridViewListaGeralAlunos);
            this.Controls.Add(this.pictureBox2Graficos);
            this.Controls.Add(this.pictureBoxAlterar);
            this.Controls.Add(this.pictureBoxCadastroAlunos);
            this.Controls.Add(this.MsgExplicacaoGrafico);
            this.Controls.Add(this.MsgExplicacaoAlterarDados);
            this.Controls.Add(this.MsgExplicacaoCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaInicialForm";
            this.Text = "TelaInicialForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaInicialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadastroAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Graficos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaGeralAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MsgExplicacaoGrafico;
        private System.Windows.Forms.Label MsgExplicacaoAlterarDados;
        private System.Windows.Forms.Label MsgExplicacaoCadastro;
        private System.Windows.Forms.PictureBox pictureBoxCadastroAlunos;
        private System.Windows.Forms.PictureBox pictureBoxAlterar;
        private System.Windows.Forms.PictureBox pictureBox2Graficos;
        private System.Windows.Forms.DataGridView dataGridViewListaGeralAlunos;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox textBoxPesquisa;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label MsgTemporariaPagamento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxVoltar;
        private System.Windows.Forms.Label labelTitulo;
    }
}