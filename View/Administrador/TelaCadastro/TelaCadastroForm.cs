using ProjetoIntegrador.Controller;
using ProjetoIntegrador.Controller.Repositorio;
using ProjetoIntegrador.Controller.Usuario;
using ProjetoIntegrador.Model;
using ProjetoIntegrador.Services;
using ProjetoIntegrador.View.Administrador.TelaModalidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjetoIntegrador.Model.TipoUsuario;

namespace ProjetoIntegrador.View
{
    public partial class TelaCadastroForm : Form
    {

        BotoesCadastroUsuarioController botoesCadastroController;
        RepositorioModalidade repositorioModalidade;
        TipoUsuarioItem tipoUsuarioItem;
        public TelaCadastroForm()
        {
            InitializeComponent();
            botoesCadastroController = new BotoesCadastroUsuarioController();
            repositorioModalidade = new RepositorioModalidade(new DatabaseService());
            tipoUsuarioItem = new TipoUsuarioItem();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TelaModalidadeEscolha telaModalidadeEscolha = new TelaModalidadeEscolha();
            telaModalidadeEscolha.Show();
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

            TxTExplicacaoModalidade.Text = "A opção geral está disponível somente para administrador\nProfessor, por favor, selecione a sua aula";
            TxTExplicacaoModalidade.Visible = true;
        }

        private void btnModalidadeCadastroDesapareceText(object sender, EventArgs e)
        {
            TxTExplicacaoModalidade.Visible = false;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            bool resultadoCamposVazios = botoesCadastroController.CamposVazios(txtUsuarioCadastro, textSenhaConfirmada, textNomeCadastro, comboBoxTipoUsuario, comboBoxModalidade);
            bool Senhasiguais = botoesCadastroController.SenhasIguais(txtSenhaCadastro, textSenhaConfirmada, MsgErrorSenha);
            bool TipoUsuario = botoesCadastroController.TipoUsuario(comboBoxTipoUsuario, comboBoxModalidade, MsgErrorTipoUsuario);
            bool resultadoComboBox = botoesCadastroController.ValidarComboBox(comboBoxModalidade, comboBoxTipoUsuario, labelMsgErroModalidade, MsgErrorTipoUsuario);

            if (TipoUsuario && resultadoCamposVazios && Senhasiguais && resultadoComboBox)
            {
                TipoUsuarioItem tipoSelecionado = (TipoUsuarioItem)comboBoxTipoUsuario.SelectedItem; // <- esta linha é a correção!

                DatabaseService databaseService = new DatabaseService();
                UsuarioRepositorio repositorio = new UsuarioRepositorio(databaseService);

                Usuario novoUsuario = new Usuario
                {
                    Nome = textNomeCadastro.Text.Trim(),
                    Cpf = txtUsuarioCadastro.Text.Trim(),
                    Senha = txtSenhaCadastro.Text,
                    TipoUsuario = tipoSelecionado.ValorBanco, // usa "usuario_padrao" ou "administrador"
                    IdModalidade = Convert.ToInt32(comboBoxModalidade.SelectedValue)
                };

                repositorio.CadastrarUsuario(novoUsuario);

                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void TelaCadastroForm_Load(object sender, EventArgs e)
        {
            //ele mostra em forma de lista os dados que puxei do banco de dados
          List<Modalidade> listaModalidades =  repositorioModalidade.GetModalidades();
            comboBoxModalidade.DataSource = listaModalidades;
            comboBoxModalidade.DisplayMember = "Tipo_Modalidade";
            comboBoxModalidade.ValueMember = "Id_Modalidade";

            comboBoxTipoUsuario.Items.Add(new TipoUsuarioItem { TextoExibido = "Usuário Padrão", ValorBanco = "usuario_padrao" });
            comboBoxTipoUsuario.Items.Add(new TipoUsuarioItem { TextoExibido = "Administrador", ValorBanco = "administrador" });



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