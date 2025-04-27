using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoIntegrador.Model
{
    public class Modalidade
    {
        public string TipoModalidade { get; set; }
        public int IdModalidade { get; set; }

        // abertura da classe e criação do método Reader para ler os dados do banco de dados
        //1- abro a classe com metodo; 2 - criou repositorio Reader 4- Criar em forma de lista para melhor organização
        // 5 - criar um objeto para cada tabela do banco de dados no caso uma classe 3- coloco as informação no load 
        public static Modalidade ModalidadeFromDataReader(MySqlDataReader reader) { 
        
            return new Modalidade
            {
                TipoModalidade = reader["tipo_modalidade"].ToString(),
                IdModalidade = Convert.ToInt32(reader["id_modalidade"])
            };
        
        }

        // public class TipoModalidade
        //{
        //        public int IdModalidade { get; set; }
        //        public string Tipo_Modalidade { get; set; }
        //        public string TextoExibido { get; set; }
        //        public int ValorBanco { get; set; }
        //        public override string ToString()
        //        {
        //            return Tipo_Modalidade;
        //        }
            
        //}
    }

    
}
