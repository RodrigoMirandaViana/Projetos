using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula_17._05
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        double valor1;
        double valor2;
        double resultado;
        string operacao
        {
            get
            {
                return Convert.ToString(ViewState["op"]);
            }
            set
            {
                ViewState["op"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                valor1 = 0;
                valor2 = 0;
        }

        protected void btnSoma_Click(object sender, EventArgs e)
        {
            //operacao = "+";
            valor1 = int.Parse(txtValor1.Text);
            valor2 = int.Parse(txtValor2.Text);
            resultado = valor1 + valor2;
            txtresult.Text = resultado.ToString();
        }

        protected void btnIgual_Click(object sender, EventArgs e)
        {
            lblresult.Text = valor1.ToString();
            Session.Add("opSession", operacao);
            Response.Redirect("~/WebForm4.aspx");
        }
    }
}