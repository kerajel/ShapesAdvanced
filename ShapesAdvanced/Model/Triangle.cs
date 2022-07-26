namespace ShapesAdvanced.Model
{
    public class Triangle : IShape
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double SideA { get; private set; }

        public double SideB { get; private set; }

        public double SideC { get; private set; }
    }
}
