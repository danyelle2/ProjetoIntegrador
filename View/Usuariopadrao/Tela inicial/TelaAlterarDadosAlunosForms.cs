using ProjetoIntegrador.Controller;
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
        public TelaAlterarDadosAlunosForms()
        {
            InitializeComponent();
        }
        AlterarDadosAlunoController alterarDadosAlunoController =new AlterarDadosAlunoController();
        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            // pensar em como criar uma funcao para quando clicar na lista e no botao alterar apareca os 
            // dados do aluno na tela de alterar dados
            bool resultadoMenorIdade = alterarDadosAlunoController.ValidarAlteracaoAlunoMenorIdade(textBoxIdadeAluno, textBoxCampoNomeResponsavel, labelNomeResponsavel, textMsgErroIdade);
            //TextBox idade, TextBox CamponomeResponsavel, Label nomeResponsavel, Label MsgErroIdade
            bool resultadoIdadeInvalida = alterarDadosAlunoController.IdadeInvalida();
            bool resultadoCamposVazios = alterarDadosAlunoController.ValidarCamposVazios();
            bool resultadoTelefoneValido = alterarDadosAlunoController.ValidarTelefone();
            bool DataInvalida = alterarDadosAlunoController.ValidarData();
            bool resultadoNomeResponsavel = alterarDadosAlunoController.ValidarNomeResponsavel();
            // pedir ajuda para ver se ta faltando alguma coisa 
            if (resultadoMenorIdade && resultadoIdadeInvalida && resultadoCamposVazios && resultadoTelefoneValido && DataInvalida && resultadoNomeResponsavel)
            {
               
                bool ValidarAlteracaoDados = alterarDadosAlunoController.ValidarAlteracaoDados(textBoxNomeAluno, textBoxIdadeAluno, textBoxTelefoneAluno, textBoxDataEntrada, comboBoxPlano, textBoxCampoNomeResponsavel, comboBoxStatusAlunos, textBoxDataSaida);

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaAlterarDadosAlunosForms_Load(object sender, EventArgs e)
        {

        }
    }
}
