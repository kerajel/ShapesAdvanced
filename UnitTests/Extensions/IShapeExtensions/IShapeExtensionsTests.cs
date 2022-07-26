using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesAdvanced.Model;
using ShapesAdvanced.Extensions;

namespace UnitTests
{
    [TestClass]
    public class IShapeExtensionsTests
    {
        [TestMethod]
        public void GetArea_WhenCalculatingCircle_ReturnsExpectedResults()
        {
            // Arrange
            var circle = new Circle(4) as IShape;

            // Act
            var result = circle.GetArea();

            // Assert
            Assert.AreEqual(50.26548245743669, result);
        }

        [TestMethod]
        public void GetArea_WhenCalculatingTriangle_ReturnsExpectedResults()
        {
            // Arrange
            var triangle = new Triangle(2,2,3) as IShape;

            // Act
            var result = triangle.GetArea();

            // Assert
            Assert.AreEqual(1.984313483298443, result);
        }
    }
}