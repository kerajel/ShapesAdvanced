using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesAdvanced.Model;
using NSubstitute;
using FluentAssertions;
using ShapesAdvanced.Interface;

namespace UnitTests
{
    [TestClass]
    public class ShapeCalculusProviderFactoryTests
    {
        [TestMethod]
        public void GetCalculusProvider_WhenShapeIsUnknownAtCompileTime_ReturnsExpectedShapeCalculusProvider()
        {
            // Arrange
            var shape = new Circle(2.87) as IShape;
            var sut = UnitTestsRegistry.ShapeCalculusProviderFactory;

            // Act
            var result = sut.GetCalculusProvider(shape);

            // Assert
            result.GetType()
                .GetInterfaces()
                .Should()
                .Contain(typeof(ICircleCalculusProvider));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GetCalculusProvider_WhenShapeIsNull_ThrowsArgumentNullException()
        {
            // Arrange
            var nullShape = new object() as IShape;
            var sut = UnitTestsRegistry.ShapeCalculusProviderFactory;

            // Act
            _ = sut.GetCalculusProvider(nullShape!);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void GetCalculusProvider_WhenShapeIsNotImplemented_ThrowsNotImplementedException()
        {
            // Arrange
            var notImplementedShape = Substitute.For<IShape>();
            var sut = UnitTestsRegistry.ShapeCalculusProviderFactory;

            // Act
            _ = sut.GetCalculusProvider(notImplementedShape);

            // Assert
            Assert.Fail();
        }
    }
}