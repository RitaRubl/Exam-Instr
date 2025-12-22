//Реализовать поиск наибольшего элемента в массиве с помощью метода compareTo() интерфейса Comparable. Определите класс Circle с полем radius и найдите наибольший элемент в массиве экземпляров этого класса.
using System;

public class Circle : IComparable<Circle>
{
    public double Radius { get; }
    
    public Circle(double radius) => Radius = radius;
    
    // Метод CompareTo обязателен для интерфейса IComparable<T>
    // Он определяет, как сравниваются два объекта Circle
    public int CompareTo(Circle other)
    {
        // Обработка сравнения с null
        if (other == null)
            return 1; // Любой объект считается больше null
            
        // Сравниваем радиусы с помощью CompareTo для double
        // double.CompareTo возвращает:
        //   < 0 - если текущее число меньше другого
        //   = 0 - если числа равны
        //   > 0 - если текущее число больше другого
        return this.Radius.CompareTo(other.Radius);
    }
    
    public override string ToString() => $"Радиус: {Radius}";
}

class Program
{
    static void Main()
    {
        Circle[] circles = {
            new Circle(2.0),
            new Circle(5.0),
            new Circle(3.0)
        };
        
        Console.WriteLine("Поиск наибольшего круга:");
        foreach (var circle in circles)
            Console.WriteLine($"  {circle}");
        
        Circle largest = FindLargest(circles);
        Console.WriteLine($"\nНаибольший круг: {largest}");
    }
    
    static Circle FindLargest(Circle[] circles)
    {
        Circle largest = circles[0];
        
        for (int i = 1; i < circles.Length; i++)
        {
            // Ключевой момент: используем CompareTo для определения,
            // какой круг больше
            if (circles[i].CompareTo(largest) > 0)
            {
                // Если circles[i] больше largest (CompareTo вернул > 0)
                largest = circles[i];
            }
        }
        
        return largest;
    }
}
