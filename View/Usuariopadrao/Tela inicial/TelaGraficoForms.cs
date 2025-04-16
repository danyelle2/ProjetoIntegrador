using ProjetoIntegrador.BancoDeDados;
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
        public TelaGraficoForms()
        {
            InitializeComponent();
        }

        private void TelaGraficoForms_Load(object sender, EventArgs e)
        {
            var database = new DatabaseService();
            var repositorio = new AlunoRepositorio(database);

            var entradas = repositorio.ObterEntradasPorMes();
            var saidas = repositorio.ObterSaidasPorMes();

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

            string[] meses = { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" };

            for (int i = 1; i <= 12; i++)
            {
                int entrada = entradas.ContainsKey(i) ? entradas[i] : 0;
                int saida = saidas.ContainsKey(i) ? saidas[i] : 0;

                serieEntrada.Points.AddXY(meses[i - 1], entrada);
                serieSaida.Points.AddXY(meses[i - 1], saida);
            }

            chart1.Series.Add(serieEntrada);
            chart1.Series.Add(serieSaida);
            chart1.Titles.Add("Entrada e Saída de Alunos por Mês");
            chart1.ChartAreas[0].AxisX.Title = "Mês";
            chart1.ChartAreas[0].AxisY.Title = "Número de Alunos";
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TelaInicialForm telaInicial = new TelaInicialForm();
            telaInicial.Show();
        }
    }
}
