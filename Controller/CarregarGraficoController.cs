using ProjetoIntegrador.Controller.Aluno;
using ProjetoIntegrador.Model;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjetoIntegrador.Controller
{
    public class CarregarGraficoController
    {
        public void CarregarGraficoMensal(RepositorioGrafico repositorio, Chart chart, ProjetoIntegrador.Model.Usuario usuario)
        {
            var dadosMensais = repositorio.ObterMovimentacaoPorMes(usuario.Modalidade);

            chart.Series.Clear();

            var entrada = new Series("Entradas")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Green,
                BorderWidth = 2
            };

            var saida = new Series("Saídas")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Red,
                BorderWidth = 2
            };

            for (int mes = 1; mes <= 12; mes++)
            {
                string nomeMes = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mes);

                int valorEntrada = dadosMensais.ContainsKey(mes) ? dadosMensais[mes].Entradas : 0;
                int valorSaida = dadosMensais.ContainsKey(mes) ? dadosMensais[mes].Saidas : 0;

                entrada.Points.AddXY(nomeMes, valorEntrada);
                saida.Points.AddXY(nomeMes, valorSaida);
            }

            chart.Series.Add(entrada);
            chart.Series.Add(saida);
            chart.Titles.Clear();
            chart.Titles.Add("Movimentação Mensal");
        }

        public void CarregarGraficoAnual(RepositorioGrafico repositorio, Chart chart, Model.Usuario usuario)
        {
            var dadosAnuais = repositorio.ObterMovimentacaoPorAno(usuario.Modalidade);

            chart.Series.Clear();

            var entrada = new Series("Entradas")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Blue,
                BorderWidth = 2
            };

            var saida = new Series("Saídas")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Orange,
                BorderWidth = 2
            };

            foreach (var ano in dadosAnuais.Keys)
            {
                entrada.Points.AddXY(ano, dadosAnuais[ano].Entradas);
                saida.Points.AddXY(ano, dadosAnuais[ano].Saidas);
            }

            chart.Series.Add(entrada);
            chart.Series.Add(saida);
            chart.Titles.Clear();
            chart.Titles.Add("Movimentação Anual");
        }
    }
}
