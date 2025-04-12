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
        BotoesAlterarDadosAlunoController botoesAlterarDadosAlunoController;
        public TelaAlterarDadosAlunosForms()
        {
            InitializeComponent();
            botoesAlterarDadosAlunoController = new BotoesAlterarDadosAlunoController();
        }
        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            // pensar em como criar uma funcao para quando clicar na lista e no botao alterar apareca os 
            // dados do aluno na tela de alterar dados
            bool resultadoMenorIdade = botoesAlterarDadosAlunoController.AparecerCampoResponsavel(textBoxIdadeAluno, textBoxNomeResponsavel, labelNomeResponsavel1, textMsgErroIdade);
            bool resultadoIdadeInvalida = botoesAlterarDadosAlunoController.IdadeInvalida(textBoxIdadeAluno, textMsgErroIdade);
            bool resultadoCamposVazios = botoesAlterarDadosAlunoController.ValidarCamposVazio(textBoxNomeAluno, textBoxIdadeAluno, textBoxTelefoneAluno, textBoxDataEntrada, comboBoxPlano, textBoxNomeResponsavel, labelMsgErroResponsavel, comboBoxStatusAlunos, textBoxDataSaida);
            bool resultadoTelefoneValido = botoesAlterarDadosAlunoController.ValidarTelefone(textBoxTelefoneAluno, textMsgErroTelefone);
            bool DataInvalida = botoesAlterarDadosAlunoController.ValidarDatas(textBoxDataEntrada, LabelMsgErroDataEntrada, textBoxDataSaida, textMsgErroDataSaida);
            bool resultadoAparecerDataSaida = botoesAlterarDadosAlunoController.AparecerDataSaida(comboBoxStatusAlunos, textBoxDataSaida,LabelNomeDataSaida, textMsgErroDataSaida);
            bool resultadoNomeResponsavel = botoesAlterarDadosAlunoController.VisibilidadeNomeResponsavel(textBoxNomeResponsavel, labelMsgErroResponsavel);
            bool resultadoComboBoxValidado= botoesAlterarDadosAlunoController.ValidarComboBox(comboBoxPlano, comboBoxStatusAlunos,labelMsgErroPlano ,labelMsgErroStatusAluno);
            // pedir ajuda para ver se ta faltando alguma coisa 
            // Ta Entrando no login válido quando não era pra entrar, ver o que to fazendo de errado...
            if (resultadoMenorIdade && resultadoIdadeInvalida && resultadoCamposVazios && resultadoTelefoneValido && DataInvalida && resultadoAparecerDataSaida && resultadoNomeResponsavel && resultadoComboBoxValidado) 
            {
               
                bool ValidarAlteracaoDados = botoesAlterarDadosAlunoController.ValidarAlteracaoDados(textBoxNomeAluno, textBoxIdadeAluno, textBoxTelefoneAluno, textBoxDataEntrada, comboBoxPlano, textBoxNomeResponsavel, comboBoxStatusAlunos, textBoxDataSaida);
                TelaInicialForm telainicialForm = new TelaInicialForm();
                telainicialForm.Show();
                this.Dispose();
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
