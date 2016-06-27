using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BookStore.Controllers
{
    public class AccountController : Controller
    {
        private BookStoreContext db = new BookStoreContext();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string senha)
        {
            var cliente = db.Clientes.FirstOrDefault(c=>c.Email == email && c.Senha == senha);

            if(cliente == null)
            {
                return View();
            }
            else
            {
                db.Carrinhos.Add(new Carrinho 
                {
                    ClienteId = cliente.Id
                });

                db.SaveChanges();
                
                FormsAuthentication.SetAuthCookie(cliente.Nome, true);
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}