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
            string password = txtPassword.Text;
            lblSaludo.Text = "Hola " + nombre;

            //para pasar mas de una variable uso el "&"; ahora recibo 2 parametros que puedo recuperar;
            //esto es de manera de ejemplo; si pusieramos una contra real habria que validar
            //1era forma
            //Response.Redirect("Default.aspx?nombre=" + nombre + "pass" + txtPassword.Text, false);

            //otra manera de mandar las variables de usuario y contraseña que no sea la que indique arriba es utilizando el
            //session
            //hago el redirect pero sin datos

            //para usar el metodo de session, ahora que tengo ambas variables las guardo en session antes de mandarlo
            //session es un objeto que va a estar vivo y que va a tener una instancia para cada instancia que este siendo consumida
            //en ese momento; cuando tu te conectas se genera una instancia para ti, cuando yo me conecto se genera una instancia para mi
            //; el objeto session es como una bolsa en la que se puede cargar cualquier cosa, variables,objetos, listas, vectores, etc
            //y para cargarlo voy a usar el metodo add.

            Session.Add("usuario", nombre); //es como un objeto de clave valor, donde "nombre" contiene el contenido de la variable
            Session.Add("pass", password); //es como una coleccion de tipo clave valor que despues se puede recuperar desde cualquier
            //pantalla, evento por ese nombre

            //entonces cuando le de click voy a recuperar los datos  en la pagina DEFAULT.ASPX.CS, los voy a guardar en sesion en el servidor,
            //redirijo a la otra pantalla, y en la otra pantalla en el load lo voy a recuperar

            //2da forma: Lo redirijo a esa pantalla y recupero los datos de session alli
            Response.Redirect("Default", false);
        }



       
        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblSecundario.Text = "El texto ingresado es: " + txtNombre.Text;
        }
    }
}
