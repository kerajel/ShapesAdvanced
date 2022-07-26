using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesAdvanced.Model;
using ShapesAdvanced.Extensions;

namespace UnitTests
{
    [TestClass]
    public class TriangleExtensionsTests
    {
        [TestMethod]
        public void IsEquilateral_WhenTriangleIsEquilateral_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle(7, 7, 7);

            // Act
            var result = triangle.IsEquilateral();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsEquilateral_WhenTriangleIsNotEquilateral_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle(7, 5, 7);

            // Act
            var result = triangle.IsEquilateral();

            // Assert
            Assert.IsFalse(result);
        }
    }
}