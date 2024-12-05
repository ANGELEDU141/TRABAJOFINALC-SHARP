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
    public partial class GeneroBorrar : Utilidades
    {
        private GeneroBL generoBL = new GeneroBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(Request.QueryString["paramID"]);
            GeneroBE generoBE = generoBL.FindById(ID);

            if (!IsPostBack)
            {
                txtID.Text = generoBE.ID.ToString();
                txtDescripcion.Text = generoBE.Descripcion;
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtID.Text);
            bool isDelete = generoBL.isDelete(ID);

            if (isDelete)
            {
                generoBL.Delete(ID);
                Response.Redirect("~/GeneroListar");
            }
            else
            {
                MessageBox("¡Error, no se puede borrar porque está asociado a la tabla Libros!");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GeneroListar");
        }
    }
}
