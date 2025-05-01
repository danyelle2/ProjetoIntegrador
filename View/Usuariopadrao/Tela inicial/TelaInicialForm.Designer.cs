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
            this.msgpagamentos = new System.Windows.Forms.Label();
            this.MsgExplicacaoCadastro = new System.Windows.Forms.Label();
            this.pictureBoxCadastroAlunos = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlterar = new System.Windows.Forms.PictureBox();
            this.pictureBox2Graficos = new System.Windows.Forms.PictureBox();
            this.dataGridViewListaGeralAlunos = new System.Windows.Forms.DataGridView();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.MsgTemporariaPagamento = new System.Windows.Forms.Label();
            this.pictureBoxVoltar = new System.Windows.Forms.PictureBox();
            this.labelTituloModalidade = new System.Windows.Forms.Label();
            this.MsgExplicacaoAlterarDados1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1UsuarioNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadastroAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Graficos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaGeralAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // MsgExplicacaoGrafico
            // 
            this.MsgExplicacaoGrafico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MsgExplicacaoGrafico.AutoSize = true;
            this.MsgExplicacaoGrafico.BackColor = System.Drawing.Color.Transparent;
            this.MsgExplicacaoGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.MsgExplicacaoGrafico.Location = new System.Drawing.Point(188, 554);
            this.MsgExplicacaoGrafico.Name = "MsgExplicacaoGrafico";
            this.MsgExplicacaoGrafico.Size = new System.Drawing.Size(0, 18);
            this.MsgExplicacaoGrafico.TabIndex = 14;
            this.MsgExplicacaoGrafico.Click += new System.EventHandler(this.MsgExplicacaoGrafico_Click);
            // 
            // msgpagamentos
            // 
            this.msgpagamentos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.msgpagamentos.AutoSize = true;
            this.msgpagamentos.BackColor = System.Drawing.Color.Transparent;
            this.msgpagamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.msgpagamentos.Location = new System.Drawing.Point(188, 710);
            this.msgpagamentos.Name = "msgpagamentos";
            this.msgpagamentos.Size = new System.Drawing.Size(0, 18);
            this.msgpagamentos.TabIndex = 13;
            this.msgpagamentos.Click += new System.EventHandler(this.MsgExplicacaoAlterarDados_Click);
            this.msgpagamentos.MouseLeave += new System.EventHandler(this.MsgTemporariaPagamento_Desaparece);
            this.msgpagamentos.MouseHover += new System.EventHandler(this.MsgTemporariaPagamento_Aparece);
            // 
            // MsgExplicacaoCadastro
            // 
            this.MsgExplicacaoCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MsgExplicacaoCadastro.AutoSize = true;
            this.MsgExplicacaoCadastro.BackColor = System.Drawing.Color.Transparent;
            this.MsgExplicacaoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgExplicacaoCadastro.Location = new System.Drawing.Point(188, 240);
            this.MsgExplicacaoCadastro.Name = "MsgExplicacaoCadastro";
            this.MsgExplicacaoCadastro.Size = new System.Drawing.Size(0, 18);
            this.MsgExplicacaoCadastro.TabIndex = 12;
            // 
            // pictureBoxCadastroAlunos
            // 
            this.pictureBoxCadastroAlunos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxCadastroAlunos.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCadastroAlunos.ErrorImage = null;
            this.pictureBoxCadastroAlunos.Location = new System.Drawing.Point(45, 118);
            this.pictureBoxCadastroAlunos.Name = "pictureBoxCadastroAlunos";
            this.pictureBoxCadastroAlunos.Size = new System.Drawing.Size(137, 139);
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
            this.pictureBoxAlterar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlterar.ErrorImage = null;
            this.pictureBoxAlterar.Location = new System.Drawing.Point(45, 273);
            this.pictureBoxAlterar.Name = "pictureBoxAlterar";
            this.pictureBoxAlterar.Size = new System.Drawing.Size(137, 148);
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
            this.pictureBox2Graficos.Location = new System.Drawing.Point(45, 440);
            this.pictureBox2Graficos.Name = "pictureBox2Graficos";
            this.pictureBox2Graficos.Size = new System.Drawing.Size(137, 131);
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
            this.dataGridViewListaGeralAlunos.Location = new System.Drawing.Point(688, 176);
            this.dataGridViewListaGeralAlunos.Name = "dataGridViewListaGeralAlunos";
            this.dataGridViewListaGeralAlunos.Size = new System.Drawing.Size(622, 551);
            this.dataGridViewListaGeralAlunos.TabIndex = 18;
            this.dataGridViewListaGeralAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(45, 590);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(137, 137);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.MsgTemporariaPagamento_Desaparece);
            this.pictureBox3.MouseHover += new System.EventHandler(this.MsgTemporariaPagamento_Aparece);
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
            // pictureBoxVoltar
            // 
            this.pictureBoxVoltar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxVoltar.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxVoltar.Name = "pictureBoxVoltar";
            this.pictureBoxVoltar.Size = new System.Drawing.Size(69, 56);
            this.pictureBoxVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVoltar.TabIndex = 27;
            this.pictureBoxVoltar.TabStop = false;
            this.pictureBoxVoltar.Click += new System.EventHandler(this.pictureBoxVoltar_Click);
            // 
            // labelTituloModalidade
            // 
            this.labelTituloModalidade.AutoSize = true;
            this.labelTituloModalidade.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloModalidade.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloModalidade.Location = new System.Drawing.Point(419, 26);
            this.labelTituloModalidade.Name = "labelTituloModalidade";
            this.labelTituloModalidade.Size = new System.Drawing.Size(0, 24);
            this.labelTituloModalidade.TabIndex = 23;
            // 
            // MsgExplicacaoAlterarDados1
            // 
            this.MsgExplicacaoAlterarDados1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MsgExplicacaoAlterarDados1.AutoSize = true;
            this.MsgExplicacaoAlterarDados1.BackColor = System.Drawing.Color.Transparent;
            this.MsgExplicacaoAlterarDados1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.MsgExplicacaoAlterarDados1.Location = new System.Drawing.Point(188, 404);
            this.MsgExplicacaoAlterarDados1.Name = "MsgExplicacaoAlterarDados1";
            this.MsgExplicacaoAlterarDados1.Size = new System.Drawing.Size(0, 18);
            this.MsgExplicacaoAlterarDados1.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(757, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(451, 33);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1UsuarioNome
            // 
            this.label1UsuarioNome.AutoSize = true;
            this.label1UsuarioNome.BackColor = System.Drawing.Color.Transparent;
            this.label1UsuarioNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1UsuarioNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1UsuarioNome.Location = new System.Drawing.Point(1173, 26);
            this.label1UsuarioNome.Name = "label1UsuarioNome";
            this.label1UsuarioNome.Size = new System.Drawing.Size(0, 22);
            this.label1UsuarioNome.TabIndex = 29;
            // 
            // TelaInicialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label1UsuarioNome);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBoxVoltar);
            this.Controls.Add(this.MsgExplicacaoAlterarDados1);
            this.Controls.Add(this.labelTituloModalidade);
            this.Controls.Add(this.MsgTemporariaPagamento);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dataGridViewListaGeralAlunos);
            this.Controls.Add(this.pictureBox2Graficos);
            this.Controls.Add(this.pictureBoxAlterar);
            this.Controls.Add(this.pictureBoxCadastroAlunos);
            this.Controls.Add(this.MsgExplicacaoGrafico);
            this.Controls.Add(this.msgpagamentos);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MsgExplicacaoGrafico;
        private System.Windows.Forms.Label msgpagamentos;
        private System.Windows.Forms.Label MsgExplicacaoCadastro;
        private System.Windows.Forms.PictureBox pictureBoxCadastroAlunos;
        private System.Windows.Forms.PictureBox pictureBoxAlterar;
        private System.Windows.Forms.PictureBox pictureBox2Graficos;
        private System.Windows.Forms.DataGridView dataGridViewListaGeralAlunos;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label MsgTemporariaPagamento;
        private System.Windows.Forms.PictureBox pictureBoxVoltar;
        private System.Windows.Forms.Label labelTituloModalidade;
        private System.Windows.Forms.Label MsgExplicacaoAlterarDados1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1UsuarioNome;
    }
}