using ProjetoIntegrador.Controller.Aluno;
using ProjetoIntegrador.Controller.Repositorio;
using ProjetoIntegrador.Services;
using System;
using System.Data;
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
            dataGridViewpagamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarregarAlunos();
        }

        private void CarregarAlunos()
        {
            var alunosAtivos = _repositorioPagamento.AlunosAtivos();
            // fiz com ajuda!!
            if (alunosAtivos != null)
            {
                dataGridViewpagamento.DataSource = alunosAtivos;

                ConfigurarColunas();

                AplicarFormatoStatusPagamento();
            }
        }

        private void ConfigurarColunas()
        {
            if (dataGridViewpagamento.Columns.Contains("Id"))
            {
                dataGridViewpagamento.Columns["Id"].Visible = false; // Esconde o Id
            }

            if (dataGridViewpagamento.Columns.Contains("Nome"))
            {
                dataGridViewpagamento.Columns["Nome"].HeaderText = "Nome do Aluno";
                dataGridViewpagamento.Columns["Nome"].Width = 200;
            }

            if (dataGridViewpagamento.Columns.Contains("StatusPagamento"))
            {
                dataGridViewpagamento.Columns["StatusPagamento"].HeaderText = "Pagamento Realizado?";
                dataGridViewpagamento.Columns["StatusPagamento"].Width = 150;
            }
        }

        private void AplicarFormatoStatusPagamento()
        {
            foreach (DataGridViewRow row in dataGridViewpagamento.Rows)
            {
                if (row.Cells["StatusPagamento"].Value != null &&
                    bool.TryParse(row.Cells["StatusPagamento"].Value.ToString(), out bool statusPagamento))
                {
                    row.Cells["StatusPagamento"].Style.BackColor = statusPagamento ? Color.LightGreen : Color.LightCoral;
                    row.Cells["StatusPagamento"].Style.ForeColor = Color.Black;
                }
            }
        }

        private void buttonPagamentoRealizado_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewpagamento.SelectedRows)
            {
                if (row.Cells["Id"].Value != null)
                {
                    int idAluno = Convert.ToInt32(row.Cells["Id"].Value);
                    _repositorioPagamento.AtualizarStatusPagamento(idAluno, true);
                }
            }

            CarregarAlunos();
        }

        private void buttonPendentePagamento_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewpagamento.SelectedRows)
            {
                if (row.Cells["Id"].Value != null)
                {
                    int idAluno = Convert.ToInt32(row.Cells["Id"].Value);
                    _repositorioPagamento.AtualizarStatusPagamento(idAluno, false);
                }
            }

            CarregarAlunos();
        }
    }
}
