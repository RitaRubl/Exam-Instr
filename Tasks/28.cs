//Разработать класс для хранения данных о товаре в строительном магазине. Используя созданный класс, смоделировать работу приложения хранения данных о товаре в строительном магазине. Загрузить проект в отдельный репозиторий с названием, совпадающим с названием проекта.
using System;

// Класс для хранения данных о товаре в строительном магазине
public class ConstructionProduct
{
    // Поля класса
    public string Name;           // Название товара
    public string Category;       // Категория (инструменты, материалы и т.д.)
    public double Price;          // Цена
    public int Quantity;          // Количество на складе
    public string Manufacturer;   // Производитель
    
    // Конструктор класса
    public ConstructionProduct(string name, string category, double price, 
                              int quantity, string manufacturer)
    {
        Name = name;
        Category = category;
        Price = price;
        Quantity = quantity;
        Manufacturer = manufacturer;
    }
    
    // Метод для вывода информации о товаре
    public void PrintProductInfo()
    {
        Console.WriteLine($"Товар: {Name}");
        Console.WriteLine($"Категория: {Category}");
        Console.WriteLine($"Производитель: {Manufacturer}");
        Console.WriteLine($"Цена: {Price}$");
        Console.WriteLine($"На складе: {Quantity} шт.");
        Console.WriteLine("---------------------");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("СТРОИТЕЛЬНЫЙ МАГАЗИН\n");
        
        // Создаем товары
        ConstructionProduct product1 = new ConstructionProduct(
            "Молоток", "Инструменты", 15.99, 50, "Bosch");
            
        ConstructionProduct product2 = new ConstructionProduct(
            "Цемент", "Стройматериалы", 8.50, 200, "Lafarge");
            
        ConstructionProduct product3 = new ConstructionProduct(
            "Кирпич", "Стройматериалы", 0.75, 1000, "Wienerberger");
        
        // Выводим информацию о товарах
        Console.WriteLine("КАТАЛОГ ТОВАРОВ:\n");
        
        product1.PrintProductInfo();
        product2.PrintProductInfo();
        product3.PrintProductInfo();
        
        // Подсчитываем общую стоимость товаров на складе
        double totalValue = (product1.Price * product1.Quantity) +
                          (product2.Price * product2.Quantity) +
                          (product3.Price * product3.Quantity);
        
        Console.WriteLine($"ОБЩАЯ СТОИМОСТЬ ТОВАРОВ НА СКЛАДЕ: {totalValue}$");
        
        Console.WriteLine("\nНажмите любую клавишу...");
        Console.ReadKey();
    }
}
