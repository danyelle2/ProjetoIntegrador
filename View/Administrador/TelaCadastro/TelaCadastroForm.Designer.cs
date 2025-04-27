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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxModalidade1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxModalidade1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "cpf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Nome";
            // 
            // comboBoxModalidade1
            // 
            this.comboBoxModalidade1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxModalidade1.FormattingEnabled = true;
            this.comboBoxModalidade1.Items.AddRange(new object[] {
            "Administrador",
            "Usuário Padrão"});
            this.comboBoxModalidade1.Location = new System.Drawing.Point(12, 661);
            this.comboBoxModalidade1.Name = "comboBoxModalidade1";
            this.comboBoxModalidade1.Size = new System.Drawing.Size(530, 33);
            this.comboBoxModalidade1.TabIndex = 73;
            this.comboBoxModalidade1.SelectedIndexChanged += new System.EventHandler(this.comboBoxModalidade1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(693, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(693, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 71;
            // 
            // TxTExplicacaoModalidade
            // 
            this.TxTExplicacaoModalidade.AutoSize = true;
            this.TxTExplicacaoModalidade.BackColor = System.Drawing.Color.Transparent;
            this.TxTExplicacaoModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTExplicacaoModalidade.ForeColor = System.Drawing.Color.Black;
            this.TxTExplicacaoModalidade.Location = new System.Drawing.Point(685, 446);
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
            this.msgTemporariaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.msgTemporariaUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.msgTemporariaUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msgTemporariaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.msgTemporariaUsuario.Location = new System.Drawing.Point(442, 365);
            this.msgTemporariaUsuario.Name = "msgTemporariaUsuario";
            this.msgTemporariaUsuario.Size = new System.Drawing.Size(75, 62);
            this.msgTemporariaUsuario.TabIndex = 67;
            this.msgTemporariaUsuario.UseVisualStyleBackColor = false;
            // 
            // btnModalidadeCadastro
            // 
            this.btnModalidadeCadastro.BackColor = System.Drawing.Color.Transparent;
            this.btnModalidadeCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModalidadeCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModalidadeCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModalidadeCadastro.Location = new System.Drawing.Point(442, 530);
            this.btnModalidadeCadastro.Name = "btnModalidadeCadastro";
            this.btnModalidadeCadastro.Size = new System.Drawing.Size(75, 61);
            this.btnModalidadeCadastro.TabIndex = 68;
            this.btnModalidadeCadastro.UseVisualStyleBackColor = false;
            // 
            // MsgErrorTipoUsuario
            // 
            this.MsgErrorTipoUsuario.AutoSize = true;
            this.MsgErrorTipoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.MsgErrorTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgErrorTipoUsuario.ForeColor = System.Drawing.Color.Maroon;
            this.MsgErrorTipoUsuario.Location = new System.Drawing.Point(387, 365);
            this.MsgErrorTipoUsuario.Name = "MsgErrorTipoUsuario";
            this.MsgErrorTipoUsuario.Size = new System.Drawing.Size(16, 16);
            this.MsgErrorTipoUsuario.TabIndex = 63;
            this.MsgErrorTipoUsuario.Text = "...";
            // 
            // comboBoxTipoUsuario
            // 
            this.comboBoxTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoUsuario.FormattingEnabled = true;
            this.comboBoxTipoUsuario.Location = new System.Drawing.Point(3, 454);
            this.comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            this.comboBoxTipoUsuario.Size = new System.Drawing.Size(530, 33);
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
            this.btnCadastro.BackColor = System.Drawing.Color.Black;
            this.btnCadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastro.Location = new System.Drawing.Point(643, 628);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(243, 77);
            this.btnCadastro.TabIndex = 60;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenhaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaCadastro.Location = new System.Drawing.Point(866, 121);
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.PasswordChar = '*';
            this.txtSenhaCadastro.Size = new System.Drawing.Size(532, 35);
            this.txtSenhaCadastro.TabIndex = 57;
            // 
            // textSenhaConfirmada
            // 
            this.textSenhaConfirmada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSenhaConfirmada.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSenhaConfirmada.Location = new System.Drawing.Point(889, 327);
            this.textSenhaConfirmada.Name = "textSenhaConfirmada";
            this.textSenhaConfirmada.PasswordChar = '*';
            this.textSenhaConfirmada.Size = new System.Drawing.Size(532, 35);
            this.textSenhaConfirmada.TabIndex = 59;
            // 
            // textNomeCadastro
            // 
            this.textNomeCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNomeCadastro.Location = new System.Drawing.Point(3, 121);
            this.textNomeCadastro.MaxLength = 11;
            this.textNomeCadastro.Name = "textNomeCadastro";
            this.textNomeCadastro.Size = new System.Drawing.Size(530, 35);
            this.textNomeCadastro.TabIndex = 58;
            // 
            // txtUsuarioCadastro
            // 
            this.txtUsuarioCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioCadastro.Location = new System.Drawing.Point(3, 314);
            this.txtUsuarioCadastro.MaxLength = 11;
            this.txtUsuarioCadastro.Name = "txtUsuarioCadastro";
            this.txtUsuarioCadastro.Size = new System.Drawing.Size(530, 35);
            this.txtUsuarioCadastro.TabIndex = 56;
            // 
            // TelaCadastroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelMsgErroModalidade);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.comboBoxModalidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TelaCadastroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "               ";
            this.Load += new System.EventHandler(this.TelaCadastroForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TxTExplicacaoModalidade;
        private System.Windows.Forms.Label MsgExplicacaoUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}