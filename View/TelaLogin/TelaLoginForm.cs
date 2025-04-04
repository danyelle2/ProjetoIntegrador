using ProjetoIntegrador.Controller;
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
        public TelaLoginForm()
        {
            InitializeComponent();
        }
        LoginController loginController = new LoginController();


        private void TelaLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            var telaCadastroForm = new View.TelaCadastroForm();
            telaCadastroForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool resultadoLogin = loginController.RealizarLogin(TxtUsuario.Text, TxtSenha.Text, MsgErro);

            if (resultadoLogin)
            {
                this.Hide();
            }
        }
    }
}
