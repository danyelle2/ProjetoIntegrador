using MySql.Data.MySqlClient;
using ProjetoIntegrador.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoIntegrador.Model;


namespace ProjetoIntegrador.Controller.Aluno
{
    public class AlunoRepositorio
    {
        
            private readonly DatabaseService _databaseService;

            public AlunoRepositorio(DatabaseService databaseService)
            {
                _databaseService = databaseService;
            }

            public Dictionary<int, int> ObterEntradasPorMes(int ano)
            {
                string query = @"SELECT MONTH(data_entrada) AS Mes, COUNT(*) AS Quantidade
                             FROM aluno
                             WHERE YEAR(data_entrada) = @Ano AND status_aluno = 1
                             GROUP BY MONTH(data_entrada)";

                var parametros = new MySqlParameter[]
                {
                new MySqlParameter("@Ano", ano)
                };

                var resultado = new Dictionary<int, int>();

                using (var reader = _databaseService.ExecuteQuery(query, parametros))
                {
                    while (reader.Read())
                    {
                        int mes = Convert.ToInt32(reader["Mes"]);
                        int quantidade = Convert.ToInt32(reader["Quantidade"]);
                        resultado.Add(mes, quantidade);
                    }
                }

                return resultado;
            }

            public Dictionary<int, int> ObterSaidasPorMes(int ano)
            {
                string query = @"SELECT MONTH(data_saida) AS Mes, COUNT(*) AS Quantidade
                             FROM aluno
                             WHERE YEAR(data_saida) = @Ano AND status_aluno = 0
                             GROUP BY MONTH(data_saida)";

                var parametros = new MySqlParameter[]
                {
                new MySqlParameter("@Ano", ano)
                };

                var resultado = new Dictionary<int, int>();

                using (var reader = _databaseService.ExecuteQuery(query, parametros))
                {
                    while (reader.Read())
                    {
                        int mes = Convert.ToInt32(reader["Mes"]);
                        int quantidade = Convert.ToInt32(reader["Quantidade"]);
                        resultado.Add(mes, quantidade);
                    }
                }

                return resultado;
            }
        }
    }


