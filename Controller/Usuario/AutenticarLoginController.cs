using ProjetoIntegrador.BancoDeDados;
using ProjetoIntegrador.Model;
using ProjetoIntegrador.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjetoIntegrador.Controller
{
    public class AutenticarLoginController
    {

        private readonly AutenticacaoUsuario _authService;
        private readonly UsuarioRepositorio _usuarioRepositorio;
        public AutenticarLoginController(AutenticacaoUsuario authService, UsuarioRepositorio usuarioRepositorio)
        {
            _authService = authService;
            _usuarioRepositorio = usuarioRepositorio;
        }

        public bool RealizarLogin(string usuario, string senha, Label labelMensagem)
        {
            if (string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Favor, Preencher todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }            

             _authService.Authenticate(usuario, senha);

            TelaInicialForm telaInicial = new TelaInicialForm();
            telaInicial.Show();
            return true;


        }
    }
}




  
