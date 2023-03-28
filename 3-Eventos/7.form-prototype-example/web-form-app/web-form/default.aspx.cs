using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bussines;
using domain;

namespace web_form
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //pregunto: si en session el esta guardado el objeto, que referencia listaDireccion; si esta null
            //lo creo, sino uso el ya existente
            if (Session["listaDireccion"] == null)
            {
                direccionBussines direccionBussines = new direccionBussines();
                ///par clave valor, la clave hace referencia al objeto que se le asigna: el objeto session guarda
                //los datos y permite interactuar con ellos mediante la ejecucion del programa. como agregar
                //Elimianr etc.
                Session.Add("listaDireccion", direccionBussines.listar());
            }
            //le paso el valor
            dgvDirecciones.DataSource = Session["listaDireccion"];


            //dibuja la grilla
            dgvDirecciones.DataBind();
        }

        protected void dgvDirecciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //guardo el data key: capturo el id del elemento seleccionado.Con esto puedo realizar un CRUD, por ej.
            var id = dgvDirecciones.SelectedDataKey.Value.ToString();

            Response.Redirect("direccionForm.aspx?id=" + id);
        }
    }
}