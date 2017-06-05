using Projeto01.Models;
using Projeto01.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto01.Views.CarroMarca
{
    public partial class CadastroModelo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarrosController ctrl = new CarrosController();
            List<Carro> lista = ctrl.Listar();
            gdvCarros.DataSource = lista.OrderBy(c => c.Id);
            gdvCarros.DataBind();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Modelo mod = new Modelo();

            mod.Nome = txtNomeModelo.Text;
            mod.Ano = listAno.Text;
            mod.CarroId = Convert.ToInt32(txtIdCarro.Text);

            ModelosController ctrl = new ModelosController();

            ctrl.Adicionar(mod);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomeModelo.Text = "";
        }

        protected void btnLista_Click(object sender, EventArgs e)
        {
            Response.Redirect("Lista.aspx");
        }
    }
}