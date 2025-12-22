// Реализовать класс Student. У класса должны быть следующие
//приватные поля:
//− String name – имя студента.
//− String surname – фамилия студента.
//− int[] grades – последние 10 оценок студента.
//Их может быть меньше, но не может быть больше 10.
//И следующие публичные методы:
//− Getter и setter-методы для name.
//− Getter и setter-методы для surname.
//− Getter и setter-методы для grades.
//− метод, добавляющий новую оценку в grades. Самая первая оценка
//должна быть удалена, новая должна сохраниться в конце массива (т.е.
//массив должен сдвинуться на 1 влево).
//− метод, возвращающий средний балл студента (рассчитывается как
//среднее арифметическое от всех оценок в массиве grades).
//Загрузить проект в отдельный репозиторий с названием, совпадающим
//с названием проекта.


using System;

public class Student
{
    private string name;
    private string surname;
    private int[] grades;
    private int count;
    
    public Student(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
        grades = new int[10];
        count = 0;
    }
    
    // Getter и Setter для имени
    public string GetName() => name;
    public void SetName(string newName) => name = newName;
    
    // Getter и Setter для фамилии
    public string GetSurname() => surname;
    public void SetSurname(string newSurname) => surname = newSurname;
    
    // Getter и Setter для оценок
    public int[] GetGrades()
    {
        int[] result = new int[count];
        Array.Copy(grades, result, count);
        return result;
    }
    
    public void SetGrades(int[] newGrades)
    {
        if (newGrades.Length <= 10)
        {
            Array.Copy(newGrades, grades, newGrades.Length);
            count = newGrades.Length;
        }
    }
    
    // Добавление новой оценки
    public void AddGrade(int grade)
    {
        if (count < 10)
        {
            grades[count] = grade;
            count++;
        }
        else
        {
            // Сдвигаем оценки влево
            for (int i = 0; i < 9; i++)
                grades[i] = grades[i + 1];
            
            grades[9] = grade;
        }
    }
    
    // Средний балл
    public double GetAverage()
    {
        if (count == 0) return 0;
        
        int sum = 0;
        for (int i = 0; i < count; i++)
            sum += grades[i];
        
        return (double)sum / count;
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Иван", "Иванов");
        
        // Добавляем оценки
        student.AddGrade(5);
        student.AddGrade(4);
        student.AddGrade(5);
        
        // Выводим средний балл
        Console.WriteLine($"Средний балл: {student.GetAverage():F2}");
    }
}
