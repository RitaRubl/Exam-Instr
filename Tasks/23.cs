//Создать функцию, для определения количества цифр в строке. Написать пять модульных тестов для проверки работоспособности данной функции.
using System;

class Program
{
    // Функция подсчета цифр в строке
    // Параметр: str - строка для анализа
    // Возвращает: количество цифр в строке
    static int CountDigits(string str)
    {
        // Если строка null или пустая, возвращаем 0
        if (string.IsNullOrEmpty(str)) return 0;
        
        int count = 0; // Счетчик цифр
        
        // Перебираем все символы в строке
        foreach (char c in str)
        {
            // Char.IsDigit проверяет, является ли символ цифрой (0-9)
            if (Char.IsDigit(c)) count++;
        }
        
        return count; // Возвращаем результат
    }
    
    // Главный метод программы
    static void Main()
    {
        Console.WriteLine("Тесты функции CountDigits():\n");
        
        // Тест 1: Только цифры
        Console.WriteLine($"Тест 1: '12345' -> {CountDigits("12345")} (ожидается 5)");
        
        // Тест 2: Строка с буквами и цифрами
        Console.WriteLine($"Тест 2: 'A1B2C3' -> {CountDigits("A1B2C3")} (ожидается 3)");
        
        // Тест 3: Пустая строка
        Console.WriteLine($"Тест 3: '' -> {CountDigits("")} (ожидается 0)");
        
        // Тест 4: Только буквы (без цифр)
        Console.WriteLine($"Тест 4: 'Hello' -> {CountDigits("Hello")} (ожидается 0)");
        
        // Тест 5: Смешанная строка с пробелами и знаками
        Console.WriteLine($"Тест 5: 'Телефон: +7 (123) 456-7890' -> {CountDigits("Телефон: +7 (123) 456-7890")} (ожидается 10)");
        
        Console.ReadKey(); // Ожидание нажатия клавиши
    }
}
