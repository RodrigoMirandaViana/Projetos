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
    public partial class CadastroCarro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Carro car = new Carro();

            car.Nome = txtNome.Text;
            car.Descricao = txtDescricao.Text;
          
            CarrosController ctrl = new CarrosController();

            ctrl.Adicionar(car);
         }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
        }

        protected void btnCadModelo_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastroModelo.aspx");
        }

      
    }
}