using ShapesAdvanced.Interface;
using ShapesAdvanced.Model;

namespace ShapesAdvanced.CalculusProvider
{
    internal class TriangleCalculusProvider : ITriangleCalculusProvider, IShapeCalculusProvider
    {
        public double GetArea(IShape shape)
        {
            var triangle = (Triangle)shape;
            return GetArea(triangle);
        }

        public double GetArea(Triangle triangle)
        {
            var semiperimeter = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - triangle.SideA) * (semiperimeter - triangle.SideB) * (semiperimeter - triangle.SideC));
        }

        public bool IsEquilateral(Triangle triangle)
        {
            return triangle.SideA == triangle.SideB && triangle.SideB == triangle.SideC;
        }
    }
}
