using System;

class Program
{
    static void Main(string[] args)
    {
        Square sqr = new Square(4.1, "Blue");
        Console.WriteLine($"The color of the square is {sqr.GetColor()}");
        Console.WriteLine($"The area of the square is {sqr.GetArea()}");
        Console.WriteLine("");

        Rectangle rect = new Rectangle(8.1, 4.1, "Blue");
        Console.WriteLine($"The color of this rectangle is {rect.GetColor()}");
        Console.WriteLine($"The area of this rectangle is {rect.GetArea()}");
        Console.WriteLine("");

        Circle crcle= new Circle(5, "Green");
        Console.WriteLine($"The color of this circle is {rect.GetColor()}");
        Console.WriteLine($"The area of this circle is {rect.GetArea()}");

        List<Shape> shp = new List<Shape>();
        shp.Add(new Square(4.1, "Blue"));
        shp.Add(new Rectangle(8.1, 4.1, "Blue"));
        shp.Add(new Circle(5, "Green"));

        foreach (Shape shrp in shp)
        {
             string clr =shrp.GetColor();
             double are =shrp.GetArea();

            Console.WriteLine(clr);
            Console.WriteLine(are);
        }
    }
}