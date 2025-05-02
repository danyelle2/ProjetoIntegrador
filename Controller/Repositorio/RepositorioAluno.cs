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
using System.Data.SqlClient;

namespace ProjetoIntegrador.Controller.Aluno
{//NÃO MEXER MAIS TA OK!!
    public class RepositorioAluno
    {
        private readonly DatabaseService _databaseService;

        public RepositorioAluno(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public bool CadastrarAluno(Model.Aluno aluno)
        {
            _databaseService.OpenConnection();
            MySqlTransaction transaction = _databaseService.Connection.BeginTransaction();

            try
            {
                string queryAluno = @"
            INSERT INTO aluno (
                nome, idade, telefone, 
                data_entrada, responsavel, 
                status_aluno, assinatura_aluno,
                id_modalidade)
            VALUES (
                @nome, @idade, @telefone,
                @data_entrada, @responsavel, 
                @status, @assinatura_aluno,
                @id_modalidade);
            SELECT LAST_INSERT_ID();";

                var parametrosAluno = new MySqlParameter[]
                {
            new MySqlParameter("@nome", aluno.Nome),
            new MySqlParameter("@idade", aluno.Idade),
            new MySqlParameter("@telefone", aluno.Telefone),
            new MySqlParameter("@data_entrada", aluno.DataEntrada),
            new MySqlParameter("@responsavel", aluno.NomeResponsavel),
            new MySqlParameter("@status", true), 
            new MySqlParameter("@assinatura_aluno", aluno.Assinatura),
            new MySqlParameter("@id_modalidade", aluno.IdModalidade)
                };

                int idAluno = Convert.ToInt32(_databaseService.ExecuteScalar(queryAluno, parametrosAluno, transaction));

                string queryPagamento = @"
            INSERT INTO pagamento (
                id_aluno, 
                status_pagamento, 
                data_pagamento)
            VALUES (
                @id_aluno, 
                false, -- Status inicial como pendente
                NULL)"; 

                var parametrosPagamento = new MySqlParameter[]
                {
            new MySqlParameter("@id_aluno", idAluno)
                };

                _databaseService.ExecuteNonQuery(queryPagamento, parametrosPagamento, transaction);

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Erro ao cadastrar aluno e registro de pagamento: " + ex.Message);
            }
            finally
            {
                _databaseService.CloseConnection();
            }
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
                new MySql.Data.MySqlClient.MySqlParameter("@status", aluno.StatusAluno),
                new MySql.Data.MySqlClient.MySqlParameter("@assinatura_aluno", aluno.Assinatura),
                new MySql.Data.MySqlClient.MySqlParameter("@id", aluno.Id)
            };

            return _databaseService.ExecuteNonQuery(query, parametros) > 0;
        }

        public List<Model.Aluno> BuscarTodos(int idModalidade)
        {
            var listaAlunos = new List<Model.Aluno>();

            string query = "SELECT * FROM aluno WHERE id_modalidade = @idModalidade";

            _databaseService.OpenConnection();
            try
            {
                using (var cmd = new MySqlCommand(query, _databaseService.Connection))
                {
                    cmd.Parameters.AddWithValue("@idModalidade", idModalidade); 

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var aluno = new Model.Aluno
                            {
                                Id = Convert.ToInt32(reader["id_aluno"]),
                                Nome = reader["nome"].ToString(),
                                Idade = Convert.ToInt32(reader["idade"]),
                                Telefone = reader["telefone"].ToString(),
                                NomeResponsavel = reader["responsavel"].ToString(),
                                DataEntrada = Convert.ToDateTime(reader["data_entrada"]),
                                DataSaida = reader["data_saida"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(reader["data_saida"]) : null,
                                StatusAluno = Convert.ToBoolean(reader["status_aluno"]),
                                Assinatura = reader["assinatura_aluno"].ToString(),
                                IdModalidade = Convert.ToInt32(reader["id_modalidade"]),
                            };
                            listaAlunos.Add(aluno);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Erro ao buscar alunos.", ex);
            }
            finally
            {
                _databaseService.CloseConnection();
            }

            return listaAlunos;
        }
    }
}