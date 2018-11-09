using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AVOT.WEB.PaginasMaestras
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["userAdmin"] == null && Session["user"] == null){
                lnkActividad.Visible = false;
                lnkAlumnos.Visible = false;
                lnkDocumentos.Visible = false;
                lnkPagoAlumnos.Visible = false;
                lnkCerrarSesion.Visible = false;
            }else if(Session["userAdmin"] != null){
                lnkAlumnos.Visible = true;
                lnkDocumentos.Visible = true;
                lnkPagoAlumnos.Visible = true;
                lnkActividad.Visible = true;
                lnkLogin.Visible = false;
                lnkRecuperarContraseña.Visible = false;
                lnkCerrarSesion.Visible = true;
            }else{
                lnkAlumnos.Visible = false;
                lnkDocumentos.Visible = true;
                lnkPagoAlumnos.Visible = true;
                lnkActividad.Visible = false;
                lnkLogin.Visible = false;
                lnkRecuperarContraseña.Visible = false;
                lnkCerrarSesion.Visible = true;
            }
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Index.aspx");
        }
    }
}