using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.Controller
{
    internal class CadastroAlunoController
    {
        public bool ValidarCadastroAlunoMenorIdade(TextBox idade, TextBox CamponomeResponsavel, Label nomeResponsavel, Label MsgErroIdade)
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

        public bool ValidarCamposVazios(TextBox nome, TextBox idade, TextBox telefone, TextBox data, ComboBox plano, TextBox nomeResponsavel, Label MsgErroResponsavel)
        {
            if (string.IsNullOrWhiteSpace(nome.Text) || string.IsNullOrWhiteSpace(idade.Text) || string.IsNullOrWhiteSpace(telefone.Text) && string.IsNullOrWhiteSpace(data.Text) && plano.SelectedItem == null)
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
                MsgErroTelefone.Text= "Número de telefone deve ter 10 ou 11 dígitos.";
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

        public bool ValidarNomeResponsavel(TextBox nomeResponsavel, Label MsgErroResponsavel)
        {
            while (nomeResponsavel.Visible)
            {
                if (string.IsNullOrWhiteSpace(nomeResponsavel.Text))
                {
                    MsgErroResponsavel.Text = "Preencha o nome do responsável.";
                    return false;
                }                      
            }
            return true;
        }
        public bool LimparCampos(TextBox nome, TextBox idade, TextBox telefone, TextBox data, ComboBox plano, TextBox nomeResponsavel)
        {         
              
            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            nome.Clear();
            idade.Clear();
            telefone.Clear();
            data.Clear();
            plano.SelectedItem = null;
            nomeResponsavel.Clear();
             return true;            
        }
    }
}







