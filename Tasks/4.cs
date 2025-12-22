using System;

class Program
{
    static void Main()
    {
        // Массив названий месяцев
        string[] months = {
            "январь", "февраль", "март", "апрель",
            "май", "июнь", "июль", "август",
            "сентябрь", "октябрь", "ноябрь", "декабрь"
        };

        // Массив количества дней в месяцах
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30,
                              31, 31, 30, 31, 30, 31 };

        Console.WriteLine("Программа определения месяца и количества дней");
        Console.WriteLine("-----------------------------------------------");

        try
        {
            // Запрос номера месяца у пользователя
            Console.Write("Введите номер месяца (от 1 до 12): ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            // Проверка диапазона с выбросом исключения
            if (monthNumber < 1 || monthNumber > 12)
            {
                throw new ArgumentOutOfRangeException();
            }

            // Получение индекса для массивов (минус 1, т.к. массивы с 0)
            int index = monthNumber - 1;

            // Вывод результата
            Console.WriteLine($"\nМесяц: {months[index]}");
            Console.WriteLine($"Количество дней: {daysInMonth[index]}");
        }
        catch (FormatException)
        {
            // Обработка ошибки "не число"
            Console.WriteLine("Ошибка: Введено не число!");
        }
        catch (ArgumentOutOfRangeException)
        {
            // Обработка ошибки "число вне диапазона"
            Console.WriteLine("Ошибка: Недопустимое число! Введите число от 1 до 12.");
        }
        catch (Exception)
        {
            // Обработка других ошибок
            Console.WriteLine("Произошла непредвиденная ошибка.");
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
