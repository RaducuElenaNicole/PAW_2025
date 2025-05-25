namespace PAW_seminar9_12_05_2025
{
    partial class Form1
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
            this.companiesListBox = new System.Windows.Forms.ListBox();
            this.stocksChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.stocksChart)).BeginInit();
            this.SuspendLayout();
            // 
            // companiesListBox
            // 
            this.companiesListBox.FormattingEnabled = true;
            this.companiesListBox.ItemHeight = 20;
            this.companiesListBox.Location = new System.Drawing.Point(12, 12);
            this.companiesListBox.Name = "companiesListBox";
            this.companiesListBox.Size = new System.Drawing.Size(154, 424);
            this.companiesListBox.TabIndex = 0;
            this.companiesListBox.SelectedIndexChanged += new System.EventHandler(this.companiesListBox_SelectedIndexChanged);
            // 
            // stocksChart
            // 
            chartArea1.Name = "ChartArea1";
            this.stocksChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.stocksChart.Legends.Add(legend1);
            this.stocksChart.Location = new System.Drawing.Point(195, 13);
            this.stocksChart.Name = "stocksChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.stocksChart.Series.Add(series1);
            this.stocksChart.Size = new System.Drawing.Size(578, 423);
            this.stocksChart.TabIndex = 1;
            this.stocksChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stocksChart);
            this.Controls.Add(this.companiesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.stocksChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox companiesListBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart stocksChart;
    }
}

