using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.Controller.Usuario
{
    public class LimparCamposLoginController
    {
        public bool CampoVazio(TextBox cpf, TextBox senha)
        {
            if (string.IsNullOrWhiteSpace(cpf.Text) || string.IsNullOrWhiteSpace(senha.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

    }
}