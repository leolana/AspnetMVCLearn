using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class CarrinhoController : Controller
    {
        private BookStoreContext db = new BookStoreContext();

        private Carrinho CarrinhoCliente
        {
            get
            {
                var nome = System.Web.HttpContext.Current.User.Identity.Name;
                return db.Carrinhos.Where(c => c.Cliente.Nome == nome).OrderByDescending(c => c.Id).FirstOrDefault();
            }
        }

        public ActionResult Index()
        {
            return View(CarrinhoCliente.Itens);
        }

        [HttpPost]
        public ActionResult Adicionar(int id)
        {
            var carrinhoItem = CarrinhoCliente.Itens.FirstOrDefault(i => i.LivroId == id);

            if (carrinhoItem == null)
            {
                CarrinhoCliente.Itens.Add(new Item
                {
                    LivroId = id,
                    Quantidade = 1
                });
            }
            else
            {
                carrinhoItem.Quantidade++;
            }

            db.SaveChanges();
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        [HttpPost]
        public ActionResult Diminuir(int id)
        {
            var carrinhoItem = CarrinhoCliente.Itens.FirstOrDefault(i => i.LivroId == id);

            if (carrinhoItem.Quantidade > 0)
            {
                carrinhoItem.Quantidade--;
            }

            db.SaveChanges();
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}