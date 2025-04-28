using MySqlX.XDevAPI;
using ProjetoIntegrador.Services;
using ProjetoIntegrador.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegrador.View.Administrador.TelaModalidade;
using ProjetoIntegrador.Controller.Usuario;
using MySql.Data.MySqlClient;

namespace ProjetoIntegrador
{
    public partial class TelaLoginForm : Form
    {
        LimparCamposLoginController loginController;


        public TelaLoginForm()
        {

            InitializeComponent();
            this.FormClosing += AppClose;
            loginController = new LimparCamposLoginController();
            TxtUsuario.KeyDown += TxtUsuarioSenha_KeyDown;
            TxtSenha.KeyDown += TxtUsuarioSenha_KeyDown;

        }

       

        public void AppClose(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();

        }



        private void TelaLoginForm_Load(object sender, EventArgs e)
        {

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool metodoCampoVazio = loginController.CampoVazio(TxtUsuario, TxtSenha);

            if (metodoCampoVazio)
            {
                string cpf = TxtUsuario.Text.Trim();
                string senha = TxtSenha.Text;

                try
                {
                    using (var databaseService = new DatabaseService())
                    {
                        var autenticador = new AutenticacaoUsuario(databaseService);

                        Usuario usuario = autenticador.AutenticarUsuario(cpf, senha);

                        if (usuario != null)
                        {
                            MessageBox.Show($"Bem-vindo, {usuario.Nome}!", "Login realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SessionUser.Login(usuario);

                            this.Close();
                            var telaEscolhaModalidade = new TelaModalidadeEscolha();
                            telaEscolhaModalidade.Show();
                        }
                        else
                        {
                            MsgErro1.Text = "CPF ou senha inválidos!";
                        }
                    }
                }
                
                catch (UnauthorizedAccessException ex)
                {
                MessageBox.Show(ex.Message, "Erro de autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                catch (MySqlException ex)
                {
                MessageBox.Show("Erro ao conectar ao banco de dados:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar fazer login:\n" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtUsuario_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void TxtUsuarioSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick(); 
            }
        }
        //private void btnCadastro_Click_1(object sender, EventArgs e)
        //{

        //}
    }
}
