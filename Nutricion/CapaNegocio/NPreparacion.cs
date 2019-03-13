using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NPreparacion
    {//inicio NPreparacion
        public static string Insertar(string preparacion, int tipo,byte[] imagen)
        {//inicio insertar
            DPreparacion Obj = new DPreparacion();
            Obj.Preparacion = preparacion;
            Obj.Tipo_Preparacion = tipo;
            Obj.Imagen = imagen;
            return Obj.Insertar(Obj);
        }//fin insertar
        
        public static string Editar(int clave, string preparacion, int tipo,byte[] imagen)
        {//inicio editar
            DPreparacion Obj = new DPreparacion();
            Obj.Clave = clave;
            Obj.Preparacion = preparacion;
            Obj.Tipo_Preparacion = tipo;
            Obj.Imagen = imagen;
            return Obj.Editar(Obj);
        }//fin editar

        public static string Eliminar(int clave)
        {//inicio eliminar
            DPreparacion Obj = new DPreparacion();
            Obj.Clave = clave;
            return Obj.Eliminar(Obj);
        }//fin eliminar

        public static DataTable Mostrar()
        {
            DPreparacion Obj = new DPreparacion();
            return Obj.Mostrar();
        }


        public static DataTable Buscar(string texto)
        {
            DPreparacion Obj = new DPreparacion();
            Obj.Texto_Buscar = texto;
            return Obj.Buscar(Obj);
        }



    }//fin NPreparacion
}
