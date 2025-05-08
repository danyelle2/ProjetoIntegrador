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
            this.msgpagamentos = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.MsgTemporariaPagamento = new System.Windows.Forms.Label();
            this.MsgExplicacaoCadastro = new System.Windows.Forms.Label();
            this.MsgExplicacaoGrafico = new System.Windows.Forms.Label();
            this.pictureBoxCadastroAlunos = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlterar = new System.Windows.Forms.PictureBox();
            this.pictureBox2Graficos = new System.Windows.Forms.PictureBox();
            this.pictureBox3Pagamento = new System.Windows.Forms.PictureBox();
            this.MsgExplicacaoAlterarDados1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1UsuarioNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewListaGeralAlunos = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTituloModalidade = new System.Windows.Forms.Label();
            this.NomeUser = new System.Windows.Forms.Label();
            this.pictureBoxVoltar = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadastroAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Graficos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3Pagamento)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaGeralAlunos)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoltar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgpagamentos
            // 
            this.msgpagamentos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.msgpagamentos.AutoSize = true;
            this.msgpagamentos.BackColor = System.Drawing.Color.Transparent;
            this.msgpagamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.msgpagamentos.Location = new System.Drawing.Point(205, 712);
            this.msgpagamentos.Name = "msgpagamentos";
            this.msgpagamentos.Size = new System.Drawing.Size(0, 18);
            this.msgpagamentos.TabIndex = 13;
            this.msgpagamentos.Click += new System.EventHandler(this.MsgExplicacaoAlterarDados_Click);
            this.msgpagamentos.MouseLeave += new System.EventHandler(this.MsgTemporariaPagamento_Desaparece);
            this.msgpagamentos.MouseHover += new System.EventHandler(this.MsgTemporariaPagamento_Aparece);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
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
            // MsgExplicacaoCadastro
            // 
            this.MsgExplicacaoCadastro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MsgExplicacaoCadastro.AutoSize = true;
            this.MsgExplicacaoCadastro.BackColor = System.Drawing.Color.Transparent;
            this.MsgExplicacaoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgExplicacaoCadastro.Location = new System.Drawing.Point(205, 234);
            this.MsgExplicacaoCadastro.Name = "MsgExplicacaoCadastro";
            this.MsgExplicacaoCadastro.Size = new System.Drawing.Size(0, 18);
            this.MsgExplicacaoCadastro.TabIndex = 31;
            // 
            // MsgExplicacaoGrafico
            // 
            this.MsgExplicacaoGrafico.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MsgExplicacaoGrafico.AutoSize = true;
            this.MsgExplicacaoGrafico.BackColor = System.Drawing.Color.Transparent;
            this.MsgExplicacaoGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.MsgExplicacaoGrafico.Location = new System.Drawing.Point(205, 537);
            this.MsgExplicacaoGrafico.Name = "MsgExplicacaoGrafico";
            this.MsgExplicacaoGrafico.Size = new System.Drawing.Size(0, 18);
            this.MsgExplicacaoGrafico.TabIndex = 32;
            // 
            // pictureBoxCadastroAlunos
            // 
            this.pictureBoxCadastroAlunos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxCadastroAlunos.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCadastroAlunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCadastroAlunos.ErrorImage = null;
            this.pictureBoxCadastroAlunos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCadastroAlunos.Image")));
            this.pictureBoxCadastroAlunos.Location = new System.Drawing.Point(43, 74);
            this.pictureBoxCadastroAlunos.Name = "pictureBoxCadastroAlunos";
            this.pictureBoxCadastroAlunos.Size = new System.Drawing.Size(162, 168);
            this.pictureBoxCadastroAlunos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCadastroAlunos.TabIndex = 33;
            this.pictureBoxCadastroAlunos.TabStop = false;
            // 
            // pictureBoxAlterar
            // 
            this.pictureBoxAlterar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxAlterar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAlterar.ErrorImage = null;
            this.pictureBoxAlterar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAlterar.Image")));
            this.pictureBoxAlterar.Location = new System.Drawing.Point(43, 248);
            this.pictureBoxAlterar.Name = "pictureBoxAlterar";
            this.pictureBoxAlterar.Size = new System.Drawing.Size(162, 168);
            this.pictureBoxAlterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlterar.TabIndex = 34;
            this.pictureBoxAlterar.TabStop = false;
            // 
            // pictureBox2Graficos
            // 
            this.pictureBox2Graficos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2Graficos.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2Graficos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2Graficos.BackgroundImage")));
            this.pictureBox2Graficos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2Graficos.ErrorImage = null;
            this.pictureBox2Graficos.Location = new System.Drawing.Point(43, 422);
            this.pictureBox2Graficos.Name = "pictureBox2Graficos";
            this.pictureBox2Graficos.Size = new System.Drawing.Size(162, 168);
            this.pictureBox2Graficos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2Graficos.TabIndex = 35;
            this.pictureBox2Graficos.TabStop = false;
            // 
            // pictureBox3Pagamento
            // 
            this.pictureBox3Pagamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3Pagamento.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3Pagamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3Pagamento.BackgroundImage")));
            this.pictureBox3Pagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3Pagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3Pagamento.ErrorImage = null;
            this.pictureBox3Pagamento.Location = new System.Drawing.Point(43, 596);
            this.pictureBox3Pagamento.Name = "pictureBox3Pagamento";
            this.pictureBox3Pagamento.Size = new System.Drawing.Size(162, 154);
            this.pictureBox3Pagamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3Pagamento.TabIndex = 36;
            this.pictureBox3Pagamento.TabStop = false;
            this.pictureBox3Pagamento.MouseLeave += new System.EventHandler(this.MsgTemporariaPagamento_Desaparece);
            this.pictureBox3Pagamento.MouseHover += new System.EventHandler(this.MsgTemporariaPagamento_Aparece);
            // 
            // MsgExplicacaoAlterarDados1
            // 
            this.MsgExplicacaoAlterarDados1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MsgExplicacaoAlterarDados1.AutoSize = true;
            this.MsgExplicacaoAlterarDados1.BackColor = System.Drawing.Color.Transparent;
            this.MsgExplicacaoAlterarDados1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.MsgExplicacaoAlterarDados1.Location = new System.Drawing.Point(205, 398);
            this.MsgExplicacaoAlterarDados1.Name = "MsgExplicacaoAlterarDados1";
            this.MsgExplicacaoAlterarDados1.Size = new System.Drawing.Size(0, 18);
            this.MsgExplicacaoAlterarDados1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 38);
            this.label1.TabIndex = 42;
            this.label1.Text = "Cadastro";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 38);
            this.label2.TabIndex = 43;
            this.label2.Text = "Alterar Dados";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 38);
            this.label3.TabIndex = 44;
            this.label3.Text = "Dados Visuais";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 584);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 38);
            this.label4.TabIndex = 45;
            this.label4.Text = "Pagamentos";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 68);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.71429F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(651, 681);
            this.tableLayoutPanel2.TabIndex = 47;
            // 
            // label1UsuarioNome
            // 
            this.label1UsuarioNome.AutoSize = true;
            this.label1UsuarioNome.BackColor = System.Drawing.Color.Transparent;
            this.label1UsuarioNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1UsuarioNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1UsuarioNome.Location = new System.Drawing.Point(1190, 9);
            this.label1UsuarioNome.Name = "label1UsuarioNome";
            this.label1UsuarioNome.Size = new System.Drawing.Size(0, 22);
            this.label1UsuarioNome.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dataGridViewListaGeralAlunos);
            this.panel1.Location = new System.Drawing.Point(671, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 628);
            this.panel1.TabIndex = 48;
            // 
            // dataGridViewListaGeralAlunos
            // 
            this.dataGridViewListaGeralAlunos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewListaGeralAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaGeralAlunos.Location = new System.Drawing.Point(29, 108);
            this.dataGridViewListaGeralAlunos.Name = "dataGridViewListaGeralAlunos";
            this.dataGridViewListaGeralAlunos.Size = new System.Drawing.Size(622, 496);
            this.dataGridViewListaGeralAlunos.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(97, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(512, 41);
            this.textBox1.TabIndex = 28;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 60, 20, 0);
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1370, 749);
            this.tableLayoutPanel3.TabIndex = 49;
            // 
            // labelTituloModalidade
            // 
            this.labelTituloModalidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTituloModalidade.AutoSize = true;
            this.labelTituloModalidade.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloModalidade.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloModalidade.Location = new System.Drawing.Point(276, 22);
            this.labelTituloModalidade.Name = "labelTituloModalidade";
            this.labelTituloModalidade.Size = new System.Drawing.Size(34, 24);
            this.labelTituloModalidade.TabIndex = 37;
            this.labelTituloModalidade.Text = "....";
            // 
            // NomeUser
            // 
            this.NomeUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NomeUser.AutoSize = true;
            this.NomeUser.BackColor = System.Drawing.Color.Transparent;
            this.NomeUser.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NomeUser.Location = new System.Drawing.Point(1128, 22);
            this.NomeUser.Name = "NomeUser";
            this.NomeUser.Size = new System.Drawing.Size(34, 24);
            this.NomeUser.TabIndex = 50;
            this.NomeUser.Text = "....";
            // 
            // pictureBoxVoltar
            // 
            this.pictureBoxVoltar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVoltar.Image")));
            this.pictureBoxVoltar.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxVoltar.Name = "pictureBoxVoltar";
            this.pictureBoxVoltar.Size = new System.Drawing.Size(81, 62);
            this.pictureBoxVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxVoltar.TabIndex = 39;
            this.pictureBoxVoltar.TabStop = false;
            this.pictureBoxVoltar.Click += new System.EventHandler(this.pictureBoxVoltar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.0292F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 852F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxVoltar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.NomeUser, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTituloModalidade, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.94526F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1370, 68);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // TelaInicialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label1UsuarioNome);
            this.Controls.Add(this.MsgExplicacaoAlterarDados1);
            this.Controls.Add(this.pictureBox3Pagamento);
            this.Controls.Add(this.pictureBox2Graficos);
            this.Controls.Add(this.pictureBoxAlterar);
            this.Controls.Add(this.pictureBoxCadastroAlunos);
            this.Controls.Add(this.MsgExplicacaoGrafico);
            this.Controls.Add(this.MsgExplicacaoCadastro);
            this.Controls.Add(this.MsgTemporariaPagamento);
            this.Controls.Add(this.msgpagamentos);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaInicialForm";
            this.Text = "TelaInicialForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaInicialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadastroAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Graficos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3Pagamento)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaGeralAlunos)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoltar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label msgpagamentos;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label MsgTemporariaPagamento;
        private System.Windows.Forms.Label MsgExplicacaoCadastro;
        private System.Windows.Forms.Label MsgExplicacaoGrafico;
        private System.Windows.Forms.PictureBox pictureBoxCadastroAlunos;
        private System.Windows.Forms.PictureBox pictureBoxAlterar;
        private System.Windows.Forms.PictureBox pictureBox2Graficos;
        private System.Windows.Forms.PictureBox pictureBox3Pagamento;
        private System.Windows.Forms.Label MsgExplicacaoAlterarDados1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1UsuarioNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewListaGeralAlunos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelTituloModalidade;
        private System.Windows.Forms.Label NomeUser;
        private System.Windows.Forms.PictureBox pictureBoxVoltar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}