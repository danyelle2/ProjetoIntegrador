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
        public string Tipo_Modalidade { get; set; }
        public int Id_Modalidade { get; set; }

        // abertura da classe e criação do método Reader para ler os dados do banco de dados
        //1- abro a classe com metodo; 2 - criou repositorio Reader 4- Criar em forma de lista para melhor organização
        // 5 - criar um objeto para cada tabela do banco de dados no caso uma classe 3- coloco as informação no load 
        public static Modalidade ModalidadeFromDataReader(MySqlDataReader reader) { 
        
            return new Modalidade
            {
                Tipo_Modalidade = reader["tipo_modalidade"].ToString(),
                Id_Modalidade = Convert.ToInt32(reader["id_modalidade"])
            };
        
        }


    }

    
}
