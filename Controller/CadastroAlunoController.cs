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
        public bool ValidarCadastroAlunoMenorIdade(TextBox idade, TextBox CamponomeResponsavel, Label nomeResponsavel)
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
                MessageBox.Show("Idade inválida, favor colocar idade correta.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }
        public bool IdadeInvalida(TextBox idade)
        {
            if (int.TryParse(idade.Text, out int idadeAluno))
                if (idadeAluno <= 0 && idadeAluno > 99)
                {
                    MessageBox.Show("Idade inválida, favor inserir uma idade válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            return true;
        }

        public bool ValidarCamposVazios(TextBox nome, TextBox idade, TextBox telefone, TextBox data, ComboBox plano, TextBox nomeResponsavel)
        {
            if (string.IsNullOrWhiteSpace(nome.Text) || string.IsNullOrWhiteSpace(idade.Text) || string.IsNullOrWhiteSpace(telefone.Text) && string.IsNullOrWhiteSpace(data.Text) && plano.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (nomeResponsavel.Visible)
                if (string.IsNullOrWhiteSpace(nomeResponsavel.Text))
                {
                    MessageBox.Show("Preencha o nome do responsável.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            return true;
        }

        public bool LimparCampos(TextBox nome, TextBox idade, TextBox telefone, TextBox data, ComboBox plano, TextBox nomeResponsavel)
        {
            if (true)
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
        public bool ValidarTelefone(TextBox telefone)
        {
            if (telefone.Text.Length < 10 || telefone.Text.Length > 11)
            {
                MessageBox.Show("Número de telefone inválido. O número deve ter 10 ou 11 dígitos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}







