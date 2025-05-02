
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoIntegrador.Model;

namespace ProjetoIntegrador.Services
{
    
        public static class SessionUser
        {
            public static Usuario userLogado;

            public static int IdUsuario => userLogado?.Id ?? 0;
            public static int IdModalidade => userLogado?.IdModalidade ?? 0;

            private const int IdModalidadeAdministrador = 1;

            public static bool EhAdministrador => IdModalidade == IdModalidadeAdministrador;

            public static Usuario Login(Usuario usuario)
            {
                return userLogado = usuario;
            }

            public static void Logout()
            {
                userLogado = null;
            }
        }


    }
