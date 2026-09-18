using System;

class Program
{
    static void Main()
    {
        var i = 42;
        var d = 3.14; 
        var m = 9.99m;
        var c = 'A'; 
        var b = true;   
        var s = "привет";  

        Console.WriteLine($"{i} — {i.GetType().Name}");
        Console.WriteLine($"{d} — {d.GetType().Name}");
        Console.WriteLine($"{m} — {m.GetType().Name}");
        Console.WriteLine($"{c} — {c.GetType().Name}");
        Console.WriteLine($"{b} — {b.GetType().Name}");
        Console.WriteLine($"{s} — {s.GetType().Name}");
    }
}