using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AVOT.NEGOCIO;

namespace AVOT.WEB
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Apoderado apoderado = new Apoderado();

            if (!apoderado.ReadApoderado(txtUsuario.Text))
            {
                apoderado = null;
                lblMensajeError.Text = "Usuario y/o contraseña inválido.";
            }
            else if (!CryptoNew.VerifyPassword(txtContraseña.Text, apoderado.Passwd))
            {
                apoderado = null;
                lblMensajeError.Text = "Usuario y/o contraseña inválido.";
            }
            else
            {
                if (apoderado.Representante == 1)
                {
                    Session["userAdmin"] = apoderado;
                    Response.Redirect("~/Index.aspx");
                }
                else
                {
                    Session["user"] = apoderado;
                    Response.Redirect("~/Index.aspx");
                }
            }
        }
    }
}
