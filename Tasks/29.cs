//Разработать класс для хранения данных о животном в питомнике для бездомных животных. Используя созданный класс, смоделировать работу приложения для хранения данных о животном в питомнике для бездомных животных. Загрузить проект в отдельный репозиторий с названием, совпадающим с названием проекта
using System;

// Класс для хранения данных о животном в питомнике
public class ShelterAnimal
{
    // Поля класса
    public string Name;        // Кличка животного
    public string Species;     // Вид (собака, кошка и т.д.)
    public int Age;            // Возраст (в годах)
    public string Breed;       // Порода
    public DateTime ArrivalDate; // Дата поступления
    public bool IsVaccinated;  // Привито ли
    public bool IsAdopted;     // Пристроено ли
    
    // Конструктор класса
    public ShelterAnimal(string name, string species, int age, string breed, 
                        DateTime arrivalDate, bool isVaccinated)
    {
        Name = name;
        Species = species;
        Age = age;
        Breed = breed;
        ArrivalDate = arrivalDate;
        IsVaccinated = isVaccinated;
        IsAdopted = false; // При поступлении животное еще не пристроено
    }
    
    // Метод для пристройства животного
    public void Adopt()
    {
        IsAdopted = true;
    }
    
    // Метод для вывода информации о животном
    public void PrintAnimalInfo()
    {
        Console.WriteLine($"Кличка: {Name}");
        Console.WriteLine($"Вид: {Species}");
        Console.WriteLine($"Возраст: {Age} лет");
        Console.WriteLine($"Порода: {Breed}");
        Console.WriteLine($"Дата поступления: {ArrivalDate:dd.MM.yyyy}");
        Console.WriteLine($"Привито: {(IsVaccinated ? "Да" : "Нет")}");
        Console.WriteLine($"Статус: {(IsAdopted ? "Пристроено" : "Ищет дом")}");
        Console.WriteLine("---------------------");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("ПИТОМНИК ДЛЯ БЕЗДОМНЫХ ЖИВОТНЫХ\n");
        
        // Создаем животных
        ShelterAnimal animal1 = new ShelterAnimal(
            "Барсик", "Кошка", 2, "Дворняга", 
            new DateTime(2023, 10, 15), true);
            
        ShelterAnimal animal2 = new ShelterAnimal(
            "Шарик", "Собака", 3, "Лабрадор", 
            new DateTime(2023, 9, 20), true);
            
        ShelterAnimal animal3 = new ShelterAnimal(
            "Мурка", "Кошка", 1, "Сиамская", 
            new DateTime(2023, 11, 5), false);
        
        // Выводим информацию о животных
        Console.WriteLine("ЖИВОТНЫЕ В ПИТОМНИКЕ:\n");
        
        animal1.PrintAnimalInfo();
        animal2.PrintAnimalInfo();
        animal3.PrintAnimalInfo();
        
        // Пристраиваем одного животного
        animal2.Adopt();
        Console.WriteLine("\nШАРИК ПРИСТРОЕН В ХОРОШИЕ РУКИ!\n");
        
        // Выводим обновленную информацию
        Console.WriteLine("ОБНОВЛЕННЫЙ СПИСОК:");
        animal1.PrintAnimalInfo();
        animal2.PrintAnimalInfo();
        animal3.PrintAnimalInfo();
        
        // Статистика
        Console.WriteLine("\nСТАТИСТИКА ПИТОМНИКА:");
        Console.WriteLine($"Всего животных: 3");
        Console.WriteLine($"Пристроено: 1");
        Console.WriteLine($"Ожидают пристройства: 2");
        
        Console.WriteLine("\nНажмите любую клавишу...");
        Console.ReadKey();
    }
}
