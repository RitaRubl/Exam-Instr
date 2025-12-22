//Разработать класс для хранения данных о покупателе магазина ювелирных украшений. Используя созданный класс, смоделировать работу приложения магазина ювелирных украшений. Загрузить проект в отдельный репозиторий с названием, совпадающим с названием проекта.

using System;

// Класс для хранения данных о покупателе
public class JewelryCustomer
{
    // Поля класса
    public string Name;          // Имя покупателя
    public string Surname;       // Фамилия покупателя
    public string Phone;         // Телефон
    public string Product;       // Название украшения
    public double Price;         // Цена украшения
    public bool IsGold;          // Из золота ли украшение
    
    // Конструктор - создает объект покупателя
    public JewelryCustomer(string name, string surname, string phone, 
                          string product, double price, bool isGold)
    {
        Name = name;
        Surname = surname;
        Phone = phone;
        Product = product;
        Price = price;
        IsGold = isGold;
    }
    
    // Метод для вывода информации о покупке
    public void PrintReceipt()
    {
        Console.WriteLine($"ЧЕК НА ПРОДАЖУ");
        Console.WriteLine($"Покупатель: {Surname} {Name}");
        Console.WriteLine($"Телефон: {Phone}");
        Console.WriteLine($"Украшение: {Product}");
        Console.WriteLine($"Цена: {Price}$");
        Console.WriteLine($"Материал: {(IsGold ? "Золото" : "Серебро")}");
        Console.WriteLine("-----------------------");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("МАГАЗИН ЮВЕЛИРНЫХ УКРАШЕНИЙ\n");
        
        // Создаем покупателей
        JewelryCustomer customer1 = new JewelryCustomer("Анна", "Петрова", 
            "+7-900-123-45-67", "Кольцо с сапфиром", 850.50, true);
            
        JewelryCustomer customer2 = new JewelryCustomer("Игорь", "Сидоров", 
            "+7-901-234-56-78", "Серебряная цепочка", 320.00, false);
            
        JewelryCustomer customer3 = new JewelryCustomer("Ольга", "Иванова", 
            "+7-902-345-67-89", "Золотые серьги", 1250.75, true);
        
        // Выводим чеки
        Console.WriteLine("ПРОДАЖИ ЗА ДЕНЬ:\n");
        
        customer1.PrintReceipt();
        Console.WriteLine();
        
        customer2.PrintReceipt();
        Console.WriteLine();
        
        customer3.PrintReceipt();
        
        // Подсчитываем итоги
        double totalGold = 0;
        double totalSilver = 0;
        
        if (customer1.IsGold) totalGold += customer1.Price;
        else totalSilver += customer1.Price;
        
        if (customer2.IsGold) totalGold += customer2.Price;
        else totalSilver += customer2.Price;
        
        if (customer3.IsGold) totalGold += customer3.Price;
        else totalSilver += customer3.Price;
        
        Console.WriteLine($"ИТОГО:");
        Console.WriteLine($"Продажи золотых украшений: {totalGold}$");
        Console.WriteLine($"Продажи серебряных украшений: {totalSilver}$");
        Console.WriteLine($"Общая выручка: {totalGold + totalSilver}$");
        
        Console.WriteLine("\nНажмите любую клавишу...");
        Console.ReadKey();
    }
}
