using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzKataVp;
using System.Collections.Generic;

namespace FizzBuzzKataVpTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ItReturnsCorrectText()
        {
            var Expected = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz";

            // Arrange
            var range = 20;
            var specs = new List<IFizzBuzzSpecification> { new Fizz(), new Buzz() };

            // Act
            var result = FizzBuzzEngine.Launch(specs, range);

            // Assert
            Assert.AreEqual(result, Expected);
        }
    }
}
