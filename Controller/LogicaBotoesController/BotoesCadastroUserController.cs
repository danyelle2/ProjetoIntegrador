using ProjetoIntegrador.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.Controller
{
    internal class BotoesCadastroUserController
    {
        public bool SenhasIguais(TextBox senha, TextBox confirmaSenha, Label labelmensagemError)
        {
            if (senha == null || confirmaSenha == null || labelmensagemError == null)
            {
                throw new ArgumentNullException("Os parâmetros não podem ser nulos");
            }

            if (senha.Text != confirmaSenha.Text)
            {
                labelmensagemError.Text = "As senhas devem ser iguais";
                return false;
            }
            return true;
        }

        public bool CamposVazios(TextBox usuarioCadastro, TextBox confirmaSenhaCadastro, TextBox nomeCadastro, ComboBox tipocadastro, ComboBox modalidade)
        {
            if (usuarioCadastro == null || confirmaSenhaCadastro == null || nomeCadastro == null || tipocadastro == null || modalidade == null)
            {
                throw new ArgumentNullException("Os parâmetros não podem ser nulos");
            }

            if (string.IsNullOrWhiteSpace(usuarioCadastro.Text) || string.IsNullOrWhiteSpace(confirmaSenhaCadastro.Text) || string.IsNullOrWhiteSpace(nomeCadastro.Text) || tipocadastro.SelectedItem == null || modalidade.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool TipoUsuario(ComboBox tipocadastro, ComboBox modalidade, Label MsgErrorTipoUsuario)
        {
            if (tipocadastro == null || modalidade == null)
            {
                MsgErrorTipoUsuario.Text = "Favor escolher uma opção";
            }

            if (tipocadastro.SelectedItem == null || modalidade.SelectedItem == null)
            {
                MsgErrorTipoUsuario.Text="Selecione uma opção válida";
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
            return true;
        }
        public bool ValidarComboBox(ComboBox Modalidade, ComboBox TipoUsuario, Label MsgErroModalidade, Label MsgErroTipoUsuario) //colocar essa função em todos as tela com combobox
        {
            if (Modalidade.SelectedItem == null || (Modalidade.SelectedItem.ToString() != "Anual" && Modalidade.SelectedItem.ToString() != "Mensal"))
            {
                MsgErroModalidade.Text = "Selecione uma opção válida.";
                return false;
            }
            if (TipoUsuario.SelectedItem == null || (TipoUsuario.SelectedItem.ToString() != "Ativo" && TipoUsuario.SelectedItem.ToString() != "Inativo"))
            {
                MsgErroTipoUsuario.Text = "Selecione uma opção válida";

                return false;
            }
            return true;
        }
    }
}

