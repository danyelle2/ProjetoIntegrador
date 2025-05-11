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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTituloModalidade = new System.Windows.Forms.Label();
            this.pictureBoxVoltar = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1UsuarioNome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridViewListaGeralAlunos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadastroAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlterar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Graficos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3Pagamento)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoltar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaGeralAlunos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgpagamentos
            // 
            this.msgpagamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.msgpagamentos.AutoSize = true;
            this.msgpagamentos.BackColor = System.Drawing.Color.Transparent;
            this.msgpagamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.msgpagamentos.Location = new System.Drawing.Point(3, 126);
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
            this.MsgTemporariaPagamento.Location = new System.Drawing.Point(87, 951);
            this.MsgTemporariaPagamento.Name = "MsgTemporariaPagamento";
            this.MsgTemporariaPagamento.Size = new System.Drawing.Size(16, 13);
            this.MsgTemporariaPagamento.TabIndex = 21;
            this.MsgTemporariaPagamento.Text = "...";
            this.MsgTemporariaPagamento.MouseLeave += new System.EventHandler(this.MsgTemporariaPagamento_Desaparece);
            this.MsgTemporariaPagamento.MouseHover += new System.EventHandler(this.MsgTemporariaPagamento_Aparece);
            // 
            // MsgExplicacaoCadastro
            // 
            this.MsgExplicacaoCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MsgExplicacaoCadastro.AutoSize = true;
            this.MsgExplicacaoCadastro.BackColor = System.Drawing.Color.Transparent;
            this.MsgExplicacaoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgExplicacaoCadastro.Location = new System.Drawing.Point(24, 131);
            this.MsgExplicacaoCadastro.Name = "MsgExplicacaoCadastro";
            this.MsgExplicacaoCadastro.Size = new System.Drawing.Size(0, 18);
            this.MsgExplicacaoCadastro.TabIndex = 31;
            // 
            // MsgExplicacaoGrafico
            // 
            this.MsgExplicacaoGrafico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MsgExplicacaoGrafico.AutoSize = true;
            this.MsgExplicacaoGrafico.BackColor = System.Drawing.Color.Transparent;
            this.MsgExplicacaoGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.MsgExplicacaoGrafico.Location = new System.Drawing.Point(3, 150);
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
            this.pictureBoxCadastroAlunos.Location = new System.Drawing.Point(103, 3);
            this.pictureBoxCadastroAlunos.Name = "pictureBoxCadastroAlunos";
            this.pictureBoxCadastroAlunos.Size = new System.Drawing.Size(146, 168);
            this.pictureBoxCadastroAlunos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCadastroAlunos.TabIndex = 33;
            this.pictureBoxCadastroAlunos.TabStop = false;
            this.pictureBoxCadastroAlunos.Click += new System.EventHandler(this.pictureBoxCadastroAlunos_Click);
            this.pictureBoxCadastroAlunos.MouseLeave += new System.EventHandler(this.pictureBoxCadastroAlunosDesaparece);
            this.pictureBoxCadastroAlunos.MouseHover += new System.EventHandler(this.pictureBoxCadastroAlunosAparecer);
            // 
            // pictureBoxAlterar
            // 
            this.pictureBoxAlterar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxAlterar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAlterar.ErrorImage = null;
            this.pictureBoxAlterar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAlterar.Image")));
            this.pictureBoxAlterar.Location = new System.Drawing.Point(103, 179);
            this.pictureBoxAlterar.Name = "pictureBoxAlterar";
            this.pictureBoxAlterar.Size = new System.Drawing.Size(146, 168);
            this.pictureBoxAlterar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlterar.TabIndex = 34;
            this.pictureBoxAlterar.TabStop = false;
            this.pictureBoxAlterar.Click += new System.EventHandler(this.pictureBoxAlterar_Click);
            this.pictureBoxAlterar.MouseLeave += new System.EventHandler(this.pictureBoxAlterarDadosDesaparece);
            this.pictureBoxAlterar.MouseHover += new System.EventHandler(this.pictureBoxAlterarDadosAparece);
            // 
            // pictureBox2Graficos
            // 
            this.pictureBox2Graficos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2Graficos.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2Graficos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2Graficos.BackgroundImage")));
            this.pictureBox2Graficos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2Graficos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2Graficos.ErrorImage = null;
            this.pictureBox2Graficos.Location = new System.Drawing.Point(103, 353);
            this.pictureBox2Graficos.Name = "pictureBox2Graficos";
            this.pictureBox2Graficos.Size = new System.Drawing.Size(146, 168);
            this.pictureBox2Graficos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2Graficos.TabIndex = 35;
            this.pictureBox2Graficos.TabStop = false;
            this.pictureBox2Graficos.Click += new System.EventHandler(this.pictureBox2Graficos_Click);
            this.pictureBox2Graficos.MouseLeave += new System.EventHandler(this.pictureBoxGráficoDesaparece);
            this.pictureBox2Graficos.MouseHover += new System.EventHandler(this.pictureBoxGráficoAparece);
            // 
            // pictureBox3Pagamento
            // 
            this.pictureBox3Pagamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3Pagamento.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3Pagamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3Pagamento.BackgroundImage")));
            this.pictureBox3Pagamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3Pagamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3Pagamento.ErrorImage = null;
            this.pictureBox3Pagamento.Location = new System.Drawing.Point(103, 528);
            this.pictureBox3Pagamento.Name = "pictureBox3Pagamento";
            this.pictureBox3Pagamento.Size = new System.Drawing.Size(146, 150);
            this.pictureBox3Pagamento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3Pagamento.TabIndex = 36;
            this.pictureBox3Pagamento.TabStop = false;
            this.pictureBox3Pagamento.Click += new System.EventHandler(this.pictureBox3Pagamento_Click);
            this.pictureBox3Pagamento.MouseLeave += new System.EventHandler(this.MsgTemporariaPagamento_Desaparece);
            this.pictureBox3Pagamento.MouseHover += new System.EventHandler(this.MsgTemporariaPagamento_Aparece);
            // 
            // MsgExplicacaoAlterarDados1
            // 
            this.MsgExplicacaoAlterarDados1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MsgExplicacaoAlterarDados1.AutoSize = true;
            this.MsgExplicacaoAlterarDados1.BackColor = System.Drawing.Color.Transparent;
            this.MsgExplicacaoAlterarDados1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.MsgExplicacaoAlterarDados1.Location = new System.Drawing.Point(3, 150);
            this.MsgExplicacaoAlterarDados1.Name = "MsgExplicacaoAlterarDados1";
            this.MsgExplicacaoAlterarDados1.Size = new System.Drawing.Size(0, 18);
            this.MsgExplicacaoAlterarDados1.TabIndex = 38;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 399F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox3Pagamento, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2Graficos, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxCadastroAlunos, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxAlterar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 1, 3);
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
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // labelTituloModalidade
            // 
            this.labelTituloModalidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTituloModalidade.AutoSize = true;
            this.labelTituloModalidade.BackColor = System.Drawing.Color.Transparent;
            this.labelTituloModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloModalidade.Location = new System.Drawing.Point(545, 21);
            this.labelTituloModalidade.Name = "labelTituloModalidade";
            this.labelTituloModalidade.Size = new System.Drawing.Size(40, 25);
            this.labelTituloModalidade.TabIndex = 37;
            this.labelTituloModalidade.Text = "....";
            // 
            // pictureBoxVoltar
            // 
            this.pictureBoxVoltar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.0292F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 953F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxVoltar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1UsuarioNome, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelTituloModalidade, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.94526F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1372, 68);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // label1UsuarioNome
            // 
            this.label1UsuarioNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1UsuarioNome.AutoSize = true;
            this.label1UsuarioNome.BackColor = System.Drawing.Color.Transparent;
            this.label1UsuarioNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1UsuarioNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1UsuarioNome.Location = new System.Drawing.Point(1145, 23);
            this.label1UsuarioNome.Name = "label1UsuarioNome";
            this.label1UsuarioNome.Size = new System.Drawing.Size(40, 22);
            this.label1UsuarioNome.TabIndex = 41;
            this.label1UsuarioNome.Text = "-----";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1045, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 62);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(657, 68);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(715, 681);
            this.tableLayoutPanel3.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.dataGridViewListaGeralAlunos);
            this.panel1.Location = new System.Drawing.Point(19, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 628);
            this.panel1.TabIndex = 49;
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
            // dataGridViewListaGeralAlunos
            // 
            this.dataGridViewListaGeralAlunos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewListaGeralAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaGeralAlunos.Location = new System.Drawing.Point(29, 108);
            this.dataGridViewListaGeralAlunos.Name = "dataGridViewListaGeralAlunos";
            this.dataGridViewListaGeralAlunos.Size = new System.Drawing.Size(622, 496);
            this.dataGridViewListaGeralAlunos.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.MsgExplicacaoCadastro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(255, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 170);
            this.panel2.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 38);
            this.label1.TabIndex = 43;
            this.label1.Text = "Cadastro";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.MsgExplicacaoAlterarDados1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(255, 179);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 168);
            this.panel3.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 38);
            this.label2.TabIndex = 44;
            this.label2.Text = "Alterar Dados";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.MsgExplicacaoGrafico);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(255, 353);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(393, 169);
            this.panel4.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 38);
            this.label3.TabIndex = 45;
            this.label3.Text = "Dados Visuais";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.msgpagamentos);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(255, 528);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(393, 150);
            this.panel5.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 38);
            this.label4.TabIndex = 46;
            this.label4.Text = "Pagamentos";
            // 
            // TelaInicialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1372, 749);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.MsgTemporariaPagamento);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaInicialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaInicialForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaInicialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadastroAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlterar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2Graficos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3Pagamento)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoltar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaGeralAlunos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelTituloModalidade;
        private System.Windows.Forms.PictureBox pictureBoxVoltar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1UsuarioNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridViewListaGeralAlunos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
    }
}