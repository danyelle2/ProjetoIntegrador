using ProjetoIntegrador.Controller.Aluno;
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
        
            public bool CadastrarAluno(TextBox nome, TextBox idade, TextBox telefone, TextBox data, ComboBox plano, TextBox nomeResponsavel, ComboBox statusAluno)
        {
            try
            {
                var aluno = new ProjetoIntegrador.Model.Aluno
                {
                    Nome = nome.Text,
                    Idade = int.Parse(idade.Text),
                    Telefone = telefone.Text,
                    DataEntrada = DateTime.Parse(data.Text),
                    Plano = plano.SelectedItem?.ToString(),
                    NomeResponsavel = nomeResponsavel.Text,
                    Status = statusAluno.SelectedItem?.ToString()
                };

                var repositorio = new RepositorioAluno(new BancoDeDados.DatabaseService());
                return repositorio.CadastrarAluno(aluno);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
    

