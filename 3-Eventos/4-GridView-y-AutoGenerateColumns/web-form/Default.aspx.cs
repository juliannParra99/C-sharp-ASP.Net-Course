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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            autoBussines autoBussines = new autoBussines();

            //con esto establezco la FUENTE, el objeto desde se recibiran los datos; estos datos pueden venir de cualquier
            //origen: una DB, internet, etc
            dgvAuto.DataSource = autoBussines.Listar();
            //este metodo hace que se rendereen esos datos en el data grid view: genera una columna por cada prop del objeto
            //y por cada registro que tiene el origen de datos, me genera una FILA

            //el data grid view se transforma en un elemento html que es una tabla

            //a esa tabla resultante le puedo aplicar las clases de bootstrap para estilizarla
            dgvAuto.DataBind();

        }
    }
}