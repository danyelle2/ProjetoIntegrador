using ProjetoIntegrador.Controller.Aluno;
using ProjetoIntegrador.Model;
using ProjetoIntegrador.Services;
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
            string modalidade = SessionUser.userLogado.Modalidade;
            //colocar um if aqui para verificar se o usuário é admin ou não ai se for coloca

            var repositorio = new RepositorioGrafico(new DatabaseService());

            var movimentacoesMes = repositorio.ObterMovimentacaoPorMes(modalidade);

            chart1.Series.Clear();
            var entradaMes = new Series("Entradas")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.DarkBlue,
                BorderWidth = 3
            };

            var saidaMes = new Series("Saídas")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.PowderBlue,
                BorderWidth = 3
            };

            for (int mes = 1; mes <= 12; mes++)
            {
                if (movimentacoesMes.TryGetValue(mes, out var movimentacao))
                {
                    entradaMes.Points.AddXY(new DateTime(1, mes, 1).ToString("MMM"), movimentacao.Entradas);
                    saidaMes.Points.AddXY(new DateTime(1, mes, 1).ToString("MMM"), movimentacao.Saidas);
                }
                else
                {
                    entradaMes.Points.AddXY(new DateTime(1, mes, 1).ToString("MMM"), 0);
                    saidaMes.Points.AddXY(new DateTime(1, mes, 1).ToString("MMM"), 0);
                }
            }


                    chart1.Series.Add(entradaMes);
                chart1.Series.Add(saidaMes);
               chart1.Titles.Clear();
                    chart1.Titles.Add("Movimentação Mensal de Alunos");
               chart1.ChartAreas[0].AxisX.Title = "Mês";
                    chart1.ChartAreas[0].AxisY.Title = "Número de Alunos";

           
            var movimentacoesAno = repositorio.ObterMovimentacaoPorAno(modalidade);

            chart2.Series.Clear();
            var entradaAno = new Series("Entradas")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.BlueViolet,
                BorderWidth = 3
            };

            var saidaAno = new Series("Saídas")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.AliceBlue,
                BorderWidth = 3
            };

            for (int ano = 2020; ano <= DateTime.Now.Year; ano++)
            {
                if (movimentacoesAno.TryGetValue(ano, out var movimentacao))
                {
                    entradaAno.Points.AddXY(ano.ToString(), movimentacao.Entradas);
                    saidaAno.Points.AddXY(ano.ToString(), movimentacao.Saidas);
                }
                else
                {
                    entradaAno.Points.AddXY(ano.ToString(), 0);
                    saidaAno.Points.AddXY(ano.ToString(), 0);
                }
            }


            chart2.Series.Add(entradaAno);
            chart2.Series.Add(saidaAno);
            chart2.Titles.Clear();
            chart2.Titles.Add("Movimentação Anual de Alunos");
            chart2.ChartAreas[0].AxisX.Title = "Ano";
            chart2.ChartAreas[0].AxisY.Title = "Número de Alunos";
            }        


        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
