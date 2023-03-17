using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_example1
{


    //Eventos, Postback y AutoPostback
    //se va a modificar ejemploConMaster.aspx

    public partial class ejemploConMaster : System.Web.UI.Page
    {
        //LOS EVENTOS EN WEB HACEN QUE CADA VES QUE SE UTILIZA UN EVENTO PASEN ANTES POR EL PAGE_LOAD, POR LO QUE TENEMOS
        //QUE JUGAR CON LOS POSTBACK: ESTO ES, CUANDO LA PAGINA CARGA POR PRIMERA VEZ PASA POR PRIMERA VEZ
        //POR EL PAGE_LOAD, PERO  CUANDO EJECUTAMOS UN EVENTO QUE COMO CONSECUANCIA HACE UNA ACCION EN EL SERVIDOR, EJECUTA
        //UNA NUEVA CARGA, UN NUEVO PAGE_LOAD, LLAMA DE NUEVO AL SERVIDOR(POSTBACK),OSEA QUE NO ES LA PRIMERA VEZ QUE VA AL 
        //SERVIDOR, POR LO QUE MANEJO EL POSTBACK, OSEA LA POSIBILIDAD DE QUE ESTE FRENTE A UNA NUEVA CARGA DE LA PANTALLA
        //PERO QUE NO LO EJECUTE TODO COMO SI FUERA LA PRIMERA VEZ, POR QUE HAY COSAS QUE QUIERO QUE SE CARGUEN UNA SOLA
        //VEZ EN LA PANTALLA INICIAL
        //SI ESTOY FRENTE A LA PRIMERA VEZ QUE SE EJECUTA EL LOAD, VOY A PRECARGAR EL VALOR, Y SINO ESTOY FRENTE A LA PRIMERA
        //VEZ NO LO EJECUTO

        //aca va a ir el codigoque yo quiero utilizar en mi form ASP
        protected void Page_Load(object sender, EventArgs e)
        {
            //Ejemplo de postback para que  se ejecute todo correctamente

            //si no es postback, osea si la pagina no se ejecuto varias veces para traer datos del servidor, osea
            //si es la priemera vez que se ejecuto(el page_load), precargo el nombre, sino lo salteo
            if (!IsPostBack)
            {
                txtNombre.Text = "Ingrese su nombre.";

            }
        }
        //esto se ve mejor colocando puntos de interrupcion en  btnAgregar y en Page_Load:
        //cuando toco en el btnAgregar, el flujo de la pagina vuelve a pasar por el page_load de nuevo, y carga el valor
        //inicial del text box y no el que nosotros colocamos, por que al invocar de nuevo el page_load
        //pisa mis cambios

        //SIEMPRE QUE SE EJECUTE UN EVENTO EN WEB .NET VA A PASAR PRIMERO POR EL EVENTO LOAD

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            lblSaludo.Text = "Hola " + nombre;


            //Response.Redirect("ejemploASPX.aspx", false);
        }



        //se agrego evento en caja de texto: con este ejemplo se puede ver que es el postBack
        //el postback es un concepto del ambito web con .net en referencia a como ocurren los eventos

        //CON EL TextChanges, saque el foco de la caja de textod espues de haber cambiado elt exto y no s ejecuto,
        //Se ejecuto despuus de hacer click en el boton: esto por que no tiene un postback automatico, sino que se
        //ejecuta cuando alguien lo acompaña, cuando otro evento hace un postback, en este caso el boton, que tiene un
        //postback automatico; pasa primero por el text changed por que sucedio primero, es el orden de prioridad d elos eventos
        //SI YO QUIERO QUE ESTO NO OCURRA Y QUIERO QUE EL EVENTO SE DISPARE CUANDO DEBERIA DISPARARSE, PUEDO PONER EL AUTOPOSBACK
        //EN TRUE EN LA CAJA DE TEXTO, ESTO HACE QUE NO TENGA QUE ESPERAR CON UN PROPIO AUTOPOSBACK PARA QUE SE EJECUTE
        //pero ojo, no siempre es bueno tener autopostback en true por que va a estarhaciendo cosas y actualizando la pantalla
        //cuando no queremos pero es importante saberlo; pero puede servir en casos como este para evitar retrasos
        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblSecundario.Text = "El texto ingresado es: " + txtNombre.Text;
        }
    }
}