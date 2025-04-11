using ProjetoIntegrador.Controller;
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
        public TelaCadastroAlunos()
        {
            InitializeComponent();

        }
        BotoesCadastroAlunoController cadastroAlunoController = new BotoesCadastroAlunoController();
        CadastrarDadosAlunosController cadastrarDadosAlunosController = new CadastrarDadosAlunosController();

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
            // pedir ajuda para ver se ta faltando alguma coisa 
            if (resultadoMenorIdade && resultadoIdadeInvalida && resultadoCamposVazios && resultadoTelefoneValido && DataInvalida && resultadoNomeResponsavel && resultadoComboBox)
            {
                bool resultadoLimparCampos = cadastrarDadosAlunosController.LimparCampos(txtNomeAluno, textBox2, txtTelefoneALuno, textBox1, txtAssinaturaAluno, textBox3, comboBoxStatusAluno);
                bool resultadoCadastrarAluno = cadastrarDadosAlunosController.CadastrarAluno(txtNomeAluno, textBox2, txtTelefoneALuno, textBox1, txtAssinaturaAluno, textBox3, comboBoxStatusAluno);

            }


        }

        private void TelaCadastroAlunos_Load(object sender, EventArgs e)
        {

        }
    }
}
