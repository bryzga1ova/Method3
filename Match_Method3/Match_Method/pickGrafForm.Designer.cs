namespace Match_Method
{
    partial class pickGrafForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.goBack = new System.Windows.Forms.Button();
            this.Graf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Graf)).BeginInit();
            this.SuspendLayout();
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(0, 387);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(194, 51);
            this.goBack.TabIndex = 1;
            this.goBack.Text = "Вернуться назад";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // Graf
            // 
            chartArea1.Name = "ChartArea1";
            this.Graf.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graf.Legends.Add(legend1);
            this.Graf.Location = new System.Drawing.Point(0, -1);
            this.Graf.Name = "Graf";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.Graf.Series.Add(series1);
            this.Graf.Series.Add(series2);
            this.Graf.Size = new System.Drawing.Size(802, 382);
            this.Graf.TabIndex = 2;
            this.Graf.Text = "chart1";
            // 
            // pickGrafForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Graf);
            this.Controls.Add(this.goBack);
            this.Name = "pickGrafForm";
            this.Text = "График";
            ((System.ComponentModel.ISupportInitialize)(this.Graf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graf;
    }
}