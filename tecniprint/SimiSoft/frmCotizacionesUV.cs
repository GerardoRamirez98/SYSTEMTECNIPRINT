﻿using DevExpress.XtraEditors;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;

namespace TP
{
    public partial class frmCotizacionesUV : DevExpress.XtraEditors.XtraForm
    {
        public frmCotizacionesUV()
        {
            InitializeComponent();
        }

        //Fecha y Hora en tiempo real
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblHoraActual.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFechaActual.Text = DateTime.Now.ToLongDateString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int indice_fila = dgvImpresionUV.Rows.Add();
            DataGridViewRow row = dgvImpresionUV.Rows[indice_fila];

            row.Cells["CantidadPares"].Value = txtTotalPares.Text;
            row.Cells["CantidadImpares"].Value = "";
            row.Cells["Descripcion"].Value = txtEstilo.Text;
            row.Cells["Largo"].Value = txtLargo.Text;
            row.Cells["Ancho"].Value = txtAncho.Text;
            row.Cells["PrecioUnitario"].Value = lblPrecioUnitario.Text;
            row.Cells["PrecioVenta"].Value = lblPrecioVenta.Text;
        }

        private void btmEliminar_Click(object sender, EventArgs e)
        {
            // Obtener las filas seleccionadas
            DataGridViewSelectedRowCollection filasSeleccionadas = dgvImpresionUV.SelectedRows;

            // Iterar sobre las filas seleccionadas y eliminarlas
            foreach (DataGridViewRow fila in filasSeleccionadas)
            {
                dgvImpresionUV.Rows.Remove(fila);
            }
        }

        private void frmCotizacionesUV_Load(object sender, EventArgs e)
        {
            //fecha y hora en tiempo real del sistema
            timer1.Enabled = true;

            txtCodigo.Text = string.Format("{0}", DateTime.Now.ToString("ddMMyyyyHHmmss"));

            dgvImpresionUV.Columns.Add("CantidadPares", "CantidadPares");
            dgvImpresionUV.Columns.Add("CantidadImpares", "CantidadImpares");
            dgvImpresionUV.Columns.Add("Descripcion", "Descripcion");
            dgvImpresionUV.Columns.Add("Largo", "Largo");
            dgvImpresionUV.Columns.Add("Ancho", "Ancho");
            dgvImpresionUV.Columns.Add("PrecioUnitario", "PrecioUnitario");
            dgvImpresionUV.Columns.Add("PrecioVenta", "PrecioVenta");
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            // Verifica si hay datos en el DataGridView
            if (dgvImpresionUV.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para generar el PDF de cotización.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica si los campos de TextEdit están completos
            if (string.IsNullOrEmpty(txtCliente.Text) || string.IsNullOrEmpty(lblFechaActual.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de generar el PDF de cotización.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Crea un objeto Document
            Document doc = new Document();

            try
            {
                // Define la ubicación y el nombre del archivo PDF de salida
                string outputPath = "C://Users/USER/Pictures/Nueva carpeta/" + txtCodigo.Text + ".pdf";

                // Crea un objeto PdfWriter para escribir en el archivo PDF
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(outputPath, FileMode.Create));

                // Abre el documento para escribir contenido
                doc.Open();

                // Agrega el contenido al documento
                // Puedes utilizar métodos como doc.Add() para agregar texto, imágenes, tablas, etc.

                // Agrega información del cliente
                Paragraph clienteParagraph = new Paragraph("Cliente: " + txtCliente.Text);
                doc.Add(clienteParagraph);

                Paragraph codigoParagraph = new Paragraph("Codigo: " + txtCodigo.Text);
                doc.Add(codigoParagraph);

                // Agrega información de la fecha
                Paragraph fechaParagraph = new Paragraph("Fecha: " + lblFechaActual.Text);
                doc.Add(fechaParagraph);

                // Agrega el DataGridView como una tabla
                PdfPTable table = new PdfPTable(dgvImpresionUV.Columns.Count);

                // Configura el ancho de las columnas
                float[] columnWidths = new float[dgvImpresionUV.Columns.Count];
                for (int i = 0; i < dgvImpresionUV.Columns.Count; i++)
                {
                    columnWidths[i] = 100f; // Puedes ajustar el ancho según tus necesidades
                }
                table.SetWidths(columnWidths);

                // Agrega los encabezados de columna
                for (int i = 0; i < dgvImpresionUV.Columns.Count; i++)
                {
                    table.AddCell(new Phrase(dgvImpresionUV.Columns[i].HeaderText));
                }

                // Agrega los datos de las filas
                for (int i = 0; i < dgvImpresionUV.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvImpresionUV.Columns.Count; j++)
                    {
                        if (dgvImpresionUV.Rows[i].Cells[j].Value != null)
                        {
                            table.AddCell(new Phrase(dgvImpresionUV.Rows[i].Cells[j].Value.ToString()));
                        }
                        else
                        {
                            table.AddCell(new Phrase(""));
                        }
                    }
                }
                // Agrega la tabla al documento
                doc.Add(table);

                // Cierra el documento
                doc.Close();

                // Muestra un mensaje de éxito
                MessageBox.Show("El PDF de cotización se generó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si ocurre alguna excepción
                MessageBox.Show("Ocurrió un error al generar el PDF de cotización: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            BorrarCamposExluyendo(this);
        }

        public void BorrarCamposExluyendo(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is TextEdit && childControl.Name != "txtCodigo")
                {
                    ((TextEdit)childControl).Clear();
                }

                if (childControl.HasChildren)
                {
                    BorrarCamposExluyendo(childControl);
                }
            }
        }

        public void BorrarCampos(Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                if (childControl is TextEdit)
                {
                    ((TextEdit)childControl).Clear();
                }

                if (childControl.HasChildren)
                {
                    BorrarCampos(childControl);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvImpresionUV.Rows.Clear();

            BorrarCampos(this);

            txtCodigo.Text = string.Format("{0}", DateTime.Now.ToString("ddMMyyyyHHmmss"));
        }

        
    }
}