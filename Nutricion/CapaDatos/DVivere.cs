using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DVivere
    {
        private int _Clave;
        private string _Vivere;
        private decimal _Hidratos;
        private decimal _Proteinas;
        private decimal _Grasa;
        private int _Tipo;
        private string _TextoBuscar;
        private string _Unidad;

        public int Clave
        {
            get  { return _Clave; }

            set {  _Clave = value;  }
        }

        public string Vivere
        {
            get  { return _Vivere; }

            set   {  _Vivere = value; }
        }

        public decimal Hidratos
        {
            get  {  return _Hidratos;   }

            set  { _Hidratos = value;   }
        }

        public decimal Proteinas
        {
            get  {   return _Proteinas;  }

            set  {   _Proteinas = value; }
        }

        public decimal Grasa
        {   get  { return _Grasa; }

            set  { _Grasa = value; }
        }

        public int Tipo
        {  get  { return _Tipo;  }

            set  { _Tipo = value; }
        }

        public string TextoBuscar
        {
            get
            {
                return _TextoBuscar;
            }

            set
            {
                _TextoBuscar = value;
            }
        }

        public string Unidad
        {
            get
            {
                return _Unidad;
            }

            set
            {
                _Unidad = value;
            }
        }



        //constructores

        public DVivere() {
            }

        public DVivere(int clave, string vivere, decimal hidratos, decimal proteinas, decimal grasa,int tipo)
        {
            this.Clave = clave;
            this.Vivere = vivere;
            this.Hidratos = hidratos;
            this.Proteinas = proteinas;
            this.Grasa = grasa;
            this.Tipo = tipo;
        }

        //metodos
        public string Insertar(DVivere Obj)
        {
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
                SqlCmd.CommandText = "spinsertar_vivere";

                //parametros
                SqlParameter ParClave = new SqlParameter();
                ParClave.ParameterName = "@clave";
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParClave);

                SqlParameter ParVivere = new SqlParameter();
                ParVivere.ParameterName = "@vivere";
                ParVivere.SqlDbType = SqlDbType.VarChar;
                ParVivere.Size = 100;
                ParVivere.Value = Obj.Vivere;
                SqlCmd.Parameters.Add(ParVivere);

                SqlParameter ParHidratos = new SqlParameter();
                ParHidratos.ParameterName = "@hidratos";
                ParHidratos.SqlDbType = SqlDbType.Decimal;
                ParHidratos.Value = Obj.Hidratos;
                SqlCmd.Parameters.Add(ParHidratos);

                SqlParameter ParProteinas = new SqlParameter();
                ParProteinas.ParameterName = "@proteinas";
                ParProteinas.SqlDbType = SqlDbType.Decimal;
                ParProteinas.Value = Obj.Proteinas;
                SqlCmd.Parameters.Add(ParProteinas);

                SqlParameter ParGrasa = new SqlParameter();
                ParGrasa.ParameterName = "@grasa";
                ParGrasa.SqlDbType = SqlDbType.Decimal;
                ParGrasa.Value = Obj.Grasa;
                SqlCmd.Parameters.Add(ParGrasa);

                SqlParameter ParTipo= new SqlParameter();
                ParTipo.ParameterName = "@tipo";
                ParTipo.SqlDbType = SqlDbType.Int;
                ParTipo.Value = Obj.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParUnidad = new SqlParameter();
                ParUnidad.ParameterName = "@unidad";
                ParUnidad.SqlDbType = SqlDbType.VarChar;
                ParUnidad.Size = 50;
                ParUnidad.Value = Obj.Unidad;
                SqlCmd.Parameters.Add(ParUnidad);

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

        //metodo editar
        public string Editar(DVivere Obj)
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
                SqlCmd.CommandText = "speditar_vivere";

                //parametros
                SqlParameter ParClave = new SqlParameter();
                ParClave.ParameterName = "@clave";
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.Value = Obj.Clave;
                SqlCmd.Parameters.Add(ParClave);

                SqlParameter ParVivere = new SqlParameter();
                ParVivere.ParameterName = "@vivere";
                ParVivere.SqlDbType = SqlDbType.VarChar;
                ParVivere.Size = 100;
                ParVivere.Value = Obj.Vivere;
                SqlCmd.Parameters.Add(ParVivere);

                SqlParameter ParHidratos = new SqlParameter();
                ParHidratos.ParameterName = "@hidratos";
                ParHidratos.SqlDbType = SqlDbType.Decimal;
                ParHidratos.Value = Obj.Hidratos;
                SqlCmd.Parameters.Add(ParHidratos);

                SqlParameter ParProteinas = new SqlParameter();
                ParProteinas.ParameterName = "@proteinas";
                ParProteinas.SqlDbType = SqlDbType.Decimal;
                ParProteinas.Value = Obj.Proteinas;
                SqlCmd.Parameters.Add(ParProteinas);

                SqlParameter ParGrasa = new SqlParameter();
                ParGrasa.ParameterName = "@grasa";
                ParGrasa.SqlDbType = SqlDbType.Decimal;
                ParGrasa.Value = Obj.Grasa;
                SqlCmd.Parameters.Add(ParGrasa);

                SqlParameter ParTipo = new SqlParameter();
                ParTipo.ParameterName = "@tipo";
                ParTipo.SqlDbType = SqlDbType.Int;
                ParTipo.Value = Obj.Tipo;
                SqlCmd.Parameters.Add(ParTipo);

                SqlParameter ParUnidad = new SqlParameter();
                ParUnidad.ParameterName = "@unidad";
                ParUnidad.SqlDbType = SqlDbType.VarChar;
                ParUnidad.Size = 50;
                ParUnidad.Value = Obj.Unidad;
                SqlCmd.Parameters.Add(ParUnidad);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "ERROR EN LA EDICION DEL REGISTRO SELECCIONADO";

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

        public string Eliminar(DVivere Obj)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_vivere";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParClave = new SqlParameter();
                ParClave.SqlDbType = SqlDbType.Int;
                ParClave.ParameterName = "@clave";
                ParClave.Value = Obj.Clave;
                SqlCmd.Parameters.Add(ParClave);

                rpta = SqlCmd.ExecuteNonQuery()==1? "OK": "ERROR AL ELIMINAR EL REGISTRO SELECCIONADO";

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

        //metodo mostrar

            public DataTable Mostrar()
        {
            DataTable dtResultado = new DataTable("viveres");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_viveres";
                SqlCmd.CommandType = CommandType.StoredProcedure;

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
        public DataTable Buscar_Vivere(DVivere Obj)
        {
            SqlConnection SqlCon = new SqlConnection();
            DataTable dtResultado = new DataTable("viveres");
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.CommandText = "spbuscar_vivere";

                SqlParameter ParTexto = new SqlParameter();
                ParTexto.SqlDbType = SqlDbType.VarChar;
                ParTexto.Size = 100;
                ParTexto.ParameterName = "@texto_buscar";
                ParTexto.Value = Obj.TextoBuscar;
                SqlCmd.Parameters.Add(ParTexto);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(dtResultado);


            }
            catch (Exception)
            {

                dtResultado = null;
            }
            return dtResultado;
        }





    }
}
