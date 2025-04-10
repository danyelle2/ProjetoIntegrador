using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Model
{
     public class Usuario
    {
        // colocar do jeito que ta no banco de dados
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string SenhaHash { get; set; }


    }
}
