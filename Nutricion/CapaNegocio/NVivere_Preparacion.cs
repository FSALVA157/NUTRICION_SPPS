using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NVivere_Preparacion
    {//inicio NViverePresentacion

        public static string Insertar(int clave_vivere, int clave_preparacion, decimal cantidad)
        {//inicio insertar
            DVivere_Preparacion Obj = new DVivere_Preparacion();
            Obj.Clave_Vivere = clave_vivere;
            Obj.Clave_Preparacion = clave_preparacion;
            Obj.Cantidad = cantidad;
          return  Obj.Insertar(Obj);
        }//fin insertar

        public static DataTable Buscar_X_Preparacion(int clave_preparacion)
        {
            DVivere_Preparacion Obj = new DVivere_Preparacion();
            Obj.Clave_Preparacion = clave_preparacion;
            return Obj.Buscar_X_Preparacion(Obj);

        }//fin buscar_X_preparacion

        public static string Editar(int clave, int clave_vivere, int clave_preparacion, decimal cantidad)
        {
            DVivere_Preparacion Obj = new DVivere_Preparacion();
            Obj.Clave = clave;
            Obj.Clave_Vivere = clave_vivere;
            Obj.Clave_Preparacion = clave_preparacion;
            Obj.Cantidad = cantidad;
            return Obj.Editar(Obj);
        }

        public static string Eliminar(int clave)
        {
            DVivere_Preparacion Obj = new DVivere_Preparacion();
            Obj.Clave = clave;
            return Obj.Eliminar(Obj);
        }

    }//fin NViverePresentacion
}
