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
    public partial class EditorialEditar : System.Web.UI.Page
    {
        private EditorialBL editorialBL = new EditorialBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(Request.QueryString["paramID"]);
            EditorialBE editorialBE = editorialBL.FindById(ID);

            if (!IsPostBack)
            {
                txtID.Text = editorialBE.ID.ToString();
                txtDescripcion.Text = editorialBE.Descripcion;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //entrada
            int ID = Convert.ToInt32(txtID.Text);
            string descripcion = txtDescripcion.Text;

            //proceso
            EditorialBE editorialBE = new EditorialBE(ID, descripcion);
            editorialBL.Update(editorialBE);

            //salida
            Response.Redirect("~/EditorialListar");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EditorialListar");
        }
    }
}
