namespace ProjetoIntegrador.View
{
    partial class ApagarRascunho
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
            this.TxTExplicacaoModalidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxTExplicacaoModalidade
            // 
            this.TxTExplicacaoModalidade.AutoSize = true;
            this.TxTExplicacaoModalidade.BackColor = System.Drawing.Color.Transparent;
            this.TxTExplicacaoModalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxTExplicacaoModalidade.ForeColor = System.Drawing.Color.Black;
            this.TxTExplicacaoModalidade.Location = new System.Drawing.Point(-74, 685);
            this.TxTExplicacaoModalidade.Name = "TxTExplicacaoModalidade";
            this.TxTExplicacaoModalidade.Size = new System.Drawing.Size(0, 20);
            this.TxTExplicacaoModalidade.TabIndex = 92;
            // 
            // ApagarRascunho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1354, 710);
            this.Controls.Add(this.TxTExplicacaoModalidade);
            this.Name = "ApagarRascunho";
            this.Text = "ApagarRascunho";
            this.Load += new System.EventHandler(this.ApagarRascunho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TxTExplicacaoModalidade;
    }
}