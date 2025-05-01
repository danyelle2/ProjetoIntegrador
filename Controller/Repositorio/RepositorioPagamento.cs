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
            List<Pagamento> listaPagamentos = new List<Pagamento>();

            string query = @"
        SELECT p.id_pagamento, p.id_aluno, p.status_pagamento, p.data_pagamento
        FROM pagamento p
        INNER JOIN aluno a ON a.id_aluno = p.id_aluno
        INNER JOIN modalidade u ON u.id_modalidade = a.id_modalidade
        WHERE a.status_aluno = 1 AND u.id_modalidade = @idModalidade;
    ";

            MySqlParameter[] parameters =
            {
        new MySqlParameter("@idModalidade", idModalidade)
    };

            using (MySqlDataReader reader = _databaseService.ExecuteQuery(query, parameters))
            {
                while (reader.Read())
                {
                    listaPagamentos.Add(new Pagamento
                    {
                        IdPagamento = reader.GetInt32("id_pagamento"),
                        IdAluno = reader.GetInt32("id_aluno"),
                        StatusPagamento = reader.GetBoolean("status_pagamento"),
                        DataPagamento = reader.IsDBNull(reader.GetOrdinal("data_pagamento")) ? (DateTime?)null : reader.GetDateTime("data_pagamento")
                    });
                }
            }

            return listaPagamentos;
        }



        public void AtualizarPagamento(int idAluno, bool statusPagamento)
        {
            string query = @"
        UPDATE pagamento 
        SET status_pagamento = @statusPagamento,
            data_pagamento = @dataPagamento
        WHERE id_aluno = @idAluno;
    ";
            //VER SE DA CERTO COM CONDICIONAL 
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
