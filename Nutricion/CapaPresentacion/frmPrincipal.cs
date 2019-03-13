using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.panelBarraLateral.Width = 427;
            
        }

        #region FUNCIONALIDADES DEL FORMULARIO
        //RESIZE METODO PARA REDIMENSIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelPrincipal.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(47, 79, 79));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

           base.OnPaint(e);
           ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent , sizeGripRectangle);
        }



        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (this.panelBarraLateral.Width == 427)
            {
                this.panelBarraLateral.Width = 150;
            }else
            {
                this.panelBarraLateral.Width = 427;
            }
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.lx = this.Location.X;
            this.ly = this.Location.Y;
            this.sw = this.Size.Width;
            this.sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //this.WindowState = FormWindowState.Maximized;
            this.btnRestaurar.Visible = true;
            this.btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            this.Size = new Size(sw,sh);
            this.Location = new Point(lx,ly);
            this.btnMaximizar.Visible = true;
            this.btnRestaurar.Visible = false;
        }
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void btnPreparaciones_Click(object sender, EventArgs e)
        {
            frmPreparaciones prep = new frmPreparaciones();
            prep.StartPosition = FormStartPosition.CenterScreen;
            prep.Show();
        }

        private void panelBarraLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPlanificaciones_Click(object sender, EventArgs e)
        {
            frmPlanificacion formPlan = new frmPlanificacion();
            formPlan.StartPosition = FormStartPosition.CenterScreen;
            formPlan.WindowState = FormWindowState.Maximized;
            formPlan.Show();
        }

        private void btnViveres_Click(object sender, EventArgs e)
        {
            frmViveres formViveres = new frmViveres();
            formViveres.StartPosition = FormStartPosition.CenterScreen;
            //formViveres.WindowState = FormWindowState.Maximized;
            formViveres.Show();
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            frmEstadisticas fe = new frmEstadisticas();
            fe.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelMenu_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion FIN FUNCIONALIDADEL DEL FORMULARIO


    }
}
