using System;

class Program
{
    static void Main()
    {
        double[][] a = new double[3][];
        a[0] = new double[2];
        a[1] = new double[3];
        a[2] = new double[4];

        for (int i = 0; i < a.Length; i++)
            for (int j = 0; j < a[i].Length; j++)
            {
                Console.Write($"a[{i}][{j}] = ");
                a[i][j] = double.Parse(Console.ReadLine());
            }

        Console.WriteLine("\nМассив:");
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
                Console.Write($"{a[i][j],8}");
            Console.WriteLine();
        }
    }
}