using System;

class Program
{
    static void Main()
    {
        int? a = 42;     
        int? b = null;     
        double? d = 3.14;
        bool? bo = null;

        Console.WriteLine($"a = {a}, HasValue = {a.HasValue}, Value = {a.Value}");
        Console.WriteLine($"b = {b}, HasValue = {b.HasValue}");

        try { int x = b.Value; }
        catch (InvalidOperationException e) { Console.WriteLine($"Ошибка: {e.Message}"); }

        Console.WriteLine($"b.GetValueOrDefault() = {b.GetValueOrDefault()}");
        Console.WriteLine($"b.GetValueOrDefault(-1) = {b.GetValueOrDefault(-1)}");

        Console.WriteLine($"a ?? -1 = {a ?? -1}");
        Console.WriteLine($"b ?? -1 = {b ?? -1}");
        b ??= 100;
        Console.WriteLine($"b после ??= 100: {b}");

        object o1 = a;   
        object o2 = b;   
        Console.WriteLine($"o1 = {o1} ({o1.GetType().Name}), o2 = {o2 ?? "null"}");
    }
}