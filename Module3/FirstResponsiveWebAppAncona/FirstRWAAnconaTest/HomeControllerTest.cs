using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Xml.Linq;

namespace FirstRWAAnconaTest
{
    [TestClass]
    public class HomeControllerTest
    {
        // test index method get request
        [TestMethod]
        public void TestIndexGet()
        {
            HomeController ctrl = new HomeController();
            var ret = ctrl.Index();
            Assert.IsNotNull(ret);
            Assert.IsInstanceOfType(ret, typeof(ViewResult));
            Assert.AreEqual("Please enter your name and birth year.", ctrl.ViewBag.CalculatedAgeMessage);
        }

        // test index method post request
        [TestMethod]
        public void TestIndexPost()
        {
            HomeController ctrl = new HomeController();
            PersonModel model = new PersonModel();
            string modelName = "Tim";
            int modelBirthYear = 1994;
            int currentYear = 2023;
            int expectedAgeThisYear = currentYear - modelBirthYear;
            model.Name = modelName;
            model.BirthYear = modelBirthYear;
            ctrl.Index(model);
            Assert.AreEqual($"Hello {modelName}! You are {expectedAgeThisYear} this year.", ctrl.ViewBag.CalculatedAgeMessage);
        }

        // test index method post request with invalid model state
        [TestMethod]
        public void TestIndexPostInvalidModel()
        {
            HomeController ctrl = new HomeController();
            PersonModel model = new PersonModel();
            ctrl.ModelState.AddModelError("", "");
            ctrl.Index(model);
            Assert.AreEqual("Please enter your name and birth year.", ctrl.ViewBag.CalculatedAgeMessage);
        }
    }
}