using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoIntegrador.View;
using ProjetoIntegrador.View.Administrador.TelaModalidade;
using ProjetoIntegrador.View.Usuariopadrao.Tela_inicial;

namespace ProjetoIntegrador
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Application.Run(new TelaLoadForms());
            Application.Run(new TelaLoginForm());
            //Application.Run(new TelaModalidadeEscolha());
        }
    }
}
