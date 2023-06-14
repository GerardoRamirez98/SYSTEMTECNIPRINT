using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace TP
{
    public partial class frmCotizacionesUV : DevExpress.XtraEditors.XtraForm
    {
        public frmCotizacionesUV()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int indice_fila = dgvImpresionUV.Rows.Add();
            DataGridViewRow fila = dgvImpresionUV.Rows[indice_fila];

            fila.Cells["Cantidad"].Value = textEdit18.Text;
            fila.Cells["Descripcion"].Value = textEdit14.Text;
            fila.Cells["PrecioUnitario"].Value = labelControl40.Text;
            fila.Cells["PrecioPar"].Value = labelControl41.Text;
            //fila.Cells["Importe"].Value = ;
            //fila.Cells["Descuento"].Value = ;

        }

        private void frmCotizacionesUV_Load(object sender, EventArgs e)
        {
            dgvImpresionUV.Columns.Add("Cantidad", "Cantidad");
            dgvImpresionUV.Columns.Add("Descripcion", "Descripcion");
            dgvImpresionUV.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvImpresionUV.Columns.Add("PrecioPar", "Precio Par");
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss")+".pdf";

            string paginahtml_texto = "<table><tr><td></td>HOLA</tr></table>";

            if (guardar.ShowDialog() == DialogResult.OK)
            {

                using (FileStream stream = new FileStream(guardar.FileName,FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();

                    pdfDoc.Add(new Phrase(""));

                    using (StreamReader sr = new StreamReader(paginahtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();

                    stream.Close();
                }
            }
        }
    }
}