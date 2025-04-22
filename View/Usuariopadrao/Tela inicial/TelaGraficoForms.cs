using ProjetoIntegrador.BancoDeDados;
using ProjetoIntegrador.Controller;
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

        public TelaGraficoForms()
        {
        }

        private void TelaGraficoForms_Load(object sender, EventArgs e)
        {

<<<<<<< HEAD
            var repositorio = new RepositorioGrafico(new DatabaseService());
            var controller = new CarregarGraficoController();
=======
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
                Color = Color.DarkBlue, 
                BorderWidth = 3
            };
            // qualquer coisa mudar a cor do gráfico colocar um azul não sei perguntar pro grupo. 
             
            var Saida = new Series("Saídas")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.PowderBlue, 
                BorderWidth = 3
            };
>>>>>>> origin/master

            controller.CarregarGraficoMensal(repositorio, chartSaidaAlunos, usuario);//sessionuser aqui vou mudar sessionUser.idmodalidade
            controller.CarregarGraficoAnual(repositorio, chart1, usuario);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TelaInicialForm telaInicial = new TelaInicialForm();
            telaInicial.Show();
        }

<<<<<<< HEAD
        private void chartSaidaAlunos_Click(object sender, EventArgs e)
        {
=======
        private void chart1_Click(object sender, EventArgs e)
        {

>>>>>>> origin/master
        }
    }
}

