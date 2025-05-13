using ProjetoIntegrador.Controller.Aluno;
using ProjetoIntegrador.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.Controller
{
    public class LimparCamposController
    {
        public bool LimparCampos(TextBox nome, TextBox idade, TextBox telefone, MaskedTextBox data, ComboBox plano, TextBox nomeResponsavel, ComboBox StatusAluno)
        {

            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            nome.Clear();
            idade.Clear();
            telefone.Clear();
            data.Clear();
            plano.SelectedItem = null;
            nomeResponsavel.Clear();
            StatusAluno.SelectedItem = null;
            return true;
        }
        public void LimparMensagensErro(params Label[] labels)
        {
            foreach (var label in labels)
            {
                label.Text = string.Empty;
                label.Visible = false;
            }
        }

       public void OcultarCampoResponsavel (TextBox nomeResponsavel, Label labelResponsavel)
        {
            nomeResponsavel.Visible = false;
            labelResponsavel.Visible = false;
        }
      
    }
}
