using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesAdvanced.Model;

namespace UnitTests
{
    [TestClass]
    public class TriangleCalculusProviderTests
    {
        [TestMethod]
        public void GetArea_WhenInvoked_ReturnsExpectedResults()
        {
            // Arrange
            var triangle = new Triangle(2, 5, 6);
            var sut = UnitTestsRegistry.TriangleCalculusProvider;

            // Act
            var result = sut.GetArea(triangle);

            // Assert
            Assert.AreEqual(4.6837484987987983, result);
        }

        [TestMethod]
        public void IsEquilateral_WhenTriangleIsEquilateral_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle(3, 3, 3);
            var sut = UnitTestsRegistry.TriangleCalculusProvider;

            // Act
            var result = sut.IsEquilateral(triangle);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsEquilateral_WhenTriangleIsNotEquilateral_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle(3, 3.5, 3);
            var sut = UnitTestsRegistry.TriangleCalculusProvider;

            // Act
            var result = sut.IsEquilateral(triangle);

            // Assert
            Assert.IsFalse(result);
        }
    }
}