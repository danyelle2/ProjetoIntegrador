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
        TelaInicialForm _telaInicial;
        BotoesCadastroAlunoController botoesCadastroAlunoController;
        LimparCamposController limparCamposController;
        private readonly int _idModalidade;

        public TelaCadastroAlunos(int idModalidade, TelaInicialForm tela)
        {
            InitializeComponent();
            botoesCadastroAlunoController = new BotoesCadastroAlunoController();
            limparCamposController = new LimparCamposController();
            _idModalidade = idModalidade;
            _telaInicial = tela;

        }

        BotoesCadastroAlunoController cadastroAlunoController = new BotoesCadastroAlunoController();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            bool resultadoMenorIdade = botoesCadastroAlunoController.ValidarCadastroAlunoMenorIdade(textBoxIdade, textBoxNomeResponsavel, label8, textMsgErroIdade, textMsgErroResponsavel);
            bool resultadoIdadeInvalida = botoesCadastroAlunoController.IdadeInvalida(textBoxIdade, textMsgErroIdade);
            bool resultadoCamposVazios = botoesCadastroAlunoController.ValidarCamposVazios(txtNomeAluno, textBoxIdade, txtTelefoneALuno, textBoxDataEntrada, txtAssinaturaAluno, textBoxNomeResponsavel, textMsgErroResponsavel, comboBoxStatusAluno);
            bool resultadoTelefoneValido = botoesCadastroAlunoController.ValidarTelefone(txtTelefoneALuno, textMsgErroTelefone);
            bool dataValida = botoesCadastroAlunoController.ValidarData(textBoxDataEntrada, textMsgErroData);
            bool resultadoComboBox = botoesCadastroAlunoController.ValidarComboBox(txtAssinaturaAluno, comboBoxStatusAluno, labelMsgErroPlano, labelMsgErroStatusAluno);

            if (resultadoMenorIdade && resultadoIdadeInvalida && resultadoCamposVazios && resultadoTelefoneValido && dataValida && resultadoComboBox)
            {
                try
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

                    bool sucesso = repositorio.CadastrarAluno(aluno);

                    if (sucesso)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limparCamposController.LimparCampos(txtNomeAluno, textBoxIdade, txtTelefoneALuno, textBoxDataEntrada, txtAssinaturaAluno, textBoxNomeResponsavel, comboBoxStatusAluno);
                        _telaInicial.AtualizarDatagrid();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao cadastrar aluno. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro inesperado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, corrija os erros antes de tentar novamente.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void TelaCadastroAlunos_Load(object sender, EventArgs e)
        {
            textBoxIdade.TextChanged += (s, ev) => limparCamposController.LimparMensagensErro(textMsgErroIdade);
            textBoxNomeResponsavel.TextChanged += (s, ev) => limparCamposController.LimparMensagensErro(textMsgErroResponsavel);
            txtTelefoneALuno.TextChanged += (s, ev) => limparCamposController.LimparMensagensErro(textMsgErroTelefone);
            textBoxDataEntrada.TextChanged += (s, ev) => limparCamposController.LimparMensagensErro(textMsgErroData);
            txtAssinaturaAluno.SelectedIndexChanged += (s, ev) => limparCamposController.LimparMensagensErro(labelMsgErroPlano);
            comboBoxStatusAluno.SelectedIndexChanged += (s, ev) => limparCamposController.LimparMensagensErro(labelMsgErroStatusAluno);
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

        private void textBoxDataEntrada_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
