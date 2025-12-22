//Реализовать класс Cat. У класса должны быть реализованы
//следующие приватные методы:
//− sleep() – выводит на экран «Sleep»
//− meow() – выводит на экран «Meow»
//− eat() – выводит на экран «Eat»
//И публичный метод:
//− status() – вызывает один из приватных методов случайным образом.
//Загрузить проект в отдельный репозиторий с названием, совпадающим
//с названием проекта.
using System;

// Класс Cat (Кот)
public class Cat
{
    // Приватный метод: кот спит
    private void Sleep()
    {
        Console.WriteLine("Sleep");
    }

    // Приватный метод: кот мяукает
    private void Meow()
    {
        Console.WriteLine("Meow");
    }

    // Приватный метод: кот ест
    private void Eat()
    {
        Console.WriteLine("Eat");
    }

    // Публичный метод: получаем случайный статус кота
    public void Status()
    {
        // Создаем генератор случайных чисел
        Random random = new Random();

        // Генерируем случайное число от 0 до 2
        int randomNumber = random.Next(0, 3);

        // Вызываем один из приватных методов в зависимости от случайного числа
        if (randomNumber == 0)
        {
            Sleep();    // Если 0 - кот спит
        }
        else if (randomNumber == 1)
        {
            Meow();     // Если 1 - кот мяукает
        }
        else
        {
            Eat();      // Если 2 - кот ест
        }
    }
}

class Program
{
    static void Main()
    {
        // Создаем объект класса Cat
        Cat myCat = new Cat();

        Console.WriteLine("Программа: Статус кота");
        Console.WriteLine("======================\n");

        // Проверяем статус кота несколько раз
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Попытка {i}: ");
            myCat.Status(); // Вызываем публичный метод Status
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
