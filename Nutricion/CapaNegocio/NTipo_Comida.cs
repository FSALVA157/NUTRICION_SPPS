using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.SqlClient;
using System.Data;

namespace CapaNegocio
{
    public class NTipo_Comida
    {//inicio NTipo

        public static string Insertar(string tipo)
        {//inicio insertar
            DTipo_Comida Obj = new DTipo_Comida();
            Obj.Tipo = tipo;
            
            return Obj.Insertar(Obj);
        }//fin insertar

        public static string Editar(int clave, string tipo)
        {//inicio editar
            DTipo_Comida Obj = new DTipo_Comida();
            Obj.Clave = clave;
            Obj.Tipo = tipo;
            return Obj.Editar(Obj);
        }//fin editar

        public static string Eliminar(int clave)
        {
            DTipo_Comida Obj = new DTipo_Comida();
            Obj.Clave = clave;

            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            DTipo_Comida Obj = new DTipo_Comida();
            return Obj.Mostrar();
        }

        public static DataTable Buscar(string texto)
        {
            DTipo_Comida Obj = new DTipo_Comida();
            Obj.Texto_Buscar = texto;
            return Obj.Buscar_Tipo_Comida(Obj);
        }
    }//fin NTipo
}
