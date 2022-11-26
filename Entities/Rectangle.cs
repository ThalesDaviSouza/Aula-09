namespace Aula9.Entities {
    internal class Rectangle : ICalculableArea{
        public double Height { get; private set; }
        public double Width { get; private set; }

        public Rectangle(double height, double width) {
            Height = height;
            Width = width;
        }

        public double Area() {
            return Height * Width;
        }
    }
}
