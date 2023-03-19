using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_example1
{ 
    //entonces 2 maneras de pasar valores por parametro: capturando el valor de una caja de texto y concatenandolo en el
    //response.redirect; y la otra manera creando un link, un href, donde le agrego a mano los valores, aunque estos valores
    //tambien pueden  pasarse de forma dinamica
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //aca capturo el valor del valor de la variable pasada por parametro y se lo asigno a lblUser

            //user va a acaputrar el resultado del valor que esta viniendo, mediante el objeto REQUEST

            //HAY QUE TENER CUIDADO, por que si accedemos a la pagina  default y quiere leer datos de una variable
            //mandada por url que no contiene, esa variable esta en null y no carga la pagina; por lo que tenemos que validarlo
            //, o pasarle el valor de la variable por url (que no es nada practico)

            //validacion por si el request tiene el valor de la variable null

            if (Request.QueryString["nombre"] != null)
            {
                string user = Request.QueryString["nombre"].ToString();
                lblUser.Text = user + " tu ingreso fue exitoso!";

            }
            else
            {
                lblUser.Text = "Debes loguearte.";
            }

            //ejemplo con un operador ternario, es lo mismo
            //string user = Request.QueryString["nombre"] != null ? Request.QueryString["nombre"].ToString() : "logueate";
            //lblUser.Text = user + " tu ingreso fue exitoso!";
        }
    }
}