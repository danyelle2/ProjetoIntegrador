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
    public partial class TelaCadastroAlunos : Form
    {
        public TelaCadastroAlunos()
        {
            InitializeComponent();
        }
        CadastroAlunoController cadastroAlunoController = new CadastroAlunoController();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {            
            bool resultadoMenorIdade = cadastroAlunoController.ValidarCadastroAlunoMenorIdade(textBox2, textBox3, label8);
            bool resultadoIdadeInvalida= cadastroAlunoController.IdadeInvalida(textBox2);
            bool resultadoCamposVazios = cadastroAlunoController.ValidarCamposVazios(txtNomeAluno, textBox2, txtTelefoneALuno, textBox1, txtAssinaturaAluno, textBox3);
            bool resultadoTelefoneValido= cadastroAlunoController.ValidarTelefone(txtTelefoneALuno);
            bool resultadoLimparCampos = cadastroAlunoController.LimparCampos(txtNomeAluno, textBox2, txtTelefoneALuno, textBox1, txtAssinaturaAluno, textBox3);
            
        }

        
    }
}
