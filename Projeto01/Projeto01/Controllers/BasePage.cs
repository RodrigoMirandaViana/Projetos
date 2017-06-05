using Projeto01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto01.Controllers
{
    public class BasePage : System.Web.UI.Page
    {
        protected static BaseDoProjetoContainer contexto = new BaseDoProjetoContainer();
    }
}