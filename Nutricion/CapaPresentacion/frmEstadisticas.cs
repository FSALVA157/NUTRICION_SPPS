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
    public partial class frmEstadisticas : Form
    {
        public frmEstadisticas()
        {
            InitializeComponent();
            this.LlenarCmbDestino();
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.txtFechaPlan.Text = monthCalendar2.SelectionStart.ToShortDateString();
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {

        }

        private void LlenarCmbDestino()
        {
            this.cmbDestino.DataSource = NDestinos.Mostrar();
            this.cmbDestino.DisplayMember = "unidad";
            this.cmbDestino.ValueMember = "clave";
        }

        private void LlenarDataAlmuerzo()
        {
          this.dataAlmuerzo.DataSource = NPlanificacion.ListaPreparacionesXPlanificacionYFecha(Convert.ToInt32(this.cmbDestino.SelectedValue), Convert.ToString(this.txtFechaPlan.Text), 1);
        //    this.dataAlmuerzo.DataSource = NPlanificacion.ListaPreparacionesXPlanificacionYFecha(4, Convert.ToString(this.txtFechaPlan.Text), 1);
        }

        private void txtFechaPlan_TextChanged(object sender, EventArgs e)
        {
            this.LlenarDataAlmuerzo();
            this.LlenarDataCena();
            this.LlenarDataViveresSecos();
            this.LlenarDataViveresFrescos();
        }

        private void LlenarDataCena()
        {
          this.dataCena.DataSource = NPlanificacion.ListaPreparacionesXPlanificacionYFecha(Convert.ToInt32(this.cmbDestino.SelectedValue), Convert.ToString(this.txtFechaPlan.Text),2);
          //  this.dataCena.DataSource = NPlanificacion.ListaPreparacionesXPlanificacionYFecha(4, Convert.ToString(this.txtFechaPlan.Text), 2);
        }

        private void LlenarDataViveresSecos()
        {
            this.dataViveresSecos.DataSource = NVivere_Planificacion.SumaViveres(Convert.ToInt32(this.cmbDestino.SelectedValue), Convert.ToString(this.txtFechaPlan.Text),2);
        }

        private void LlenarDataViveresFrescos()
        {
            this.dataViveresFrescos.DataSource = NVivere_Planificacion.SumaViveres(Convert.ToInt32(this.cmbDestino.SelectedValue), Convert.ToString(this.txtFechaPlan.Text), 1);
        }
    }
}
