using ProjetoIntegrador.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Controller.Aluno
{
    public class RepositorioAluno
    {
        private readonly DatabaseService _databaseService;

        public RepositorioAluno(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public bool CadastrarAluno(ProjetoIntegrador.Model.Aluno aluno)
        { //FIZ EM CASA VERIFICAR SE TA DE ACORDO COM O BANCO DE DADOS NA SALA!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            string query = @"INSERT INTO aluno (nome, idade, telefone, data_entrada, data_saida,plano, responsavel, status) 
                         VALUES (@nome, @idade, @telefone, @data_entrada,@data_saida @plano, @responsavel, @status)";

            var parametros = new MySql.Data.MySqlClient.MySqlParameter[]
            {
            new MySql.Data.MySqlClient.MySqlParameter("@nome", aluno.Nome),
            new MySql.Data.MySqlClient.MySqlParameter("@idade", aluno.Idade),
            new MySql.Data.MySqlClient.MySqlParameter("@telefone", aluno.Telefone),
            new MySql.Data.MySqlClient.MySqlParameter("@data_entrada", aluno.DataEntrada),
            new MySql.Data.MySqlClient.MySqlParameter("@data_saida", aluno.DataSaida),
            new MySql.Data.MySqlClient.MySqlParameter("@plano", aluno.Plano),
            new MySql.Data.MySqlClient.MySqlParameter("@responsavel", aluno.NomeResponsavel),
            new MySql.Data.MySqlClient.MySqlParameter("@status", aluno.Status)
            };

            return _databaseService.ExecuteNonQuery(query, parametros) > 0;
        }
    }

}
