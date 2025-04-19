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
    public class CadastrarDadosAlunosController
    {
        public bool CadastrarAluno(Model.Aluno aluno)
        {
          
        }

            // Aqui vou deixar assim.




        public bool LimparCampos(TextBox nome, TextBox idade, TextBox telefone, TextBox data, ComboBox plano, TextBox nomeResponsavel, ComboBox StatusAluno)
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
    }
}
    

