using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoIntegrador.Model;

namespace ProjetoIntegrador.Controller.Repositorios
{
    public class AutenticacaoLoginController
    {
        
            private readonly AutenticacaoLoginController _authService;
            private readonly UsuarioRepositorio _usuarioRepositorio;

            public AutenticacaoLoginController(AutenticacaoLoginController authService, UsuarioRepositorio usuarioRepositorio)
            {
                _authService = authService;
                _usuarioRepositorio = usuarioRepositorio;
            }

            public Usuario Login(string cpf, string senha, bool statusUsuario)
            {               

                return _authService.AuthenticacaoUsuario(cpf, senha, statusUsuario);
            }

            public bool Register(Usuario usuario, string password)
            { 

                return _usuarioRepositorio.Register(usuario, password);
            }
        }
    }
}

