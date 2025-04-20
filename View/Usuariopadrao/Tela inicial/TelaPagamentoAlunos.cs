using ProjetoIntegrador.BancoDeDados;
using ProjetoIntegrador.Controller.Aluno;
using ProjetoIntegrador.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoIntegrador.View.Usuariopadrao.Tela_inicial
{
    public partial class TelaPagamentoAlunos : Form
    {
        private RepositorioPagamento alunoController;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer(); 

        public TelaPagamentoAlunos()
        {
            InitializeComponent();
            DatabaseService dbService = new DatabaseService();
            alunoController = new RepositorioPagamento(dbService);
        }

        private void TelaPagamentoAlunos_Load(object sender, EventArgs e)
        {
            CarregarAlunos();
            ConfigurarTimerParaDiaEspecifico(15);  
        }

        private void CarregarAlunos()
        {
            List<Aluno> alunosAtivos = alunoController.AlunosAtivos();
            dataGridViewpagamento.DataSource = alunosAtivos;

            dataGridViewpagamento.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex >= 0 && dataGridViewpagamento.Columns[ev.ColumnIndex].Name == "StatusPagamento")
                {
                    bool statusPagamento = (bool)dataGridViewpagamento.Rows[ev.RowIndex].Cells[ev.ColumnIndex].Value;
                    ev.CellStyle.BackColor = statusPagamento ? System.Drawing.Color.Green : System.Drawing.Color.Red;
                    ev.CellStyle.ForeColor = System.Drawing.Color.White; 
                    //Ve se fica bom com branco!!!!!!!!!!!!!!!!!!!!!!!!
                }
            };
        }

        private void ConfigurarTimerParaDiaEspecifico(int dia)
        {
            DateTime hoje = DateTime.Now;

            DateTime proximoDia = new DateTime(hoje.Year, hoje.Month, dia);

            if (hoje.Date > proximoDia.Date)
            {
                proximoDia = proximoDia.AddMonths(1);  
            }

            TimeSpan intervalo = proximoDia - hoje;

            timer.Interval = (int)intervalo.TotalMilliseconds;
            timer.Tick += Timer_Tick; 
            timer.Start(); 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            CarregarAlunos();
            MessageBox.Show("Lista de pagamentos atualizada!");
        }

        private void buttonPagamentoRealizado_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewpagamento.SelectedRows)
            {
                var aluno = (Aluno)row.DataBoundItem;
                alunoController.AtualizarStatusPagamento(aluno.Id, true); 
            }

            CarregarAlunos();
        }

        private void buttonPendentePagamento_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewpagamento.SelectedRows)
            {
                var aluno = (Aluno)row.DataBoundItem;
                alunoController.AtualizarStatusPagamento(aluno.Id, false);  
            }

            CarregarAlunos();
        }

        private void dataGridViewpagamento_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var aluno = (Aluno)dataGridViewpagamento.Rows[e.RowIndex].DataBoundItem;
                MessageBox.Show($"Aluno selecionado: {aluno.Nome}, Status de Pagamento: {(aluno.StatusPagamento ? "Realizado" : "Pendente")}");
            }
        }
    }
}
