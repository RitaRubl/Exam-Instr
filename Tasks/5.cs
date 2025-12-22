using System;

class Program
{
    static void Main()
    {
        string[] months = {"Январь","Февраль","Март","Апрель","Май","Июнь",
                          "Июль","Август","Сентябрь","Октябрь","Ноябрь","Декабрь"};

        int monthNumber;

        while (true)
        {
            Console.Write("Введите номер месяца (1-12): ");

            try
            {
                monthNumber = int.Parse(Console.ReadLine());
                break; // Выход из цикла, если ввод корректен
            }
            catch
            {
                Console.WriteLine("Некорректный ввод! Введите целое число.");
                Console.WriteLine();
            }
        }

        if (monthNumber >= 1 && monthNumber <= 12)
            Console.WriteLine($"Месяц: {months[monthNumber - 1]}");
        else
            Console.WriteLine("Число вне диапазона!");

        Console.ReadKey();
    }
}
