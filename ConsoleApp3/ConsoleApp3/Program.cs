using System;

class Boxing
{
    static void Main()
    {
        int i = 42; object oi = i;
        double d = 3.14; object od = d;
        char c = 'A'; object oc = c;
        bool b = true; object ob = b;
        decimal m = 9.99m; object om = m;

        Console.WriteLine("Упаковка:");
        Console.WriteLine($"{oi} {od} {oc} {ob} {om}");

        int i2 = (int)oi;
        double d2 = (double)od;
        char c2 = (char)oc;
        bool b2 = (bool)ob;
        decimal m2 = (decimal)om;

        Console.WriteLine("Распаковка:");
        Console.WriteLine($"{i2} {d2} {c2} {b2} {m2}");
    }
}