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
        public bool CampoVazio(TextBox cpf, TextBox senha, Label mensagemError)
        {
            if (cpf == null || senha == null || mensagemError == null)
            {
                mensagemError.Text = "Por favor, preencha CPF e senha.";
                return false;
            }

            return true;
        }
    }
}