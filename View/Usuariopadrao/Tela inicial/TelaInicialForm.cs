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

namespace ProjetoIntegrador.View
{
    public partial class TelaInicialForm : Form
    {

        public TelaInicialForm(int idModalidade)
        {
            InitializeComponent();
            
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
            TelaCadastroAlunos telaCadastroAluno = new TelaCadastroAlunos();
            telaCadastroAluno.ShowDialog();
        }

        private void pictureBoxAlterarDadosAparece(object sender, EventArgs e)
        {

            MsgExplicacaoAlterarDados1.Visible = true;
            MsgExplicacaoAlterarDados1.Text = "Clique aqui para alterar os dados do aluno";
        }

        private void pictureBoxAlterarDadosDesaparece(object sender, EventArgs e)
        {
            MsgExplicacaoAlterarDados.Visible = false;

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
            var listaAlunos = repositorioAluno.BuscarTodos();
            dataGridViewListaGeralAlunos.DataSource = listaAlunos;
        }

        private void TelaInicialForm_Load(object sender, EventArgs e)
        {
            CarregarAlunos();

            Usuario usuario = SessionUser.userLogado;
           
            switch (usuario.IdModalidade)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        
            if (e.RowIndex >= 0) 
            {
                alunoSelecionado = (Aluno)dataGridViewListaGeralAlunos.Rows[e.RowIndex].DataBoundItem;
            }
        

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TelaPagamentoAlunos telapagamento = new TelaPagamentoAlunos();
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
           
            if (alunoSelecionado != null)
            {
                var telaAlterarDados = new TelaAlterarDadosAlunosForms(alunoSelecionado);
                telaAlterarDados.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um aluno para alterar os dados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        


    }

        private void MsgExplicacaoAlterarDados_Click(object sender, EventArgs e)
        {

        }
    }
    }

