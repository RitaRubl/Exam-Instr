//Разработать класс для хранения данных о покупателе магазина спортивной одежды. Используя созданный класс, смоделировать работу приложения магазина спортивной одежды. Загрузить проект в отдельный репозиторий с названием, совпадающим с названием проекта.

using System;

// Класс для хранения данных о покупателе спортивной одежды
public class SportShopCustomer
{
    // Поля класса
    public string Name;          // Имя покупателя
    public string Surname;       // Фамилия покупателя
    public string SportType;     // Вид спорта
    public string Product;       // Наименование товара
    public double Price;         // Цена товара
    public int Size;             // Размер одежды
    
    // Конструктор класса
    public SportShopCustomer(string name, string surname, string sportType,
                            string product, double price, int size)
    {
        Name = name;
        Surname = surname;
        SportType = sportType;
        Product = product;
        Price = price;
        Size = size;
    }
    
    // Метод для вывода информации о покупке
    public void PrintPurchaseInfo()
    {
        Console.WriteLine($"Покупатель: {Surname} {Name}");
        Console.WriteLine($"Вид спорта: {SportType}");
        Console.WriteLine($"Товар: {Product}");
        Console.WriteLine($"Размер: {Size}");
        Console.WriteLine($"Цена: {Price}$");
        Console.WriteLine("---------------------");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("МАГАЗИН СПОРТИВНОЙ ОДЕЖДЫ\n");
        
        // Создаем покупателей
        SportShopCustomer customer1 = new SportShopCustomer(
            "Алексей", "Иванов", "Футбол", "Футбольная форма", 89.99, 48);
            
        SportShopCustomer customer2 = new SportShopCustomer(
            "Мария", "Петрова", "Бег", "Беговые кроссовки", 120.50, 39);
            
        SportShopCustomer customer3 = new SportShopCustomer(
            "Дмитрий", "Сидоров", "Баскетбол", "Баскетбольные шорты", 45.75, 52);
        
        // Выводим информацию о покупках
        Console.WriteLine("ПОКУПКИ ЗА ДЕНЬ:\n");
        
        customer1.PrintPurchaseInfo();
        customer2.PrintPurchaseInfo();
        customer3.PrintPurchaseInfo();
        
        // Подсчитываем статистику
        double totalRevenue = customer1.Price + customer2.Price + customer3.Price;
        
        Console.WriteLine($"\nИТОГИ ДНЯ:");
        Console.WriteLine($"Количество покупок: 3");
        Console.WriteLine($"Общая выручка: {totalRevenue}$");
        
        Console.WriteLine("\nНажмите любую клавишу...");
        Console.ReadKey();
    }
}
