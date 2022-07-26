using ShapesAdvanced.Core;
using ShapesAdvanced.Interface;
using ShapesAdvanced.Model;

namespace ShapesAdvanced.Extensions
{
    public static class IShapeExtensions
    {
        private static IShapeCalculusProvider GetShapeCalculusProvider(IShape shape) => Registry.ShapeCalculusProviderFactory.GetCalculusProvider(shape);

        public static double GetArea(this IShape shape)
        {
            var provider = GetShapeCalculusProvider(shape);
            return provider.GetArea(shape);
        }
    }
}
