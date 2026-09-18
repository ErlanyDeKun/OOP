using System;

class Program
{
    static void Main()
    {
        (int, string, char, string, ulong) tuple = (42, "привет", 'A', "мир", 18000000000000000000UL);

        Console.WriteLine($"Целиком: {tuple}");

        Console.WriteLine($"Выборочно (1, 3, 4): {tuple.Item1}, {tuple.Item3}, {tuple.Item4}");
    }
}