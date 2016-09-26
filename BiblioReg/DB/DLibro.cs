using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DB
{
   public  class DLibro
    {
       private int _IdLibro;
       private string _Nombre;
       private DateTime _FechaRegistro;
       private string _Autor;
       private string _Editorial;
       private string _Descripcion;
       private string _TextoBuscar;

      

       public int IdLibro
       {
           get
           { 
               return _IdLibro; 
           }
           set
           { 
               _IdLibro = value;
           }
       }
       public string Nombre
       {
           get
           { 
               return _Nombre; 
           }
           set
           { 
               _Nombre = value;
           }
       }
       public DateTime FechaRegistro
       {
           get
           { 
               return _FechaRegistro; 
           }
           set
           { 
               _FechaRegistro = value;
           }
       }
       public string Autor
       {
           get
           { 
               return _Autor; 
           }
           set
           { 
               _Autor = value;
           }
       }
       public string Editorial
       {
           get 
           {
               return _Editorial; 
           }
           set
           { 
               _Editorial = value; 
           }
       }
       public string Descripcion
       {
           get
           { 
               return _Descripcion; 
           }
           set
           { 
               _Descripcion = value; 
           }
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
       //Constructor vacio
        public DLibro()
        {

        }
        //Constructor con parametros
        public DLibro(int idLibro, string nombre,  DateTime fechaRegistro, string autor, string editorial, string descripcion, string textobuscar)
        {
            this.IdLibro = idLibro;
            this.Nombre = nombre;
            this.FechaRegistro = fechaRegistro;
            this.Autor = autor;
            this.Editorial = editorial;
            this.Descripcion = descripcion;
            this.TextoBuscar = textobuscar;
           
        }
        //Metodo Insertar
        public string Insertar(DLibro Libro)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Codigo
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdLibro = new SqlParameter();
                ParIdLibro.ParameterName = "@idLibro";
                ParIdLibro.SqlDbType = SqlDbType.Int;
                ParIdLibro.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdLibro);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Libro.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParFechaRegistro = new SqlParameter();
                ParFechaRegistro.ParameterName = "@fechaRegistro";
                ParFechaRegistro.SqlDbType = SqlDbType.Date;
                ParFechaRegistro.Size = 50;
                ParFechaRegistro.Value = Libro.FechaRegistro;
                SqlCmd.Parameters.Add(ParFechaRegistro);

                SqlParameter ParAutor = new SqlParameter();
                ParAutor.ParameterName = "@autor";
                ParAutor.SqlDbType = SqlDbType.VarChar;
                ParAutor.Size = 50;
                ParAutor.Value = Libro.Autor;
                SqlCmd.Parameters.Add(ParAutor);

                SqlParameter ParEditorial = new SqlParameter();
                ParEditorial.ParameterName = "@editorial";
                ParEditorial.SqlDbType = SqlDbType.VarChar;
                ParEditorial.Size = 50;
                ParEditorial.Value = Libro.Editorial;
                SqlCmd.Parameters.Add(ParEditorial);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 50;
                ParDescripcion.Value = Libro.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                //Ejecutamos nuestros comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";



            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
       //Metodo Editar
        public string Editar(DLibro Libro)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Codigo
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdLibro = new SqlParameter();
                ParIdLibro.ParameterName = "@idLibro";
                ParIdLibro.SqlDbType = SqlDbType.Int;
                ParIdLibro.Value = Libro.IdLibro;
                SqlCmd.Parameters.Add(ParIdLibro);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Libro.Nombre;
                SqlCmd.Parameters.Add(ParNombre);

                SqlParameter ParFechaRegistro = new SqlParameter();
                ParFechaRegistro.ParameterName = "@fechaRegistro";
                ParFechaRegistro.SqlDbType = SqlDbType.Date;
                ParFechaRegistro.Size = 50;
                ParFechaRegistro.Value = Libro.FechaRegistro;
                SqlCmd.Parameters.Add(ParFechaRegistro);

                SqlParameter ParAutor = new SqlParameter();
                ParAutor.ParameterName = "@autor";
                ParAutor.SqlDbType = SqlDbType.VarChar;
                ParAutor.Size = 50;
                ParAutor.Value = Libro.Autor;
                SqlCmd.Parameters.Add(ParAutor);

                SqlParameter ParEditorial = new SqlParameter();
                ParEditorial.ParameterName = "@editorial";
                ParEditorial.SqlDbType = SqlDbType.VarChar;
                ParEditorial.Size = 50;
                ParEditorial.Value = Libro.Editorial;
                SqlCmd.Parameters.Add(ParEditorial);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 50;
                ParDescripcion.Value = Libro.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);

                //Ejecutamos nuestros comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";



            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
       //Metodo Eliminar
        public string Eliminar(DLibro Libro)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Codigo
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdLibro = new SqlParameter();
                ParIdLibro.ParameterName = "@idLibro";
                ParIdLibro.SqlDbType = SqlDbType.Int;
                ParIdLibro.Value = Libro.IdLibro;
                SqlCmd.Parameters.Add(ParIdLibro);


                //Ejecutamos nuestros comando
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se elimino el registro";
            }
            catch (Exception ex)
            {

                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;

        }

        //Método utilizado para obtener todos los profesor de la base de datos
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("libro");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //1. Establecer la cadena de conexion
                SqlCon.ConnectionString = Conexion.Cn;

                //2. Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;//La conexión que va a usar el comando
                SqlCmd.CommandText = "sp_mostrar";//El comando a ejecutar
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //Decirle al comando que va a ejecutar una sentencia SQL

                //3. No hay parámetros

                //4. El DataAdapter que va a ejecutar el comando y
                //es el encargado de llena el DataTable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);//Llenamos el DataTable
            }
            catch (Exception )
            {
                DtResultado = null;

            }
            return DtResultado;
        }
       public DataTable BuscarNombre(DLibro Libro)
        {
            DataTable DtResultado = new DataTable("libro");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //1. Establecer la cadena de conexion
                SqlCon.ConnectionString = Conexion.Cn;

                //2. Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;//La conexión que va a usar el comando
                SqlCmd.CommandText = "spbuscar";//El comando a ejecutar
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //Decirle al comando que va a ejecutar una sentencia SQL

                //3.Enviamos el parámetro de Búsqueda
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Libro.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                //4. El DataAdapter que va a ejecutar el comando y es el encargado de llena el DataTable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);//Llenamos el DataTable
            }
            catch (Exception )
            {
                DtResultado = null;

            }
            return DtResultado;
        }
        public DataTable Buscar_Autor(DLibro Libro)
        {
            DataTable DtResultado = new DataTable("libro");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //1. Establecer la cadena de conexion
                SqlCon.ConnectionString = Conexion.Cn;

                //2. Establecer el comando
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;//La conexión que va a usar el comando
                SqlCmd.CommandText = "spbuscar_autor";//El comando a ejecutar
                SqlCmd.CommandType = CommandType.StoredProcedure;
                //Decirle al comando que va a ejecutar una sentencia SQL

                //3.Enviamos el parámetro de Búsqueda
                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Libro.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                //4. El DataAdapter que va a ejecutar el comando y es el encargado de llena el DataTable
                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);//Llenamos el DataTable
            }
            catch (Exception)
            {
                DtResultado = null;

            }
            return DtResultado;
        }
    }
    
}
