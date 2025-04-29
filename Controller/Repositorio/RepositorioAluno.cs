using ProjetoIntegrador.Model;
using ProjetoIntegrador.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoIntegrador.Controller;
using ProjetoIntegrador.Controller.Aluno;
using MySql.Data.MySqlClient;

namespace ProjetoIntegrador.Controller.Aluno
{
    public class RepositorioAluno
    {
        private readonly DatabaseService _databaseService;

        public RepositorioAluno(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public bool CadastrarAluno(Model.Aluno aluno)
        {
            string query = @"
                INSERT INTO aluno (
                    nome, idade, telefone, 
                    data_entrada, responsavel, 
                    status_aluno, assinatura_aluno
                ) 
                VALUES (
                    @nome, @idade, @telefone,
                    @data_entrada, @responsavel, 
                    @status, @assinatura_aluno
                )";

            var parametros = new MySql.Data.MySqlClient.MySqlParameter[]
            {
                new MySql.Data.MySqlClient.MySqlParameter("@nome", aluno.Nome),
                new MySql.Data.MySqlClient.MySqlParameter("@idade", aluno.Idade),
                new MySql.Data.MySqlClient.MySqlParameter("@telefone", aluno.Telefone),
                new MySql.Data.MySqlClient.MySqlParameter("@data_entrada", aluno.DataEntrada),
                new MySql.Data.MySqlClient.MySqlParameter("@responsavel", aluno.NomeResponsavel),
                new MySql.Data.MySqlClient.MySqlParameter("@status", true),
                new MySql.Data.MySqlClient.MySqlParameter("@assinatura_aluno", aluno.Assinatura)
            };

            return _databaseService.ExecuteNonQuery(query, parametros) > 0;
        }

        public bool AlterarDadosAlunos(Model.Aluno aluno)
        {
            string query = @"UPDATE aluno 
                             SET nome = @nome,
                                 idade = @idade,
                                 telefone = @telefone,
                                 responsavel = @responsavel,
                                 data_entrada = @dataEntrada,
                                 data_saida = @dataSaida,
                                 status_aluno = @status,
                                 assinatura_aluno = @assinatura_aluno
                             WHERE id_aluno = @id";

            var parametros = new MySql.Data.MySqlClient.MySqlParameter[]
            {
                new MySql.Data.MySqlClient.MySqlParameter("@nome", aluno.Nome),
                new MySql.Data.MySqlClient.MySqlParameter("@idade", aluno.Idade),
                new MySql.Data.MySqlClient.MySqlParameter("@telefone", aluno.Telefone),
                new MySql.Data.MySqlClient.MySqlParameter("@responsavel", aluno.NomeResponsavel),
                new MySql.Data.MySqlClient.MySqlParameter("@dataEntrada", aluno.DataEntrada),
                new MySql.Data.MySqlClient.MySqlParameter("@dataSaida",  aluno.DataSaida.HasValue ? aluno.DataSaida.Value : (object)DBNull.Value), // SE EU COLOCAR ASSIM ACEITA A DATA SAIDA SER NULA !!!
                new MySql.Data.MySqlClient.MySqlParameter("@status", aluno.Status),
                new MySql.Data.MySqlClient.MySqlParameter("@assinatura_aluno", aluno.Assinatura),
                new MySql.Data.MySqlClient.MySqlParameter("@id", aluno.Id)
            };

            return _databaseService.ExecuteNonQuery(query, parametros) > 0;
        }
    }
}
