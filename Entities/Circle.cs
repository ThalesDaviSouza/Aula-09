namespace Aula9.Entities {
    internal class Circle : ICalculableArea{
        public double Radius { get; private set; }

        public Circle(double radius) {
            Radius = radius;
        }

        public double Area() {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
