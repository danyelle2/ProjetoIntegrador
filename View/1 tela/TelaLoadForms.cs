﻿using System;
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
                await Task.Delay(5000);           

            this.Dispose();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
