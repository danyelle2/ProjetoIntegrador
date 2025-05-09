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
        private TelaInicialForm telaInicialForm;//teste 

        private readonly RepositorioPagamento _repositorioPagamento;
        private readonly int _idModalidade;
        private Aluno alunoSelecionado;

        public TelaPagamentoAlunos(int idModalidade)
        {
            InitializeComponent();
            telaInicialForm= new TelaInicialForm(idModalidade);
            this.FormClosing += TelaPagamentoAlunos_FormClosing;//teste

            _idModalidade = idModalidade;
            _repositorioPagamento = new RepositorioPagamento(new DatabaseService());

            dataGridViewpagamento.DataError += dataGridViewpagamento_DataError;
        }
       
        private void TelaPagamentoAlunos_FormClosing(object sender, FormClosingEventArgs e)  //teste por em todos
        {
            e.Cancel = true;                       

            telaInicialForm.Show();
            this.Hide();
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

                ConfigurarColunasPagamento();

                dataGridViewpagamento.DataSource = pagamentos;

                AplicarFormatacaoCondicional();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar pagamentos: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AplicarFormatacaoCondicional()
        {
            foreach (DataGridViewRow row in dataGridViewpagamento.Rows)
            {
                if (row.Cells["StatusPagamento"].Value != null)
                {
                    bool status = row.Cells["StatusPagamento"].Value.ToString() == "Pago";
                    row.Cells["StatusPagamento"].Style.BackColor = status ? Color.LightGreen : Color.LightCoral;
                    row.Cells["StatusPagamento"].Style.ForeColor = Color.Black;
                }
            }
        }

        private void dataGridViewpagamento_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true; 
        }

        private void ConfigurarColunasPagamento()
        {
            dataGridViewpagamento.AutoGenerateColumns = false;
            dataGridViewpagamento.Columns.Clear();

            dataGridViewpagamento.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IdAluno",
                HeaderText = "ID",
                Name = "IdAluno",
                Width = 50
            });

            dataGridViewpagamento.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome",
                Name = "Nome",
                Width = 200
            });

            dataGridViewpagamento.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StatusPagamentoTexto",
                HeaderText = "Status",
                Name = "StatusPagamento",
                Width = 80
            });

            dataGridViewpagamento.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataPagamento",
                HeaderText = "Data Pagamento",
                Name = "DataPagamento",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy",
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    NullValue = " - "
                }
            });

            dataGridViewpagamento.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NomeResponsavel",
                HeaderText = "Responsável",
                Name = "Responsavel",
                Width = 150
            });
        }

        private void buttonPagamentoRealizado_Click(object sender, EventArgs e)
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
                        int idAluno = Convert.ToInt32(row.Cells["IdAluno"].Value); // Corrigido o nome da coluna
                        _repositorioPagamento.AtualizarPagamento(idAluno, false);
                    }
                }

                CarregarPagamentos();
                MessageBox.Show("StatusPagamento alterado para pendente com sucesso!", "Sucesso",
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
                        .Where(p => p.Nome.ToLower().Contains(filtro))
                        .ToList();

                    dataGridViewpagamento.DataSource = pagamentosFiltrados;
                    AplicarFormatacaoCondicional();
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
                };
            }
        }
    }
}