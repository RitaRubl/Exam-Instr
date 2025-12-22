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
        
        Console.Write($"{testName}: {a} × {b} = {result} ");
        Console.WriteLine(passed ? "✓" : $"✗ (ожидалось {expected})");
    }
    
    static void Main()
    {
        Console.WriteLine("Пять модульных тестов умножения:\n");
        
        // 1. Базовый тест
        Test("Тест 1: Положительные числа", 6, 7, 42);
        
        // 2. Отрицательные числа
        Test("Тест 2: Отрицательные числа", -4, -5, 20);
        
        // 3. Разные знаки
        Test("Тест 3: Разные знаки", 9, -3, -27);
        
        // 4. Умножение на ноль
        Test("Тест 4: Умножение на ноль", 0, 15, 0);
        
        // 5. Умножение на единицу
        Test("Тест 5: Умножение на единицу", 1, -25, -25);
        
        Console.ReadKey();
    }
}
