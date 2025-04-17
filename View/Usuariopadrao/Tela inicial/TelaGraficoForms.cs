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

        private void TelaGraficoForms_Load(object sender, EventArgs e)
        {
            var repositorio = new RepositorioGrafico(new DatabaseService());
            var controller = new CarregarGraficoController();

            controller.CarregarGraficoMensal(repositorio, chartSaidaAlunos, usuario);//colocar professor e não usuario
            controller.CarregarGraficoAnual(repositorio, chart1, usuario.Modalidade);
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

