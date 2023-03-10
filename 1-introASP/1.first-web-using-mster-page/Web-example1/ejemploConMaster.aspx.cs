using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_example1
{
        //aca vamos a ver las diferencias entre un control html y controles asp; los controles asp los arrastramos de la barra de herramintas
        //y debido a que tiene la etiqueta 'runat="server"' podemos ejecutar logica de servidor con C#
        //utilizando el ID que le ponemos y utilizando
        //eventos del framework, cosa que no podemos hacer con el html plano aunque le agreguemos
        //'runat="server"' 
        
    public partial class ejemploConMaster : System.Web.UI.Page
    {
        //aca va a ir el codigoque yo quiero utilizar en mi form ASP
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text; 
            lblSaludo.Text = "Hola " + nombre;

            //eel objeto response.redirect permite navegar entre paginas desde el code behind, pero
            //nombre es muy recomendable utilizarlo, por que carga mucho el servidor por que al ejecutar
            //esto y terminar el bloque ejecuta un 'end' que corta el codigo que sigue en el bloque y da una excepcion
            // y puede si manejamos la excepcion toma la excepcion y no nos redirije etc; por lo que le colocamos
            //un false para que no corte el hilo de ejecucion, por lo que si no tenemos ningun codigo mas abajo
            //del response.redirect no pasa nada; pero si hay mas codigo puede que la pagina se redirija
            //pero siga ejecutando lo de abajo; pero mas adelante se vera como resolverlo
            Response.Redirect("ejemploASPX.aspx");
        }

        
        protected void btnCheckBox_Click1(object sender, EventArgs e)
        {
            cbRandom.Visible = true;

        }
    }
}