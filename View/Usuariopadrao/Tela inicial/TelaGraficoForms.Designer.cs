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
<<<<<<< HEAD
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chartSaidaAlunos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
=======
            this.chartEntradaAlunos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSaidaAlunos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartEntradaAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSaidaAlunos)).BeginInit();
>>>>>>> origin/master
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSaidaAlunos)).BeginInit();
            this.SuspendLayout();
            // 
<<<<<<< HEAD
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "MENSAL";
=======
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
>>>>>>> origin/master
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightGray;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
<<<<<<< HEAD
            this.chart1.Location = new System.Drawing.Point(938, 61);
=======
            this.chart1.Location = new System.Drawing.Point(162, 142);
>>>>>>> origin/master
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Saida";
            this.chart1.Series.Add(series3);
<<<<<<< HEAD
            this.chart1.Size = new System.Drawing.Size(478, 233);
=======
            this.chart1.Size = new System.Drawing.Size(557, 355);
>>>>>>> origin/master
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            this.chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
<<<<<<< HEAD
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(889, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "ANUAL";
=======
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
>>>>>>> origin/master
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
            // chartSaidaAlunos
            // 
            this.chartSaidaAlunos.BackColor = System.Drawing.Color.LightGray;
            chartArea4.Name = "ChartArea1";
            this.chartSaidaAlunos.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSaidaAlunos.Legends.Add(legend4);
            this.chartSaidaAlunos.Location = new System.Drawing.Point(313, 61);
            this.chartSaidaAlunos.Name = "chartSaidaAlunos";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Saida";
            this.chartSaidaAlunos.Series.Add(series4);
            this.chartSaidaAlunos.Size = new System.Drawing.Size(478, 233);
            this.chartSaidaAlunos.TabIndex = 26;
            this.chartSaidaAlunos.Text = "chartMensal";
            this.chartSaidaAlunos.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // TelaGraficoForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1119, 512);
            this.Controls.Add(this.chartSaidaAlunos);
=======
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1858, 948);
>>>>>>> origin/master
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart1);
<<<<<<< HEAD
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
=======
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chartSaidaAlunos);
            this.Controls.Add(this.chartEntradaAlunos);
>>>>>>> origin/master
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaGraficoForms";
            this.Text = "TelaGraficoForms";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaGraficoForms_Load);
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.chartEntradaAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSaidaAlunos)).EndInit();
>>>>>>> origin/master
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSaidaAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
<<<<<<< HEAD

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
=======
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEntradaAlunos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSaidaAlunos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
>>>>>>> origin/master
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSaidaAlunos;
    }
}