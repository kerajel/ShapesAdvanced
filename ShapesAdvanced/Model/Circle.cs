namespace ShapesAdvanced.Model
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; private set; }
    }
}
