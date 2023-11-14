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
            this.ChartReservas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtAño = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChartReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartReservas
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartReservas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartReservas.Legends.Add(legend1);
            this.ChartReservas.Location = new System.Drawing.Point(11, 68);
            this.ChartReservas.Margin = new System.Windows.Forms.Padding(2);
            this.ChartReservas.Name = "ChartReservas";
            this.ChartReservas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Reservas";
            this.ChartReservas.Series.Add(series1);
            this.ChartReservas.Size = new System.Drawing.Size(355, 213);
            this.ChartReservas.TabIndex = 0;
            this.ChartReservas.Text = "Reservas";
            this.ChartReservas.Click += new System.EventHandler(this.chartReserva_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(271, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 41);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Aceptar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(373, 33);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(148, 20);
            this.txtAño.TabIndex = 4;
            // 
            // ReporteReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.ChartReservas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReporteReservas";
            this.Text = "ReporteReservas";
            this.Load += new System.EventHandler(this.ReporteReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartReservas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtAño;
    }
}