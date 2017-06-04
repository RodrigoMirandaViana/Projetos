using Projeto01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto01.Controllers
{
    public class ModelosController : BasePage
    {

        protected BaseDoProjetoContainer contexto = new BaseDoProjetoContainer();

        public void Adicionar(ModeloCar modelocar)
        {
            if(modelocar != null)
            {
                contexto.Modelos.Add(modelocar);
                contexto.SaveChanges();
            }
        }
        public List<ModeloCar> Listar()
        {
            return contexto.Modelos.ToList();
        }

        public ModeloCar BuscarModeloPorAno(int Ano)
        {
            return contexto.Modelos.Find(Ano);
        }

        
    }
}