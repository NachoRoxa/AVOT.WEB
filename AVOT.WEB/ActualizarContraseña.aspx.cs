using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AVOT.NEGOCIO;

namespace AVOT.WEB
{
    public partial class ACtualizarContraseña : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (txtNewPass.Text == txtRePass.Text)
                {
                    var uri = new Uri(HttpContext.Current.Request.Url.ToString());
                    var query = HttpUtility.ParseQueryString(uri.Query);
                    string usuario = query.Get("us").ToString();
                    new Apoderado().UpdatePass(usuario, CryptoNew.CreatePasswordHash(txtNewPass.Text));
                    Response.Redirect("Index.aspx");
                }
                else
                {
                    lblError.Text = "Por favor, confirmar que la contraseña sea la misma en ambas casillas";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
