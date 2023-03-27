using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using domain;
using bussines;

namespace web_form
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["listaAutos"] == null)
            {
                autoBussines autoBussines = new autoBussines();
                Session.Add("listaAutos", autoBussines.Listar());

            }


            dgvAuto.DataSource = Session["listaAutos"];
            dgvAuto.DataBind();
        }

        //cuando toque el boton de la nueva columna 'accion' ,pero a mi me interesa capturar cual es el valor
        //actual de la lsita
        protected void dgvAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //'var'  es una variable dinamica que va tomar el tipo del valor del objeto sea cual sea el tipo
            //en este caso almacena el valor de la celda 0 

            //esto mas bien es para visualizar, no se usa en la utilidad
            var algo = dgvAuto.SelectedRow.Cells[0].Text;
            //le pido que me de el valor clave: el id es importante para por ejemplo crear un crud: en este
            //ejemplo voy a capturar los datos del seleccionado y precargarlos en el formAuto
            var id = dgvAuto.SelectedDataKey.Value.ToString();
            //con esto voy a navegar a autoForm con el valor del id del elemento seleccionado: para recuperar
            //el objeto desde la sesion y precargar los valores
            Response.Redirect("autoForm.aspx?id=" + id);
        }
    }
}