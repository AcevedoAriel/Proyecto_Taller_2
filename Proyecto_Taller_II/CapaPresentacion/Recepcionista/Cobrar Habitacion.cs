using Proyecto_Taller_II.CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace Proyecto_Taller_II.CapaPresentacion.Recepcionista
{
    public partial class Cobrar_Habitacion : Form
    {
        public Cobrar_Habitacion(int id)
        {
            InitializeComponent();
            txtIDReserva.Text = id.ToString();
            Factura factura = new Factura();
            DataTable datos = factura.ObtenerDatos(id);
            DataRow fila = datos.Rows[0];
            txtHabitacion.Text = fila["nro_habitacion"].ToString();
            txtPrHab.Text = fila["precio"].ToString();
            if (!fila.IsNull("Total Servicios") && !fila.IsNull("Servicios"))
            {
                txtPrSer.Text = fila["Total Servicios"].ToString();
                txtServicios.Text = fila["Servicios"].ToString();
                double resultado = Convert.ToDouble(fila["precio"]) + Convert.ToDouble(fila["Total Servicios"]);
                txtTotal.Text = resultado.ToString();
            }
            else
            {
                txtPrSer.Text = "0";
                txtServicios.Text = "Sin Servicio";
                txtTotal.Text = fila["precio"].ToString();
            }




            cboboxCliente.DataSource = Cliente.TraerClientes();
            cboboxCliente.DisplayMember = "Cliente";
            cboboxCliente.ValueMember = "id_cliente";

            CBMetodoPago.DataSource = Factura.TraerMetodoPago();
            CBMetodoPago.DisplayMember = "descripcion";
            CBMetodoPago.ValueMember = "id_tipo_pago";
        }

        private void btnCobrarHabitacion_Click(object sender, EventArgs e)
        {
            DialogResult resultado;

            if (cboboxCliente.SelectedIndex != -1 && CBMetodoPago.SelectedIndex != -1)
            {
                resultado = MessageBox.Show("Desea confirmar e Imprimir el Pago?", "Confirmar", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    Factura factura = new Factura();
                    factura.fecha_pago = DateTime.Today;
                    factura.precio_hab = Convert.ToDouble(txtPrHab.Text);
                    factura.precio_ser = Convert.ToDouble(txtPrSer.Text);
                    factura.tipo_pago = Convert.ToInt32(CBMetodoPago.SelectedValue);
                    factura.id_reserva = Convert.ToInt32(txtIDReserva.Text);
                    factura.id_cliente = Convert.ToInt32(cboboxCliente.SelectedValue);
                    factura.total = Convert.ToDouble(txtTotal.Text);

                    int result = Factura.AgregarFactura(factura);

                    SaveFileDialog guardar = new SaveFileDialog
                    {
                        Filter = "Archivos PDF|*.pdf",
                        Title = "Guardar archivo PDF",
                        FileName = $"Factura_{DateTime.Now:yyyyMMdd}.pdf"
                    };

                    string nombreCliente = cboboxCliente.Text;
                    string tipoPago = CBMetodoPago.Text;

                    string paginaHtml_texto = Properties.Resources.Plantilla.ToString();
                    paginaHtml_texto = paginaHtml_texto.Replace("@CLIENTE", nombreCliente);
                    paginaHtml_texto = paginaHtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
                    paginaHtml_texto = paginaHtml_texto.Replace("@PAGO", tipoPago);
                    paginaHtml_texto = paginaHtml_texto.Replace("@SERVICIOS", txtServicios.Text);
                    paginaHtml_texto = paginaHtml_texto.Replace("@COSTOH", txtPrHab.Text);
                    paginaHtml_texto = paginaHtml_texto.Replace("@COSTOS", txtPrSer.Text);
                    paginaHtml_texto = paginaHtml_texto.Replace("@TOTAL", txtTotal.Text);


                    // Verificar si el usuario seleccionó un archivo antes de intentar guardar
                    if (guardar.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                            pdfDoc.Open();

                            pdfDoc.Add(new Phrase(""));

                            /*Agrego una imagen a mi factura en la posicion izquierda superior*/
                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.HotelParana, System.Drawing.Imaging.ImageFormat.Png);
                            img.ScaleToFit(227, 118);
                            img.Alignment = iTextSharp.text.Image.UNDERLYING;
                            img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 80);
                            pdfDoc.Add(img);

                            using (StringReader sr = new StringReader(paginaHtml_texto))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                            }

                            pdfDoc.Close();

                            stream.Close();

                        }




                        if (result != 0)
                        {
                            MessageBox.Show("Pago Guardado e Impreso con éxito", "Guardado", MessageBoxButtons.OK);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo Guardar", "Error", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Operación cancelada por el usuario", "Cancelado", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los Campos", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
