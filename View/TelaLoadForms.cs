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
    public partial class TelaLoadForms : Form
    {
        public TelaLoadForms()
        {
            InitializeComponent();
            FecharJanelaSplash();
        }

        private void TelaLoadForms_Load(object sender, EventArgs e)
        {
           
        }
        private async void FecharJanelaSplash()
        {
            int delay = 4000; // 5 segundos
            int interval = 100; // Intervalo de 100ms
            int steps = delay / interval;

            for (int i = 0; i < steps; i++)
            {
                await Task.Delay(interval);
                progressBar1.Value = (i + 1) * 100 / steps;
            }

            this.Dispose();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
