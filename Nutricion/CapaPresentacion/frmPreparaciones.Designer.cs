namespace CapaPresentacion
{
    partial class frmPreparaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreparaciones));
            this.tabPreparaciones = new System.Windows.Forms.TabControl();
            this.pagListado = new System.Windows.Forms.TabPage();
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtTextoBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataPreparaciones = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pagMantemiento = new System.Windows.Forms.TabPage();
            this.gpPreparaciones = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBuscarVivere = new System.Windows.Forms.TextBox();
            this.btnEliminarIngrediente = new System.Windows.Forms.Button();
            this.chkEliminaIngrediente = new System.Windows.Forms.CheckBox();
            this.btnCargarIngrediente = new System.Windows.Forms.PictureBox();
            this.btnBorrarImagen = new System.Windows.Forms.Button();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.pxImagen = new System.Windows.Forms.PictureBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.lblListadoViveres = new System.Windows.Forms.Label();
            this.dataIngredientes = new System.Windows.Forms.DataGridView();
            this.Borrar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataListadoViveres = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtPreparacion = new System.Windows.Forms.TextBox();
            this.lblPreparacion = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabPreparaciones.SuspendLayout();
            this.pagListado.SuspendLayout();
            this.grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPreparaciones)).BeginInit();
            this.pagMantemiento.SuspendLayout();
            this.gpPreparaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCargarIngrediente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataIngredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoViveres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPreparaciones
            // 
            this.tabPreparaciones.Controls.Add(this.pagListado);
            this.tabPreparaciones.Controls.Add(this.pagMantemiento);
            this.tabPreparaciones.Location = new System.Drawing.Point(1, 1);
            this.tabPreparaciones.Name = "tabPreparaciones";
            this.tabPreparaciones.SelectedIndex = 0;
            this.tabPreparaciones.Size = new System.Drawing.Size(1286, 673);
            this.tabPreparaciones.TabIndex = 1;
            // 
            // pagListado
            // 
            this.pagListado.BackColor = System.Drawing.Color.CadetBlue;
            this.pagListado.Controls.Add(this.grpListado);
            this.pagListado.ForeColor = System.Drawing.Color.Black;
            this.pagListado.Location = new System.Drawing.Point(4, 22);
            this.pagListado.Name = "pagListado";
            this.pagListado.Padding = new System.Windows.Forms.Padding(3);
            this.pagListado.Size = new System.Drawing.Size(1278, 647);
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
            this.grpListado.Controls.Add(this.dataPreparaciones);
            this.grpListado.Location = new System.Drawing.Point(7, 8);
            this.grpListado.Name = "grpListado";
            this.grpListado.Size = new System.Drawing.Size(1265, 633);
            this.grpListado.TabIndex = 0;
            this.grpListado.TabStop = false;
            this.grpListado.Text = "Listado";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminar.Location = new System.Drawing.Point(22, 100);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(105, 24);
            this.chkEliminar.TabIndex = 4;
            this.chkEliminar.Text = "ELIMINAR";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.SlateGray;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::CapaPresentacion.Properties.Resources.borrar_amarillo_32;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(22, 37);
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
            this.txtTextoBuscar.Location = new System.Drawing.Point(503, 38);
            this.txtTextoBuscar.Name = "txtTextoBuscar";
            this.txtTextoBuscar.Size = new System.Drawing.Size(294, 26);
            this.txtTextoBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SlateGray;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::CapaPresentacion.Properties.Resources.buscar_amarillo_32;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(260, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(203, 38);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "&BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dataPreparaciones
            // 
            this.dataPreparaciones.AllowUserToAddRows = false;
            this.dataPreparaciones.AllowUserToDeleteRows = false;
            this.dataPreparaciones.AllowUserToOrderColumns = true;
            this.dataPreparaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataPreparaciones.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataPreparaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPreparaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPreparaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPreparaciones.ColumnHeadersHeight = 60;
            this.dataPreparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataPreparaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPreparaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataPreparaciones.Location = new System.Drawing.Point(22, 142);
            this.dataPreparaciones.Name = "dataPreparaciones";
            this.dataPreparaciones.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPreparaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataPreparaciones.Size = new System.Drawing.Size(1237, 485);
            this.dataPreparaciones.TabIndex = 0;
            this.dataPreparaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPreparaciones_CellContentClick);
            this.dataPreparaciones.DoubleClick += new System.EventHandler(this.dataPreparaciones_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Visible = false;
            this.Eliminar.Width = 74;
            // 
            // pagMantemiento
            // 
            this.pagMantemiento.BackColor = System.Drawing.Color.LightSlateGray;
            this.pagMantemiento.Controls.Add(this.gpPreparaciones);
            this.pagMantemiento.Location = new System.Drawing.Point(4, 22);
            this.pagMantemiento.Name = "pagMantemiento";
            this.pagMantemiento.Padding = new System.Windows.Forms.Padding(3);
            this.pagMantemiento.Size = new System.Drawing.Size(1278, 647);
            this.pagMantemiento.TabIndex = 1;
            this.pagMantemiento.Text = "Mantenimiento";
            // 
            // gpPreparaciones
            // 
            this.gpPreparaciones.BackColor = System.Drawing.Color.Transparent;
            this.gpPreparaciones.Controls.Add(this.pictureBox1);
            this.gpPreparaciones.Controls.Add(this.txtBuscarVivere);
            this.gpPreparaciones.Controls.Add(this.btnEliminarIngrediente);
            this.gpPreparaciones.Controls.Add(this.chkEliminaIngrediente);
            this.gpPreparaciones.Controls.Add(this.btnCargarIngrediente);
            this.gpPreparaciones.Controls.Add(this.btnBorrarImagen);
            this.gpPreparaciones.Controls.Add(this.btnCargarImagen);
            this.gpPreparaciones.Controls.Add(this.pxImagen);
            this.gpPreparaciones.Controls.Add(this.cmbTipo);
            this.gpPreparaciones.Controls.Add(this.lblIngredientes);
            this.gpPreparaciones.Controls.Add(this.lblListadoViveres);
            this.gpPreparaciones.Controls.Add(this.dataIngredientes);
            this.gpPreparaciones.Controls.Add(this.dataListadoViveres);
            this.gpPreparaciones.Controls.Add(this.btnCancelar);
            this.gpPreparaciones.Controls.Add(this.btnNuevo);
            this.gpPreparaciones.Controls.Add(this.btnEditar);
            this.gpPreparaciones.Controls.Add(this.btnGuardar);
            this.gpPreparaciones.Controls.Add(this.lblTipo);
            this.gpPreparaciones.Controls.Add(this.txtPreparacion);
            this.gpPreparaciones.Controls.Add(this.lblPreparacion);
            this.gpPreparaciones.Controls.Add(this.txtClave);
            this.gpPreparaciones.Controls.Add(this.lblClave);
            this.gpPreparaciones.Location = new System.Drawing.Point(7, 6);
            this.gpPreparaciones.Name = "gpPreparaciones";
            this.gpPreparaciones.Size = new System.Drawing.Size(1255, 623);
            this.gpPreparaciones.TabIndex = 0;
            this.gpPreparaciones.TabStop = false;
            this.gpPreparaciones.Text = "Mantenimiento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.lupa_1;
            this.pictureBox1.Location = new System.Drawing.Point(379, 234);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // txtBuscarVivere
            // 
            this.txtBuscarVivere.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBuscarVivere.Font = new System.Drawing.Font("Swis721 Blk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarVivere.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarVivere.Location = new System.Drawing.Point(170, 243);
            this.txtBuscarVivere.Name = "txtBuscarVivere";
            this.txtBuscarVivere.Size = new System.Drawing.Size(203, 25);
            this.txtBuscarVivere.TabIndex = 27;
            this.txtBuscarVivere.Click += new System.EventHandler(this.txtBuscarVivere_Click);
            this.txtBuscarVivere.TextChanged += new System.EventHandler(this.txtBuscarVivere_TextChanged);
            // 
            // btnEliminarIngrediente
            // 
            this.btnEliminarIngrediente.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnEliminarIngrediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarIngrediente.ForeColor = System.Drawing.Color.White;
            this.btnEliminarIngrediente.Image = global::CapaPresentacion.Properties.Resources.borrar_amarillo_32;
            this.btnEliminarIngrediente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarIngrediente.Location = new System.Drawing.Point(955, 162);
            this.btnEliminarIngrediente.Name = "btnEliminarIngrediente";
            this.btnEliminarIngrediente.Size = new System.Drawing.Size(219, 38);
            this.btnEliminarIngrediente.TabIndex = 26;
            this.btnEliminarIngrediente.Text = "Eliminar Ingredien&te";
            this.btnEliminarIngrediente.UseVisualStyleBackColor = false;
            this.btnEliminarIngrediente.Click += new System.EventHandler(this.btnEliminarIngrediente_Click);
            // 
            // chkEliminaIngrediente
            // 
            this.chkEliminaIngrediente.AutoSize = true;
            this.chkEliminaIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminaIngrediente.Location = new System.Drawing.Point(811, 178);
            this.chkEliminaIngrediente.Name = "chkEliminaIngrediente";
            this.chkEliminaIngrediente.Size = new System.Drawing.Size(105, 24);
            this.chkEliminaIngrediente.TabIndex = 25;
            this.chkEliminaIngrediente.Text = "ELIMINAR";
            this.chkEliminaIngrediente.UseVisualStyleBackColor = true;
            this.chkEliminaIngrediente.CheckedChanged += new System.EventHandler(this.chkEliminaIngrediente_CheckedChanged);
            this.chkEliminaIngrediente.Click += new System.EventHandler(this.chkEliminaIngrediente_Click);
            // 
            // btnCargarIngrediente
            // 
            this.btnCargarIngrediente.Image = global::CapaPresentacion.Properties.Resources.flecha_1;
            this.btnCargarIngrediente.Location = new System.Drawing.Point(551, 328);
            this.btnCargarIngrediente.Name = "btnCargarIngrediente";
            this.btnCargarIngrediente.Size = new System.Drawing.Size(206, 159);
            this.btnCargarIngrediente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCargarIngrediente.TabIndex = 24;
            this.btnCargarIngrediente.TabStop = false;
            this.btnCargarIngrediente.Click += new System.EventHandler(this.btnCargarIngrediente_Click);
            // 
            // btnBorrarImagen
            // 
            this.btnBorrarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarImagen.Image = global::CapaPresentacion.Properties.Resources.borrar_rojo_64;
            this.btnBorrarImagen.Location = new System.Drawing.Point(651, 15);
            this.btnBorrarImagen.Name = "btnBorrarImagen";
            this.btnBorrarImagen.Size = new System.Drawing.Size(56, 56);
            this.btnBorrarImagen.TabIndex = 23;
            this.btnBorrarImagen.UseVisualStyleBackColor = true;
            this.btnBorrarImagen.Click += new System.EventHandler(this.btnBorrarImagen_Click);
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarImagen.Image = global::CapaPresentacion.Properties.Resources.guardar_amarillo_64;
            this.btnCargarImagen.Location = new System.Drawing.Point(651, 162);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(56, 56);
            this.btnCargarImagen.TabIndex = 22;
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // pxImagen
            // 
            this.pxImagen.Image = global::CapaPresentacion.Properties.Resources.Preparacion_logo;
            this.pxImagen.Location = new System.Drawing.Point(433, 15);
            this.pxImagen.Name = "pxImagen";
            this.pxImagen.Size = new System.Drawing.Size(212, 203);
            this.pxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxImagen.TabIndex = 21;
            this.pxImagen.TabStop = false;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(119, 117);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(267, 28);
            this.cmbTipo.TabIndex = 20;
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientes.ForeColor = System.Drawing.Color.White;
            this.lblIngredientes.Location = new System.Drawing.Point(938, 211);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(143, 20);
            this.lblIngredientes.TabIndex = 19;
            this.lblIngredientes.Text = "INGREDIENTES";
            // 
            // lblListadoViveres
            // 
            this.lblListadoViveres.AutoSize = true;
            this.lblListadoViveres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoViveres.ForeColor = System.Drawing.Color.White;
            this.lblListadoViveres.Location = new System.Drawing.Point(174, 211);
            this.lblListadoViveres.Name = "lblListadoViveres";
            this.lblListadoViveres.Size = new System.Drawing.Size(199, 20);
            this.lblListadoViveres.TabIndex = 18;
            this.lblListadoViveres.Text = "LISTADO DE VIVERES";
            // 
            // dataIngredientes
            // 
            this.dataIngredientes.AllowDrop = true;
            this.dataIngredientes.AllowUserToAddRows = false;
            this.dataIngredientes.AllowUserToDeleteRows = false;
            this.dataIngredientes.AllowUserToOrderColumns = true;
            this.dataIngredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataIngredientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataIngredientes.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataIngredientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataIngredientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataIngredientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataIngredientes.ColumnHeadersHeight = 50;
            this.dataIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataIngredientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Borrar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataIngredientes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataIngredientes.GridColor = System.Drawing.Color.White;
            this.dataIngredientes.Location = new System.Drawing.Point(811, 243);
            this.dataIngredientes.Name = "dataIngredientes";
            this.dataIngredientes.ReadOnly = true;
            this.dataIngredientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataIngredientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataIngredientes.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataIngredientes.Size = new System.Drawing.Size(433, 362);
            this.dataIngredientes.TabIndex = 17;
            this.dataIngredientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataIngredientes_CellContentClick);
            this.dataIngredientes.Click += new System.EventHandler(this.dataIngredientes_Click);
            this.dataIngredientes.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataIngredientes_DragDrop);
            this.dataIngredientes.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataIngredientes_DragEnter);
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Eliminar";
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Visible = false;
            // 
            // dataListadoViveres
            // 
            this.dataListadoViveres.AllowDrop = true;
            this.dataListadoViveres.AllowUserToAddRows = false;
            this.dataListadoViveres.AllowUserToDeleteRows = false;
            this.dataListadoViveres.AllowUserToOrderColumns = true;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightGray;
            this.dataListadoViveres.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataListadoViveres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListadoViveres.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataListadoViveres.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataListadoViveres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListadoViveres.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListadoViveres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataListadoViveres.ColumnHeadersHeight = 60;
            this.dataListadoViveres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListadoViveres.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataListadoViveres.EnableHeadersVisualStyles = false;
            this.dataListadoViveres.GridColor = System.Drawing.Color.White;
            this.dataListadoViveres.Location = new System.Drawing.Point(53, 272);
            this.dataListadoViveres.Name = "dataListadoViveres";
            this.dataListadoViveres.ReadOnly = true;
            this.dataListadoViveres.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListadoViveres.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Maroon;
            this.dataListadoViveres.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataListadoViveres.Size = new System.Drawing.Size(433, 333);
            this.dataListadoViveres.TabIndex = 16;
            this.dataListadoViveres.Click += new System.EventHandler(this.dataListadoViveres_Click);
            this.dataListadoViveres.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataListadoViveres_MouseDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.cancelar_32;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(997, 70);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 38);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Maroon;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.Nuevo_32;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(791, 71);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(156, 38);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Maroon;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = global::CapaPresentacion.Properties.Resources.editar_32;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(997, 18);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(156, 38);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Maroon;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::CapaPresentacion.Properties.Resources.guardar_amarillo_32;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(791, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(156, 38);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(15, 118);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtPreparacion
            // 
            this.txtPreparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreparacion.Location = new System.Drawing.Point(119, 73);
            this.txtPreparacion.Name = "txtPreparacion";
            this.txtPreparacion.Size = new System.Drawing.Size(267, 26);
            this.txtPreparacion.TabIndex = 3;
            // 
            // lblPreparacion
            // 
            this.lblPreparacion.AutoSize = true;
            this.lblPreparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparacion.Location = new System.Drawing.Point(15, 76);
            this.lblPreparacion.Name = "lblPreparacion";
            this.lblPreparacion.Size = new System.Drawing.Size(98, 20);
            this.lblPreparacion.TabIndex = 2;
            this.lblPreparacion.Text = "Preparación:";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(119, 32);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(187, 26);
            this.txtClave.TabIndex = 1;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(15, 35);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(52, 20);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave:";
            // 
            // errorIcon
            // 
            this.errorIcon.ContainerControl = this;
            // 
            // frmPreparaciones
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1299, 686);
            this.Controls.Add(this.tabPreparaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPreparaciones";
            this.Text = "FORMULARIO DE PREPARACIONES";
            this.Load += new System.EventHandler(this.frmPreparaciones_Load);
            this.tabPreparaciones.ResumeLayout(false);
            this.pagListado.ResumeLayout(false);
            this.grpListado.ResumeLayout(false);
            this.grpListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPreparaciones)).EndInit();
            this.pagMantemiento.ResumeLayout(false);
            this.gpPreparaciones.ResumeLayout(false);
            this.gpPreparaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCargarIngrediente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataIngredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoViveres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPreparaciones;
        private System.Windows.Forms.TabPage pagListado;
        private System.Windows.Forms.GroupBox grpListado;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtTextoBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataPreparaciones;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TabPage pagMantemiento;
        private System.Windows.Forms.GroupBox gpPreparaciones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtPreparacion;
        private System.Windows.Forms.Label lblPreparacion;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.DataGridView dataListadoViveres;
        private System.Windows.Forms.DataGridView dataIngredientes;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.ErrorProvider errorIcon;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.Label lblListadoViveres;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.PictureBox pxImagen;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Button btnBorrarImagen;
        private System.Windows.Forms.PictureBox btnCargarIngrediente;
        private System.Windows.Forms.CheckBox chkEliminaIngrediente;
        private System.Windows.Forms.Button btnEliminarIngrediente;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Borrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscarVivere;
    }
}