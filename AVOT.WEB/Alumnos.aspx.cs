using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AVOT.NEGOCIO;

namespace AVOT.WEB
{
    public partial class Alumnos : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        DataRow dr = null;
        
        Apoderado apoderado = new Apoderado();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userAdmin"] == null && Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else {
                apoderado = (Apoderado)Session["userAdmin"];
            }

            if (!IsPostBack)
            {
                List<Alumno> alumnos = new List<Alumno>();
                alumnos = new Alumno().ListarAlumno(apoderado.Run);
                dt.Columns.Add("Colegio", System.Type.GetType("System.String"));
                dt.Columns.Add("RUN", System.Type.GetType("System.String"));
                dt.Columns.Add("Nombre completo", System.Type.GetType("System.String"));
                dt.Columns.Add("Monto personal", System.Type.GetType("System.String"));
                dt.Columns.Add("Nombre apoderado", System.Type.GetType("System.String"));
                
                foreach (var alumno in alumnos)
                {
                    dr = dt.NewRow();
                    dr["Colegio"] = alumno.Curso.Colegio.NombreColegio;
                    dr["RUN"] = alumno.Run;
                    dr["Nombre completo"] = alumno.Nombre + " " + alumno.ApellidoPaterno + " " + alumno.ApellidoMaterno;
                    dr["Monto personal"] = alumno.MontoPersonal.ToString();
                    dr["Nombre apoderado"] = alumno.Apoderado.Nombre+" "+alumno.Apoderado.Apellido;
                    dt.Rows.Add(dr);
                }
                dt.AcceptChanges();
                gdvAlumnos.DataSource = dt;
                gdvAlumnos.DataBind();
            }
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {

            
        }
    }
}