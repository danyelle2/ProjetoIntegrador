using ProjetoIntegrador.BancoDeDados;
using ProjetoIntegrador.Controller;
using ProjetoIntegrador.Controller.Usuario;
using ProjetoIntegrador.View;
using ProjetoIntegrador.View.Administrador.TelaModalidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador
{
    public partial class TelaLoginForm : Form
    {
        LoginController loginController;
        public TelaLoginForm()
        {
            
            InitializeComponent();
            this.FormClosing += AppClose;
            loginController = new LoginController();
        }

        public void AppClose(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();

        }              
        


        private void TelaLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
                TelaCadastroForm telaCadastroForm = new TelaCadastroForm();
                telaCadastroForm.Show();
                this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool resultadoCamposVazios = loginController.CampoVazio(TxtUsuario, TxtSenha,MsgErro);

            string cpf = TxtUsuario.Text.Trim();
            string senha = TxtSenha.Text;

            try
            {
                var databaseService = new DatabaseService();
                var autenticador = new AutenticacaoUsuario(databaseService);
                var usuario = autenticador.AutenticarUsuario(cpf, senha);

                if (usuario != null)
                {
                    MessageBox.Show($"Bem-vindo, {usuario.Nome}!", "Login realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    var telaEscolhaModalidade = new TelaModalidadeEscolha(usuario);
                    telaEscolhaModalidade.Show();
                }
                else
                {
                    MsgErro.Text = "CPF ou senha inválidos!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar fazer login:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
              

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
