//Обработка исключительных ситуаций. Создать класс с двумя целочисленными полями: числителем и знаменателем. Конструктор этого класса создает дроби при заданных значениях, но выбрасывает исключение при нулевом знаменателе. Для этого дополнительно создать класс проверяемого исключения, объекты которого выбрасываются, если знаменатель объекта равен 0, а также написать тестовый класс, который проверяет эти классы.

using System;

public class ZeroDenominatorException : Exception
{
    public ZeroDenominatorException() : base("Знаменатель не может быть нулем!") { }
}

public class Fraction
{
    public int Numerator { get; }
    public int Denominator { get; }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ZeroDenominatorException();

        Numerator = numerator;
        Denominator = denominator;
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}

class Program
{
    static void Main()
    {
        // Тестирование валидной дроби
        try
        {
            Fraction f1 = new Fraction(3, 4);
            Console.WriteLine($"Дробь создана: {f1}");
        }
        catch (ZeroDenominatorException e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }

        // Тестирование дроби с нулевым знаменателем
        try
        {
            Fraction f2 = new Fraction(5, 0);
            Console.WriteLine($"Дробь создана: {f2}");
        }
        catch (ZeroDenominatorException e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }

        Console.ReadKey();
    }
}
