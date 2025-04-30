using MySql.Data.MySqlClient;
using ProjetoIntegrador.Model;
using ProjetoIntegrador.Services;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegrador.Controller.Aluno
{
    public class RepositorioGrafico //função de adm e professor visualizar a tela ok !!!
    {

        private readonly DatabaseService _databaseService;

        public RepositorioGrafico(DatabaseService databaseService)
        {//banco ligação NÃO esquecer _databaseService = databaseService;
            _databaseService = databaseService;
        }

        public Dictionary<int, int> ObterEntradasPorMes(int idModalidade)
        {
            var resultado = new Dictionary<int, int>();
            string query = @"SELECT MONTH(a.data_entrada) AS mes, COUNT(*) AS entradas  
                     FROM aluno a 
                     JOIN usuario u ON a.id_usuario = u.id_usuario 
                     JOIN modalidade m ON u.id_modalidade = m.id_modalidade 
                     WHERE YEAR(a.data_entrada) = YEAR(CURDATE()) 
                       AND m.id_modalidade = @id_modalidade
                     GROUP BY MONTH(a.data_entrada)";

            using (var cmd = new MySqlCommand(query, _databaseService.Connection))
            {
                cmd.Parameters.AddWithValue("@modalidade", idModalidade);
                _databaseService.OpenConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int mes = Convert.ToInt32(reader["mes"]);
                        int entradas = Convert.ToInt32(reader["entradas"]);
                        resultado[mes] = entradas;
                    }
                }
                _databaseService.CloseConnection();
            }

            return resultado;
        }


        public Dictionary<int, int> ObterSaidasPorMes(int idModalidade)
        {
            var resultado = new Dictionary<int, int>();

            string query = @"
        SELECT MONTH(a.data_saida) AS mes, COUNT(*) AS saidas 
        FROM aluno a 
        JOIN usuario u ON a.id_usuario = u.id_usuario 
        JOIN modalidade m ON u.id_modalidade = m.id_modalidade 
        WHERE a.data_saida IS NOT NULL 
          AND YEAR(a.data_saida) = YEAR(CURDATE())
          AND m.id_modalidade = @id_modalidade
        GROUP BY MONTH(a.data_saida)";

            using (var cmd = new MySqlCommand(query, _databaseService.Connection))
            {
                cmd.Parameters.AddWithValue("@id_modalidade", idModalidade);

                _databaseService.OpenConnection();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int mes = Convert.ToInt32(reader["mes"]);
                        int saidas = Convert.ToInt32(reader["saidas"]);
                        resultado[mes] = saidas;
                    }
                }
                _databaseService.CloseConnection();
            }

            return resultado;
        }

        public Dictionary<int, (int Entradas, int Saidas)> ObterMovimentacaoPorMes(int idModalidade)
        {
            var entradas = ObterEntradasPorMes(idModalidade);
            var saidas = ObterSaidasPorMes(idModalidade);

            var movimentacao = new Dictionary<int, (int Entradas, int Saidas)>();

            for (int mes = 1; mes <= 12; mes++)
            {
                int entrada = entradas.ContainsKey(mes) ? entradas[mes] : 0;
                int saida = saidas.ContainsKey(mes) ? saidas[mes] : 0;

                movimentacao[mes] = (entrada, saida);
            }

            return movimentacao;
        }


        public Dictionary<int, EntradaSaidaAlunos> ObterMovimentacaoPorAno(int idModalidade, int? anoInicial = null, int? anoFinal = null)
        {
            var resultado = new Dictionary<int, EntradaSaidaAlunos>();

            _databaseService.OpenConnection();
            try
            {
                string query = @"
            SELECT 
                YEAR(a.data_entrada) AS Ano,
                COUNT(CASE WHEN a.data_entrada IS NOT NULL THEN 1 END) AS Entradas,
                COUNT(CASE WHEN a.data_saida IS NOT NULL THEN 1 END) AS Saidas
            FROM aluno a
            JOIN usuario u ON a.id_usuario = u.id_usuario
            JOIN modalidade m ON u.id_modalidade = m.id_modalidade
            WHERE m.id_modalidade = @id_modalidade";

                if (anoInicial.HasValue)
                    query += " AND YEAR(a.data_entrada) >= @anoInicial ";

                if (anoFinal.HasValue)
                    query += " AND YEAR(a.data_entrada) <= @anoFinal ";

                query += " GROUP BY YEAR(a.data_entrada) ORDER BY Ano";

                using (var cmd = new MySqlCommand(query, _databaseService.Connection))
                {
                    cmd.Parameters.AddWithValue("@id_modalidade", idModalidade);
                    if (anoInicial.HasValue)
                        cmd.Parameters.AddWithValue("@anoInicial", anoInicial);
                    if (anoFinal.HasValue)
                        cmd.Parameters.AddWithValue("@anoFinal", anoFinal);

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