using ProjetoIntegrador.Controller.Aluno;
using ProjetoIntegrador.Controller.Repositorio;
using ProjetoIntegrador.Model;
using ProjetoIntegrador.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoIntegrador.View.Usuariopadrao.Tela_inicial
{
    public partial class TelaPagamentoAlunos : Form
    {
        private readonly RepositorioPagamento _repositorioPagamento;

        public TelaPagamentoAlunos()
        {
            InitializeComponent();
            _repositorioPagamento = new RepositorioPagamento(new DatabaseService()); 
        }

        private void TelaPagamentoAlunos_Load(object sender, EventArgs e)
        {
            CarregarAlunos();

            List<Aluno> listaModalidades = RepositorioAluno.ListarAlunos();

            dataGridViewpagamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void CarregarAlunos()
        {
            var alunosAtivos = _repositorioPagamento.AlunosAtivos();
            dataGridViewpagamento.DataSource = alunosAtivos;

            AplicarFormatoStatusPagamento();
        }

        private void AplicarFormatoStatusPagamento()
        {
            foreach (DataGridViewRow row in dataGridViewpagamento.Rows)
            {
                if (row.Cells["StatusPagamento"].Value != null)
                {
                    bool statusPagamento = (bool)row.Cells["StatusPagamento"].Value;
                    row.Cells["StatusPagamento"].Style.BackColor = statusPagamento ? Color.Green : Color.Red;
                }
            }
        }

        private void buttonPagamentoRealizado_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewpagamento.SelectedRows)
            {
                var aluno = (Model.Aluno)row.DataBoundItem;
                _repositorioPagamento.AtualizarStatusPagamento(aluno.Id, true);
            }
            CarregarAlunos();
            }

        private void buttonPendentePagamento_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewpagamento.SelectedRows)
            {
                var aluno = (Model.Aluno)row.DataBoundItem;
                _repositorioPagamento.AtualizarStatusPagamento(aluno.Id, false);
            }
            CarregarAlunos(); 
        }
    }
}
