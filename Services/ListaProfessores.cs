using ProjetoIntegrador.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Services
{
    internal class ListaProfessores
    {
        List<Professor> professores = new List<Professor>();

        string query = "SELECT Id_professor, nome FROM professor";

    using (var reader = _databaseService.ExecuteQuery(query))
    {
        while (reader.Read())
        {
            professores.Add(new Professor
            {
                Id = Convert.ToInt32(reader["Id_professor"]),
                Nome = reader["nome"].ToString()
            });
        }
    }

    return professores;
}
    }
}
