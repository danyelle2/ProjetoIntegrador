namespace ProjetoIntegrador.View.EsquecerSenha
{
    partial class TelaEsqueciSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEsqueciSenha));
            this.textBoxNomeUser = new System.Windows.Forms.TextBox();
            this.textBoxCpfUser = new System.Windows.Forms.TextBox();
            this.textBox3Senha = new System.Windows.Forms.TextBox();
            this.buttonConfirmarDados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNomeUser
            // 
            this.textBoxNomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeUser.Location = new System.Drawing.Point(54, 186);
            this.textBoxNomeUser.Name = "textBoxNomeUser";
            this.textBoxNomeUser.Size = new System.Drawing.Size(232, 26);
            this.textBoxNomeUser.TabIndex = 0;
            // 
            // textBoxCpfUser
            // 
            this.textBoxCpfUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCpfUser.Location = new System.Drawing.Point(54, 292);
            this.textBoxCpfUser.MaxLength = 11;
            this.textBoxCpfUser.Name = "textBoxCpfUser";
            this.textBoxCpfUser.Size = new System.Drawing.Size(232, 26);
            this.textBoxCpfUser.TabIndex = 1;
            // 
            // textBox3Senha
            // 
            this.textBox3Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3Senha.Location = new System.Drawing.Point(404, 186);
            this.textBox3Senha.Name = "textBox3Senha";
            this.textBox3Senha.Size = new System.Drawing.Size(232, 26);
            this.textBox3Senha.TabIndex = 2;
            // 
            // buttonConfirmarDados
            // 
            this.buttonConfirmarDados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConfirmarDados.BackColor = System.Drawing.Color.Transparent;
            this.buttonConfirmarDados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConfirmarDados.BackgroundImage")));
            this.buttonConfirmarDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonConfirmarDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConfirmarDados.FlatAppearance.BorderSize = 0;
            this.buttonConfirmarDados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonConfirmarDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonConfirmarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmarDados.ForeColor = System.Drawing.Color.Black;
            this.buttonConfirmarDados.Location = new System.Drawing.Point(475, 323);
            this.buttonConfirmarDados.Name = "buttonConfirmarDados";
            this.buttonConfirmarDados.Size = new System.Drawing.Size(152, 50);
            this.buttonConfirmarDados.TabIndex = 26;
            this.buttonConfirmarDados.UseVisualStyleBackColor = false;
            this.buttonConfirmarDados.Click += new System.EventHandler(this.buttonConfirmarDados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "CPF ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 36);
            this.label3.TabIndex = 29;
            this.label3.Text = "Digite os dados exatamente como foram cadastrados para\r\n recuperar a senha.\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nova Senha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(590, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // TelaEsqueciSenha
            // 
            this.AcceptButton = this.buttonConfirmarDados;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(674, 399);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConfirmarDados);
            this.Controls.Add(this.textBox3Senha);
            this.Controls.Add(this.textBoxCpfUser);
            this.Controls.Add(this.textBoxNomeUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaEsqueciSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGA Academy";
            this.Load += new System.EventHandler(this.TelaEsqueciSenha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomeUser;
        private System.Windows.Forms.TextBox textBoxCpfUser;
        private System.Windows.Forms.TextBox textBox3Senha;
        private System.Windows.Forms.Button buttonConfirmarDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}