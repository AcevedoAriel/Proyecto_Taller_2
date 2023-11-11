namespace Proyecto_Taller_II.CapaPresentacion.Administrador
{
    partial class ReporteReservas
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
            this.chartReserva = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // chartReserva
            // 
            chartArea1.Name = "ChartArea1";
            this.chartReserva.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartReserva.Legends.Add(legend1);
            this.chartReserva.Location = new System.Drawing.Point(112, 28);
            this.chartReserva.Name = "chartReserva";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartReserva.Series.Add(series1);
            this.chartReserva.Size = new System.Drawing.Size(532, 328);
            this.chartReserva.TabIndex = 0;
            this.chartReserva.Text = "chart1";
            this.chartReserva.Click += new System.EventHandler(this.chartReserva_Click);
            // 
            // ReporteReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartReserva);
            this.Name = "ReporteReservas";
            this.Text = "ReporteReservas";
            ((System.ComponentModel.ISupportInitialize)(this.chartReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartReserva;
    }
}