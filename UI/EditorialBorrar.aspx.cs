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
    public partial class EditorialBorrar : Utilidades
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

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtID.Text);
            bool isDelete = editorialBL.isDelete(ID);

            if (isDelete)
            {
                editorialBL.Delete(ID);
                Response.Redirect("~/EditorialListar");
            }
            else
            {
                MessageBox("¡Error, no se puede borrar porque está asociado a la tabla Libros!");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/EditorialListar");
        }
    }
}
