using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula10._05
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            lblDataAgora.Text = DateTime.Now.ToString();
        }

        protected void btn_ok_Click(object sender, EventArgs e)
        {
            DateTime dataCalendario = Calendar1.SelectedDate;
           lblDataAgora.Text = dataCalendario.ToString();
        }
    }
}