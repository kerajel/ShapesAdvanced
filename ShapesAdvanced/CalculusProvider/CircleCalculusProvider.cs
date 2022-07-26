using ShapesAdvanced.Interface;
using ShapesAdvanced.Model;

namespace ShapesAdvanced.CalculusProvider
{
    internal class CircleCalculusProvider : ICircleCalculusProvider, IShapeCalculusProvider
    {
        public double GetArea(IShape shape)
        {
            var circle = (Circle)shape;
            return GetArea(circle);
        }

        public double GetArea(Circle circle)
        {
            return Math.PI * Math.Pow(circle.Radius, 2);
        }
    }
}
