using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using ProjetoIntegrador.Services;
using ModelAluno = ProjetoIntegrador.Model.Aluno;

namespace ProjetoIntegrador.Controller.Repositorio
{
    internal class RepositorioPagamento
    {
        private readonly DatabaseService _databaseService;

        public RepositorioPagamento(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public List<ModelAluno> AlunosAtivos()
        {
            List<ModelAluno> lista = new List<ModelAluno>();

            string query = @"
                SELECT id_aluno, nome, status_aluno, status_pagamento 
                FROM aluno 
                WHERE status_aluno = 1"
            ;

            using (MySqlDataReader reader = _databaseService.ExecuteQuery(query))
            {
                while (reader.Read())
                {
                    lista.Add(new ModelAluno
                    {
                        Id = reader.GetInt32("id_aluno"),
                        Nome = reader.GetString("nome"),
                        StatusAtivo = reader.GetBoolean("status_aluno"),
                        StatusPagamento = reader.GetBoolean("status_pagamento")
                    });
                }
            }

            return lista;
        }

        public void AtualizarStatusPagamento(int idAluno, bool statusPagamento)
        {
            string query = @"
                UPDATE pagamento 
                SET data_pagamento = NOW(), status_pagamento = @status 
                WHERE id_aluno = @idAluno"
            ;

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@status", statusPagamento),
                new MySqlParameter("@idAluno", idAluno),
            };

            _databaseService.ExecuteNonQuery(query, parameters);
        }
    }
}
