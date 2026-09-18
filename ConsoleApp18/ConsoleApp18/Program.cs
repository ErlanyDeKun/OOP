using System;

class Program
{
    static void Main()
    {
        var t1 = (1, "привет", 'A', "мир", 100UL);
        var t2 = (1, "привет", 'A', "мир", 100UL);

        Console.WriteLine($"t1 == t2 : {t1 == t2}"); 
        Console.WriteLine($"t1 != t2 : {t1 != t2}");   

        var t3 = (2, "привет", 'A', "мир", 100UL);
        Console.WriteLine($"\nt1 == t3 : {t1 == t3}");  
        Console.WriteLine($"t1 != t3 : {t1 != t3}");    

        var a = (X: 5, Y: 10);
        var b = (Y: 5, X: 10);
        Console.WriteLine($"\na == b : {a == b}");   
        Console.WriteLine($"a != b : {a != b}");     

        (int, byte) left = (5, 10);
        (long, int) right = (5, 10);
        Console.WriteLine($"\nleft == right : {left == right}");

        var t4 = (1, "привет", 'A', "мир", 100UL);
        Console.WriteLine("\nПокомпонентно:");
        Console.WriteLine($"Item1: {t1.Item1 == t4.Item1}");
        Console.WriteLine($"Item2: {t1.Item2 == t4.Item2}");
        Console.WriteLine($"Item3: {t1.Item3 == t4.Item3}");
        Console.WriteLine($"Item4: {t1.Item4 == t4.Item4}");
        Console.WriteLine($"Item5: {t1.Item5 == t4.Item5}");
    }
}