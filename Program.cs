using Aula9.Entities;

public class Program {
    static void Main(string[] args) {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(15, 25);
        Square square = new Square(12);

        Console.WriteLine($"Circle: {circle.Area().ToString("F2")}");
        Console.WriteLine($"Rectangle: {rectangle.Area().ToString("F2")}");
        Console.WriteLine($"Square: {square.Area().ToString("F2")}");
    }
}