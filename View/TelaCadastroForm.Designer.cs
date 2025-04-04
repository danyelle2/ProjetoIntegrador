namespace ProjetoIntegrador.View
{
    partial class TelaCadastroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroForm));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxModalidade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.msgTemporariaUsuario = new System.Windows.Forms.Button();
            this.MsgExplicacaoUsuario = new System.Windows.Forms.Label();
            this.TxTExplicacaoModalidade = new System.Windows.Forms.Label();
            this.btnModalidadeCadastro = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSenhaCadastro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textSenhaConfirmada = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textNomeCadastro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuarioCadastro = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.comboBoxModalidade);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBoxTipoUsuario);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.msgTemporariaUsuario);
            this.groupBox3.Controls.Add(this.MsgExplicacaoUsuario);
            this.groupBox3.Controls.Add(this.TxTExplicacaoModalidade);
            this.groupBox3.Controls.Add(this.btnModalidadeCadastro);
            this.groupBox3.Location = new System.Drawing.Point(444, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(519, 141);
            this.groupBox3.TabIndex = 73;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo usuário";
            // 
            // comboBoxModalidade
            // 
            this.comboBoxModalidade.FormattingEnabled = true;
            this.comboBoxModalidade.Items.AddRange(new object[] {
            "Zumba",
            "Funcional",
            "Muay thai",
            "Geral"});
            this.comboBoxModalidade.Location = new System.Drawing.Point(272, 82);
            this.comboBoxModalidade.Name = "comboBoxModalidade";
            this.comboBoxModalidade.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModalidade.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Tipo de usuário";
            // 
            // comboBoxTipoUsuario
            // 
            this.comboBoxTipoUsuario.FormattingEnabled = true;
            this.comboBoxTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Usuário Padrão"});
            this.comboBoxTipoUsuario.Location = new System.Drawing.Point(36, 82);
            this.comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            this.comboBoxTipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoUsuario.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "Modalidade ";
            // 
            // msgTemporariaUsuario
            // 
            this.msgTemporariaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.msgTemporariaUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("msgTemporariaUsuario.BackgroundImage")));
            this.msgTemporariaUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.msgTemporariaUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msgTemporariaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.msgTemporariaUsuario.Location = new System.Drawing.Point(137, 43);
            this.msgTemporariaUsuario.Name = "msgTemporariaUsuario";
            this.msgTemporariaUsuario.Size = new System.Drawing.Size(20, 25);
            this.msgTemporariaUsuario.TabIndex = 64;
            this.msgTemporariaUsuario.UseVisualStyleBackColor = false;
            this.msgTemporariaUsuario.Click += new System.EventHandler(this.msgTemporariaUsuario_Click);
            this.msgTemporariaUsuario.MouseLeave += new System.EventHandler(this.msgTemporariaUsuarioDesaparece);
            this.msgTemporariaUsuario.MouseHover += new System.EventHandler(this.msgTemporariaUsuarioAparece);
            // 
            // MsgExplicacaoUsuario
            // 
            this.MsgExplicacaoUsuario.AutoSize = true;
            this.MsgExplicacaoUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MsgExplicacaoUsuario.Location = new System.Drawing.Point(33, 106);
            this.MsgExplicacaoUsuario.Name = "MsgExplicacaoUsuario";
            this.MsgExplicacaoUsuario.Size = new System.Drawing.Size(16, 13);
            this.MsgExplicacaoUsuario.TabIndex = 65;
            this.MsgExplicacaoUsuario.Text = "...";
            // 
            // TxTExplicacaoModalidade
            // 
            this.TxTExplicacaoModalidade.AutoSize = true;
            this.TxTExplicacaoModalidade.ForeColor = System.Drawing.Color.Black;
            this.TxTExplicacaoModalidade.Location = new System.Drawing.Point(258, 106);
            this.TxTExplicacaoModalidade.Name = "TxTExplicacaoModalidade";
            this.TxTExplicacaoModalidade.Size = new System.Drawing.Size(16, 13);
            this.TxTExplicacaoModalidade.TabIndex = 67;
            this.TxTExplicacaoModalidade.Text = "...";
            // 
            // btnModalidadeCadastro
            // 
            this.btnModalidadeCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnModalidadeCadastro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModalidadeCadastro.BackgroundImage")));
            this.btnModalidadeCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModalidadeCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModalidadeCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModalidadeCadastro.Location = new System.Drawing.Point(373, 44);
            this.btnModalidadeCadastro.Name = "btnModalidadeCadastro";
            this.btnModalidadeCadastro.Size = new System.Drawing.Size(20, 26);
            this.btnModalidadeCadastro.TabIndex = 66;
            this.btnModalidadeCadastro.UseVisualStyleBackColor = false;
            this.btnModalidadeCadastro.MouseLeave += new System.EventHandler(this.btnModalidadeCadastroDesapareceText);
            this.btnModalidadeCadastro.MouseHover += new System.EventHandler(this.btnModalidadeCadastroApareceText);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtSenhaCadastro);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textSenhaConfirmada);
            this.groupBox2.Location = new System.Drawing.Point(54, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 218);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login";
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaCadastro.Location = new System.Drawing.Point(25, 50);
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.PasswordChar = '*';
            this.txtSenhaCadastro.Size = new System.Drawing.Size(194, 20);
            this.txtSenhaCadastro.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Digite uma senha";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Confirme a senha";
            // 
            // textSenhaConfirmada
            // 
            this.textSenhaConfirmada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSenhaConfirmada.Location = new System.Drawing.Point(25, 124);
            this.textSenhaConfirmada.Name = "textSenhaConfirmada";
            this.textSenhaConfirmada.PasswordChar = '*';
            this.textSenhaConfirmada.Size = new System.Drawing.Size(194, 20);
            this.textSenhaConfirmada.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textNomeCadastro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUsuarioCadastro);
            this.groupBox1.Location = new System.Drawing.Point(54, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 141);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados pessoais";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Nome";
            // 
            // textNomeCadastro
            // 
            this.textNomeCadastro.Location = new System.Drawing.Point(25, 98);
            this.textNomeCadastro.MaxLength = 11;
            this.textNomeCadastro.Name = "textNomeCadastro";
            this.textNomeCadastro.Size = new System.Drawing.Size(194, 20);
            this.textNomeCadastro.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Insira seu CPF ";
            // 
            // txtUsuarioCadastro
            // 
            this.txtUsuarioCadastro.Location = new System.Drawing.Point(25, 50);
            this.txtUsuarioCadastro.MaxLength = 11;
            this.txtUsuarioCadastro.Name = "txtUsuarioCadastro";
            this.txtUsuarioCadastro.Size = new System.Drawing.Size(194, 20);
            this.txtUsuarioCadastro.TabIndex = 48;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnCadastro.Location = new System.Drawing.Point(-97, 528);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(144, 38);
            this.btnCadastro.TabIndex = 71;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.UseWaitCursor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.Location = new System.Drawing.Point(54, 45);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(57, 38);
            this.btnVoltar.TabIndex = 75;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // TelaCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 527);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCadastro);
            this.Name = "TelaCadastroForm";
            this.Text = "TelaCadastroForm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxModalidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxTipoUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button msgTemporariaUsuario;
        private System.Windows.Forms.Label MsgExplicacaoUsuario;
        private System.Windows.Forms.Label TxTExplicacaoModalidade;
        private System.Windows.Forms.Button btnModalidadeCadastro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSenhaCadastro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSenhaConfirmada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textNomeCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuarioCadastro;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnVoltar;
    }
}