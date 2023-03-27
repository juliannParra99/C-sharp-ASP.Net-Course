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
    //en este ejemplo vamos a ver como seleccionar un elemento de la grilla para poder realizar distintas acciones
    //por lo que queremos hacer un select de la row e interactuar con ella. Inicialmente la grilla es texto
    //plano por lo que tengo que hacer algunos ajustes: en default aspx, agrego el campo: commandField, que es para
    //poder ejecutar una accion

    //en este ejemplo el ID es importante: yo habia programdo que no se muestre el id, pero es importante
    //para obtener los valores; hay dos maneras de obtener el id y que no se muestre en la columna.
    //se puede hacer por css y por .net
    //cabe resaltar que una manera seria usar un campo de asp, y poner visible=false, pero al hacer esto
    //el campo no se dibuja ni siquiera en el html, por lo que no puedo obtener el id; y yo necesito que lo dibuje
    //y lo oculete, para que pueda obtener el valor del id.  El visible=false no dibuje el html de los controles asp
    //por lo que hay que hacerlo manual mediante css o por .net
    public partial class autoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlColores.Items.Add("Blanco");
                ddlColores.Items.Add("Negro");
                ddlColores.Items.Add("Rojo");
            }
            //si la variable enviada por url es distinta de null quiere decir que ya existia, por que no se 
            //quiso agregar un nuevo elemento, sino que se selecciono uno existente y se mando por la url
            //si no es null guardo ese valor para acceder a sus datos y precargarlos
            if (Request.QueryString["id"] != null)
            {
                //quiero el id para buscar el objeto que quiero precargar
                int id = int.Parse(Request.QueryString["id"].ToString());
                //el objeto que quiero precargar esta en la session
                List<auto> temporal = (List<auto>)Session["listaAutos"];
                // y  busco el auto dentro del objeto por el id 
                auto seleccionado = temporal.Find(x => x.Id == id);
                //y del objeto obtenido precargo los valores
                txtId.Text = seleccionado.Id.ToString();
                //para que sea solo lectura y no se modifique
                txtId.ReadOnly = true;
                txtModelo.Text = seleccionado.Modelo;




            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            auto a = new auto();
            a.Id = int.Parse(txtId.Text);
            a.Modelo = txtModelo.Text;
            a.Descripcion = txtDescripcion.Text;
            a.Color = ddlColores.SelectedValue;
            a.Fecha = DateTime.Parse(txtFecha.Text);
            a.Usado = cbUsado.Checked;

            if (rdbImportado.Checked)
                a.Importado = true;
            else if (rdbNacional.Checked)
                a.Importado = false;

            // Se obtiene la lista de autos almacenada en la sesión en la variable temporal
            List<auto> temporal = (List<auto>)Session["listaAutos"];

            // Se comprueba si la lista es nula (no existe en la sesión)
            //esto es importante, el
            if (temporal == null)
            {
                // Si es nula, se crea una nueva lista vacía
                temporal = new List<auto>();
            }

            // Se agrega el nuevo objeto auto a la lista temporal
            temporal.Add(a);

            // Se almacena la lista actualizada de autos en la sesión: puede omitirse esta linea por que 
            //por que los datos de session estan enlazados al objeto que se asigna, entonces si se agrega
            //o modifica tambien lo hace la session. en el commit 10, no lo puse y no funcionaba bien:
            //pero tiene sus diferencias asique ojo, en este caso lo voy  a dejar comentado
            ////Session["listaAutos"] = temporal;

            // Se redirige al usuario a la página default.aspx
            Response.Redirect("default.aspx");
        }
    
    }
}