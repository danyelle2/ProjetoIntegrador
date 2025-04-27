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
            this.MsgErrorTipoUsuario = new System.Windows.Forms.Label();
            this.comboBoxModalidade = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.msgTemporariaUsuario = new System.Windows.Forms.Button();
            this.MsgExplicacaoUsuario = new System.Windows.Forms.Label();
            this.TxTExplicacaoModalidade = new System.Windows.Forms.Label();
            this.btnModalidadeCadastro = new System.Windows.Forms.Button();
            this.MsgErrorSenha = new System.Windows.Forms.Label();
            this.txtSenhaCadastro = new System.Windows.Forms.TextBox();
            this.textSenhaConfirmada = new System.Windows.Forms.TextBox();
            this.textNomeCadastro = new System.Windows.Forms.TextBox();
            this.txtUsuarioCadastro = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
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
            // MsgErrorTipoUsuario
            // 
            this.MsgErrorTipoUsuario.AutoSize = true;
            this.MsgErrorTipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.MsgErrorTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgErrorTipoUsuario.ForeColor = System.Drawing.Color.Maroon;
            this.MsgErrorTipoUsuario.Location = new System.Drawing.Point(184, 828);
            this.MsgErrorTipoUsuario.Name = "MsgErrorTipoUsuario";
            this.MsgErrorTipoUsuario.Size = new System.Drawing.Size(16, 16);
            this.MsgErrorTipoUsuario.TabIndex = 57;
            this.MsgErrorTipoUsuario.Text = "...";
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
            // comboBoxTipoUsuario
            // 
            this.comboBoxTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoUsuario.FormattingEnabled = true;
            this.comboBoxTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Usuário Padrão"});
            this.comboBoxTipoUsuario.Location = new System.Drawing.Point(187, 773);
            this.comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            this.comboBoxTipoUsuario.Size = new System.Drawing.Size(530, 33);
            this.comboBoxTipoUsuario.TabIndex = 61;
            this.comboBoxTipoUsuario.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoUsuario_SelectedIndexChanged);
            // 
            // msgTemporariaUsuario
            // 
            this.msgTemporariaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.msgTemporariaUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.msgTemporariaUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msgTemporariaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.msgTemporariaUsuario.Location = new System.Drawing.Point(595, 678);
            this.msgTemporariaUsuario.Name = "msgTemporariaUsuario";
            this.msgTemporariaUsuario.Size = new System.Drawing.Size(75, 62);
            this.msgTemporariaUsuario.TabIndex = 64;
            this.msgTemporariaUsuario.UseVisualStyleBackColor = false;
            this.msgTemporariaUsuario.Click += new System.EventHandler(this.msgTemporariaUsuario_Click);
            this.msgTemporariaUsuario.MouseLeave += new System.EventHandler(this.msgTemporariaUsuarioDesaparece);
            this.msgTemporariaUsuario.MouseHover += new System.EventHandler(this.msgTemporariaUsuarioAparece);
            // 
            // MsgExplicacaoUsuario
            // 
            this.MsgExplicacaoUsuario.AutoSize = true;
            this.MsgExplicacaoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.MsgExplicacaoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgExplicacaoUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MsgExplicacaoUsuario.Location = new System.Drawing.Point(676, 701);
            this.MsgExplicacaoUsuario.Name = "MsgExplicacaoUsuario";
            this.MsgExplicacaoUsuario.Size = new System.Drawing.Size(0, 20);
            this.MsgExplicacaoUsuario.TabIndex = 65;
            // 
            // TxTExplicacaoModalidade
            // 
            this.TxTExplicacaoModalidade.AutoSize = true;
            this.TxTExplicacaoModalidade.BackColor = System.Drawing.Color.Transparent;
            this.TxTExplicacaoModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTExplicacaoModalidade.ForeColor = System.Drawing.Color.Black;
            this.TxTExplicacaoModalidade.Location = new System.Drawing.Point(676, 865);
            this.TxTExplicacaoModalidade.Name = "TxTExplicacaoModalidade";
            this.TxTExplicacaoModalidade.Size = new System.Drawing.Size(0, 20);
            this.TxTExplicacaoModalidade.TabIndex = 67;
            // 
            // btnModalidadeCadastro
            // 
            this.btnModalidadeCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnModalidadeCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModalidadeCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModalidadeCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModalidadeCadastro.Location = new System.Drawing.Point(595, 843);
            this.btnModalidadeCadastro.Name = "btnModalidadeCadastro";
            this.btnModalidadeCadastro.Size = new System.Drawing.Size(75, 61);
            this.btnModalidadeCadastro.TabIndex = 66;
            this.btnModalidadeCadastro.UseVisualStyleBackColor = false;
            this.btnModalidadeCadastro.MouseLeave += new System.EventHandler(this.btnModalidadeCadastroDesapareceText);
            this.btnModalidadeCadastro.MouseHover += new System.EventHandler(this.btnModalidadeCadastroApareceText);
            // 
            // MsgErrorSenha
            // 
            this.MsgErrorSenha.AutoSize = true;
            this.MsgErrorSenha.BackColor = System.Drawing.Color.Transparent;
            this.MsgErrorSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgErrorSenha.ForeColor = System.Drawing.Color.Maroon;
            this.MsgErrorSenha.Location = new System.Drawing.Point(1142, 634);
            this.MsgErrorSenha.Name = "MsgErrorSenha";
            this.MsgErrorSenha.Size = new System.Drawing.Size(0, 16);
            this.MsgErrorSenha.TabIndex = 56;
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCadastro.Location = new System.Drawing.Point(1145, 263);
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.PasswordChar = '*';
            this.txtSenhaCadastro.Size = new System.Drawing.Size(532, 35);
            this.txtSenhaCadastro.TabIndex = 49;
            this.txtSenhaCadastro.TextChanged += new System.EventHandler(this.txtSenhaCadastro_TextChanged);
            // 
            // textSenhaConfirmada
            // 
            this.textSenhaConfirmada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSenhaConfirmada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenhaConfirmada.Location = new System.Drawing.Point(1145, 429);
            this.textSenhaConfirmada.Name = "textSenhaConfirmada";
            this.textSenhaConfirmada.PasswordChar = '*';
            this.textSenhaConfirmada.Size = new System.Drawing.Size(532, 35);
            this.textSenhaConfirmada.TabIndex = 55;
            // 
            // textNomeCadastro
            // 
            this.textNomeCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeCadastro.Location = new System.Drawing.Point(187, 404);
            this.textNomeCadastro.MaxLength = 11;
            this.textNomeCadastro.Name = "textNomeCadastro";
            this.textNomeCadastro.Size = new System.Drawing.Size(530, 35);
            this.textNomeCadastro.TabIndex = 51;
            this.textNomeCadastro.TextChanged += new System.EventHandler(this.textNomeCadastro_TextChanged);
            // 
            // txtUsuarioCadastro
            // 
            this.txtUsuarioCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioCadastro.Location = new System.Drawing.Point(187, 251);
            this.txtUsuarioCadastro.MaxLength = 11;
            this.txtUsuarioCadastro.Name = "txtUsuarioCadastro";
            this.txtUsuarioCadastro.Size = new System.Drawing.Size(530, 35);
            this.txtUsuarioCadastro.TabIndex = 48;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastro.Location = new System.Drawing.Point(0, 0);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(243, 77);
            this.btnCadastro.TabIndex = 71;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnCadastro);
            this.panel2.Location = new System.Drawing.Point(1289, 739);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 77);
            this.panel2.TabIndex = 0;
            // 
            // TelaCadastroForm
            // 
            this.AcceptButton = this.btnCadastro;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtSenhaCadastro);
            this.Controls.Add(this.textSenhaConfirmada);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MsgErrorSenha);
            this.Controls.Add(this.labelMsgErroModalidade);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.MsgErrorTipoUsuario);
            this.Controls.Add(this.textNomeCadastro);
            this.Controls.Add(this.TxTExplicacaoModalidade);
            this.Controls.Add(this.comboBoxModalidade);
            this.Controls.Add(this.txtUsuarioCadastro);
            this.Controls.Add(this.msgTemporariaUsuario);
            this.Controls.Add(this.btnModalidadeCadastro);
            this.Controls.Add(this.comboBoxTipoUsuario);
            this.Controls.Add(this.MsgExplicacaoUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TelaCadastroForm";
            this.Text = "               ";
            this.Load += new System.EventHandler(this.TelaCadastroForm_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxModalidade;
        private System.Windows.Forms.ComboBox comboBoxTipoUsuario;
        private System.Windows.Forms.Button msgTemporariaUsuario;
        private System.Windows.Forms.Label MsgExplicacaoUsuario;
        private System.Windows.Forms.Label TxTExplicacaoModalidade;
        private System.Windows.Forms.Button btnModalidadeCadastro;
        private System.Windows.Forms.TextBox txtSenhaCadastro;
        private System.Windows.Forms.TextBox textSenhaConfirmada;
        private System.Windows.Forms.TextBox textNomeCadastro;
        private System.Windows.Forms.TextBox txtUsuarioCadastro;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label MsgErrorSenha;
        private System.Windows.Forms.Label MsgErrorTipoUsuario;
        private System.Windows.Forms.Label labelMsgErroModalidade;
        private System.Windows.Forms.Panel panel2;
    }
}