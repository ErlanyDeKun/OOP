using System;

class Program
{
    static void Main()
    {
        var array = new[] { 1, 2, 3, 4, 5 };

        var str = "Привет, мир!";

        Console.WriteLine($"Массив: {string.Join(", ", array)}");
        Console.WriteLine($"Тип массива: {array.GetType().Name}");
        Console.WriteLine($"Строка: {str}");
        Console.WriteLine($"Тип строки: {str.GetType().Name}");
    }
}