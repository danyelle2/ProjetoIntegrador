using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.View
{
    public partial class TelaInicialForm : Form
    {
        public TelaInicialForm()
        {
            InitializeComponent();
            this.FormClosing += AppClose;
        }

        public void AppClose(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Deseja encerrar a aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Application.ExitThread();
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

            TelaAlterarDadosAlunosForms telaAlterarDados = new TelaAlterarDadosAlunosForms();
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
            TelaInicialForm telaInicial = new TelaInicialForm();
            telaInicial.Hide();
            TelaGraficoForms telaGrafico = new TelaGraficoForms();
            telaGrafico.Show();
        }

        private void TelaInicialForm_Load(object sender, EventArgs e)
        {

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
    }
}
