namespace Proyecto_Taller_II.CapaPresentacion.Administrador
{
    partial class ReporteServicios
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
            this.chartServicios = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // chartServicios
            // 
            chartArea2.Name = "ChartArea1";
            this.chartServicios.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartServicios.Legends.Add(legend2);
            this.chartServicios.Location = new System.Drawing.Point(55, 60);
            this.chartServicios.Name = "chartServicios";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartServicios.Series.Add(series2);
            this.chartServicios.Size = new System.Drawing.Size(441, 300);
            this.chartServicios.TabIndex = 0;
            this.chartServicios.Text = "chart1";
            // 
            // ReporteServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartServicios);
            this.Name = "ReporteServicios";
            this.Text = "ReporteServicios";
            this.Load += new System.EventHandler(this.ReporteServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartServicios;
    }
}