using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.Controller
{
    internal class BotoesCadastroAlunoController
    {
        public bool ValidarCadastroAlunoMenorIdade(TextBox idade, TextBox CamponomeResponsavel, Label nomeResponsavel, Label MsgErroIdade, Label MsgErrorNomeReponsavel)
        {
            string idadeTexto = idade.Text.Trim().Replace(".", "").Replace(",", ".");

            if (int.TryParse(idadeTexto, out int idadeAluno))
            {
                if (idadeAluno > 1 && idadeAluno < 18)
                {
                    MessageBox.Show("Aluno menor de idade, favor colocar nome do responsável.", "Aviso");
                    nomeResponsavel.Visible = true;
                    CamponomeResponsavel.Visible = true;

                    if (string.IsNullOrWhiteSpace(CamponomeResponsavel.Text))
                    {
                        MsgErrorNomeReponsavel.Text = "Por favor, insira o nome do responsável.";
                        MsgErrorNomeReponsavel.Visible = true;
                        return false;
                    }

                    return true;
                }
            }
            else
            {
                MsgErroIdade.Text = "Idade inválida. Por favor, insira um número inteiro válido.";
                MsgErroIdade.Visible = true;
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

        public bool ValidarCamposVazios(TextBox nome, TextBox idade, TextBox telefone, TextBox data, ComboBox plano, TextBox nomeResponsavel, Label MsgErroResponsavel, ComboBox statusAluno)
        {
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

        public bool ValidarData(TextBox data, Label MsgErroData)
        {
            DateTime dataEntrada;
            if (!DateTime.TryParse(data.Text, out dataEntrada))
            {
                MsgErroData.Text = "Data inválida. Favor inserir uma data válida.";
                return false;
            }
            else if (dataEntrada > DateTime.Now)
            {
                MsgErroData.Text = "Data inválida. Favor inserir uma data válida.";
                return false;
            }
            return true;
        }
        public bool ValidarComboBox(ComboBox plano, ComboBox statusAluno, Label MsgErroPlano, Label MsgErroStatusAluno) //colocar essa função em todos as tela com combobox
        {
            if (plano.SelectedItem == null || (plano.SelectedItem.ToString() != "Anual" && plano.SelectedItem.ToString() != "Mensal"))
            {
                MsgErroPlano.Text = "Selecione uma opção válida.";
                return false;
            }
            if (statusAluno.SelectedItem == null || (statusAluno.SelectedItem.ToString() != "Ativo" && statusAluno.SelectedItem.ToString() != "Inativo"))
            {
                MsgErroStatusAluno.Text = "Selecione uma opção válida";

                return false;
            }
            return true;
        }

        //public bool ValidarNomeResponsavel(TextBox nomeResponsavel, Label MsgErroResponsavel)
        //{
        //    while (nomeResponsavel.Visible)
        //    {
        //        if (string.IsNullOrWhiteSpace(nomeResponsavel.Text))
        //        {
        //            MsgErroResponsavel.Visible = true;
        //            MsgErroResponsavel.Text = "Preencha o nome do responsável.";

        //            return false;
        //        }
        //    }

        //    return true;
        //}
    }
}

