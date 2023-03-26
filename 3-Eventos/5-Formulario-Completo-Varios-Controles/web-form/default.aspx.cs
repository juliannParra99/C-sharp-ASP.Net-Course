using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using domain;
using Bussines;

namespace web_form
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //para seguir manteniendo los datos de la lista los guardo en session, para poder manipular los datos


            //antes de guardarla en session voy a preguntar si existe. Si en session, en "listaAutos" es nulo, creo una instancia
            //de autobussiness y  lo agrego a la session, si no es null entonces ya existe

            //esto pregunta cuando tengo la pantalla de la lista, tengo la lista de autos guardada en session? si es nulo
            //no la tengo, entonces la creo

            //hago esto para poder tener los datos durables en el tiempo

            if (Session["listaAutos"] == null)
            {
                autoBussines autoBussines = new autoBussines();
                Session.Add("listaAutos", autoBussines.Listar());

            }
            //y ahora el origen de datos es la session["listaAutos"] que persiste los datos en el tiempo: lo que hago es que si
            //la session esta en null creo el objeto autoBussines, la guardo en la session y ahora trabajo con esos datos
            //que ahora estan guardados en session
            dgvAuto.DataSource = Session["listaAutos"];

            //cuando yo toque el boton aceptar, el registro se va a agregar en el objeto guardado en session y que contiene la lista
            //y en autoForm voy a recuperar la lista de la session, para poder agregarleun elemenot
            dgvAuto.DataBind();
        }
    }
}