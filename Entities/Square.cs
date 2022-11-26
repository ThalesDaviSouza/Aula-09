namespace Aula9.Entities {
    internal class Square : ICalculableArea {
        public double Side { get; private set; }

        public Square(double side) {
            this.Side = side;
        }

        public double Area() {
            return Math.Pow(Side, 2);
        }
    }
}
