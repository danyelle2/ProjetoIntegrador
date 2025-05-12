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
            
            this.DoubleBuffered = true; //efeito para não ficar piscando a tela ok

        }

        protected override CreateParams CreateParams//fórmula para os icones não picarem na tela. ok
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;

            }
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            TelaModalidadeEscolha telaModalidadeEscolha = new TelaModalidadeEscolha();
            telaModalidadeEscolha.Show();
        }

        private void msgTemporariaUsuarioAparece(object sender, EventArgs e)
        {
            MsgExplicacaoUsuario1.Text = "Usuário Padrão disponível somente para professores\n Administrador somente dono ou sócios do studio";
            MsgExplicacaoUsuario1.Visible = true;
        }

        private void msgTemporariaUsuarioDesaparece(object sender, EventArgs e)
        {
            MsgExplicacaoUsuario1.Visible = false;

        }

        private void msgTemporariaUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnModalidadeCadastroApareceText(object sender, EventArgs e)
        {

            MsgExplicacaoModalidade1.Text = "Opção Geral disponível somente para administrador";
            MsgExplicacaoModalidade1.Visible = true;
        }

        private void btnModalidadeCadastroDesapareceText(object sender, EventArgs e)
        {
            MsgExplicacaoModalidade1.Visible = false;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            bool resultadoCamposVazios = botoesCadastroController.CamposVazios(txtUsuarioCadastro, textSenhaConfirmada, textNomeCadastro, comboBoxTipoUsuario, comboBoxModalidade1);
            bool senhasIguais = botoesCadastroController.SenhasIguais(txtSenhaCadastro, textSenhaConfirmada, MsgErrorSenha1);
            bool tipoUsuarioValido = botoesCadastroController.TipoUsuario(comboBoxTipoUsuario, comboBoxModalidade1, MsgErrorTipoUsuario);
            bool resultadoComboBox = botoesCadastroController.ValidarComboBox(comboBoxModalidade1, comboBoxTipoUsuario, labelMsgErroModalidade1, MsgErrorTipoUsuario);
            bool resultadoValidacaoCpf = botoesCadastroController.ValidarCpf(txtUsuarioCadastro, labelMsgErroCpf1);
            if (tipoUsuarioValido && resultadoCamposVazios && senhasIguais && resultadoComboBox)
            {
                TipoUsuarioItem tipoSelecionado = (TipoUsuarioItem)comboBoxTipoUsuario.SelectedItem;

                DatabaseService databaseService = new DatabaseService();
                UsuarioRepositorio repositorio = new UsuarioRepositorio(databaseService);

                try
                {
                    txtUsuarioCadastro.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    string cpf = txtUsuarioCadastro.Text.Trim();

                    Usuario novoUsuario = new Usuario
                    {
                        Nome = textNomeCadastro.Text.Trim(),
                        Cpf = cpf,
                        Senha = txtSenhaCadastro.Text,
                        TipoUsuario = tipoSelecionado.ValorBanco,
                        IdModalidade = (int)comboBoxModalidade1.SelectedValue
                    };

                    repositorio.CadastrarUsuario(novoUsuario);

                    MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TelaModalidadeEscolha telaModalidadeEscolha = new TelaModalidadeEscolha();
                    telaModalidadeEscolha.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao cadastrar usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    
            





        private void TelaCadastroForm_Load(object sender, EventArgs e)
        {
            //ele mostra em forma de lista os dados que puxei do banco de dados
            // FAZER A MESMA COISA COM A TELA PAGAMENTO E INICIAL 
            List<Modalidade> listaModalidades = repositorioModalidade.GetModalidades();
            comboBoxModalidade1.DataSource = listaModalidades;
            comboBoxModalidade1.DisplayMember = "TipoModalidade";
            comboBoxModalidade1.ValueMember = "IdModalidade";
            comboBoxModalidade1.SelectedIndex = -1;



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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxModalidade1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtUsuarioCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxVoltar_Click(object sender, EventArgs e)
        {
            TelaModalidadeEscolha telaModalidadeEscolha = new TelaModalidadeEscolha();
            telaModalidadeEscolha.Show();
            this.Close();

        }

        private void btnCadastro_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}