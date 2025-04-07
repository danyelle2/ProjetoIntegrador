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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chartEntradaAlunos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSaidaAlunos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEntradaAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSaidaAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
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
            chartArea3.Name = "ChartArea1";
            this.chartEntradaAlunos.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartEntradaAlunos.Legends.Add(legend3);
            this.chartEntradaAlunos.Location = new System.Drawing.Point(292, 267);
            this.chartEntradaAlunos.Name = "chartEntradaAlunos";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Entrada";
            this.chartEntradaAlunos.Series.Add(series3);
            this.chartEntradaAlunos.Size = new System.Drawing.Size(478, 233);
            this.chartEntradaAlunos.TabIndex = 19;
            this.chartEntradaAlunos.Text = "chart1";
            // 
            // chartSaidaAlunos
            // 
            this.chartSaidaAlunos.BackColor = System.Drawing.Color.LightGray;
            chartArea4.Name = "ChartArea1";
            this.chartSaidaAlunos.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSaidaAlunos.Legends.Add(legend4);
            this.chartSaidaAlunos.Location = new System.Drawing.Point(292, 12);
            this.chartSaidaAlunos.Name = "chartSaidaAlunos";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Saida";
            this.chartSaidaAlunos.Series.Add(series4);
            this.chartSaidaAlunos.Size = new System.Drawing.Size(478, 233);
            this.chartSaidaAlunos.TabIndex = 20;
            this.chartSaidaAlunos.Text = "chartSaidaAlunos";
            this.chartSaidaAlunos.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "MENSAL";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightGray;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(962, 12);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Saida";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(478, 233);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            this.chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.LightGray;
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(962, 267);
            this.chart2.Name = "chart2";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Entrada";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(478, 233);
            this.chart2.TabIndex = 22;
            this.chart2.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(889, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "ANUAL";
            // 
            // TelaGraficoForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartSaidaAlunos);
            this.Controls.Add(this.chartEntradaAlunos);
            this.Controls.Add(this.pictureBox2);
            this.Name = "TelaGraficoForms";
            this.Text = "TelaGraficoForms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEntradaAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSaidaAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEntradaAlunos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSaidaAlunos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label2;
    }
}