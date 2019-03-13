using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DTipo_Preparacion
    {
        private int _Clave;
        private string _Tipo;
        #region propiedades
        public int Clave
        {
            get
            {
                return _Clave;
            }

            set
            {
                _Clave = value;
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
        public DTipo_Preparacion() { }

        public DTipo_Preparacion(int clave, string tipo)
        {
            this.Clave = clave;
            this.Tipo = tipo;
        }

        #endregion constructores
        //metodos
        public string Insertar(DTipo_Preparacion Obj)
        {//inicio insertar
            SqlConnection SqlCon = new SqlConnection();
            string rpta = "";
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spinsertar_tipo_preparacion";

                SqlParameter ParClave = new SqlParameter();
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.Direction = ParameterDirection.Output;
                ParClave.ParameterName = "@clave";
                SqlCmd.Parameters.Add(ParClave);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 50;
                ParTipo.ParameterName = "@tipo";
                ParTipo.Value = Obj.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                rpta = SqlCmd.ExecuteNonQuery() == 1? "OK":"Error al insertar el Nuevo Registro";

            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return rpta;
        }//fin insertar

        public string Editar(DTipo_Preparacion Obj)
        {//inicio insertar
            SqlConnection SqlCon = new SqlConnection();
            string rpta = "";
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "speditar_tipo_preparacion";

                SqlParameter ParClave = new SqlParameter();
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.ParameterName = "@clave";
                ParClave.Value = Obj.Clave;
                SqlCmd.Parameters.Add(ParClave);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 50;
                ParTipo.ParameterName = "@tipo";
                ParTipo.Value = Obj.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Error al Editar el Registro Seleccionado";

            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return rpta;
        }//fin insertar

        public DataTable Mostrar()
        {
            DataTable dtResultado = new DataTable("tipo_preparacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_tipo_preparacion";

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(dtResultado);


            }
            catch (Exception)
            {
                dtResultado = null;
            }
            return dtResultado;
            
        }


    }//fin DTipoPreparacion
}
