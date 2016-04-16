using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EspacioAdmin
{
    public partial class CrearUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Control de sesion, si no es administrador no puede entrar aquí
            if (Session["Usuario"] == null || ((Usuario)Session["Usuario"]).perfil != "SuperAdmin" || ((Usuario)Session["Usuario"]).perfil != "Admin")
                Response.Redirect("Login.aspx");
        }

        protected void ddlPerfil_Init(object sender, EventArgs e)
        {
            ddlPerfil.Items.Add("--Seleccione--");
            ddlPerfil.Items.Add("Admin");
            ddlPerfil.Items.Add("Conserje");
            ddlPerfil.Items.Add("Directiva");
            ddlPerfil.Items.Add("Residente");
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == string.Empty)
                    throw new Exception("Debe ingresar un nombre de Usuario");
                if (txtPassword.Text == string.Empty)
                    throw new Exception("Debe ingresar una contraseña");
                if (txtConfirmaContra.Text == string.Empty)
                    throw new Exception("Debe ingresar una contraseña");
                if (txtPassword.Text != txtConfirmaContra.Text)
                    throw new Exception("Las contraseñas no coinciden");
                if (ddlPerfil.SelectedIndex == 0)
                    throw new Exception("Debe seleccionar un Perfil");

                //Si todo funciona

                Database1Entities1 bd = new Database1Entities1();
                Usuario user = new Usuario();
                user.usuario1 = txtUsuario.Text;
                user.password = txtPassword.Text;
                user.perfil = ddlPerfil.SelectedValue.ToString();
                if (chkHabilitado.Checked==true)
                {
                    user.habilitado = true;
                }else
                {
                    user.habilitado = false;
                }

                //agregar todo a la base de datos
                bd.Usuario.Add(user);
                bd.SaveChanges();
                lblAviso.Text = "Usuario creado exitosamente";
            }
            catch (Exception ex)
            {
                lblAviso.ForeColor = System.Drawing.Color.Red;
                lblAviso.Text = ex.Message;
            }
        }
    }
}