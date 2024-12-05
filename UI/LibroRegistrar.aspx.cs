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
    public partial class LibroRegistrar : Utilidades
    {
        //referencia
        private LibroBL libroBL = new LibroBL();
        private GeneroBL generoBL = new GeneroBL();
        private EditorialBL editorialBL = new EditorialBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlGenero.DataSource = generoBL.FindAll();
                ddlGenero.DataValueField = "ID";
                ddlGenero.DataTextField = "Descripcion";
                ddlGenero.DataBind();

                ddlEditorial.DataSource = editorialBL.FindAll();
                ddlEditorial.DataValueField = "ID";
                ddlEditorial.DataTextField = "Descripcion";
                ddlEditorial.DataBind();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                //entrada
                string isbn = txtISBN.Text;
                string titulo = txtTitulo.Text;
                int edicion = Convert.ToInt32(txtEdicion.Text);
                int idGenero = Convert.ToInt32(ddlGenero.SelectedValue.ToString());
                int idEditorial = Convert.ToInt32(ddlEditorial.SelectedValue.ToString()); ;

                // Uso de TryParse para manejar conversiones seguras
                if (int.TryParse(txtEdicion.Text, out edicion) &&
                    int.TryParse(ddlGenero.SelectedValue.ToString(), out idGenero) &&
                    int.TryParse(ddlEditorial.SelectedValue.ToString(), out idEditorial))
                {
                    //proceso
                    LibroBE libroBE = new LibroBE(isbn, titulo, edicion, idGenero, idEditorial);
                    libroBL.Insert(libroBE);

                    //salida
                    Response.Redirect("~/LibroListar");
                }
               
            }
            
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LibroListar");
        }
    }
}
