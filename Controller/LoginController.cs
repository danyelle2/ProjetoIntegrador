using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.Controller
{
    internal class LoginController
    {
        public bool RealizarLogin(string usuario, string senha, Label labelMensagem)
        {
            if (string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Favor, Preencher todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (usuario != "admin" && senha != "1234")
            {
                labelMensagem.Text = "Usuário ou senha incorretos";
                return false;
            }

            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
            return true;


        }
    }
}
