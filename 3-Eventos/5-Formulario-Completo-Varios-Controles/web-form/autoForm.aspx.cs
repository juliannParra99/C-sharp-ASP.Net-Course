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
    public partial class autoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //manejo el posback para que no cargue de nuevo estos valores en el el DDL

            if (!IsPostBack)
            {
                ddlColores.Items.Add("Blanco");
                ddlColores.Items.Add("Negro");
                ddlColores.Items.Add("Rojo");
            }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            //&&cuando haga click en el boton para enviar, quiero que se lean los datos correspondientes y se guarden en
            //    el objeto

            auto a = new auto();
            a.Id = int.Parse(txtId.Text);
            a.Modelo = txtModelo.Text;
            a.Descripcion = txtDescripcion.Text;
            a.Color = ddlColores.SelectedValue;
            a.Fecha = DateTime.Parse(txtFecha.Text);
            a.Usado = cbUsado.Checked;

            //ya tengo mis datos de auto; esto en un escenario corriente se lo cargaria en una db, PERO EN ESTE CASO LO VAMOS
            //A AGREGR A LA GRILLA EN MEMORIA, pero no la tengo en memoria por que lo que hice hasta ahroa fue 
             //leer la grilla estatica: para poder tener la lista en memoria la guardo en SESSION en default.aspx.cs

            //hay 2 formas de  capturar ele stado d elos radio button
            //la primera es mas enogrrosa pero mas fcil: es validar el true todos los checkbox segun estan en true o no
            //pero puede ser complicado si tengo muchos check box: en este caso como son dos opciones utilizo el true y el false
            //pero  si fueran mas opciones seria recomendable hacerlo por un enum quizas

            //la otra manera de capturar el valor es colocando al radio button el evento onChekedChange en el aspx,
            //que sirve para saber cuando un botton fue cheked o no.
            if (rdbImportado.Checked)
                a.Importado = true;
            else if (rdbNacional.Checked)
                a.Importado = false;
            

            //cuando yo toque el boton aceptar, el registro se va a agregar en el objeto guardado en session y que contiene la lista
            //y en autoForm voy a recuperar la lista de la session, para poder agregarleun elementos: tiene una forma larga
            //y una corta


            //RECUPERO LA LISTA DE LA SESSION PARA PODER AGREGARLE UN ELEMENTO

            //en la session se puede guardar cualquier cosa

            //forma corta
            //((List<auto>)Session["listaAutos"]).Add(a);

            //forma larga: la mas sencilla de comprender
            //si quiero recuperar la lista entonces:

            List<auto> temporal = (List<auto>)Session["listaAutos"];
            temporal.Add(a);

            //y ahora agrego el auto: CUANDO AGREGO UN NUEVO AUTO, EN ESTE CASO EL OBJETO LSIT TEMPORAL ESTA ENLAZADO A LA
            //SESSION["listaAuto"], por lo que comparten referencia al mismo objeto, osea que lo que agregue o modifique en
            //temporal va a ocurrir tambien en ese objeto de session

            //redirecciono a la lista: y si todo estuvo bien, va  a cargar de la session la lsita que ya existe con el nuevo
            //elemento
            Response.Redirect("default.aspx");


            //resumiendo lo que hicimos: en default, creamos el objeto session["listaAuto"] que trae una list de autos
            //que v a aser el origen de la grilla que se muestra, y cuyo objeto se mantiene vivo en session.Por lo que
            //uso otro objeto para hacer referencia a ese objeto vivo, y le agrego nuevos datos, que se van a mostrar en la 
            //grilla


        }
        //ojo con este tipo de eventos: por que el autopostback puede funcionar de manera diferente: en este caso se 
        //va a ejecutar cuando toque el btn aceptar
        protected void rdbImportado_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}