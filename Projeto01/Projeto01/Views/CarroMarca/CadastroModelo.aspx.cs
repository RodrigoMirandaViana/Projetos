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

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            ModeloCar modelo = new ModeloCar();

            modelo.Nome = txtNomeModelo.Text;
            modelo.Ano = listAno.Text;

            ModelosController ctrl = new ModelosController();

            ctrl.Adicionar(modelo);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomeModelo.Text = "";
        }
    }
}