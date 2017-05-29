using Aula_24._05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula_24._05.Views
{
    public class BasePage : System.Web.UI.Page
    {
        protected BaseDadosContainer contexto = new BaseDadosContainer();
    }
}