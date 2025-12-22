//Создать функцию, для определения количества букв в строке. Написать пять модульных тестов для проверки работоспособности данной функции
using System;

class Program
{
    // Функция подсчета букв в строке
    // Параметр: str - строка для анализа
    // Возвращает: количество букв в строке
    static int CountLetters(string str)
    {
        // Если строка null или пустая, возвращаем 0
        if (string.IsNullOrEmpty(str)) return 0;
        
        int count = 0; // Счетчик букв
        
        // Перебираем все символы в строке
        foreach (char c in str)
        {
            // Char.IsLetter проверяет, является ли символ буквой
            // (русской, английской и др.)
            if (Char.IsLetter(c)) count++;
        }
        
        return count; // Возвращаем результат
    }
    
    // Главный метод программы
    static void Main()
    {
        Console.WriteLine("Тесты функции CountLetters():\n");
        
        // Тест 1: Английские буквы
        Console.WriteLine($"Тест 1: 'Hello' -> {CountLetters("Hello")} (ожидается 5)");
        
        // Тест 2: Русские буквы с пунктуацией
        Console.WriteLine($"Тест 2: 'Привет, мир!' -> {CountLetters("Привет, мир!")} (ожидается 10)");
        
        // Тест 3: Буквы с цифрами
        Console.WriteLine($"Тест 3: 'A1B2C3' -> {CountLetters("A1B2C3")} (ожидается 3)");
        
        // Тест 4: Пустая строка
        Console.WriteLine($"Тест 4: '' -> {CountLetters("")} (ожидается 0)");
        
        // Тест 5: Смешанные алфавиты
        Console.WriteLine($"Тест 5: 'Hello Мир' -> {CountLetters("Hello Мир")} (ожидается 8)");
        
        Console.ReadKey(); // Ожидание нажатия клавиши
    }
}
