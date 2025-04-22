using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Model
{
    internal class EntradaSaidaAlunos
    {
        //ve se essa classe ainda vai ser util quando tiver o banco de dados
        // ela é usada no gráfico mensal 
        public string Mes { get; set; }
        public int Entrada { get; set; }
        public int Saida { get; set; }
    }
}
