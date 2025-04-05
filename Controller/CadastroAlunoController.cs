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
        
            public bool ValidarCadastroAlunoMenorIdade(TextBox nome, TextBox idade, TextBox CamponomeResponsavel, Label nomeResponsavel)
        {
            int idadeAluno;
            if (int.TryParse(idade.Text, out idadeAluno))
            {
                if (idadeAluno < 18)
                {                    
                    MessageBox.Show("Aluno menor de idade, favor colocar nome do responsável.", "Aviso");

                    nomeResponsavel.Visible = true;
                    CamponomeResponsavel.Visible = true;

                    return false;
                }
                
            }
            else
            {
                MessageBox.Show("Por favor, insira uma idade válida.", "Erro");
                return false;
            }

            return true;
            
        }





    }
}
}
