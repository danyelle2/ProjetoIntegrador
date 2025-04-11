using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.Controller
{
    internal class CadastrarDadosAlunosController
    {
        public bool CadastrarAluno(TextBox nome, TextBox idade, TextBox telefone, TextBox data, ComboBox plano, TextBox nomeResponsavel, ComboBox StatusAluno)
        {
            // Criar um repositorio que vai chamar o banco de dados aqui eu vou abrir uma classe chamada repositorio pro aluno e professor 
            //nela chamar o banco de dados e depos 
            return true;
        }

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
    

