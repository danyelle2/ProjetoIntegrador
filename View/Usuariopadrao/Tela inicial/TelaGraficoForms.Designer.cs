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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaGraficoForms));
            this.chartEntradaAlunos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSaidaAlunos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartEntradaAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSaidaAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEntradaAlunos
            // 
            this.chartEntradaAlunos.BackColor = System.Drawing.Color.LightGray;
            chartArea1.Name = "ChartArea1";
            this.chartEntradaAlunos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEntradaAlunos.Legends.Add(legend1);
            this.chartEntradaAlunos.Location = new System.Drawing.Point(1233, 620);
            this.chartEntradaAlunos.Name = "chartEntradaAlunos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Entrada";
            this.chartEntradaAlunos.Series.Add(series1);
            this.chartEntradaAlunos.Size = new System.Drawing.Size(571, 316);
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
            this.chartSaidaAlunos.Location = new System.Drawing.Point(1233, 142);
            this.chartSaidaAlunos.Name = "chartSaidaAlunos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Saida";
            this.chartSaidaAlunos.Series.Add(series2);
            this.chartSaidaAlunos.Size = new System.Drawing.Size(571, 355);
            this.chartSaidaAlunos.TabIndex = 20;
            this.chartSaidaAlunos.Text = "chartSaidaAlunos";
            this.chartSaidaAlunos.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightGray;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(162, 142);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Saida";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(557, 355);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            this.chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.LightGray;
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(162, 610);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Entrada";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(557, 316);
            this.chart2.TabIndex = 22;
            this.chart2.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TelaGraficoForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1858, 948);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chartSaidaAlunos);
            this.Controls.Add(this.chartEntradaAlunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaGraficoForms";
            this.Text = "TelaGraficoForms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaGraficoForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartEntradaAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSaidaAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEntradaAlunos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSaidaAlunos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}