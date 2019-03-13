using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NVivere_Planificacion
    {//inicio clase principal
        public static string Insertar(int clave_vivere, int clave_planificacion, decimal cantidad)
        {//inicio insertar
            DVivere_Planificacion Obj = new DVivere_Planificacion();
            Obj.Clave_Vivere = clave_vivere;
            Obj.Clave_Planificacion = clave_planificacion;
            Obj.Cantidad = cantidad;
            return Obj.Insertar(Obj);
        }//fin insertar

        public static DataTable Buscar_X_Planificacion(int clave_planificacion)
        {
            DVivere_Planificacion Obj = new DVivere_Planificacion();
            Obj.Clave_Planificacion = clave_planificacion;
            return Obj.Buscar_X_Planificacion(Obj);

        }//fin buscar_X_preparacion

        public static string Editar(int clave, int clave_vivere, int clave_planificacion, decimal cantidad)
        {
            DVivere_Planificacion Obj = new DVivere_Planificacion();
            Obj.Clave = clave;
            Obj.Clave_Vivere = clave_vivere;
            Obj.Clave_Planificacion = clave_planificacion;
            Obj.Cantidad = cantidad;
            return Obj.Editar(Obj);
        }

        public static string Eliminar(int clave)
        {
            DVivere_Planificacion Obj = new DVivere_Planificacion();
            Obj.Clave = clave;
            return Obj.Eliminar(Obj);
        }

        public static DataTable SumaViveres(int unidad,string fecha, int categoria)
        {
            DVivere_Planificacion Obj = new DVivere_Planificacion();
            if (fecha != String.Empty)
            {
                try
                {
                    Obj.Fecha_Buscar = Convert.ToDateTime(fecha);
                }
                catch (Exception)
                {

                    Obj.Fecha_Buscar = System.DateTime.Parse("1900-01-01");
                }
            }
            else
            {
                Obj.Fecha_Buscar = System.DateTime.Parse("1900-01-01");
            }
            Obj.Destino_buscar = unidad;
            Obj.Categoria_Buscar = categoria;
            return Obj.SumaViveresSegunPlanificacion(Obj);

        }//fin buscar_X_preparacion


    }//fin clase principal
}
