using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class LivroController : Controller
    {
        public ActionResult BuscarAutor(string termo)
        {
            var autores = db.Livroes.Where(l => l.Autor.Contains(termo))
                                    .Select(l => l.Autor)
                                    .ToList();

            return PartialView("_BuscarAutorPartialView", autores);
        }
    }
}
