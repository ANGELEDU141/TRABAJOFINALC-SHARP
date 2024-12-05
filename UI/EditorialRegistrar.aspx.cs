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
    public partial class EditorialRegistrar : Utilidades
    {
        //referencia
        private EditorialBL editorialBL = new EditorialBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // No additional data binding needed for this page
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                //entrada
                string descripcion = txtDescripcion.Text;

                //proceso
                EditorialBE editorialBE = new EditorialBE(descripcion);
                editorialBL.Insert(editorialBE);

                //salida
                Response.Redirect("~/EditorialListar");
            }
            else
            {
                MessageBox("¡Error, campos no validados!");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EditorialListar");
        }
    }
}
