using ProjetoIntegrador.Model;
using ProjetoIntegrador.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoIntegrador.Controller;
using ProjetoIntegrador.Controller.Aluno;

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
            string query = @"INSERT INTO aluno (nome, idade, telefone, data_entrada, data_saida,assinatura , responsavel, status_aluno, assinatura_aluno) 
                         VALUES (@nome, @idade, @telefone, @data_entrada,@data_saida @plano, @responsavel, @status,@assinatura_aluno)";

            var parametros = new MySql.Data.MySqlClient.MySqlParameter[]
            {
            new MySql.Data.MySqlClient.MySqlParameter("@nome", aluno.Nome),
            new MySql.Data.MySqlClient.MySqlParameter("@idade", aluno.Idade),
            new MySql.Data.MySqlClient.MySqlParameter("@telefone", aluno.Telefone),
            new MySql.Data.MySqlClient.MySqlParameter("@data_entrada", aluno.DataEntrada),
            new MySql.Data.MySqlClient.MySqlParameter("@data_saida", aluno.DataSaida),
            new MySql.Data.MySqlClient.MySqlParameter("@plano", aluno.Plano),
            new MySql.Data.MySqlClient.MySqlParameter("@responsavel", aluno.NomeResponsavel),
            new MySql.Data.MySqlClient.MySqlParameter("@status", aluno.Status),
            new MySql.Data.MySqlClient.MySqlParameter("@assinatura_aluno", aluno.Assinatura)
            };

            return _databaseService.ExecuteNonQuery(query, parametros) > 0;
        }
        public bool AlterarDadosAlunos(Model.Aluno aluno)

        {
            string query = @"UPDATE aluno SET nome = @nome,
                            idade = @idade,
                            responsavel = @responsavel,
                            telefone = @telefone,
                            data_entrada = @dataEntrada,
                            data_saida = @dataSaida,
                            status_aluno = @status
                            assinatura_aluno = @assinatur_aluno, 
                         WHERE id_aluno = @id";

            var parametros = new MySql.Data.MySqlClient.MySqlParameter[]
                {
                    new MySql.Data.MySqlClient.MySqlParameter("@nome", aluno.Nome),
                    new MySql.Data.MySqlClient.MySqlParameter("@idade", aluno.Idade),
                    new MySql.Data.MySqlClient.MySqlParameter("@telefone", aluno.Telefone),
                  new MySql.Data.MySqlClient.MySqlParameter("@dataEntrada", aluno.DataEntrada),
              new MySql.Data.MySqlClient.MySqlParameter("@plano", aluno.Plano),
                    new MySql.Data.MySqlClient.MySqlParameter("@nomeResponsavel", aluno.NomeResponsavel),
                    new MySql.Data.MySqlClient.MySqlParameter("@status", aluno.Status),
                    new MySql.Data.MySqlClient.MySqlParameter("@dataSaida", aluno.DataSaida),
                new MySql.Data.MySqlClient.MySqlParameter("@id", aluno.Id),
                new MySql.Data.MySqlClient.MySqlParameter("@assinatura_aluno", aluno.Assinatura)
            };

            return _databaseService.ExecuteNonQuery(query, parametros) > 0;
        }

            }
}

