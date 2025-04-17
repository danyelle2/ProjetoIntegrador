using ProjetoIntegrador.Controller;
using ProjetoIntegrador.Controller.Aluno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ProjetoIntegrador.View
{
    public partial class TelaCadastroAlunos : Form
    {

        BotoesCadastroAlunoController cadastroAlunoController;
        CadastrarDadosAlunosController cadastrarDadosAlunosController;

        public TelaCadastroAlunos()
        {
            InitializeComponent();
            cadastroAlunoController = new BotoesCadastroAlunoController();
            cadastrarDadosAlunosController = new CadastrarDadosAlunosController();

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            bool resultadoMenorIdade = cadastroAlunoController.ValidarCadastroAlunoMenorIdade(textBox2, textBox3, label8, textMsgErroIdade);
            bool resultadoIdadeInvalida = cadastroAlunoController.IdadeInvalida(textBox2, textMsgErroIdade);
            bool resultadoCamposVazios = cadastroAlunoController.ValidarCamposVazios(txtNomeAluno, textBox2, txtTelefoneALuno, textBox1, txtAssinaturaAluno, textBox3, textMsgErroResponsavel, comboBoxStatusAluno);
            bool resultadoTelefoneValido = cadastroAlunoController.ValidarTelefone(txtTelefoneALuno, textMsgErroTelefone);
            bool DataInvalida = cadastroAlunoController.ValidarData(textBox1, textMsgErroData);
            bool resultadoNomeResponsavel = cadastroAlunoController.ValidarNomeResponsavel(textBox3, textMsgErroResponsavel);
            bool resultadoComboBox = cadastroAlunoController.ValidarComboBox(txtAssinaturaAluno, comboBoxStatusAluno, labelMsgErroPlano, labelMsgErroStatusAluno);

            if (resultadoMenorIdade && resultadoIdadeInvalida && resultadoCamposVazios && resultadoTelefoneValido && DataInvalida && resultadoNomeResponsavel && resultadoComboBox)
            {
                bool resultadoLimparCampos = cadastrarDadosAlunosController.LimparCampos(txtNomeAluno, textBox2, txtTelefoneALuno, textBox1, txtAssinaturaAluno, textBox3, comboBoxStatusAluno);
                //bool resultadoCadastrarAluno = cadastrarDadosAlunosController.CadastrarAluno();
                public bool CadastrarAluno(Model.Aluno aluno)
        {
            //arrumar esse COLOCAR O NOME DOS BOTÕES QUE ESTÃ NA TELA CADASTRO ALUNO
            try
            {
                var aluno = new ProjetoIntegrador.Model.Aluno
                {
                    Nome = nome.Text,
                    Idade = int.Parse(idade.Text),
                    Telefone = telefone.Text,
                    DataEntrada = DateTime.Parse(data.Text),
                    Plano = plano.SelectedItem?.ToString(),
                    NomeResponsavel = nomeResponsavel.Text,
                    Status = statusAluno.SelectedItem?.ToString()
                };

                var repositorio = new RepositorioAluno(new BancoDeDados.DatabaseService());
                return repositorio.CadastrarAluno(aluno);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }







        private void TelaCadastroAlunos_Load(object sender, EventArgs e)
        {

        }
    }
}
