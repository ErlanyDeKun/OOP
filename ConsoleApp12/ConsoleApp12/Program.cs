using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string[] fruits = { "яблоко", "банан", "вишня", "груша", "слива" };

        Console.WriteLine("Содержимое массива:");
        for (int i = 0; i < fruits.Length; i++)
            Console.WriteLine($"  [{i}] {fruits[i]}");

        Console.WriteLine($"\nДлина массива: {fruits.Length}");

        Console.Write("\nВведите позицию для замены (0..4): ");
        int pos = int.Parse(Console.ReadLine());

        Console.Write("Введите новое значение: ");
        string value = Console.ReadLine();

        fruits[pos] = value;

        Console.WriteLine("\nМассив после замены:");
        for (int i = 0; i < fruits.Length; i++)
            Console.WriteLine($"  [{i}] {fruits[i]}");
    }
}