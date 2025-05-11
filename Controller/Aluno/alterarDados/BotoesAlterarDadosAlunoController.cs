using ProjetoIntegrador.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.Controller
{
    internal class BotoesAlterarDadosAlunoController
    {
        public bool AparecerCampoResponsavel(TextBox idade, TextBox CamponomeResponsavel, Label nomeResponsavel, Label MsgErroIdade)
        {
            MsgErroIdade.Text = "";
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
            MsgErroIdade.Text = "";
            if (int.TryParse(idade.Text, out int idadeAluno))
                if (idadeAluno <= 0 && idadeAluno > 99)
                {
                    MsgErroIdade.Text = "Idade inválida, favor colocar idade correta.";
                    return false;
                }
            return true;
        }

        public bool ValidarCamposVazio(TextBox nome, TextBox idade, TextBox telefone, MaskedTextBox dataEntrada, ComboBox plano, TextBox nomeResponsavel, Label MsgErroResponsavel, ComboBox statusAluno, MaskedTextBox dataSaida)
        {
            MsgErroResponsavel.Text = "";
            if (string.IsNullOrWhiteSpace(nome.Text) || string.IsNullOrWhiteSpace(idade.Text) || string.IsNullOrWhiteSpace(telefone.Text) && string.IsNullOrWhiteSpace(dataEntrada.Text) && plano.SelectedItem == null && statusAluno.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (nomeResponsavel.Visible && dataSaida.Visible)
                if (string.IsNullOrWhiteSpace(nomeResponsavel.Text) && string.IsNullOrWhiteSpace(dataSaida.Text))
                {
                    MsgErroResponsavel.Text = "Preencha o nome do responsável.";
                    MessageBox.Show("Preencha a data de saída.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

            return true;
        }


        public bool ValidarTelefone(TextBox telefone, Label MsgErroTelefone)
        {MsgErroTelefone.Text = "";
            if (telefone.Text.Length < 10 || telefone.Text.Length > 11)
            {
                MsgErroTelefone.Text = "Número de telefone deve ter 10 ou 11 dígitos.";
                return false;
            }
            return true;
        }

        public bool ValidarDatas(MaskedTextBox dataEntrada, Label MsgErroDataEntrada, MaskedTextBox dataSaida, Label MsgErroDataSaida)
        {
            MsgErroDataEntrada.Text = "";
            MsgErroDataSaida.Text = "";

            if (!DateTime.TryParse(dataEntrada.Text, out DateTime dataEntradaConvertida))
            {
                MsgErroDataEntrada.Text = "Data de entrada inválida. Formato esperado: dd/MM/aaaa";
                return false;
            }

            if (dataEntradaConvertida > DateTime.Now)
            {
                MsgErroDataEntrada.Text = "Data de entrada não pode ser futura";
                return false;
            }

            if (dataSaida.Visible && !string.IsNullOrWhiteSpace(dataSaida.Text))
            {
                if (!DateTime.TryParse(dataSaida.Text, out DateTime dataSaidaConvertida))
                {
                    MsgErroDataSaida.Text = "Data de saída inválida. Formato esperado: dd/MM/aaaa";
                    return false;
                }

                if (dataSaidaConvertida > DateTime.Now)
                {
                    MsgErroDataSaida.Text = "Data de saída não pode ser futura";
                    return false;
                }

                if (dataSaidaConvertida < dataEntradaConvertida)
                {
                    MsgErroDataSaida.Text = "Data de saída não pode ser anterior à data de entrada";
                    return false;
                }
            }

            return true;
        }
        public bool AparecerDataSaida(ComboBox statusAluno, MaskedTextBox dataSaida, Label nomeDataSaida, Label MsgErrorDataSaida)
        {
            MsgErrorDataSaida.Text = "";

            bool Inativo = (statusAluno.SelectedItem != null && statusAluno.SelectedItem.ToString() == "Inativo");
            dataSaida.Visible = Inativo;
            nomeDataSaida.Visible = Inativo;

            if (Inativo)
            {
                if (string.IsNullOrWhiteSpace(dataSaida.Text))
                {
                    MsgErrorDataSaida.Text = "Data de saída é obrigatória para alunos inativos.";
                    return false;
                }

                if (!DateTime.TryParse(dataSaida.Text, out _))
                {
                    MsgErrorDataSaida.Text = "Formato de data inválido. Use dd/MM/aaaa.";
                    return false;
                }
            }

            return true;
        }
        
        public bool VisibilidadeNomeResponsavel(TextBox nomeResponsavel, Label MsgErroResponsavel)
        {
            MsgErroResponsavel.Text = "";
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

        public bool ValidarComboBox(ComboBox plano, ComboBox statusAluno, Label MsgErroPlano, Label MsgErroStatusAluno) 
        {
            MsgErroPlano.Text = "";
            MsgErroStatusAluno.Text = "";
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

    }
}