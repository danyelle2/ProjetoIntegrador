namespace ProjetoIntegrador.View
{
    partial class TelaGraficoForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaGraficoForms));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chartEntradaAlunos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSaidaAlunos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEntradaAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSaidaAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(62, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // chartEntradaAlunos
            // 
            this.chartEntradaAlunos.BackColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.chartEntradaAlunos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEntradaAlunos.Legends.Add(legend1);
            this.chartEntradaAlunos.Location = new System.Drawing.Point(292, 280);
            this.chartEntradaAlunos.Name = "chartEntradaAlunos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Entrada";
            this.chartEntradaAlunos.Series.Add(series1);
            this.chartEntradaAlunos.Size = new System.Drawing.Size(478, 233);
            this.chartEntradaAlunos.TabIndex = 19;
            this.chartEntradaAlunos.Text = "chart1";
            // 
            // chartSaidaAlunos
            // 
            this.chartSaidaAlunos.BackColor = System.Drawing.Color.LightGray;
            chartArea2.Name = "ChartArea1";
            this.chartSaidaAlunos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSaidaAlunos.Legends.Add(legend2);
            this.chartSaidaAlunos.Location = new System.Drawing.Point(292, 30);
            this.chartSaidaAlunos.Name = "chartSaidaAlunos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Saida";
            this.chartSaidaAlunos.Series.Add(series2);
            this.chartSaidaAlunos.Size = new System.Drawing.Size(478, 233);
            this.chartSaidaAlunos.TabIndex = 20;
            this.chartSaidaAlunos.Text = "chartSaidaAlunos";
            this.chartSaidaAlunos.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "MENSAL";
            // 
            // TelaGraficoForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartSaidaAlunos);
            this.Controls.Add(this.chartEntradaAlunos);
            this.Controls.Add(this.pictureBox2);
            this.Name = "TelaGraficoForms";
            this.Text = "TelaGraficoForms";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEntradaAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSaidaAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEntradaAlunos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSaidaAlunos;
        private System.Windows.Forms.Label label1;
    }
}