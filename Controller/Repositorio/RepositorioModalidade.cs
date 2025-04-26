using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ProjetoIntegrador.Model;
using ProjetoIntegrador.Services;

namespace ProjetoIntegrador.Controller.Repositorio
{
    public  class RepositorioModalidade
    {
        private readonly DatabaseService _databaseService;

        public RepositorioModalidade (DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
        public List<Modalidade> GetModalidades()
        {
            //Eu faço uma lista para ler de forma organizada . Quando tiver o select

            List<Modalidade> listModalidades = new List<Modalidade>();

            string query = @"
            SELECT * FROM professor;";
            // ExecuteQuery faz somente a leitura do banco de dados 
            MySqlDataReader reader = _databaseService.ExecuteQuery(query);

            while (reader.Read())
            {
                // Crio um objeto modalidadeItem para cada linha que ele ler do banco de dados
                Modalidade modalidadeItem = new Modalidade();
                modalidadeItem = Modalidade.ModalidadeFromDataReader(reader);

                listModalidades.Add(modalidadeItem);

            }



            return listModalidades;




        }
    }

}
