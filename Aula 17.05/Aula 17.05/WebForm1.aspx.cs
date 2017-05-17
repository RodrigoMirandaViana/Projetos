using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula_17._05
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public int QuantidadeCliques {
            get
            {
                return Convert.ToInt32(ViewState["qtdcliques"]);
            }
            set
            {
                ViewState["qtdcliques"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            QuantidadeCliques = 0;
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            //QuantidadeCliques = Convert.ToInt32(ViewState["qtdcliques"]);
            QuantidadeCliques++;
            lblQuantidadeCliques.Text = QuantidadeCliques.ToString();
           // ViewState["qtdcliques"] = QuantidadeCliques;
        }

        protected void btnEnviarCliques_Click(object sender, EventArgs e)
        {   

            Session.Add("qtdcliquessession", QuantidadeCliques);
            Response.Redirect("~/WebForm2.aspx");
        }
    }
}