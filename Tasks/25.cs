//Разработать класс для хранения данных о пользователе туристического агентства. Используя созданный класс, смоделировать работу приложения туристического агентства. Загрузить проект в отдельный репозиторий с названием, совпадающим с названием проекта.
using System;

public class Tourist
{
    // Поля класса
    public string Name;
    public string Surname;
    public int Age;
    public string Destination;
    public double Budget;
    public int TravelDays; // Длительность поездки
    
    // Конструктор
    public Tourist(string name, string surname, int age, string destination, double budget, int days)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Destination = destination;
        Budget = budget;
        TravelDays = days;
    }
    
    // Метод для расчета стоимости дня
    public double GetCostPerDay()
    {
        return Budget / TravelDays;
    }
    
    // Метод для проверки бюджета
    public bool IsBudgetEnough(double minBudget)
    {
        return Budget >= minBudget;
    }
    
    // Метод для вывода информации
    public void PrintInfo()
    {
        Console.WriteLine($"Турист: {Surname} {Name}, {Age} лет");
        Console.WriteLine($"Поездка: {Destination}, {TravelDays} дней");
        Console.WriteLine($"Бюджет: {Budget}$ ({GetCostPerDay():F2}$/день)");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("ТУРИСТИЧЕСКОЕ АГЕНТСТВО");
        Console.WriteLine("=======================\n");
        
        // Создаем базу туристов
        Tourist[] tourists = {
            new Tourist("Иван", "Петров", 25, "Испания", 1500, 10),
            new Tourist("Мария", "Иванова", 30, "Италия", 2000, 14),
            new Tourist("Алексей", "Сидоров", 22, "Греция", 1200, 7)
        };
        
        // Выводим информацию
        Console.WriteLine("Зарегистрированные туристы:");
        Console.WriteLine("---------------------------");
        
        for (int i = 0; i < tourists.Length; i++)
        {
            Console.WriteLine($"\nТурист #{i + 1}:");
            tourists[i].PrintInfo();
        }
        
        // Проверяем бюджеты
        Console.WriteLine("\n\nПроверка бюджетов:");
        Console.WriteLine("-----------------");
        double requiredBudget = 1000; // Минимальный бюджет
        
        foreach (Tourist t in tourists)
        {
            string status = t.IsBudgetEnough(requiredBudget) ? "✓ Достаточно" : "✗ Недостаточно";
            Console.WriteLine($"{t.Surname}: {t.Budget}$ - {status}");
        }
        
        Console.WriteLine("\nНажмите любую клавишу...");
        Console.ReadKey();
    }
}
