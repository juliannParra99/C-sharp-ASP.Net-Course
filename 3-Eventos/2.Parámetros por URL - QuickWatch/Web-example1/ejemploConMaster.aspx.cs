using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_example1
{




    public partial class ejemploConMaster : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                txtNombre.Text = "Ingrese su nombre.";

            }
        }
        
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            lblSaludo.Text = "Hola " + nombre;
            //; vamos a realizar el caso en que  estamos en esta pagina y hay un formulario de login, que nos pide
            //    el nombre y nos redirije a la pagina default y nos indica nuestros datos.

            //no e slo mejor utilizar pasaje de param por url para usuario y contraseña por que queda a la vista los datos
            //pero es bueno conocer esta manera
            //en este caso me redirige a  la pag default

            //para pasar un parametro por url uso el '?' que indica que voy  a agregar una variable, y le concateno el valor
            //asi cuando me redirija a esa pantalla, voy a ver en la url los valores q puse en la caja de texto

            //para este caso voy a quitar el autoPostback de la caja de texto, por que al hacer click sobre el boton
            //se ejecuta solo textChanged, pero no redirecciona sino hasta hacer dos clicks, y yo quiero q lo haga en uno
            // de la variable nombre
            Response.Redirect("Default.aspx?nombre=" + nombre, false);
        }



       
        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblSecundario.Text = "El texto ingresado es: " + txtNombre.Text;
        }
    }
}
