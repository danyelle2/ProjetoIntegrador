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
            this.labelMsgErroModalidade = new System.Windows.Forms.Label();
            this.comboBoxModalidade = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxVoltar = new System.Windows.Forms.PictureBox();
            this.labelMsgErroCpf1 = new System.Windows.Forms.Label();
            this.MsgExplicacaoModalidade1 = new System.Windows.Forms.Label();
            this.MsgExplicacaoUsuario1 = new System.Windows.Forms.Label();
            this.labelMsgErroModalidade1 = new System.Windows.Forms.Label();
            this.MsgErrorSenha1 = new System.Windows.Forms.Label();
            this.comboBoxModalidade1 = new System.Windows.Forms.ComboBox();
            this.TxTExplicacaoModalidade = new System.Windows.Forms.Label();
            this.MsgExplicacaoUsuario = new System.Windows.Forms.Label();
            this.msgTemporariaUsuario = new System.Windows.Forms.Button();
            this.btnModalidadeCadastro = new System.Windows.Forms.Button();
            this.MsgErrorTipoUsuario = new System.Windows.Forms.Label();
            this.comboBoxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.MsgErrorSenha = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Panel();
            this.txtSenhaCadastro = new System.Windows.Forms.TextBox();
            this.textSenhaConfirmada = new System.Windows.Forms.TextBox();
            this.textNomeCadastro = new System.Windows.Forms.TextBox();
            this.txtUsuarioCadastro = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMsgErroModalidade
            // 
            this.labelMsgErroModalidade.AutoSize = true;
            this.labelMsgErroModalidade.BackColor = System.Drawing.Color.Transparent;
            this.labelMsgErroModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsgErroModalidade.ForeColor = System.Drawing.Color.Maroon;
            this.labelMsgErroModalidade.Location = new System.Drawing.Point(184, 984);
            this.labelMsgErroModalidade.Name = "labelMsgErroModalidade";
            this.labelMsgErroModalidade.Size = new System.Drawing.Size(16, 16);
            this.labelMsgErroModalidade.TabIndex = 68;
            this.labelMsgErroModalidade.Text = "...";
            // 
            // comboBoxModalidade
            // 
            this.comboBoxModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModalidade.FormattingEnabled = true;
            this.comboBoxModalidade.Location = new System.Drawing.Point(187, 926);
            this.comboBoxModalidade.Name = "comboBoxModalidade";
            this.comboBoxModalidade.Size = new System.Drawing.Size(530, 33);
            this.comboBoxModalidade.TabIndex = 63;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVoltar.BackgroundImage")));
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.Location = new System.Drawing.Point(62, -99);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(57, 38);
            this.btnVoltar.TabIndex = 75;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBoxVoltar);
            this.panel1.Controls.Add(this.labelMsgErroCpf1);
            this.panel1.Controls.Add(this.MsgExplicacaoModalidade1);
            this.panel1.Controls.Add(this.MsgExplicacaoUsuario1);
            this.panel1.Controls.Add(this.labelMsgErroModalidade1);
            this.panel1.Controls.Add(this.MsgErrorSenha1);
            this.panel1.Controls.Add(this.comboBoxModalidade1);
            this.panel1.Controls.Add(this.TxTExplicacaoModalidade);
            this.panel1.Controls.Add(this.MsgExplicacaoUsuario);
            this.panel1.Controls.Add(this.msgTemporariaUsuario);
            this.panel1.Controls.Add(this.btnModalidadeCadastro);
            this.panel1.Controls.Add(this.MsgErrorTipoUsuario);
            this.panel1.Controls.Add(this.comboBoxTipoUsuario);
            this.panel1.Controls.Add(this.MsgErrorSenha);
            this.panel1.Controls.Add(this.btnCadastro);
            this.panel1.Controls.Add(this.txtSenhaCadastro);
            this.panel1.Controls.Add(this.textSenhaConfirmada);
            this.panel1.Controls.Add(this.textNomeCadastro);
            this.panel1.Controls.Add(this.txtUsuarioCadastro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 749);
            this.panel1.TabIndex = 76;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBoxVoltar
            // 
            this.pictureBoxVoltar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxVoltar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVoltar.Image")));
            this.pictureBoxVoltar.Location = new System.Drawing.Point(22, 12);
            this.pictureBoxVoltar.Name = "pictureBoxVoltar";
            this.pictureBoxVoltar.Size = new System.Drawing.Size(74, 66);
            this.pictureBoxVoltar.TabIndex = 81;
            this.pictureBoxVoltar.TabStop = false;
            this.pictureBoxVoltar.Click += new System.EventHandler(this.pictureBoxVoltar_Click);
            // 
            // labelMsgErroCpf1
            // 
            this.labelMsgErroCpf1.AutoSize = true;
            this.labelMsgErroCpf1.BackColor = System.Drawing.Color.Transparent;
            this.labelMsgErroCpf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsgErroCpf1.ForeColor = System.Drawing.Color.Maroon;
            this.labelMsgErroCpf1.Location = new System.Drawing.Point(65, 207);
            this.labelMsgErroCpf1.Name = "labelMsgErroCpf1";
            this.labelMsgErroCpf1.Size = new System.Drawing.Size(0, 16);
            this.labelMsgErroCpf1.TabIndex = 80;
            // 
            // MsgExplicacaoModalidade1
            // 
            this.MsgExplicacaoModalidade1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MsgExplicacaoModalidade1.AutoSize = true;
            this.MsgExplicacaoModalidade1.BackColor = System.Drawing.Color.Transparent;
            this.MsgExplicacaoModalidade1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgExplicacaoModalidade1.ForeColor = System.Drawing.Color.Black;
            this.MsgExplicacaoModalidade1.Location = new System.Drawing.Point(286, 569);
            this.MsgExplicacaoModalidade1.Name = "MsgExplicacaoModalidade1";
            this.MsgExplicacaoModalidade1.Size = new System.Drawing.Size(0, 15);
            this.MsgExplicacaoModalidade1.TabIndex = 79;
            // 
            // MsgExplicacaoUsuario1
            // 
            this.MsgExplicacaoUsuario1.AutoSize = true;
            this.MsgExplicacaoUsuario1.BackColor = System.Drawing.Color.Transparent;
            this.MsgExplicacaoUsuario1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgExplicacaoUsuario1.ForeColor = System.Drawing.Color.Black;
            this.MsgExplicacaoUsuario1.Location = new System.Drawing.Point(257, 463);
            this.MsgExplicacaoUsuario1.Name = "MsgExplicacaoUsuario1";
            this.MsgExplicacaoUsuario1.Size = new System.Drawing.Size(0, 15);
            this.MsgExplicacaoUsuario1.TabIndex = 78;
            // 
            // labelMsgErroModalidade1
            // 
            this.labelMsgErroModalidade1.AutoSize = true;
            this.labelMsgErroModalidade1.BackColor = System.Drawing.Color.Transparent;
            this.labelMsgErroModalidade1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsgErroModalidade1.ForeColor = System.Drawing.Color.Maroon;
            this.labelMsgErroModalidade1.Location = new System.Drawing.Point(96, 663);
            this.labelMsgErroModalidade1.Name = "labelMsgErroModalidade1";
            this.labelMsgErroModalidade1.Size = new System.Drawing.Size(0, 16);
            this.labelMsgErroModalidade1.TabIndex = 77;
            // 
            // MsgErrorSenha1
            // 
            this.MsgErrorSenha1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MsgErrorSenha1.AutoSize = true;
            this.MsgErrorSenha1.BackColor = System.Drawing.Color.Transparent;
            this.MsgErrorSenha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgErrorSenha1.ForeColor = System.Drawing.Color.Maroon;
            this.MsgErrorSenha1.Location = new System.Drawing.Point(828, 463);
            this.MsgErrorSenha1.Name = "MsgErrorSenha1";
            this.MsgErrorSenha1.Size = new System.Drawing.Size(0, 16);
            this.MsgErrorSenha1.TabIndex = 76;
            // 
            // comboBoxModalidade1
            // 
            this.comboBoxModalidade1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModalidade1.FormattingEnabled = true;
            this.comboBoxModalidade1.Items.AddRange(new object[] {
            "Administrador",
            "Usuário Padrão"});
            this.comboBoxModalidade1.Location = new System.Drawing.Point(99, 617);
            this.comboBoxModalidade1.Name = "comboBoxModalidade1";
            this.comboBoxModalidade1.Size = new System.Drawing.Size(432, 33);
            this.comboBoxModalidade1.TabIndex = 73;
            this.comboBoxModalidade1.SelectedIndexChanged += new System.EventHandler(this.comboBoxModalidade1_SelectedIndexChanged);
            // 
            // TxTExplicacaoModalidade
            // 
            this.TxTExplicacaoModalidade.AutoSize = true;
            this.TxTExplicacaoModalidade.BackColor = System.Drawing.Color.Transparent;
            this.TxTExplicacaoModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTExplicacaoModalidade.ForeColor = System.Drawing.Color.Black;
            this.TxTExplicacaoModalidade.Location = new System.Drawing.Point(26, 709);
            this.TxTExplicacaoModalidade.Name = "TxTExplicacaoModalidade";
            this.TxTExplicacaoModalidade.Size = new System.Drawing.Size(0, 20);
            this.TxTExplicacaoModalidade.TabIndex = 70;
            // 
            // MsgExplicacaoUsuario
            // 
            this.MsgExplicacaoUsuario.AutoSize = true;
            this.MsgExplicacaoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.MsgExplicacaoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgExplicacaoUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MsgExplicacaoUsuario.Location = new System.Drawing.Point(685, 282);
            this.MsgExplicacaoUsuario.Name = "MsgExplicacaoUsuario";
            this.MsgExplicacaoUsuario.Size = new System.Drawing.Size(0, 20);
            this.MsgExplicacaoUsuario.TabIndex = 69;
            // 
            // msgTemporariaUsuario
            // 
            this.msgTemporariaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.msgTemporariaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.msgTemporariaUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("msgTemporariaUsuario.BackgroundImage")));
            this.msgTemporariaUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.msgTemporariaUsuario.Cursor = System.Windows.Forms.Cursors.Help;
            this.msgTemporariaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.msgTemporariaUsuario.Location = new System.Drawing.Point(196, 443);
            this.msgTemporariaUsuario.Name = "msgTemporariaUsuario";
            this.msgTemporariaUsuario.Size = new System.Drawing.Size(55, 52);
            this.msgTemporariaUsuario.TabIndex = 67;
            this.msgTemporariaUsuario.UseVisualStyleBackColor = false;
            this.msgTemporariaUsuario.MouseLeave += new System.EventHandler(this.msgTemporariaUsuarioDesaparece);
            this.msgTemporariaUsuario.MouseHover += new System.EventHandler(this.msgTemporariaUsuarioAparece);
            // 
            // btnModalidadeCadastro
            // 
            this.btnModalidadeCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModalidadeCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnModalidadeCadastro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModalidadeCadastro.BackgroundImage")));
            this.btnModalidadeCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModalidadeCadastro.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnModalidadeCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModalidadeCadastro.Location = new System.Drawing.Point(226, 557);
            this.btnModalidadeCadastro.Name = "btnModalidadeCadastro";
            this.btnModalidadeCadastro.Size = new System.Drawing.Size(55, 52);
            this.btnModalidadeCadastro.TabIndex = 68;
            this.btnModalidadeCadastro.UseVisualStyleBackColor = false;
            this.btnModalidadeCadastro.MouseLeave += new System.EventHandler(this.btnModalidadeCadastroDesapareceText);
            this.btnModalidadeCadastro.MouseHover += new System.EventHandler(this.btnModalidadeCadastroApareceText);
            // 
            // MsgErrorTipoUsuario
            // 
            this.MsgErrorTipoUsuario.AutoSize = true;
            this.MsgErrorTipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.MsgErrorTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgErrorTipoUsuario.ForeColor = System.Drawing.Color.Maroon;
            this.MsgErrorTipoUsuario.Location = new System.Drawing.Point(96, 537);
            this.MsgErrorTipoUsuario.Name = "MsgErrorTipoUsuario";
            this.MsgErrorTipoUsuario.Size = new System.Drawing.Size(0, 16);
            this.MsgErrorTipoUsuario.TabIndex = 63;
            // 
            // comboBoxTipoUsuario
            // 
            this.comboBoxTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoUsuario.FormattingEnabled = true;
            this.comboBoxTipoUsuario.Location = new System.Drawing.Point(99, 501);
            this.comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            this.comboBoxTipoUsuario.Size = new System.Drawing.Size(432, 33);
            this.comboBoxTipoUsuario.TabIndex = 62;
            // 
            // MsgErrorSenha
            // 
            this.MsgErrorSenha.AutoSize = true;
            this.MsgErrorSenha.BackColor = System.Drawing.Color.Transparent;
            this.MsgErrorSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgErrorSenha.ForeColor = System.Drawing.Color.Maroon;
            this.MsgErrorSenha.Location = new System.Drawing.Point(886, 365);
            this.MsgErrorSenha.Name = "MsgErrorSenha";
            this.MsgErrorSenha.Size = new System.Drawing.Size(0, 16);
            this.MsgErrorSenha.TabIndex = 61;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastro.BackgroundImage")));
            this.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastro.Location = new System.Drawing.Point(992, 486);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(161, 67);
            this.btnCadastro.TabIndex = 60;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            this.btnCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.btnCadastro_Paint);
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCadastro.Location = new System.Drawing.Point(831, 282);
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.PasswordChar = '*';
            this.txtSenhaCadastro.Size = new System.Drawing.Size(426, 35);
            this.txtSenhaCadastro.TabIndex = 57;
            // 
            // textSenhaConfirmada
            // 
            this.textSenhaConfirmada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSenhaConfirmada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenhaConfirmada.Location = new System.Drawing.Point(831, 425);
            this.textSenhaConfirmada.Name = "textSenhaConfirmada";
            this.textSenhaConfirmada.PasswordChar = '*';
            this.textSenhaConfirmada.Size = new System.Drawing.Size(426, 35);
            this.textSenhaConfirmada.TabIndex = 59;
            // 
            // textNomeCadastro
            // 
            this.textNomeCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeCadastro.Location = new System.Drawing.Point(99, 321);
            this.textNomeCadastro.MaxLength = 50;
            this.textNomeCadastro.Name = "textNomeCadastro";
            this.textNomeCadastro.Size = new System.Drawing.Size(432, 35);
            this.textNomeCadastro.TabIndex = 58;
            // 
            // txtUsuarioCadastro
            // 
            this.txtUsuarioCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioCadastro.Location = new System.Drawing.Point(99, 230);
            this.txtUsuarioCadastro.MaxLength = 11;
            this.txtUsuarioCadastro.Name = "txtUsuarioCadastro";
            this.txtUsuarioCadastro.Size = new System.Drawing.Size(432, 35);
            this.txtUsuarioCadastro.TabIndex = 56;
            this.txtUsuarioCadastro.TextChanged += new System.EventHandler(this.txtUsuarioCadastro_TextChanged);
            // 
            // TelaCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelMsgErroModalidade);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.comboBoxModalidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaCadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "               ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaCadastroForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxModalidade;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label labelMsgErroModalidade;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSenhaCadastro;
        private System.Windows.Forms.TextBox textSenhaConfirmada;
        private System.Windows.Forms.TextBox textNomeCadastro;
        private System.Windows.Forms.TextBox txtUsuarioCadastro;
        private System.Windows.Forms.Label MsgErrorSenha;
        private System.Windows.Forms.Panel btnCadastro;
        private System.Windows.Forms.Button msgTemporariaUsuario;
        private System.Windows.Forms.Button btnModalidadeCadastro;
        private System.Windows.Forms.Label MsgErrorTipoUsuario;
        private System.Windows.Forms.ComboBox comboBoxTipoUsuario;
        private System.Windows.Forms.ComboBox comboBoxModalidade1;
        private System.Windows.Forms.Label TxTExplicacaoModalidade;
        private System.Windows.Forms.Label MsgExplicacaoUsuario;
        private System.Windows.Forms.Label MsgErrorSenha1;
        private System.Windows.Forms.Label labelMsgErroModalidade1;
        private System.Windows.Forms.Label MsgExplicacaoUsuario1;
        private System.Windows.Forms.Label MsgExplicacaoModalidade1;
        private System.Windows.Forms.Label labelMsgErroCpf1;
        private System.Windows.Forms.PictureBox pictureBoxVoltar;
    }
}