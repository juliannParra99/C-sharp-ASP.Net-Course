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
    public partial class direccionForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //si la url de la direccion de la pagina contiene una variable id, osea si es distinto de null
            // se cargo la pagina desde el boton seleccionar de Default, por lo que guardo el valor del id
            //para hallar el valor seleccionado del objeto q quiero entocntrar. Si es null,entonces se toco agregar.
            if (Request.QueryString["id"] != null) //uno precarga datos, el otro genera el form vacio
            {
                int id = int.Parse(Request.QueryString["id"]);

                //el objeto que quiero esta en la session 
                List<direccion> temporal = (List<direccion>)Session["listaDireccion"];
                //obtengo el objeto que tenga el mismo id que el id del objeto que seleccione y lo asigno a 
                //mi nuevo objeto direccion
                direccion direccion = temporal.Find(x => x.Id == id);
                //precargo los valores.
                txtId.Text = direccion.Id.ToString();
                //para que si selecciono ese valor y quiero modificar o eliminar el id no se toque, por que es
                //un elemento existente.
                txtId.ReadOnly = true; 
                txtCalle.Text = direccion.calle;
                txtAltura.Text = direccion.altura.ToString();
            }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            direccion x = new direccion();

            x.Id = int.Parse(txtId.Text);
            x.calle = txtCalle.Text;
            x.altura = int.Parse(txtAltura.Text);

            //quiero agregar datos: traigo el objeto guardado en session lo asigno a una variable
            //y referencian al mismo objeto en session, por lo que si agrego algo en la variable nueva
            //se guarda en el objeto en session. Hago casteo explicito para el objeto en session
            List<direccion> temporal = (List<direccion>)Session["listaDireccion"];

            if (temporal == null)
            {
                //si es nula se crea un nuevo objeto y se le asigna igualmente el valor de la session
                temporal = new List<direccion>();
            }
            //agrega el nuevo valor
            temporal.Add(x);

            Response.Redirect("default.aspx");
        }
    }
}