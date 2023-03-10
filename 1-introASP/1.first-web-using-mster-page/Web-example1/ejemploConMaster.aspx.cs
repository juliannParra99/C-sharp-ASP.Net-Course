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
        }

        protected void btnCheckBox_Click(object sender, EventArgs e)
        {

        }

        protected void btnCheckBox_Click1(object sender, EventArgs e)
        {
            cbRandom.Visible = true;
        }
    }
}