using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ProjetoIntegrador.Model;
using ProjetoIntegrador.Services;
using ModelAluno = ProjetoIntegrador.Model.Aluno;
using ModelModalidade = ProjetoIntegrador.Model.Modalidade;

namespace ProjetoIntegrador.Controller.Repositorio
{
    internal class RepositorioPagamento
    {
        private readonly DatabaseService _databaseService;

        public RepositorioPagamento(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public List<ModelAluno> AlunosAtivos(int idModalidade)
        {
            List<ModelAluno> lista = new List<ModelAluno>();

            string query = @"
        SELECT a.id_aluno, a.nome, a.status_aluno, a.status_pagamento 
        FROM aluno a
        INNER JOIN usuario u ON a.id_usuario = u.id_usuario
        WHERE a.status_aluno = 1 AND u.id_modalidade = @idModalidade;
    ";

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@idModalidade", IdModalidade),
    };

            using (MySqlDataReader reader = _databaseService.ExecuteQuery(query, parameters))
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
                UPDATE aluno 
                SET status_pagamento = @status 
                WHERE id_aluno = @idAluno;
            ";

            MySqlParameter[] parameters =
            {
                new MySqlParameter("@status", statusPagamento),
                new MySqlParameter("@idAluno", idAluno),
            };

            _databaseService.ExecuteNonQuery(query, parameters);
        }
    }
}
