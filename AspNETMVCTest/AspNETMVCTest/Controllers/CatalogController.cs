using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNETMVCTest.Models;
using Microsoft.Web.Mvc;

namespace AspNETMVCTest.Controllers
{
    public class CatalogController : Controller
    {
        //
        // GET: /Catalog/
        public ActionResult Index()
        {
            this.ViewBag.Message = this.TempData["Message"];

            var bookrepository = new BookRepository();
            return this.View(bookrepository.Books);
        }

        // GET: /Catalog/Create/
        public ActionResult Create()
        {
            return this.View(new BookDetails());
        }

        // POST: /Catalog/Create/
        [HttpPost]
        public ActionResult Create(BookDetails newBook)
        {
            var bookRepository = new BookRepository();
            bookRepository.Add(newBook);
            this.TempData["Message"] = "The book has been added to repository.";
            return this.RedirectToAction(c => c.Index());
        }
    }
}