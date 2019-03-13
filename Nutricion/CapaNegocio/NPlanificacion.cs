using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NPlanificacion
    {//inicio NPlanificacion

        public static string Insertar(string fecha, int destino, int preparacion, int raciones, int tipo)
        {//inicio insertar
            DPlanificacion Obj = new DPlanificacion();
            if (fecha != String.Empty)
            {
                try
                {
                    Obj.Fecha = Convert.ToDateTime(fecha);
                }
                catch (Exception)
                {

                    Obj.Fecha = System.DateTime.Parse("1900-01-01");
                }
            } else
            {
                Obj.Fecha = System.DateTime.Parse("1900-01-01");
            }

            Obj.Destino = destino;
            Obj.Preparacion = preparacion;
            Obj.Raciones = raciones;
            
            Obj.Tipo = tipo;

            return Obj.Insertar(Obj);
        }//fin insertar

        public static string Editar(int clave, string fecha, int destino, int preparacion, int raciones, int tipo)
        {//inicio editar
            DPlanificacion Obj = new DPlanificacion();
            Obj.Clave = clave;
            if (fecha != String.Empty)
            {
                try
                {
                    Obj.Fecha = Convert.ToDateTime(fecha);
                }
                catch (Exception)
                {

                    Obj.Fecha = System.DateTime.Parse("1900-01-01");
                }
            }
            else
            {
                Obj.Fecha = System.DateTime.Parse("1900-01-01");
            }

            Obj.Destino = destino;
            Obj.Preparacion = preparacion;
            Obj.Raciones = raciones;
            Obj.Tipo = tipo;

            return Obj.Editar(Obj);
        }//fin editar

        public static string Eliminar(int clave)
        {
            DPlanificacion Obj = new DPlanificacion();
            Obj.Clave = clave;
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DPlanificacion().Mostrar();
        }

        public static DataTable BuscarXDestino(int destino)
        {
            DPlanificacion Obj = new DPlanificacion();
            Obj.Destino = destino;
            return Obj.Buscar_X_Unidad(Obj);
        }

        public static DataTable BuscarXNombre(string nombre)
        {
            DPlanificacion Obj = new DPlanificacion();
            Obj.Texto_Buscar = nombre;
            return Obj.Buscar_X_Nombre(Obj);
        }

        public static DataTable BuscarXFecha(DateTime fecha_inicio, DateTime fecha_fin)
        {
            DPlanificacion Obj = new DPlanificacion();
            Obj.Fecha1 = fecha_inicio;
            Obj.Fecha2 = fecha_fin;
            return Obj.Buscar_X_Fecha(Obj);
        }

        public static DataTable ListaPreparacionesXPlanificacionYFecha(int unidad, string fecha,int turno)
        {
            DPlanificacion Obj = new DPlanificacion();
            Obj.Destino = unidad;
            Obj.Tipo = turno;
            if (fecha != String.Empty)
            {
                try
                {
                    Obj.Fecha1 = Convert.ToDateTime(fecha);
                }
                catch (Exception)
                {

                    Obj.Fecha1 = System.DateTime.Parse("1900-01-01");
                }
            }
            else
            {
                Obj.Fecha1 = System.DateTime.Parse("1900-01-01");
            }
            return Obj.ListaPreparXPlaniFecha(Obj);
        }


    }//fin NPlanificacion
}
