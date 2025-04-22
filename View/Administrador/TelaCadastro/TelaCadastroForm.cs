using ProjetoIntegrador.Controller;
using ProjetoIntegrador.Model;
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
        CadastroProfessorUserController repositorioCadastroProfessor = new CadastroProfessorUserController();
        BotoesCadastroController cadastroProfessorController = new BotoesCadastroController();
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TelaLoginForm telalogin = new TelaLoginForm();
            telalogin.Show();
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
            bool resultadoCamposVazios = cadastroProfessorController.CamposVazios(txtUsuarioCadastro, textSenhaConfirmada, textNomeCadastro, comboBoxTipoUsuario, comboBoxModalidade);
            bool Senhasiguais = cadastroProfessorController.SenhasIguais(txtSenhaCadastro, textSenhaConfirmada, MsgErrorSenha);
            bool TipoUsuario = cadastroProfessorController.TipoUsuario(comboBoxTipoUsuario, comboBoxModalidade, MsgErrorTipoUsuario);
            bool resultadoComboBox = cadastroProfessorController.ValidarComboBox(comboBoxModalidade, comboBoxTipoUsuario, labelMsgErroModalidade, MsgErrorTipoUsuario);
            
            if (TipoUsuario && resultadoCamposVazios && Senhasiguais && resultadoComboBox)
            {

                //colocar aqui o repositorio que vai chamar o banco de dados
                //criar um repositorio para o aluno colocar datagride e colocar uma lista (Olhar o projeto do professor como base )
                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TelaCadastroForm telaCadastroForm = new TelaCadastroForm();
                telaCadastroForm.Dispose();
                TelaLoginForm telalogin = new TelaLoginForm();
                telalogin.Show();

                
            }
        }

        private void TelaCadastroForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textNomeCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaCadastro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
