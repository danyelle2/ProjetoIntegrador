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
            //colocar janela como pagina e tirar o dialog ok
            //Amanda fazer o visual dela e do cadastro de professores 
            // não sei se coloca nessa tela ou abre um controller para ela 
            //teste se funcionar fazer a mesma coisa só que com ano

            var movimentacoes = new List<EntradaSaidaAlunos>
        {
            new EntradaSaidaAlunos { Mes = "Jan", Entrada = 0, Saida = 0 },
            new EntradaSaidaAlunos { Mes = "Fev", Entrada = 6, Saida = 1 },
            new EntradaSaidaAlunos { Mes = "Mar", Entrada = 7, Saida = 1 },
            new EntradaSaidaAlunos { Mes = "Abr", Entrada = 2, Saida = 5 },
            new EntradaSaidaAlunos { Mes = "Mai", Entrada = 9, Saida = 0 },
            new EntradaSaidaAlunos { Mes = "Jun", Entrada = 0, Saida = 0 },
            new EntradaSaidaAlunos { Mes = "Jul", Entrada = 0, Saida = 0 },
            new EntradaSaidaAlunos   { Mes = "Ago", Entrada = 0, Saida = 0 },
            new EntradaSaidaAlunos { Mes = "Set", Entrada = 0, Saida = 0 },
            new EntradaSaidaAlunos { Mes = "Out", Entrada = 0, Saida = 0 },
            new EntradaSaidaAlunos { Mes = "Nov", Entrada = 0, Saida = 0 },
            new EntradaSaidaAlunos { Mes = "Dez", Entrada = 0, Saida = 0 }
        };
            chart1.Series.Clear();
            var Entrada = new Series("Entradas")
            {
                ChartType = SeriesChartType.Column, 
                Color = Color.Green, 
                BorderWidth = 3
            };
            // qualquer coisa mudar a cor do gráfico colocar um azul não sei perguntar pro grupo. 
             
            var Saida = new Series("Saídas")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Red, 
                BorderWidth = 3
            };

            foreach (var movimentacao in movimentacoes)
            {
                Entrada.Points.AddXY(movimentacao.Mes, movimentacao.Entrada);
                Saida.Points.AddXY(movimentacao.Mes, movimentacao.Saida);
            }
            chart1.Series.Add(Entrada);
            chart1.Series.Add(Saida);
            chart1.Titles.Add("Entrada e Saída de Alunos por Mês"); //pensar num texto melhor, mensal
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
