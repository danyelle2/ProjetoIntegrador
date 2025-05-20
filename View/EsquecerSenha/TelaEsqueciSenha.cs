using ProjetoIntegrador.Controller.Repositorio;
using ProjetoIntegrador.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.View.EsquecerSenha
{
    public partial class TelaEsqueciSenha : Form
    {
        public TelaEsqueciSenha()
        {
            InitializeComponent();
        }

        private void TelaEsqueciSenha_Load(object sender, EventArgs e)
        {
            //colocar função esqueci senha aqui e abrir um controller para senhas iguais e preencher o repositório
        //Colocar no parametro new parament(senha (@senha.criptograda))
        //depois chamar ela 
        }

        private void buttonConfirmarDados_Click(object sender, EventArgs e)
        
        {
            string nome = textBoxNomeUser.Text.Trim();
            string cpf = textBoxCpfUser.Text.Trim();
            string novaSenha = textBox3Senha.Text;

            var repositorio = new RepositorioRecuperarSenha(new DatabaseService());

            if (repositorio.VerificarUsuario(nome, cpf))
            {
                if (repositorio.AtualizarSenha(nome, cpf, novaSenha))
                {
                    MessageBox.Show("Senha atualizada com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar senha.");
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado. Verifique os dados.");
            }
        }

    }
}

