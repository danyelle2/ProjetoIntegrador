using ProjetoIntegrador.BancoDeDados;
using ProjetoIntegrador.View;
using System;
using System.Windows.Forms;

namespace ProjetoIntegrador.Controller.Aluno
{
    internal class AlterarDadosAlunoController
    {
        public bool AlterarDadosAlunos(TextBox nome, TextBox idade, TextBox telefone, TextBox dataEntrada, ComboBox plano, TextBox nomeResponsavel, ComboBox StatusAluno, TextBox dataSaida)
        {
            var alunoEditando = new ProjetoIntegrador.Model.Aluno();  
            alunoEditando.Nome = nome.Text;
            alunoEditando.Idade = int.Parse(idade.Text);
            alunoEditando.Telefone = telefone.Text;
            alunoEditando.DataEntrada = DateTime.Parse(dataEntrada.Text);
            alunoEditando.NomeResponsavel = nomeResponsavel.Text;
            alunoEditando.Plano = plano.SelectedItem.ToString();
            alunoEditando.Status = StatusAluno.SelectedItem.ToString();
            alunoEditando.DataSaida = DateTime.Parse(dataSaida.Text);
            var repositorio = new RepositorioAluno(new DatabaseService());
            bool sucesso = repositorio.AtualizarAluno(alunoEditando);


            if (sucesso)
            {
                MessageBox.Show("Aluno alterado com sucesso!");
                return true; 
            }
            else
            {
                MessageBox.Show("Erro ao alterar aluno.");
                return false; 
            }
        }
           
    }
}
