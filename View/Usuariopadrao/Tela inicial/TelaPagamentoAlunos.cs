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
        private Aluno alunoSelecionado;

        public TelaPagamentoAlunos(int idModalidade)
        {
            InitializeComponent();
            _idModalidade = idModalidade;
            _repositorioPagamento = new RepositorioPagamento(new DatabaseService());

            dataGridViewpagamento.DataError += dataGridViewpagamento_DataError;
        }

        private void TelaPagamentoAlunos_Load(object sender, EventArgs e)
        {
            dataGridViewpagamento.BackgroundColor = Color.White;
            dataGridViewpagamento.ReadOnly = true;
            dataGridViewpagamento.AllowUserToAddRows = false;
            dataGridViewpagamento.AllowUserToDeleteRows = false;
            dataGridViewpagamento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            CarregarPagamentos();

        }

        private void CarregarPagamentos()
        {
            try
            {
                var pagamentos = _repositorioPagamento.ObterPagamentosAtivos(_idModalidade);

                if (pagamentos != null && pagamentos.Any())
                {
                    dataGridViewpagamento.DataSource = pagamentos;
                    ConfigurarColunasPagamento();
                }
                else
                {
                    MessageBox.Show("Nenhum aluno encontrado para esta modalidade.", "Informação",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar pagamentos: {ex.Message}", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridViewpagamento_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewpagamento.Columns["StatusPagamento"].Index)
            {
                e.ThrowException = false;
                MessageBox.Show("Erro ao processar status de pagamento", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ConfigurarColunasPagamento()
        {
            if (dataGridViewpagamento.Columns.Contains("StatusPagamento"))
            {
                dataGridViewpagamento.Columns["StatusPagamento"].CellTemplate = new DataGridViewTextBoxCell();

                foreach (DataGridViewRow row in dataGridViewpagamento.Rows)
                {
                    if (row.Cells["StatusPagamento"].Value != null)
                    {
                        bool status;
                        if (row.Cells["StatusPagamento"].Value is bool)
                        {
                            status = (bool)row.Cells["StatusPagamento"].Value;
                        }
                        else if (row.Cells["StatusPagamento"].Value is string strValue)
                        {
                            status = strValue == "Pago";
                        }
                        else
                        {
                            status = false; 
                        }

                        row.Cells["StatusPagamento"].Value = status ? "Pago" : "Pendente";
                        row.Cells["StatusPagamento"].Style.BackColor = status ? Color.LightGreen : Color.LightCoral;
                        row.Cells["StatusPagamento"].Style.ForeColor = Color.Black;
                    }
                }

                dataGridViewpagamento.Columns["StatusPagamento"].HeaderText = "Status";
                dataGridViewpagamento.Columns["StatusPagamento"].Width = 100;
            }

            if (dataGridViewpagamento.Columns.Contains("DataPagamento"))
            {
                dataGridViewpagamento.Columns["DataPagamento"].HeaderText = "Data";
                dataGridViewpagamento.Columns["DataPagamento"].Width = 100;
                dataGridViewpagamento.Columns["DataPagamento"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dataGridViewpagamento.Columns["DataPagamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
        private void buttonPagamentoRealizado_Click(object sender, EventArgs e)
        {
            if (dataGridViewpagamento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um aluno.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                foreach (DataGridViewRow row in dataGridViewpagamento.SelectedRows)
                {
                    if (row.Cells["IdAluno"].Value != null)
                    {
                        int idAluno = Convert.ToInt32(row.Cells["IdAluno"].Value);
                        _repositorioPagamento.AtualizarPagamento(idAluno, true);
                    }
                }

                CarregarPagamentos();
                MessageBox.Show("Pagamento(s) atualizado(s) com sucesso!", "Sucesso",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar pagamento: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPendentePagamento_Click(object sender, EventArgs e)
        {
            if (dataGridViewpagamento.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um aluno.", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                foreach (DataGridViewRow row in dataGridViewpagamento.SelectedRows)
                {
                    if (row.Cells["IdAluno"].Value != null)
                    {
                        int idAluno = Convert.ToInt32(row.Cells["IdAluno"].Value);
                        _repositorioPagamento.AtualizarPagamento(idAluno, false);
                    }
                }

                CarregarPagamentos();
                MessageBox.Show("Status alterado para pendente com sucesso!", "Sucesso",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar status: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1PesquisaPagamento_TextChanged(object sender, EventArgs e)
        {
            FiltrarAlunos();
        }

        private void FiltrarAlunos()
        {
            try
            {
                string filtro = textBox1PesquisaPagamento.Text.ToLower();
                var pagamentos = _repositorioPagamento.ObterPagamentosAtivos(_idModalidade);

                if (pagamentos != null)
                {
                    var pagamentosFiltrados = pagamentos
                        .Where(p => p.NomeAluno.ToLower().Contains(filtro))
                        .ToList();

                    dataGridViewpagamento.DataSource = pagamentosFiltrados;
                    ConfigurarColunasPagamento();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao filtrar alunos: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewpagamento_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewpagamento.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewpagamento.SelectedRows[0];
                alunoSelecionado = new Aluno
                {
                    Id = Convert.ToInt32(selectedRow.Cells["IdAluno"].Value),
                    Nome = selectedRow.Cells["NomeAluno"].Value.ToString(),
                    StatusPagamento = (bool)selectedRow.Cells["StatusPagamento"].Value
                };
            }
        }
    }
}