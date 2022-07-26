using ShapesAdvanced.Model;

namespace ShapesAdvanced.Interface
{
    internal interface IShapeCalculusProviderFactory
    {
        IShapeCalculusProvider GetCalculusProvider(IShape shape);
    }
}
