using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using ProjetoIntegrador.Services;
using ModelAluno = ProjetoIntegrador.Model.Aluno;

namespace ProjetoIntegrador.Controller.Aluno
{
    internal class RepositorioPagamento
    {
        private readonly DatabaseService _databaseService;
        //"DatabaseService databaseService" é a conexão com o banco de dados
        public RepositorioPagamento(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }


        public List<ModelAluno> AlunosAtivos()
        {
            List<Model.Aluno> lista = new List<Model.Aluno>();
            string query = "SELECT * FROM aluno id_aluno, nome, status_aluno, status_pagamento WHERE status_aluno = 1";

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
            // coloquei now para atualizar com a data atual que a pessoa atualizou o pagamento
            string query = @"
        UPDATE pagamento 
        SET data_pagamento = NOW(), status_pagamento = @status 
        WHERE id_aluno = @idAluno";

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@status", statusPagamento),
        new MySqlParameter("@idAluno", idAluno),
    };

            _databaseService.ExecuteNonQuery(query, parameters);
        }

    }
}