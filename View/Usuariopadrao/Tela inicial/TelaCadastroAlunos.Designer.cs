﻿namespace ProjetoIntegrador.View
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
            this.textBoxNomeResponsavel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxIdade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAssinaturaAluno = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefoneALuno = new System.Windows.Forms.TextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textMsgErroIdade = new System.Windows.Forms.Label();
            this.textMsgErroResponsavel = new System.Windows.Forms.Label();
            this.textMsgErroTelefone = new System.Windows.Forms.Label();
            this.textMsgErroData = new System.Windows.Forms.Label();
            this.comboBoxStatusAluno = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMsgErroPlano = new System.Windows.Forms.Label();
            this.labelMsgErroStatusAluno = new System.Windows.Forms.Label();
            this.btnCadastrarAluno = new System.Windows.Forms.Button();
            this.textBoxDataEntrada = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBoxNomeResponsavel
            // 
            this.textBoxNomeResponsavel.Location = new System.Drawing.Point(456, 284);
            this.textBoxNomeResponsavel.Multiline = true;
            this.textBoxNomeResponsavel.Name = "textBoxNomeResponsavel";
            this.textBoxNomeResponsavel.Size = new System.Drawing.Size(140, 23);
            this.textBoxNomeResponsavel.TabIndex = 92;
            this.textBoxNomeResponsavel.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(459, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 24);
            this.label8.TabIndex = 91;
            this.label8.Text = "Responsável";
            this.label8.Visible = false;
            // 
            // textBoxIdade
            // 
            this.textBoxIdade.Location = new System.Drawing.Point(217, 369);
            this.textBoxIdade.Multiline = true;
            this.textBoxIdade.Name = "textBoxIdade";
            this.textBoxIdade.Size = new System.Drawing.Size(140, 23);
            this.textBoxIdade.TabIndex = 90;
            this.textBoxIdade.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(216, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 24);
            this.label7.TabIndex = 89;
            this.label7.Text = "Idade";
            // 
            // txtAssinaturaAluno
            // 
            this.txtAssinaturaAluno.FormattingEnabled = true;
            this.txtAssinaturaAluno.Items.AddRange(new object[] {
            "Mensal",
            "Anual"});
            this.txtAssinaturaAluno.Location = new System.Drawing.Point(217, 286);
            this.txtAssinaturaAluno.Name = "txtAssinaturaAluno";
            this.txtAssinaturaAluno.Size = new System.Drawing.Size(140, 21);
            this.txtAssinaturaAluno.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(456, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 24);
            this.label5.TabIndex = 86;
            this.label5.Text = "Data de entrada";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTelefoneALuno
            // 
            this.txtTelefoneALuno.Location = new System.Drawing.Point(217, 193);
            this.txtTelefoneALuno.MaxLength = 11;
            this.txtTelefoneALuno.Multiline = true;
            this.txtTelefoneALuno.Name = "txtTelefoneALuno";
            this.txtTelefoneALuno.Size = new System.Drawing.Size(140, 23);
            this.txtTelefoneALuno.TabIndex = 84;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(217, 110);
            this.txtNomeAluno.Multiline = true;
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(140, 23);
            this.txtNomeAluno.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(216, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 81;
            this.label3.Text = "Plano";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(216, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 80;
            this.label2.Text = "Telefone";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(216, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 79;
            this.label1.Text = "Nome";
            // 
            // textMsgErroIdade
            // 
            this.textMsgErroIdade.AutoSize = true;
            this.textMsgErroIdade.BackColor = System.Drawing.Color.Transparent;
            this.textMsgErroIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMsgErroIdade.ForeColor = System.Drawing.Color.Maroon;
            this.textMsgErroIdade.Location = new System.Drawing.Point(217, 398);
            this.textMsgErroIdade.Name = "textMsgErroIdade";
            this.textMsgErroIdade.Size = new System.Drawing.Size(0, 16);
            this.textMsgErroIdade.TabIndex = 95;
            // 
            // textMsgErroResponsavel
            // 
            this.textMsgErroResponsavel.AutoSize = true;
            this.textMsgErroResponsavel.BackColor = System.Drawing.Color.Transparent;
            this.textMsgErroResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMsgErroResponsavel.ForeColor = System.Drawing.Color.Maroon;
            this.textMsgErroResponsavel.Location = new System.Drawing.Point(460, 312);
            this.textMsgErroResponsavel.Name = "textMsgErroResponsavel";
            this.textMsgErroResponsavel.Size = new System.Drawing.Size(0, 16);
            this.textMsgErroResponsavel.TabIndex = 96;
            // 
            // textMsgErroTelefone
            // 
            this.textMsgErroTelefone.AutoSize = true;
            this.textMsgErroTelefone.BackColor = System.Drawing.Color.Transparent;
            this.textMsgErroTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMsgErroTelefone.ForeColor = System.Drawing.Color.Maroon;
            this.textMsgErroTelefone.Location = new System.Drawing.Point(217, 219);
            this.textMsgErroTelefone.Name = "textMsgErroTelefone";
            this.textMsgErroTelefone.Size = new System.Drawing.Size(0, 16);
            this.textMsgErroTelefone.TabIndex = 97;
            // 
            // textMsgErroData
            // 
            this.textMsgErroData.AutoSize = true;
            this.textMsgErroData.BackColor = System.Drawing.Color.Transparent;
            this.textMsgErroData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMsgErroData.ForeColor = System.Drawing.Color.Maroon;
            this.textMsgErroData.Location = new System.Drawing.Point(460, 133);
            this.textMsgErroData.Name = "textMsgErroData";
            this.textMsgErroData.Size = new System.Drawing.Size(0, 16);
            this.textMsgErroData.TabIndex = 98;
            // 
            // comboBoxStatusAluno
            // 
            this.comboBoxStatusAluno.FormattingEnabled = true;
            this.comboBoxStatusAluno.Items.AddRange(new object[] {
            "Ativo"});
            this.comboBoxStatusAluno.Location = new System.Drawing.Point(456, 193);
            this.comboBoxStatusAluno.Name = "comboBoxStatusAluno";
            this.comboBoxStatusAluno.Size = new System.Drawing.Size(140, 21);
            this.comboBoxStatusAluno.TabIndex = 113;
            this.comboBoxStatusAluno.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatusAluno_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(459, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 24);
            this.label6.TabIndex = 112;
            this.label6.Text = "Status do aluno";
            // 
            // labelMsgErroPlano
            // 
            this.labelMsgErroPlano.AutoSize = true;
            this.labelMsgErroPlano.BackColor = System.Drawing.Color.Transparent;
            this.labelMsgErroPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsgErroPlano.ForeColor = System.Drawing.Color.Maroon;
            this.labelMsgErroPlano.Location = new System.Drawing.Point(217, 310);
            this.labelMsgErroPlano.Name = "labelMsgErroPlano";
            this.labelMsgErroPlano.Size = new System.Drawing.Size(0, 16);
            this.labelMsgErroPlano.TabIndex = 114;
            // 
            // labelMsgErroStatusAluno
            // 
            this.labelMsgErroStatusAluno.AutoSize = true;
            this.labelMsgErroStatusAluno.BackColor = System.Drawing.Color.Transparent;
            this.labelMsgErroStatusAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsgErroStatusAluno.ForeColor = System.Drawing.Color.Maroon;
            this.labelMsgErroStatusAluno.Location = new System.Drawing.Point(460, 222);
            this.labelMsgErroStatusAluno.Name = "labelMsgErroStatusAluno";
            this.labelMsgErroStatusAluno.Size = new System.Drawing.Size(0, 16);
            this.labelMsgErroStatusAluno.TabIndex = 115;
            // 
            // btnCadastrarAluno
            // 
            this.btnCadastrarAluno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrarAluno.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarAluno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrarAluno.BackgroundImage")));
            this.btnCadastrarAluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCadastrarAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarAluno.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCadastrarAluno.FlatAppearance.BorderSize = 0;
            this.btnCadastrarAluno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarAluno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnCadastrarAluno.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarAluno.Location = new System.Drawing.Point(583, 430);
            this.btnCadastrarAluno.Name = "btnCadastrarAluno";
            this.btnCadastrarAluno.Size = new System.Drawing.Size(137, 59);
            this.btnCadastrarAluno.TabIndex = 85;
            this.btnCadastrarAluno.UseVisualStyleBackColor = false;
            this.btnCadastrarAluno.Click += new System.EventHandler(this.btnCadastrarAluno_Click);
            // 
            // textBoxDataEntrada
            // 
            this.textBoxDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDataEntrada.Location = new System.Drawing.Point(456, 110);
            this.textBoxDataEntrada.Mask = "00/00/0000";
            this.textBoxDataEntrada.Name = "textBoxDataEntrada";
            this.textBoxDataEntrada.Size = new System.Drawing.Size(140, 22);
            this.textBoxDataEntrada.TabIndex = 116;
            this.textBoxDataEntrada.ValidatingType = typeof(System.DateTime);
            this.textBoxDataEntrada.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textBoxDataEntrada_MaskInputRejected);
            // 
            // TelaCadastroAlunos
            // 
            this.AcceptButton = this.btnCadastrarAluno;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 554);
            this.Controls.Add(this.textBoxDataEntrada);
            this.Controls.Add(this.labelMsgErroStatusAluno);
            this.Controls.Add(this.labelMsgErroPlano);
            this.Controls.Add(this.comboBoxStatusAluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textMsgErroData);
            this.Controls.Add(this.textMsgErroTelefone);
            this.Controls.Add(this.textMsgErroResponsavel);
            this.Controls.Add(this.textMsgErroIdade);
            this.Controls.Add(this.textBoxNomeResponsavel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxIdade);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAssinaturaAluno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCadastrarAluno);
            this.Controls.Add(this.txtTelefoneALuno);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(238, 118);
            this.Name = "TelaCadastroAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TelaCadastroAlunos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomeResponsavel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxIdade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtAssinaturaAluno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefoneALuno;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textMsgErroIdade;
        private System.Windows.Forms.Label textMsgErroResponsavel;
        private System.Windows.Forms.Label textMsgErroTelefone;
        private System.Windows.Forms.Label textMsgErroData;
        private System.Windows.Forms.ComboBox comboBoxStatusAluno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMsgErroPlano;
        private System.Windows.Forms.Label labelMsgErroStatusAluno;
        private System.Windows.Forms.Button btnCadastrarAluno;
        private System.Windows.Forms.MaskedTextBox textBoxDataEntrada;
    }
}