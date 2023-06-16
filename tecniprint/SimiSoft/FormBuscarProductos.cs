using DevExpress.XtraGrid.Views.Grid;
using FarmsRamirezBML;
using System;
using System.Linq;
using System.Windows.Forms;

namespace TP
{
    public partial class FormBuscarProductos : DevExpress.XtraEditors.XtraForm
    {
        public Producto ProductoSeleccionado { get; private set; }
        public FormBuscarProductos()
        {
            InitializeComponent();
            gvProducto.DoubleClick += gridView_DoubleClick;
        }

        private void FormBuscarProducto_Load(object sender, EventArgs e)
        {
            productoBindingSource.DataSource = new Producto().GetAll();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            GridView view = sender as GridView;
            if (view != null)
            {
                int focusedRowHandle = view.FocusedRowHandle;
                if (focusedRowHandle >= 0)
                {
                    Producto productoSeleccionado = view.GetRow(focusedRowHandle) as Producto;

                    frmCotizacionesUV formularioOriginal = Application.OpenForms.OfType<frmCotizacionesUV>().FirstOrDefault();
                    if (formularioOriginal != null)
                    {
                        formularioOriginal.MostrarDatosProducto(productoSeleccionado);
                    }
                }
            }
            Close();
        }
    }
}