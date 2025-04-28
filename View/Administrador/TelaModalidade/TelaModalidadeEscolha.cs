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
        }

        private void TelaModalidadeEscolha_Load(object sender, EventArgs e)
        {
            Usuario usuario = SessionUser.userLogado;
            VisibilidadeTelaUsuario(usuario);


            if (usuario.TipoUsuario == "administrador")
            {
                btnCadastro.Visible = true;
            }
            else
            {
                btnCadastro.Visible = false;
            }
        }
        private void VisibilidadeTelaUsuario(Usuario usuario)
        {
            //TROCAR NOME MODALIDADE PARA O ID DA MODALIDADE
            if (usuario.IdModalidade == 1)
            {
                BtnZumba.Visible = true;
                BtnFuncional.Visible = true;
                BtnMuayThai.Visible = true;
            }
            else
            {
                BtnZumba.Visible = (usuario.IdModalidade == 2);
                BtnMuayThai.Visible = (usuario.IdModalidade == 3);
                BtnFuncional.Visible = (usuario.IdModalidade == 4);
            }


            //modalidade 1 é GERAL DO ADM
             //2 ZUMBA, 3 FUNCIONAL, 4 MUAY THAI
        }
                            
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

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

        }

        private void pictureBoxVoltar_Click(object sender, EventArgs e)
        {

        }

        private void BtnZumba_Click(object sender, EventArgs e)
        {
            var telaInicial = new TelaInicialForm();
            telaInicial.Show();
            this.Hide();
        }

        private void BtnFuncional_Click(object sender, EventArgs e)
        {
            var telaInicial = new TelaInicialForm();
            telaInicial.Show();
            this.Hide();
        }

        private void BtnMuayThai_Click(object sender, EventArgs e)
        {
            var telaInicial = new TelaInicialForm();
            telaInicial.Show();
            this.Hide();
        }

        private void btnCadastro_Click_1(object sender, EventArgs e)
        {
            TelaCadastroForm telaCadastro = new TelaCadastroForm();
            telaCadastro.Show();
            
        }

        //private void pictureBoxVoltar_Click(object sender, EventArgs e)
        //{

        //}
    }
}
