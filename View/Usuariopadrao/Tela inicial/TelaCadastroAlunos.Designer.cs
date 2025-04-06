namespace ProjetoIntegrador.View
{
    partial class TelaCadastroAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroAlunos));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAssinaturaAluno = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.txtTelefoneALuno = new System.Windows.Forms.TextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxCadastroAlunos = new System.Windows.Forms.PictureBox();
            this.textMsgErroIdade = new System.Windows.Forms.Label();
            this.textMsgErroResponsavel = new System.Windows.Forms.Label();
            this.textMsgErroTelefone = new System.Windows.Forms.Label();
            this.textMsgErroData = new System.Windows.Forms.Label();
            this.comboBoxStatusAluno = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadastroAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(428, 318);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 23);
            this.textBox3.TabIndex = 92;
            this.textBox3.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Responsável";
            this.label8.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(235, 318);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 23);
            this.textBox2.TabIndex = 90;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "Idade";
            // 
            // txtAssinaturaAluno
            // 
            this.txtAssinaturaAluno.FormattingEnabled = true;
            this.txtAssinaturaAluno.Items.AddRange(new object[] {
            "Mensal",
            "Anual"});
            this.txtAssinaturaAluno.Location = new System.Drawing.Point(235, 245);
            this.txtAssinaturaAluno.Name = "txtAssinaturaAluno";
            this.txtAssinaturaAluno.Size = new System.Drawing.Size(140, 21);
            this.txtAssinaturaAluno.TabIndex = 88;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 388);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 23);
            this.textBox1.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "Data de entrada";
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Location = new System.Drawing.Point(443, 157);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarAluno.TabIndex = 85;
            this.btnCadastrarAluno.Text = "Cadastrar";
            this.btnCadastrarAluno.UseVisualStyleBackColor = true;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // txtTelefoneALuno
            // 
            this.txtTelefoneALuno.Location = new System.Drawing.Point(235, 157);
            this.txtTelefoneALuno.Multiline = true;
            this.txtTelefoneALuno.Name = "txtTelefoneALuno";
            this.txtTelefoneALuno.Size = new System.Drawing.Size(140, 23);
            this.txtTelefoneALuno.TabIndex = 84;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(235, 56);
            this.txtNomeAluno.Multiline = true;
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(140, 23);
            this.txtNomeAluno.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "Plano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Nome";
            // 
            // pictureBoxCadastroAlunos
            // 
            this.pictureBoxCadastroAlunos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCadastroAlunos.Image")));
            this.pictureBoxCadastroAlunos.Location = new System.Drawing.Point(64, 72);
            this.pictureBoxCadastroAlunos.Name = "pictureBoxCadastroAlunos";
            this.pictureBoxCadastroAlunos.Size = new System.Drawing.Size(100, 108);
            this.pictureBoxCadastroAlunos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCadastroAlunos.TabIndex = 93;
            this.pictureBoxCadastroAlunos.TabStop = false;
            // 
            // textMsgErroIdade
            // 
            this.textMsgErroIdade.AutoSize = true;
            this.textMsgErroIdade.ForeColor = System.Drawing.Color.Red;
            this.textMsgErroIdade.Location = new System.Drawing.Point(235, 347);
            this.textMsgErroIdade.Name = "textMsgErroIdade";
            this.textMsgErroIdade.Size = new System.Drawing.Size(16, 13);
            this.textMsgErroIdade.TabIndex = 95;
            this.textMsgErroIdade.Text = "...";
            // 
            // textMsgErroResponsavel
            // 
            this.textMsgErroResponsavel.AutoSize = true;
            this.textMsgErroResponsavel.ForeColor = System.Drawing.Color.Red;
            this.textMsgErroResponsavel.Location = new System.Drawing.Point(428, 348);
            this.textMsgErroResponsavel.Name = "textMsgErroResponsavel";
            this.textMsgErroResponsavel.Size = new System.Drawing.Size(16, 13);
            this.textMsgErroResponsavel.TabIndex = 96;
            this.textMsgErroResponsavel.Text = "...";
            // 
            // textMsgErroTelefone
            // 
            this.textMsgErroTelefone.AutoSize = true;
            this.textMsgErroTelefone.ForeColor = System.Drawing.Color.Red;
            this.textMsgErroTelefone.Location = new System.Drawing.Point(235, 183);
            this.textMsgErroTelefone.Name = "textMsgErroTelefone";
            this.textMsgErroTelefone.Size = new System.Drawing.Size(16, 13);
            this.textMsgErroTelefone.TabIndex = 97;
            this.textMsgErroTelefone.Text = "...";
            // 
            // textMsgErroData
            // 
            this.textMsgErroData.AutoSize = true;
            this.textMsgErroData.ForeColor = System.Drawing.Color.Red;
            this.textMsgErroData.Location = new System.Drawing.Point(235, 414);
            this.textMsgErroData.Name = "textMsgErroData";
            this.textMsgErroData.Size = new System.Drawing.Size(16, 13);
            this.textMsgErroData.TabIndex = 98;
            this.textMsgErroData.Text = "...";
            // 
            // comboBoxStatusAluno
            // 
            this.comboBoxStatusAluno.FormattingEnabled = true;
            this.comboBoxStatusAluno.Items.AddRange(new object[] {
            "Ativo"});
            this.comboBoxStatusAluno.Location = new System.Drawing.Point(431, 235);
            this.comboBoxStatusAluno.Name = "comboBoxStatusAluno";
            this.comboBoxStatusAluno.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatusAluno.TabIndex = 113;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 112;
            this.label6.Text = "Status do aluno";
            // 
            // TelaCadastroAlunos
            // 
            this.AcceptButton = this.btnCadastrarAluno;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxStatusAluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textMsgErroData);
            this.Controls.Add(this.textMsgErroTelefone);
            this.Controls.Add(this.textMsgErroResponsavel);
            this.Controls.Add(this.textMsgErroIdade);
            this.Controls.Add(this.pictureBoxCadastroAlunos);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAssinaturaAluno);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.txtTelefoneALuno);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastroAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TelaCadastroAlunos";
            this.Load += new System.EventHandler(this.TelaCadastroAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadastroAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtAssinaturaAluno;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.TextBox txtTelefoneALuno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxCadastroAlunos;
        private System.Windows.Forms.Label textMsgErroIdade;
        private System.Windows.Forms.Label textMsgErroResponsavel;
        private System.Windows.Forms.Label textMsgErroTelefone;
        private System.Windows.Forms.Label textMsgErroData;
        private System.Windows.Forms.ComboBox comboBoxStatusAluno;
        private System.Windows.Forms.Label label6;
    }
}