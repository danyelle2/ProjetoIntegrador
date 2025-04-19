using MySqlX.XDevAPI;
using ProjetoIntegrador.BancoDeDados;
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

namespace ProjetoIntegrador.View.Administrador.TelaModalidade
{
    public partial class TelaModalidadeEscolha : Form
    {
        public TelaModalidadeEscolha()
        {
            InitializeComponent();
          
        }

       

        public TelaModalidadeEscolha(Usuario usuario)
        {
            Usuario = usuario;
        }

        public Usuario Usuario { get; }

        private void TelaModalidadeEscolha_Load(object sender, EventArgs e)
        {// aqui é sobre a modalidade. CHAMA O SESSIONUSER ele identifica qual usuario está logado
         //vou cadastrar a modalidade colocar um comboBox para selecionar a modalidade
            Usuario usuario = SessionUser.userLogado;
            //esse ta ok!! 
            //perguntar para o professor se é certo por aqui mesmo.
            if (usuario.TipoUsuario == "administrador")
            {
                btnCadastro.Visible = true;
            }
            else
            {
                btnCadastro.Visible = false;
            }
            //Falta esse Cadastrar a modalidade e depois colocar ela aqui 


            if (usuario.TipoUsuario == "administrador")
            {
                // Administrador vê tudo
                Zumba.Visible = true;
                grupoMuayThai.Visible = true;
                grupoFuncional.Visible = true;
            }
            else if (usuario.TipoUsuario == "professor")
            {
                if (usuario.Modalidade == "zumba")
                {
                    grupoZumba.Visible = true;
                    grupoMuayThai.Visible = false;
                    grupoFuncional.Visible = false;
                }
                else if (usuario.Modalidade == "muay_thai")
                {
                    grupoZumba.Visible = false;
                    grupoMuayThai.Visible = true;
                    grupoFuncional.Visible = false;
                }
                else if (usuario.Modalidade == "funcional")
                {
                    grupoZumba.Visible = false;
                    grupoMuayThai.Visible = false;
                    grupoFuncional.Visible = true;
                }
            }






        private void btnCadastro_Click(object sender, EventArgs e)
        {

           
            
                TelaCadastroForm telaCadastroForm = new TelaCadastroForm();
                telaCadastroForm.Show();
                this.Hide();
            

        }       
    }
}

