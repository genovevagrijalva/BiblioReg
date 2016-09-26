using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using System.Data;


namespace BIBLIOREG_Lib
{
   public class NLibro
    {
       //Método que llama al método Insertar de la Capa de Datos de la clase DLibro
        public static string Insertar(string nombre, DateTime fechaRegistro, string autor, string editorial, string descripcion)
        {
            DLibro Obj = new DLibro();
            Obj.Nombre = nombre;
            Obj.FechaRegistro = fechaRegistro;
            Obj.Autor = autor;
            Obj.Editorial = editorial;
            Obj.Descripcion = descripcion;
            
            return Obj.Insertar(Obj);
        }
        //Método que llama al método Actualizar de la Capa de Datos de la clase DLibro
        public static string Editar(int idLibro, string nombre, DateTime fechaRegistro,string autor, string editorial, string descripcion)
        {
            DLibro Obj = new DLibro();
            Obj.IdLibro = idLibro;
            Obj.Nombre = nombre;
            Obj.FechaRegistro = fechaRegistro;
            Obj.Autor = autor;
            Obj.Editorial = editorial;
            Obj.Descripcion = descripcion;
            
            return Obj.Editar(Obj);
        }

        //Método que se encarga de llamar al método Eliminar de la clase DLibro
        public static string Eliminar(int IdLibro)
        {
            DLibro Obj = new DLibro();
            Obj.IdLibro = IdLibro;

            return Obj.Eliminar(Obj);
        }

        //Método que se encarga de llamar al método Mostrar de la clase DLibro
        public static DataTable Mostrar()
        {
            return new DLibro().Mostrar();
        }
        
        
        //Método BuscarNombre que llama al Método BuscarNombre de la clase DLibro de la capa de datos
        public static DataTable BuscarNombre(string textobuscar)
        {
            DLibro Obj = new DLibro();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNombre(Obj);
        }
        //Método que busca al profesor mediante su numero de expediente, llamando al Método en la clase DLibro
        public static DataTable Buscar_Autor(string textobuscar)
        {
            DLibro Obj = new DLibro();
            Obj.TextoBuscar = textobuscar;
            return Obj.Buscar_Autor(Obj);
        }
        

    
    }
}
