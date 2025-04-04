using ProjetoIntegrador.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.Controller
{
    internal class CadastroProfessorController
    {
        public bool ValidarCadastro(TextBox senha, TextBox confirmaSenha, Label labelmensagemError, TextBox usuarioCadastro, TextBox senhaCadastro, TextBox confirmaSenhaCadastro, TextBox nomeCadastro, ComboBox tipocadastro, ComboBox modalidade)
        {
            if (senha.Text != confirmaSenha.Text)
            {
                labelmensagemError.Text = "As senhas devem ser iguais"; ;
                return false;
            }

            if (string.IsNullOrWhiteSpace(usuarioCadastro.Text) || string.IsNullOrWhiteSpace(confirmaSenhaCadastro.Text) || string.IsNullOrWhiteSpace(nomeCadastro.Text) || tipocadastro.SelectedItem == null || modalidade.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (tipocadastro.SelectedItem.ToString() == "Administrador" && modalidade.SelectedItem.ToString() != "Geral")
            {

                MessageBox.Show("Administrador favor escolher a opção Geral", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (tipocadastro.SelectedItem.ToString() == "Usuário Padrão" && modalidade.SelectedItem.ToString() == "Geral")
            {
                MessageBox.Show("Opção geral somente para Administrador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TelaCadastroForm telaCadastroForm = new TelaCadastroForm();
            telaCadastroForm.Close();
            TelaLoginForm telalogin = new TelaLoginForm();
            telalogin.Show();
            return true;

        }

    }
}
}
