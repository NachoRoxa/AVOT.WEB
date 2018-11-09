using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AVOT.WEB.PaginasMaestras
{
    public partial class Actividades : System.Web.UI.Page
    {
        List<Actividades> actividades;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userAdmin"] == null && Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
      
          
        }

        protected void BorrarEntrada(object sender, EventArgs e) {

        }

        protected void AgregarActividad(object sender, EventArgs e) {

        }

        protected void GuardarCambios(object sender, EventArgs e)
        {

        }
    }
}