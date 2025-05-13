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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonConfirmarDados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelErrorSenha = new System.Windows.Forms.Label();
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
            this.textBoxCpfUser.Name = "textBoxCpfUser";
            this.textBoxCpfUser.Size = new System.Drawing.Size(232, 26);
            this.textBoxCpfUser.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(479, 186);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(232, 26);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(479, 292);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(232, 26);
            this.textBox4.TabIndex = 3;
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
            this.buttonConfirmarDados.Location = new System.Drawing.Point(591, 378);
            this.buttonConfirmarDados.Name = "buttonConfirmarDados";
            this.buttonConfirmarDados.Size = new System.Drawing.Size(152, 50);
            this.buttonConfirmarDados.TabIndex = 26;
            this.buttonConfirmarDados.UseVisualStyleBackColor = false;
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
            this.label3.Location = new System.Drawing.Point(64, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Digite os dados cadastrados para recuperar a senha.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Senha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(476, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Confirme a Senha";
            // 
            // labelErrorSenha
            // 
            this.labelErrorSenha.AutoSize = true;
            this.labelErrorSenha.ForeColor = System.Drawing.Color.Maroon;
            this.labelErrorSenha.Location = new System.Drawing.Point(476, 321);
            this.labelErrorSenha.Name = "labelErrorSenha";
            this.labelErrorSenha.Size = new System.Drawing.Size(92, 13);
            this.labelErrorSenha.TabIndex = 32;
            this.labelErrorSenha.Text = "Senhas diferentes";
            // 
            // TelaEsqueciSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelErrorSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConfirmarDados);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxCpfUser);
            this.Controls.Add(this.textBoxNomeUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaEsqueciSenha";
            this.Text = "SGA Academy";
            this.Load += new System.EventHandler(this.TelaEsqueciSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomeUser;
        private System.Windows.Forms.TextBox textBoxCpfUser;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonConfirmarDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelErrorSenha;
    }
}