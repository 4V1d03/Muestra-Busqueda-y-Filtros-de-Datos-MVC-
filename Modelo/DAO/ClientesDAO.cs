using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Muestra__Busqueda_y_Filtro_de_Datos.Modelo.DTO;

namespace Muestra__Busqueda_y_Filtro_de_Datos.Modelo.DAO
{
    internal class ClientesDAO: Conexion
    {
        SqlDataReader leerfilas;
        SqlCommand cmd = new SqlCommand();

        //Metodos CRUD
        public List<Clientes> MostrarRegistros(string busqueda)
        {
            cmd.Connection = ConexionBD;
            cmd.CommandText = "MostrarRegistros";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@busqueda", busqueda);

            ConexionBD.Open();

            leerfilas = cmd.ExecuteReader();
            List<Clientes> listadatos = new List<Clientes>();
            while (leerfilas.Read())
            {
                listadatos.Add(new Clientes()
                {
                    ID = leerfilas.GetInt32(0),
                    Nombre = leerfilas.GetString(1),
                    Apellido = leerfilas.GetString(2),
                    Direccion = leerfilas.GetString(3),
                    Ciudad = leerfilas.GetString(4),
                    Email = leerfilas.GetString(5),
                    Telefono = leerfilas.GetString(6),
                    Ocupacion = leerfilas.GetString(7),
                });
            }
            leerfilas.Close();
            ConexionBD.Close();
            return listadatos;

        }

        public void insertar()
        {

        }

        public void eliminar()
        {

        }

        public void editar()
        {

        }

    }
}
