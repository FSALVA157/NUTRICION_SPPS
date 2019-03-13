using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
   public class DTipo_Comida
    {//inicio DTipo_Comida
        private int _Clave;
        private string _Tipo;
        private string _Texto_Buscar;
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

        #endregion propiedades

        #region constructores
        public DTipo_Comida() { }

        public DTipo_Comida(int clave, string tipo)
        {
            this.Clave = clave;
            this.Tipo = tipo;
        }

        #endregion constructores

        //metodos

        public DataTable Mostrar()
        {//inicio mostrar
            SqlConnection SqlCon = new SqlConnection();
            DataTable DtResultado = new DataTable("tipo_comida");
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spmostrar_tipo_comida";

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);



            }
            catch (Exception)
            {

                DtResultado = null;

            }
            return DtResultado;
        }//fin mostrar

        public string Insertar(DTipo_Comida Obj)
        {//inicio insertar
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //conexion
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spinsertar_tipo_comida";

                //parametros
                SqlParameter ParClave = new SqlParameter();
                ParClave.ParameterName = "@clave";
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParClave);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 50;
                ParTipo.Value = Obj.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

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

        public string Editar(DTipo_Comida Obj)
        {//inicio Editar
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //conexion
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                //establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "speditar_tipo_comida";

                //parametros
                SqlParameter ParClave = new SqlParameter();
                ParClave.ParameterName = "@clave";
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.Value = Obj.Clave;
                SqlCmd.Parameters.Add(ParClave);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@tipo";
                ParTipo.SqlDbType = SqlDbType.VarChar;
                ParTipo.Size = 50;
                ParTipo.Value = Obj.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

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
        }//fin Editar

        public string Eliminar(DTipo_Comida Obj)
        {//inicio Eliminar
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_tipo_comida";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParClave = new SqlParameter();
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.ParameterName = "@clave";
                ParClave.Value = Obj.Clave;
                SqlCmd.Parameters.Add(ParClave);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "ERROR AL ELIMINAR EL REGISTRO SELECCIONADO";

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

        }//fin Eliminar

        public DataTable Buscar_Tipo_Comida(DTipo_Comida Obj)
        {//inicio buscar
            SqlConnection SqlCon = new SqlConnection();
            DataTable dtResultado = new DataTable("tipo_comida");
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spbuscar_tipo_comida";

                SqlParameter ParTexto = new SqlParameter();
                ParTexto.SqlDbType = SqlDbType.VarChar;
                ParTexto.Size = 100;
                ParTexto.ParameterName = "@texto_buscar";
                ParTexto.Value = Obj.Texto_Buscar;
                SqlCmd.Parameters.Add(ParTexto);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtResultado);


            }
            catch (Exception)
            {

                dtResultado = null;
            }
            return dtResultado;
        }//fin buscar



    }//fin DTipo_Comida
}
