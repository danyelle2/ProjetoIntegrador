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
        }

        //LimparCamposLoginController loginController;
        //DatabaseService _dataBaseService;
        //AutenticacaoUsuario _autenticador;
        //public TelaLoginForm()
        //{

        //    InitializeComponent();
        //    this.FormClosing += AppClose;
        //    loginController = new LimparCamposLoginController();
        //    _dataBaseService = new DatabaseService();
        //    _autenticador = new AutenticacaoUsuario(_dataBaseService);
        //} DEPOIS COLOCAR ASSIM PRA CHAMAR QUANDO INICIAR 

        public void AppClose(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();

        }



        private void TelaLoginForm_Load(object sender, EventArgs e)
        {

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool camposVazios = loginController.CampoVazio(TxtUsuario, TxtSenha, MsgErro);
            if (camposVazios)
            {



                string cpf = TxtUsuario.Text.Trim();
                string senha = TxtSenha.Text;

                try
                {
                    using (var databaseService = new DatabaseService())
                    {
                        var autenticador = new AutenticacaoUsuario(databaseService);

                        Usuario usuario = autenticador.AutenticarUsuarionaModalidade(cpf, senha, true, "administrador" ); //LEMBRRAR DE COLOCAR PADRÃO AQUI TAMBÉM
                        MessageBox.Show("chegou aqui:\n", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (usuario != null)
                        {
                            MessageBox.Show($"Bem-vindo, {usuario.Nome}!", "Login realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            SessionUser.Login(usuario);

                            this.Hide();
                            var telaEscolhaModalidade = new TelaModalidadeEscolha();
                            telaEscolhaModalidade.Show();
                        }
                        else
                        {

                            MsgErro.Text = "CPF ou senha inválidos!";
                        }
                    }
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

        //private void btnCadastro_Click_1(object sender, EventArgs e)
        //{

        //}
    }
}
