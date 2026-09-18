using System;

class Program
{
    static void Main()
    {
        (int, string, char, string, ulong) tuple = (42, "привет", 'A', "мир", 18000000000000000000UL);

        Console.WriteLine($"Item1 = {tuple.Item1}");
        Console.WriteLine($"Item2 = {tuple.Item2}");
        Console.WriteLine($"Item3 = {tuple.Item3}");
        Console.WriteLine($"Item4 = {tuple.Item4}");
        Console.WriteLine($"Item5 = {tuple.Item5}");
    }
}