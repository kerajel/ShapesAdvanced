using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesAdvanced.Model;

namespace UnitTests
{
    [TestClass]
    public class CircleCalculusProviderTests
    {
        [TestMethod]
        public void GetArea_WhenInvoked_ReturnsExpectedResults()
        {
            // Arrange
            var circle = new Circle(3.87);
            var sut = UnitTestsRegistry.CircleCalculusProvider;

            // Act
            var result = sut.GetArea(circle);

            // Assert
            Assert.AreEqual(47.051319013548976, result);
        }
    }
}