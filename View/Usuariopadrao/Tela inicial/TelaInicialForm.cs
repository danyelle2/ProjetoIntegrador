using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegrador.Controller.Aluno;
using ProjetoIntegrador.Model;
using ProjetoIntegrador.Services;
using ProjetoIntegrador.View.Administrador.TelaModalidade;
using ProjetoIntegrador.View.Usuariopadrao.Tela_inicial;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoIntegrador.View
{
    public partial class TelaInicialForm : Form
    {
        private readonly int idModalidadeSelecionada;
        public TelaInicialForm(int idModalidade)
        {
            InitializeComponent();
            idModalidadeSelecionada = idModalidade;


        }   
       
        

        private void pictureBoxCadastroAlunosAparecer(object sender, EventArgs e)
        {
            MsgExplicacaoCadastro.Visible = true;
            MsgExplicacaoCadastro.Text = "Clique aqui para cadastrar um aluno";
        }

        private void pictureBoxCadastroAlunosDesaparece(object sender, EventArgs e)
        {
            MsgExplicacaoCadastro.Visible = false;

        }

        private void pictureBoxCadastroAlunos_Click(object sender, EventArgs e)
        {
            TelaCadastroAlunos telaCadastroAluno = new TelaCadastroAlunos(idModalidadeSelecionada);
            telaCadastroAluno.ShowDialog();
        }

        private void pictureBoxAlterarDadosAparece(object sender, EventArgs e)
        {

            MsgExplicacaoAlterarDados1.Visible = true;
            MsgExplicacaoAlterarDados1.Text = "Clique aqui para alterar os dados do aluno";
        }

        private void pictureBoxAlterarDadosDesaparece(object sender, EventArgs e)
        {
            MsgExplicacaoAlterarDados1.Visible = false;

        }       

        private void pictureBoxGráficoAparece(object sender, EventArgs e)
        {

            MsgExplicacaoGrafico.Visible = true;
            MsgExplicacaoGrafico.Text = "Clique aqui para visualizar o gráfico de entradas e saída dos alunos";
        }

        private void pictureBoxGráficoDesaparece(object sender, EventArgs e)
        {

            MsgExplicacaoGrafico.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var telaGrafico = new TelaGraficoForms(idModalidadeSelecionada);
            telaGrafico.Show();
            this.Hide();

        }
        private void CarregarAlunos()
        {
            var repositorioAluno = new RepositorioAluno(new DatabaseService());
            var listaAlunos = repositorioAluno.BuscarTodos(idModalidadeSelecionada);

            dataGridViewListaGeralAlunos.DataSource = listaAlunos.ToList();

            dataGridViewListaGeralAlunos.Columns["StatusPagamento"].Visible = false;
            dataGridViewListaGeralAlunos.Columns["IdModalidade"].Visible = false;

            dataGridViewListaGeralAlunos.Columns["Id"].HeaderText = "ID";
            dataGridViewListaGeralAlunos.Columns["Id"].Width = 40;


            if (dataGridViewListaGeralAlunos.Columns.Contains("StatusAluno"))
            {
                dataGridViewListaGeralAlunos.Columns["StatusAluno"].HeaderText = "Status";
                dataGridViewListaGeralAlunos.Columns["StatusAluno"].Width = 80;

                dataGridViewListaGeralAlunos.Columns["StatusAluno"].CellTemplate = new DataGridViewTextBoxCell();
            }

            if (dataGridViewListaGeralAlunos.Columns.Contains("Id"))
                dataGridViewListaGeralAlunos.Columns["Id"].DisplayIndex = 0;

            if (dataGridViewListaGeralAlunos.Columns.Contains("Nome"))
                dataGridViewListaGeralAlunos.Columns["Nome"].DisplayIndex = 1;

            if (dataGridViewListaGeralAlunos.Columns.Contains("assinatura"))
                dataGridViewListaGeralAlunos.Columns["assinatura"].DisplayIndex = 2;

            foreach (DataGridViewRow row in dataGridViewListaGeralAlunos.Rows)
            {
                var aluno = (Aluno)row.DataBoundItem;

                if (row.Cells["StatusAluno"] != null)
                {
                    row.Cells["StatusAluno"].Value = aluno.StatusAlunoTexto; 
                }

                if (!aluno.StatusAluno)
                {
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                    row.DefaultCellStyle.ForeColor = Color.DarkGray;
                }
            }
        }

        private void TelaInicialForm_Load(object sender, EventArgs e)
        {
            dataGridViewListaGeralAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewListaGeralAlunos.MultiSelect = false; 

            dataGridViewListaGeralAlunos.BackgroundColor = Color.White;
            dataGridViewListaGeralAlunos.ReadOnly = true;
            dataGridViewListaGeralAlunos.AllowUserToAddRows = false;
            dataGridViewListaGeralAlunos.AllowUserToDeleteRows = false;

            Usuario usuario = SessionUser.userLogado;
            label1UsuarioNome.Text = usuario.Nome;

            CarregarAlunos();


            switch (idModalidadeSelecionada)
            {
                case 2:
                    labelTituloModalidade.Text = "Área de Ritimos e Zumba";
                    break;
                case 3:
                    labelTituloModalidade.Text = "Área de Funcional";
                    break;
                case 4:
                    labelTituloModalidade.Text = "Área do Muay Thai";
                    break;

            }
        }
        
        private void MsgTemporariaPagamento_Aparece(object sender, EventArgs e)
        {
            MsgTemporariaPagamento.Visible = true;
            MsgTemporariaPagamento.Text = "Status do pagamentos dos alunos";
        }

        private void MsgTemporariaPagamento_Desaparece(object sender, EventArgs e)
        {
            MsgTemporariaPagamento.Visible = false;
        }

        private Aluno alunoSelecionado;

       
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TelaPagamentoAlunos telapagamento = new TelaPagamentoAlunos(idModalidadeSelecionada);
            telapagamento.Show();

        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {

        }

            private void pictureBoxVoltar_Click(object sender, EventArgs e)
        {
            var telaModalidadeEscolha = new TelaModalidadeEscolha();
            telaModalidadeEscolha.Show();
            this.Hide(); 
        }



        private void pictureBoxAlterar_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaGeralAlunos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um aluno para alterar os dados.", "Atenção",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var telaAlterarDados = new TelaAlterarDadosAlunosForms(alunoSelecionado);
            if (telaAlterarDados.ShowDialog() == DialogResult.OK)
            {
                CarregarAlunos(); 
            }
        }



        private void MsgExplicacaoAlterarDados_Click(object sender, EventArgs e)
        {

        }

        private void MsgExplicacaoGrafico_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FiltrarAlunos();

        }

        private void FiltrarAlunos()
        {
            string pesquisa = textBox1.Text.Trim();

            var repositorioAluno = new RepositorioAluno(new DatabaseService());
            var listaAlunos = repositorioAluno.BuscarTodos(idModalidadeSelecionada);

            var alunosFiltrados = listaAlunos
                .Where(a => a.Nome != null && 
                            a.Nome != null &&
                            a.Nome.IndexOf(pesquisa, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            dataGridViewListaGeralAlunos.DataSource = alunosFiltrados;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewListaGeralAlunos.SelectedRows.Count > 0)
            {
                alunoSelecionado = (Aluno)dataGridViewListaGeralAlunos.SelectedRows[0].DataBoundItem;
            }
        }
    }
    }

