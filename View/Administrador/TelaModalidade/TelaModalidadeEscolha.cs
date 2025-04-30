using ProjetoIntegrador.Model;
using ProjetoIntegrador.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.View.Administrador.TelaModalidade
{
    public partial class TelaModalidadeEscolha : Form
    {
        public TelaModalidadeEscolha()
        {
            InitializeComponent();
            this.FormClosing += AppClose;

        }
        public void AppClose(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja encerrar a aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.ExitThread();
            }
        }

        private void TelaModalidadeEscolha_Load(object sender, EventArgs e)
        {
            Usuario usuario = SessionUser.userLogado;
            VisibilidadeTelaUsuario(usuario);

            labelTextoNaTela.Text = $"Pronto para iniciar {usuario.Nome}!\n Selecione a sua modalidade ";
            //labelTextoNaTela.Text = $"Pronto para iniciar Danyelle!\n Selecione a sua modalidade  ";

            btnCadastro.Visible = (usuario.TipoUsuario == "administrador");

           

        }
     private void VisibilidadeTelaUsuario(Usuario usuario)
        {
     
     BtnZumba.Visible = true;
     BtnFuncional.Visible = true;
     BtnMuayThai.Visible = true;

     if (usuario.IdModalidade == 1) 
     {
         BtnZumba.Enabled = true;
         BtnFuncional.Enabled = true;
         BtnMuayThai.Enabled = true;
     }
     else
     {
         BtnZumba.Enabled = (usuario.IdModalidade == 2);
         BtnFuncional.Enabled = (usuario.IdModalidade == 3);
         BtnMuayThai.Enabled = (usuario.IdModalidade == 4);
     }
 }



        //modalidade 1 é GERAL DO ADM
        //2 ZUMBA, 3 FUNCIONAL, 4 MUAY THAI




        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            TelaCadastroForm telaCadastro = new TelaCadastroForm();
            telaCadastro.Show();
            this.Hide();

        }

        private void pictureBoxVoltar_Click(object sender, EventArgs e)
        {

        }

        private void BtnZumba_Click(object sender, EventArgs e)
        {
            if (BtnZumba.Enabled)
            {
                var telaInicial = new TelaInicialForm(2); 
                telaInicial.Show();
                this.Hide();

            }
        
        }

        private void BtnFuncional_Click(object sender, EventArgs e)
        {

            if (BtnFuncional.Enabled)
            {
                var telaInicial = new TelaInicialForm(3); 
                telaInicial.Show();
                this.Hide();
            }
        }

        private void BtnMuayThai_Click(object sender, EventArgs e)
        {
            if (BtnMuayThai.Enabled)
            {
                var telaInicial = new TelaInicialForm(4); 
                telaInicial.Show();
                this.Hide();
            }
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTextoNaTela_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void pictureBoxVoltar_Click(object sender, EventArgs e)
        //{

        //}
    }
}
