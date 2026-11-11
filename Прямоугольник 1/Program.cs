
class Rectangle
{

    public double width;
    public double height;
    public double GetArea() => width * height;
    public double GetPerimeter() => 2 * (width + height);

}

class Program
{
    static void Main()
    {
        Console.Write("Введите первую сторону:");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Введите вторую сторону:");
        double height = double.Parse(Console.ReadLine());
        Rectangle rect = new Rectangle { width = width, height = height };
        Console.WriteLine($"Площадь:{rect.GetArea()}\nПериметр:{rect.GetPerimeter()}");
    }
}