using Projeto01.Controllers;
using Projeto01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto01.Views.CarroMarca
{
    public partial class Lista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarrosController ctrl = new CarrosController();

            List<Carro> lista = ctrl.Listar();
            gdvCarros.DataSource = lista.OrderBy(c => c.Id);
            gdvCarros.DataBind();

        }
    }
}