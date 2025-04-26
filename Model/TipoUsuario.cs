using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Model
{
    public class TipoUsuario
    {
        public class TipoUsuarioItem
        {
            public string TextoExibido { get; set; }
            public string ValorBanco { get; set; }

            public override string ToString()
            {
                return TextoExibido;
            }

        }
    }
}
