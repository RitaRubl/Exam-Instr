//Реализуйте поиск наибольшего элемента в двумерном массиве с помощью метода compareTo() интерфейса Comparable.
using System;

class Program
{
    static void Main()
    {
        // Создаем двумерный массив целых чисел 3x3
        int[,] matrix = {
            { 5, 8, 3 },
            { 9, 2, 7 },
            { 4, 1, 6 }
        };
        
        // Выводим массив на экран
        Console.WriteLine("Двумерный массив:");
        PrintMatrix(matrix);
        
        // Находим наибольший элемент
        int max = FindMaxInMatrix(matrix);
        
        // Выводим результат
        Console.WriteLine($"\nНаибольший элемент в массиве: {max}");
        
        Console.ReadKey();
    }
    
    /// <summary>
    /// Метод для поиска наибольшего элемента в двумерном массиве
    /// Использует метод CompareTo() для сравнения элементов
    /// </summary>
    /// <param name="matrix">Двумерный массив</param>
    /// <returns>Наибольший элемент массива</returns>
    public static int FindMaxInMatrix(int[,] matrix)
    {
        // Проверяем, что массив не пустой
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
        {
            throw new ArgumentException("Массив не может быть пустым");
        }
        
        // Предполагаем, что первый элемент (0,0) - наибольший
        int max = matrix[0, 0];
        
        // Проходим по всем строкам массива
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            // Проходим по всем столбцам массива
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                // Используем CompareTo() для сравнения текущего элемента с максимальным
                // CompareTo() возвращает:
                //   > 0 - если текущий элемент больше максимального
                //   = 0 - если элементы равны
                //   < 0 - если текущий элемент меньше максимального
                if (matrix[i, j].CompareTo(max) > 0)
                {
                    // Если текущий элемент больше максимального, обновляем максимум
                    max = matrix[i, j];
                }
            }
        }
        
        return max;
    }
    
    /// <summary>
    /// Метод для вывода двумерного массива на экран
    /// </summary>
    /// <param name="matrix">Двумерный массив для вывода</param>
    public static void PrintMatrix(int[,] matrix)
    {
        // Получаем размеры массива
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        // Выводим каждый элемент массива
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],3} "); // Выводим элемент с шириной 3 символа
            }
            Console.WriteLine(); // Переход на новую строку после каждой строки массива
        }
    }
}
