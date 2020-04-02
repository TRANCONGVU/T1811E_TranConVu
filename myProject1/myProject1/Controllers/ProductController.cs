using myProject1.Context;
using myProject1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace myProject1.Controllers
{
    public class ProductController : Controller
    {
        private ProductContext db = new ProductContext();
        // GET: Product
        public ActionResult Index()
        {
            return View(db.Proucts.ToList());
        }

        // GET: Product/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            if (id == null)
            
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                Product product = db.Proucts.Find(id);
            if (product == null)
                return HttpNotFound();
            return View(product);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Proucts.Add(product);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(product);
               
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Product product = db.Proucts.Find(id);
            if(product == null)
                return HttpNotFound();
            return View(product);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    db.Entry(product).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(product);
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == null)
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            Product product = db.Proucts.Find(id);
            if (product == null)
                return HttpNotFound();
            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id)
        {
            try
            {
                Product product = new Product();
                if (ModelState.IsValid)
                {
                    if (id == null)
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    product = db.Proucts.Find(id);
                    if (product == null)
                        return HttpNotFound();
                    db.Proucts.Remove(product);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return View(product);
            }
            catch
            {
                return View();
            }
        }

        private ActionResult HttpStatusCodeResult(HttpStatusCode badRequest)
        {
            throw new NotImplementedException();
        }

        public static implicit operator ProductController(ProductContext v)
        {
            throw new NotImplementedException();
        }
    }
}
