﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AVOT.WEB
{
    public partial class PagoAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userAdmin"] == null && Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}