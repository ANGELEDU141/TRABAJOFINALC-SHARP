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
    public partial class GeneroEditar : System.Web.UI.Page
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

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //entrada
            int ID = Convert.ToInt32(txtID.Text);
            string descripcion = txtDescripcion.Text;

            //proceso
            GeneroBE generoBE = new GeneroBE(ID, descripcion);
            generoBL.Update(generoBE);

            //salida
            Response.Redirect("~/GeneroListar");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/GeneroListar");
        }
    }
}
