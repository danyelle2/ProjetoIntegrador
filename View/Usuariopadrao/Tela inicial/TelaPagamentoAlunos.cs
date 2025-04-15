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
        }

        private void dataGridViewpagamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // não sei se coloca nessa tela ou coloca na classe controller e só chamo aqui
            //teste de funcionamento
            List<Aluno> alunos = new List<Aluno>
        {
            new Aluno { Nome = "fulano", StatusAtivo = true, StatusPagamento = false },
            new Aluno { Nome = "teste", StatusAtivo = true, StatusPagamento = true },
            new Aluno { Nome = "aaaa", StatusAtivo = false, StatusPagamento = false },
            new Aluno { Nome = "bbbbb", StatusAtivo = true, StatusPagamento = false }
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
            // teste de funcionamento
            //tem que ver como colocar isso quando tiver o banco de dados
            foreach (DataGridViewRow row in dataGridViewpagamento.SelectedRows)
            {
                var aluno = (Aluno)row.DataBoundItem;
                aluno.StatusPagamento = true; 
            }
            dataGridViewpagamento.Refresh();

        }

        private void buttonPendentePagamento_Click(object sender, EventArgs e)
        {

            // teste de funcionamento
            //tem que ver como colocar isso quando tiver o banco de dados
            foreach (DataGridViewRow row in dataGridViewpagamento.SelectedRows)
            {
                var aluno = (Aluno)row.DataBoundItem;
                aluno.StatusPagamento = false;
            }
            dataGridViewpagamento.Refresh();
        }
    }
}
