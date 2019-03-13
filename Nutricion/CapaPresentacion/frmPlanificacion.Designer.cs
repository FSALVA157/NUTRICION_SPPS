namespace CapaPresentacion
{
    partial class frmPlanificacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanificacion));
            this.errorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.Borrar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.txtBuscarVivere = new System.Windows.Forms.TextBox();
            this.chkEliminaIngrediente = new System.Windows.Forms.CheckBox();
            this.gpPlanificacion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataIngredientes = new System.Windows.Forms.DataGridView();
            this.cmbPreparacion = new System.Windows.Forms.ComboBox();
            this.lblPreparacion = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEliminarIngrediente = new System.Windows.Forms.Button();
            this.btnCalculoViveres = new System.Windows.Forms.PictureBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.lblListadoViveres = new System.Windows.Forms.Label();
            this.dataDetallePlanificacion = new System.Windows.Forms.DataGridView();
            this.dataListadoPreparaciones = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtRaciones = new System.Windows.Forms.TextBox();
            this.lblRaciones = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.pagListado = new System.Windows.Forms.TabPage();
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtTextoBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataPlanificaciones = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pagMantemiento = new System.Windows.Forms.TabPage();
            this.tabPlanificaciones = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            this.gpPlanificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataIngredientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalculoViveres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetallePlanificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoPreparaciones)).BeginInit();
            this.pagListado.SuspendLayout();
            this.grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPlanificaciones)).BeginInit();
            this.pagMantemiento.SuspendLayout();
            this.tabPlanificaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorIcon
            // 
            this.errorIcon.ContainerControl = this;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Eliminar";
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Visible = false;
            // 
            // txtBuscarVivere
            // 
            this.txtBuscarVivere.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtBuscarVivere.Font = new System.Drawing.Font("Swis721 Blk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarVivere.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarVivere.Location = new System.Drawing.Point(170, 308);
            this.txtBuscarVivere.Name = "txtBuscarVivere";
            this.txtBuscarVivere.Size = new System.Drawing.Size(203, 25);
            this.txtBuscarVivere.TabIndex = 27;
            this.txtBuscarVivere.TextChanged += new System.EventHandler(this.txtBuscarVivere_TextChanged);
            // 
            // chkEliminaIngrediente
            // 
            this.chkEliminaIngrediente.AutoSize = true;
            this.chkEliminaIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEliminaIngrediente.Location = new System.Drawing.Point(811, 271);
            this.chkEliminaIngrediente.Name = "chkEliminaIngrediente";
            this.chkEliminaIngrediente.Size = new System.Drawing.Size(105, 24);
            this.chkEliminaIngrediente.TabIndex = 25;
            this.chkEliminaIngrediente.Text = "ELIMINAR";
            this.chkEliminaIngrediente.UseVisualStyleBackColor = true;
            // 
            // gpPlanificacion
            // 
            this.gpPlanificacion.BackColor = System.Drawing.Color.Transparent;
            this.gpPlanificacion.Controls.Add(this.label1);
            this.gpPlanificacion.Controls.Add(this.dataIngredientes);
            this.gpPlanificacion.Controls.Add(this.cmbPreparacion);
            this.gpPlanificacion.Controls.Add(this.lblPreparacion);
            this.gpPlanificacion.Controls.Add(this.cmbDestino);
            this.gpPlanificacion.Controls.Add(this.lblDestino);
            this.gpPlanificacion.Controls.Add(this.txtFecha);
            this.gpPlanificacion.Controls.Add(this.lblFecha);
            this.gpPlanificacion.Controls.Add(this.monthCalendar1);
            this.gpPlanificacion.Controls.Add(this.pictureBox1);
            this.gpPlanificacion.Controls.Add(this.txtBuscarVivere);
            this.gpPlanificacion.Controls.Add(this.btnEliminarIngrediente);
            this.gpPlanificacion.Controls.Add(this.chkEliminaIngrediente);
            this.gpPlanificacion.Controls.Add(this.btnCalculoViveres);
            this.gpPlanificacion.Controls.Add(this.cmbTipo);
            this.gpPlanificacion.Controls.Add(this.lblIngredientes);
            this.gpPlanificacion.Controls.Add(this.lblListadoViveres);
            this.gpPlanificacion.Controls.Add(this.dataDetallePlanificacion);
            this.gpPlanificacion.Controls.Add(this.dataListadoPreparaciones);
            this.gpPlanificacion.Controls.Add(this.btnCancelar);
            this.gpPlanificacion.Controls.Add(this.btnNuevo);
            this.gpPlanificacion.Controls.Add(this.btnEditar);
            this.gpPlanificacion.Controls.Add(this.btnGuardar);
            this.gpPlanificacion.Controls.Add(this.lblTipo);
            this.gpPlanificacion.Controls.Add(this.txtRaciones);
            this.gpPlanificacion.Controls.Add(this.lblRaciones);
            this.gpPlanificacion.Controls.Add(this.txtClave);
            this.gpPlanificacion.Controls.Add(this.lblClave);
            this.gpPlanificacion.ForeColor = System.Drawing.Color.White;
            this.gpPlanificacion.Location = new System.Drawing.Point(7, 6);
            this.gpPlanificacion.Name = "gpPlanificacion";
            this.gpPlanificacion.Size = new System.Drawing.Size(1255, 678);
            this.gpPlanificacion.TabIndex = 0;
            this.gpPlanificacion.TabStop = false;
            this.gpPlanificacion.Text = "Mantenimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(801, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "LISTADO DE VIVERES PARA ESTA PLANIFICACION";
            // 
            // dataIngredientes
            // 
            this.dataIngredientes.AllowUserToAddRows = false;
            this.dataIngredientes.AllowUserToDeleteRows = false;
            this.dataIngredientes.AllowUserToOrderColumns = true;
            this.dataIngredientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataIngredientes.BackgroundColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataIngredientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataIngredientes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataIngredientes.Location = new System.Drawing.Point(54, 559);
            this.dataIngredientes.Name = "dataIngredientes";
            this.dataIngredientes.ReadOnly = true;
            this.dataIngredientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataIngredientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataIngredientes.Size = new System.Drawing.Size(431, 111);
            this.dataIngredientes.TabIndex = 37;
            // 
            // cmbPreparacion
            // 
            this.cmbPreparacion.AllowDrop = true;
            this.cmbPreparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPreparacion.FormattingEnabled = true;
            this.cmbPreparacion.Location = new System.Drawing.Point(149, 487);
            this.cmbPreparacion.Name = "cmbPreparacion";
            this.cmbPreparacion.Size = new System.Drawing.Size(267, 28);
            this.cmbPreparacion.TabIndex = 36;
            this.cmbPreparacion.DragDrop += new System.Windows.Forms.DragEventHandler(this.cmbPreparacion_DragDrop);
            this.cmbPreparacion.DragEnter += new System.Windows.Forms.DragEventHandler(this.cmbPreparacion_DragEnter);
            // 
            // lblPreparacion
            // 
            this.lblPreparacion.AutoSize = true;
            this.lblPreparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparacion.Location = new System.Drawing.Point(215, 463);
            this.lblPreparacion.Name = "lblPreparacion";
            this.lblPreparacion.Size = new System.Drawing.Size(129, 20);
            this.lblPreparacion.TabIndex = 35;
            this.lblPreparacion.Text = "PREPARACION:";
            // 
            // cmbDestino
            // 
            this.cmbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(219, 123);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(267, 28);
            this.cmbDestino.TabIndex = 34;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(15, 123);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(123, 20);
            this.lblDestino.TabIndex = 33;
            this.lblDestino.Text = "Destino/Unidad:";
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(219, 77);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(267, 26);
            this.txtFecha.TabIndex = 32;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(15, 79);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(188, 20);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "Fecha de la Planificación:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.Khaki;
            this.monthCalendar1.Location = new System.Drawing.Point(594, 18);
            this.monthCalendar1.MaximumSize = new System.Drawing.Size(300, 300);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 29;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.Green;
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.Yellow;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.lupa_1;
            this.pictureBox1.Location = new System.Drawing.Point(397, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnEliminarIngrediente
            // 
            this.btnEliminarIngrediente.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnEliminarIngrediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarIngrediente.ForeColor = System.Drawing.Color.White;
            this.btnEliminarIngrediente.Image = global::CapaPresentacion.Properties.Resources.borrar_amarillo_32;
            this.btnEliminarIngrediente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarIngrediente.Location = new System.Drawing.Point(955, 255);
            this.btnEliminarIngrediente.Name = "btnEliminarIngrediente";
            this.btnEliminarIngrediente.Size = new System.Drawing.Size(219, 38);
            this.btnEliminarIngrediente.TabIndex = 26;
            this.btnEliminarIngrediente.Text = "Eliminar Ingredien&te";
            this.btnEliminarIngrediente.UseVisualStyleBackColor = false;
            // 
            // btnCalculoViveres
            // 
            this.btnCalculoViveres.Image = global::CapaPresentacion.Properties.Resources.calculator_128;
            this.btnCalculoViveres.Location = new System.Drawing.Point(551, 415);
            this.btnCalculoViveres.Name = "btnCalculoViveres";
            this.btnCalculoViveres.Size = new System.Drawing.Size(206, 159);
            this.btnCalculoViveres.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCalculoViveres.TabIndex = 24;
            this.btnCalculoViveres.TabStop = false;
            this.btnCalculoViveres.Click += new System.EventHandler(this.btnCalculoViveres_Click);
            this.btnCalculoViveres.DoubleClick += new System.EventHandler(this.btnCalculoViveres_DoubleClick);
            // 
            // cmbTipo
            // 
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(219, 172);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(267, 28);
            this.cmbTipo.TabIndex = 20;
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientes.ForeColor = System.Drawing.Color.White;
            this.lblIngredientes.Location = new System.Drawing.Point(203, 533);
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
            this.lblListadoViveres.Location = new System.Drawing.Point(145, 276);
            this.lblListadoViveres.Name = "lblListadoViveres";
            this.lblListadoViveres.Size = new System.Drawing.Size(271, 20);
            this.lblListadoViveres.TabIndex = 18;
            this.lblListadoViveres.Text = "LISTADO DE PREPARACIONES";
            // 
            // dataDetallePlanificacion
            // 
            this.dataDetallePlanificacion.AllowDrop = true;
            this.dataDetallePlanificacion.AllowUserToAddRows = false;
            this.dataDetallePlanificacion.AllowUserToDeleteRows = false;
            this.dataDetallePlanificacion.AllowUserToOrderColumns = true;
            this.dataDetallePlanificacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataDetallePlanificacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataDetallePlanificacion.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataDetallePlanificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataDetallePlanificacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDetallePlanificacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataDetallePlanificacion.ColumnHeadersHeight = 50;
            this.dataDetallePlanificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataDetallePlanificacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Borrar});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDetallePlanificacion.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataDetallePlanificacion.GridColor = System.Drawing.Color.White;
            this.dataDetallePlanificacion.Location = new System.Drawing.Point(793, 387);
            this.dataDetallePlanificacion.Name = "dataDetallePlanificacion";
            this.dataDetallePlanificacion.ReadOnly = true;
            this.dataDetallePlanificacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkOliveGreen;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDetallePlanificacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDetallePlanificacion.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataDetallePlanificacion.Size = new System.Drawing.Size(451, 283);
            this.dataDetallePlanificacion.TabIndex = 17;
            // 
            // dataListadoPreparaciones
            // 
            this.dataListadoPreparaciones.AllowDrop = true;
            this.dataListadoPreparaciones.AllowUserToAddRows = false;
            this.dataListadoPreparaciones.AllowUserToDeleteRows = false;
            this.dataListadoPreparaciones.AllowUserToOrderColumns = true;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightGray;
            this.dataListadoPreparaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataListadoPreparaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dataListadoPreparaciones.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.dataListadoPreparaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListadoPreparaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataListadoPreparaciones.ColumnHeadersHeight = 20;
            this.dataListadoPreparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListadoPreparaciones.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataListadoPreparaciones.EnableHeadersVisualStyles = false;
            this.dataListadoPreparaciones.GridColor = System.Drawing.Color.White;
            this.dataListadoPreparaciones.Location = new System.Drawing.Point(53, 363);
            this.dataListadoPreparaciones.Name = "dataListadoPreparaciones";
            this.dataListadoPreparaciones.ReadOnly = true;
            this.dataListadoPreparaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataListadoPreparaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListadoPreparaciones.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataListadoPreparaciones.Size = new System.Drawing.Size(433, 95);
            this.dataListadoPreparaciones.TabIndex = 16;
            this.dataListadoPreparaciones.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataListadoPreparaciones_MouseDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::CapaPresentacion.Properties.Resources.cancelar_32;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(1088, 69);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(156, 38);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.Nuevo_32;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(882, 70);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(156, 38);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = global::CapaPresentacion.Properties.Resources.editar_32;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(1088, 17);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(156, 38);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::CapaPresentacion.Properties.Resources.guardar_amarillo_32;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(882, 17);
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
            this.lblTipo.Location = new System.Drawing.Point(15, 172);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(161, 20);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo (almuerzo/cena):";
            // 
            // txtRaciones
            // 
            this.txtRaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaciones.Location = new System.Drawing.Point(219, 228);
            this.txtRaciones.Name = "txtRaciones";
            this.txtRaciones.Size = new System.Drawing.Size(267, 26);
            this.txtRaciones.TabIndex = 3;
            // 
            // lblRaciones
            // 
            this.lblRaciones.AutoSize = true;
            this.lblRaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRaciones.Location = new System.Drawing.Point(15, 230);
            this.lblRaciones.Name = "lblRaciones";
            this.lblRaciones.Size = new System.Drawing.Size(155, 20);
            this.lblRaciones.TabIndex = 2;
            this.lblRaciones.Text = "Raciones (cantidad):";
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(219, 33);
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
            // pagListado
            // 
            this.pagListado.BackColor = System.Drawing.Color.LightSlateGray;
            this.pagListado.Controls.Add(this.grpListado);
            this.pagListado.ForeColor = System.Drawing.Color.Black;
            this.pagListado.Location = new System.Drawing.Point(4, 22);
            this.pagListado.Name = "pagListado";
            this.pagListado.Padding = new System.Windows.Forms.Padding(3);
            this.pagListado.Size = new System.Drawing.Size(1278, 690);
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
            this.grpListado.Controls.Add(this.dataPlanificaciones);
            this.grpListado.Location = new System.Drawing.Point(7, 8);
            this.grpListado.Name = "grpListado";
            this.grpListado.Size = new System.Drawing.Size(1265, 645);
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
            this.btnEliminar.BackColor = System.Drawing.Color.Black;
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
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
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
            // dataPlanificaciones
            // 
            this.dataPlanificaciones.AllowUserToAddRows = false;
            this.dataPlanificaciones.AllowUserToDeleteRows = false;
            this.dataPlanificaciones.AllowUserToOrderColumns = true;
            this.dataPlanificaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataPlanificaciones.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataPlanificaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPlanificaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPlanificaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPlanificaciones.ColumnHeadersHeight = 60;
            this.dataPlanificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataPlanificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPlanificaciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataPlanificaciones.Location = new System.Drawing.Point(22, 130);
            this.dataPlanificaciones.Name = "dataPlanificaciones";
            this.dataPlanificaciones.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPlanificaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataPlanificaciones.Size = new System.Drawing.Size(1237, 285);
            this.dataPlanificaciones.TabIndex = 0;
            this.dataPlanificaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPlanificaciones_CellContentClick);
            this.dataPlanificaciones.DoubleClick += new System.EventHandler(this.dataPlanificaciones_DoubleClick);
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
            this.pagMantemiento.BackColor = System.Drawing.Color.SlateGray;
            this.pagMantemiento.Controls.Add(this.gpPlanificacion);
            this.pagMantemiento.Location = new System.Drawing.Point(4, 22);
            this.pagMantemiento.Name = "pagMantemiento";
            this.pagMantemiento.Padding = new System.Windows.Forms.Padding(3);
            this.pagMantemiento.Size = new System.Drawing.Size(1278, 690);
            this.pagMantemiento.TabIndex = 1;
            this.pagMantemiento.Text = "Mantenimiento";
            // 
            // tabPlanificaciones
            // 
            this.tabPlanificaciones.Controls.Add(this.pagListado);
            this.tabPlanificaciones.Controls.Add(this.pagMantemiento);
            this.tabPlanificaciones.Location = new System.Drawing.Point(0, 1);
            this.tabPlanificaciones.Name = "tabPlanificaciones";
            this.tabPlanificaciones.SelectedIndex = 0;
            this.tabPlanificaciones.Size = new System.Drawing.Size(1286, 716);
            this.tabPlanificaciones.TabIndex = 2;
            // 
            // frmPlanificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1289, 729);
            this.Controls.Add(this.tabPlanificaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPlanificacion";
            this.Text = "                              .:.  Formulario de Planificaciones  .:.";
            this.Load += new System.EventHandler(this.frmPlanificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            this.gpPlanificacion.ResumeLayout(false);
            this.gpPlanificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataIngredientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalculoViveres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetallePlanificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoPreparaciones)).EndInit();
            this.pagListado.ResumeLayout(false);
            this.grpListado.ResumeLayout(false);
            this.grpListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPlanificaciones)).EndInit();
            this.pagMantemiento.ResumeLayout(false);
            this.tabPlanificaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorIcon;
        private System.Windows.Forms.TabControl tabPlanificaciones;
        private System.Windows.Forms.TabPage pagListado;
        private System.Windows.Forms.GroupBox grpListado;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtTextoBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataPlanificaciones;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TabPage pagMantemiento;
        private System.Windows.Forms.GroupBox gpPlanificacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBuscarVivere;
        private System.Windows.Forms.Button btnEliminarIngrediente;
        private System.Windows.Forms.CheckBox chkEliminaIngrediente;
        private System.Windows.Forms.PictureBox btnCalculoViveres;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.Label lblListadoViveres;
        private System.Windows.Forms.DataGridView dataDetallePlanificacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Borrar;
        private System.Windows.Forms.DataGridView dataListadoPreparaciones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtRaciones;
        private System.Windows.Forms.Label lblRaciones;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbPreparacion;
        private System.Windows.Forms.Label lblPreparacion;
        private System.Windows.Forms.DataGridView dataIngredientes;
        private System.Windows.Forms.Label label1;
    }
}