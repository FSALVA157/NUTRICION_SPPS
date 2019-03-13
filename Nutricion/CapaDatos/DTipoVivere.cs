using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DTipoVivere
    {
        private int _Codigo;
        private string _Tipo;
        #region propiedades
        public int Codigo
        {
            get
            {
                return _Codigo;
            }

            set
            {
                _Codigo = value;
            }
        }

        public string Tipo
        {
            get
            {
                return _Tipo;
            }

            set
            {
                _Tipo = value;
            }
        }

        #endregion propiedades
        //constructores
        #region constructores
        public DTipoVivere() { }

        public DTipoVivere(int clave,string tipo)
        {
            this.Codigo = clave;
            this.Tipo = tipo;
        }

        #endregion constructores
        //metodos
        #region metodos
        public DataTable Mostrar()
        {
            SqlConnection SqlCon = new SqlConnection();
            DataTable dtResultado = new DataTable("tipo_vivere");
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;

                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_tipo_vivere";

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtResultado);


            }
            catch (Exception)
            {

                dtResultado = null;
            }
            return dtResultado;
        }
        #endregion metodos

    }
}
