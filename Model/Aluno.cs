using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Model
{
    internal class Aluno
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public bool StatusAtivo { get; set; }
        public bool StatusPagamento { get; set; }
    }
}
}
