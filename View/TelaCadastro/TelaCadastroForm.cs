using ProjetoIntegrador.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegrador.View
{
    public partial class TelaCadastroForm : Form
    {
        public TelaCadastroForm()
        {
            InitializeComponent();
        }
        CadastroProfessorController cadastroProfessorController = new CadastroProfessorController();
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaLoginForm telaLogin = new TelaLoginForm();
            telaLogin.Show();
            TelaCadastroForm telaCadastroForm = new TelaCadastroForm();
            telaCadastroForm.Hide();
        }

        private void msgTemporariaUsuarioAparece(object sender, EventArgs e)
        {
            MsgExplicacaoUsuario.Text = "Selecione usuário se você for professor\nSelecione Administrador se você for o dono do studio";
            MsgExplicacaoUsuario.Visible = true;
        }

        private void msgTemporariaUsuarioDesaparece(object sender, EventArgs e)
        {
            MsgExplicacaoUsuario.Visible = false;

        }

        private void msgTemporariaUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnModalidadeCadastroApareceText(object sender, EventArgs e)
        {

            TxTExplicacaoModalidade.Text = "A opção geral está disponível somente para administradore\nProfessor, por favor, selecione a sua aula";
            TxTExplicacaoModalidade.Visible = true;
        }

        private void btnModalidadeCadastroDesapareceText(object sender, EventArgs e)
        {
            TxTExplicacaoModalidade.Visible = false;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            bool resultadoValidarCadastro = cadastroProfessorController.ValidarCadastro(txtSenhaCadastro, textSenhaConfirmada, MsgErrorSenha, txtUsuarioCadastro, txtSenhaCadastro, textSenhaConfirmada, textNomeCadastro, comboBoxTipoUsuario, comboBoxModalidade);
            
            //Somente adm fará o cadastro dos usuários, então devo criar uma função para a tela aparecer somente para ele
            // Ocultar para o usuário o botão de cadastro
        }

        private void TelaCadastroForm_Load(object sender, EventArgs e)
        {

        }
    }
}
