using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Muestra__Busqueda_y_Filtro_de_Datos.Controlador;

namespace Muestra__Busqueda_y_Filtro_de_Datos.Vista
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();

            ControladorCliente ctrl = new ControladorCliente(this); //el constructor espera que enviemos la vista, entonces enviamos el formulario con la palabra (this)

        }
    }
}
