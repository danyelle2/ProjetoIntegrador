namespace ProjetoIntegrador.View
{
    partial class TelaInicialForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicialForm));
            this.MsgExplicacaoGrafico = new System.Windows.Forms.Label();
            this.MsgExplicacaoAlterarDados = new System.Windows.Forms.Label();
            this.MsgExplicacaoCadastro = new System.Windows.Forms.Label();
            this.pictureBoxCadastroAlunos = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadastroAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MsgExplicacaoGrafico
            // 
            this.MsgExplicacaoGrafico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MsgExplicacaoGrafico.AutoSize = true;
            this.MsgExplicacaoGrafico.Location = new System.Drawing.Point(695, 224);
            this.MsgExplicacaoGrafico.Name = "MsgExplicacaoGrafico";
            this.MsgExplicacaoGrafico.Size = new System.Drawing.Size(16, 13);
            this.MsgExplicacaoGrafico.TabIndex = 14;
            this.MsgExplicacaoGrafico.Text = "...";
            // 
            // MsgExplicacaoAlterarDados
            // 
            this.MsgExplicacaoAlterarDados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MsgExplicacaoAlterarDados.AutoSize = true;
            this.MsgExplicacaoAlterarDados.Location = new System.Drawing.Point(430, 224);
            this.MsgExplicacaoAlterarDados.Name = "MsgExplicacaoAlterarDados";
            this.MsgExplicacaoAlterarDados.Size = new System.Drawing.Size(16, 13);
            this.MsgExplicacaoAlterarDados.TabIndex = 13;
            this.MsgExplicacaoAlterarDados.Text = "...";
            // 
            // MsgExplicacaoCadastro
            // 
            this.MsgExplicacaoCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MsgExplicacaoCadastro.AutoSize = true;
            this.MsgExplicacaoCadastro.Location = new System.Drawing.Point(164, 233);
            this.MsgExplicacaoCadastro.Name = "MsgExplicacaoCadastro";
            this.MsgExplicacaoCadastro.Size = new System.Drawing.Size(16, 13);
            this.MsgExplicacaoCadastro.TabIndex = 12;
            this.MsgExplicacaoCadastro.Text = "...";
            // 
            // pictureBoxCadastroAlunos
            // 
            this.pictureBoxCadastroAlunos.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCadastroAlunos.Image")));
            this.pictureBoxCadastroAlunos.Location = new System.Drawing.Point(37, 175);
            this.pictureBoxCadastroAlunos.Name = "pictureBoxCadastroAlunos";
            this.pictureBoxCadastroAlunos.Size = new System.Drawing.Size(100, 108);
            this.pictureBoxCadastroAlunos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCadastroAlunos.TabIndex = 15;
            this.pictureBoxCadastroAlunos.TabStop = false;
            this.pictureBoxCadastroAlunos.Click += new System.EventHandler(this.pictureBoxCadastroAlunos_Click);
            this.pictureBoxCadastroAlunos.MouseLeave += new System.EventHandler(this.pictureBoxCadastroAlunosDesaparece);
            this.pictureBoxCadastroAlunos.MouseHover += new System.EventHandler(this.pictureBoxCadastroAlunosAparecer);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 175);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBoxAlterarDadosDesaparece);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBoxAlterarDadosAparece);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(558, 176);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBoxGráficoDesaparece);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBoxGráficoAparece);
            // 
            // TelaInicialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxCadastroAlunos);
            this.Controls.Add(this.MsgExplicacaoGrafico);
            this.Controls.Add(this.MsgExplicacaoAlterarDados);
            this.Controls.Add(this.MsgExplicacaoCadastro);
            this.Name = "TelaInicialForm";
            this.Text = "TelaInicialForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadastroAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MsgExplicacaoGrafico;
        private System.Windows.Forms.Label MsgExplicacaoAlterarDados;
        private System.Windows.Forms.Label MsgExplicacaoCadastro;
        private System.Windows.Forms.PictureBox pictureBoxCadastroAlunos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}