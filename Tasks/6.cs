using System;

public class IllegalTriangleException : Exception
{
    public IllegalTriangleException(string message) : base(message) { }
}

//Конструктор проверяет два условия:
//Все стороны положительные
//Выполняется неравенство треугольника (a + b > c, a + c > b, b + c > a)
//При нарушении условий выбрасывается IllegalTriangleException
public class Triangle
{
    public double A { get; }
    public double B { get; }
    public double C { get; }

    public Triangle(double a, double b, double c)
    {
        // Проверка на положительность
        if (a <= 0 || b <= 0 || c <= 0)
            throw new IllegalTriangleException("Все стороны должны быть > 0");

        // Проверка неравенства треугольника
        if (!(a + b > c && a + c > b && b + c > a))
            throw new IllegalTriangleException("Не выполняется неравенство треугольника");

        A = a; B = b; C = c;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Создание треугольника");

        try
        {
            Console.Write("Сторона A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Сторона B: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Сторона C: ");
            double c = double.Parse(Console.ReadLine());

            Triangle triangle = new Triangle(a, b, c);
            Console.WriteLine($"\nТреугольник создан! Стороны: {a}, {b}, {c}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка: введите числа!");
        }
        catch (IllegalTriangleException ex)
        {
            Console.WriteLine($"Ошибка треугольника: {ex.Message}");
        }
        catch (Exception)
        {
            Console.WriteLine("Неизвестная ошибка");
        }

        Console.ReadKey();
    }
}
