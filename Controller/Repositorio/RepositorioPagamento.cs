using System;
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
        SELECT a.id_aluno, a.nome, a.status_aluno, p.status_pagamento
        FROM aluno a
        INNER JOIN pagamento p ON a.id_aluno = p.id_aluno
        INNER JOIN modalidade u ON u.id_modalidade = a.id_modalidade
        WHERE a.status_aluno = 1 AND p.status_pagamento = 0 AND u.id_modalidade = @idModalidade;
    ";

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@idModalidade", idModalidade)
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


        public void AtualizarStatusPagamento(int idPagamento, bool statusPagamento)
        {
            string query = @"
        UPDATE pagamento 
        SET status_pagamento = @status, 
            data_pagamento = @data
        WHERE id_pagamento = @idPagamento;
    ";

            var dataPagamento = statusPagamento ? DateTime.Now.Date : (object)DBNull.Value;

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@status", statusPagamento),
        new MySqlParameter("@data", dataPagamento),
        new MySqlParameter("@idPagamento", idPagamento),
    };

            _databaseService.ExecuteNonQuery(query, parameters);
        }
    }
    }
