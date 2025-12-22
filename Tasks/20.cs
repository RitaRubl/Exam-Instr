// 20. Создать функцию, для умножения двух чисел. Написать пятьмодульных тестов для проверки работоспособности данной функции.
using System;

class Program
{
    // Функция умножения
    public static int Multiply(int a, int b) => a * b;
    
    // Функция для тестирования
    static void Test(string testName, int a, int b, int expected)
    {
        int result = Multiply(a, b);
        bool passed = result == expected;
        
        // Используем ASCII символы вместо Unicode
        Console.Write($"{testName}: {a} * {b} = {result} ");
        
        if (passed)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[OK] ПРОЙДЕН");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[FAIL] ПРОВАЛ (ожидалось {expected})");
        }
        Console.ResetColor();
    }
    
    static void Main()
    {
        Console.WriteLine("Пять модульных тестов умножения:");
        Console.WriteLine("================================\n");
        
        Test("Тест 1: Положительные числа", 6, 7, 42);
        Test("Тест 2: Отрицательные числа", -4, -5, 20);
        Test("Тест 3: Разные знаки", 9, -3, -27);
        Test("Тест 4: Умножение на ноль", 0, 15, 0);
        Test("Тест 5: Умножение на единицу", 1, -25, -25);
        
        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
