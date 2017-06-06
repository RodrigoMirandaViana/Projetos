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
        CarrosController ctrl = new CarrosController();
        ModelosController modelo = new ModelosController();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            List<Carro> lista = ctrl.Listar();
            gdvCarros.DataSource = lista.OrderBy(c => c.Id);
            gdvCarros.DataBind();

            

            List<Modelo> lista2 = modelo.Listar();
            gdvModelos.DataSource = lista2.OrderBy(c => c.Id);
            gdvModelos.DataBind();

        }
        protected void AtualizarLista()
        {
          

            List<Carro> lista = ctrl.Listar();
            gdvCarros.DataSource = lista.OrderBy(c => c.Id);
            gdvCarros.DataBind();


            List<Modelo> lista2 = modelo.Listar();
            gdvModelos.DataSource = lista2.OrderBy(c => c.Id);
            gdvModelos.DataBind();
        }
        protected void btnExcluirmod_Click(object sender, EventArgs e)
        {
            Modelo mod = new Modelo();
            mod.Nome = txtNome.Text;
            mod = modelo.BuscarModeloPorNome(mod);
            if(mod != null)
            {
                modelo.Excluir(mod);
                AtualizarLista();
            }
        }

        protected void btnExcluircar_Click1(object sender, EventArgs e)
        {
            Carro car = new Carro();
            car.Id = int.Parse(txtId.Text);
            car = ctrl.BuscarPorID(car);
            if(car != null)
            {
                ctrl.Excluir(car);
                AtualizarLista();
            }
        }

        protected void btnEditarmod_Click(object sender, EventArgs e)
        {

            Modelo mod = new Modelo();

            mod.Nome = txtNome.Text;
            mod = modelo.BuscarModeloPorNome(mod);
            if (mod != null)
            {
                mod.Nome = txtNomeEditar1.Text;
                mod.Ano = listAno.Text;
                modelo.Editar(mod);
                AtualizarLista();
            }
        }

        protected void btnEditarcar_Click(object sender, EventArgs e)
        {
            Carro car = new Carro();
  
            car.Id = int.Parse(txtId.Text);
            car = ctrl.BuscarPorID(car);
            if(car != null)
            {
                car.Nome = txtNomeEditar.Text;
                car.Descricao = txtDescricaoEditar.Text;
                ctrl.Editar(car);
                AtualizarLista();
            }
        }
    }
 }