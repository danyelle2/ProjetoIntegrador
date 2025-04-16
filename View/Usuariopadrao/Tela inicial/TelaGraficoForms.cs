using ProjetoIntegrador.BancoDeDados;
using ProjetoIntegrador.Controller.Aluno;
using ProjetoIntegrador.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProjetoIntegrador.View
{
    public partial class TelaGraficoForms : Form
    {
        private Usuario usuario;

        public TelaGraficoForms(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }


        private void TelaGraficoForms_Load(object sender, EventArgs e)
        {
            var repositorio = new RepositorioGrafico(new DatabaseService());

            var dadosMensais = repositorio.ObterMovimentacaoPorMes();

            CarregarGraficoMensal(repositorio);
            CarregarGraficoAnual(repositorio);

            chart1.Series.Clear();

            var serieEntrada = new Series("Entradas")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Green,
                BorderWidth = 3
            };

            var serieSaida = new Series("Saídas")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Red,
                BorderWidth = 3
            };

            for (int mes = 1; mes <= 12; mes++)
            {
                string nomeMes = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(mes);

                int entrada = dadosMensais.ContainsKey(mes) ? dadosMensais[mes].Entradas : 0;
                int saida = dadosMensais.ContainsKey(mes) ? dadosMensais[mes].Saidas : 0;

                serieEntrada.Points.AddXY(nomeMes, entrada);
                serieSaida.Points.AddXY(nomeMes, saida);
            }

            chartSaidaAlunos.Series.Add(serieEntrada);
            chartSaidaAlunos.Series.Add(serieSaida);

            chartSaidaAlunos.Titles.Clear();
            chartSaidaAlunos.Titles.Add("Entradas e Saídas de Alunos por Mês");

            chartSaidaAlunos.ChartAreas[0].AxisX.Title = "Mês";
            chartSaidaAlunos.ChartAreas[0].AxisY.Title = "Quantidade de Alunos";
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TelaInicialForm telaInicial = new TelaInicialForm();
            telaInicial.Show();
        }

        private void chartSaidaAlunos_Click(object sender, EventArgs e)
        {

        }
    }
}
//nome do gráfico chartSaidaAlunos
