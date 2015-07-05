using System.Web.Mvc;
using AspNETMVCTest.Models;
using Microsoft.Web.Mvc;

namespace AspNETMVCTest.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IBookRepository _bookRepository = new DbBookRepository();
//        private readonly Creator _creator = new ConcreteCreatorB();

        // GET: /Catalog/
        public ActionResult Index()
        {
            ViewBag.Message = TempData["Message"];
            return View(_bookRepository.Books);
        }

        // GET: /Catalog/Create/
        public ActionResult Create()
        {
            return View(new BookDetails());
        }

        // POST: /Catalog/Create/
        [HttpPost]
        public ActionResult Create(BookDetails newBook)
        {
            _bookRepository.Add(newBook);
            TempData["Message"] = "The book has been added to repository.";
            return this.RedirectToAction(c=>c.Index());
        }

        //Фабричный метод
//        abstract class Creator
//        {
//            public abstract IBookRepository FactoryMethod();
//        }
//
//        class ConcreteCreatorA : Creator
//        {
//            public override IBookRepository FactoryMethod() { return new BookRepository(); }
//        }
//
//        class ConcreteCreatorB : Creator
//        {
//            public override IBookRepository FactoryMethod() { return new DbBookRepository(); }
//        }
    }
}