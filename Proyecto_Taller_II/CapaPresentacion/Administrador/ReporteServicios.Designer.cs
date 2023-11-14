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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartServicios = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // chartServicios
            // 
            chartArea1.Name = "ChartArea1";
            this.chartServicios.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartServicios.Legends.Add(legend1);
            this.chartServicios.Location = new System.Drawing.Point(55, 60);
            this.chartServicios.Name = "chartServicios";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartServicios.Series.Add(series1);
            this.chartServicios.Size = new System.Drawing.Size(441, 300);
            this.chartServicios.TabIndex = 0;
            this.chartServicios.Text = "chart1";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(593, 44);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(107, 48);
            this.btnVer.TabIndex = 1;
            this.btnVer.Text = "Ver Gráfico";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // ReporteServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.chartServicios);
            this.Name = "ReporteServicios";
            this.Text = "ReporteServicios";
            this.Load += new System.EventHandler(this.ReporteServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartServicios;
        private System.Windows.Forms.Button btnVer;
    }
}