using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Xml.Linq;

namespace FirstRWAAnconaTest
{
    [TestClass]
    public class PersonModelTest
    {
        // test to see if a PersonModel object can be created
        [TestMethod]
        public void TestCreatePerson()
        {
            PersonModel model = new();
            Assert.IsNotNull(model);
            Assert.IsInstanceOfType(model, typeof(PersonModel));
        }

        // test AgeThisYear method
        [TestMethod]
        public void TestAgeThisYear()
        {
            PersonModel model = new()
            {
                BirthYear = 1994,
                Name = "Tim"
            };
            int expectedAgeThisYear = 29;
            int? actualAgeThisYear = model.AgeThisYear();
            Assert.AreEqual(expectedAgeThisYear, actualAgeThisYear);
        }

        // test that the model state is invalid when both properties are empty
        [TestMethod]
        public void TestInvalidModelStateNameAndBirthYearEmpty()
        {
            PersonModel model = new();
            ValidationContext context = new(model);
            List<ValidationResult> results = new();
            bool isModelStateValid = Validator.TryValidateObject(model, context, results, true);
            Assert.IsFalse(isModelStateValid);
        }

        // test that the model state is invalid when name property is empty
        [TestMethod]
        public void TestInvalidModelStateNameEmpty()
        {
            PersonModel model = new()
            {
                BirthYear = 1994
            };
            ValidationContext context = new(model);
            List<ValidationResult> results = new();
            bool isModelStateValid = Validator.TryValidateObject(model, context, results, true);
            Assert.IsFalse(isModelStateValid);
        }

        // test that the model state is invalid when birth year property is empty
        [TestMethod]
        public void TestInvalidModelStateBirthYearEmpty()
        {
            PersonModel model = new()
            {
                Name = "Tim"
            };
            ValidationContext context = new(model);
            List<ValidationResult> results = new();
            bool isModelStateValid = Validator.TryValidateObject(model, context, results, true);
            Assert.IsFalse(isModelStateValid);
        }

        // test that the model state is invalid when the birth year is below range
        [TestMethod]
        public void TestInvalidModelStateBirthYearBelowRange()
        {
            PersonModel model = new()
            {
                BirthYear = 1899,
                Name = "Tim"
            };
            ValidationContext context = new(model);
            List<ValidationResult> results = new();
            bool isModelStateValid = Validator.TryValidateObject(model, context, results, true);
            Assert.IsFalse(isModelStateValid);
        }

        // test that the model state is invalid when the birth year is above range
        [TestMethod]
        public void TestInvalidModelStateBirthYearAboveRange()
        {
            PersonModel model = new()
            {
                BirthYear = 2024,
                Name = "Tim"
            };
            ValidationContext context = new(model);
            List<ValidationResult> results = new();
            bool isModelStateValid = Validator.TryValidateObject(model, context, results, true);
            Assert.IsFalse(isModelStateValid);
        }

        // test that the model state is valid when both properties are set and within range
        [TestMethod]
        public void TestValidModelState()
        {
            PersonModel model = new()
            {
                BirthYear = 1994,
                Name = "Tim"
            };
            ValidationContext context = new(model);
            List<ValidationResult> results = new();
            bool isModelStateValid = Validator.TryValidateObject(model, context, results, true);
            Assert.IsTrue(isModelStateValid);
        }
    }
}