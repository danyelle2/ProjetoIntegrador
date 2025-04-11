using ProjetoIntegrador.BancoDeDados;
using ProjetoIntegrador.Controller;
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
    public class LoginController
    {

        //private readonly AuthService _authService;
        //private readonly UsuarioRepositorio _usuarioRepositorio;
        //public LoginController(AuthService authService, UsuarioRepositorio usuarioRepositorio)
        //{
        //    _authService = authService;
        //    _usuarioRepositorio = usuarioRepositorio;
        //}

        public bool RealizarLogin(string usuario, string senha, Label labelMensagem)
        {
            if (string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Favor, Preencher todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }            

             //_authService.Authenticate(usuario, senha);

            TelaInicialForm telaInicial = new TelaInicialForm();
            telaInicial.Show();
            return true;


        }
    }
}



//CÓDIGO DO REPOSITÓRIO DO PROFESSOR
//public class AuthController
//{
//    private readonly AuthService _authService;
//    private readonly UsuarioRepositorio _usuarioRepositorio;

//    public AuthController(AuthService authService, UsuarioRepositorio usuarioRepositorio)
//    {
//        _authService = authService;
//        _usuarioRepositorio = usuarioRepositorio;
//    }

//    public Usuario Login(string email, string password)
//    {
//        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
//        {
//            throw new ArgumentException("Email e senha são obrigatórios");
//        }

//        return _authService.Authenticate(email, password);
//    }

//    public bool Register(Usuario usuario, string password)
//    {

//        if (usuario == null)
//        {
//            throw new ArgumentNullException(nameof(usuario));
//        }

//        if (string.IsNullOrEmpty(password))
//        {
//            throw new ArgumentException("Senha é obrigatória");
//        }

//        return _usuarioRepositorio.Register(usuario, password);
//    }
//}
