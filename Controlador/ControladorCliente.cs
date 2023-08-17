using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Muestra__Busqueda_y_Filtro_de_Datos.Modelo.DTO;
using Muestra__Busqueda_y_Filtro_de_Datos.Modelo.DAO;
using Muestra__Busqueda_y_Filtro_de_Datos.Vista;
using System.Drawing.Printing;

namespace Muestra__Busqueda_y_Filtro_de_Datos.Controlador
{
    internal class ControladorCliente
    {
        Cliente vista; //atributo de tipo Cliente (vista)

        public ControladorCliente(Cliente view) //contructor
        { 
            vista = view; //esto sirve como instancia para poder acceder a todos los elemtos de (vista) Cliente

            //inicializacion de eventos de la (vista) 
            vista.Load += new EventHandler(ListaCliente); //este objeto espera que enviemos la fuente del evento y el onjeto del evento sin datos entonces enviamos el metodos de que creamos abajo
        
            vista.btnbuscar.Click += new EventHandler(ListaCliente);
            
            vista.txtbuscar.TextChanged += new EventHandler(ListaCliente);
        }

        //evento para listar los clientes
        //metodo
        private void ListaCliente(object sender, EventArgs e)//parametros - un objeto remitente que es la fuente del evento y el objeto evento sin datos 
        {
            ClientesDAO db = new ClientesDAO(); //instanciamos al acceso de datos de cliente para poder invocar los metodos CRUD 

            vista.dgvclientes.DataSource = db.MostrarRegistros(vista.txtbuscar.Text);

        }












    }
}
