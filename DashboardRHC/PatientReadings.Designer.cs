
namespace DashboardRHC
{
    partial class PatientReadings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.chBodyTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chHeartRate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chEnvironmentTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chOxygenSaturation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chRespiratoryRate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chBodyTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chHeartRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEnvironmentTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chOxygenSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chRespiratoryRate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.Color.White;
            this.lblPatientName.Location = new System.Drawing.Point(20, 17);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(112, 20);
            this.lblPatientName.TabIndex = 0;
            this.lblPatientName.Text = "PatientName";
            // 
            // chBodyTemperature
            // 
            chartArea1.AxisX.MaximumAutoSize = 90F;
            chartArea1.Name = "ChartArea1";
            this.chBodyTemperature.ChartAreas.Add(chartArea1);
            this.chBodyTemperature.Location = new System.Drawing.Point(35, 56);
            this.chBodyTemperature.Name = "chBodyTemperature";
            this.chBodyTemperature.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chBodyTemperature.Series.Add(series1);
            this.chBodyTemperature.Size = new System.Drawing.Size(350, 140);
            this.chBodyTemperature.TabIndex = 1;
            this.chBodyTemperature.Text = "Body Temperature";
            // 
            // chHeartRate
            // 
            chartArea2.AxisX.MaximumAutoSize = 90F;
            chartArea2.Name = "ChartArea1";
            this.chHeartRate.ChartAreas.Add(chartArea2);
            this.chHeartRate.Location = new System.Drawing.Point(415, 56);
            this.chHeartRate.Name = "chHeartRate";
            this.chHeartRate.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Heart Rate";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chHeartRate.Series.Add(series2);
            this.chHeartRate.Size = new System.Drawing.Size(350, 140);
            this.chHeartRate.TabIndex = 2;
            this.chHeartRate.Text = "chart2";
            // 
            // chEnvironmentTemperature
            // 
            chartArea3.AxisX.MaximumAutoSize = 90F;
            chartArea3.Name = "ChartArea1";
            this.chEnvironmentTemperature.ChartAreas.Add(chartArea3);
            this.chEnvironmentTemperature.Location = new System.Drawing.Point(415, 215);
            this.chEnvironmentTemperature.Name = "chEnvironmentTemperature";
            this.chEnvironmentTemperature.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Environment Temperature";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chEnvironmentTemperature.Series.Add(series3);
            this.chEnvironmentTemperature.Size = new System.Drawing.Size(350, 140);
            this.chEnvironmentTemperature.TabIndex = 4;
            this.chEnvironmentTemperature.Text = "chart3";
            // 
            // chOxygenSaturation
            // 
            chartArea4.AxisX.MaximumAutoSize = 90F;
            chartArea4.Name = "ChartArea1";
            this.chOxygenSaturation.ChartAreas.Add(chartArea4);
            this.chOxygenSaturation.Location = new System.Drawing.Point(35, 215);
            this.chOxygenSaturation.Name = "chOxygenSaturation";
            this.chOxygenSaturation.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "Oxygen Saturation";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chOxygenSaturation.Series.Add(series4);
            this.chOxygenSaturation.Size = new System.Drawing.Size(350, 140);
            this.chOxygenSaturation.TabIndex = 3;
            this.chOxygenSaturation.Text = "chart4";
            // 
            // chRespiratoryRate
            // 
            chartArea5.AxisX.MaximumAutoSize = 90F;
            chartArea5.Name = "ChartArea1";
            this.chRespiratoryRate.ChartAreas.Add(chartArea5);
            this.chRespiratoryRate.Location = new System.Drawing.Point(35, 373);
            this.chRespiratoryRate.Name = "chRespiratoryRate";
            this.chRespiratoryRate.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Name = "Respiratory Rate";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.chRespiratoryRate.Series.Add(series5);
            this.chRespiratoryRate.Size = new System.Drawing.Size(350, 140);
            this.chRespiratoryRate.TabIndex = 5;
            this.chRespiratoryRate.Text = "chart5";
            // 
            // PatientReadings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.chRespiratoryRate);
            this.Controls.Add(this.chEnvironmentTemperature);
            this.Controls.Add(this.chOxygenSaturation);
            this.Controls.Add(this.chHeartRate);
            this.Controls.Add(this.chBodyTemperature);
            this.Controls.Add(this.lblPatientName);
            this.Name = "PatientReadings";
            this.Size = new System.Drawing.Size(800, 541);
            this.Load += new System.EventHandler(this.PatientReadings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chBodyTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chHeartRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chEnvironmentTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chOxygenSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chRespiratoryRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chBodyTemperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart chHeartRate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chEnvironmentTemperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart chOxygenSaturation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chRespiratoryRate;
    }
}
