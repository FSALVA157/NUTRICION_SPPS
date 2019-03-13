namespace CapaPresentacion
{
    partial class frmEstadisticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadisticas));
            this.tbEstadisticas = new System.Windows.Forms.TabControl();
            this.pagPlanifXUnidad = new System.Windows.Forms.TabPage();
            this.grpPlanificacion1 = new System.Windows.Forms.GroupBox();
            this.lblCena = new System.Windows.Forms.Label();
            this.dataCena = new System.Windows.Forms.DataGridView();
            this.lblDataAlmuerzo = new System.Windows.Forms.Label();
            this.dataAlmuerzo = new System.Windows.Forms.DataGridView();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.txtFechaPlan = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataViveresSecos = new System.Windows.Forms.DataGridView();
            this.lblVivSecos = new System.Windows.Forms.Label();
            this.lblVivFrescos = new System.Windows.Forms.Label();
            this.dataViveresFrescos = new System.Windows.Forms.DataGridView();
            this.tbEstadisticas.SuspendLayout();
            this.pagPlanifXUnidad.SuspendLayout();
            this.grpPlanificacion1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlmuerzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViveresSecos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViveresFrescos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEstadisticas
            // 
            this.tbEstadisticas.Controls.Add(this.pagPlanifXUnidad);
            this.tbEstadisticas.Controls.Add(this.tabPage2);
            this.tbEstadisticas.Location = new System.Drawing.Point(0, 0);
            this.tbEstadisticas.Name = "tbEstadisticas";
            this.tbEstadisticas.SelectedIndex = 0;
            this.tbEstadisticas.Size = new System.Drawing.Size(1055, 655);
            this.tbEstadisticas.TabIndex = 0;
            // 
            // pagPlanifXUnidad
            // 
            this.pagPlanifXUnidad.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pagPlanifXUnidad.Controls.Add(this.grpPlanificacion1);
            this.pagPlanifXUnidad.Location = new System.Drawing.Point(4, 22);
            this.pagPlanifXUnidad.Name = "pagPlanifXUnidad";
            this.pagPlanifXUnidad.Padding = new System.Windows.Forms.Padding(3);
            this.pagPlanifXUnidad.Size = new System.Drawing.Size(1047, 629);
            this.pagPlanifXUnidad.TabIndex = 0;
            this.pagPlanifXUnidad.Text = "Planificacion Segun Unidad";
            // 
            // grpPlanificacion1
            // 
            this.grpPlanificacion1.Controls.Add(this.dataViveresFrescos);
            this.grpPlanificacion1.Controls.Add(this.lblVivFrescos);
            this.grpPlanificacion1.Controls.Add(this.lblVivSecos);
            this.grpPlanificacion1.Controls.Add(this.dataViveresSecos);
            this.grpPlanificacion1.Controls.Add(this.lblCena);
            this.grpPlanificacion1.Controls.Add(this.dataCena);
            this.grpPlanificacion1.Controls.Add(this.lblDataAlmuerzo);
            this.grpPlanificacion1.Controls.Add(this.dataAlmuerzo);
            this.grpPlanificacion1.Controls.Add(this.monthCalendar2);
            this.grpPlanificacion1.Controls.Add(this.txtFechaPlan);
            this.grpPlanificacion1.Controls.Add(this.lblFecha);
            this.grpPlanificacion1.Controls.Add(this.lblDestino);
            this.grpPlanificacion1.Controls.Add(this.cmbDestino);
            this.grpPlanificacion1.Location = new System.Drawing.Point(14, 12);
            this.grpPlanificacion1.Name = "grpPlanificacion1";
            this.grpPlanificacion1.Size = new System.Drawing.Size(1027, 609);
            this.grpPlanificacion1.TabIndex = 0;
            this.grpPlanificacion1.TabStop = false;
            this.grpPlanificacion1.Text = "Planificacion";
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCena.Location = new System.Drawing.Point(611, 72);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(57, 20);
            this.lblCena.TabIndex = 34;
            this.lblCena.Text = "CENA";
            // 
            // dataCena
            // 
            this.dataCena.AllowUserToAddRows = false;
            this.dataCena.AllowUserToDeleteRows = false;
            this.dataCena.AllowUserToOrderColumns = true;
            this.dataCena.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataCena.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataCena.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataCena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataCena.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCena.Location = new System.Drawing.Point(468, 106);
            this.dataCena.Name = "dataCena";
            this.dataCena.ReadOnly = true;
            this.dataCena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataCena.Size = new System.Drawing.Size(356, 82);
            this.dataCena.TabIndex = 33;
            // 
            // lblDataAlmuerzo
            // 
            this.lblDataAlmuerzo.AutoSize = true;
            this.lblDataAlmuerzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAlmuerzo.Location = new System.Drawing.Point(149, 72);
            this.lblDataAlmuerzo.Name = "lblDataAlmuerzo";
            this.lblDataAlmuerzo.Size = new System.Drawing.Size(107, 20);
            this.lblDataAlmuerzo.TabIndex = 32;
            this.lblDataAlmuerzo.Text = "ALMUERZO";
            // 
            // dataAlmuerzo
            // 
            this.dataAlmuerzo.AllowUserToAddRows = false;
            this.dataAlmuerzo.AllowUserToDeleteRows = false;
            this.dataAlmuerzo.AllowUserToOrderColumns = true;
            this.dataAlmuerzo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataAlmuerzo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataAlmuerzo.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataAlmuerzo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataAlmuerzo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAlmuerzo.Location = new System.Drawing.Point(45, 106);
            this.dataAlmuerzo.Name = "dataAlmuerzo";
            this.dataAlmuerzo.ReadOnly = true;
            this.dataAlmuerzo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataAlmuerzo.Size = new System.Drawing.Size(356, 82);
            this.dataAlmuerzo.TabIndex = 31;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.BackColor = System.Drawing.Color.Gray;
            this.monthCalendar2.Location = new System.Drawing.Point(838, 9);
            this.monthCalendar2.MaximumSize = new System.Drawing.Size(300, 300);
            this.monthCalendar2.MaxSelectionCount = 1;
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 30;
            this.monthCalendar2.TitleBackColor = System.Drawing.Color.Black;
            this.monthCalendar2.TitleForeColor = System.Drawing.Color.Yellow;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // txtFechaPlan
            // 
            this.txtFechaPlan.Location = new System.Drawing.Point(575, 33);
            this.txtFechaPlan.Name = "txtFechaPlan";
            this.txtFechaPlan.Size = new System.Drawing.Size(150, 20);
            this.txtFechaPlan.TabIndex = 3;
            this.txtFechaPlan.TextChanged += new System.EventHandler(this.txtFechaPlan_TextChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(495, 34);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(64, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(41, 34);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(76, 20);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino:";
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(123, 33);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(261, 21);
            this.cmbDestino.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1047, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataViveresSecos
            // 
            this.dataViveresSecos.AllowUserToAddRows = false;
            this.dataViveresSecos.AllowUserToDeleteRows = false;
            this.dataViveresSecos.AllowUserToOrderColumns = true;
            this.dataViveresSecos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataViveresSecos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataViveresSecos.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataViveresSecos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataViveresSecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViveresSecos.Location = new System.Drawing.Point(71, 274);
            this.dataViveresSecos.Name = "dataViveresSecos";
            this.dataViveresSecos.ReadOnly = true;
            this.dataViveresSecos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataViveresSecos.Size = new System.Drawing.Size(442, 300);
            this.dataViveresSecos.TabIndex = 35;
            // 
            // lblVivSecos
            // 
            this.lblVivSecos.AutoSize = true;
            this.lblVivSecos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVivSecos.Location = new System.Drawing.Point(216, 239);
            this.lblVivSecos.Name = "lblVivSecos";
            this.lblVivSecos.Size = new System.Drawing.Size(154, 20);
            this.lblVivSecos.TabIndex = 36;
            this.lblVivSecos.Text = "VIVERES SECOS";
            // 
            // lblVivFrescos
            // 
            this.lblVivFrescos.AutoSize = true;
            this.lblVivFrescos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVivFrescos.Location = new System.Drawing.Point(716, 239);
            this.lblVivFrescos.Name = "lblVivFrescos";
            this.lblVivFrescos.Size = new System.Drawing.Size(178, 20);
            this.lblVivFrescos.TabIndex = 37;
            this.lblVivFrescos.Text = "VIVERES FRESCOS";
            // 
            // dataViveresFrescos
            // 
            this.dataViveresFrescos.AllowUserToAddRows = false;
            this.dataViveresFrescos.AllowUserToDeleteRows = false;
            this.dataViveresFrescos.AllowUserToOrderColumns = true;
            this.dataViveresFrescos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataViveresFrescos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataViveresFrescos.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataViveresFrescos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataViveresFrescos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViveresFrescos.Location = new System.Drawing.Point(575, 274);
            this.dataViveresFrescos.Name = "dataViveresFrescos";
            this.dataViveresFrescos.ReadOnly = true;
            this.dataViveresFrescos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataViveresFrescos.Size = new System.Drawing.Size(442, 300);
            this.dataViveresFrescos.TabIndex = 38;
            // 
            // frmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 655);
            this.Controls.Add(this.tbEstadisticas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstadisticas";
            this.Text = "frmEstadisticas";
            this.Load += new System.EventHandler(this.frmEstadisticas_Load);
            this.tbEstadisticas.ResumeLayout(false);
            this.pagPlanifXUnidad.ResumeLayout(false);
            this.grpPlanificacion1.ResumeLayout(false);
            this.grpPlanificacion1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlmuerzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViveresSecos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataViveresFrescos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbEstadisticas;
        private System.Windows.Forms.TabPage pagPlanifXUnidad;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpPlanificacion1;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFechaPlan;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.DataGridView dataAlmuerzo;
        private System.Windows.Forms.Label lblDataAlmuerzo;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.DataGridView dataCena;
        private System.Windows.Forms.Label lblVivFrescos;
        private System.Windows.Forms.Label lblVivSecos;
        private System.Windows.Forms.DataGridView dataViveresSecos;
        private System.Windows.Forms.DataGridView dataViveresFrescos;
    }
}