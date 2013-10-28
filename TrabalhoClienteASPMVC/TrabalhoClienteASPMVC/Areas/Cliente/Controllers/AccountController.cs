using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TrabalhoClienteASPMVC.Areas.Cliente.Models;

namespace TrabalhoClienteASPMVC.Areas.Cliente.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult LogOn()
        {
            return View();
        }

        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LogOn", "Account");
        }

        [HttpPost]
        public ActionResult LogOn(AccountCliente m, String returnUrl)
        {
            if (m.UserId == "admin" && m.Senha == "admin")
            {
                FormsAuthentication.SetAuthCookie(m.UserId, false);
                return Redirect(returnUrl);
            }
            return Redirect(returnUrl);
        }
    }
}
