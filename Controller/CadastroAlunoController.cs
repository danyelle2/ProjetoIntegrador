using System;
using System.Collections.Generic;
using System.Linq;
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
        

    }
}






