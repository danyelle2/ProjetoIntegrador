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

        public TelaPagamentoAlunos()
        {
            InitializeComponent();
            DatabaseService dbService = new DatabaseService(); 
            alunoController = new RepositorioPagamento(dbService); 
        }

        private void TelaPagamentoAlunos_Load(object sender, EventArgs e)
        {
            CarregarAlunos();   
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
                }
            };
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
            // Tenho que Atualizar o status de pagamento para 'false'  no banco de dados
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
