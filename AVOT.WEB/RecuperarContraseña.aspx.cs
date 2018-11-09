using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AVOT.NEGOCIO;

namespace AVOT.WEB
{
    public partial class RecuperarContraseña : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            Apoderado apoderado = new Apoderado();
            apoderado.GetUsuarioCorreo(correo);
            if (apoderado != null)
            {
                new Correo().EnvioDeCorreos(apoderado.Correo, apoderado.User);
                Response.Redirect("Login.aspx");
            }
            else
            {
                lblError.Text = "El correo ingresado no es válido. Intente de nuevo";
                txtCorreo.Text = "";
            }
        }
    }
}