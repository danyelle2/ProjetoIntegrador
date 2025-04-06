using ProjetoIntegrador.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.Controller
{
    internal class AlterarDadosAlunoController
    {
        public bool ValidarAlteracaoAlunoMenorIdade(TextBox idade, TextBox CamponomeResponsavel, Label nomeResponsavel, Label MsgErroIdade)
        {
            if (int.TryParse(idade.Text, out int idadeAluno))
            {

                if (idadeAluno > 1 && idadeAluno < 18)
                {
                    MessageBox.Show("Aluno menor de idade, favor colocar nome do responsável.", "Aviso");
                    nomeResponsavel.Visible = true;
                    CamponomeResponsavel.Visible = true;

                    return false;
                }
            }
            else
            {
                MsgErroIdade.Text = "Idade inválida, favor colocar idade correta.";
                return false;
            }

            return true;

        }
        public bool IdadeInvalida(TextBox idade, Label MsgErroIdade)
        {
            if (int.TryParse(idade.Text, out int idadeAluno))
                if (idadeAluno <= 0 && idadeAluno > 99)
                {
                    MsgErroIdade.Text = "Idade inválida, favor colocar idade correta.";
                    return false;
                }
            return true;
        }

        public bool ValidarCamposVazio(TextBox nome, TextBox idade, TextBox telefone, TextBox data, ComboBox plano, TextBox nomeResponsavel, Label MsgErroResponsavel, ComboBox statusAluno)
        {
            // adicionar data saida
            if (string.IsNullOrWhiteSpace(nome.Text) || string.IsNullOrWhiteSpace(idade.Text) || string.IsNullOrWhiteSpace(telefone.Text) && string.IsNullOrWhiteSpace(data.Text) && plano.SelectedItem == null && statusAluno.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (nomeResponsavel.Visible)
                if (string.IsNullOrWhiteSpace(nomeResponsavel.Text))
                {
                    MsgErroResponsavel.Text = "Preencha o nome do responsável.";
                    return false;
                }
            return true;
        }


        public bool ValidarTelefone(TextBox telefone, Label MsgErroTelefone)
        {
            if (telefone.Text.Length < 10 || telefone.Text.Length > 11)
            {
                MsgErroTelefone.Text = "Número de telefone deve ter 10 ou 11 dígitos.";
                return false;
            }
            return true;
        }

        public bool ValidarDatas(TextBox dataentrada, Label MsgErroData,TextBox dataSaida)
        {
            // adicionar visibilidade na data saida se status for inativo
            DateTime dataEntrada, dataDeSaida;
         
            if (!DateTime.TryParse(dataentrada.Text, out dataEntrada ))
            {
                MsgErroData.Text = "Data inválida. Favor inserir uma data válida.";
                return false;
            }
            
            if (!DateTime.TryParse(dataSaida.Text, out dataDeSaida))
            {
                MsgErroData.Text = "Data inválida. Favor inserir uma data válida.";
                return false;
            }
            else if (dataEntrada > DateTime.Now && dataDeSaida > DateTime.Now)
            {
                MsgErroData.Text = "Data inválida. Favor inserir uma data que não ultrapasse a atual.";
                return false;
            }

            return true;
        }

        public bool ValidarNomeResponsavel(TextBox nomeResponsavel, Label MsgErroResponsavel)
        {
            while (nomeResponsavel.Visible)
            {
                if (string.IsNullOrWhiteSpace(nomeResponsavel.Text))
                {
                    MsgErroResponsavel.Visible = true;
                    MsgErroResponsavel.Text = "Preencha o nome do responsável.";
                    return false;
                }
            }
            return true;
        }

        public bool AlterarDadosAlunos(TextBox nome, TextBox idade, TextBox telefone, TextBox dataEntrada, ComboBox plano, TextBox nomeResponsavel, ComboBox StatusAluno, TextBox dataSaida)
        {
            // PERGUNTAR AO PROFESSOR COMO FAZER ISSO COM BANCO DE DADOS
            // Aluno novoAluno = new Aluno(nome.Text, idade.Text, telefone.Text, data.Text, plano.SelectedItem.ToString(), nomeResponsavel.Text);
            // alunos.Add(novoAluno);
            return true;
        }

        public bool ValidarAlteracaoDados(TextBox nome, TextBox idade, TextBox telefone, TextBox dataEntrada, ComboBox plano, TextBox nomeResponsavel, ComboBox StatusAluno, TextBox dataSaida)
        {
            MessageBox.Show("Alteração realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TelaInicialForm telaInicial = new TelaInicialForm();
            telaInicial.Show();
            return true;
        }
    }
}
