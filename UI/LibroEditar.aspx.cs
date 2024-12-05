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
    public partial class LibroEditar : System.Web.UI.Page
    {
        private LibroBL libroBL = new LibroBL();
        private GeneroBL generoBL = new GeneroBL();
        private EditorialBL editorialBL = new EditorialBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            string isbn = Request.QueryString["paramISBN"];
            LibroBE libroBE = libroBL.FindByISBN(isbn);

            if (!IsPostBack)
            {
                txtISBN.Text = libroBE.ISBN;
                txtTitulo.Text = libroBE.Titulo;
                txtEdicion.Text = libroBE.Edicion.ToString();
                ddlGenero.DataSource = generoBL.FindAll();
                ddlGenero.DataValueField = "ID";
                ddlGenero.DataTextField = "Descripcion";
                ddlGenero.DataBind();
                ddlGenero.SelectedValue = libroBE.IdGenero.ToString();

                ddlEditorial.DataSource = editorialBL.FindAll();
                ddlEditorial.DataValueField = "ID";
                ddlEditorial.DataTextField = "Descripcion";
                ddlEditorial.DataBind();
                ddlEditorial.SelectedValue = libroBE.IdEditorial.ToString();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //entrada
            string isbn = txtISBN.Text;
            string titulo = txtTitulo.Text;
            int edicion = Convert.ToInt32(txtEdicion.Text);
            int idGenero = Convert.ToInt32(ddlGenero.SelectedValue.ToString()); 
            int idEditorial = Convert.ToInt32(ddlEditorial.SelectedValue.ToString()); ;


            //proceso
            LibroBE libroBE = new LibroBE(isbn, titulo, edicion, idGenero, idEditorial);
                libroBL.Update(libroBE);

                //salida
                Response.Redirect("~/LibroListar");
            
        
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LibroListar");
        }
    }
}
