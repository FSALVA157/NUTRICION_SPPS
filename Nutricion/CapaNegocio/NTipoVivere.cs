﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class NTipoVivere
    {//inicio NTipo
        public static DataTable Mostrar()
        {
            return new DTipoVivere().Mostrar();
        }

    }//fin NTipo
}
