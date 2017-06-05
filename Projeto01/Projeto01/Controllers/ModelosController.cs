using Projeto01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto01.Controllers
{
    public class ModelosController : BasePage
    {

     

        public void Adicionar(Modelo modelo)
        {
            if(modelo != null)
            {
                contexto.Modelos.Add(modelo);
                contexto.SaveChanges();
            }
        }
        public List<Modelo> Listar()
        {
            return contexto.Modelos.ToList();
        }

        public Modelo BuscarModeloPorNome(Modelo modelo)
        {
            return contexto.Modelos.FirstOrDefault(m => m.Nome == modelo.Nome);
        }
        public void Excluir(Modelo modelo)
        {

            contexto.Entry(modelo).State =
                System.Data.Entity.EntityState.Deleted;

            contexto.SaveChanges();
        }
        public void Editar(Modelo modelo)
        {
            contexto.Entry(modelo).State =
                System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }

    }
}