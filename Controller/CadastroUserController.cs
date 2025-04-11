using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoIntegrador.BancoDeDados;
using ProjetoIntegrador.Model;

namespace ProjetoIntegrador.Controller
{
    internal class CadastroUserController
    {
        private readonly AutenticacaoLogin _authService;
        private readonly UsuarioRepositorio _usuarioRepositorio;
        public CadastroUserController (AutenticacaoLogin authService, UsuarioRepositorio usuarioRepositorio)
        {
            _authService = authService;
            _usuarioRepositorio = usuarioRepositorio;
        }

        public bool Register(Usuario usuario, string senha)
        {
            return _usuarioRepositorio.Register(usuario, senha);
        }
        //public bool Login (Usuario usuario, string senha)

    }
}
