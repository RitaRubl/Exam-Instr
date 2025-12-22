//Разработать класс для хранения данных об автомобилях, находящихся в таксопарке. Используя созданный класс, смоделировать работу приложения. Загрузить проект в отдельный репозиторий с названием, совпадающим с названием проекта.
using System;

// Класс для хранения данных об автомобиле в таксопарке
public class TaxiCar
{
    // Поля класса
    public string Model;          // Модель автомобиля
    public string LicensePlate;   // Госномер
    public int Year;              // Год выпуска
    public string Color;          // Цвет
    public double Mileage;        // Пробег (км)
    public bool IsAvailable;      // Свободен ли
    
    // Конструктор класса
    public TaxiCar(string model, string licensePlate, int year, 
                   string color, double mileage)
    {
        Model = model;
        LicensePlate = licensePlate;
        Year = year;
        Color = color;
        Mileage = mileage;
        IsAvailable = true; // При добавлении автомобиль свободен
    }
    
    // Метод для начала поездки
    public void StartTrip()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"{Model} ({LicensePlate}) начал поездку");
        }
        else
        {
            Console.WriteLine($"{Model} ({LicensePlate}) уже в рейсе!");
        }
    }
    
    // Метод для завершения поездки
    public void EndTrip(double distanceKm)
    {
        IsAvailable = true;
        Mileage += distanceKm;
        Console.WriteLine($"{Model} ({LicensePlate}) завершил поездку на {distanceKm} км");
    }
    
    // Метод для вывода информации об автомобиле
    public void PrintCarInfo()
    {
        Console.WriteLine($"Модель: {Model}");
        Console.WriteLine($"Госномер: {LicensePlate}");
        Console.WriteLine($"Год: {Year}");
        Console.WriteLine($"Цвет: {Color}");
        Console.WriteLine($"Пробег: {Mileage} км");
        Console.WriteLine($"Статус: {(IsAvailable ? "Свободен" : "В рейсе")}");
        Console.WriteLine("---------------------");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("ТАКСОПАРК\n");
        
        // Создаем автомобили таксопарка
        TaxiCar car1 = new TaxiCar("Toyota Camry", "А123БВ", 2020, "Белый", 45000);
        TaxiCar car2 = new TaxiCar("Kia Rio", "В456ГД", 2021, "Серый", 32000);
        TaxiCar car3 = new TaxiCar("Hyundai Solaris", "Е789ЖЗ", 2019, "Черный", 58000);
        
        // Выводим информацию об автомобилях
        Console.WriteLine("АВТОМОБИЛИ ТАКСОПАРКА:\n");
        
        car1.PrintCarInfo();
        car2.PrintCarInfo();
        car3.PrintCarInfo();
        
        // Симуляция поездок
        Console.WriteLine("СИМУЛЯЦИЯ ПОЕЗДОК:");
        Console.WriteLine("------------------");
        
        car1.StartTrip();
        car2.StartTrip();
        car1.EndTrip(15.5); // Завершаем поездку на 15.5 км
        car3.StartTrip();
        car2.EndTrip(22.3); // Завершаем поездку на 22.3 км
        
        // Обновленная информация
        Console.WriteLine("\nОБНОВЛЕННАЯ ИНФОРМАЦИЯ:");
        car1.PrintCarInfo();
        car2.PrintCarInfo();
        car3.PrintCarInfo();
        
        // Статистика
        Console.WriteLine("\nСТАТИСТИКА ТАКСОПАРКА:");
        Console.WriteLine($"Всего автомобилей: 3");
        Console.WriteLine($"Свободно: {(car1.IsAvailable ? 1 : 0) + (car2.IsAvailable ? 1 : 0) + (car3.IsAvailable ? 1 : 0)}");
        Console.WriteLine($"В рейсе: {(car1.IsAvailable ? 0 : 1) + (car2.IsAvailable ? 0 : 1) + (car3.IsAvailable ? 0 : 1)}");
        
        Console.WriteLine("\nНажмите любую клавишу...");
        Console.ReadKey();
    }
}
