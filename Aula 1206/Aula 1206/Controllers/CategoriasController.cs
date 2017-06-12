﻿using System;
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
            List<string> categorias = new List<string>();

            categorias.Add("Carros");
            categorias.Add("Motos");
            categorias.Add("Barcos");
            categorias.Add("Aviões");
            categorias.Add("Caminhões");

            ViewBag.listaCategorias = categorias;

            return View();
        }
    }
}