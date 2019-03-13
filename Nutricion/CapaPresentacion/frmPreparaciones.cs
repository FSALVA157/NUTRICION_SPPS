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
using System.IO;
using Microsoft.VisualBasic;

namespace CapaPresentacion
{
    public partial class frmPreparaciones : Form
    {
        private bool isNuevo = false;
        private bool isEditar = false;
        public frmPreparaciones()
        {
            InitializeComponent();
            this.LlenarComboTipo();
           
          
            this.txtClave.ReadOnly = true;
            
        }

        private void frmPreparaciones_Load(object sender, EventArgs e)
        {
            this.ttMensaje.SetToolTip(this.txtPreparacion, "Debe Ingresar el nombre de la Preparación");
            this.Mostrar();
            this.MostrarViveres();
            this.Habilitar(false);
            this.Botones();
           

        }
        #region Listados y DataGridView

        

        private void LlenarComboTipo()
        {
            this.cmbTipo.DataSource = CapaNegocio.NTipo_Preparacion.Mostrar();
            this.cmbTipo.DisplayMember = "tipo";
            this.cmbTipo.ValueMember = "clave";
            this.cmbTipo.SelectedIndex = 1;

        }

        private void Mostrar()
        {
             this.dataPreparaciones.DataSource = CapaNegocio.NPreparacion.Mostrar();
           
        }
        private void MostrarViveres()
        {
            this.dataListadoViveres.DataSource = NVivere.Mostrar();
        }

        private void LlenarIngredientes()
        {
            this.dataIngredientes.DataSource = CapaNegocio.NVivere_Preparacion.Buscar_X_Preparacion(Convert.ToInt32(this.txtClave.Text));
        }


        #endregion Listados

        #region Mensajes
        public void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "SISTEMA INFORMATICO DE LA DIVISION NUTRICION DEL S.P.P.S.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "SISTEMA INFORMATICO DE LA DIVISION NUTRICION DEL S.P.P.S.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion Mensajes

        #region Metodos Varios
        private void Habilitar(bool valor)
        {
            this.txtPreparacion.ReadOnly = !valor;
            this.cmbTipo.Enabled = valor;
            if (isNuevo)
            {
                
                this.dataListadoViveres.Enabled = false;
                this.txtBuscarVivere.Enabled = false;
                this.dataIngredientes.Enabled = false;
                this.btnCargarIngrediente.Enabled = false;
                this.chkEliminaIngrediente.Enabled = false;
                this.btnEliminarIngrediente.Enabled = false;
            }else
            {
                
                this.dataListadoViveres.Enabled = true;
                this.txtBuscarVivere.Enabled = true;
                this.dataIngredientes.Enabled = true;
                this.btnCargarIngrediente.Enabled = true;
                this.chkEliminaIngrediente.Enabled = true;
                this.btnEliminarIngrediente.Enabled = true;
            }
            
        }

        private void Botones()
        {
            if(isEditar || isNuevo)
            {
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
                this.btnCargarImagen.Enabled = true;
                this.btnBorrarImagen.Enabled = true;
                this.btnNuevo.Enabled = false;
                this.btnEditar.Enabled = false;
            }else
            {
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnCargarImagen.Enabled = false;
                this.btnBorrarImagen.Enabled = false;
                this.btnNuevo.Enabled = true;
                this.btnEditar.Enabled = true;
            }
        }

        private void Limpiar()
        {
            this.txtClave.Text = String.Empty;
            this.txtPreparacion.Text = String.Empty;
            this.pxImagen.Image = global::CapaPresentacion.Properties.Resources.Preparacion_logo;
            this.dataIngredientes.DataSource = null;
        }

        #endregion metodos Varios

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ruta = new OpenFileDialog();
            DialogResult respuesta = new DialogResult();
            respuesta = ruta.ShowDialog();
            if(respuesta == DialogResult.OK)
            {
                this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pxImagen.Image = Image.FromFile(ruta.FileName);
            }
        }

        private void btnBorrarImagen_Click(object sender, EventArgs e)
        {
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pxImagen.Image = global::CapaPresentacion.Properties.Resources.Preparacion_logo;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            isNuevo = true;
            isEditar = false;
            Limpiar();
            this.Habilitar(true);
            

            this.Botones();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if(this.txtPreparacion.Text == String.Empty)
                {
                    this.MensajeError("Existen Datos Obligatorios sin Completar, los mismos seran señalados");
                    this.errorIcon.SetError(this.txtPreparacion,"Debe ingresar una preparación");
                }else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    Byte[] cadenaImagen = ms.GetBuffer();

                    if (isNuevo)
                    {
                        rpta = CapaNegocio.NPreparacion.Insertar(this.txtPreparacion.Text.ToString().Trim().ToUpper(), Convert.ToInt32(this.cmbTipo.SelectedValue), cadenaImagen);
                    }else
                    {
                        rpta = CapaNegocio.NPreparacion.Editar(Convert.ToInt32(this.txtClave.Text),this.txtPreparacion.Text.ToString().Trim().ToUpper(), Convert.ToInt32(this.cmbTipo.SelectedValue), cadenaImagen);
                    }

                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se ha agragado con Exito el Nuevo Registro!");
                    }else
                    {
                        this.MensajeError(rpta);
                    }
                    this.isNuevo = false;
                    this.isEditar = false;
                    this.Habilitar(false);
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }

        }

        private void dataPreparaciones_DoubleClick(object sender, EventArgs e)
        {
            isNuevo = false;
            isEditar = false;
            Limpiar();
            this.txtClave.Text = Convert.ToString(this.dataPreparaciones.CurrentRow.Cells["clave"].Value);
            this.txtPreparacion.Text = Convert.ToString(this.dataPreparaciones.CurrentRow.Cells["preparacion"].Value);
            this.cmbTipo.SelectedValue = Convert.ToInt32(this.dataPreparaciones.CurrentRow.Cells["clave_tipo"].Value);

            Byte[] imagenBuffer = (Byte[]) this.dataPreparaciones.CurrentRow.Cells["imagen"].Value;
            System.IO.MemoryStream ms = new  System.IO.MemoryStream(imagenBuffer);
            this.pxImagen.Image = Image.FromStream(ms);
            this.LlenarIngredientes();
            this.tabPreparaciones.SelectedIndex = 1;
            
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
            }else
            {
                MensajeError("Debe Seleccionar un registro para su Edición");
            }


            

        }

        private void dataListadoViveres_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(this.dataListadoViveres.CurrentRow.Cells["clave"].Value.ToString(),DragDropEffects.Copy);
        }

        

       

        

        private void dataIngredientes_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))

                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void dataIngredientes_DragDrop(object sender, DragEventArgs e)
        {

            string entrada = Interaction.InputBox("Ingrese la cantidad por racion para cada ingrediente","Sistema Nutrición","cantidad");
            decimal cantidad = Convert.ToDecimal(entrada);
            int clave_vivere = Convert.ToInt32(e.Data.GetData(DataFormats.Text).ToString());
            int clave_preparacion = Convert.ToInt32(this.txtClave.Text);
            NVivere_Preparacion.Insertar(clave_vivere, clave_preparacion,cantidad);
           // NVivere_Preparacion.Insertar(Convert.ToInt32(e.Data.GetData(DataFormats.Text).ToString()),
           //Convert.ToInt32(this.txtClave.Text),cantidad);
           this.LlenarIngredientes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            isEditar = false;
            isNuevo = false;
            Limpiar();
            Habilitar(false);
            Botones();
        }

        private void chkEliminaIngrediente_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkEliminaIngrediente.Checked)
            {
                this.dataIngredientes.Columns[0].Visible = true;
            }else
            {
                this.dataIngredientes.Columns[0].Visible = false;
            }
        }

        private void dataIngredientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dataIngredientes.Columns["Borrar"].Index)
            {
                {
                    DataGridViewCheckBoxCell chkEliminate = (DataGridViewCheckBoxCell)(this.dataIngredientes.Rows[e.RowIndex].Cells["Borrar"]);
                    chkEliminate.Value = !Convert.ToBoolean(chkEliminate.Value);
                }
            }
        }

        private void btnEliminarIngrediente_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult respuesta = new DialogResult();
                respuesta = MessageBox.Show("Esta seguro de ELIMINAR los registros seleccionados?", "Sistema Nutricion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(respuesta == DialogResult.Yes)
                {
                    //inicio proceso de eliminacion de registros
                    string rpta = "";
                    foreach (DataGridViewRow fila in this.dataIngredientes.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells[0].Value))
                        {
                            rpta = NVivere_Preparacion.Eliminar(Convert.ToInt32(fila.Cells["clave"].Value));
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se ha eliminado con exito el ingrediente seleccionada");
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }
                        }
                        
                    }
                    this.LlenarIngredientes();
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarVivere_TextChanged(object sender, EventArgs e)
        {
            this.dataListadoViveres.DataSource = NVivere.Buscar(txtBuscarVivere.Text.ToString());
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkEliminar.Checked)
            {
                this.dataPreparaciones.Columns[0].Visible = true;
            }else
            {
                this.dataPreparaciones.Columns[0].Visible = false;
            }

        }

        private void dataPreparaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.dataPreparaciones.Columns["Eliminar"].Index == e.ColumnIndex)
            {
                DataGridViewCheckBoxCell checkB = (DataGridViewCheckBoxCell)(this.dataPreparaciones.Rows[e.RowIndex].Cells["Eliminar"]);
                checkB.Value = !Convert.ToBoolean(checkB.Value);
            }
                        

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion = new DialogResult();
                opcion = MessageBox.Show("Confirma la Eliminación de los registros seleccionados?",
                    "SISTEMA NUTRICION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(opcion == DialogResult.Yes)
                {
                    string rpta = "";
                    foreach(DataGridViewRow fila in this.dataPreparaciones.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells[0].Value))
                        {
                            rpta = NPreparacion.Eliminar(Convert.ToInt32(fila.Cells["clave"].Value));
                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("El registro ha sido eliminado con exito");
                            }else
                            {
                                this.MensajeError(rpta);
                            }
                        }
                    }
                    this.Mostrar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscarVivere_Click(object sender, EventArgs e)
        {
            if (isNuevo)
            {
                MessageBox.Show("Para Agregar Ingredientes debe estar en modo Edición");
            }
        }

        private void dataListadoViveres_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para Agregar Ingredientes debe estar en modo Edición");
        }

        private void btnCargarIngrediente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para Agregar Ingredientes debe estar en modo Edición");
        }

        private void dataIngredientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para Agregar Ingredientes debe estar en modo Edición");
        }

        private void chkEliminaIngrediente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para Agregar Ingredientes debe estar en modo Edición");
        }
    }
}
