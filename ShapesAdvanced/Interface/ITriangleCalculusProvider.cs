using ShapesAdvanced.Model;

namespace ShapesAdvanced.Interface
{
    internal interface ITriangleCalculusProvider
    {
        double GetArea(Triangle triangle);

        bool IsEquilateral(Triangle triangle);
    }
}
