
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoIntegrador.Model;

namespace ProjetoIntegrador.BancoDeDados
{
    public static class SessionUser
    {
        public static Usuario userLogado;

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
