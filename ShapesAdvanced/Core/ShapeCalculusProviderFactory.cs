using ShapesAdvanced.Interface;
using ShapesAdvanced.Model;

namespace ShapesAdvanced.Core
{
    internal class ShapeCalculusProviderFactory : IShapeCalculusProviderFactory
    {      
        public IShapeCalculusProvider GetCalculusProvider(IShape shape)
        {
            if (shape is null)
                throw new ArgumentNullException(nameof(shape));

            object provider = shape switch
            {
                Circle => Registry.CircleCalculusProvider,
                Triangle => Registry.TriangleCalculusProvider,
                _ => throw new NotImplementedException($"Calculus for '{shape.GetType()}' is not supported")
            };

            return (IShapeCalculusProvider)provider;
        }
    }
}
