using ProjetoIntegrador.Controller;
using ProjetoIntegrador.View;
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
            this.FormClosing += AppClose;

        }
        LoginController loginController = new LoginController();

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
            bool resultadoLogin = loginController.RealizarLogin(TxtUsuario.Text, TxtSenha.Text, MsgErro);

            if (resultadoLogin)
            {
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
