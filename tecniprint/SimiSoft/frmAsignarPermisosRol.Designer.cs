namespace SimiSoft
{
    partial class frmAsignarPermisosRol
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
            dgvPermisos = new System.Windows.Forms.DataGridView();
            lblRol = new DevExpress.XtraEditors.LabelControl();
            btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            cbRoles = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).BeginInit();
            SuspendLayout();
            // 
            // dgvPermisos
            // 
            dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermisos.Location = new System.Drawing.Point(12, 41);
            dgvPermisos.Name = "dgvPermisos";
            dgvPermisos.Size = new System.Drawing.Size(505, 257);
            dgvPermisos.TabIndex = 0;
            // 
            // lblRol
            // 
            lblRol.Location = new System.Drawing.Point(11, 15);
            lblRol.Name = "lblRol";
            lblRol.Size = new System.Drawing.Size(19, 13);
            lblRol.TabIndex = 2;
            lblRol.Text = "Rol:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(186, 304);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new System.Drawing.Point(267, 304);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(257, 10);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cbRoles
            // 
            cbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbRoles.FormattingEnabled = true;
            cbRoles.Location = new System.Drawing.Point(36, 12);
            cbRoles.Name = "cbRoles";
            cbRoles.Size = new System.Drawing.Size(215, 21);
            cbRoles.TabIndex = 6;
            // 
            // frmAsignarPermisosRol
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(529, 336);
            Controls.Add(cbRoles);
            Controls.Add(btnBuscar);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(lblRol);
            Controls.Add(dgvPermisos);
            Name = "frmAsignarPermisosRol";
            Text = "AsignarPermisosRol";
            Load += frmAsignarPermisosRol_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPermisos;
        private DevExpress.XtraEditors.LabelControl lblRol;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private System.Windows.Forms.ComboBox cbRoles;
    }
}