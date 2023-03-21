using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_example1
{ 
    public partial class _Default : Page
    {
        //lo que quiero hacer es, segun si se logeo o no en la pagina ejemploConMaster, que muestre que se logeo, o que diga
        //que no se logeo y debe hacerlo; para eso voy a agregarle UN ATRIBUTO AL OBJETO PARA PODER MANIPULARLO


        public string user { get; set; } //y cuando se cargue la pantalla lo voy a escribir con un dato a mostrar u otro
        protected void Page_Load(object sender, EventArgs e)
        {

            //validacion por si el request tiene el valor de la variable null

            //if (Request.QueryString["nombre"] != null)
            //{
            //    string user = Request.QueryString["nombre"].ToString();
            //    lblUser.Text = user + " tu ingreso fue exitoso!";

            //}
            //else
            //{
            //    lblUser.Text = "Debes loguearte.";
            //}

            //ejemplo con un operador ternario, es lo mismo
            //user = Request.QueryString["nombre"] != null ? Request.QueryString["nombre"].ToString() : "";


            //recupero desde el servidor: pongo el nombre que le puse: LA DIFERENCIA ES QUE CON SESSION NO SE MUESTRAN
            //LOS DATOS EN LA URL; los datos van a permaneceer hasta que se cierre la sesion, o los podemos modificar,
            //eliminar,etc segun necesitemos.
            user = Session["usuario"] != null ? Session["usuario"].ToString() : ""; 
            lblUser.Text = user + " tu ingreso fue exitoso!";
        }
    }
}