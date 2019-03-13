using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class DPreparacion
    {
        private int _Clave;
        private string _Preparacion;
        private int _Tipo_Preparacion;
        private string _Texto_Buscar;
        private byte[] _Imagen;

        //propiedades
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

        public String Preparacion
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

        public int Tipo_Preparacion
        {
            get
            {
                return _Tipo_Preparacion;
            }
            set
            {
                _Tipo_Preparacion = value;
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

        public byte[] Imagen
        {
            get
            {
                return _Imagen;
            }

            set
            {
                _Imagen = value;
            }
        }

        //constructores

        public DPreparacion()
        {

        }

        public DPreparacion(int clave, string preparacion, int tipo,byte[] imagen) {
            this.Clave = clave;
            this.Preparacion = preparacion;
            this.Tipo_Preparacion = tipo;
            this.Imagen = imagen;
        }

        //metodos
        public string Insertar(DPreparacion Obj)
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
                SqlCmd.CommandText = "spinsertar_preparacion";

                SqlParameter ParClave = new SqlParameter();
                ParClave.ParameterName = "@clave";
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParClave);

                SqlParameter ParPreparacion = new SqlParameter();
                ParPreparacion.ParameterName = "@preparacion";
                ParPreparacion.SqlDbType = SqlDbType.VarChar;
                ParPreparacion.Size = 200;
                ParPreparacion.Value = Obj.Preparacion;
                SqlCmd.Parameters.Add(ParPreparacion);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@tipo";
                ParTipo.SqlDbType = SqlDbType.Int;
                ParTipo.Value = Obj.Tipo_Preparacion;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParImagen = new SqlParameter();
                ParImagen.ParameterName = "@imagen";
                ParImagen.SqlDbType = SqlDbType.VarBinary;
                ParImagen.Value = Obj.Imagen;
                SqlCmd.Parameters.Add(ParImagen);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "ERROR EN LA CARGA DEL NUEVO REGISTRO";
            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
            finally
            {
                if(SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
            return rpta;
        }

        //metodo editar
        public string Editar(DPreparacion Obj)
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
                SqlCmd.CommandText = "speditar_preparacion";

                SqlParameter ParClave = new SqlParameter();
                ParClave.ParameterName = "@clave";
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.Value = Obj.Clave;
                SqlCmd.Parameters.Add(ParClave);

                SqlParameter ParPreparacion = new SqlParameter();
                ParPreparacion.ParameterName = "@preparacion";
                ParPreparacion.SqlDbType = SqlDbType.VarChar;
                ParPreparacion.Size = 200;
                ParPreparacion.Value = Obj.Preparacion;
                SqlCmd.Parameters.Add(ParPreparacion);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@tipo";
                ParTipo.SqlDbType = SqlDbType.Int;
                ParTipo.Value = Obj.Tipo_Preparacion;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParImagen = new SqlParameter();
                ParImagen.ParameterName = "@imagen";
                ParImagen.SqlDbType = SqlDbType.VarBinary;
                ParImagen.Value = Obj.Imagen;
                SqlCmd.Parameters.Add(ParImagen);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "ERROR AL EDITAR EL REGISTRO SELECCIONADO";
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


        //metodo eliminar
        public string Eliminar(DPreparacion Obj)
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
                SqlCmd.CommandText = "speliminar_preparacion";

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

        //metodo mostrar
        public DataTable Mostrar()
        {
            DataTable dtResultado = new DataTable("preparaciones");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_preparacion";

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(dtResultado);


            }
            catch (Exception)
            {

                dtResultado = null;
            }
            return dtResultado;


        }

        //metodo buscar
        public DataTable Buscar(DPreparacion Obj)
        {
            DataTable dtResultado = new DataTable("preparaciones");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spbuscar_preparacion";

                SqlParameter ParText = new SqlParameter();
                ParText.ParameterName = "@texto_buscar";
                ParText.SqlDbType = SqlDbType.VarChar;
                ParText.Size = 50;
                ParText.Value = Obj.Texto_Buscar;
                SqlCmd.Parameters.Add(ParText);

                

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(dtResultado);


            }
            catch (Exception)
            {

                dtResultado = null;
            }
            return dtResultado;


        }

    }
}
