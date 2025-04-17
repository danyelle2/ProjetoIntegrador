using MySql.Data.MySqlClient;
using ProjetoIntegrador.BancoDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Controller.Aluno
{
    public class RepositorioGrafico
    {

        private readonly DatabaseService _databaseService;

        public RepositorioGrafico(DatabaseService databaseService)
        {//banco ligação NÃO esquecer _databaseService = databaseService;
            _databaseService = databaseService;
        }

        public Dictionary<int, int> ObterEntradasPorMes()
        {
            var resultado = new Dictionary<int, int>();
            string query = "SELECT MONTH(data_entrada) AS mes, COUNT(*) AS entradas FROM aluno WHERE YEAR(data_entrada) = YEAR(CURDATE()) GROUP BY MONTH(data_entrada)";

            using (var reader = _databaseService.ExecuteQuery(query))
            {
                while (reader.Read())
                {
                    int mes = Convert.ToInt32(reader["mes"]);
                    int entradas = Convert.ToInt32(reader["entradas"]);
                    resultado[mes] = entradas;
                }
            }
            return resultado;
        }

        public Dictionary<int, int> ObterSaidasPorMes()
        {
            var resultado = new Dictionary<int, int>();
            string query = "SELECT MONTH(data_saida) AS mes, COUNT(*) AS saidas FROM aluno WHERE data_saida IS NOT NULL AND YEAR(data_saida) = YEAR(CURDATE()) GROUP BY MONTH(data_saida)";

            using (var reader = _databaseService.ExecuteQuery(query))
            {
                while (reader.Read())
                {
                    int mes = Convert.ToInt32(reader["mes"]);
                    int saidas = Convert.ToInt32(reader["saidas"]);
                    resultado[mes] = saidas;
                }
            }
            return resultado;
        }
        public Dictionary<int, (int Entradas, int Saidas)> ObterMovimentacaoPorMes(string modalidade)
        {
            var entradas = ObterEntradasPorMes();
            var saidas = ObterSaidasPorMes();

            var movimentacao = new Dictionary<int, (int Entradas, int Saidas)>();

            for (int mes = 1; mes <= 12; mes++)
            {
                int entrada = entradas.ContainsKey(mes) ? entradas[mes] : 0;
                int saida = saidas.ContainsKey(mes) ? saidas[mes] : 0;

                movimentacao[mes] = (entrada, saida);
            }

            return movimentacao;
        }



        public Dictionary<int, EntradaSaidaAlunos> ObterMovimentacaoPorAno(string modalidade)
        {
            if (string.IsNullOrWhiteSpace(modalidade))
            {
                throw new ArgumentException("O parâmetro 'modalidade' não pode ser nulo ou vazio.", nameof(modalidade));
            }

            var resultado = new Dictionary<int, EntradaSaidaAlunos>();

            _databaseService.OpenConnection(); 
            try
            {
                string query = @"
            SELECT YEAR(data_entrada) AS Ano, 
                   COUNT(CASE WHEN data_entrada IS NOT NULL THEN 1 END) AS Entradas,
                   COUNT(CASE WHEN data_saida IS NOT NULL THEN 1 END) AS Saidas
            FROM aluno
            WHERE modalidade = @modalidade
            GROUP BY YEAR(data_entrada)
            ORDER BY Ano";

                using (var cmd = new MySqlCommand(query, _databaseService.Connection)) 
                {
                    cmd.Parameters.AddWithValue("@modalidade", modalidade);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int ano = reader.GetInt32("Ano");

                            var movimentacao = new EntradaSaidaAlunos
                            {
                                Entradas = reader.GetInt32("Entradas"),
                                Saidas = reader.GetInt32("Saidas")
                            };

                            resultado[ano] = movimentacao;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Erro ao obter movimentação por ano.", ex);
            }
            finally
            {
                _databaseService.CloseConnection(); 
            }

            return resultado;
        }
    }
}