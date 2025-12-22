//Создать функцию нахождения максимального из трех чисел. Написать пять модульных тестов для проверки работоспособности данной функции.
using System;

class Program
{
    // Функция нахождения максимального из трех чисел
    // Используем второй вариант: if-else
    public static int MaxOfThree(int a, int b, int c)
    {
        // Проверяем, является ли 'a' максимальным
        if (a >= b && a >= c)
        {
            // Если 'a' больше или равно 'b' и 'c', возвращаем 'a'
            return a;
        }
        
        // Проверяем, является ли 'b' максимальным
        if (b >= a && b >= c)
        {
            // Если 'b' больше или равно 'a' и 'c', возвращаем 'b'
            return b;
        }
        
        // Если ни 'a', ни 'b' не максимальные, то 'c' - максимальное
        return c;
    }
    
    // Функция для выполнения теста
    static void RunTest(string testName, int a, int b, int c, int expected)
    {
        // Вызываем тестируемую функцию
        int result = MaxOfThree(a, b, c);
        
        // Выводим информацию о тесте
        Console.Write($"{testName}: Max({a}, {b}, {c}) = {result} ");
        
        // Проверяем результат
        if (result == expected)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[OK]");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[FAIL] ожидалось {expected}");
        }
        Console.ResetColor();
    }
    
    static void Main()
    {
        Console.WriteLine("Пять тестов функции MaxOfThree:");
        Console.WriteLine("===============================\n");
        
        // Тест 1: Первое число максимальное
        RunTest("Тест 1: a максимальное", 10, 5, 3, 10);
        
        // Тест 2: Второе число максимальное
        RunTest("Тест 2: b максимальное", 2, 8, 4, 8);
        
        // Тест 3: Третье число максимальное
        RunTest("Тест 3: c максимальное", 1, 3, 7, 7);
        
        // Тест 4: Все числа равны
        RunTest("Тест 4: все равны", 5, 5, 5, 5);
        
        // Тест 5: Отрицательные числа
        RunTest("Тест 5: с отрицательными", -5, -1, -3, -1);
        
        Console.WriteLine("\nТестирование завершено!");
        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
