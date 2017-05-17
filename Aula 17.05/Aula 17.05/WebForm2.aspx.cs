using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula_17._05
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int qtdcliquesViewState = Convert.ToInt32(ViewState["qtdcliques"]);
            int qtdcliquessession = Convert.ToInt32(Session["qtdcliquessession"]);
            lblQuantidadeCliques.Text = qtdcliquessession.ToString();
        }
    }
}