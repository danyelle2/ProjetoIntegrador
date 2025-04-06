namespace ProjetoIntegrador.View
{
    partial class TelaAlterarDadosAlunosForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAlterarDadosAlunosForms));
            this.comboBoxPlano = new System.Windows.Forms.ComboBox();
            this.textBoxDataSaida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxStatusAlunos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDataEntrada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.textBoxTelefoneAluno = new System.Windows.Forms.TextBox();
            this.textBoxNomeAluno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textMsgErroIdade = new System.Windows.Forms.Label();
            this.textBoxIdadeAluno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textMsgErroDataSaida = new System.Windows.Forms.Label();
            this.LabelMsgErroDataEntrada = new System.Windows.Forms.Label();
            this.labelMsgErroResponsavel = new System.Windows.Forms.Label();
            this.textBoxNomeResponsavel = new System.Windows.Forms.TextBox();
            this.labelNomeResponsavel1 = new System.Windows.Forms.Label();
            this.textMsgErroTelefone = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPlano
            // 
            this.comboBoxPlano.FormattingEnabled = true;
            this.comboBoxPlano.Items.AddRange(new object[] {
            "Mensal",
            "Anual"});
            this.comboBoxPlano.Location = new System.Drawing.Point(207, 292);
            this.comboBoxPlano.Name = "comboBoxPlano";
            this.comboBoxPlano.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlano.TabIndex = 114;
            // 
            // textBoxDataSaida
            // 
            this.textBoxDataSaida.Location = new System.Drawing.Point(442, 190);
            this.textBoxDataSaida.Multiline = true;
            this.textBoxDataSaida.Name = "textBoxDataSaida";
            this.textBoxDataSaida.Size = new System.Drawing.Size(140, 23);
            this.textBoxDataSaida.TabIndex = 113;
            this.textBoxDataSaida.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 112;
            this.label7.Text = "Data de saída";
            this.label7.Visible = false;
            // 
            // comboBoxStatusAlunos
            // 
            this.comboBoxStatusAlunos.FormattingEnabled = true;
            this.comboBoxStatusAlunos.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.comboBoxStatusAlunos.Location = new System.Drawing.Point(452, 103);
            this.comboBoxStatusAlunos.Name = "comboBoxStatusAlunos";
            this.comboBoxStatusAlunos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatusAlunos.TabIndex = 111;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 110;
            this.label6.Text = "Status do aluno";
            // 
            // textBoxDataEntrada
            // 
            this.textBoxDataEntrada.Location = new System.Drawing.Point(207, 386);
            this.textBoxDataEntrada.Multiline = true;
            this.textBoxDataEntrada.Name = "textBoxDataEntrada";
            this.textBoxDataEntrada.Size = new System.Drawing.Size(140, 23);
            this.textBoxDataEntrada.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 108;
            this.label5.Text = "Data de entrada";
            // 
            // btnAlterarDados
            // 
            this.btnAlterarDados.Location = new System.Drawing.Point(634, 377);
            this.btnAlterarDados.Name = "btnAlterarDados";
            this.btnAlterarDados.Size = new System.Drawing.Size(119, 32);
            this.btnAlterarDados.TabIndex = 107;
            this.btnAlterarDados.Text = "Alterar";
            this.btnAlterarDados.UseVisualStyleBackColor = true;
            this.btnAlterarDados.Click += new System.EventHandler(this.btnAlterarDados_Click);
            // 
            // textBoxTelefoneAluno
            // 
            this.textBoxTelefoneAluno.Location = new System.Drawing.Point(207, 190);
            this.textBoxTelefoneAluno.Multiline = true;
            this.textBoxTelefoneAluno.Name = "textBoxTelefoneAluno";
            this.textBoxTelefoneAluno.Size = new System.Drawing.Size(140, 23);
            this.textBoxTelefoneAluno.TabIndex = 106;
            // 
            // textBoxNomeAluno
            // 
            this.textBoxNomeAluno.Location = new System.Drawing.Point(207, 89);
            this.textBoxNomeAluno.Multiline = true;
            this.textBoxNomeAluno.Name = "textBoxNomeAluno";
            this.textBoxNomeAluno.Size = new System.Drawing.Size(140, 23);
            this.textBoxNomeAluno.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "Plano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Nome";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 115;
            this.pictureBox1.TabStop = false;
            // 
            // textMsgErroIdade
            // 
            this.textMsgErroIdade.AutoSize = true;
            this.textMsgErroIdade.ForeColor = System.Drawing.Color.Red;
            this.textMsgErroIdade.Location = new System.Drawing.Point(442, 296);
            this.textMsgErroIdade.Name = "textMsgErroIdade";
            this.textMsgErroIdade.Size = new System.Drawing.Size(16, 13);
            this.textMsgErroIdade.TabIndex = 119;
            this.textMsgErroIdade.Text = "...";
            // 
            // textBoxIdadeAluno
            // 
            this.textBoxIdadeAluno.Location = new System.Drawing.Point(442, 267);
            this.textBoxIdadeAluno.Multiline = true;
            this.textBoxIdadeAluno.Name = "textBoxIdadeAluno";
            this.textBoxIdadeAluno.Size = new System.Drawing.Size(140, 23);
            this.textBoxIdadeAluno.TabIndex = 118;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 117;
            this.label8.Text = "Idade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 116;
            // 
            // textMsgErroDataSaida
            // 
            this.textMsgErroDataSaida.AutoSize = true;
            this.textMsgErroDataSaida.ForeColor = System.Drawing.Color.Red;
            this.textMsgErroDataSaida.Location = new System.Drawing.Point(442, 216);
            this.textMsgErroDataSaida.Name = "textMsgErroDataSaida";
            this.textMsgErroDataSaida.Size = new System.Drawing.Size(16, 13);
            this.textMsgErroDataSaida.TabIndex = 120;
            this.textMsgErroDataSaida.Text = "...";
            // 
            // LabelMsgErroDataEntrada
            // 
            this.LabelMsgErroDataEntrada.AutoSize = true;
            this.LabelMsgErroDataEntrada.ForeColor = System.Drawing.Color.Red;
            this.LabelMsgErroDataEntrada.Location = new System.Drawing.Point(204, 412);
            this.LabelMsgErroDataEntrada.Name = "LabelMsgErroDataEntrada";
            this.LabelMsgErroDataEntrada.Size = new System.Drawing.Size(16, 13);
            this.LabelMsgErroDataEntrada.TabIndex = 121;
            this.LabelMsgErroDataEntrada.Text = "...";
            // 
            // labelMsgErroResponsavel
            // 
            this.labelMsgErroResponsavel.AutoSize = true;
            this.labelMsgErroResponsavel.ForeColor = System.Drawing.Color.Red;
            this.labelMsgErroResponsavel.Location = new System.Drawing.Point(442, 378);
            this.labelMsgErroResponsavel.Name = "labelMsgErroResponsavel";
            this.labelMsgErroResponsavel.Size = new System.Drawing.Size(16, 13);
            this.labelMsgErroResponsavel.TabIndex = 124;
            this.labelMsgErroResponsavel.Text = "...";
            // 
            // textBoxNomeResponsavel
            // 
            this.textBoxNomeResponsavel.Location = new System.Drawing.Point(442, 348);
            this.textBoxNomeResponsavel.Multiline = true;
            this.textBoxNomeResponsavel.Name = "textBoxNomeResponsavel";
            this.textBoxNomeResponsavel.Size = new System.Drawing.Size(140, 23);
            this.textBoxNomeResponsavel.TabIndex = 123;
            this.textBoxNomeResponsavel.Visible = false;
            // 
            // labelNomeResponsavel1
            // 
            this.labelNomeResponsavel1.AutoSize = true;
            this.labelNomeResponsavel1.Location = new System.Drawing.Point(468, 319);
            this.labelNomeResponsavel1.Name = "labelNomeResponsavel1";
            this.labelNomeResponsavel1.Size = new System.Drawing.Size(69, 13);
            this.labelNomeResponsavel1.TabIndex = 122;
            this.labelNomeResponsavel1.Text = "Responsável";
            this.labelNomeResponsavel1.Visible = false;
            // 
            // textMsgErroTelefone
            // 
            this.textMsgErroTelefone.AutoSize = true;
            this.textMsgErroTelefone.ForeColor = System.Drawing.Color.Red;
            this.textMsgErroTelefone.Location = new System.Drawing.Point(204, 216);
            this.textMsgErroTelefone.Name = "textMsgErroTelefone";
            this.textMsgErroTelefone.Size = new System.Drawing.Size(16, 13);
            this.textMsgErroTelefone.TabIndex = 125;
            this.textMsgErroTelefone.Text = "...";
            // 
            // TelaAlterarDadosAlunosForms
            // 
            this.AcceptButton = this.btnAlterarDados;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textMsgErroTelefone);
            this.Controls.Add(this.labelMsgErroResponsavel);
            this.Controls.Add(this.textBoxNomeResponsavel);
            this.Controls.Add(this.labelNomeResponsavel1);
            this.Controls.Add(this.LabelMsgErroDataEntrada);
            this.Controls.Add(this.textMsgErroDataSaida);
            this.Controls.Add(this.textMsgErroIdade);
            this.Controls.Add(this.textBoxIdadeAluno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxPlano);
            this.Controls.Add(this.textBoxDataSaida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxStatusAlunos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDataEntrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAlterarDados);
            this.Controls.Add(this.textBoxTelefoneAluno);
            this.Controls.Add(this.textBoxNomeAluno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaAlterarDadosAlunosForms";
            this.Text = "TelaAlterarDadosAlunosForms";
            this.Load += new System.EventHandler(this.TelaAlterarDadosAlunosForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPlano;
        private System.Windows.Forms.TextBox textBoxDataSaida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxStatusAlunos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDataEntrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.TextBox textBoxTelefoneAluno;
        private System.Windows.Forms.TextBox textBoxNomeAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label textMsgErroIdade;
        private System.Windows.Forms.TextBox textBoxIdadeAluno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label textMsgErroDataSaida;
        private System.Windows.Forms.Label LabelMsgErroDataEntrada;
        private System.Windows.Forms.Label labelMsgErroResponsavel;
        private System.Windows.Forms.TextBox textBoxNomeResponsavel;
        private System.Windows.Forms.Label labelNomeResponsavel1;
        private System.Windows.Forms.Label textMsgErroTelefone;
    }
}