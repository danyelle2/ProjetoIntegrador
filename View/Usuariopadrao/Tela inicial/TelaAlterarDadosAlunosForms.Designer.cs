﻿namespace ProjetoIntegrador.View
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
            this.comboBoxStatusAlunos = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.textBoxTelefoneAluno = new System.Windows.Forms.TextBox();
            this.textBoxNomeAluno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textMsgErroIdade = new System.Windows.Forms.Label();
            this.textBoxIdadeAluno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LabelMsgErroDataEntrada = new System.Windows.Forms.Label();
            this.labelMsgErroResponsavel = new System.Windows.Forms.Label();
            this.textBoxNomeResponsavel = new System.Windows.Forms.TextBox();
            this.labelNomeResponsavel1 = new System.Windows.Forms.Label();
            this.textMsgErroTelefone = new System.Windows.Forms.Label();
            this.labelMsgErroPlano = new System.Windows.Forms.Label();
            this.labelMsgErroStatusAluno = new System.Windows.Forms.Label();
            this.textMsgErroDataSaida = new System.Windows.Forms.Label();
            this.LabelNomeDataSaida = new System.Windows.Forms.Label();
            this.textBoxDataSaida = new System.Windows.Forms.MaskedTextBox();
            this.textBoxDataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // comboBoxPlano
            // 
            this.comboBoxPlano.FormattingEnabled = true;
            this.comboBoxPlano.Items.AddRange(new object[] {
            "Mensal",
            "Anual"});
            this.comboBoxPlano.Location = new System.Drawing.Point(223, 284);
            this.comboBoxPlano.Name = "comboBoxPlano";
            this.comboBoxPlano.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPlano.TabIndex = 114;
            // 
            // comboBoxStatusAlunos
            // 
            this.comboBoxStatusAlunos.FormattingEnabled = true;
            this.comboBoxStatusAlunos.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.comboBoxStatusAlunos.Location = new System.Drawing.Point(457, 106);
            this.comboBoxStatusAlunos.Name = "comboBoxStatusAlunos";
            this.comboBoxStatusAlunos.Size = new System.Drawing.Size(125, 21);
            this.comboBoxStatusAlunos.TabIndex = 111;
            this.comboBoxStatusAlunos.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatusAlunos_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(453, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 24);
            this.label6.TabIndex = 110;
            this.label6.Text = "Status do aluno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 24);
            this.label5.TabIndex = 108;
            this.label5.Text = "Data de entrada";
            // 
            // btnAlterarDados
            // 
            this.btnAlterarDados.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterarDados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlterarDados.BackgroundImage")));
            this.btnAlterarDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlterarDados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAlterarDados.FlatAppearance.BorderSize = 0;
            this.btnAlterarDados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAlterarDados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAlterarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAlterarDados.ForeColor = System.Drawing.Color.Transparent;
            this.btnAlterarDados.Location = new System.Drawing.Point(577, 491);
            this.btnAlterarDados.Name = "btnAlterarDados";
            this.btnAlterarDados.Size = new System.Drawing.Size(121, 51);
            this.btnAlterarDados.TabIndex = 107;
            this.btnAlterarDados.UseVisualStyleBackColor = false;
            this.btnAlterarDados.Click += new System.EventHandler(this.btnAlterarDados_Click);
            // 
            // textBoxTelefoneAluno
            // 
            this.textBoxTelefoneAluno.Location = new System.Drawing.Point(222, 190);
            this.textBoxTelefoneAluno.Multiline = true;
            this.textBoxTelefoneAluno.Name = "textBoxTelefoneAluno";
            this.textBoxTelefoneAluno.Size = new System.Drawing.Size(140, 23);
            this.textBoxTelefoneAluno.TabIndex = 106;
            // 
            // textBoxNomeAluno
            // 
            this.textBoxNomeAluno.Location = new System.Drawing.Point(222, 106);
            this.textBoxNomeAluno.Multiline = true;
            this.textBoxNomeAluno.Name = "textBoxNomeAluno";
            this.textBoxNomeAluno.Size = new System.Drawing.Size(140, 23);
            this.textBoxNomeAluno.TabIndex = 105;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 103;
            this.label3.Text = "Plano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 102;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(219, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 101;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textMsgErroIdade
            // 
            this.textMsgErroIdade.AutoSize = true;
            this.textMsgErroIdade.BackColor = System.Drawing.Color.Transparent;
            this.textMsgErroIdade.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textMsgErroIdade.ForeColor = System.Drawing.Color.Maroon;
            this.textMsgErroIdade.Location = new System.Drawing.Point(498, 221);
            this.textMsgErroIdade.Name = "textMsgErroIdade";
            this.textMsgErroIdade.Size = new System.Drawing.Size(0, 16);
            this.textMsgErroIdade.TabIndex = 119;
            // 
            // textBoxIdadeAluno
            // 
            this.textBoxIdadeAluno.Location = new System.Drawing.Point(460, 190);
            this.textBoxIdadeAluno.Multiline = true;
            this.textBoxIdadeAluno.Name = "textBoxIdadeAluno";
            this.textBoxIdadeAluno.Size = new System.Drawing.Size(140, 23);
            this.textBoxIdadeAluno.TabIndex = 118;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(456, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 117;
            this.label8.Text = "Idade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 116;
            // 
            // LabelMsgErroDataEntrada
            // 
            this.LabelMsgErroDataEntrada.AutoSize = true;
            this.LabelMsgErroDataEntrada.BackColor = System.Drawing.Color.Transparent;
            this.LabelMsgErroDataEntrada.Font = new System.Drawing.Font("Arial", 9.75F);
            this.LabelMsgErroDataEntrada.ForeColor = System.Drawing.Color.Maroon;
            this.LabelMsgErroDataEntrada.Location = new System.Drawing.Point(220, 413);
            this.LabelMsgErroDataEntrada.Name = "LabelMsgErroDataEntrada";
            this.LabelMsgErroDataEntrada.Size = new System.Drawing.Size(0, 16);
            this.LabelMsgErroDataEntrada.TabIndex = 121;
            // 
            // labelMsgErroResponsavel
            // 
            this.labelMsgErroResponsavel.AutoSize = true;
            this.labelMsgErroResponsavel.BackColor = System.Drawing.Color.Transparent;
            this.labelMsgErroResponsavel.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelMsgErroResponsavel.ForeColor = System.Drawing.Color.Maroon;
            this.labelMsgErroResponsavel.Location = new System.Drawing.Point(457, 413);
            this.labelMsgErroResponsavel.Name = "labelMsgErroResponsavel";
            this.labelMsgErroResponsavel.Size = new System.Drawing.Size(0, 16);
            this.labelMsgErroResponsavel.TabIndex = 124;
            // 
            // textBoxNomeResponsavel
            // 
            this.textBoxNomeResponsavel.Location = new System.Drawing.Point(457, 385);
            this.textBoxNomeResponsavel.Multiline = true;
            this.textBoxNomeResponsavel.Name = "textBoxNomeResponsavel";
            this.textBoxNomeResponsavel.Size = new System.Drawing.Size(140, 23);
            this.textBoxNomeResponsavel.TabIndex = 123;
            this.textBoxNomeResponsavel.Visible = false;
            // 
            // labelNomeResponsavel1
            // 
            this.labelNomeResponsavel1.AutoSize = true;
            this.labelNomeResponsavel1.BackColor = System.Drawing.Color.Transparent;
            this.labelNomeResponsavel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeResponsavel1.Location = new System.Drawing.Point(453, 344);
            this.labelNomeResponsavel1.Name = "labelNomeResponsavel1";
            this.labelNomeResponsavel1.Size = new System.Drawing.Size(130, 24);
            this.labelNomeResponsavel1.TabIndex = 122;
            this.labelNomeResponsavel1.Text = "Responsável";
            this.labelNomeResponsavel1.Visible = false;
            // 
            // textMsgErroTelefone
            // 
            this.textMsgErroTelefone.AutoSize = true;
            this.textMsgErroTelefone.BackColor = System.Drawing.Color.Transparent;
            this.textMsgErroTelefone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMsgErroTelefone.ForeColor = System.Drawing.Color.Maroon;
            this.textMsgErroTelefone.Location = new System.Drawing.Point(219, 216);
            this.textMsgErroTelefone.Name = "textMsgErroTelefone";
            this.textMsgErroTelefone.Size = new System.Drawing.Size(0, 16);
            this.textMsgErroTelefone.TabIndex = 125;
            this.textMsgErroTelefone.Click += new System.EventHandler(this.textMsgErroTelefone_Click);
            // 
            // labelMsgErroPlano
            // 
            this.labelMsgErroPlano.AutoSize = true;
            this.labelMsgErroPlano.BackColor = System.Drawing.Color.Transparent;
            this.labelMsgErroPlano.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelMsgErroPlano.ForeColor = System.Drawing.Color.Maroon;
            this.labelMsgErroPlano.Location = new System.Drawing.Point(220, 308);
            this.labelMsgErroPlano.Name = "labelMsgErroPlano";
            this.labelMsgErroPlano.Size = new System.Drawing.Size(0, 16);
            this.labelMsgErroPlano.TabIndex = 126;
            // 
            // labelMsgErroStatusAluno
            // 
            this.labelMsgErroStatusAluno.AutoSize = true;
            this.labelMsgErroStatusAluno.BackColor = System.Drawing.Color.Transparent;
            this.labelMsgErroStatusAluno.Font = new System.Drawing.Font("Arial", 9.75F);
            this.labelMsgErroStatusAluno.ForeColor = System.Drawing.Color.Maroon;
            this.labelMsgErroStatusAluno.Location = new System.Drawing.Point(457, 132);
            this.labelMsgErroStatusAluno.Name = "labelMsgErroStatusAluno";
            this.labelMsgErroStatusAluno.Size = new System.Drawing.Size(0, 16);
            this.labelMsgErroStatusAluno.TabIndex = 127;
            // 
            // textMsgErroDataSaida
            // 
            this.textMsgErroDataSaida.AutoSize = true;
            this.textMsgErroDataSaida.BackColor = System.Drawing.Color.Transparent;
            this.textMsgErroDataSaida.Font = new System.Drawing.Font("Arial", 9.75F);
            this.textMsgErroDataSaida.ForeColor = System.Drawing.Color.Maroon;
            this.textMsgErroDataSaida.Location = new System.Drawing.Point(457, 310);
            this.textMsgErroDataSaida.Name = "textMsgErroDataSaida";
            this.textMsgErroDataSaida.Size = new System.Drawing.Size(0, 16);
            this.textMsgErroDataSaida.TabIndex = 130;
            // 
            // LabelNomeDataSaida
            // 
            this.LabelNomeDataSaida.AutoSize = true;
            this.LabelNomeDataSaida.BackColor = System.Drawing.Color.Transparent;
            this.LabelNomeDataSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomeDataSaida.Location = new System.Drawing.Point(456, 237);
            this.LabelNomeDataSaida.Name = "LabelNomeDataSaida";
            this.LabelNomeDataSaida.Size = new System.Drawing.Size(136, 24);
            this.LabelNomeDataSaida.TabIndex = 128;
            this.LabelNomeDataSaida.Text = "Data de saída";
            this.LabelNomeDataSaida.Visible = false;
            this.LabelNomeDataSaida.Click += new System.EventHandler(this.LabelNomeDataSaida_Click);
            // 
            // textBoxDataSaida
            // 
            this.textBoxDataSaida.Location = new System.Drawing.Point(457, 284);
            this.textBoxDataSaida.Mask = "00/00/0000";
            this.textBoxDataSaida.Name = "textBoxDataSaida";
            this.textBoxDataSaida.Size = new System.Drawing.Size(140, 20);
            this.textBoxDataSaida.TabIndex = 131;
            this.textBoxDataSaida.ValidatingType = typeof(System.DateTime);
            this.textBoxDataSaida.Visible = false;
            // 
            // textBoxDataEntrada
            // 
            this.textBoxDataEntrada.Location = new System.Drawing.Point(226, 388);
            this.textBoxDataEntrada.Mask = "00/00/0000";
            this.textBoxDataEntrada.Name = "textBoxDataEntrada";
            this.textBoxDataEntrada.Size = new System.Drawing.Size(140, 20);
            this.textBoxDataEntrada.TabIndex = 132;
            this.textBoxDataEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // TelaAlterarDadosAlunosForms
            // 
            this.AcceptButton = this.btnAlterarDados;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 554);
            this.Controls.Add(this.textBoxDataEntrada);
            this.Controls.Add(this.textBoxDataSaida);
            this.Controls.Add(this.textMsgErroDataSaida);
            this.Controls.Add(this.LabelNomeDataSaida);
            this.Controls.Add(this.labelMsgErroStatusAluno);
            this.Controls.Add(this.labelMsgErroPlano);
            this.Controls.Add(this.textMsgErroTelefone);
            this.Controls.Add(this.labelMsgErroResponsavel);
            this.Controls.Add(this.textBoxNomeResponsavel);
            this.Controls.Add(this.labelNomeResponsavel1);
            this.Controls.Add(this.LabelMsgErroDataEntrada);
            this.Controls.Add(this.textMsgErroIdade);
            this.Controls.Add(this.textBoxIdadeAluno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxPlano);
            this.Controls.Add(this.comboBoxStatusAlunos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAlterarDados);
            this.Controls.Add(this.textBoxTelefoneAluno);
            this.Controls.Add(this.textBoxNomeAluno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(238, 118);
            this.Name = "TelaAlterarDadosAlunosForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TelaAlterarDadosAlunosForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPlano;
        private System.Windows.Forms.ComboBox comboBoxStatusAlunos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.TextBox textBoxTelefoneAluno;
        private System.Windows.Forms.TextBox textBoxNomeAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textMsgErroIdade;
        private System.Windows.Forms.TextBox textBoxIdadeAluno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LabelMsgErroDataEntrada;
        private System.Windows.Forms.Label labelMsgErroResponsavel;
        private System.Windows.Forms.TextBox textBoxNomeResponsavel;
        private System.Windows.Forms.Label labelNomeResponsavel1;
        private System.Windows.Forms.Label textMsgErroTelefone;
        private System.Windows.Forms.Label labelMsgErroPlano;
        private System.Windows.Forms.Label labelMsgErroStatusAluno;
        private System.Windows.Forms.Label textMsgErroDataSaida;
        private System.Windows.Forms.Label LabelNomeDataSaida;
        private System.Windows.Forms.MaskedTextBox textBoxDataSaida;
        private System.Windows.Forms.MaskedTextBox textBoxDataEntrada;
    }
}