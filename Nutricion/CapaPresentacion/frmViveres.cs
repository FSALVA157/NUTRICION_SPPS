using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmViveres : Form
    {
        private bool isNuevo = false;
        private bool isEditar = false;
        public frmViveres()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.txtVivere, "Debe Ingresar la denominación del Vivere");
        }

        private void frmViveres_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.txtClave.ReadOnly = true;
            LlenarComboTipo();
            Mostrar();
            this.Habilitar(false);
            this.Botones();
        }
        #region Mensajes
        public void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SISTEMA INFORMATICO DE LA DIVISION NUTRICION DEL S.P.P.S.",  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SISTEMA INFORMATICO DE LA DIVISION NUTRICION DEL S.P.P.S.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion Mensajes

        private void LlenarComboTipo()
        {
            this.cmbTipo.DataSource = CapaNegocio.NTipoVivere.Mostrar();
            this.cmbTipo.DisplayMember = "tipo";
            this.cmbTipo.ValueMember = "clave";
            this.cmbTipo.SelectedIndex = 1;
        }

        #region Metodos Comunes
        private void Mostrar()
        {
            this.dataViveres.DataSource = CapaNegocio.NVivere.Mostrar();
        }

        private void Habilitar(bool valor)
        {
            this.txtVivere.ReadOnly = !valor;
            this.txtGrasa.ReadOnly = !valor;
            this.txtProteinas.ReadOnly = !valor;
            this.txtHidratos.ReadOnly = !valor;
            this.cmbTipo.Enabled = valor;
            this.txtUnidad.ReadOnly = !valor;
        }

        private void Botones()
        {
            if (isNuevo || isEditar)
            {
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnNuevo.Enabled = false;
                this.btnCancelar.Enabled = true;
            }else
            {
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnNuevo.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }

        private void Limpiar()
        {
            this.txtClave.Text = String.Empty;
            this.txtVivere.Text = String.Empty;
            this.txtGrasa.Text = String.Empty;
            this.txtProteinas.Text = String.Empty;
            this.txtHidratos.Text = String.Empty;
            this.txtUnidad.Text = String.Empty;

        }




        #endregion Metodos Comunes

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            isNuevo = true;
            isEditar = false;
            this.Limpiar();
            this.Habilitar(true);
            this.Botones();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtVivere.Text == String.Empty)
                {
                    this.MensajeError("Faltan Llenar algunos datos obligatorios los mismos seran marcados");
                    errorIcon.SetError(this.txtVivere,"Este campo es obligatorio");
                }else
                {
                    if(isNuevo || isEditar)
                    {
                        string rpta = "";
                        if (isNuevo)
                        {
                            rpta = CapaNegocio.NVivere.Insertar(this.txtVivere.Text.Trim(),Convert.ToDecimal(this.txtHidratos.Text),Convert.ToDecimal(this.txtProteinas.Text),Convert.ToDecimal(this.txtGrasa.Text),Convert.ToInt32(this.cmbTipo.SelectedValue),this.txtUnidad.Text.Trim());
                       
                        }
                        else
                        {
                            rpta = CapaNegocio.NVivere.Editar(Convert.ToInt32(this.txtClave.Text),this.txtVivere.Text.Trim(), Convert.ToDecimal(this.txtHidratos.Text), Convert.ToDecimal(this.txtProteinas.Text), Convert.ToDecimal(this.txtGrasa.Text), Convert.ToInt32(this.cmbTipo.SelectedValue), this.txtUnidad.Text.Trim());
                        }
                        if (rpta.Equals("OK"))
                        {
                            this.MensajeOk("La Operación se ha realizado correctamente");
                        }else
                        {
                            this.MensajeError("Error en la Operación realizada");
                        }

                    }
                }
                isNuevo = false;
                isEditar = false;
                this.Limpiar();
                this.Habilitar(false);
                this.Botones();
                this.Mostrar();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataViveres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataViveres.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chekEliminate = (DataGridViewCheckBoxCell) dataViveres.Rows[e.RowIndex].Cells["Eliminar"];
                chekEliminate.Value = !Convert.ToBoolean(chekEliminate.Value);
            }
        }

        private void dataViveres_DoubleClick(object sender, EventArgs e)
        {
            isNuevo = isEditar = false;
            this.Limpiar();
            this.txtClave.Text = Convert.ToString(this.dataViveres.CurrentRow.Cells["clave"].Value);
            this.txtVivere.Text = Convert.ToString(this.dataViveres.CurrentRow.Cells["vivere"].Value);
            this.txtGrasa.Text = Convert.ToString(this.dataViveres.CurrentRow.Cells["grasa"].Value);
            this.txtHidratos.Text = Convert.ToString(this.dataViveres.CurrentRow.Cells["hidratos"].Value);
            this.cmbTipo.SelectedValue = Convert.ToString(this.dataViveres.CurrentRow.Cells["tipo"].Value);
            this.txtProteinas.Text = Convert.ToString(this.dataViveres.CurrentRow.Cells["proteinas"].Value);
            this.txtUnidad.Text = Convert.ToString(this.dataViveres.CurrentRow.Cells["unidad"].Value);
            this.tabViveres.SelectedIndex = 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            isNuevo = false;
            isEditar = true;
            this.Habilitar(true);
            Botones();
        }
        private void BuscarVivere()
        {
            this.dataViveres.DataSource = CapaNegocio.NVivere.Buscar(this.txtTextoBuscar.Text.ToString().Trim());

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.BuscarVivere();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkEliminar.Checked)
            {
                this.dataViveres.Columns[0].Visible = true;
            }else
            {
                this.dataViveres.Columns[0].Visible = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Esta seguro de Eliminar los Registros seleccionados?",
                    "Sistema Nutricion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    //string codigo;
                    string rpta = "";
                    foreach (DataGridViewRow row in this.dataViveres.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            rpta = CapaNegocio.NVivere.Eliminar(Convert.ToInt32(row.Cells[1].Value));
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se ha eliminado con exito la categoria seleccionada");
                            }
                            else
                            {
                                this.MensajeError("No se ha completado la eliminacion de categoria");
                            }
                        }
                    }
                    this.Mostrar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
    }
}
