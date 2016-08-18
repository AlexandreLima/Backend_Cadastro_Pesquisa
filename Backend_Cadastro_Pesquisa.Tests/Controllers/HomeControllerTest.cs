using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Backend_Cadastro_Pesquisa;
using Backend_Cadastro_Pesquisa.Controllers;

namespace Backend_Cadastro_Pesquisa.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
