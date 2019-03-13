using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DPlanificacion
    {//inicio clase DPlanificacion
        private int _Clave;
        private DateTime _Fecha;
        private int _Destino;
        private int _Preparacion;
        private int _Raciones;
        private int _Tipo;
        private string _Texto_Buscar;
        private DateTime _Fecha1;
        private DateTime _Fecha2;

        //propiedades
        #region bloquePropiedades
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

        public DateTime Fecha
        {
            get
            {
                return _Fecha;
            }
            set
            {
                _Fecha = value;
            }
        }

        public int Destino
        {
            get
            {
                return _Destino;
            }
            set
            {
                _Destino = value;
                
            }
        }

        public int Preparacion
        {
            get
            {
                return _Preparacion;
            }
            set
            {
                _Preparacion = value;
            }
        }

        public int Raciones
        {
            get
            {
                return _Raciones;
            }
            set
            {
                _Raciones = value;
            }

        }

        public int Tipo
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

        public string Texto_Buscar
        {
            get
            {
                return _Texto_Buscar;
            }
            set
            {
                _Texto_Buscar = value;
            }
        }

        public DateTime Fecha1
        {
            get
            {
                return _Fecha1;
            }

            set
            {
                _Fecha1 = value;
            }
        }

        public DateTime Fecha2
        {
            get
            {
                return _Fecha2;
            }

            set
            {
                _Fecha2 = value;
            }
        }

        #endregion bloquePropiedades

        //constructores
        #region Constructores
        public DPlanificacion() { }

        public DPlanificacion(int clave, DateTime fecha, int destino, int preparacion, int raciones, int tipo)
        {
           this.Clave= clave;
            this.Fecha = fecha;
            this.Destino = destino;
            this.Preparacion = preparacion;
            this.Raciones = raciones;
            this.Tipo = tipo;
        }
        #endregion Constructores

        //metodos
        #region Metodos
        public string Insertar(DPlanificacion Obj)
        {
            
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spinsertar_planificacion";

                SqlParameter ParClave = new SqlParameter();
                ParClave.ParameterName = "@clave";
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParClave);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.ParameterName = "@fecha";
                ParFecha.Value = Obj.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParDestino = new SqlParameter();
                ParDestino.SqlDbType = SqlDbType.Int;
                ParDestino.ParameterName = "@destino_clave";
                ParDestino.Value = Obj.Destino;
                SqlCmd.Parameters.Add(ParDestino);

                SqlParameter ParPreparacion = new SqlParameter();
                ParPreparacion.SqlDbType = SqlDbType.Int;
                ParPreparacion.ParameterName = "@preparacion_clave";
                ParPreparacion.Value = Obj.Preparacion;
                SqlCmd.Parameters.Add(ParPreparacion);

                SqlParameter ParRaciones = new SqlParameter();
                ParRaciones.SqlDbType = SqlDbType.Int;
                ParRaciones.ParameterName = "@raciones";
                ParRaciones.Value = Obj.Raciones;
                SqlCmd.Parameters.Add(ParRaciones);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.SqlDbType = SqlDbType.Int;
                ParTipo.ParameterName = "@tipo";
                ParTipo.Value = Obj.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "ERROR AL INSERTAR NUEVO REGISTRO PLANIFICACION";



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

        public string Editar(DPlanificacion Obj)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "speditar_planificacion";

                SqlParameter ParClave = new SqlParameter();
                ParClave.ParameterName = "@clave";
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.Value = Obj.Clave;
                SqlCmd.Parameters.Add(ParClave);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.ParameterName = "@fecha";
                ParFecha.Value = Obj.Fecha;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParDestino = new SqlParameter();
                ParDestino.SqlDbType = SqlDbType.Int;
                ParDestino.ParameterName = "@destino_clave";
                ParDestino.Value = Obj.Destino;
                SqlCmd.Parameters.Add(ParDestino);

                SqlParameter ParPreparacion = new SqlParameter();
                ParPreparacion.SqlDbType = SqlDbType.Int;
                ParPreparacion.ParameterName = "@preparacion_clave";
                ParPreparacion.Value = Obj.Preparacion;
                SqlCmd.Parameters.Add(ParPreparacion);

                SqlParameter ParRaciones = new SqlParameter();
                ParRaciones.SqlDbType = SqlDbType.Int;
                ParRaciones.ParameterName = "@raciones";
                ParRaciones.Value = Obj.Raciones;
                SqlCmd.Parameters.Add(ParRaciones);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.SqlDbType = SqlDbType.Int;
                ParTipo.ParameterName = "@tipo";
                ParTipo.Value = Obj.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "ERROR AL EDITAR REGISTRO PLANIFICACION";
                

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

        public string Eliminar(DPlanificacion Obj)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "speliminar_planificacion";

                SqlParameter ParClave = new SqlParameter();
                ParClave.ParameterName = "@clave";
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.Value = Obj.Clave;
                SqlCmd.Parameters.Add(ParClave);



                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "ERROR AL ELIMINAR EL REGISTRO SELECCIONADO";
            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
            return rpta;
        }

        public DataTable Mostrar()
        {
            DataTable dtResultado = new DataTable("planificacion");
            SqlConnection SqlCon = new SqlConnection();
                try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_planificacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtResultado);

            }
            catch (Exception)
            {

                dtResultado = null;
            }
            return dtResultado;
        }

        public DataTable Buscar_X_Unidad(DPlanificacion Obj)
        {
            DataTable dtResultado = new DataTable("planificacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_planificacion_x_clave_unidad";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParClaveDestino = new SqlParameter();
                ParClaveDestino.SqlDbType = SqlDbType.Int;
                ParClaveDestino.ParameterName = "@clave_destino";
                ParClaveDestino.Value = Obj.Destino;
                SqlCmd.Parameters.Add(ParClaveDestino);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtResultado);

            }
            catch (Exception)
            {

                dtResultado = null;
            }
            return dtResultado;
        }

        public DataTable Buscar_X_Fecha(DPlanificacion Obj)
        {
            DataTable dtResultado = new DataTable("planificacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_planificacion_x_fecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFechaInicio = new SqlParameter();
                ParFechaInicio.SqlDbType = SqlDbType.DateTime;
                ParFechaInicio.ParameterName = "@fecha_inicio";
                ParFechaInicio.Value = Obj.Fecha1;
                SqlCmd.Parameters.Add(ParFechaInicio);

                SqlParameter ParFechaFin = new SqlParameter();
                ParFechaFin.SqlDbType = SqlDbType.DateTime;
                ParFechaFin.ParameterName = "@fecha_fin";
                ParFechaFin.Value = Obj.Fecha2;
                SqlCmd.Parameters.Add(ParFechaFin);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtResultado);

            }
            catch (Exception)
            {

                dtResultado = null;
            }
            return dtResultado;
        }



        public DataTable Buscar_X_Nombre(DPlanificacion Obj)
        {
            DataTable dtResultado = new DataTable("planificacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_planificacion_x_nombre_preparacion";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.ParameterName = "@texto_buscar";
                ParNombre.Value = Obj.Texto_Buscar;
                SqlCmd.Parameters.Add(ParNombre);

                
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtResultado);

            }
            catch (Exception)
            {

                dtResultado = null;
            }
            return dtResultado;
        }

        public DataTable ListaPreparXPlaniFecha(DPlanificacion Obj)
        {
            DataTable dtResultado = new DataTable("planificacion");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "splistaPreparacionesXPlanificacionyFecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.SqlDbType = SqlDbType.DateTime;
                ParFecha.ParameterName = "@fecha";
                ParFecha.Value = Obj.Fecha1;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParDestino = new SqlParameter();
                ParDestino.SqlDbType = SqlDbType.Int;
                ParDestino.ParameterName = "@unidad";
                ParDestino.Value = Obj.Destino;
                SqlCmd.Parameters.Add(ParDestino);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.SqlDbType = SqlDbType.Int;
                ParTipo.ParameterName = "@turno";
                ParTipo.Value = Obj.Tipo;
                SqlCmd.Parameters.Add(ParTipo);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtResultado);

            }
            catch (Exception)
            {

                dtResultado = null;
            }
            return dtResultado;
        }


        #endregion Metodos
    }//fin clase DPlanificacion
}
