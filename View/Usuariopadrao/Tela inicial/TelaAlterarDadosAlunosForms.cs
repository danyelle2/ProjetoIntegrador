using ProjetoIntegrador.Controller;
using ProjetoIntegrador.Controller.Aluno;
using ProjetoIntegrador.Model;
using ProjetoIntegrador.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoIntegrador.View
{
    public partial class TelaAlterarDadosAlunosForms : Form
    {
        
        BotoesAlterarDadosAlunoController botoesAlterarDadosAlunoController;
        private Aluno alunoSelecionado;

        public TelaAlterarDadosAlunosForms(Aluno aluno)
        {
            InitializeComponent();
            botoesAlterarDadosAlunoController = new BotoesAlterarDadosAlunoController();
            this.alunoSelecionado = aluno;
            PreencherCampos();
        }
       

        private void PreencherCampos()
        {
            if (alunoSelecionado != null)
            {
                textBoxNomeAluno.Text = alunoSelecionado.Nome;
                textBoxIdadeAluno.Text = alunoSelecionado.Idade.ToString();
                textBoxTelefoneAluno.Text = alunoSelecionado.Telefone;
                textBoxDataEntrada.Text = alunoSelecionado.DataEntrada.ToString("dd-MM-yyyy");
                textBoxNomeResponsavel.Text = alunoSelecionado.NomeResponsavel;
                comboBoxPlano.SelectedItem = alunoSelecionado.Assinatura;
                comboBoxStatusAlunos.SelectedItem = alunoSelecionado.StatusAluno;

                if (alunoSelecionado.DataSaida != null)
                {
                    textBoxDataSaida.Text = alunoSelecionado.DataSaida?.ToString("dd-MM-yyyy");
                }
            }
        }


       

        BotoesAlterarDadosAlunoController alterarDadosAlunoController =new BotoesAlterarDadosAlunoController();
        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            try
            {                
                bool todasAsValidoesPassaram =
                    //botoesAlterarDadosAlunoController.AparecerCampoResponsavel(textBoxIdadeAluno, textBoxNomeResponsavel, labelNomeResponsavel1, textMsgErroIdade) &&
                    botoesAlterarDadosAlunoController.IdadeInvalida(textBoxIdadeAluno, textMsgErroIdade) &&
                    botoesAlterarDadosAlunoController.ValidarCamposVazio(textBoxNomeAluno, textBoxIdadeAluno, textBoxTelefoneAluno,
                        textBoxDataEntrada, comboBoxPlano, textBoxNomeResponsavel, labelMsgErroResponsavel,
                        comboBoxStatusAlunos, textBoxDataSaida) &&
                    botoesAlterarDadosAlunoController.ValidarTelefone(textBoxTelefoneAluno, textMsgErroTelefone) &&
                    botoesAlterarDadosAlunoController.ValidarDatas(textBoxDataEntrada, LabelMsgErroDataEntrada,
                        textBoxDataSaida, textMsgErroDataSaida) &&
                    botoesAlterarDadosAlunoController.AparecerDataSaida(comboBoxStatusAlunos, textBoxDataSaida,
                        LabelNomeDataSaida, textMsgErroDataSaida) &&
                    botoesAlterarDadosAlunoController.VisibilidadeNomeResponsavel(textBoxNomeResponsavel, labelMsgErroResponsavel) &&
                    botoesAlterarDadosAlunoController.ValidarComboBox(comboBoxPlano, comboBoxStatusAlunos,
                        labelMsgErroPlano, labelMsgErroStatusAluno);

                if (!todasAsValidoesPassaram)
                {
                    MessageBox.Show("Por favor, corrija os erros destacados antes de salvar.", "Dados Inválidos",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                alunoSelecionado.Nome = textBoxNomeAluno.Text;
                alunoSelecionado.Idade = int.Parse(textBoxIdadeAluno.Text);
                alunoSelecionado.Telefone = textBoxTelefoneAluno.Text;
                alunoSelecionado.DataEntrada = DateTime.Parse(textBoxDataEntrada.Text);
                alunoSelecionado.NomeResponsavel = textBoxNomeResponsavel.Text;
                alunoSelecionado.Assinatura = comboBoxPlano.SelectedItem.ToString();

                alunoSelecionado.StatusAluno = comboBoxStatusAlunos.SelectedItem.ToString() == "Ativo";
                
                if (!alunoSelecionado.StatusAluno && !string.IsNullOrEmpty(textBoxDataSaida.Text))
                {
                    alunoSelecionado.DataSaida = DateTime.Parse(textBoxDataSaida.Text);
                }
                else
                {
                    alunoSelecionado.DataSaida = null;
                }

                if (alunoSelecionado.Idade < 18)
                {
                    labelNomeResponsavel1.Visible = true;
                    textBoxNomeResponsavel.Visible = true;
                }
                else
                {
                    labelNomeResponsavel1.Visible = false;
                    textBoxNomeResponsavel.Visible = false;
                }

                var repositorio = new RepositorioAluno(new DatabaseService());
                bool sucesso = repositorio.AlterarDadosAlunos(alunoSelecionado);

                if (sucesso)
                {
                    MessageBox.Show($"Dados do aluno {alunoSelecionado.Nome} alterados com sucesso!","Alteração de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível salvar as alterações. Tente novamente.",
                                  "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Erro de formato nos dados: {ex.Message}",
                              "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}",
                              "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaAlterarDadosAlunosForms_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxStatusAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textMsgErroTelefone_Click(object sender, EventArgs e)
        {

        }

        private void LabelNomeDataSaida_Click(object sender, EventArgs e)
        {

        }
    }
}
