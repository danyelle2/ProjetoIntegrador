using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Model
{
    public class Aluno
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public bool StatusAtivo { get; set; }
        public bool StatusPagamento { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public DateTime DataEntrada { get; set; }
        public string Plano { get; set; }
        public string NomeResponsavel { get; set; }
        public string Status { get; set; }
    
}
}

