using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DVivere_Planificacion
    {//inicio clase principal
        private int _Clave;
        private int _Clave_Planificacion;
        private int _Clave_Vivere;
        private decimal _Cantidad;
        private int _Destino_buscar;
        private DateTime _Fecha_Buscar;
        private int _Categoria_Buscar;

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

        public int Clave_Planificacion
        {
            get
            {
                return _Clave_Planificacion;
            }

            set
            {
                _Clave_Planificacion = value;
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

        public int Destino_buscar
        {
            get
            {
                return _Destino_buscar;
            }

            set
            {
                _Destino_buscar = value;
            }
        }

        public DateTime Fecha_Buscar
        {
            get
            {
                return _Fecha_Buscar;
            }

            set
            {
                _Fecha_Buscar = value;
            }
        }

        public int Categoria_Buscar
        {
            get
            {
                return _Categoria_Buscar;
            }

            set
            {
                _Categoria_Buscar = value;
            }
        }

        #endregion propiedades

        #region constructores
        public DVivere_Planificacion() { }

        public DVivere_Planificacion(int clave, int clave_planificacion,int clave_vivere, decimal cantidad)
        {
            this.Clave = clave;
            this.Clave_Planificacion = clave_planificacion;
            this.Clave_Vivere = clave_vivere;
            this.Cantidad = cantidad;
        }//fin constructor

        #endregion constructores

        //metodos
        #region metodos
        public DataTable Buscar_X_Planificacion(DVivere_Planificacion Obj)
        {
            DataTable dtResultado = new DataTable("vivere_planificacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spbuscar_x_planificacion_en_vivere_planificacion";

                SqlParameter ParClavePlanificacion = new SqlParameter();
                ParClavePlanificacion.ParameterName = "@clave_buscar";
                ParClavePlanificacion.SqlDbType = SqlDbType.Int;
                ParClavePlanificacion.Value = Obj.Clave_Planificacion;
                SqlCmd.Parameters.Add(ParClavePlanificacion);



                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(dtResultado);

            }
            catch (Exception)
            {

                dtResultado = null;
            }
            return dtResultado;

        }//fin metodo buscar

        public string Insertar(DVivere_Planificacion Obj) {
            SqlConnection SqlCon = new SqlConnection();
            string rpta = "";
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spinsertar_vivere_planificacion";

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

                SqlParameter ParClavePlanificacion = new SqlParameter();
                ParClavePlanificacion.ParameterName = "@clave_planificacion";
                ParClavePlanificacion.SqlDbType = SqlDbType.Int;
                ParClavePlanificacion.Value = Obj.Clave_Planificacion;
                SqlCmd.Parameters.Add(ParClavePlanificacion);

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


        }

        public string Editar(DVivere_Planificacion Obj)
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
                SqlCmd.CommandText = "speditar_vivere_planificacion";

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

                SqlParameter ParClavePlanificacion = new SqlParameter();
                ParClavePlanificacion.ParameterName = "@clave_planificacion";
                ParClavePlanificacion.SqlDbType = SqlDbType.Int;
                ParClavePlanificacion.Value = Obj.Clave_Planificacion;
                SqlCmd.Parameters.Add(ParClavePlanificacion);

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

        public string Eliminar(DVivere_Planificacion Obj)
        {
            string rpta = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Conexion.Cn;
                sqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = sqlCon;

                SqlCmd.CommandText = "speliminar_vivere_planificacion";
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

        public DataTable SumaViveresSegunPlanificacion(DVivere_Planificacion Obj)
        {
            DataTable dtResultado = new DataTable("vivere_planificacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spsuma_viveres_segun_planificacion";

                SqlParameter ParUnidad = new SqlParameter();
                ParUnidad.ParameterName = "@unidad";
                ParUnidad.SqlDbType = SqlDbType.Int;
                ParUnidad.Value = Obj.Destino_buscar;
                SqlCmd.Parameters.Add(ParUnidad);

                SqlParameter ParFechaPlan = new SqlParameter();
                ParFechaPlan.ParameterName = "@fecha";
                ParFechaPlan.SqlDbType = SqlDbType.Date;
                ParFechaPlan.Value = Obj.Fecha_Buscar;
                SqlCmd.Parameters.Add(ParFechaPlan);

                SqlParameter ParCatViv = new SqlParameter();
                ParCatViv.ParameterName = "@tipo_vivere";
                ParCatViv.SqlDbType = SqlDbType.Int;
                ParCatViv.Value = Obj.Categoria_Buscar;
                SqlCmd.Parameters.Add(ParCatViv);



                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(dtResultado);

            }
            catch (Exception)
            {

                dtResultado = null;
            }
            return dtResultado;


        }
        
        #endregion metodos

    }//fin clase principal

}
