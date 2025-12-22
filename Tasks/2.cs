using System;

class Program
{
    static void Main()
    {
        int num1, num2;

        Console.WriteLine("Программа сложения двух целых чисел");
        Console.WriteLine("-----------------------------------");

        // Запрос первого числа с проверкой
        num1 = GetNumber("Введите первое число: ");

        // Запрос второго числа с проверкой
        num2 = GetNumber("Введите второе число: ");

        // Вывод результата
        Console.WriteLine($"\nРезультат: {num1} + {num2} = {num1 + num2}");
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    // Метод для получения числа с обработкой ошибок
    static int GetNumber(string prompt)
    {
        int number;

        while (true)
        {
            Console.Write(prompt);

            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                return number; // Успешный ввод, выходим из цикла
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Введите целое число.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка! Число слишком большое или слишком маленькое.");
            }

            Console.WriteLine(); // Пустая строка для читаемости
        }
    }
}
