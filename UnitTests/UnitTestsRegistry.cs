using ShapesAdvanced.CalculusProvider;
using ShapesAdvanced.Core;
using ShapesAdvanced.Interface;

namespace UnitTests
{
    internal sealed class UnitTestsRegistry
    {
        static UnitTestsRegistry() { }

        private UnitTestsRegistry() { }

        private static readonly Lazy<IShapeCalculusProviderFactory> _lazyShapeCalculusProviderFactory = new(() => new ShapeCalculusProviderFactory());

        private static readonly Lazy<ICircleCalculusProvider> _lazyCircleCalculusProvider = new(() => new CircleCalculusProvider());

        private static readonly Lazy<ITriangleCalculusProvider> _lazyTriangleCalculusProvider = new(() => new TriangleCalculusProvider());

        public static IShapeCalculusProviderFactory ShapeCalculusProviderFactory => _lazyShapeCalculusProviderFactory.Value;

        public static ICircleCalculusProvider CircleCalculusProvider => _lazyCircleCalculusProvider.Value;

        public static ITriangleCalculusProvider TriangleCalculusProvider => _lazyTriangleCalculusProvider.Value;
    }
}
