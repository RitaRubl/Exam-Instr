//Реализовать класс Student. У класса должны быть следующие
//приватные поля:
//− String name – имя студента
//− String surname – фамилия студента
//− int[] grades – последние 10 оценок студента.
//Необходимо реализовать класс StudentService. У класса должны быть
//реализованы следующие публичные методы:
//− bestStudent() – принимает массив студентов (класс Student), возвращает
//лучшего студента (студент, который имеет самый высокий средний
//балл). Если таких несколько – вывести любого.
//− sortBySurname() – принимает массив студентов (класс Student) и
//сортирует его по фамилии.
//Загрузить проект в отдельный репозиторий с названием, совпадающим
//с названием проекта

using System;

// Класс Student
public class Student
{
    private string name;
    private string surname;
    private int[] grades = new int[10];
    private int count = 0;
    
    public Student(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
    }
    
    public string GetName() => name;
    public string GetSurname() => surname;
    
    public void AddGrade(int grade)
    {
        if (count < 10)
        {
            grades[count] = grade;
            count++;
        }
        else
        {
            for (int i = 0; i < 9; i++)
                grades[i] = grades[i + 1];
            grades[9] = grade;
        }
    }
    
    public double GetAverage()
    {
        if (count == 0) return 0;
        int sum = 0;
        for (int i = 0; i < count; i++)
            sum += grades[i];
        return (double)sum / count;
    }
}

// Класс StudentService
public class StudentService
{
    // Метод для поиска лучшего студента
    public Student BestStudent(Student[] students)
    {
        if (students.Length == 0) return null;
        
        Student best = students[0];
        for (int i = 1; i < students.Length; i++)
        {
            if (students[i].GetAverage() > best.GetAverage())
                best = students[i];
        }
        return best;
    }
    
    // Метод для сортировки по фамилии
    public void SortBySurname(Student[] students)
    {
        for (int i = 0; i < students.Length - 1; i++)
        {
            for (int j = 0; j < students.Length - i - 1; j++)
            {
                // Сравниваем фамилии с помощью CompareTo()
                if (students[j].GetSurname().CompareTo(students[j + 1].GetSurname()) > 0)
                {
                    // Меняем местами
                    Student temp = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = temp;
                }
            }
        }
    }
}

// Программа
class Program
{
    static void Main()
    {
        // Создаем студентов
        Student[] students = {
            new Student("Иван", "Петров"),
            new Student("Мария", "Иванова"),
            new Student("Алексей", "Сидоров")
        };
        
        // Добавляем оценки
        students[0].AddGrade(5); students[0].AddGrade(4);
        students[1].AddGrade(3); students[1].AddGrade(5);
        students[2].AddGrade(5); students[2].AddGrade(5);
        
        // Используем сервис
        StudentService service = new StudentService();
        
        // Находим лучшего
        Student best = service.BestStudent(students);
        Console.WriteLine($"Лучший студент: {best.GetSurname()} {best.GetName()}");
        
        // Сортируем по фамилии
        service.SortBySurname(students);
        Console.WriteLine("\nОтсортировано по фамилии:");
        foreach (var student in students)
            Console.WriteLine(student.GetSurname() + " " + student.GetName());
    }
}
