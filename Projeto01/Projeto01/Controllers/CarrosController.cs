using Projeto01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto01.Controllers
{
    public class CarrosController : BasePage
    {
       
        public void Adicionar(Carro carro)
        {
            if (carro != null)
            {
                contexto.Carros.Add(carro);
                contexto.SaveChanges();
            }
        }

        public List<Carro> Listar()
        {
            return contexto.Carros.ToList();
        }
        public Carro BuscarPorID(Carro carro)
        {
            int id = carro.Id;
            return contexto.Carros.Find(id);
        }
        public void Excluir(Carro carro)
        {
          
            contexto.Entry(carro).State =
                System.Data.Entity.EntityState.Deleted;

            contexto.SaveChanges();
        }
    }
}