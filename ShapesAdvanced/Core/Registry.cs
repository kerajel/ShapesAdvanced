using ShapesAdvanced.CalculusProvider;
using ShapesAdvanced.Interface;

namespace ShapesAdvanced.Core
{
    internal sealed class Registry
    {
        static Registry() { }

        private Registry() { }

        private static readonly Lazy<IShapeCalculusProviderFactory> _lazyShapeCalculusProviderFactory = new(() => new ShapeCalculusProviderFactory());

        private static readonly Lazy<ICircleCalculusProvider> _lazyCircleCalculusProvider = new(() => new CircleCalculusProvider());

        private static readonly Lazy<ITriangleCalculusProvider> _lazyTriangleCalculusProvider = new(() => new TriangleCalculusProvider());

        public static IShapeCalculusProviderFactory ShapeCalculusProviderFactory => _lazyShapeCalculusProviderFactory.Value;

        public static ICircleCalculusProvider CircleCalculusProvider => _lazyCircleCalculusProvider.Value;

        public static ITriangleCalculusProvider TriangleCalculusProvider => _lazyTriangleCalculusProvider.Value;
    }
}
