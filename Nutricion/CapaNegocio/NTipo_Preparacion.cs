using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;


namespace CapaNegocio
{
    public class NTipo_Preparacion
    {//inicio NTipoPreparacion
        //metodo mostrar
        public static DataTable Mostrar()
        {
            DTipo_Preparacion Obj = new DTipo_Preparacion();
            return Obj.Mostrar();
            //return new DTipo_Preparacion().Mostrar();
        }
    }//fin NTipoPreparacion
}
