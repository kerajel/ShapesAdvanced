using ShapesAdvanced.Model;

namespace ShapesAdvanced.Interface
{
    internal interface IShapeCalculusProvider
    {
        double GetArea(IShape shape);
    }
}
