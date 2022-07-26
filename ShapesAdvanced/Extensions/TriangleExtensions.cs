using ShapesAdvanced.Core;
using ShapesAdvanced.Model;

namespace ShapesAdvanced.Extensions
{
    public static class TriangleExtensions
    {
        public static bool IsEquilateral(this Triangle triangle)
        {
            return Registry.TriangleCalculusProvider.IsEquilateral(triangle);
        }
    }
}
