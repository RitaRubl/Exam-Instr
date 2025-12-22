//Реализовать алгоритм линейного поиска элемента в массиве. При нахождении элемента необходимо вернуть его позицию в массиве. Если элемент не найден, то вернуть -1.
using System;

class Program
{
    /// <summary>
    /// Линейный поиск - простейший алгоритм поиска
    /// Сложность: O(n) - в худшем случае проверяем все n элементов
    /// </summary>
    public static int LinearSearch(int[] array, int target)
    {
        // Шаг 1: Начинаем с первого элемента (индекс 0)
        // Шаг 2: Сравниваем текущий элемент с искомым
        // Шаг 3: Если совпадает - возвращаем индекс
        // Шаг 4: Если нет - переходим к следующему элементу
        // Шаг 5: Повторяем шаги 2-4 до конца массива
        // Шаг 6: Если дошли до конца и не нашли - возвращаем -1
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
                return i; // Элемент найден
        }
        
        return -1; // Элемент не найден
    }
    
    static void Main()
    {
        // Пример массива для поиска
        int[] data = { 3, 7, 1, 9, 4, 6, 2, 8, 5 };
        
        // Тест 1: Элемент есть в массиве
        int search1 = 9;
        int result1 = LinearSearch(data, search1);
        Console.WriteLine($"Поиск {search1}: результат = {result1} (ожидается 3)");
        
        // Тест 2: Элемента нет в массиве
        int search2 = 10;
        int result2 = LinearSearch(data, search2);
        Console.WriteLine($"Поиск {search2}: результат = {result2} (ожидается -1)");
        
        // Тест 3: Поиск первого элемента
        int search3 = 3;
        int result3 = LinearSearch(data, search3);
        Console.WriteLine($"Поиск {search3}: результат = {result3} (ожидается 0)");
        
        // Тест 4: Поиск последнего элемента
        int search4 = 5;
        int result4 = LinearSearch(data, search4);
        Console.WriteLine($"Поиск {search4}: результат = {result4} (ожидается 8)");
    }
}
