using System;

class Program
{
    static void Main()
    {
        // 1. Сортировка целых чисел
        int[] nums = { 5, 2, 8, 1, 3 };
        Sort(nums);
        
        // 2. Сортировка строк
        string[] words = { "яблоко", "банан", "апельсин" };
        Sort(words);
        
        // Вывод результатов
        Console.WriteLine(string.Join(", ", nums));
        Console.WriteLine(string.Join(", ", words));
    }
    
    /// <summary>
    /// Обобщенный метод сортировки
    /// where T : IComparable<T> - ограничение: тип T должен реализовывать интерфейс IComparable
    /// Это позволяет использовать метод CompareTo() для сравнения элементов
    /// </summary>
    public static void Sort<T>(T[] arr) where T : IComparable<T>
    {
        // Вложенные циклы для сравнения всех пар элементов
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                // Сравниваем два элемента
                // arr[i].CompareTo(arr[j]) возвращает:
                // > 0 - если arr[i] больше arr[j]
                // = 0 - если равны
                // < 0 - если arr[i] меньше arr[j]
                if (arr[i].CompareTo(arr[j]) > 0)
                {
                    // Если arr[i] больше arr[j], меняем их местами
                    T temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
}
