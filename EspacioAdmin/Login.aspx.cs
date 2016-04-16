using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace EspacioAdmin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session.Remove("Usuario");
            //FormsAuthentication.SignOut();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtUsuario.Text == string.Empty)
                    throw new Exception("Debe ingresar un nombre de usuario");
                if (txtPassword.Text == string.Empty)
                    throw new Exception("Debe ingresar una Contraseña");
                Database1Entities1 bd = new Database1Entities1(); //Verificar el login
                Usuario user = bd.Usuario.FirstOrDefault(it => it.usuario1 == txtUsuario.Text);
                if (user == null || user.password != txtPassword.Text)
                {
                    throw new Exception("Login incorrecto");
                }
                //Crear variables de sesion, ingresar en la variable un objeto
                
                //FormsAuthentication.RedirectFromLoginPage(user.usuario1, false);
                Session["Usuario"] = user;
                Response.Redirect("Default.aspx", false);
            }
            catch (Exception ex)
            {
                lblAviso.ForeColor = System.Drawing.Color.Red;
                lblAviso.Text = ex.Message;
            }
        }
    }
}