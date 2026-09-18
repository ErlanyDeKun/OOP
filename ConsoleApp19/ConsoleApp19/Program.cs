using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 5, -3, 8, 0, 12, 7, -1 };
        string text = "привет";

        var result = Analyze(numbers, text);

        Console.WriteLine($"Максимум   : {result.max}");
        Console.WriteLine($"Минимум    : {result.min}");
        Console.WriteLine($"Сумма      : {result.sum}");
        Console.WriteLine($"Первая буква: {result.first}");

        (int max, int min, int sum, char first) Analyze(int[] arr, string s)
        {
            int max = arr[0];
            int min = arr[0];
            int sum = 0;

            foreach (int n in arr)
            {
                if (n > max) max = n;
                if (n < min) min = n;
                sum += n;
            }

            char first = s[0];

            return (max, min, sum, first);
        }
    }
}