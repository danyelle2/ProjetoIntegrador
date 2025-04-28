using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegrador.Model;
using ProjetoIntegrador.View.Administrador.TelaModalidade;
using ProjetoIntegrador.View.Usuariopadrao.Tela_inicial;

namespace ProjetoIntegrador.View
{
    public partial class TelaInicialForm : Form
    {
        private int idModalidade;

        public TelaInicialForm(int idModalidade)
        {
            InitializeComponent();
            this.FormClosing += AppClose;
            this.idModalidade = idModalidade;
        }


        public void AppClose(object sender, FormClosingEventArgs e)
        {          
            DialogResult result = MessageBox.Show("Deseja encerrar a aplicação?","Sair",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; 
            }
            else
            {
                Application.ExitThread(); 
            }
        


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

            MsgExplicacaoAlterarDados.Visible = true;
            MsgExplicacaoAlterarDados.Text = "Clique aqui para alterar os dados do aluno";
        }

        private void pictureBoxAlterarDadosDesaparece(object sender, EventArgs e)
        {
            MsgExplicacaoAlterarDados.Visible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var telaAlterarDados = new TelaAlterarDadosAlunosForms();
            telaAlterarDados.ShowDialog();
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
            //Qualquer coisa mudar para show normal em tela inteira mesmo
            TelaGraficoForms telaGrafico = new TelaGraficoForms();
            telaGrafico.ShowDialog();
        }

        private void TelaInicialForm_Load(object sender, EventArgs e)
        {
            //mudar por os nomes dos botões
            switch (idModalidade)
            {
                case 2:
                    labelTitulo.Text = "Área da Zumba";
                    break;
                case 3:
                    labelTitulo.Text = "Área Funcional";
                    break;
                case 4:
                    labelTitulo.Text = "Área do Muay Thai";
                    break;
                default:
                    labelTitulo.Text = "Área Geral";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
        }
    }
}
