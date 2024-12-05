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
    public partial class LibroBorrar : Utilidades
    {
        private LibroBL libroBL = new LibroBL();

        protected void Page_Load(object sender, EventArgs e)
        {
            string isbn = Request.QueryString["paramISBN"];
            LibroBE libroBE = libroBL.FindByISBN(isbn);

            if (!IsPostBack)
            {
                txtISBN.Text = libroBE.ISBN;
                txtTitulo.Text = libroBE.Titulo;
            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text;
            libroBL.Delete(isbn);
            Response.Redirect("~/LibroListar");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/LibroListar");
        }
    }
}
