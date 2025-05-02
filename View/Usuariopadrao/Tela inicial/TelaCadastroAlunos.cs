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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.View
{
    public partial class TelaCadastroAlunos : Form
    {

        BotoesCadastroAlunoController botoesCadastroAlunoController;
        LimparCamposController limparCamposController;
        private readonly int _idModalidade;

        public TelaCadastroAlunos(int idModalidade)
        {
            InitializeComponent();
            botoesCadastroAlunoController = new BotoesCadastroAlunoController();
            limparCamposController = new LimparCamposController();
            _idModalidade = idModalidade;

        }
        BotoesCadastroAlunoController cadastroAlunoController = new BotoesCadastroAlunoController();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultadoMenorIdade = botoesCadastroAlunoController.ValidarCadastroAlunoMenorIdade(textBoxIdade, textBoxNomeResponsavel, label8, textMsgErroIdade);
                bool resultadoIdadeInvalida = botoesCadastroAlunoController.IdadeInvalida(textBoxIdade, textMsgErroIdade);
                bool resultadoCamposVazios = botoesCadastroAlunoController.ValidarCamposVazios(txtNomeAluno, textBoxIdade, txtTelefoneALuno, textBoxDataEntrada, txtAssinaturaAluno, textBoxNomeResponsavel, textMsgErroResponsavel, comboBoxStatusAluno);
                bool resultadoTelefoneValido = botoesCadastroAlunoController.ValidarTelefone(txtTelefoneALuno, textMsgErroTelefone);
                bool dataValida = botoesCadastroAlunoController.ValidarData(textBoxDataEntrada, textMsgErroData);
                bool resultadoNomeResponsavel = botoesCadastroAlunoController.ValidarNomeResponsavel(textBoxNomeResponsavel, textMsgErroResponsavel);
                bool resultadoComboBox = botoesCadastroAlunoController.ValidarComboBox(txtAssinaturaAluno, comboBoxStatusAluno, labelMsgErroPlano, labelMsgErroStatusAluno);

                if (resultadoMenorIdade && resultadoIdadeInvalida && resultadoCamposVazios && resultadoTelefoneValido && dataValida && resultadoNomeResponsavel && resultadoComboBox)
                {
                    var databaseService = new DatabaseService();
                    var repositorio = new RepositorioAluno(databaseService);

                    var aluno = new Model.Aluno

                    {
                        
                        Nome = txtNomeAluno.Text,
                        Idade = int.Parse(textBoxIdade.Text),
                        Telefone = txtTelefoneALuno.Text,
                        DataEntrada = DateTime.Parse(textBoxDataEntrada.Text),
                        Assinatura = txtAssinaturaAluno.SelectedItem?.ToString(),
                        NomeResponsavel = textBoxNomeResponsavel.Text,
                        IdModalidade = _idModalidade

                    };

                    var usuarioLogado = SessionUser.userLogado;

                    bool sucesso = repositorio.CadastrarAluno(aluno);

                    if (sucesso)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limparCamposController.LimparCampos(txtNomeAluno, textBoxIdade, txtTelefoneALuno, textBoxDataEntrada, txtAssinaturaAluno, textBoxNomeResponsavel, comboBoxStatusAluno);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar aluno. Verifique os campos e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
