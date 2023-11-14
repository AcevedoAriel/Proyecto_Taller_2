namespace Proyecto_Taller_II.CapaPresentacion.Administrador
{
    partial class ReporteMedioPago
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartMedioPago = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartMedioPago)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMedioPago
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMedioPago.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMedioPago.Legends.Add(legend2);
            this.chartMedioPago.Location = new System.Drawing.Point(124, 108);
            this.chartMedioPago.Name = "chartMedioPago";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Recaudación";
            this.chartMedioPago.Series.Add(series2);
            this.chartMedioPago.Size = new System.Drawing.Size(494, 300);
            this.chartMedioPago.TabIndex = 0;
            this.chartMedioPago.Text = "chart1";
            // 
            // ReporteMedioPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartMedioPago);
            this.Name = "ReporteMedioPago";
            this.Text = "ReporteMedioPago";
            this.Load += new System.EventHandler(this.ReporteMedioPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartMedioPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMedioPago;
    }
}