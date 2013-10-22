using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabalhoClienteASPMVC.Areas.Cliente.Controllers
{
    public class ClienteController : Controller
    {
        private CLIENTEEntities db = new CLIENTEEntities();

        //
        // GET: /Cliente/Cliente/

        public ActionResult Index()
        {
            return View(db.CLIENTE.ToList());
        }

        //
        // GET: /Cliente/Cliente/Details/5

        public ActionResult Details(long id = 0)
        {
            CLIENTE cliente = db.CLIENTE.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        //
        // GET: /Cliente/Cliente/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cliente/Cliente/Create

        [HttpPost]
        public ActionResult Create(CLIENTE cliente)
        {
            if (ModelState.IsValid)
            {
                db.CLIENTE.Add(cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        //
        // GET: /Cliente/Cliente/Edit/5

        public ActionResult Edit(long id = 0)
        {
            CLIENTE cliente = db.CLIENTE.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        //
        // POST: /Cliente/Cliente/Edit/5

        [HttpPost]
        public ActionResult Edit(CLIENTE cliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        //
        // GET: /Cliente/Cliente/Delete/5

        public ActionResult Delete(long id = 0)
        {
            CLIENTE cliente = db.CLIENTE.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        //
        // POST: /Cliente/Cliente/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long id)
        {
            CLIENTE cliente = db.CLIENTE.Find(id);
            db.CLIENTE.Remove(cliente);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}