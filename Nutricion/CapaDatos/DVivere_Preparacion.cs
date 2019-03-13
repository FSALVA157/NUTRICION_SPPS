using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DVivere_Preparacion
    {//inicio DVivere_Preparacion
        private int _Clave;
        private int _Clave_Vivere;
        private int _Clave_Preparacion;
        private decimal _Cantidad;

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

        public int Clave_Vivere
        {
            get
            {
                return _Clave_Vivere;
            }

            set
            {
                _Clave_Vivere = value;
            }
        }

        public int Clave_Preparacion
        {
            get
            {
                return _Clave_Preparacion;
            }

            set
            {
                _Clave_Preparacion = value;
            }
        }

        public decimal Cantidad
        {
            get
            {
                return _Cantidad;
            }

            set
            {
                _Cantidad = value;
            }
        }

        #endregion propiedades

        #region constructores

        public DVivere_Preparacion() { }

        public DVivere_Preparacion(int clave, int clave_vivere, int clave_preparacion,decimal cantidad)
        {
            this.Clave = clave;
            this.Clave_Vivere = clave_vivere;
            this.Clave_Preparacion = clave_preparacion;
            this.Cantidad = cantidad;
        }

        #endregion constructores


        public string Insertar(DVivere_Preparacion Obj)
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
                SqlCmd.CommandText = "spinsertar_vivere_preparacion";

                SqlParameter ParClave = new SqlParameter();
                ParClave.ParameterName = "@clave";
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParClave);

                SqlParameter ParClaveVivere = new SqlParameter();
                ParClaveVivere.ParameterName = "@clave_vivere";
                ParClaveVivere.SqlDbType = SqlDbType.Int;
                ParClaveVivere.Value = Obj.Clave_Vivere;
                SqlCmd.Parameters.Add(ParClaveVivere);

                SqlParameter ParClavePreparacion = new SqlParameter();
                ParClavePreparacion.ParameterName = "@clave_preparacion";
                ParClavePreparacion.SqlDbType = SqlDbType.Int;
                ParClavePreparacion.Value = Obj.Clave_Preparacion;
                SqlCmd.Parameters.Add(ParClavePreparacion);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Decimal;
                ParCantidad.Value = Obj.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "ERROR EN LA CARGA DEL NUEVO REGISTRO";
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

        public string Editar(DVivere_Preparacion Obj)
        {
            SqlConnection SqlCon = new SqlConnection();
            string rpta = "";
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "speditar_vivere_preparacion";

                SqlParameter ParClave = new SqlParameter();
                ParClave.ParameterName = "@clave";
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.Value = Obj.Clave_Vivere;
                SqlCmd.Parameters.Add(ParClave);

                SqlParameter ParClaveVivere = new SqlParameter();
                ParClaveVivere.ParameterName = "@clave_vivere";
                ParClaveVivere.SqlDbType = SqlDbType.Int;
                ParClaveVivere.Value = Obj.Clave_Vivere;
                SqlCmd.Parameters.Add(ParClaveVivere);

                SqlParameter ParClavePreparacion = new SqlParameter();
                ParClavePreparacion.ParameterName = "@clave_preparacion";
                ParClavePreparacion.SqlDbType = SqlDbType.Int;
                ParClavePreparacion.Value = Obj.Clave_Preparacion;
                SqlCmd.Parameters.Add(ParClavePreparacion);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";
                ParCantidad.SqlDbType = SqlDbType.Decimal;
                ParCantidad.Value = Obj.Cantidad;
                SqlCmd.Parameters.Add(ParCantidad);


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "ERROR: NO SE HA REALIZADO LA EDICION DEL REGISTRO";
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
        }

        public DataTable Buscar_X_Preparacion(DVivere_Preparacion Obj)
        {
            DataTable dtResultado = new DataTable("vivere_preparacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spbuscar_vivere_preparacion_x_preparacion";

                SqlParameter ParClavePreparacion = new SqlParameter();
                ParClavePreparacion.ParameterName = "@clave_preparacion";
                ParClavePreparacion.SqlDbType = SqlDbType.Int;
                ParClavePreparacion.Value = Obj.Clave_Preparacion;
                SqlCmd.Parameters.Add(ParClavePreparacion);



                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(dtResultado);

            }
            catch (Exception)
            {

                dtResultado = null;
            }
            return dtResultado;

        }

        public string Eliminar(DVivere_Preparacion Obj)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlCon;

                SqlCmd.CommandText = "speliminar_vivere_preparacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParClave = new SqlParameter();
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.ParameterName = "@clave";
                ParClave.Value = Obj.Clave;
                SqlCmd.Parameters.Add(ParClave);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Error al Eliminar este Registro";



            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
            return rpta;
        }



    }//fin DVivere_Preparacion
}
