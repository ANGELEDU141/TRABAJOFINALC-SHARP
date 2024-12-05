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
    public partial class EditorialListar : System.Web.UI.Page
    {
        //referencia
        private EditorialBL editorialBL = new EditorialBL();

        //método arrancador
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvEditoriales.DataSource = editorialBL.FindAll();
                gvEditoriales.DataBind();
            }
        }

        protected void gvEditoriales_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvEditoriales.PageIndex = e.NewPageIndex;

            gvEditoriales.DataSource = editorialBL.FindAll();
            gvEditoriales.DataBind();
        }
    }
}
