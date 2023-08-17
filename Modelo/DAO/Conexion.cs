using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Muestra__Busqueda_y_Filtro_de_Datos.Modelo.DAO
{
    public class Conexion //el modificador de acceso debe de estar como publico
    {
        protected SqlConnection ConexionBD = new SqlConnection("Server=MSI\\SQLEXPRESS;DataBase=Practica_Patrones;Integrated Security=true");

    }
}
