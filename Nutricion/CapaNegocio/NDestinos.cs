using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class NDestinos
    {//inicio NDestinos
        public static DataTable Mostrar()
        {//inicio mostrar
            DDestinos Obj = new DDestinos();
            return Obj.Mostrar();
        }//fin mostrar

    public static string Insertar(string unidad)
        {//inicio insertar
            DDestinos Obj = new DDestinos();
            Obj.Unidad = unidad;

            return Obj.Insertar(Obj);
        }//fin insertar

        public static string Editar(int clave,string unidad)
        {//inicio insertar
            DDestinos Obj = new DDestinos();
            Obj.Clave = clave;
            Obj.Unidad = unidad;

            return Obj.Editar(Obj);
        }//fin insertar

        public static string Eliminar(int clave)
        {//inicio eliminar
            DDestinos Obj = new DDestinos();
            Obj.Clave = clave;

            return Obj.Eliminar(Obj);
        }//fin eliminar

        public static DataTable Buscar(string texto)
        {
            DDestinos Obj = new DDestinos();
            Obj.Texto_Buscar = texto;
            return Obj.Buscar_Unidad(Obj);
        }

    }//fin NDestinos
}
