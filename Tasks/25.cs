//Разработать класс для хранения данных о пользователе туристического агентства. Используя созданный класс, смоделировать работу приложения туристического агентства. Загрузить проект в отдельный репозиторий с названием, совпадающим с названием проекта.
using System;

// Класс для хранения данных о пользователе туристического агентства
public class Tourist
{
    // Поля класса - данные о туристе
    public string Name;       // Имя туриста
    public string Surname;    // Фамилия туриста
    public int Age;           // Возраст
    public string Destination; // Страна назначения
    public double Budget;     // Бюджет на поездку
    
    // Конструктор класса - создает объект Tourist
    public Tourist(string name, string surname, int age, string destination, double budget)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Destination = destination;
        Budget = budget;
    }
    
    // Метод для вывода информации о туристе
    public void PrintInfo()
    {
        Console.WriteLine($"Турист: {Surname} {Name}");
        Console.WriteLine($"Возраст: {Age}");
        Console.WriteLine($"Направление: {Destination}");
        Console.WriteLine($"Бюджет: {Budget}$");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Туристическое агентство\n");
        
        // Создаем туристов
        Tourist tourist1 = new Tourist("Иван", "Петров", 25, "Испания", 1500);
        Tourist tourist2 = new Tourist("Мария", "Иванова", 30, "Италия", 2000);
        Tourist tourist3 = new Tourist("Алексей", "Сидоров", 22, "Греция", 1200);
        
        // Выводим информацию о туристах
        Console.WriteLine("Список туристов:");
        Console.WriteLine("================\n");
        
        tourist1.PrintInfo();
        Console.WriteLine();
        
        tourist2.PrintInfo();
        Console.WriteLine();
        
        tourist3.PrintInfo();
        
        Console.WriteLine("\nНажмите любую клавишу...");
        Console.ReadKey();
    }
}
