using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BE;
using BL;

namespace UI
{
    public partial class GeneroListar : System.Web.UI.Page
    {
        //referencia
        private GeneroBL generoBL = new GeneroBL();

        //método arrancador
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvGeneros.DataSource = generoBL.FindAll();
                gvGeneros.DataBind();
            }
        }

        protected void gvGeneros_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvGeneros.PageIndex = e.NewPageIndex;

            gvGeneros.DataSource = generoBL.FindAll();
            gvGeneros.DataBind();
        }
    }
}
