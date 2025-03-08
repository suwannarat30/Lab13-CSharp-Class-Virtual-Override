public abstract class Shape
{
    public abstract void Draw();
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

public class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

public class Program
{
    public static void Main()
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle());
        shapes.Add(new Rectangle());
        shapes.Add(new Circle());

        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
    }
}