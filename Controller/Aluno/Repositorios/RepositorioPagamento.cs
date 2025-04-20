using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ProjetoIntegrador.BancoDeDados;
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
            List<ModelAluno> lista = new List<ModelAluno>();
            string query = "SELECT id_aluno, nome, status_aluno, status_pagamento FROM aluno WHERE status_aluno = 1";

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
            string query = "UPDATE aluno SET status_pagamento = @status WHERE id_aluno = @id";
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@status", statusPagamento),
                new MySqlParameter("@id", idAluno)
            };

            _databaseService.ExecuteNonQuery(query, parameters);
        }


    }
}
