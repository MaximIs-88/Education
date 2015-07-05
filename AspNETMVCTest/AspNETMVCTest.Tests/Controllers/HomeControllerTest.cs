using System.Web.Mvc;
using AspNETMVCTest.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNETMVCTest.UnitTests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {

        private readonly HomeController _homeController = new HomeController();

        [TestMethod]
        public void Index()
        {
            var result = _homeController.Index();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            var result = _homeController.About() as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            var result = _homeController.Contact() as ViewResult;
            Assert.IsNotNull(result);
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }
    }
}
