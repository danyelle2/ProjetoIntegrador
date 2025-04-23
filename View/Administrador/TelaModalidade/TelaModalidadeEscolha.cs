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

            // aqui é sobre a modalidade. CHAMA O SESSIONUSER ele identifica qual usuario está logado
            //perguntar para o professor se é certo por aqui mesmo.
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
            //Colocar i nome dos botoes nao esquecer!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //if (usuario.TipoUsuario == "administrador")
            {
                //    grupoZumba.Visible = true;
                //    grupoMuayThai.Visible = true;
                //    grupoFuncional.Visible = true;
                //}
                //else
                //{
                //    grupoZumba.Visible = (usuario.Modalidade == "zumba");
                //    grupoMuayThai.Visible = (usuario.Modalidade == "muay_thai");
                //    grupoFuncional.Visible = (usuario.Modalidade == "funcional");
            }
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
        }

        private void BtnFuncional_Click(object sender, EventArgs e)
        {
            var telaInicial = new TelaInicialForm();
            telaInicial.Show();
        }

        private void BtnMuayThai_Click(object sender, EventArgs e)
        {
            var telaInicial = new TelaInicialForm();
            telaInicial.Show();
        }

        //private void pictureBoxVoltar_Click(object sender, EventArgs e)
        //{

        //}
    }
}
