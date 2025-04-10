using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoIntegrador.Model;

namespace ProjetoIntegrador.Controller
{
    internal class CadastroProfessorController
    {
        public bool Register(Usuario usuario, string password)
        {

            if (usuario == null)
            {
                throw new ArgumentNullException(nameof(usuario));
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Senha é obrigatória");
            }

            return _usuarioRepositorio.Register(usuario, password);
        }
    }
}
