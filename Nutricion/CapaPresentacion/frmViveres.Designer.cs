namespace CapaPresentacion
{
    partial class frmViveres
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViveres));
            this.tabViveres = new System.Windows.Forms.TabControl();
            this.pagListado = new System.Windows.Forms.TabPage();
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtTextoBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataViveres = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pagMantemiento = new System.Windows.Forms.TabPage();
            this.gpMantenimiento = new System.Windows.Forms.GroupBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtGrasa = new System.Windows.Forms.TextBox();
            this.lblGrasa = new System.Windows.Forms.Label();
            this.txtProteinas = new System.Windows.Forms.TextBox();
            this.lblProteinas = new System.Windows.Forms.Label();
            this.txtHidratos = new System.Windows.Forms.TextBox();
            this.lblHidratos = new System.Windows.Forms.Label();
            this.txtVivere = new System.Windows.Forms.TextBox();
            this.lblVivere = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.errorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.tabViveres.SuspendLayout();
            this.pagListado.SuspendLayout();
            this.grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViveres)).BeginInit();
            this.pagMantemiento.SuspendLayout();
            this.gpMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabViveres
            // 
            this.tabViveres.Controls.Add(this.pagListado);
            this.tabViveres.Controls.Add(this.pagMantemiento);
            this.tabViveres.Location = new System.Drawing.Point(-2, 0);
            this.tabViveres.Name = "tabViveres";
            this.tabViveres.SelectedIndex = 0;
            this.tabViveres.Size = new System.Drawing.Size(925, 621);
            this.tabViveres.TabIndex = 0;
            // 
            // pagListado
            // 
            this.pagListado.BackColor = System.Drawing.Color.Plum;
            this.pagListado.Controls.Add(this.grpListado);
            this.pagListado.ForeColor = System.Drawing.Color.Black;
            this.pagListado.Location = new System.Drawing.Point(4, 22);
            this.pagListado.Name = "pagListado";
            this.pagListado.Padding = new System.Windows.Forms.Padding(3);
            this.pagListado.Size = new System.Drawing.Size(917, 595);
            this.pagListado.TabIndex = 0;
            this.pagListado.Text = "Listado";
            // 
            // grpListado
            // 
            this.grpListado.BackColor = System.Drawing.Color.Transparent;
            this.grpListado.Controls.Add(this.chkEliminar);
            this.grpListado.Controls.Add(this.btnEliminar);
            this.grpListado.Controls.Add(this.txtTextoBuscar);
            this.grpListado.Controls.Add(this.btnBuscar);
            this.grpListado.Controls.Add(this.dataViveres);
            this.grpListado.Location = new System.Drawing.Point(6, 8);
            this.grpListado.Name = "grpListado";
            this.grpListado.Size = new System.Drawing.Size(901, 573);
            this.grpListado.TabIndex = 0;
            this.grpListado.TabStop = false;
            this.grpListado.Text = "Listado";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminar.Location = new System.Drawing.Point(6, 100);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(105, 24);
            this.chkEliminar.TabIndex = 4;
            this.chkEliminar.Text = "ELIMINAR";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::CapaPresentacion.Properties.Resources.borrar_amarillo_32;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(6, 37);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(203, 38);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtTextoBuscar
            // 
            this.txtTextoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextoBuscar.Location = new System.Drawing.Point(487, 38);
            this.txtTextoBuscar.Name = "txtTextoBuscar";
            this.txtTextoBuscar.Size = new System.Drawing.Size(294, 26);
            this.txtTextoBuscar.TabIndex = 2;
            this.txtTextoBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.buscar_amarillo_32;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(244, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(203, 38);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "&BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dataViveres
            // 
            this.dataViveres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViveres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataViveres.Location = new System.Drawing.Point(6, 142);
            this.dataViveres.Name = "dataViveres";
            this.dataViveres.Size = new System.Drawing.Size(873, 425);
            this.dataViveres.TabIndex = 0;
            this.dataViveres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViveres_CellContentClick);
            this.dataViveres.DoubleClick += new System.EventHandler(this.dataViveres_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Visible = false;
            // 
            // pagMantemiento
            // 
            this.pagMantemiento.BackColor = System.Drawing.Color.Thistle;
            this.pagMantemiento.Controls.Add(this.gpMantenimiento);
            this.pagMantemiento.Location = new System.Drawing.Point(4, 22);
            this.pagMantemiento.Name = "pagMantemiento";
            this.pagMantemiento.Padding = new System.Windows.Forms.Padding(3);
            this.pagMantemiento.Size = new System.Drawing.Size(917, 595);
            this.pagMantemiento.TabIndex = 1;
            this.pagMantemiento.Text = "Mantenimiento";
            // 
            // gpMantenimiento
            // 
            this.gpMantenimiento.BackColor = System.Drawing.Color.Transparent;
            this.gpMantenimiento.Controls.Add(this.txtUnidad);
            this.gpMantenimiento.Controls.Add(this.lblUnidad);
            this.gpMantenimiento.Controls.Add(this.btnCancelar);
            this.gpMantenimiento.Controls.Add(this.btnNuevo);
            this.gpMantenimiento.Controls.Add(this.btnEditar);
            this.gpMantenimiento.Controls.Add(this.btnGuardar);
            this.gpMantenimiento.Controls.Add(this.cmbTipo);
            this.gpMantenimiento.Controls.Add(this.lblTipo);
            this.gpMantenimiento.Controls.Add(this.txtGrasa);
            this.gpMantenimiento.Controls.Add(this.lblGrasa);
            this.gpMantenimiento.Controls.Add(this.txtProteinas);
            this.gpMantenimiento.Controls.Add(this.lblProteinas);
            this.gpMantenimiento.Controls.Add(this.txtHidratos);
            this.gpMantenimiento.Controls.Add(this.lblHidratos);
            this.gpMantenimiento.Controls.Add(this.txtVivere);
            this.gpMantenimiento.Controls.Add(this.lblVivere);
            this.gpMantenimiento.Controls.Add(this.txtClave);
            this.gpMantenimiento.Controls.Add(this.lblClave);
            this.gpMantenimiento.Location = new System.Drawing.Point(7, 6);
            this.gpMantenimiento.Name = "gpMantenimiento";
            this.gpMantenimiento.Size = new System.Drawing.Size(891, 527);
            this.gpMantenimiento.TabIndex = 0;
            this.gpMantenimiento.TabStop = false;
            this.gpMantenimiento.Text = "Mantenimiento";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidad.Location = new System.Drawing.Point(211, 401);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(267, 26);
            this.txtUnidad.TabIndex = 7;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidad.Location = new System.Drawing.Point(45, 404);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(142, 20);
            this.lblUnidad.TabIndex = 16;
            this.lblUnidad.Text = "Unidad de Medida:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.cancelar_32;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(583, 238);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(203, 38);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.Nuevo_32;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(583, 99);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(203, 38);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = global::CapaPresentacion.Properties.Resources.editar_32;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(583, 171);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(203, 38);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::CapaPresentacion.Properties.Resources.guardar_amarillo_32;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(583, 39);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(203, 38);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(211, 329);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(267, 28);
            this.cmbTipo.TabIndex = 6;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(45, 328);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtGrasa
            // 
            this.txtGrasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrasa.Location = new System.Drawing.Point(211, 270);
            this.txtGrasa.Name = "txtGrasa";
            this.txtGrasa.Size = new System.Drawing.Size(267, 26);
            this.txtGrasa.TabIndex = 5;
            // 
            // lblGrasa
            // 
            this.lblGrasa.AutoSize = true;
            this.lblGrasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrasa.Location = new System.Drawing.Point(45, 273);
            this.lblGrasa.Name = "lblGrasa";
            this.lblGrasa.Size = new System.Drawing.Size(57, 20);
            this.lblGrasa.TabIndex = 8;
            this.lblGrasa.Text = "Grasa:";
            // 
            // txtProteinas
            // 
            this.txtProteinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProteinas.Location = new System.Drawing.Point(211, 211);
            this.txtProteinas.Name = "txtProteinas";
            this.txtProteinas.Size = new System.Drawing.Size(267, 26);
            this.txtProteinas.TabIndex = 4;
            // 
            // lblProteinas
            // 
            this.lblProteinas.AutoSize = true;
            this.lblProteinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProteinas.Location = new System.Drawing.Point(45, 214);
            this.lblProteinas.Name = "lblProteinas";
            this.lblProteinas.Size = new System.Drawing.Size(80, 20);
            this.lblProteinas.TabIndex = 6;
            this.lblProteinas.Text = "Proteinas:";
            // 
            // txtHidratos
            // 
            this.txtHidratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHidratos.Location = new System.Drawing.Point(211, 152);
            this.txtHidratos.Name = "txtHidratos";
            this.txtHidratos.Size = new System.Drawing.Size(267, 26);
            this.txtHidratos.TabIndex = 3;
            // 
            // lblHidratos
            // 
            this.lblHidratos.AutoSize = true;
            this.lblHidratos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHidratos.Location = new System.Drawing.Point(45, 155);
            this.lblHidratos.Name = "lblHidratos";
            this.lblHidratos.Size = new System.Drawing.Size(73, 20);
            this.lblHidratos.TabIndex = 4;
            this.lblHidratos.Text = "Hidratos:";
            // 
            // txtVivere
            // 
            this.txtVivere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVivere.Location = new System.Drawing.Point(211, 96);
            this.txtVivere.Name = "txtVivere";
            this.txtVivere.Size = new System.Drawing.Size(267, 26);
            this.txtVivere.TabIndex = 2;
            // 
            // lblVivere
            // 
            this.lblVivere.AutoSize = true;
            this.lblVivere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVivere.Location = new System.Drawing.Point(45, 99);
            this.lblVivere.Name = "lblVivere";
            this.lblVivere.Size = new System.Drawing.Size(57, 20);
            this.lblVivere.TabIndex = 2;
            this.lblVivere.Text = "Vivere:";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(211, 45);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(187, 26);
            this.txtClave.TabIndex = 1;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(45, 48);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(52, 20);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave:";
            // 
            // errorIcon
            // 
            this.errorIcon.ContainerControl = this;
            // 
            // frmViveres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(921, 618);
            this.Controls.Add(this.tabViveres);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViveres";
            this.Text = "VIVERES";
            this.Load += new System.EventHandler(this.frmViveres_Load);
            this.tabViveres.ResumeLayout(false);
            this.pagListado.ResumeLayout(false);
            this.grpListado.ResumeLayout(false);
            this.grpListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViveres)).EndInit();
            this.pagMantemiento.ResumeLayout(false);
            this.gpMantenimiento.ResumeLayout(false);
            this.gpMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabViveres;
        private System.Windows.Forms.TabPage pagListado;
        private System.Windows.Forms.TabPage pagMantemiento;
        private System.Windows.Forms.GroupBox grpListado;
        private System.Windows.Forms.ErrorProvider errorIcon;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.DataGridView dataViveres;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtTextoBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gpMantenimiento;
        private System.Windows.Forms.TextBox txtVivere;
        private System.Windows.Forms.Label lblVivere;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtProteinas;
        private System.Windows.Forms.Label lblProteinas;
        private System.Windows.Forms.TextBox txtHidratos;
        private System.Windows.Forms.Label lblHidratos;
        private System.Windows.Forms.TextBox txtGrasa;
        private System.Windows.Forms.Label lblGrasa;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Label lblUnidad;
    }
}