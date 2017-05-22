using Aula_22._05_EF_DF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula_22._05_EF_DF.Views.Produto
{
    public partial class ListaProdutos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            strConnLojaEntities contexto = new strConnLojaEntities();

            GdvProdutos.DataSource = contexto.Produto.ToList();
            GdvProdutos.DataBind();
        }
    }
}