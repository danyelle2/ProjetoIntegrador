
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Model
{
    public class Usuario
    {
        // colocar do jeito que ta no banco de dados aqui é para ele identificar na autentificação de login
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public string TipoUsuario { get; set; }
        public int TipoMembro { get; set; }
        public bool StatusUsuario { get; set; }        
        public string Modalidade { get; set; }
        public int IdModalidade { get; set; } 


    }
}
