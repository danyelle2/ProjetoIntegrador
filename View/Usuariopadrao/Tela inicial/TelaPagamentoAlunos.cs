using ProjetoIntegrador.BancoDeDados;
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

namespace ProjetoIntegrador.View.Usuariopadrao.Tela_inicial
{
    public partial class TelaPagamentoAlunos : Form
    {
        public TelaPagamentoAlunos()
        {
            InitializeComponent();
            DatabaseService dbService = new DatabaseService(); 
            alunoController = new AlunoPagamentoController(dbService);
        }

        private void dataGridViewpagamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
            List<Aluno> alunos = new List<Aluno>
        {
           
        };

            var alunosAtivos = alunos.Where(a => a.StatusAtivo).ToList();

            dataGridViewpagamento.DataSource = alunosAtivos;

            foreach (DataGridViewRow row in dataGridViewpagamento.Rows)
            {
                bool statusPagamento = (bool)row.Cells["StatusPagamento"].Value;
                row.Cells["StatusPagamento"].Style.BackColor = statusPagamento ? Color.Green : Color.Red;
            }

            dataGridViewpagamento.DataSource = alunosAtivos;

            dataGridViewpagamento.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex >= 0 && dataGridViewpagamento.Columns[ev.ColumnIndex].Name == "StatusPagamento")
                {
                    bool statusPagamento = (bool)dataGridViewpagamento.Rows[ev.RowIndex].Cells[ev.ColumnIndex].Value;
                    ev.CellStyle.BackColor = statusPagamento ? Color.Green : Color.Red;
                }
            };
        }
        
        private void TelaPagamentoAlunos_Load(object sender, EventArgs e)
        {

        }

        private void buttonPagamentoRealizado_Click(object sender, EventArgs e)
        {
           
            foreach (DataGridViewRow row in dataGridViewpagamento.SelectedRows)
            {
                var aluno = (Aluno)row.DataBoundItem;
                aluno.StatusPagamento = true; 
            }
            dataGridViewpagamento.Refresh();

        }

        private void buttonPendentePagamento_Click(object sender, EventArgs e)
        {

            
            foreach (DataGridViewRow row in dataGridViewpagamento.SelectedRows)
            {
                var aluno = (Aluno)row.DataBoundItem;
                aluno.StatusPagamento = false;
            }
            dataGridViewpagamento.Refresh();
        }
    }
}
// Colocar para esse na tela do código caso não de certo.

//using ProjetoIntegrador.BancoDeDados;
//using ProjetoIntegrador.Controller.Aluno;
//using ProjetoIntegrador.Model;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Windows.Forms;

//namespace ProjetoIntegrador.View.Usuariopadrao.Tela_inicial
//{
//    public partial class TelaPagamentoAlunos : Form
//    {
//        private AlunoPagamentoController alunoController;

//        public TelaPagamentoAlunos()
//        {
//            InitializeComponent();
//            DatabaseService dbService = new DatabaseService(); // Conexão com o banco de dados
//            alunoController = new AlunoPagamentoController(dbService); // Instancia o controller
//        }

//        private void TelaPagamentoAlunos_Load(object sender, EventArgs e)
//        {
//            CarregarAlunos();  // Carregar os alunos ativos assim que a tela for carregada
//        }

//        private void CarregarAlunos()
//        {
//            // Obtém a lista de alunos ativos do banco de dados
//            List<Aluno> alunosAtivos = alunoController.AlunosAtivos();

//            // Define o DataSource do DataGridView com os alunos ativos
//            dataGridViewpagamento.DataSource = alunosAtivos;

//            // Formatação da célula para indicar o status do pagamento
//            dataGridViewpagamento.CellFormatting += (s, ev) =>
//            {
//                if (ev.RowIndex >= 0 && dataGridViewpagamento.Columns[ev.ColumnIndex].Name == "StatusPagamento")
//                {
//                    bool statusPagamento = (bool)dataGridViewpagamento.Rows[ev.RowIndex].Cells[ev.ColumnIndex].Value;
//                    ev.CellStyle.BackColor = statusPagamento ? System.Drawing.Color.Green : System.Drawing.Color.Red;
//                }
//            };
//        }

//        private void buttonPagamentoRealizado_Click(object sender, EventArgs e)
//        {
//            // Atualizar o status de pagamento para 'true' (realizado) no banco de dados
//            foreach (DataGridViewRow row in dataGridViewpagamento.SelectedRows)
//            {
//                var aluno = (Aluno)row.DataBoundItem;  // Obtém o aluno selecionado
//                alunoController.AtualizarStatusPagamento(aluno.Id, true);  // Atualiza o status no banco
//            }

//            // Recarrega a lista de alunos para refletir as alterações
//            CarregarAlunos();
//        }

//        private void buttonPendentePagamento_Click(object sender, EventArgs e)
//        {
//            // Atualizar o status de pagamento para 'false' (pendente) no banco de dados
//            foreach (DataGridViewRow row in dataGridViewpagamento.SelectedRows)
//            {
//                var aluno = (Aluno)row.DataBoundItem;  // Obtém o aluno selecionado
//                alunoController.AtualizarStatusPagamento(aluno.Id, false);  // Atualiza o status no banco
//            }

//            // Recarrega a lista de alunos para refletir as alterações
//            CarregarAlunos();
//        }
//    }
//}
