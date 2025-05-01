using ProjetoIntegrador.Controller.Aluno;
using ProjetoIntegrador.Controller.Repositorio;
using ProjetoIntegrador.Model;
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
        private readonly int _idModalidade;

        public TelaPagamentoAlunos(int idModalidade)
        {
            InitializeComponent();
            _idModalidade = idModalidade;

            _repositorioPagamento = new RepositorioPagamento(new DatabaseService());
        }

        private void TelaPagamentoAlunos_Load(object sender, EventArgs e)
        {
            dataGridViewpagamento.BackgroundColor = Color.Gray;

            dataGridViewpagamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CarregarPagamentos();
        }

        private void CarregarPagamentos()
        {
            var pagamentos = _repositorioPagamento.ObterPagamentosAtivos(_idModalidade);
            if (pagamentos != null)
            {
                dataGridViewpagamento.DataSource = pagamentos;
                ConfigurarColunasPagamento();
            }
        }

        private void ConfigurarColunasPagamento()
        {
            if (dataGridViewpagamento.Columns.Contains("IdPagamento"))
            {
                dataGridViewpagamento.Columns["IdPagamento"].Visible = false;
            }

            if (dataGridViewpagamento.Columns.Contains("IdAluno"))
            {
                dataGridViewpagamento.Columns["IdAluno"].HeaderText = "ID";
                dataGridViewpagamento.Columns["IdAluno"].Width = 40; 
            }
            if (dataGridViewpagamento.Columns.Contains("NomeAluno"))
            {
                dataGridViewpagamento.Columns["NomeAluno"].HeaderText = "Nome";
            }


            if (dataGridViewpagamento.Columns.Contains("StatusPagamento"))
            {
                dataGridViewpagamento.Columns["StatusPagamento"].HeaderText = "Status do Pagamento";
                dataGridViewpagamento.Columns["StatusPagamento"].Width = 150;
            }

            if (dataGridViewpagamento.Columns.Contains("DataPagamento"))
            {
                dataGridViewpagamento.Columns["DataPagamento"].HeaderText = "Data do Pagamento";
                dataGridViewpagamento.Columns["DataPagamento"].Width = 150;
            }
        }


        private void AplicarFormatoStatusPagamento()
        {
            foreach (DataGridViewRow row in dataGridViewpagamento.Rows)
            {
                if (row.Cells["StatusPagamento"]?.Value is bool statusPagamento)

                {
                    row.Cells["StatusPagamento"].Style.BackColor = statusPagamento ? Color.DarkBlue : Color.LightCoral;
                    row.Cells["StatusPagamento"].Style.ForeColor = Color.DarkMagenta;
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
                    _repositorioPagamento.AtualizarPagamento(idAluno, true);
                }
            }

            CarregarPagamentos();
        }

        private void buttonPendentePagamento_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewpagamento.SelectedRows)
            {
                if (row.Cells["Id"].Value != null)
                {
                    int idAluno = Convert.ToInt32(row.Cells["Id"].Value);
                    _repositorioPagamento.AtualizarPagamento(idAluno, false);
                }
            }

            CarregarPagamentos();
        }

        private void dataGridViewpagamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
