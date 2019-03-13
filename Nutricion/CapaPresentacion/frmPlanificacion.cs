using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmPlanificacion : Form
    {
        private bool isNuevo = false;
        private bool isEditar = false;

        public frmPlanificacion()
        {
            InitializeComponent();
            this.LLenar_DataPlanificaciones();
            this.LLenarCmbDestinos();
            this.LLenarCmbTipo_Comida();
            this.LlenarCmbPreparaciones();
            this.LLenarDataListadoPreparaciones();
        }

        #region mensajes
        public void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SISTEMA INFORMATICO DE LA DIVISION NUTRICION DEL S.P.P.S.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SISTEMA INFORMATICO DE LA DIVISION NUTRICION DEL S.P.P.S.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        #endregion mensajes

        #region Listas_y_DataGridView

        public void LLenar_DataPlanificaciones()
        {//inicio llenar planificaciones
            this.dataPlanificaciones.DataSource = NPlanificacion.Mostrar();
        }//fin llenar planificaciones

        public void LLenarCmbDestinos()
        {//inicio llenar Destinos
            this.cmbDestino.DataSource = NDestinos.Mostrar();
            this.cmbDestino.DisplayMember = "unidad";
            this.cmbDestino.ValueMember = "clave";
        }//fin llenar Destinos

        public void LLenarCmbTipo_Comida()
        {//inicio llenar Destinos
            this.cmbTipo.DataSource = NTipo_Comida.Mostrar();
            this.cmbTipo.DisplayMember = "tipo";
            this.cmbTipo.ValueMember = "clave";
        }//fin llenar Destinos

        public void LlenarCmbPreparaciones()
        {
            this.cmbPreparacion.DataSource = NPreparacion.Mostrar();
            this.cmbPreparacion.DisplayMember = "preparacion";
            this.cmbPreparacion.ValueMember = "clave";
        }

        public void LLenarDataListadoPreparaciones()
        {
            this.dataListadoPreparaciones.DataSource = NPreparacion.Mostrar();
        }

        public void LlenarDataIngredientes()
        {
            this.dataIngredientes.DataSource = NVivere_Preparacion.Buscar_X_Preparacion(Convert.ToInt32(this.cmbPreparacion.SelectedValue));
        }

        #endregion Listas

        #region Metodos Varios
        private void Habilitar(bool valor)
        {

            this.txtFecha.ReadOnly = !valor;
            this.txtRaciones.ReadOnly = !valor;
            this.txtBuscarVivere.ReadOnly = !valor;
            this.cmbDestino.Enabled = valor;
            this.cmbTipo.Enabled = valor;
            this.cmbPreparacion.Enabled = valor;
            this.dataListadoPreparaciones.Enabled = valor;
          //  this.dataPlanificaciones.Enabled = valor;
          //  this.dataDetallePlanificacion.Enabled = valor;
        }

        private void Botones()
        {
            if (isEditar || isNuevo)
            {
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
                this.btnCalculoViveres.Enabled = true;
                this.btnNuevo.Enabled = false;
                this.btnEditar.Enabled = false;
            }
            else
            {
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnCalculoViveres.Enabled = false;
                this.btnNuevo.Enabled = true;
                this.btnEditar.Enabled = true;
            }
        }

        private void Limpiar()
        {
            this.txtClave.Text = String.Empty;
            this.txtFecha.Text= String.Empty;
            this.txtRaciones.Text = String.Empty;
            this.txtBuscarVivere.Text = String.Empty;
           // this.dataListadoPreparaciones.DataSource = null;
         //   this.dataPlanificaciones.DataSource = null;
//            this.dataDetallePlanificacion.DataSource = null;

            
        }

        #endregion metodos Varios



        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.txtFecha.Text = this.monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void frmPlanificacion_Load(object sender, EventArgs e)
        {
            this.txtClave.Enabled = false;
            this.ttMensaje.SetToolTip(this.txtFecha, "Debe Ingresar la FECHA de la Planificación");
            this.ttMensaje.SetToolTip(this.txtRaciones, "Debe cargar el número de raciones");
            this.LLenar_DataPlanificaciones();
            
            this.Habilitar(false);
            this.Botones();

        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkEliminar.Checked)
            {
                this.dataPlanificaciones.Columns[0].Visible = true;
            }
            else
            {
                this.dataPlanificaciones.Columns[0].Visible = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = new DialogResult();
                opcion = MessageBox.Show("Confirma la Eliminación de los registros seleccionados?",
                    "SISTEMA NUTRICION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (opcion == DialogResult.Yes)
                {
                    string rpta = "";
                    foreach (DataGridViewRow fila in this.dataPlanificaciones.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells[0].Value))
                        {
                            rpta = NPlanificacion.Eliminar(Convert.ToInt32(fila.Cells["clave"].Value));
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("El registro ha sido eliminado con exito");
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }
                        }
                    }
                    this.LLenar_DataPlanificaciones();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataPlanificaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataPlanificaciones.Columns["Eliminar"].Index == e.ColumnIndex)
            {
                DataGridViewCheckBoxCell checkB = (DataGridViewCheckBoxCell)(this.dataPlanificaciones.Rows[e.RowIndex].Cells["Eliminar"]);
                checkB.Value = !Convert.ToBoolean(checkB.Value);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //this.MensajeOk(this.cmbPreparacion.SelectedValue.ToString());
                string rpta = "";
                
                if (this.txtFecha.Text == String.Empty || this.cmbDestino.SelectedValue.ToString() == String.Empty
                    || this.cmbTipo.SelectedValue.ToString() == String.Empty || this.txtRaciones.Text == String.Empty
                    || this.cmbPreparacion.SelectedValue.ToString() == String.Empty)
                {
                    this.MensajeError("Existen Datos Obligatorios sin Completar, los mismos seran señalados");
                    this.errorIcon.SetError(this.txtFecha, "Debe ingresar una fecha para la planificación");
                    this.errorIcon.SetError(this.cmbDestino, "Debe seleccionar un destino o dependencia");
                    this.errorIcon.SetError(this.cmbTipo, "Debe seleccionar ALMUERZO o CENA");
                    this.errorIcon.SetError(this.txtRaciones, "Ingrese una cantidad de raciones por favor");
                    this.errorIcon.SetError(this.cmbPreparacion, "Selecciona una Preparación para cargar en la Planificación");
                }
                else
                {
                    

                    if (isNuevo)
                    {
                        this.MensajeOk("fecha " + this.txtFecha.Text.ToString().Trim());
                        this.MensajeOk("destino " + this.cmbDestino.SelectedValue.ToString().Trim());
                        this.MensajeOk("preparacion " + this.cmbPreparacion.SelectedValue.ToString().Trim());
                        this.MensajeOk("raciones " + this.txtRaciones.Text.ToString().Trim());
                        this.MensajeOk("tipo " + this.cmbTipo.SelectedValue.ToString().Trim());

                        rpta = CapaNegocio.NPlanificacion.Insertar(this.txtFecha.Text.ToString().Trim(),Convert.ToInt32(this.cmbDestino.SelectedValue),
                            Convert.ToInt32(this.cmbPreparacion.SelectedValue), Convert.ToInt32(this.txtRaciones.Text.ToString()),
                            Convert.ToInt32(this.cmbTipo.SelectedValue));
                    }
                    else
                    {
                        rpta = CapaNegocio.NPlanificacion.Editar(Convert.ToInt32(this.txtClave.Text),this.txtFecha.Text.ToString().Trim(), Convert.ToInt32(this.cmbDestino.SelectedValue),
                            Convert.ToInt32(this.cmbPreparacion.SelectedValue), Convert.ToInt32(this.txtRaciones.Text),
                            Convert.ToInt32(this.cmbTipo.SelectedValue));
                    }

                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se ha agragado con Exito el Nuevo Registro!");
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                    this.isNuevo = false;
                    this.isEditar = false;
                    this.Habilitar(false);
                    this.Botones();
                    this.Limpiar();
                    this.LLenar_DataPlanificaciones();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            isNuevo = true;
            isEditar = false;
            Limpiar();
            this.Habilitar(true);
            this.Botones();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            isEditar = false;
            isNuevo = false;
            Limpiar();
            Habilitar(false);
            
            Botones();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtClave.Equals(""))
            {
                isEditar = true;
                isNuevo = false;
                //Limpiar();
                Habilitar(true);
                Botones();
                this.LlenarDataIngredientes();
            }
            else
            {
                MensajeError("Debe Seleccionar un registro para su Edición");
            }
        }

        private void dataListadoPreparaciones_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(this.dataListadoPreparaciones.CurrentRow.Cells["clave"].Value.ToString(),DragDropEffects.Copy);
        }

        private void cmbPreparacion_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void cmbPreparacion_DragDrop(object sender, DragEventArgs e)
        {
            this.cmbPreparacion.SelectedValue = Convert.ToInt32(e.Data.GetData(DataFormats.Text));
            this.LlenarDataIngredientes();
        }

        private void txtBuscarVivere_TextChanged(object sender, EventArgs e)
        {
            this.dataListadoPreparaciones.DataSource = NPreparacion.Buscar(this.txtBuscarVivere.Text);
        }

        private void btnCalculoViveres_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                decimal cantidad;
                int clave_plan;
                int clave_viv;
                if (isEditar)
                {
                    if (this.cmbPreparacion.SelectedValue == null || this.txtClave.Text == String.Empty)
                    {
                        this.MensajeError("Recuerde que para efectuar el cálculo de viveres debe tener seleccionados una planificación y una preparación");
                        errorIcon.SetError(this.txtClave, "Seleccione una planificación por favor");
                        errorIcon.SetError(this.cmbPreparacion,"Seleccione una preparación para el cálculo de viveres");
                    }else
                    {
                        cantidad = 0;
                        foreach(DataGridViewRow fila in dataIngredientes.Rows)
                        {
                            clave_plan = Convert.ToInt32(this.txtClave.Text);
                            clave_viv = Convert.ToInt32(fila.Cells[0].Value);
                            cantidad = Convert.ToDecimal(fila.Cells["cantidad"].Value) * Convert.ToInt32(this.txtRaciones.Text);
                            string resultado = NVivere_Planificacion.Insertar(clave_viv,clave_plan,cantidad);
                            this.dataDetallePlanificacion.DataSource = NVivere_Planificacion.Buscar_X_Planificacion(clave_plan);
                        }
                    }
                }
                else
                {
                    MensajeError("Esta opción solo es funcional en modo Edición");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataPlanificaciones_DoubleClick(object sender, EventArgs e)
        {
            isNuevo = false;
            isEditar = false;
            Limpiar();
            this.txtClave.Text = Convert.ToString(dataPlanificaciones.CurrentRow.Cells["clave"].Value);
            this.txtFecha.Text = Convert.ToString(dataPlanificaciones.CurrentRow.Cells["fecha"].Value);
            this.cmbDestino.SelectedValue = Convert.ToInt32(dataPlanificaciones.CurrentRow.Cells["clave_dependencia"].Value);
            this.cmbTipo.SelectedValue = Convert.ToInt32(dataPlanificaciones.CurrentRow.Cells["clave_tipo"].Value);
            this.txtRaciones.Text = Convert.ToString(dataPlanificaciones.CurrentRow.Cells["raciones"].Value);
            this.cmbPreparacion.SelectedValue = Convert.ToInt32(dataPlanificaciones.CurrentRow.Cells["clave_preparacion"].Value);
            this.tabPlanificaciones.SelectedIndex = 1;

        }

        private void btnCalculoViveres_Click(object sender, EventArgs e)

        {
           
            try
            {
                decimal cantidad;
                int clave_plan;
                int clave_viv;
               
                if (isEditar)
                {
                    if (this.cmbPreparacion.SelectedValue == null || this.txtClave.Text == String.Empty)
                    {
                        this.MensajeError("Recuerde que para efectuar el cálculo de viveres debe tener seleccionados una planificación y una preparación");
                        errorIcon.SetError(this.txtClave, "Seleccione una planificación por favor");
                        errorIcon.SetError(this.cmbPreparacion, "Seleccione una preparación para el cálculo de viveres");
                    }
                    else
                    {
                      
                        cantidad = 0;
                        clave_plan = Convert.ToInt32(this.txtClave.Text);
                        foreach (DataGridViewRow fila in dataIngredientes.Rows)
                        {
                            cantidad = 0;
                           
                            clave_viv = Convert.ToInt32(fila.Cells[1].Value);
                            cantidad = Convert.ToDecimal(fila.Cells["cantidad"].Value) * Convert.ToInt32(this.txtRaciones.Text);
                            MensajeOk("clave plan " + clave_plan + "clave vivere " + clave_viv + "cantidad " + cantidad);
                            string resultado = NVivere_Planificacion.Insertar(clave_viv, clave_plan, cantidad);
                            this.MensajeOk(resultado);
                            this.dataDetallePlanificacion.DataSource = NVivere_Planificacion.Buscar_X_Planificacion(clave_plan);
                        }
                        this.dataDetallePlanificacion.DataSource = NVivere_Planificacion.Buscar_X_Planificacion(clave_plan);
                    }
                }
                else
                {
                    MensajeError("Esta opción solo es funcional en modo Edición");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal cantidad;
                int clave_plan;
                int clave_viv;
                if (isEditar)
                {
                    if (this.cmbPreparacion.SelectedValue == null || this.txtClave.Text == String.Empty)
                    {
                        this.MensajeError("Recuerde que para efectuar el cálculo de viveres debe tener seleccionados una planificación y una preparación");
                        errorIcon.SetError(this.txtClave, "Seleccione una planificación por favor");
                        errorIcon.SetError(this.cmbPreparacion, "Seleccione una preparación para el cálculo de viveres");
                    }
                    else
                    {
                        cantidad = 0;
                        foreach (DataGridViewRow fila in dataIngredientes.Rows)
                        {
                            clave_plan = Convert.ToInt32(this.txtClave.Text);
                            clave_viv = Convert.ToInt32(fila.Cells[0].Value);
                            cantidad = Convert.ToDecimal(fila.Cells["cantidad"].Value) * Convert.ToInt32(this.txtRaciones.Text);
                            string resultado = NVivere_Planificacion.Insertar(clave_viv, clave_plan, cantidad);
                            //   this.dataDetallePlanificacion.DataSource = NVivere_Planificacion.Buscar_X_Planificacion();
                            this.dataDetallePlanificacion.DataSource = NVivere_Planificacion.Buscar_X_Planificacion(clave_plan);
                        }
                    }
                }
                else
                {
                    MensajeError("Esta opción solo es funcional en modo Edición");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
