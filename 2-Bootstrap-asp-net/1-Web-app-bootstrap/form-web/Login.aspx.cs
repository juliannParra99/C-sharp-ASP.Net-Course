using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace form_web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string userEmail = txtEmail.Text;
            string userPassword = txtPassword.Text;

            lblUserEmail.Text = "The user's email is: " + userEmail;
            lblUserPassword.Text = "The user's password is: " + userPassword;
        }
    }
}