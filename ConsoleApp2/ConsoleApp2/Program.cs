using System;

class Conversions
{
    static void Main()
    {
        Console.WriteLine("НЕЯВНЫЕ ПРЕОБРАЗОВАНИЯ");
        sbyte a = -100; int b = a;
        int c = 2000000000; long d = c;
        int e = 42; double f = e;
        float g = 3.14f; double h = g;
        char i = 'A'; int j = i;
        Console.WriteLine($"{a} → int: {b}");
        Console.WriteLine($"{c} → long: {d}");
        Console.WriteLine($"{e} → double: {f}");
        Console.WriteLine($"{g} → double: {h}");
        Console.WriteLine($"{i} → int: {j}");

        Console.WriteLine("\nЯВНЫЕ ПРЕОБРАЗОВАНИЯ");
        double a1 = 1234.78; int b1 = (int)a1;
        int c1 = 300; byte d1 = (byte)c1;
        decimal e1 = 9.99m; int f1 = (int)e1;
        long g1 = 100000; short h1 = (short)g1;
        double i1 = 3.14159265358979; float j1 = (float)i1;
        Console.WriteLine($"{a1} → int: {b1}");
        Console.WriteLine($"{c1} → byte: {d1}");
        Console.WriteLine($"{e1} → int: {f1}");
        Console.WriteLine($"{g1} → short: {h1}");
        Console.WriteLine($"{i1} → float: {j1}");
    }
}