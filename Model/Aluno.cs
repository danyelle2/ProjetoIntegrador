using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Model
{
    internal class Aluno
    {
        //ve se essa classe ainda vai ser util quando tiver o banco de dados 
        // ela é usada no dataGridView da tela de pagamento
        public string Nome { get; set; }
        public bool StatusAtivo { get; set; }
        public bool StatusPagamento { get; set; }
    }
}
