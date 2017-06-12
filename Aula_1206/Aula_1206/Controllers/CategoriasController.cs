using Aula_1206.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula_1206.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            List<Categoria> categorias = new List<Categoria>();

            categorias.Add(new Categoria() { Nome = "Carros", Descricao = "Super Carros"});
            categorias.Add(new Categoria() { Nome = "Motos", Descricao = "Super Motos que correm" });
            categorias.Add(new Categoria() { Nome = "Barcos", Descricao = "Titanic" });
            categorias.Add(new Categoria() { Nome = "Aviões", Descricao = "Aviões que voam" });
            categorias.Add(new Categoria() { Nome = "Caminhões"});

            //categorias.Add("Carros");
            //categorias.Add("Motos");
           // categorias.Add("Barcos");
           // categorias.Add("Aviões");
           // categorias.Add("Caminhões");

            ViewBag.listaCategorias = categorias;

            return View(categorias);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            return View(categoria);
        }
    }
}