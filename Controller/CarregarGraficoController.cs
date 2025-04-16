using ProjetoIntegrador.Controller.Aluno;
using ProjetoIntegrador.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjetoIntegrador.Controller
{
    public class CarregarGraficoController
    {
        public void CarregarGraficoMensal(RepositorioGrafico repositorio, Chart chart, Usuario usuario)
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
                string nomeMes = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mes);

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
    }
}
