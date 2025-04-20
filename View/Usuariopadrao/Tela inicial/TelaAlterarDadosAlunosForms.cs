using ProjetoIntegrador.BancoDeDados;
using ProjetoIntegrador.Controller;
using ProjetoIntegrador.Controller.Aluno;
using ProjetoIntegrador.Model;
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
        public TelaAlterarDadosAlunosForms(Model.Aluno aluno)
        {
            InitializeComponent();
            botoesAlterarDadosAlunoController = new BotoesAlterarDadosAlunoController();
        }

        private void TelaAlterarDadosAlunosForms_Load(object sender, EventArgs e)
        {

        }
        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            Model.Aluno aluno = new Model.Aluno();

            bool resultadoMenorIdade = botoesAlterarDadosAlunoController.AparecerCampoResponsavel(textBoxIdadeAluno, textBoxNomeResponsavel, labelNomeResponsavel1, textMsgErroIdade);
            bool resultadoIdadeInvalida = botoesAlterarDadosAlunoController.IdadeInvalida(textBoxIdadeAluno, textMsgErroIdade);
            bool resultadoCamposVazios = botoesAlterarDadosAlunoController.ValidarCamposVazio(textBoxNomeAluno, textBoxIdadeAluno, textBoxTelefoneAluno, textBoxDataEntrada, comboBoxPlano, textBoxNomeResponsavel, labelMsgErroResponsavel, comboBoxStatusAlunos, textBoxDataSaida);
            bool resultadoTelefoneValido = botoesAlterarDadosAlunoController.ValidarTelefone(textBoxTelefoneAluno, textMsgErroTelefone);
            bool DataInvalida = botoesAlterarDadosAlunoController.ValidarDatas(textBoxDataEntrada, LabelMsgErroDataEntrada, textBoxDataSaida, textMsgErroDataSaida);
            bool resultadoAparecerDataSaida = botoesAlterarDadosAlunoController.AparecerDataSaida(comboBoxStatusAlunos, textBoxDataSaida,LabelNomeDataSaida, textMsgErroDataSaida);
            bool resultadoNomeResponsavel = botoesAlterarDadosAlunoController.VisibilidadeNomeResponsavel(textBoxNomeResponsavel, labelMsgErroResponsavel);
            bool resultadoComboBoxValidado= botoesAlterarDadosAlunoController.ValidarComboBox(comboBoxPlano, comboBoxStatusAlunos,labelMsgErroPlano ,labelMsgErroStatusAluno);

            if (resultadoMenorIdade && resultadoIdadeInvalida && resultadoCamposVazios && resultadoTelefoneValido && DataInvalida && resultadoAparecerDataSaida && resultadoNomeResponsavel && resultadoComboBoxValidado) 
            {

                var alunoEditando = new Aluno();
                alunoEditando.Nome = textBoxNomeAluno.Text;
                alunoEditando.Idade = int.Parse(textBoxIdadeAluno.Text);
                alunoEditando.Telefone = textBoxTelefoneAluno.Text;
                alunoEditando.DataEntrada = DateTime.Parse(textBoxDataEntrada.Text);
                alunoEditando.NomeResponsavel = textBoxNomeResponsavel.Text;
                alunoEditando.Plano = comboBoxPlano.SelectedItem.ToString();
                alunoEditando.Status = comboBoxStatusAlunos.SelectedItem.ToString();
                alunoEditando.DataSaida = DateTime.Parse(textBoxDataSaida.Text);

                var repositorio = new RepositorioAluno(new DatabaseService());
                repositorio.AlterarDadosAlunos(aluno);

                MessageBox.Show($"Dados do aluno {aluno.Nome}, alterado com sucesso!","Alteraçao de dados");
                
            }
            else
            {
                MessageBox.Show($"Erro ao alterar os dados do aluno{aluno.Nome}.", "Alteração de dados");
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBoxDataSaida_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
