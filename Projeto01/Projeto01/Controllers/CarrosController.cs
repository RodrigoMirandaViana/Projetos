using Projeto01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto01.Controllers
{
    public class CarrosController
    {
       protected BaseDoProjetoContainer contexto = new BaseDoProjetoContainer();
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
            return contexto.Carros.Where(c => c.Popular == true).ToList();
        }

        public List<Carro> ListarNaoPopulares()
        {
            return contexto.Carros.Where(c => c.Popular == false).ToList();
        }

        public Carro BuscarCarroPorAno(int id)
        {
            return contexto.Carros.Find(id);
        }

        public void Excluir(Carro carro)
        {
            carro.Popular = false;

            contexto.Entry(carro).State = System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }
        public void Editar(Carro carro)
        {
            contexto.Entry(carro).State = System.Data.Entity.EntityState.Modified;

            contexto.SaveChanges();
        }
    }
}