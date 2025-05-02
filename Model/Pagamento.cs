using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Model
{
    public class Pagamento
    {
        public int IdPagamento { get; set; }
        public int IdAluno { get; set; }
        public string NomeAluno { get; set; }
        public bool StatusPagamento { get; set; }
        public DateTime? DataPagamento { get; set; }
        public string StatusPagamentoTexto => StatusPagamento ? "Pago" : "Pendente";

    }
}
