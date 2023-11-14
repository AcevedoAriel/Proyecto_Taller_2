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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartReservas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ChartReservas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChartReservas
            // 
            chartArea3.Name = "ChartArea1";
            this.ChartReservas.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ChartReservas.Legends.Add(legend3);
            this.ChartReservas.Location = new System.Drawing.Point(248, 123);
            this.ChartReservas.Margin = new System.Windows.Forms.Padding(2);
            this.ChartReservas.Name = "ChartReservas";
            this.ChartReservas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Reservas";
            this.ChartReservas.Series.Add(series3);
            this.ChartReservas.Size = new System.Drawing.Size(426, 303);
            this.ChartReservas.TabIndex = 0;
            this.ChartReservas.Text = "Reservas";
            this.ChartReservas.Click += new System.EventHandler(this.chartReserva_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(103, 271);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 41);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Graficar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(67, 230);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(148, 20);
            this.txtAño.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de Reservas en el Mes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 81);
            this.panel1.TabIndex = 5;
            // 
            // ReporteReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.ChartReservas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReporteReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteReservas";
            this.Load += new System.EventHandler(this.ReporteReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartReservas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartReservas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}