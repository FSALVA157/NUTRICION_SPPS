using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NVivere
    {//inicio NVivere

        public static string Insertar(string vivere, decimal hidratos, decimal proteinas, decimal grasa, int tipo,string unidad)
        {//inicio insertar
            DVivere Obj = new DVivere();
            Obj.Vivere = vivere;
            Obj.Hidratos = hidratos;
            Obj.Proteinas = proteinas;
            Obj.Grasa = grasa;
            Obj.Tipo = tipo;
            Obj.Unidad = unidad;
            return Obj.Insertar(Obj);
        }//fin insertar

        public static string Editar(int clave, string vivere, decimal hidratos, decimal proteinas, decimal grasa, int tipo,string unidad)
        {//inicio editar
            DVivere Obj = new DVivere();
            Obj.Clave = clave;
            Obj.Vivere = vivere;
            Obj.Hidratos = hidratos;
            Obj.Proteinas = proteinas;
            Obj.Grasa = grasa;
            Obj.Tipo = tipo;
            Obj.Unidad = unidad;
            return Obj.Editar(Obj);
        }//fin editar

        public static string Eliminar(int clave)
        {
            DVivere Obj = new DVivere();
            Obj.Clave= clave;
            
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            DVivere Obj = new DVivere();
            return Obj.Mostrar();
        }

        public static DataTable Buscar(string texto)
        {
            DVivere Obj = new DVivere();
            Obj.TextoBuscar = texto;
            return Obj.Buscar_Vivere(Obj);
        }

    }//fin NVivere
}
