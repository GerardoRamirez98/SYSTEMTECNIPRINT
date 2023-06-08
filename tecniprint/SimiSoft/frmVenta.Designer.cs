namespace TECNIPRINT
{
    partial class frmVenta
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
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            cbCliente = new System.Windows.Forms.ComboBox();
            lblCliente = new DevExpress.XtraEditors.LabelControl();
            lblPrecioVenta = new DevExpress.XtraEditors.LabelControl();
            lblPrecioProducto = new DevExpress.XtraEditors.LabelControl();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            comboBox2 = new System.Windows.Forms.ComboBox();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            cbProducto = new System.Windows.Forms.ComboBox();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            lblFecha = new DevExpress.XtraEditors.LabelControl();
            lblFechaActual = new DevExpress.XtraEditors.LabelControl();
            lblHora = new DevExpress.XtraEditors.LabelControl();
            lblHoraActual = new DevExpress.XtraEditors.LabelControl();
            timer1 = new System.Windows.Forms.Timer(components);
            listView1 = new System.Windows.Forms.ListView();
            columnHeader1 = new System.Windows.Forms.ColumnHeader();
            columnHeader2 = new System.Windows.Forms.ColumnHeader();
            columnHeader3 = new System.Windows.Forms.ColumnHeader();
            columnHeader4 = new System.Windows.Forms.ColumnHeader();
            columnHeader5 = new System.Windows.Forms.ColumnHeader();
            columnHeader6 = new System.Windows.Forms.ColumnHeader();
            columnHeader7 = new System.Windows.Forms.ColumnHeader();
            barManager3 = new DevExpress.XtraBars.BarManager(components);
            bar1 = new DevExpress.XtraBars.Bar();
            btnActualizarProducto = new DevExpress.XtraBars.BarButtonItem();
            btnNuevoProducto = new DevExpress.XtraBars.BarButtonItem();
            btnModificarProducto = new DevExpress.XtraBars.BarButtonItem();
            btnEliminarProducto = new DevExpress.XtraBars.BarButtonItem();
            skinBarSubItem2 = new DevExpress.XtraBars.SkinBarSubItem();
            barDockControl5 = new DevExpress.XtraBars.BarDockControl();
            barDockControl6 = new DevExpress.XtraBars.BarDockControl();
            barDockControl7 = new DevExpress.XtraBars.BarDockControl();
            barDockControl8 = new DevExpress.XtraBars.BarDockControl();
            skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager3).BeginInit();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(cbCliente);
            groupControl1.Controls.Add(lblCliente);
            groupControl1.Controls.Add(lblPrecioVenta);
            groupControl1.Controls.Add(lblPrecioProducto);
            groupControl1.Controls.Add(textEdit1);
            groupControl1.Controls.Add(labelControl3);
            groupControl1.Controls.Add(comboBox2);
            groupControl1.Controls.Add(labelControl2);
            groupControl1.Controls.Add(cbProducto);
            groupControl1.Controls.Add(labelControl1);
            groupControl1.Location = new System.Drawing.Point(24, 116);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(1066, 231);
            groupControl1.TabIndex = 0;
            groupControl1.Text = "Area de ventas";
            // 
            // cbCliente
            // 
            cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbCliente.FormattingEnabled = true;
            cbCliente.Location = new System.Drawing.Point(95, 66);
            cbCliente.Name = "cbCliente";
            cbCliente.Size = new System.Drawing.Size(141, 21);
            cbCliente.TabIndex = 9;
            // 
            // lblCliente
            // 
            lblCliente.Location = new System.Drawing.Point(14, 69);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new System.Drawing.Size(37, 13);
            lblCliente.TabIndex = 8;
            lblCliente.Text = "Cliente:";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPrecioVenta.Appearance.Options.UseFont = true;
            lblPrecioVenta.Location = new System.Drawing.Point(548, 96);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new System.Drawing.Size(5, 13);
            lblPrecioVenta.TabIndex = 7;
            lblPrecioVenta.Text = "-";
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.Location = new System.Drawing.Point(446, 96);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new System.Drawing.Size(96, 13);
            lblPrecioProducto.TabIndex = 6;
            lblPrecioProducto.Text = "Precio del producto:";
            // 
            // textEdit1
            // 
            textEdit1.Location = new System.Drawing.Point(322, 94);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new System.Drawing.Size(100, 20);
            textEdit1.TabIndex = 5;
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(269, 96);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(47, 13);
            labelControl3.TabIndex = 4;
            labelControl3.Text = "Cantidad:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(95, 120);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(141, 21);
            comboBox2.TabIndex = 3;
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(14, 123);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(66, 13);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Tipo de pago:";
            // 
            // cbProducto
            // 
            cbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbProducto.FormattingEnabled = true;
            cbProducto.Location = new System.Drawing.Point(95, 93);
            cbProducto.Name = "cbProducto";
            cbProducto.Size = new System.Drawing.Size(141, 21);
            cbProducto.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(14, 96);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(47, 13);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Producto:";
            // 
            // lblFecha
            // 
            lblFecha.Location = new System.Drawing.Point(24, 59);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(33, 13);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha:";
            // 
            // lblFechaActual
            // 
            lblFechaActual.Location = new System.Drawing.Point(63, 59);
            lblFechaActual.Name = "lblFechaActual";
            lblFechaActual.Size = new System.Drawing.Size(4, 13);
            lblFechaActual.TabIndex = 6;
            lblFechaActual.Text = "-";
            // 
            // lblHora
            // 
            lblHora.Location = new System.Drawing.Point(24, 78);
            lblHora.Name = "lblHora";
            lblHora.Size = new System.Drawing.Size(27, 13);
            lblHora.TabIndex = 7;
            lblHora.Text = "Hora:";
            // 
            // lblHoraActual
            // 
            lblHoraActual.Location = new System.Drawing.Point(63, 78);
            lblHoraActual.Name = "lblHoraActual";
            lblHoraActual.Size = new System.Drawing.Size(4, 13);
            lblHoraActual.TabIndex = 8;
            lblHoraActual.Text = "-";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.Location = new System.Drawing.Point(24, 393);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(1066, 253);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "PRODUCTO";
            columnHeader1.Width = 101;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "CANTIDAD";
            columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "PRECIO";
            columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "TIPO DE PAGO";
            columnHeader4.Width = 108;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "DESCUENTO";
            columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "RECARGO";
            columnHeader6.Width = 118;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "PRECIO FINAL";
            columnHeader7.Width = 113;
            // 
            // barManager3
            // 
            barManager3.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1 });
            barManager3.DockControls.Add(barDockControl5);
            barManager3.DockControls.Add(barDockControl6);
            barManager3.DockControls.Add(barDockControl7);
            barManager3.DockControls.Add(barDockControl8);
            barManager3.Form = this;
            barManager3.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnActualizarProducto, btnNuevoProducto, btnModificarProducto, btnEliminarProducto, skinBarSubItem1, skinBarSubItem2 });
            barManager3.MaxItemId = 11;
            // 
            // bar1
            // 
            bar1.BarName = "Herramientas";
            bar1.DockCol = 0;
            bar1.DockRow = 0;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnActualizarProducto), new DevExpress.XtraBars.LinkPersistInfo(btnNuevoProducto), new DevExpress.XtraBars.LinkPersistInfo(btnModificarProducto), new DevExpress.XtraBars.LinkPersistInfo(btnEliminarProducto), new DevExpress.XtraBars.LinkPersistInfo(skinBarSubItem2) });
            bar1.Text = "Herramientas";
            // 
            // btnActualizarProducto
            // 
            btnActualizarProducto.Caption = "Actualizar";
            btnActualizarProducto.Id = 0;
            btnActualizarProducto.Name = "btnActualizarProducto";
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Caption = "Nuevo";
            btnNuevoProducto.Id = 1;
            btnNuevoProducto.Name = "btnNuevoProducto";
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.Caption = "Modificar";
            btnModificarProducto.Id = 2;
            btnModificarProducto.Name = "btnModificarProducto";
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.Caption = "Eliminar";
            btnEliminarProducto.Id = 3;
            btnEliminarProducto.Name = "btnEliminarProducto";
            // 
            // skinBarSubItem2
            // 
            skinBarSubItem2.Caption = "Apariencia";
            skinBarSubItem2.Id = 10;
            skinBarSubItem2.Name = "skinBarSubItem2";
            // 
            // barDockControl5
            // 
            barDockControl5.CausesValidation = false;
            barDockControl5.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControl5.Location = new System.Drawing.Point(0, 0);
            barDockControl5.Manager = barManager3;
            barDockControl5.Size = new System.Drawing.Size(1113, 20);
            // 
            // barDockControl6
            // 
            barDockControl6.CausesValidation = false;
            barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControl6.Location = new System.Drawing.Point(0, 675);
            barDockControl6.Manager = barManager3;
            barDockControl6.Size = new System.Drawing.Size(1113, 0);
            // 
            // barDockControl7
            // 
            barDockControl7.CausesValidation = false;
            barDockControl7.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControl7.Location = new System.Drawing.Point(0, 20);
            barDockControl7.Manager = barManager3;
            barDockControl7.Size = new System.Drawing.Size(0, 655);
            // 
            // barDockControl8
            // 
            barDockControl8.CausesValidation = false;
            barDockControl8.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControl8.Location = new System.Drawing.Point(1113, 20);
            barDockControl8.Manager = barManager3;
            barDockControl8.Size = new System.Drawing.Size(0, 655);
            // 
            // skinBarSubItem1
            // 
            skinBarSubItem1.Caption = "Apariencia";
            skinBarSubItem1.Id = 4;
            skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // frmVenta
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1113, 675);
            Controls.Add(listView1);
            Controls.Add(lblHoraActual);
            Controls.Add(lblHora);
            Controls.Add(lblFechaActual);
            Controls.Add(lblFecha);
            Controls.Add(groupControl1);
            Controls.Add(barDockControl7);
            Controls.Add(barDockControl8);
            Controls.Add(barDockControl6);
            Controls.Add(barDockControl5);
            Name = "frmVenta";
            Text = "Venta";
            Load += frmVenta_Load;
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox cbProducto;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox comboBox2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraEditors.LabelControl lblFechaActual;
        private DevExpress.XtraEditors.LabelControl lblHora;
        private DevExpress.XtraEditors.LabelControl lblHoraActual;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl lblPrecioVenta;
        private DevExpress.XtraEditors.LabelControl lblPrecioProducto;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox cbCliente;
        private DevExpress.XtraEditors.LabelControl lblCliente;
        private DevExpress.XtraBars.BarManager barManager3;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnActualizarProducto;
        private DevExpress.XtraBars.BarButtonItem btnNuevoProducto;
        private DevExpress.XtraBars.BarButtonItem btnModificarProducto;
        private DevExpress.XtraBars.BarButtonItem btnEliminarProducto;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem2;
        private DevExpress.XtraBars.BarDockControl barDockControl5;
        private DevExpress.XtraBars.BarDockControl barDockControl6;
        private DevExpress.XtraBars.BarDockControl barDockControl7;
        private DevExpress.XtraBars.BarDockControl barDockControl8;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
    }
}