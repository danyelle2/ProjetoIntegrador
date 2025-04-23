using ProjetoIntegrador.Controller;
using ProjetoIntegrador.Controller.Aluno;
using ProjetoIntegrador.Services;
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
    public partial class TelaCadastroAlunos : Form
    {

        BotoesCadastroAlunoController BotoescadastroAlunoController;
        LimparCamposController limparCamposController;

        public TelaCadastroAlunos()
        {
            InitializeComponent();
            cadastroAlunoController = new BotoesCadastroAlunoController();
            limparCamposController = new LimparCamposController();

        }
        BotoesCadastroAlunoController cadastroAlunoController = new BotoesCadastroAlunoController();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultadoMenorIdade = cadastroAlunoController.ValidarCadastroAlunoMenorIdade(textBoxIdade, textBoxNomeResponsavel, label8, textMsgErroIdade);
                bool resultadoIdadeInvalida = cadastroAlunoController.IdadeInvalida(textBoxIdade, textMsgErroIdade);
                bool resultadoCamposVazios = cadastroAlunoController.ValidarCamposVazios(txtNomeAluno, textBoxIdade, txtTelefoneALuno, textBoxDataEntrada, txtAssinaturaAluno, textBoxNomeResponsavel, textMsgErroResponsavel, comboBoxStatusAluno);
                bool resultadoTelefoneValido = cadastroAlunoController.ValidarTelefone(txtTelefoneALuno, textMsgErroTelefone);
                bool DataInvalida = cadastroAlunoController.ValidarData(textBoxDataEntrada, textMsgErroData);
                bool resultadoNomeResponsavel = cadastroAlunoController.ValidarNomeResponsavel(textBoxNomeResponsavel, textMsgErroResponsavel);
                bool resultadoComboBox = cadastroAlunoController.ValidarComboBox(txtAssinaturaAluno, comboBoxStatusAluno, labelMsgErroPlano, labelMsgErroStatusAluno);

                if (resultadoMenorIdade && resultadoIdadeInvalida && resultadoCamposVazios && resultadoTelefoneValido && DataInvalida && resultadoNomeResponsavel && resultadoComboBox)
                {
                    var databaseService = new DatabaseService();
                    var repositorio = new RepositorioAluno(databaseService);

                    var aluno = new Model.Aluno
                    {
                        Nome = txtNomeAluno.Text,
                        Idade = int.Parse(textBoxIdade.Text),
                        Telefone = txtTelefoneALuno.Text,
                        DataEntrada = DateTime.Parse(textBoxDataEntrada.Text),
                        Plano = txtAssinaturaAluno.SelectedItem?.ToString(),
                        NomeResponsavel = textBoxNomeResponsavel.Text,
                        Status = comboBoxStatusAluno.SelectedItem?.ToString()
                    };

                    repositorio.CadastrarAluno(aluno);

                    MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCamposController.LimparCampos(txtNomeAluno, textBoxIdade, txtTelefoneALuno, textBoxDataEntrada, txtAssinaturaAluno, textBoxNomeResponsavel, comboBoxStatusAluno);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar aluno. Verifique os campos e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void TelaCadastroAlunos_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxStatusAluno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
