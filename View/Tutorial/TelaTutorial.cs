using ProjetoIntegrador.View.Desenvolvedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.View.Tutorial
{
    public partial class TelaTutorial : Form
    {
        public TelaTutorial()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Botao de tela de esquecer senha tutorial
            TelaEsquecerSenhaTutorial telaEsquecerSenha = new TelaEsquecerSenhaTutorial();
            telaEsquecerSenha.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // botão de tela inicial da tela tutorial
            TelaInicialTutorial telaInicialTutorial = new TelaInicialTutorial();
            telaInicialTutorial.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Botão da Tela de login Tutorial
            var telaLogin = new TelaLoginForm();
            telaLogin.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Botão da Tela cadastro de usuário Tutorial
            var telaCadastroUsuario = new TelaCadastroUsuarioTutorial();
            telaCadastroUsuario.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Botao sobre desenvolvedor
            TelaCreditos telaCreditos = new TelaCreditos();
            telaCreditos.ShowDialog();
        }
    }
}
