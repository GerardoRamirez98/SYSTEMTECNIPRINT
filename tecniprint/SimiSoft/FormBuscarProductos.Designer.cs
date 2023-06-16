namespace TP
{
    partial class FormBuscarProductos
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
            components = new System.ComponentModel.Container();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            productoBindingSource = new System.Windows.Forms.BindingSource(components);
            gvProducto = new DevExpress.XtraGrid.Views.Grid.GridView();
            colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            colCodigoBarras = new DevExpress.XtraGrid.Columns.GridColumn();
            colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            colUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            colPrecioCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            colMargenGanancia = new DevExpress.XtraGrid.Columns.GridColumn();
            colPrecioVenta = new DevExpress.XtraGrid.Columns.GridColumn();
            colStock = new DevExpress.XtraGrid.Columns.GridColumn();
            colStockMin = new DevExpress.XtraGrid.Columns.GridColumn();
            colStockMax = new DevExpress.XtraGrid.Columns.GridColumn();
            colIdCategoria = new DevExpress.XtraGrid.Columns.GridColumn();
            colCategoriaDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            colActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            colFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            colImagen = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvProducto).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.DataSource = productoBindingSource;
            gridControl1.Location = new System.Drawing.Point(12, 12);
            gridControl1.MainView = gvProducto;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(718, 343);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gvProducto });
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(FarmsRamirezBML.Producto);
            // 
            // gvProducto
            // 
            gvProducto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colIdProducto, colCodigo, colCodigoBarras, colNombre, colDescripcion, colMarca, colUnidadMedida, colPrecioCompra, colMargenGanancia, colPrecioVenta, colStock, colStockMin, colStockMax, colIdCategoria, colCategoriaDescripcion, colActivo, colFechaRegistro, colImagen });
            gvProducto.GridControl = gridControl1;
            gvProducto.Name = "gvProducto";
            gvProducto.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colIdProducto
            // 
            colIdProducto.FieldName = "IdProducto";
            colIdProducto.Name = "colIdProducto";
            colIdProducto.Visible = true;
            colIdProducto.VisibleIndex = 0;
            // 
            // colCodigo
            // 
            colCodigo.FieldName = "Codigo";
            colCodigo.Name = "colCodigo";
            colCodigo.Visible = true;
            colCodigo.VisibleIndex = 1;
            // 
            // colCodigoBarras
            // 
            colCodigoBarras.FieldName = "CodigoBarras";
            colCodigoBarras.Name = "colCodigoBarras";
            // 
            // colNombre
            // 
            colNombre.FieldName = "Nombre";
            colNombre.Name = "colNombre";
            colNombre.Visible = true;
            colNombre.VisibleIndex = 2;
            // 
            // colDescripcion
            // 
            colDescripcion.FieldName = "Descripcion";
            colDescripcion.Name = "colDescripcion";
            colDescripcion.Visible = true;
            colDescripcion.VisibleIndex = 3;
            // 
            // colMarca
            // 
            colMarca.FieldName = "Marca";
            colMarca.Name = "colMarca";
            // 
            // colUnidadMedida
            // 
            colUnidadMedida.FieldName = "UnidadMedida";
            colUnidadMedida.Name = "colUnidadMedida";
            // 
            // colPrecioCompra
            // 
            colPrecioCompra.FieldName = "PrecioCompra";
            colPrecioCompra.Name = "colPrecioCompra";
            // 
            // colMargenGanancia
            // 
            colMargenGanancia.FieldName = "MargenGanancia";
            colMargenGanancia.Name = "colMargenGanancia";
            // 
            // colPrecioVenta
            // 
            colPrecioVenta.FieldName = "PrecioVenta";
            colPrecioVenta.Name = "colPrecioVenta";
            // 
            // colStock
            // 
            colStock.FieldName = "Stock";
            colStock.Name = "colStock";
            // 
            // colStockMin
            // 
            colStockMin.FieldName = "StockMin";
            colStockMin.Name = "colStockMin";
            // 
            // colStockMax
            // 
            colStockMax.FieldName = "StockMax";
            colStockMax.Name = "colStockMax";
            // 
            // colIdCategoria
            // 
            colIdCategoria.FieldName = "IdCategoria";
            colIdCategoria.Name = "colIdCategoria";
            // 
            // colCategoriaDescripcion
            // 
            colCategoriaDescripcion.FieldName = "CategoriaDescripcion";
            colCategoriaDescripcion.Name = "colCategoriaDescripcion";
            colCategoriaDescripcion.Visible = true;
            colCategoriaDescripcion.VisibleIndex = 4;
            // 
            // colActivo
            // 
            colActivo.FieldName = "Activo";
            colActivo.Name = "colActivo";
            // 
            // colFechaRegistro
            // 
            colFechaRegistro.FieldName = "FechaRegistro";
            colFechaRegistro.Name = "colFechaRegistro";
            // 
            // colImagen
            // 
            colImagen.FieldName = "Imagen";
            colImagen.Name = "colImagen";
            // 
            // FormBuscarProductos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(742, 388);
            Controls.Add(gridControl1);
            Name = "FormBuscarProductos";
            Text = "FormBuscarProducto";
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigoBarras;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colMargenGanancia;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioVenta;
        private DevExpress.XtraGrid.Columns.GridColumn colStock;
        private DevExpress.XtraGrid.Columns.GridColumn colStockMin;
        private DevExpress.XtraGrid.Columns.GridColumn colStockMax;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCategoria;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoriaDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colActivo;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn colImagen;
    }
}