using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Controller
{
    internal class RepositorioProfessor
    {//terminar esse !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private readonly DatabaseService _databaseService;
        public RepositorioProfessor(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }
        public List<Professor> ObterProfessores()
        {
            List<Professor> professores = new List<Professor>();
            string query = "SELECT Id_professor, nome,id_modalidade FROM professor";
            using (var reader = _databaseService.ExecuteQuery(query))
            {
                while (reader.Read())
                {
                    professores.Add(new Professor
                    {
                        Id = Convert.ToInt32(reader["Id_professor"]),
                        Id = Convert.ToInt32(reader["Id_modalidade"]),
                        Nome = reader["nome"].ToString()
                    });
                }
            }
            return professores;
        }
    }
}
