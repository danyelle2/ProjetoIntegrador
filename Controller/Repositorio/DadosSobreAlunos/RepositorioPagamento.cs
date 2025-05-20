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

        public List<Pagamento> ObterPagamentosAtivos(int idModalidade)
        {
            var pagamentos = new List<Pagamento>();
            string query = @"
        SELECT
            p.id_pagamento,
            p.id_aluno,
            a.nome as Nome,
            a.responsavel as NomeResponsavel, 
            p.status_pagamento as StatusPagamento,
            p.data_pagamento as DataPagamento
        FROM
            pagamento p
        INNER JOIN
            aluno a ON a.id_aluno = p.id_aluno
        INNER JOIN
            modalidade u ON u.id_modalidade = a.id_modalidade
        WHERE
            a.status_aluno = 1 AND u.id_modalidade = @idModalidade";

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
                            var pagamento = new Pagamento
                            {
                                IdPagamento = Convert.ToInt32(reader["id_pagamento"]),
                                IdAluno = Convert.ToInt32(reader["id_aluno"]),
                                Nome = reader["Nome"].ToString(), 
                                NomeResponsavel = reader["NomeResponsavel"].ToString(),
                                StatusPagamento = Convert.ToBoolean(reader["StatusPagamento"]),
                                DataPagamento = reader["DataPagamento"] != DBNull.Value ?
                                                (DateTime?)Convert.ToDateTime(reader["DataPagamento"]) : null
                            };
                            pagamentos.Add(pagamento);
                        }
                    }
                }
            }
            finally
            {
                _databaseService.CloseConnection();
            }

            return pagamentos;
        }

        public void AtualizarPagamento(int idAluno, bool statusPagamento)
        {
            string query = @"
        UPDATE pagamento 
        SET status_pagamento = @statusPagamento,
            data_pagamento = @dataPagamento
        WHERE id_aluno = @idAluno;
    ";
            object dataPagamento;
            if (statusPagamento)
            {
                dataPagamento = DateTime.Now;
            }
            else
            {
                dataPagamento = DBNull.Value;
            }

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@statusPagamento", statusPagamento),
        new MySqlParameter("@dataPagamento", dataPagamento),
        new MySqlParameter("@idAluno", idAluno)
    };

            _databaseService.ExecuteNonQuery(query, parameters);
        }
    }
    }
